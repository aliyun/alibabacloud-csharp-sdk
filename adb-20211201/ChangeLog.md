2024-12-26 Version: 3.4.0
- Support API GetCreateTableSQL.
- Support API ModifyUserEniVswitchOptions.
- Update API AttachUserENI: update param AccessKeyId.
- Update API CreatePerformanceView: update param AccessKeyId.
- Update API DeletePerformanceView: update param AccessKeyId.
- Update API DescribeBackupPolicy: update param AccessKeyId.
- Update API DescribeDBClusterAttribute: update param AccessKeyId.
- Update API DescribeDBClusterAttribute: update response param.
- Update API DescribeDBClusterSpaceSummary: update param AccessKeyId.
- Update API DescribeExcessivePrimaryKeys: update param AccessKeyId.
- Update API DescribePerformanceViewAttribute: update param AccessKeyId.
- Update API DescribePerformanceViews: update param AccessKeyId.
- Update API DetachUserENI: update param AccessKeyId.
- Update API ModifyAccountDescription: update param AccessKeyId.
- Update API ModifyDBClusterDescription: update param AccessKeyId.
- Update API ModifyDBClusterMaintainTime: update param AccessKeyId.
- Update API ModifyPerformanceView: update param AccessKeyId.


2024-12-16 Version: 3.3.0
- Support API DescribeSparkAppDiagnosisInfo.
- Support API DescribeSparkAppType.
- Update API DescribeDBClusterPerformance: update param AccessKeyId.
- Update API DescribeDBClusterPerformance: update response param.


2024-12-12 Version: 3.2.0
- Support API DescribeSparkAppDiagnosisInfo.
- Support API DescribeSparkAppType.


2024-12-11 Version: 3.1.0
- Support API CancelSparkReplStatement.
- Support API ExecuteSparkReplStatement.
- Support API GetSparkReplSession.
- Support API GetSparkReplStatement.
- Support API StartSparkReplSession.


2024-12-10 Version: 3.0.0
- Support API DeleteBackups.
- Support API DescribeCompactionServiceSwitch.
- Support API DescribeEssdCacheConfig.
- Support API DescribeKernelVersion.
- Support API DescribeLakeCacheSize.
- Support API DescribeOperatorPermission.
- Support API GrantOperatorPermission.
- Support API ListTagResources.
- Support API ModifyCompactionServiceSwitch.
- Support API ModifyDBClusterResourceGroup.
- Support API ModifyDBClusterVip.
- Support API ModifyEssdCacheConfig.
- Support API ModifyLakeCacheSize.
- Support API RevokeOperatorPermission.
- Delete API GetSparkDefinitions.
- Delete API RenameSparkTemplateFile.
- Update API DescribeDBClusterAttribute: update response param.
- Update API DescribeDiagnosisRecords: update response param.
- Update API DescribePatternPerformance: update response param.


2024-10-16 Version: 2.0.11
- Update API CreateDBResourceGroup: add param AutoStopInterval.
- Update API DescribeDBResourceGroup: update response param.
- Update API DescribePerformanceViewAttribute: update response param.
- Update API ModifyDBResourceGroup: add param AutoStopInterval.
- Update API ModifyDBResourceGroup: add param Status.


2024-10-12 Version: 2.0.10
- Update API DescribeBackups: update response param.
- Update API ModifyBackupPolicy: update param PreferredBackupPeriod.


2024-09-29 Version: 2.0.9
- Update API CreateDBResourceGroup: add param MaxGpuQuantity.
- Update API CreateDBResourceGroup: add param MinGpuQuantity.
- Update API CreateDBResourceGroup: add param SpecName.
- Update API CreateDBResourceGroup: add param TargetResourceGroupName.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param MaxGpuQuantity.
- Update API ModifyDBResourceGroup: add param MinGpuQuantity.
- Update API ModifyDBResourceGroup: add param SpecName.
- Update API ModifyDBResourceGroup: add param TargetResourceGroupName.


2024-09-26 Version: 2.0.8
- Update API DescribeClusterAccessWhiteList: add param RegionId.


2024-09-24 Version: 2.0.7
- Update API CreateDBCluster: add param CloneSourceRegionId.
- Update API CreateDBCluster: update param ProductForm.
- Update API ModifyDBCluster: add param ProductForm.


2024-08-30 Version: 2.0.6
- Update API DescribeDiagnosisRecords: update response param.


2024-08-30 Version: 2.0.6
- Update API DescribeDiagnosisRecords: update response param.


2024-08-20 Version: 2.0.5
- Update API GetTableObjects: update param PageNumber.
- Update API GetTableObjects: update param PageSize.
- Update API ModifyAuditLogConfig: add param EngineType.


2024-08-14 Version: 2.0.4
- Update API CreateDBResourceGroup: add param Engine.
- Update API CreateDBResourceGroup: add param EngineParams.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param EngineParams.


2024-08-09 Version: 2.0.3
- Generated csharp 2021-12-01 for adb.

2024-08-06 Version: 2.0.2
- Update API DescribeSQLPatterns: update response param.


2024-07-24 Version: 2.0.1
- Update API DescribeRegions: add param RegionId.
- Update API GetTable: update param DbName.
- Update API GetTable: update param TableName.


