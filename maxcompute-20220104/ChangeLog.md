2025-11-25 Version: 3.0.0
- Support API DeleteProject.
- Support API QueryQuotaMetric.
- Support API UpdateProjectModelTier.
- Update API CreateMmsJob: add request parameters body.enableDataMigration.
- Update API CreateMmsJob: add request parameters body.enableSchemaMigration.
- Update API GetMmsDataSource: add response parameters Body.data.dstProject.
- Update API GetMmsDataSource: add response parameters Body.data.dstProjects.
- Update API GetMmsDb: add response parameters Body.data.dstName.
- Update API GetMmsDb: add response parameters Body.data.dstProjectName.
- Update API GetMmsPartition: add response parameters Body.data.dbId.
- Update API GetMmsPartition: add response parameters Body.data.dstProjectName.
- Update API GetMmsPartition: add response parameters Body.data.dstSchemaName.
- Update API GetMmsPartition: add response parameters Body.data.dstTableName.
- Update API GetMmsPartition: add response parameters Body.data.dstValue.
- Update API GetMmsPartition: delete response parameters Body.data.DbId.
- Update API GetMmsTable: add response parameters Body.data.dstName.
- Update API GetMmsTable: add response parameters Body.data.dstProjectName.
- Update API GetMmsTable: add response parameters Body.data.dstSchemaName.
- Update API GetProject: add request parameters withQuotaProductType.
- Update API GetProject: add request parameters withStorageTierInfo.
- Update API ListMmsDataSources: add response parameters Body.data.objectList.$.dstProject.
- Update API ListMmsDataSources: add response parameters Body.data.objectList.$.dstProjects.
- Update API ListMmsDbs: add response parameters Body.data.objectList.$.dstName.
- Update API ListMmsDbs: add response parameters Body.data.objectList.$.dstProjectName.
- Update API ListMmsJobs: add request parameters timerId.
- Update API ListMmsPartitions: add request parameters tableId.
- Update API ListMmsPartitions: add response parameters Body.data.objectList.$.dbId.
- Update API ListMmsPartitions: add response parameters Body.data.objectList.$.dstProjectName.
- Update API ListMmsPartitions: add response parameters Body.data.objectList.$.dstSchemaName.
- Update API ListMmsPartitions: add response parameters Body.data.objectList.$.dstTableName.
- Update API ListMmsPartitions: add response parameters Body.data.objectList.$.dstValue.
- Update API ListMmsPartitions: delete response parameters Body.data.objectList.$.DbId.
- Update API ListMmsTables: add request parameters dstName.
- Update API ListMmsTables: add request parameters dstProjectName.
- Update API ListMmsTables: add request parameters dstSchemaName.
- Update API ListMmsTables: add response parameters Body.data.objectList.$.dstName.
- Update API ListMmsTables: add response parameters Body.data.objectList.$.dstProjectName.
- Update API ListMmsTables: add response parameters Body.data.objectList.$.dstSchemaName.
- Update API ListQuotas: add response parameters Body.data.quotaInfoList.$.subQuotaInfoList.$.parameter.adhocSlot.
- Update API ListQuotas: add response parameters Body.data.quotaInfoList.$.subQuotaInfoList.$.parameter.autoScaleCPULimit.
- Update API ListQuotas: add response parameters Body.data.quotaInfoList.$.subQuotaInfoList.$.parameter.maxGu.
- Update API ListQuotas: add response parameters Body.data.quotaInfoList.$.subQuotaInfoList.$.parameter.minGu.
- Update API ListQuotas: add response parameters Body.data.quotaInfoList.$.subQuotaInfoList.$.parameter.slotNum.
- Update API ListQuotas: add response parameters Body.quotaInfoList.$.subQuotaInfoList.$.parameter.adhocSlot.
- Update API ListQuotas: add response parameters Body.quotaInfoList.$.subQuotaInfoList.$.parameter.autoScaleCPULimit.
- Update API ListQuotas: add response parameters Body.quotaInfoList.$.subQuotaInfoList.$.parameter.maxGu.
- Update API ListQuotas: add response parameters Body.quotaInfoList.$.subQuotaInfoList.$.parameter.minGu.
- Update API ListQuotas: add response parameters Body.quotaInfoList.$.subQuotaInfoList.$.parameter.slotNum.


