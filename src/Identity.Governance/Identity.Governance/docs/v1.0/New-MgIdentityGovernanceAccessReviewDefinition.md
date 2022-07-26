---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgidentitygovernanceaccessreviewdefinition
schema: 2.0.0
---

# New-MgIdentityGovernanceAccessReviewDefinition

## SYNOPSIS
Create new navigation property to definitions for identityGovernance

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgIdentityGovernanceAccessReviewDefinition
 [-AdditionalNotificationRecipients <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>]
 [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphUserIdentity>] [-CreatedDateTime <DateTime>]
 [-DescriptionForAdmins <String>] [-DescriptionForReviewers <String>] [-DisplayName <String>]
 [-FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>] [-Id <String>]
 [-InstanceEnumerationScope <Hashtable>] [-Instances <IMicrosoftGraphAccessReviewInstance1[]>]
 [-LastModifiedDateTime <DateTime>] [-Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]
 [-Scope <Hashtable>] [-Settings <IMicrosoftGraphAccessReviewScheduleSettings1>]
 [-StageSettings <IMicrosoftGraphAccessReviewStageSettings1[]>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter <IMicrosoftGraphAccessReviewScheduleDefinition1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to definitions for identityGovernance

## EXAMPLES

## PARAMETERS

### -AdditionalNotificationRecipients
Defines the list of additional users or group members to be notified of the access review progress.
To construct, please use Get-Help -Online and see NOTES section for ADDITIONALNOTIFICATIONRECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewNotificationRecipientItem[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessReviewScheduleDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScheduleDefinition1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
userIdentity
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserIdentity
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Timestamp when the access review series was created.
Supports $select.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DescriptionForAdmins
Description provided by review creators to provide more context of the review to admins.
Supports $select.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DescriptionForReviewers
Description provided by review creators to provide more context of the review to reviewers.
Reviewers will see this description in the email sent to them requesting their review.
Email notifications support up to 256 characters.
Supports $select.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the access review series.
Supports $select and $orderBy.
Required on create.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FallbackReviewers
This collection of reviewer scopes is used to define the list of fallback reviewers.
These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified.
This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.
See accessReviewReviewerScope.
Replaces backupReviewers.
Supports $select.
NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.
To construct, please use Get-Help -Online and see NOTES section for FALLBACKREVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewerScope1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceEnumerationScope
accessReviewScope

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Instances
Set of access reviews instances for this access review series.
Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
To construct, please use Get-Help -Online and see NOTES section for INSTANCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewInstance1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Timestamp when the access review series was last modified.
Supports $select.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reviewers
This collection of access review scopes is used to define who are the reviewers.
The reviewers property is only updatable if individual users are assigned as reviewers.
Required on create.
Supports $select.
For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.
To construct, please use Get-Help -Online and see NOTES section for REVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewerScope1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
accessReviewScope

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
accessReviewScheduleSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScheduleSettings1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StageSettings
Required only for a multi-stage access review to define the stages and their settings.
You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings.
Stages will be created sequentially based on the dependsOn property.
Optional.
When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.
To construct, please use Get-Help -Online and see NOTES section for STAGESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewStageSettings1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
This read-only field specifies the status of an access review.
The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.
Supports $select, $orderby, and $filter (eq only).
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScheduleDefinition1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScheduleDefinition1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDITIONALNOTIFICATIONRECIPIENTS <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>: Defines the list of additional users or group members to be notified of the access review progress.
  - `[NotificationRecipientScope <IMicrosoftGraphAccessReviewNotificationRecipientScope>]`: accessReviewNotificationRecipientScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[NotificationTemplateType <String>]`: Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.

BODYPARAMETER <IMicrosoftGraphAccessReviewScheduleDefinition1>: accessReviewScheduleDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AdditionalNotificationRecipients <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>]`: Defines the list of additional users or group members to be notified of the access review progress.
    - `[NotificationRecipientScope <IMicrosoftGraphAccessReviewNotificationRecipientScope>]`: accessReviewNotificationRecipientScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NotificationTemplateType <String>]`: Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[CreatedDateTime <DateTime?>]`: Timestamp when the access review series was created. Supports $select. Read-only.
  - `[DescriptionForAdmins <String>]`: Description provided by review creators to provide more context of the review to admins. Supports $select.
  - `[DescriptionForReviewers <String>]`: Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.
  - `[DisplayName <String>]`: Name of the access review series. Supports $select and $orderBy. Required on create.
  - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select. NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.
    - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
    - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
    - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
  - `[InstanceEnumerationScope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Instances <IMicrosoftGraphAccessReviewInstance1[]>]`: Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
    - `[Id <String>]`: 
    - `[ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
      - `[DisplayName <String>]`: Name of reviewer.
      - `[UserPrincipalName <String>]`: User principal name of the user.
    - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem1[]>]`: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
      - `[Id <String>]`: 
      - `[AccessReviewId <String>]`: The identifier of the accessReviewInstance parent. Supports $select. Read-only.
      - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[AppliedDateTime <DateTime?>]`: The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.
      - `[ApplyResult <String>]`: The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.
      - `[Decision <String>]`: Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).
      - `[Justification <String>]`: Justification left by the reviewer when they made the decision.
      - `[Principal <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[PrincipalLink <String>]`: Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.
      - `[Recommendation <String>]`: A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.
      - `[Resource <IMicrosoftGraphAccessReviewInstanceDecisionItemResource>]`: accessReviewInstanceDecisionItemResource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Display name of the resource
        - `[Id <String>]`: Resource ID
        - `[Type <String>]`: Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.
      - `[ResourceLink <String>]`: A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.
      - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[ReviewedDateTime <DateTime?>]`: The timestamp when the review decision occurred. Supports $select. Read-only.
    - `[EndDateTime <DateTime?>]`: DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
    - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[Stages <IMicrosoftGraphAccessReviewStage1[]>]`: If the instance has multiple stages, this returns the collection of stages. A new stage will only be created when the previous stage ends. The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.
      - `[Id <String>]`: 
      - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem1[]>]`: Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.
      - `[EndDateTime <DateTime?>]`: DateTime when review stage is scheduled to end. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This property is the cumulative total of the durationInDays for all stages. Read-only.
      - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.
      - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of access review scopes is used to define who the reviewers are. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
      - `[StartDateTime <DateTime?>]`: DateTime when review stage is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: Specifies the status of an accessReviewStage. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $orderby, and $filter (eq only). Read-only.
    - `[StartDateTime <DateTime?>]`: DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[Status <String>]`: Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: Timestamp when the access review series was last modified. Supports $select. Read-only.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.
  - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
  - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings1>]`: accessReviewScheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
    - `[AutoApplyDecisionsEnabled <Boolean?>]`: Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
    - `[DecisionHistoriesForReviewersEnabled <Boolean?>]`: Indicates whether decisions on previous access review stages are available for reviewers on an accessReviewInstance with multiple subsequent stages. If not provided, the default is disabled (false).
    - `[DefaultDecision <String>]`: Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
    - `[DefaultDecisionEnabled <Boolean?>]`: Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
    - `[InstanceDurationInDays <Int32?>]`: Duration of each recurrence of review (accessReviewInstance) in number of days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its durationInDays setting will be used instead of the value of this property.
    - `[JustificationRequiredOnApproval <Boolean?>]`: Indicates whether reviewers are required to provide justification with their decision. Default value is false.
    - `[MailNotificationsEnabled <Boolean?>]`: Indicates whether emails are enabled or disabled. Default value is false.
    - `[RecommendationsEnabled <Boolean?>]`: Indicates whether decision recommendations are enabled or disabled. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationsEnabled setting will be used instead of the value of this property.
    - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
        - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
        - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        - `[Type <String>]`: recurrenceRangeType
    - `[ReminderNotificationsEnabled <Boolean?>]`: Indicates whether reminders are enabled or disabled. Default value is false.
  - `[StageSettings <IMicrosoftGraphAccessReviewStageSettings1[]>]`: Required only for a multi-stage access review to define the stages and their settings. You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings. Stages will be created sequentially based on the dependsOn property. Optional.  When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.
    - `[DecisionsThatWillMoveToNextStage <String[]>]`: Indicate which decisions will go to the next stage. Can be a sub-set of Approve, Deny, Recommendation, or NotReviewed. If not provided, all decisions will go to the next stage. Optional.
    - `[DependsOn <String[]>]`: Defines the sequential or parallel order of the stages and depends on the stageId. Only sequential stages are currently supported. For example, if stageId is 2, then dependsOn must be 1. If stageId is 1, do not specify dependsOn. Required if stageId is not 1.
    - `[DurationInDays <Int32?>]`: The duration of the stage. Required.  NOTE: The cumulative value of this property across all stages  1. Will override the instanceDurationInDays setting on the accessReviewScheduleDefinition object. 2. Cannot exceed the length of one recurrence. That is, if the review recurs weekly, the cumulative durationInDays cannot exceed 7.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: If provided, the fallback reviewers are asked to complete a review if the primary reviewers do not exist. For example, if managers are selected as reviewers and a principal under review does not have a manager in Azure AD, the fallback reviewers are asked to review that principal. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition object.
    - `[RecommendationsEnabled <Boolean?>]`: Indicates whether showing recommendations to reviewers is enabled. Required. NOTE: The value of this property will override override the corresponding setting on the accessReviewScheduleDefinition object.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: Defines who the reviewers are. If none are specified, the review is a self-review (users review their own access).  For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition.
    - `[StageId <String>]`: Unique identifier of the accessReviewStageSettings. The stageId will be used in dependsOn property to indicate the stage relationship. Required.
  - `[Status <String>]`: This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.

CREATEDBY <IMicrosoftGraphUserIdentity>: userIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

FALLBACKREVIEWERS <IMicrosoftGraphAccessReviewReviewerScope1[]>: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select. NOTE: The value of this property will be ignored if fallback reviewers are assigned through the stageSettings property.
  - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
  - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
  - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.

INSTANCES <IMicrosoftGraphAccessReviewInstance1[]>: Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
  - `[Id <String>]`: 
  - `[ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
    - `[DisplayName <String>]`: Name of reviewer.
    - `[UserPrincipalName <String>]`: User principal name of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem1[]>]`: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
    - `[Id <String>]`: 
    - `[AccessReviewId <String>]`: The identifier of the accessReviewInstance parent. Supports $select. Read-only.
    - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
      - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
      - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[AppliedDateTime <DateTime?>]`: The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.
    - `[ApplyResult <String>]`: The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.
    - `[Decision <String>]`: Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).
    - `[Justification <String>]`: Justification left by the reviewer when they made the decision.
    - `[Principal <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[PrincipalLink <String>]`: Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.
    - `[Recommendation <String>]`: A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.
    - `[Resource <IMicrosoftGraphAccessReviewInstanceDecisionItemResource>]`: accessReviewInstanceDecisionItemResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Display name of the resource
      - `[Id <String>]`: Resource ID
      - `[Type <String>]`: Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.
    - `[ResourceLink <String>]`: A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.
    - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[ReviewedDateTime <DateTime?>]`: The timestamp when the review decision occurred. Supports $select. Read-only.
  - `[EndDateTime <DateTime?>]`: DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
  - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
    - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
    - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
    - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
  - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Stages <IMicrosoftGraphAccessReviewStage1[]>]`: If the instance has multiple stages, this returns the collection of stages. A new stage will only be created when the previous stage ends. The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.
    - `[Id <String>]`: 
    - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem1[]>]`: Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.
    - `[EndDateTime <DateTime?>]`: DateTime when review stage is scheduled to end. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This property is the cumulative total of the durationInDays for all stages. Read-only.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: This collection of access review scopes is used to define who the reviewers are. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
    - `[StartDateTime <DateTime?>]`: DateTime when review stage is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Status <String>]`: Specifies the status of an accessReviewStage. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $orderby, and $filter (eq only). Read-only.
  - `[StartDateTime <DateTime?>]`: DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
  - `[Status <String>]`: Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.

REVIEWERS <IMicrosoftGraphAccessReviewReviewerScope1[]>: This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will be ignored if reviewers are assigned through the stageSettings property.
  - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
  - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
  - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.

SETTINGS <IMicrosoftGraphAccessReviewScheduleSettings1>: accessReviewScheduleSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
  - `[AutoApplyDecisionsEnabled <Boolean?>]`: Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
  - `[DecisionHistoriesForReviewersEnabled <Boolean?>]`: Indicates whether decisions on previous access review stages are available for reviewers on an accessReviewInstance with multiple subsequent stages. If not provided, the default is disabled (false).
  - `[DefaultDecision <String>]`: Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
  - `[DefaultDecisionEnabled <Boolean?>]`: Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
  - `[InstanceDurationInDays <Int32?>]`: Duration of each recurrence of review (accessReviewInstance) in number of days. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its durationInDays setting will be used instead of the value of this property.
  - `[JustificationRequiredOnApproval <Boolean?>]`: Indicates whether reviewers are required to provide justification with their decision. Default value is false.
  - `[MailNotificationsEnabled <Boolean?>]`: Indicates whether emails are enabled or disabled. Default value is false.
  - `[RecommendationsEnabled <Boolean?>]`: Indicates whether decision recommendations are enabled or disabled. NOTE: If the stageSettings of the accessReviewScheduleDefinition object is defined, its recommendationsEnabled setting will be used instead of the value of this property.
  - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
      - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
      - `[FirstDayOfWeek <String>]`: dayOfWeek
      - `[Index <String>]`: weekIndex
      - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
      - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
      - `[Type <String>]`: recurrencePatternType
    - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
      - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
      - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
      - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
      - `[Type <String>]`: recurrenceRangeType
  - `[ReminderNotificationsEnabled <Boolean?>]`: Indicates whether reminders are enabled or disabled. Default value is false.

STAGESETTINGS <IMicrosoftGraphAccessReviewStageSettings1[]>: Required only for a multi-stage access review to define the stages and their settings. You can break down each review instance into up to three sequential stages, where each stage can have a different set of reviewers, fallback reviewers, and settings. Stages will be created sequentially based on the dependsOn property. Optional. When this property is defined, its settings are used instead of the corresponding settings in the accessReviewScheduleDefinition object and its settings, reviewers, and fallbackReviewers properties.
  - `[DecisionsThatWillMoveToNextStage <String[]>]`: Indicate which decisions will go to the next stage. Can be a sub-set of Approve, Deny, Recommendation, or NotReviewed. If not provided, all decisions will go to the next stage. Optional.
  - `[DependsOn <String[]>]`: Defines the sequential or parallel order of the stages and depends on the stageId. Only sequential stages are currently supported. For example, if stageId is 2, then dependsOn must be 1. If stageId is 1, do not specify dependsOn. Required if stageId is not 1.
  - `[DurationInDays <Int32?>]`: The duration of the stage. Required.  NOTE: The cumulative value of this property across all stages  1. Will override the instanceDurationInDays setting on the accessReviewScheduleDefinition object. 2. Cannot exceed the length of one recurrence. That is, if the review recurs weekly, the cumulative durationInDays cannot exceed 7.
  - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: If provided, the fallback reviewers are asked to complete a review if the primary reviewers do not exist. For example, if managers are selected as reviewers and a principal under review does not have a manager in Azure AD, the fallback reviewers are asked to review that principal. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition object.
    - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
    - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
    - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
  - `[RecommendationsEnabled <Boolean?>]`: Indicates whether showing recommendations to reviewers is enabled. Required. NOTE: The value of this property will override override the corresponding setting on the accessReviewScheduleDefinition object.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope1[]>]`: Defines who the reviewers are. If none are specified, the review is a self-review (users review their own access).  For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API. NOTE: The value of this property will override the corresponding setting on the accessReviewScheduleDefinition.
  - `[StageId <String>]`: Unique identifier of the accessReviewStageSettings. The stageId will be used in dependsOn property to indicate the stage relationship. Required.

## RELATED LINKS
