﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Security.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Handlers;
    using System.Management.Automation;

    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// The version for current assembly.
        private static AssemblyName AssemblyInfo = typeof(ConnectMgGraph).GetTypeInfo().Assembly.GetName();

        /// The value for the Auth module version header.
        private static string AuthModuleVersionHeaderValue =
            string.Format(Constants.SDKHeaderValue,
                AssemblyInfo.Version.Major,
                AssemblyInfo.Version.Minor,
                AssemblyInfo.Version.Build);

        /// <summary>
        /// Prepends SDK header to an HTTP client.
        /// </summary>
        /// <param name="httpClient"></param>
        private static void PrependSDKHeader(HttpClient httpClient, string headerName, string headerValue)
        {
            httpClient.DefaultRequestHeaders.TryGetValues(headerName, out IEnumerable<string> previousSDKHeaders);
            if (previousSDKHeaders == null) {
                httpClient.DefaultRequestHeaders.Add(headerName, headerValue);
            } else {
                httpClient.DefaultRequestHeaders.Remove(headerName);
                httpClient.DefaultRequestHeaders.Add(headerName, previousSDKHeaders.Prepend(headerValue));
            }
        }

        public static HttpClient GetGraphHttpClient(InvocationInfo invocationInfo, IAuthContext authContext = null)
        {
            authContext = authContext ?? GraphSession.Instance.AuthContext;
            if (authContext is null) { throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext); }
            var httpClient = GetGraphHttpClient(authContext);
            var requestUserAgent = new RequestUserAgent(authContext.PSHostVersion, invocationInfo);
            PrependSDKHeader(httpClient, HttpKnownHeaderNames.UserAgent, requestUserAgent.UserAgent);
            return httpClient;
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="authContext"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthContext authContext = null)
        {
            authContext = authContext ?? GraphSession.Instance.AuthContext;
            if (authContext is null)
            {
                throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext);
            }

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authContext);
            return GetGraphHttpClient(authProvider);
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// with an <see cref="IAuthenticationProvider"/>
        /// </summary>
        /// <param name="authProvider">Custom AuthProvider</param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthenticationProvider authProvider)
        {
            IList<DelegatingHandler> defaultHandlers = GraphClientFactory.CreateDefaultHandlers(authProvider);

            // Register NationalCloudHandler after AuthHandler.
            defaultHandlers.Insert(1, new NationalCloudHandler());
            // Register ODataQueryOptionsHandler after NationalCloudHandler.
            defaultHandlers.Insert(2, new ODataQueryOptionsHandler());

            HttpClient httpClient = GraphClientFactory.Create(defaultHandlers);

            // Prepend SDKVersion header
            PrependSDKHeader(httpClient, CoreConstants.Headers.SdkVersionHeaderName, AuthModuleVersionHeaderValue);
            return httpClient;
        }
    }
}
