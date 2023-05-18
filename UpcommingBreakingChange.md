# Upcoming breaking changes in Azure PowerShell

## Az.AnalysisServices 

### `Add-AzAnalysisServicesAccount`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

## Az.ApiManagement 

### `Update-AzApiManagementRegion`

- Parameter breaking-change will happen to all parameter sets
  - `-Sku`
    - The parameter : 'Sku' is changing.
    The type of the parameter is changing from 'Microsoft.Azure.Commands.ApiManagement.Models.PsApiManagementSku' to 'String'.

## Az.Batch 

### `New-AzBatchPool`

- Parameter breaking-change will happen to all parameter sets
  - `-TaskSlotsPerNode`
    - The parameter : 'MaxTasksPerComputeNode' is changing.

## Az.CognitiveServices 

### `Get-AzCognitiveServicesAccountSku`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzCognitiveServicesAccountSkus alias will be removed in an upcoming breaking change release

## Az.Compute 

### `New-AzVmss`

- Cmdlet breaking-change will happen to all parameter set
  - Starting May 2023, the "New-AzVmss" cmdlet will default to Trusted Launch VMSS. For more info, visit https://aka.ms/trustedLaunchVMSS.
  - Starting November 2023, the "New-AzVmss" cmdlet will use new defaults: Flexible orchestration mode and enable NATv2 configuration for Load Balancer. To learn more about Flexible Orchestration modes, visit https://aka.ms/orchestrationModeVMSS.

## Az.ContainerRegistry 

### `Get-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Get-AzContainerRegistryCredential`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Get-AzContainerRegistryReplication`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Get-AzContainerRegistryUsage`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Get-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-IncludeConfiguration`
    - Parameter is being deprecated without being replaced
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Get-AzContainerRegistryWebhookEvent`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `New-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `New-AzContainerRegistryNetworkRule`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet 'New-AzContainerRegistryIPRuleObject' is replacing this cmdlet.

### `New-AzContainerRegistryReplication`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `New-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistry`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistryReplication`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Remove-AzContainerRegistryWebhook`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Set-AzContainerRegistryNetworkRuleSet`

- Cmdlet breaking-change will happen to all parameter set
  - The cmdlet is being deprecated. There will be no replacement for it.

### `Test-AzContainerRegistryNameAvailability`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

### `Test-AzContainerRegistryWebhook`

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistry`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-NetworkRuleSet`
    - Parameter is being deprecated without being replaced
  - `-ResourceId`
    - Parameter is being deprecated without being replaced
  - `-StorageAccountName`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistryCredential`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

### `Update-AzContainerRegistryWebhook`

- Cmdlet breaking-change will happen to all parameter set
  - The Az.ContainerRegistry module is upgrading. The output properties may have some changes

- Parameter breaking-change will happen to all parameter sets
  - `-ResourceId`
    - Parameter is being deprecated without being replaced

## Az.DataLakeStore 

### `Export-AzDataLakeStoreChildItemProperty`

- Cmdlet breaking-change will happen to all parameter set
  - Export-AzDataLakeStoreChildItemProperties alias will be removed in an upcoming breaking change release

### `Export-AzDataLakeStoreItem`

- Cmdlet breaking-change will happen to all parameter set
  - For store side export failures, Export-AzDataLakeStoreItem will throw exception instead of printing message on screen

### `Import-AzDataLakeStoreItem`

- Cmdlet breaking-change will happen to all parameter set
  - For store side import failures, Import-AzDataLakeStoreItem will throw exception instead of printing message on screen

## Az.EventHub 

### `Get-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with Get-AzEventHubNamespaceV2.

### `New-AzEventHub`

- Parameter breaking-change will happen to all parameter sets
  - `-MessageRetentionInDays`
    - The parameter : 'MessageRetentionInDays' is changing.
    - The change is expected to take effect from the version : '4.0.0'

### `New-AzEventHubEncryptionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.KeyVaultProperties`.

### `New-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with New-AzEventHubNamespaceV2.

