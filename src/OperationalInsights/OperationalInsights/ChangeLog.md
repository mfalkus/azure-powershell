﻿<!--
    Please leave this section at the top of the change log.

    Changes for the upcoming release should go under the section titled "Upcoming Release", and should adhere to the following format:

    ## Upcoming Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->
## Upcoming Release
* Expanded DatasourceType with values `Query`, `Alerts` for cmdlets:
  - `Get-AzOperationalInsightsLinkedStorageAccount`
  - `New-AzOperationalInsightsLinkedStorageAccount`
  - `Remove-AzOperationalInsightsLinkedStorageAccount`
  - `Set-AzOperationalInsightsLinkedStorageAccount`
* Files moved (without change):
  - `Get-AzOperationalInsightsSavedSearch`
  - `Get-AzOperationalInsightsSchema`
  - `New-AzOperationalInsightsSavedSearch`
  - `Remove-AzOperationalInsightsSavedSearch`
  - `Set-AzOperationalInsightsSavedSearch`
* CmdletParameterBreakingChange: rename `StorageAccountId` to `StorageAccountIds`
  - `New-AzOperationalInsightsLinkedStorageAccount`
* Changed return contract: Now returns `PSSavedSearch` instead of `HttpStatusCode`:
  - `New-AzOperationalInsightsComputerGroup`
* Changed return contract: Now returns `PSCluster` instead of `PSLinkedService`:
  - `Update-AzOperationalInsightsCluster`
* Expanded Sku with values `capacityreservation`, `lacluster` for cmdlets:
  - `Set-AzOperationalInsightsWorkspace`
  - `New-AzOperationalInsightsWorkspace`
* Added new properties:`SkuCapacity`, `ForceCmkForQuery`, `DisableLocalAuth`  for cmdlets:
  - `Set-AzOperationalInsightsWorkspace`
  - `New-AzOperationalInsightsWorkspace`
* Added new property: `DailyQuotaGb`:
  - `Set-AzOperationalInsightsWorkspace`
* Added new properties: `ETag`, `Tag` for cmdlets:
  - `Set-AzOperationalInsightsStorageInsight`
  - `New-AzOperationalInsightsStorageInsight`
* Added new property `StorageAccountResourceId` to cmdlet:
  - `Set-AzOperationalInsightsStorageInsight`
* Added SupportsShouldProcess attribute to cmdlet:
  - `Set-AzOperationalInsightsStorageInsight`
* Added new cmdlets:
  - `Get-AzOperationalInsightsTable`
  - `Get-AzOperationalInsightsOperation`
  - `Get-AzOperationalInsightsDataExport`
  - `New-AzOperationalInsightsDataExport`
  - `Remove-AzOperationalInsightsDataExport`
  - `Update-AzOperationalInsightsDataExport`
  - `Get-AzOperationalInsightsOperationStatus`
  - `Update-AzOperationalInsightsWorkspaceSharedKey`
  - `New-AzOperationalInsightsPurgeWorkspace`
  - `Get-AzOperationalInsightsPurgeWorkspaceStatus`
  - `Get-AzOperationalInsightsAvailableServiceTier`

* Added `Error` property in the result of the `Invoke-AzOperationalInsightsQuery` to retrieve partial error when running a query [#16378]

## Version 2.3.1
* Fixed a bug in `Set-AzOperationalInsightsLinkedService: when linked service does not exist, perform create(update) instead of failing`

## Version 2.3.0
* Added `-ForceDelete` option for `Remove-AzOperationalInsightsWorkspace`
* Added new cmdlet `Get-AzOperationalInsightsDeletedWorkspace`
* Added new cmdlet `Restore-AzOperationalInsightsWorkspace`

## Version 2.2.0
* Fixed bug PSWorkspace doesn't implement IOperationalInsightsWorkspace [#12135]
* Added "pergb2018" to valid value set of parameter `Sku` in `Set-AzOperationalInsightsWorkspace` 
* Added alias "FunctionParameters" for parameter `FunctionParameter` to
    - `New-AzOperationalInsightsSavedSearch`
    - `Set-AzOperationalInsightsSavedSearch`

## Version 2.1.0
* Upgraded SDK to 0.21.0
* Added optional parameters to 
    - `New-AzOperationalInsightsSavedSearch`
    - `Set-AzOperationalInsightsSavedSearch`

## Version 2.0.0
* Updated legacy code to apply new generated SDK
* Deleted cmdlets due to deprecated APIs
    - `Get-AzOperationalInsightsSavedSearchResult` (alias `Get-AzOperationalInsightsSavedSearchResults`)
    - `Get-AzOperationalInsightsSearchResult` (alias `Get-AzOperationalInsightsSearchResults`)
    - `Get-AzOperationalInsightsLinkTarget` (alias `Get-AzOperationalInsightsLinkTargets`)
* Added parameters for `Set-AzOperationalInsightsWorkspace` and `New-AzOperationalInsightsWorkspace`
* Created cmdlets for Linked Stoarge Account
* Created cmdlets for Clusters and Linked Service

## Version 1.3.4
* Update references in .psd1 to use relative path

## Version 1.3.3
* Fixed miscellaneous typos across module
* Updated documentation for `New-AzOperationalInsightsLinuxSyslogDataSource`
    - Added example
    - Updated description for `-Name` parameter
* Added an example for New-AzOperationalInsightsWindowsEventDataSource
* Changed the description of the -Name parameter for New-AzOperationalInsightsWindowsEventDataSource

## Version 1.3.2
* Updated default version for saved searches to be 1. 
* Fixed custom log null regex handling

## Version 1.3.1
* Fixed CustomLog datasource model returned in Get-AzOperationalInsightsDataSource

## Version 1.3.0
* Enable **pergb2018** pricing tier in `New-AzureRmOperationalInsightsWorkspace` command

## Version 1.2.0
* Updated cmdlets with plural nouns to singular, and deprecated plural names.

## Version 1.1.0
* Additional support for New and Get ApplicationInsights data source.
    - Added new 'ApplicationInsights' kind to support Get specific and Get all ApplicationInsights data sources for given workspace. 
    - Added New-AzOperationalInsightsApplicationInsightsDataSource cmdlet for creating data source by given Application-Insights resource parameters: subscription Id, resourceGroupName and name. 

## Version 1.0.0
* General availability of `Az.OperationalInsights` module
* Default parameter set for Get-AzOperationalInsightsDataSource is removed, and ByWorkspaceNameByKind has become the default parameter set
