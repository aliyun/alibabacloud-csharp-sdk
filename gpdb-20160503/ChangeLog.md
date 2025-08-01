2025-08-01 Version: 2.4.0
- Support API CreateSupabaseProject.
- Support API DeleteSupabaseProject.
- Support API GetSupabaseProject.
- Support API GetSupabaseProjectApiKeys.
- Support API GetSupabaseProjectDashboardAccount.
- Support API ListSupabaseProjects.
- Support API ModifyCollection.
- Support API ModifySupabaseProjectSecurityIps.
- Support API ResetSupabaseProjectPassword.
- Update API DescribeDBInstanceAttribute: add response parameters Body.Items.$.InstanceSpec.
- Update API DescribeDocument: add response parameters Body.DocumentLoaderResultFileUrl.
- Update API GetUploadDocumentJob: add response parameters Body.ChunkResult.DocumentLoaderResultFileUrl.
- Update API UploadDocumentAsync: add request parameters VlEnhance.
- Update API UpsertChunks: add request parameters AllowInsertWithFilter.


2025-05-29 Version: 2.2.5
- Update API CreateDBInstance: add request parameters CacheStorageSize.
- Update API DescribeDBInstanceAttribute: add response parameters Body.Items.$.CacheStorageSize.
- Update API QueryContent: add request parameters UrlExpiration.
- Update API TextEmbedding: add request parameters Dimension.
- Update API UpgradeDBInstance: add request parameters CacheStorageSize.
- Update API UpgradeDBInstance: add request parameters ServerlessResource.
- Update API UpsertChunks: add request parameters ShouldReplaceFile.
- Update API UpsertChunks: add request parameters TextChunks.$.Filter.
- Update API UpsertChunks: add request parameters TextChunks.$.Id.


2025-04-27 Version: 2.2.4
- Generated csharp 2016-05-03 for gpdb.

2025-03-25 Version: 2.2.3
- Update API QueryContent: update param Content.


2025-03-18 Version: 2.2.2
- Update API DescribeDownloadRecords: add param DownloadTaskType.


2025-01-10 Version: 2.2.0
- Support API CreateBackup.
- Support API DeleteBackup.
- Support API DescribeBackupJob.
- Support API ListBackupJobs.
- Update API ModifyMasterSpec: update param AccessKeyId.


