### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	externalUserLifecycleAction = "None"
}

Update-MgEntitlementManagementSetting -BodyParameter $params
```
This example shows how to use the Update-MgEntitlementManagementSetting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

