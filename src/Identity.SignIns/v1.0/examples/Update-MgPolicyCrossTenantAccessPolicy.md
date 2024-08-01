### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	allowedCloudEndpoints = @(
		"microsoftonline.us"
	)
}

Update-MgPolicyCrossTenantAccessPolicy -BodyParameter $params
```
This example shows how to use the Update-MgPolicyCrossTenantAccessPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