2024-12-20 Version: 2.1.0
- Support API CreateRemoteADBDataSource.
- Support API DeleteAccount.
- Support API DeleteRemoteADBDataSource.
- Support API GetAccount.
- Support API ListRemoteADBDataSources.
- Support API ModifyDBInstanceNetworkType.
- Support API ModifyDBInstancePayType.
- Support API ModifyRemoteADBDataSource.
- Support API Rerank.
- Support API TextEmbedding.
- Update API AllocateInstancePublicConnection: update param AccessKeyId.
- Update API BindDBResourceGroupWithRole: update param AccessKeyId.
- Update API CreateAccount: delete param ResourceGroupId.
- Update API CreateAccount: update param AccessKeyId.
- Update API CreateAccount: update param AccountPassword.
- Update API CreateCollection: add param MetadataIndices.
- Update API CreateCollection: update param AccessKeyId.
- Update API CreateDBInstance: add param DeployMode.
- Update API CreateDBInstance: add param StandbyVSwitchId.
- Update API CreateDBInstance: add param StandbyZoneId.
- Update API CreateDBInstance: update param AccessKeyId.
- Update API CreateDBInstancePlan: update param AccessKeyId.
- Update API CreateDBResourceGroup: update param AccessKeyId.
- Update API CreateDocumentCollection: add param MetadataIndices.
- Update API CreateDocumentCollection: update param AccessKeyId.
- Update API CreateJDBCDataSource: update param JDBCPassword.
- Update API CreateSampleData: update param AccessKeyId.
- Update API CreateStreamingJob: update param Password.
- Update API DescribeActiveSQLRecords: update param AccessKeyId.
- Update API DescribeAvailableResources: update param AccessKeyId.
- Update API DescribeDBClusterNode: update param AccessKeyId.
- Update API DescribeDBClusterPerformance: update param AccessKeyId.
- Update API DescribeDBInstanceAttribute: update param AccessKeyId.
- Update API DescribeDBInstanceAttribute: update response param.
- Update API DescribeDBInstanceDataBloat: update param AccessKeyId.
- Update API DescribeDBInstanceDataSkew: update param AccessKeyId.
- Update API DescribeDBInstanceDiagnosisSummary: update param AccessKeyId.
- Update API DescribeDBInstanceErrorLog: update param AccessKeyId.
- Update API DescribeDBInstanceIPArrayList: update param AccessKeyId.
- Update API DescribeDBInstanceIndexUsage: update param AccessKeyId.
- Update API DescribeDBInstanceNetInfo: update param AccessKeyId.
- Update API DescribeDBInstancePerformance: update param AccessKeyId.
- Update API DescribeDBInstancePlans: update param AccessKeyId.
- Update API DescribeDBInstanceSSL: update param AccessKeyId.
- Update API DescribeDBInstanceSupportMaxPerformance: update param AccessKeyId.
- Update API DescribeDBInstances: update param AccessKeyId.
- Update API DescribeDBResourceGroup: update param AccessKeyId.
- Update API DescribeDBResourceManagementMode: update param AccessKeyId.
- Update API DescribeDBVersionInfos: update param AccessKeyId.
- Update API DescribeDataReDistributeInfo: update param AccessKeyId.
- Update API DescribeDataShareInstances: update param AccessKeyId.
- Update API DescribeDiagnosisDimensions: update param AccessKeyId.
- Update API DescribeDiagnosisMonitorPerformance: update param AccessKeyId.
- Update API DescribeDiagnosisRecords: update param AccessKeyId.
- Update API DescribeDiagnosisSQLInfo: update param AccessKeyId.
- Update API DescribeDownloadRecords: update param AccessKeyId.
- Update API DescribeDownloadSQLLogs: update param AccessKeyId.
- Update API DescribeHealthStatus: update param AccessKeyId.
- Update API DescribeIMVInfos: update param AccessKeyId.
- Update API DescribeJDBCDataSource: update response param.
- Update API DescribeLogBackups: update param AccessKeyId.
- Update API DescribeModifyParameterLog: update param AccessKeyId.
- Update API DescribeParameters: update param AccessKeyId.
- Update API DescribeRoles: update param AccessKeyId.
- Update API DescribeSQLLogCount: update param AccessKeyId.
- Update API DescribeSQLLogs: update param AccessKeyId.
- Update API DescribeSQLLogsV2: update param AccessKeyId.
- Update API DescribeSQLLogsV2: update response param.
- Update API DescribeSampleData: update param AccessKeyId.
- Update API DescribeSupportFeatures: update param AccessKeyId.
- Update API DescribeTags: update param AccessKeyId.
- Update API DescribeWaitingSQLInfo: update param AccessKeyId.
- Update API DescribeWaitingSQLRecords: update param AccessKeyId.
- Update API DisableDBResourceGroup: update param AccessKeyId.
- Update API DownloadDiagnosisRecords: update param AccessKeyId.
- Update API DownloadSQLLogsRecords: update param AccessKeyId.
- Update API EnableDBResourceGroup: update param AccessKeyId.
- Update API GetUploadDocumentJob: update response param.
- Update API HandleActiveSQLRecord: update param AccessKeyId.
- Update API ListTagResources: update param AccessKeyId.
- Update API ModifyAccountDescription: add param ClientToken.
- Update API ModifyAccountDescription: update param AccessKeyId.
- Update API ModifyAccountDescription: update param AccountDescription.
- Update API ModifyDBInstanceConnectionString: add param ClientToken.
- Update API ModifyDBInstanceConnectionString: update param AccessKeyId.
- Update API SetDataShareInstance: update param AccessKeyId.
- Update API UpgradeExtensions: add param DatabaseName.


