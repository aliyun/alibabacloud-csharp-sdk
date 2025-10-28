2025-10-28 Version: 2.5.4
- Update API DescribeSlowLogHistogramAsync: add response parameters Body.Data.Data.TotalCount.
- Update API DescribeSlowLogHistogramAsync: add response parameters Body.Data.Data.Item.$.InsRole.
- Update API DescribeSlowLogHistogramAsync: add response parameters Body.Data.Data.Item.$.TotalCount.
- Update API DescribeSlowLogHistogramAsync: add response parameters Body.Data.Data.Item.$.InsItems.$.TotalCount.


2025-09-23 Version: 2.5.3
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.ClientIp.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.Cmd.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.DbId.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.NodeId.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.OriginTime.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.RequestSize.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.ResponseSize.
- Update API DescribeSlowLogRecords: add response parameters Body.Data.Logs.$.Rt.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.AvgRequestSize.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.AvgResponseSize.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.AvgRt.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.ClientIp.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.Cmd.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.DbId.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.MaxRequestSize.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.MaxResponseSize.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.MaxRt.
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.TotalCount.


2025-09-09 Version: 2.5.2
- Update API DescribeSqlLogRecords: add response parameters Body.Data.Items.SQLLogRecord.$.TableName.
- Update API ModifySqlLogConfig: add response parameters Body.Data.SqlLogSource.


2025-08-21 Version: 2.5.1
- Update API DescribeHotBigKeys: add response parameters Body.Data.HighTrafficKeyMsg.
- Update API DescribeHotBigKeys: add response parameters Body.Data.HighTrafficKeys.
- Update API DescribeHotBigKeys: add response parameters Body.Data.HotKeys.$.Size.
- Update API DescribeHotKeys: add response parameters Body.Data.$.Category.
- Update API DescribeHotKeys: add response parameters Body.Data.$.InBytes.
- Update API DescribeHotKeys: add response parameters Body.Data.$.NodeId.
- Update API DescribeHotKeys: add response parameters Body.Data.$.OutBytes.
- Update API DescribeTopHotKeys: add response parameters Body.Data.$.Category.
- Update API DescribeTopHotKeys: add response parameters Body.Data.$.InBytes.
- Update API DescribeTopHotKeys: add response parameters Body.Data.$.OutBytes.


2025-07-24 Version: 2.5.0
- Support API DescribeErrorLogRecords.


2025-07-22 Version: 2.4.4
- Update API GetDasSQLLogHotData: add response parameters Body.Data.List.$.NodeId.


2025-06-25 Version: 2.4.3
- Generated csharp 2020-01-16 for DAS.

2025-06-25 Version: 2.4.3
- Generated csharp 2020-01-16 for DAS.

2025-06-24 Version: 2.4.2
- Generated csharp 2020-01-16 for DAS.

2025-06-05 Version: 2.4.1
- Update API DescribeSqlLogStatistic: add response parameters Body.Data.TotalSqlSize.
- Update API DescribeSqlLogTasks: add response parameters Body.Data.List.$.InnerResult.


2025-05-20 Version: 2.4.0
- Support API DescribeQueryExplain.
- Support API DescribeSlowLogRecords.


2025-04-01 Version: 2.3.4
- Update API DescribeSlowLogStatistic: add response parameters Body.Data.Data.Logs.$.RuleId.
- Update API DescribeSqlLogTask: add response parameters Body.Data.Queries.$.SqlCommand.


2025-02-28 Version: 2.3.2
- Update API ModifySqlLogConfig: add param EnableAudit.


2025-02-11 Version: 2.3.1
- Update API DescribeSlowLogHistogramAsync: update param EndTime.
- Update API DescribeSlowLogHistogramAsync: update param InstanceId.
- Update API DescribeSlowLogHistogramAsync: update param StartTime.
- Update API DescribeSlowLogHistogramAsync: update response param.
- Update API DescribeSlowLogStatistic: update param EndTime.
- Update API DescribeSlowLogStatistic: update param InstanceId.
- Update API DescribeSlowLogStatistic: update param StartTime.
- Update API DescribeSlowLogStatistic: update response param.


2024-12-26 Version: 2.3.0
- Support API DescribeSlowLogHistogramAsync.
- Support API DescribeSlowLogStatistic.


2024-11-29 Version: 2.2.0
- Support API CreateLatestDeadLockAnalysis.
- Support API GetDeadLockDetail.
- Support API GetDeadLockHistory.
- Support API GetDeadlockHistogram.
- Delete API CreateAdamBenchTask.
- Delete API StopCloudBenchTask.
- Delete API SyncHDMAliyunResource.
- Update API GetAsyncErrorRequestStatResult: update response param.


2024-07-23 Version: 2.1.4
- Update API DescribeSqlLogConfig: update response param.


2024-07-03 Version: 2.1.3
- Update API DescribeSqlLogTask: update response param.


2024-06-13 Version: 2.1.2
- Update API DescribeCacheAnalysisJob: update response param.
- Update API DescribeSqlLogRecords: update response param.
- Update API DescribeSqlLogTask: update response param.


2024-05-15 Version: 2.1.1
- Update API GetStorageAnalysisResult: update response param.


2024-04-25 Version: 2.1.0
- Support API CreateSqlLogTask.
- Support API DescribeSqlLogConfig.
- Support API DescribeSqlLogRecords.
- Support API DescribeSqlLogStatistic.
- Support API DescribeSqlLogTask.
- Support API DescribeSqlLogTasks.
- Support API ModifySqlLogConfig.


2024-02-27 Version: 2.0.1
- Update API GetPfsSqlSample: update param EndTime.
- Update API GetPfsSqlSample: update param InstanceId.
- Update API GetPfsSqlSample: update param StartTime.
- Update API ModifyAutoScalingConfig: update param Bandwidth.
- Update API ModifyAutoScalingConfig: update response param.


2024-02-21 Version: 2.0.0
- Generated csharp 2020-01-16 for DAS.