2025-08-05 Version: 1.7.0
- Support API SumStorageMetricsByDate.
- Update API GetProject: add response parameters Body.data.properties.externalProjectProperties.externalCatalogId.
- Update API GetProject: add response parameters Body.data.properties.externalProjectProperties.foreignServerName.
- Update API GetProject: add response parameters Body.data.properties.externalProjectProperties.foreignServerType.
- Update API GetProject: add response parameters Body.data.properties.externalProjectProperties.tableFormat.
- Update API GetProject: add response parameters Body.data.properties.externalProjectProperties.warehouse.


2025-07-11 Version: 1.6.0
- Support API GetStorageAmountSummary.
- Support API GetStorageSizeSummary.
- Support API GetStorageSummaryCompared.
- Support API ListStorageProjectsInfo.
- Support API QueryStorageMetric.
- Support API UpdateUsersToRole.


2025-05-30 Version: 1.5.1
- Generated csharp 2022-01-04 for MaxCompute.

2025-04-23 Version: 1.5.0
- Support API QueryTunnelMetric.
- Support API QueryTunnelMetricDetail.


2025-03-25 Version: 1.4.3
- Update API UpdateProjectBasicMeta: update param body.


2025-02-18 Version: 2.0.0
- Support API ApplyComputeQuotaPlan.
- Support API CreateComputeQuotaPlan.
- Support API CreateMmsDataSource.
- Support API CreateMmsFetchMetadataJob.
- Support API CreateMmsJob.
- Support API DeleteComputeQuotaPlan.
- Support API DeleteMmsDataSource.
- Support API DeleteMmsJob.
- Support API GetComputeEffectivePlan.
- Support API GetComputeQuotaPlan.
- Support API GetComputeQuotaSchedule.
- Support API GetMmsAsyncTask.
- Support API GetMmsDataSource.
- Support API GetMmsDb.
- Support API GetMmsFetchMetadataJob.
- Support API GetMmsJob.
- Support API GetMmsPartition.
- Support API GetMmsTable.
- Support API GetMmsTask.
- Support API GetQuotaUsage.
- Support API ListComputeMetricsByInstance.
- Support API ListComputeQuotaPlan.
- Support API ListJobMetric.
- Support API ListJobSnapshotInfos.
- Support API ListMmsDataSources.
- Support API ListMmsDbs.
- Support API ListMmsJobs.
- Support API ListMmsPartitions.
- Support API ListMmsTables.
- Support API ListMmsTaskLogs.
- Support API ListMmsTasks.
- Support API ListStoragePartitionsInfo.
- Support API ListStorageTablesInfo.
- Support API ListTunnelQuotaTimer.
- Support API QueryQuota.
- Support API RetryMmsJob.
- Support API StartMmsJob.
- Support API StopMmsJob.
- Support API UpdateComputeQuotaPlan.
- Support API UpdateComputeQuotaSchedule.
- Support API UpdateComputeSubQuota.
- Support API UpdateMmsDataSource.
- Support API UpdateProjectBasicMeta.
- Support API UpdateProjectDefaultQuota.
- Support API UpdateTunnelQuotaTimer.
- Delete API CreateQuotaSchedule.
- Delete API UpdateQuota.
- Update API GetProject: update response param.
- Update API GetRoleAclOnObject: update response param.
- Update API GetTableInfo: update response param.
- Update API ListJobInfos: add param body.
- Update API ListJobInfos: update param body.
- Update API ListJobInfos: update response param.
- Update API ListProjects: update response param.
- Update API ListTables: update response param.


2024-06-24 Version: 1.4.1
- Update API GetProject: update response param.


2024-04-17 Version: 1.4.0
- Support API GetTableInfo.
- Update API GetProject: update response param.


2024-02-28 Version: 1.3.0
- Support API GetTableInfo.


2024-01-08 Version: 1.2.1
- Generated csharp 2022-01-04 for MaxCompute.

2024-01-08 Version: 1.2.1
- Generated csharp 2022-01-04 for MaxCompute.

2023-12-28 Version: 1.2.0
- Generated csharp 2022-01-04 for MaxCompute.

2023-12-10 Version: 1.1.3
- Generated csharp 2022-01-04 for MaxCompute.

2023-11-16 Version: 1.1.2
- Generated csharp 2022-01-04 for MaxCompute.

2023-11-14 Version: 1.1.1
- Generated csharp 2022-01-04 for MaxCompute.

2023-10-24 Version: 1.1.0
- Generated csharp 2022-01-04 for MaxCompute.

2023-08-23 Version: 1.0.0
- Generated csharp 2022-01-04 for MaxCompute.