2024-08-29 Version: 2.0.2
- Update API DescribeDataBackups: update param EndTime.
- Update API DescribeDataBackups: update param StartTime.
- Update API ModifyMasterSpec: update param MasterCU.


2024-08-28 Version: 2.0.1
- Update API QueryCollectionData: add param RelationalTableFilter.


2024-08-23 Version: 2.0.0
- Update API CheckHadoopNetConnection: add param DataSourceId.
- Update API CheckHadoopNetConnection: update param EmrInstanceId.
- Update API CheckJDBCSourceNetConnection: add param DataSourceId.
- Update API CheckJDBCSourceNetConnection: update param JdbcConnectionString.
- Update API CreateAccount: add param AccountType.
- Update API DescribeAccounts: add param AccountType.
- Update API DescribeAccounts: update response param.
- Update API DescribeDBInstanceDataBloat: add param Database.
- Update API DescribeDBInstanceDataBloat: add param OrderBy.
- Update API DescribeDBInstanceDataSkew: add param Database.
- Update API DescribeDBInstanceDataSkew: add param OrderBy.
- Update API DescribeDBInstanceIndexUsage: add param Database.
- Update API DescribeDBInstanceIndexUsage: add param OrderBy.
- Update API DescribeDBInstanceIndexUsage: update response param.
- Update API DescribeHadoopDataSource: update response param.
- Update API DescribeJDBCDataSource: update response param.


2024-08-04 Version: 1.11.1
- Update API CancelUpsertCollectionDataJob: add param WorkspaceId.
- Update API CancelUpsertCollectionDataJob: update param DBInstanceId.
- Update API CreateCollection: add param WorkspaceId.
- Update API CreateCollection: update param DBInstanceId.
- Update API CreateNamespace: add param WorkspaceId.
- Update API CreateNamespace: update param DBInstanceId.
- Update API DeleteCollection: add param WorkspaceId.
- Update API DeleteCollection: update param DBInstanceId.
- Update API DeleteCollectionData: add param WorkspaceId.
- Update API DeleteCollectionData: update param DBInstanceId.
- Update API DeleteNamespace: add param WorkspaceId.
- Update API DeleteNamespace: update param DBInstanceId.
- Update API DescribeCollection: add param WorkspaceId.
- Update API DescribeCollection: update param DBInstanceId.
- Update API DescribeNamespace: add param WorkspaceId.
- Update API DescribeNamespace: update param DBInstanceId.
- Update API GetUpsertCollectionDataJob: add param WorkspaceId.
- Update API GetUpsertCollectionDataJob: update param DBInstanceId.
- Update API InitVectorDatabase: add param WorkspaceId.
- Update API InitVectorDatabase: update param DBInstanceId.
- Update API ListCollections: add param WorkspaceId.
- Update API ListCollections: update param DBInstanceId.
- Update API ListNamespaces: add param WorkspaceId.
- Update API ListNamespaces: update param DBInstanceId.
- Update API QueryCollectionData: add param WorkspaceId.
- Update API QueryCollectionData: update param DBInstanceId.
- Update API UpdateCollectionDataMetadata: add param WorkspaceId.
- Update API UpdateCollectionDataMetadata: update param DBInstanceId.
- Update API UpsertCollectionData: add param WorkspaceId.
- Update API UpsertCollectionData: update param DBInstanceId.
- Update API UpsertCollectionDataAsync: add param WorkspaceId.
- Update API UpsertCollectionDataAsync: update param DBInstanceId.


2024-07-19 Version: 1.11.0
- Support API CreateSecret.
- Support API DeleteSecret.
- Support API DescribeTable.
- Support API ExecuteStatement.
- Support API GetSecretValue.
- Support API ListDatabases.
- Support API ListSchemas.
- Support API ListSecrets.
- Support API ListTables.


