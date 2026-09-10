// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data body returned by the operation. For the field structure, see the descriptions of child fields.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataCheckTaskConfigResponseBodyData Data { get; set; }
        public class GetDataCheckTaskConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch ID that uniquely identifies a data validation batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public long? BatchId { get; set; }

            /// <summary>
            /// <para>The global node parameter settings (built-in configuration of the data validation service).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("checkGlobalParams")]
            [Validation(Required=false)]
            public string CheckGlobalParams { get; set; }

            /// <summary>
            /// <para>The validation template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("checkTemplateId")]
            [Validation(Required=false)]
            public string CheckTemplateId { get; set; }

            /// <summary>
            /// <para>The validation rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: data volume comparison.</description></item>
            /// <item><description>1: metric comparison.</description></item>
            /// <item><description>2: weak content comparison.</description></item>
            /// <item><description>3: custom comparison.</description></item>
            /// <item><description>4: full-text comparison.</description></item>
            /// <item><description>5: null value ratio comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The batch concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>The scheduling cycle expression (cron expression).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 2 * * ?</para>
            /// </summary>
            [NameInMap("cronExp")]
            [Validation(Required=false)]
            public string CronExp { get; set; }

            /// <summary>
            /// <para>The task configuration table.</para>
            /// </summary>
            [NameInMap("dataCheckConfig")]
            [Validation(Required=false)]
            public List<GetDataCheckTaskConfigResponseBodyDataDataCheckConfig> DataCheckConfig { get; set; }
            public class GetDataCheckTaskConfigResponseBodyDataDataCheckConfig : TeaModel {
                /// <summary>
                /// <para>The validation algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public int? Algorithm { get; set; }

                /// <summary>
                /// <para>The batch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001</para>
                /// </summary>
                [NameInMap("batchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// <para>The batch size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("batchSize")]
                [Validation(Required=false)]
                public int? BatchSize { get; set; }

                /// <summary>
                /// <para>The validation rule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: data volume comparison.</description></item>
                /// <item><description>1: metric comparison.</description></item>
                /// <item><description>2: weak content comparison.</description></item>
                /// <item><description>3: custom comparison.</description></item>
                /// <item><description>4: full-text comparison.</description></item>
                /// <item><description>5: null value ratio comparison.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("checkType")]
                [Validation(Required=false)]
                public int? CheckType { get; set; }

                /// <summary>
                /// <para>The comparison type. Valid values: =, !=, &gt;, &lt;, &gt;=, &lt;=, contains, does not contain, and ==.</para>
                /// 
                /// <b>Example:</b>
                /// <para>=</para>
                /// </summary>
                [NameInMap("comparator")]
                [Validation(Required=false)]
                public string Comparator { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("extra")]
                [Validation(Required=false)]
                public object Extra { get; set; }

                /// <summary>
                /// <para>The group data volume comparison threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("groupCountThreshold")]
                [Validation(Required=false)]
                public float? GroupCountThreshold { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Specifies whether to perform a full table count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isFullTableCount")]
                [Validation(Required=false)]
                public int? IsFullTableCount { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: No.</description></item>
                /// <item><description>1: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("isSkipped")]
                [Validation(Required=false)]
                public int? IsSkipped { get; set; }

                /// <summary>
                /// <para>The metric type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM_METRIC_NUM: built-in NUM mode.</description></item>
                /// <item><description>CUSTOM_METRIC_LEN: built-in LEN mode.</description></item>
                /// <item><description>CUSTOM_METRIC_MIX: built-in MIX mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM_METRIC_MIX</para>
                /// </summary>
                [NameInMap("metricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The source table columns. You can specify multiple columns separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("sourceColumns")]
                [Validation(Required=false)]
                public string SourceColumns { get; set; }

                /// <summary>
                /// <para>The source comparison key (the key field used for data comparison between the source and destination).</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("sourceCompareKey")]
                [Validation(Required=false)]
                public string SourceCompareKey { get; set; }

                /// <summary>
                /// <para>The source data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_demo</para>
                /// </summary>
                [NameInMap("sourceDataSource")]
                [Validation(Required=false)]
                public string SourceDataSource { get; set; }

                /// <summary>
                /// <para>The GROUP BY clause for the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("sourceGroupClause")]
                [Validation(Required=false)]
                public string SourceGroupClause { get; set; }

                [NameInMap("sourceHint")]
                [Validation(Required=false)]
                public string SourceHint { get; set; }

                /// <summary>
                /// <para>The source data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The source partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20260116</para>
                /// </summary>
                [NameInMap("sourcePartition")]
                [Validation(Required=false)]
                public string SourcePartition { get; set; }

                /// <summary>
                /// <para>The source SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM t;</para>
                /// </summary>
                [NameInMap("sourceSql")]
                [Validation(Required=false)]
                public string SourceSql { get; set; }

                /// <summary>
                /// <para>The source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("sourceTable")]
                [Validation(Required=false)]
                public string SourceTable { get; set; }

                /// <summary>
                /// <para>The source data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hive</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The WHERE clause for the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
                /// </summary>
                [NameInMap("sourceWhereClause")]
                [Validation(Required=false)]
                public string SourceWhereClause { get; set; }

                /// <summary>
                /// <para>The destination table columns. You can specify multiple columns separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("targetColumns")]
                [Validation(Required=false)]
                public string TargetColumns { get; set; }

                /// <summary>
                /// <para>The destination comparison key (the key field used for data comparison between the source and destination).</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("targetCompareKey")]
                [Validation(Required=false)]
                public string TargetCompareKey { get; set; }

                /// <summary>
                /// <para>The destination data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds_demo</para>
                /// </summary>
                [NameInMap("targetDataSource")]
                [Validation(Required=false)]
                public string TargetDataSource { get; set; }

                /// <summary>
                /// <para>The GROUP BY clause for the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("targetGroupClause")]
                [Validation(Required=false)]
                public string TargetGroupClause { get; set; }

                [NameInMap("targetHint")]
                [Validation(Required=false)]
                public string TargetHint { get; set; }

                /// <summary>
                /// <para>The destination ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001</para>
                /// </summary>
                [NameInMap("targetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// <para>The destination partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20260116</para>
                /// </summary>
                [NameInMap("targetPartition")]
                [Validation(Required=false)]
                public string TargetPartition { get; set; }

                /// <summary>
                /// <para>The destination SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM t;</para>
                /// </summary>
                [NameInMap("targetSql")]
                [Validation(Required=false)]
                public string TargetSql { get; set; }

                /// <summary>
                /// <para>The destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("targetTable")]
                [Validation(Required=false)]
                public string TargetTable { get; set; }

                /// <summary>
                /// <para>The destination data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hive</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The WHERE clause for the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
                /// </summary>
                [NameInMap("targetWhereClause")]
                [Validation(Required=false)]
                public string TargetWhereClause { get; set; }

                /// <summary>
                /// <para>The validation task configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("taskConfigId")]
                [Validation(Required=false)]
                public long? TaskConfigId { get; set; }

                /// <summary>
                /// <para>The validation task configuration information (regular expression matching rules). This parameter takes effect only when taskMode is set to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lhm|lhm_dw|*</para>
                /// </summary>
                [NameInMap("taskConfigInfo")]
                [Validation(Required=false)]
                public string TaskConfigInfo { get; set; }

                /// <summary>
                /// <para>The validation batch token. Together with batchId, it identifies the result records generated by a validation batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9f2c7a1e4b8d****</para>
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                /// <summary>
                /// <para>The total data volume comparison threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("totalCountThreshold")]
                [Validation(Required=false)]
                public float? TotalCountThreshold { get; set; }

            }

            /// <summary>
            /// <para>The destination data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("dstDsId")]
            [Validation(Required=false)]
            public string DstDsId { get; set; }

            /// <summary>
            /// <para>The destination data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("dstDsName")]
            [Validation(Required=false)]
            public string DstDsName { get; set; }

            /// <summary>
            /// <para>The destination data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dstDsType")]
            [Validation(Required=false)]
            public string DstDsType { get; set; }

            /// <summary>
            /// <para>The ID of the destination verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("dstEngineId")]
            [Validation(Required=false)]
            public string DstEngineId { get; set; }

            /// <summary>
            /// <para>The name of the destination verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine_demo</para>
            /// </summary>
            [NameInMap("dstEngineName")]
            [Validation(Required=false)]
            public string DstEngineName { get; set; }

            /// <summary>
            /// <para>The type of the destination verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tez</para>
            /// </summary>
            [NameInMap("dstEngineType")]
            [Validation(Required=false)]
            public string DstEngineType { get; set; }

            /// <summary>
            /// <para>The execution type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: immediate execution</description></item>
            /// <item><description>1: scheduled execution</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public int? ExecuteType { get; set; }

            /// <summary>
            /// <para>The count mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: count by partition</description></item>
            /// <item><description>1: count the entire table</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fullTableCount")]
            [Validation(Required=false)]
            public int? FullTableCount { get; set; }

            /// <summary>
            /// <para>The group data volume comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("groupCountThreshold")]
            [Validation(Required=false)]
            public float? GroupCountThreshold { get; set; }

            /// <summary>
            /// <para>Indicates whether the template is a built-in template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isBuiltin")]
            [Validation(Required=false)]
            public int? IsBuiltin { get; set; }

            /// <summary>
            /// <para>Indicates whether scheduling is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public int? IsScheduled { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is on the whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isWhiteList")]
            [Validation(Required=false)]
            public int? IsWhiteList { get; set; }

            /// <summary>
            /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task (scheduling ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("scheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            /// <summary>
            /// <para>The scope filter JSON data.</para>
            /// </summary>
            [NameInMap("scopeFilter")]
            [Validation(Required=false)]
            public GetDataCheckTaskConfigResponseBodyDataScopeFilter ScopeFilter { get; set; }
            public class GetDataCheckTaskConfigResponseBodyDataScopeFilter : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-14 13:59:00</para>
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The last N parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("lastN")]
                [Validation(Required=false)]
                public int? LastN { get; set; }

                /// <summary>
                /// <para>The filter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("scopeFilterType")]
                [Validation(Required=false)]
                public int? ScopeFilterType { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-14 11:21:00</para>
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The source node parameter settings (source execute parameters).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("sourceGlobalParams")]
            [Validation(Required=false)]
            public string SourceGlobalParams { get; set; }

            /// <summary>
            /// <para>The ID of the source data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("srcDsId")]
            [Validation(Required=false)]
            public string SrcDsId { get; set; }

            /// <summary>
            /// <para>The name of the source data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("srcDsName")]
            [Validation(Required=false)]
            public string SrcDsName { get; set; }

            /// <summary>
            /// <para>The type of the source data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("srcDsType")]
            [Validation(Required=false)]
            public string SrcDsType { get; set; }

            /// <summary>
            /// <para>The ID of the source verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("srcEngineId")]
            [Validation(Required=false)]
            public string SrcEngineId { get; set; }

            /// <summary>
            /// <para>The name of the source verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine_demo</para>
            /// </summary>
            [NameInMap("srcEngineName")]
            [Validation(Required=false)]
            public string SrcEngineName { get; set; }

            /// <summary>
            /// <para>The type of the source verification engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tez</para>
            /// </summary>
            [NameInMap("srcEngineType")]
            [Validation(Required=false)]
            public string SrcEngineType { get; set; }

            /// <summary>
            /// <para>Indicates whether to start the task immediately. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("startImmediately")]
            [Validation(Required=false)]
            public int? StartImmediately { get; set; }

            /// <summary>
            /// <para>The destination node parameter settings (destination execute parameters).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("targetGlobalParams")]
            [Validation(Required=false)]
            public string TargetGlobalParams { get; set; }

            /// <summary>
            /// <para>The regular expression information of the verification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lhm|lhm_dw|*</para>
            /// </summary>
            [NameInMap("taskConfigInfo")]
            [Validation(Required=false)]
            public string TaskConfigInfo { get; set; }

            /// <summary>
            /// <para>The task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data validation node description</para>
            /// </summary>
            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <para>The task ID, which uniquely identifies a task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The parameter creation mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: fine-grained creation on a per-table basis</description></item>
            /// <item><description>1: batch creation with the same pattern</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("taskMode")]
            [Validation(Required=false)]
            public int? TaskMode { get; set; }

            /// <summary>
            /// <para>The task name. When used as a query condition, fuzzy matching with % is supported (SQL syntax).</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_check_task_demo</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The name of the verification template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data volume verification template</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The total data volume comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("totalCountThreshold")]
            [Validation(Required=false)]
            public float? TotalCountThreshold { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check errCode and errMessage for troubleshooting.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
