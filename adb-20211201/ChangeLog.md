2025-09-08 Version: 4.2.1
- Update API DescribeDBClusters: add response parameters Body.Items.$.AINodeNumber.
- Update API DescribeDBClusters: add response parameters Body.Items.$.AINodeSpec.
- Update API DescribeJobResourceUsage: add request parameters PageNumber.
- Update API DescribeJobResourceUsage: add request parameters PageSize.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.PageNumber.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.PageSize.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.TotalCount.


2025-09-08 Version: 4.2.1
- Update API DescribeDBClusters: add response parameters Body.Items.$.AINodeNumber.
- Update API DescribeDBClusters: add response parameters Body.Items.$.AINodeSpec.
- Update API DescribeJobResourceUsage: add request parameters PageNumber.
- Update API DescribeJobResourceUsage: add request parameters PageSize.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.PageNumber.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.PageSize.
- Update API DescribeJobResourceUsage: add response parameters Body.Data.TotalCount.


2025-08-20 Version: 4.2.0
- Support API CreateApsKafkaHudiJob.
- Support API DescribeDBClusterSSL.
- Support API DescribeHistoryTasks.
- Support API DescribeHistoryTasksStat.
- Support API GetADBSparkNecessaryRAMPermissions.
- Support API ModifyDBClusterSSL.
- Update API CreateDBResourceGroup: add request parameters RayConfig.EnableUserEni.
- Update API CreateDBResourceGroup: add request parameters RayConfig.HeadAllocateUnit.
- Update API CreateDBResourceGroup: add request parameters RayConfig.HeadDiskCapacity.
- Update API CreateDBResourceGroup: add request parameters RayConfig.HeadSpecType.
- Update API DescribeDBResourceGroup: add response parameters Body.GroupsInfo.$.RayConfig.EnableUserEni.
- Update API DescribeDBResourceGroup: add response parameters Body.GroupsInfo.$.RayConfig.HeadAllocateUnit.
- Update API DescribeDBResourceGroup: add response parameters Body.GroupsInfo.$.RayConfig.HeadDiskCapacity.
- Update API DescribeDBResourceGroup: add response parameters Body.GroupsInfo.$.RayConfig.HeadSpecType.
- Update API ModifyDBResourceGroup: add request parameters RayConfig.EnableUserEni.
- Update API ModifyDBResourceGroup: add request parameters RayConfig.HeadAllocateUnit.
- Update API ModifyDBResourceGroup: add request parameters RayConfig.HeadDiskCapacity.
- Update API ModifyDBResourceGroup: add request parameters RayConfig.HeadSpecType.


2025-07-09 Version: 4.1.3
- Update API ApplyAdviceById: add request parameters ApplyType.
- Update API ApplyAdviceById: add request parameters BuildImmediately.
- Update API BatchApplyAdviceByIdList: add request parameters ApplyType.
- Update API BatchApplyAdviceByIdList: add request parameters BuildImmediately.
- Update API DescribeAppliedAdvices: add response parameters Body.Items.$.IndexFields.
- Update API DescribeAvailableAdvices: add response parameters Body.Items.$.IndexFields.


2025-06-28 Version: 4.1.2
- Update API DescribeSQLPatterns: add request parameters UserName.


2025-06-25 Version: 4.1.1
- Update API DescribeDBClusterAttribute: add response parameters Body.Items.$.AINodeNumber.
- Update API DescribeDBClusterAttribute: add response parameters Body.Items.$.AINodeSpec.


2025-05-26 Version: 4.1.0
- Support API DescribeAdbMySqlIndexes.
- Support API DescribeAdbMySqlTableMeta.
- Support API DescribeLLMAnswer.
- Support API DescribeLLMSimilarQuestions.
- Support API DescribeSQLWebSocketDomain.
- Support API DescribeTableStatistics.
- Update API DescribeBackups: add request parameters Remote.
- Update API DescribeBackups: add response parameters Body.Items.$.BackupRegion.
- Update API DescribeBackups: add response parameters Body.Items.$.ParentBackupId.


2025-04-18 Version: 4.0.3
- Update API DescribeDiagnosisSQLInfo: add response parameters Body.StageInfos.$.ExecutionType.