2024-07-18 Version: 1.10.3
- Update API ListDocuments: add param MaxResults.
- Update API ListDocuments: add param NextToken.
- Update API ListDocuments: update response param.
- Update API QueryContent: add param IncludeFileUrl.


2024-07-03 Version: 1.10.2
- Update API DescribeDocument: update response param.


2024-06-27 Version: 1.10.1
- Update API DescribeStreamingDataService: update response param.
- Update API ListStreamingDataServices: update response param.


2024-06-27 Version: 1.10.1
- Update API DescribeStreamingDataService: update response param.
- Update API ListStreamingDataServices: update response param.


2024-05-28 Version: 1.10.0
- Support API BindDBResourceGroupWithRole.
- Support API CreateDBResourceGroup.
- Support API DeleteDBResourceGroup.
- Support API DescribeDBResourceGroup.
- Support API DescribeRoles.
- Support API DisableDBResourceGroup.
- Support API EnableDBResourceGroup.
- Support API ModifyDBResourceGroup.
- Support API PauseDataRedistribute.
- Support API ResumeDataRedistribute.
- Support API UnbindDBResourceGroupWithRole.


2024-05-17 Version: 1.9.0
- Support API CheckHadoopDataSource.
- Support API CheckHadoopNetConnection.
- Support API CheckJDBCSourceNetConnection.
- Support API CreateExtensions.
- Support API CreateExternalDataService.
- Support API CreateHadoopDataSource.
- Support API CreateJDBCDataSource.
- Support API CreateStreamingDataService.
- Support API CreateStreamingDataSource.
- Support API CreateStreamingJob.
- Support API DeleteExtension.
- Support API DeleteExternalDataService.
- Support API DeleteHadoopDataSource.
- Support API DeleteJDBCDataSource.
- Support API DeleteStreamingDataService.
- Support API DeleteStreamingDataSource.
- Support API DeleteStreamingJob.
- Support API DescribeExternalDataService.
- Support API DescribeHadoopClustersInSameNet.
- Support API DescribeHadoopConfigs.
- Support API DescribeHadoopDataSource.
- Support API DescribeJDBCDataSource.
- Support API DescribeStreamingDataService.
- Support API DescribeStreamingDataSource.
- Support API DescribeStreamingJob.
- Support API ListExternalDataServices.
- Support API ListExternalDataSources.
- Support API ListInstanceExtensions.
- Support API ListStreamingDataServices.
- Support API ListStreamingDataSources.
- Support API ListStreamingJobs.
- Support API ModifyExternalDataService.
- Support API ModifyHadoopDataSource.
- Support API ModifyJDBCDataSource.
- Support API ModifyStreamingDataService.
- Support API ModifyStreamingDataSource.
- Support API ModifyStreamingJob.
- Support API UpgradeExtensions.


2024-05-13 Version: 1.8.2
- Update API CreateDBInstance: update param SecurityIPList.


2024-05-11 Version: 1.8.1
- Generated csharp 2016-05-03 for gpdb.

2024-05-09 Version: 1.8.0
- Support API DescribeDBResourceManagementMode.


2024-04-29 Version: 1.7.4
- Update API QueryCollectionData: add param IncludeMetadataFields.
- Update API QueryCollectionData: add param Offset.
- Update API QueryCollectionData: add param OrderBy.
- Update API QueryCollectionData: update param HybridSearchArgs.
- Update API QueryCollectionData: update response param.
- Update API QueryContent: add param IncludeMetadataFields.


2024-04-22 Version: 1.7.3
- Update API DescribeSampleData: update response param.
- Update API QueryCollectionData: add param HybridSearch.
- Update API QueryCollectionData: add param HybridSearchArgs.
- Update API QueryContent: add param HybridSearch.
- Update API QueryContent: add param HybridSearchArgs.
- Update API QueryContent: add param IncludeVector.
- Update API QueryContent: add param RecallWindow.
- Update API QueryContent: add param RerankFactor.
- Update API QueryContent: update response param.


