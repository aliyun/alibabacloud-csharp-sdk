2025-08-19 Version: 1.9.2
- Update API CreateSessionCluster: add request parameters body.clientToken.
- Update API ListJobRuns: add request parameters applicationConfigs.
- Update API ListJobRuns: add request parameters runtimeConfigs.
- Update API ListKyuubiServices: add response parameters Body.data.kyuubiServices.$.kyuubiReleaseVersion.
- Update API ListKyuubiSparkApplications: add response parameters Body.applications.$.exitReason.
- Update API ListKyuubiToken: add response parameters Body.data.tokens.$.accountNames.
- Update API ListKyuubiToken: add response parameters Body.data.tokens.$.memberArns.


2025-08-15 Version: 1.10.0
- Support API CreateLivyCompute.
- Support API CreateLivyComputeToken.
- Support API DeleteLivyCompute.
- Support API DeleteLivyComputeToken.
- Support API GetLivyCompute.
- Support API GetLivyComputeToken.
- Support API ListKyuubiServices.
- Support API ListKyuubiToken.
- Support API ListLivyCompute.
- Support API ListLivyComputeToken.
- Support API ListSqlStatementContents.
- Support API RefreshLivyComputeToken.
- Support API StartLivyCompute.
- Support API StopLivyCompute.
- Support API UpdateLivyCompute.
- Update API GetSessionCluster: add response parameters Body.sessionCluster.connectionToken.
- Update API ListJobRuns: add request parameters isWorkflow.
- Update API ListKyuubiSparkApplications: add request parameters minDuration.
- Update API ListKyuubiSparkApplications: add request parameters orderBy.
- Update API ListKyuubiSparkApplications: add request parameters resourceQueueId.
- Update API ListKyuubiSparkApplications: add request parameters sort.
- Update API ListKyuubiSparkApplications: add response parameters Body.applications.$.latestSqlStatementStatus.
- Update API ListSessionClusters: add response parameters Body.sessionClusters.$.connectionToken.


2025-05-30 Version: 1.8.6
- Generated csharp 2023-08-08 for emr-serverless-spark.

2025-05-19 Version: 1.8.5
- Update API CreateSessionCluster: add request parameters body.publicEndpointEnabled.
- Update API GetSessionCluster: add response parameters Body.sessionCluster.publicEndpointEnabled.
- Update API GetTemplate: add request parameters templateBizId.
- Update API ListSessionClusters: add response parameters Body.sessionClusters.$.publicEndpointEnabled.
- Update API ListWorkspaces: add response parameters Body.workspaces.$.prePaidQuota.orderId.


2025-05-16 Version: 1.8.4
- Generated csharp 2023-08-08 for emr-serverless-spark.

2025-05-06 Version: 1.8.3
- Generated csharp 2023-08-08 for emr-serverless-spark.

2024-12-24 Version: 1.9.0
- Support API CreateProcessDefinitionWithSchedule.
- Support API StartProcessInstance.
- Support API UpdateProcessDefinitionWithSchedule.


2024-12-10 Version: 1.8.1
- Update API ListJobRuns: update response param.


2024-11-27 Version: 1.8.0
- Support API GetTemplate.


2024-11-25 Version: 1.7.1
- Update API GetJobRun: update response param.
- Update API GetSessionCluster: update response param.
- Update API ListSessionClusters: update response param.


2024-11-15 Version: 1.7.0
- Support API GetSessionCluster.


2024-11-06 Version: 1.6.0
- Support API ListLogContents.


2024-10-17 Version: 1.5.0
- Support API StartSessionCluster.
- Support API StopSessionCluster.
- Update API ListJobRuns: update param workspaceId.
- Update API ListJobRuns: update param creator.
- Update API ListJobRuns: update param endTime.
- Update API ListJobRuns: update param jobRunDeploymentId.
- Update API ListJobRuns: update param jobRunId.
- Update API ListJobRuns: update param maxResults.
- Update API ListJobRuns: update param name.
- Update API ListJobRuns: update param nextToken.
- Update API ListJobRuns: update param resourceQueueId.
- Update API ListJobRuns: update param startTime.
- Update API ListJobRuns: update param states.
- Update API ListJobRuns: update param tags.


2024-09-10 Version: 1.4.4
- Update API ListReleaseVersions: add param workspaceId.


2024-08-22 Version: 1.4.3
- Update API GetJobRun: update response param.


2024-08-20 Version: 1.4.2
- Update API ListJobRuns: update response param.
- Update API ListReleaseVersions: update response param.
- Update API ListSessionClusters: update response param.
- Update API ListWorkspaces: update response param.
- Update API StartJobRun: update param body.


2024-07-09 Version: 1.4.1
- Update API ListSessionClusters: add param kind.
- Update API ListSessionClusters: update response param.


2024-05-31 Version: 1.4.0
- Support API CreateSqlStatement.
- Support API GetSqlStatement.
- Support API TerminateSqlStatement.
- Update API ListJobRuns: add param jobRunDeploymentId.


2024-05-22 Version: 1.3.0
- Support API AddMembers.
- Support API GrantRoleToUsers.


2024-05-21 Version: 1.2.0
- Support API ListSessionClusters.


2024-05-20 Version: 1.1.0
- Support API ListReleaseVersions.
- Support API ListWorkspaceQueues.
- Support API ListWorkspaces.


2024-05-17 Version: 1.0.1
- Update API CancelJobRun: update param workspaceId.
- Update API CancelJobRun: update param jobRunId.
- Update API GetJobRun: update param workspaceId.
- Update API GetJobRun: update param jobRunId.
- Update API ListJobRuns: update param workspaceId.
- Update API StartJobRun: update param workspaceId.


2024-04-16 Version: 1.0.0
- Generated csharp 2023-08-08 for emr-serverless-spark.