2025-04-17 Version: 4.0.2
- Generated csharp 2021-12-01 for adb.

2025-04-15 Version: 4.0.1
- Generated csharp 2021-12-01 for adb.

2025-04-15 Version: 4.0.0
- Support API DescribeInclinedTables.
- Support API DescribeResourceGroupSpec.
- Delete API DeleteProcessInstance.
- Update API GetViewObjects: add request parameters ShowMvBaseTable.
- Update API ModifyDBCluster: delete request parameters OwnerAccount.
- Update API ModifyDBCluster: delete request parameters OwnerId.
- Update API ModifyDBCluster: delete request parameters ResourceOwnerAccount.


2025-03-31 Version: 3.9.0
- Support API UpgradeKernelVersion.
- Update API CreateDBCluster: add request parameters ProductVersion.
- Update API CreateDBCluster: add request parameters SecondaryVSwitchId.
- Update API CreateDBCluster: add request parameters SecondaryZoneId.
- Update API CreateDBResourceGroup: add request parameters RayConfig.
- Update API DescribeDBClusterAttribute: add response parameters Body.Items.$.DiskEncryption.
- Update API DescribeDBClusterAttribute: add response parameters Body.Items.$.SecondaryVSwitchId.
- Update API DescribeDBClusterAttribute: add response parameters Body.Items.$.SecondaryZoneId.
- Update API DescribeDBResourceGroup: add response parameters Body.GroupsInfo.$.RayConfig.
- Update API ModifyDBResourceGroup: add request parameters RayConfig.


2025-02-11 Version: 3.8.0
- Support API CancelSparkWarehouseBatchSQL.
- Support API DescribeSparkSQLDiagnosisAttribute.
- Support API DescribeSparkSQLDiagnosisList.
- Support API ExecuteSparkWarehouseBatchSQL.
- Support API GetSparkWarehouseBatchSQL.
- Support API ListSparkWarehouseBatchSQL.
- Update API ListSparkApps: add param Filters.


2024-12-30 Version: 3.7.0
- Support API CreateApsCopyWorkload.
- Support API CreateApsDatasoure.
- Support API CreateApsSlsADBJob.
- Support API DeleteLakeStorage.
- Support API DescribeAbnormalPatternDetection.
- Support API DescribeAppliedAdvices.
- Support API DescribeAvailableAdvices.
- Support API DescribeBadSqlDetection.
- Support API DescribeControllerDetection.
- Support API DescribeExecutorDetection.
- Support API DescribeOversizeNonPartitionTableInfos.
- Support API DescribeTableDetail.
- Support API DescribeTablePartitionDiagnose.
- Support API DescribeWorkerDetection.
- Support API DisableAdviceService.
- Support API DownloadInstanceCACertificate.
- Support API EnableAdviceService.
- Support API KillProcess.
- Support API ListLakeStorages.
- Support API ModifyApsSlsADBJob.
- Support API ModifyClickhouseEngine.
- Support API SuspendApsJob.


2024-12-29 Version: 3.6.0
- Support API CreateApsHiveJob.
- Support API CreateLakeStorage.
- Support API DeleteApsDatasoure.
- Support API DeleteApsJob.
- Support API DescribeAPSADBInstances.
- Support API DescribeApsDatasource.
- Support API DescribeApsDatasources.
- Support API DescribeApsHiveWorkload.
- Support API DescribeApsJobDetail.
- Support API DescribeApsJobs.
- Support API DescribeApsMigrationWorkloads.
- Support API DescribeApsProgress.
- Support API DescribeInclinedNodes.
- Support API GetApsManagedDatabases.
- Support API GetLakeStorage.
- Support API ListApsLifecycleStrategy.
- Support API ListApsOptimizationStrategy.
- Support API ListApsOptimizationTasks.
- Support API ListResultExportJobHistory.
- Support API ModifyApsDatasoure.
- Support API ModifyApsJob.
- Support API ModifyApsWorkloadName.
- Support API StartApsJob.
- Support API SubmitResultExportJob.
- Support API UpdateLakeStorage.


2024-12-27 Version: 3.5.0
- Support API ApplyAdviceById.
- Support API BatchApplyAdviceByIdList.
- Support API CreateAPSJob.
- Support API DescribeAdviceServiceEnabled.
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