2024-07-01 Version: 2.0.0
- Support API CreatePerformanceView.
- Support API DeletePerformanceView.
- Support API DescribeExcessivePrimaryKeys.
- Support API DescribePerformanceViewAttribute.
- Support API DescribePerformanceViews.
- Support API ModifyPerformanceView.
- Update API AllocateClusterPublicConnection: add param Engine.
- Update API CreateAccount: add param Engine.
- Update API CreateDBCluster: add param DiskEncryption.
- Update API CreateDBCluster: add param KmsId.
- Update API DeleteAccount: add param Engine.
- Update API DescribeAccounts: add param Engine.
- Update API DescribeAccounts: update response param.
- Update API DescribeApsActionLogs: delete param Action.
- Update API DescribeApsActionLogs: update response param.
- Update API DescribeClusterNetInfo: add param Engine.
- Update API DescribeClusterNetInfo: update response param.
- Update API DescribeDBClusterAttribute: update response param.
- Update API DescribeDBClusterHealthStatus: update response param.
- Update API DescribeDBClusters: update response param.
- Update API DescribeDownloadRecords: update response param.
- Update API DescribeJobResourceUsage: update response param.
- Update API DescribeSQLPatterns: update response param.
- Update API ModifyAccountDescription: add param Engine.
- Update API ReleaseClusterPublicConnection: add param Engine.
- Update API ResetAccountPassword: add param Engine.
- Update API SubmitSparkApp: update param AppName.


2024-05-10 Version: 1.3.5
- Update API CreateOssSubDirectory: update param DBClusterId.


2024-05-09 Version: 1.3.4
- Update API CreateDBCluster: add param ProductForm.
- Update API CreateDBCluster: add param ReservedNodeCount.
- Update API CreateDBCluster: add param ReservedNodeSize.
- Update API CreateDBCluster: update param ComputeResource.
- Update API CreateDBCluster: update param StorageResource.
- Update API DescribeDBClusterAttribute: update response param.
- Update API DescribeDBClusters: add param DBClusterVersion.
- Update API DescribeDBClusters: add param ProductVersion.
- Update API DescribeDBClusters: update response param.
- Update API ExistRunningSQLEngine: update response param.
- Update API ModifyDBCluster: add param ReservedNodeCount.
- Update API ModifyDBCluster: add param ReservedNodeSize.
- Update API ModifyDBCluster: update param ComputeResource.
- Update API ModifyDBCluster: update param StorageResource.


2024-04-10 Version: 1.3.3
- Update API DescribeApsResourceGroups: add param RegionId.
- Update API DescribeApsResourceGroups: add param WorkloadId.


2024-04-09 Version: 1.3.2
- Generated csharp 2021-12-01 for adb.

2024-03-25 Version: 1.3.1
- Update API CreateDBResourceGroup: add param Rules.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param Rules.


2024-03-25 Version: 1.3.1
- Update API CreateDBResourceGroup: add param Rules.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param Rules.


2024-03-23 Version: 1.3.0
- Support API DescribeDBClusterSpaceSummary.
- Update API CreateDBResourceGroup: add param EnableSpot.
- Update API DescribeApsActionLogs: update response param.
- Update API DescribeClusterResourceDetail: update response param.
- Update API DescribeDBResourceGroup: add param RegionId.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param EnableSpot.


2024-03-01 Version: 1.2.7
- Update API CreateDBResourceGroup: add param EnableSpot.
- Update API DescribeApsActionLogs: update response param.
- Update API DescribeClusterResourceDetail: update response param.
- Update API DescribeDBResourceGroup: add param RegionId.
- Update API DescribeDBResourceGroup: update response param.
- Update API ModifyDBResourceGroup: add param EnableSpot.


2024-01-26 Version: 1.2.6
- Generated csharp 2021-12-01 for adb.

2024-01-18 Version: 1.2.5
- Generated csharp 2021-12-01 for adb.

2024-01-18 Version: 1.2.5
- Generated csharp 2021-12-01 for adb.

2024-01-18 Version: 1.2.5
- Generated csharp 2021-12-01 for adb.

2024-01-18 Version: 1.2.5
- Generated csharp 2021-12-01 for adb.

2024-01-05 Version: 1.2.4
- Generated csharp 2021-12-01 for adb.

2023-12-21 Version: 1.2.3
- Generated csharp 2021-12-01 for adb.

2023-12-19 Version: 1.2.2
- Generated csharp 2021-12-01 for adb.

2023-12-12 Version: 1.2.1
- Generated csharp 2021-12-01 for adb.

2023-12-08 Version: 1.2.0
- Generated csharp 2021-12-01 for adb.

2023-11-25 Version: 1.1.6
- Generated csharp 2021-12-01 for adb.

2023-11-20 Version: 1.1.5
- Generated csharp 2021-12-01 for adb.

2023-11-06 Version: 1.1.4
- Generated csharp 2021-12-01 for adb.

2023-11-03 Version: 1.1.3
- Generated csharp 2021-12-01 for adb.

2023-10-18 Version: 1.1.2
- Generated csharp 2021-12-01 for adb.

2023-10-18 Version: 1.1.2
- Generated csharp 2021-12-01 for adb.

2023-09-25 Version: 1.1.1
- Generated csharp 2021-12-01 for adb.

2023-09-13 Version: 1.1.0
- Generated csharp 2021-12-01 for adb.

2023-08-28 Version: 1.0.1
- Generated csharp 2021-12-01 for adb.

2023-08-25 Version: 1.0.0
- Generated csharp 2021-12-01 for adb.