### `Remove-AzEventHubNamespace`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - The type of the `-InputObject` parameter would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`.
  - `-ResourceId`
    - This parameter would be removed. Henceforth, resource Id's can be provided as input to `-InputObject` parameter.

### `Set-AzEventHub`

- Parameter breaking-change will happen to all parameter sets
  - `-MessageRetentionInDays`
    - The parameter : 'MessageRetentionInDays' is changing.
    - Change description : -MessageRetentionInDays would be deprecated and would be replaced by -RetentionTimeInHours 
    - The change is expected to take effect from the version : '4.0.0'

### `Set-AzEventHubNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.IEhNamespace`. This cmdlet would henceforth be alias cmdlet with Set-AzEventHubNamespaceV2.

## Az.KeyVault 

### `Invoke-AzKeyVaultKeyOperation`

- Cmdlet breaking-change will happen to all parameter set
  - The encoded/decoded way between string and bytes will change to UTF8.

## Az.MachineLearning 

### `Get-AzMlWebServiceKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzMlWebServiceKeys alias will be removed in an upcoming breaking change release

## Az.Media 

### `Get-AzMediaServiceKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzMediaServiceKeys alias will be removed in an upcoming breaking change release

### `Sync-AzMediaServiceStorageKey`

- Cmdlet breaking-change will happen to all parameter set
  - Sync-AzMediaServiceStorageKeys alias will be removed in an upcoming breaking change release

## Az.NotificationHubs 

### `Get-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubListKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubListKeys alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubPNSCredential`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubPNSCredentials alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Get-AzNotificationHubsNamespaceListKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzNotificationHubsNamespaceListKeys alias will be removed in an upcoming breaking change release

### `New-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - New-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `New-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - New-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Remove-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Remove-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

### `Set-AzNotificationHubAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzNotificationHubAuthorizationRules alias will be removed in an upcoming breaking change release

### `Set-AzNotificationHubsNamespaceAuthorizationRule`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzNotificationHubsNamespaceAuthorizationRules alias will be removed in an upcoming breaking change release

## Az.PowerBIEmbedded 

### `Get-AzPowerBIWorkspaceCollectionAccessKey`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzPowerBIWorkspaceCollectionAccessKeys alias will be removed in an upcoming breaking change release

### `Reset-AzPowerBIWorkspaceCollectionAccessKey`

- Cmdlet breaking-change will happen to all parameter set
  - Reset-AzPowerBIWorkspaceCollectionAccessKeys alias will be removed in an upcoming breaking change release

## Az.RedisCache 

### `Remove-AzRedisCacheDiagnostic`

- Cmdlet breaking-change will happen to all parameter set
  - Remove-AzRedisCacheDiagnostics alias will be removed in an upcoming breaking change release

### `Set-AzRedisCacheDiagnostic`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzRedisCacheDiagnostics alias will be removed in an upcoming breaking change release

## Az.Relay 

### `Get-AzRelayOperation`

- Cmdlet breaking-change will happen to all parameter set
  - Get-AzRelayOperation will be removed in an upcoming breaking change release. Please use 'Get-AzProviderOperation Microsoft.Relay/*'

### `Set-AzRelayNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Set-AzRelayNamespace will be removed in an upcoming breaking change release, you can use Update-AzRelayNamespace in a future release

## Az.ServiceBus 

### `Get-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with Get-AzServiceBusNamespaceV2.

### `New-AzServiceBusEncryptionConfig`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.KeyVaultProperties`.

### `New-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with New-AzServiceBusNamespaceV2.

### `Remove-AzServiceBusNamespace`

- Parameter breaking-change will happen to all parameter sets
  - `-InputObject`
    - The type of the `-InputObject` parameter would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api202210Preview.ISbNamespace`.
  - `-ResourceId`
    - This parameter would be removed. Henceforth, resource Id's can be provided as input to `-InputObject` parameter.

### `Set-AzServiceBusNamespace`

- Cmdlet breaking-change will happen to all parameter set
  - Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with Set-AzServiceBusNamespaceV2.