2024-02-19 Version: 1.7.2
- Update API DescribeSampleData: update response param.
- Update API QueryContent: add param IncludeVector.
- Update API QueryContent: add param RecallWindow.
- Update API QueryContent: add param RerankFactor.
- Update API QueryContent: update response param.


2024-01-18 Version: 1.7.1
- Generated csharp 2016-05-03 for gpdb.

2024-01-18 Version: 1.7.0
- Generated csharp 2016-05-03 for gpdb.

2024-01-17 Version: 1.6.1
- Generated csharp 2016-05-03 for gpdb.

2024-01-10 Version: 1.6.0
- Generated csharp 2016-05-03 for gpdb.

2024-01-05 Version: 1.5.0
- Generated csharp 2016-05-03 for gpdb.

2024-01-05 Version: 1.5.0
- Generated csharp 2016-05-03 for gpdb.

2024-01-04 Version: 1.4.4
- Generated csharp 2016-05-03 for gpdb.

2023-12-18 Version: 1.4.3
- Generated csharp 2016-05-03 for gpdb.

2023-12-11 Version: 1.4.2
- Generated csharp 2016-05-03 for gpdb.

2023-11-07 Version: 1.4.1
- Generated csharp 2016-05-03 for gpdb.

2023-11-06 Version: 1.4.0
- Generated csharp 2016-05-03 for gpdb.

2023-09-20 Version: 1.3.2
- Generated csharp 2016-05-03 for gpdb.

2023-09-18 Version: 1.3.1
- Generated csharp 2016-05-03 for gpdb.

2023-09-11 Version: 1.3.0
- Generated csharp 2016-05-03 for gpdb.

2023-08-18 Version: 1.2.0
- Generated csharp 2016-05-03 for gpdb.

2023-08-09 Version: 1.1.0
- Generated csharp 2016-05-03 for gpdb.

2023-07-26 Version: 1.0.25
- Add Cloud Disk Encryption.

2023-01-09 Version: 1.0.24
- Support Pause and Resume Instance.


2022-12-13 Version: 1.0.23
- Support describe cluster support features.


2022-12-12 Version: 1.0.22
- Support describe cluster support features.


2022-12-08 Version: 1.0.21
- Support describe cluster support features.


2022-11-02 Version: 1.0.19
- Support serverless v2


2022-09-26 Version: 1.0.18
- Support Openapi Tag.
- Support Tag Ram.


2022-09-14 Version: 1.0.17
- Support Openapi Tag.
- Support Tag Ram.


2022-09-05 Version: 1.0.16
- Support Resource Group.

2022-08-25 Version: 1.0.14
- Support diagnose instance.

2022-08-10 Version: 1.0.13
- Support diagnose instance.

2022-06-27 Version: 1.0.12
- Support diagnose instance.

2022-05-30 Version: 1.0.11
- Support rebalance instance.

2022-04-28 Version: 1.0.10
- Support upgrade instance.

2022-04-19 Version: 1.0.9
- Support set datashare.

2022-02-16 Version: 1.0.8
- Support set datashare.

2022-02-15 Version: 1.0.7
- AMP Version Change.

2021-10-09 Version: 1.0.6
- ADB for PG sdk.

2021-09-23 Version: 1.0.5
- ADB for PG sdk.

2021-09-09 Version: 1.0.4
- ADB for PG sdk.

2021-08-10 Version: 1.0.3
- ADB for PG SDK.

2021-03-22 Version: 1.0.2
- ADB for PG sdk.

2020-11-29 Version: 1.0.1
- ADB for PG sdk.

2020-11-16 Version: 1.0.0
- ADB for PG sdk.

