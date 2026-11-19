// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListAlertEventsResponseBodyListResult ListResult { get; set; }
        public class ListAlertEventsResponseBodyListResult : TeaModel {
            /// <summary>
            /// <para>The alert event query result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAlertEventsResponseBodyListResultData> Data { get; set; }
            public class ListAlertEventsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>The alert frequency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ONCE: Immediate alert.</description></item>
                /// <item><description>PERIOD: Periodic alert. Format: 1HOUR, 1MINUTE, 1SECOND.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("AlertFrequency")]
                [Validation(Required=false)]
                public string AlertFrequency { get; set; }

                /// <summary>
                /// <para>The alert object.</para>
                /// </summary>
                [NameInMap("AlertObject")]
                [Validation(Required=false)]
                public ListAlertEventsResponseBodyListResultDataAlertObject AlertObject { get; set; }
                public class ListAlertEventsResponseBodyListResultDataAlertObject : TeaModel {
                    /// <summary>
                    /// <para>The name of the alert object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The source system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALL: All.</description></item>
                    /// <item><description>DQE: Data quality.</description></item>
                    /// <item><description>OS: Data service.</description></item>
                    /// <item><description>STREAM: Real-time computing.</description></item>
                    /// <item><description>VDM_BATCH: Offline computing.</description></item>
                    /// <item><description>SOP: O&amp;M platform.</description></item>
                    /// <item><description>REAL_TIME_PIPELINE: Real-time integration.</description></item>
                    /// <item><description>KGB: Baseline monitoring.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VDM_BATCH</para>
                    /// </summary>
                    [NameInMap("SourceSystemType")]
                    [Validation(Required=false)]
                    public string SourceSystemType { get; set; }

                    /// <summary>
                    /// <para>The alert object type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>OS_API: API operation.</description></item>
                    /// <item><description>OS_APPLICATION_SERVICE: Service application.</description></item>
                    /// <item><description>STREAM_TASK: Real-time computing.</description></item>
                    /// <item><description>REAL_TIME_PIPELINE_TASK: Real-time integration.</description></item>
                    /// <item><description>VDM_BATCH_SHELL: SHELL.</description></item>
                    /// <item><description>VDM_BATCH_PYTHON: PYTHON.</description></item>
                    /// <item><description>VDM_BATCH_DATAX: DATAX.</description></item>
                    /// <item><description>VDM_BATCH_DLINK: DLINK.</description></item>
                    /// <item><description>VDM_BATCH_VIRTUAL: VIRTUAL.</description></item>
                    /// <item><description>VDM_BATCH_PYTHON37: PYTHON37.</description></item>
                    /// <item><description>VDM_BATCH_PYTHON311: PYTHON311.</description></item>
                    /// <item><description>VDM_BATCH_MAX_COMPUTE_SQL: MAXCOMPUTE_SQL.</description></item>
                    /// <item><description>VDM_BATCH_MAX_COMPUTE_MR: MAXCOMPUTE_MR.</description></item>
                    /// <item><description>VDM_BATCH_SPARK_JAR_ON_MAX_COMPUTE: SPARK_JAR_ON_MAX_COMPUTE.</description></item>
                    /// <item><description>VDM_BATCH_HIVE_SQL: HIVE_SQL.</description></item>
                    /// <item><description>VDM_BATCH_HADOOP_MR: HADOOP_MR.</description></item>
                    /// <item><description>VDM_BATCH_SPARK_JAR_ON_HIVE: SPARK_JAR_ON_HIVE.</description></item>
                    /// <item><description>VDM_BATCH_SPARK_SQL_ON_HIVE: SPARK_SQL_ON_HIVE.</description></item>
                    /// <item><description>VDM_BATCH_SPARK_SQL: VDM_BATCH_SPARK_SQL.</description></item>
                    /// <item><description>DQE_LOGICAL_TABLE: Logical table.</description></item>
                    /// <item><description>DQE_PHYSICAL_TABLE: Physical table.</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: Real-time metadata table.</description></item>
                    /// <item><description>DQE_DATA_SOURCE: Data source.</description></item>
                    /// <item><description>DQE_INDEX: Metric.</description></item>
                    /// <item><description>QD_DECISION_INVOKE: QD decision invocation.</description></item>
                    /// <item><description>BASELINE: Baseline.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STREAM_TASK</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The alert cause.</para>
                /// </summary>
                [NameInMap("AlertReason")]
                [Validation(Required=false)]
                public ListAlertEventsResponseBodyListResultDataAlertReason AlertReason { get; set; }
                public class ListAlertEventsResponseBodyListResultDataAlertReason : TeaModel {
                    /// <summary>
                    /// <para>The list of alert cause parameters.</para>
                    /// </summary>
                    [NameInMap("AlertReasonParamList")]
                    [Validation(Required=false)]
                    public List<ListAlertEventsResponseBodyListResultDataAlertReasonAlertReasonParamList> AlertReasonParamList { get; set; }
                    public class ListAlertEventsResponseBodyListResultDataAlertReasonAlertReasonParamList : TeaModel {
                        /// <summary>
                        /// <para>The name of the alert cause parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>biz_date</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the alert cause parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-11-24 00:00:00</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The business date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-11-25 10:02:47</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The alert cause. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DQE_COLUMN: Field rule exception.</description></item>
                    /// <item><description>DQE_DATA_SOURCE: Data source rule exception.</description></item>
                    /// <item><description>DQE_CUSTOMIZE: Custom rule exception.</description></item>
                    /// <item><description>DQE_TABLE: Table rule exception.</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: Real-time table rule exception.</description></item>
                    /// <item><description>DQE_INDEX: Metric rule exception.</description></item>
                    /// <item><description>OS_AVG_RESPONSE: Average response time exception.</description></item>
                    /// <item><description>OS_CALL_TIMES: Call count exception.</description></item>
                    /// <item><description>OS_ERROR_RATE: Error rate exception.</description></item>
                    /// <item><description>OS_OFFLINE: Offline percentage exception.</description></item>
                    /// <item><description>STREAM_BIZ_DELAY: High business delay.</description></item>
                    /// <item><description>STREAM_DATA_RETENTION: Data retention exceeds configuration.</description></item>
                    /// <item><description>STREAM_MORE_THAN_FAILURE: Failure frequency exceeds configuration.</description></item>
                    /// <item><description>STREAM_TPS_OUT_RANGE: TPS out of range.</description></item>
                    /// <item><description>STREAM_CHECKPOINT_FAILURE: Checkpoint failures exceed configuration.</description></item>
                    /// <item><description>STREAM_BACKPRESSURE: Backpressure duration exceeds configuration.</description></item>
                    /// <item><description>STREAM_JOB_FAILURE: Run failure.</description></item>
                    /// <item><description>VDM_BATCH_ERROR: Error.</description></item>
                    /// <item><description>VDM_BATCH_FINISH: Completed.</description></item>
                    /// <item><description>VDM_BATCH_TIME_OUT: Run timeout.</description></item>
                    /// <item><description>VDM_BATCH_UNDONE: Uncompleted.</description></item>
                    /// <item><description>VDM_BATCH_LOGIC_DATA_DELAY: Data delay.</description></item>
                    /// <item><description>QD_DECISION_CALL_TIMES: Decision call count exception.</description></item>
                    /// <item><description>QD_DECISION_MAX_RESPONSE: Maximum response time exception.</description></item>
                    /// <item><description>QD_DECISION_ERROR_RATE: Error rate exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_COUNT: Decision parameter count exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_PERCENTAGE: Decision parameter percentage exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_SUM: Decision parameter sum exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_AVG: Decision parameter average exception.</description></item>
                    /// <item><description>LOGICAL_INSTANCE_GENERATION: Logical instance generation monitoring.</description></item>
                    /// <item><description>KGB_TASK_ERROR: Baseline task error.</description></item>
                    /// <item><description>KGB_TASK_SLOW_DOWN: Baseline task slowdown.</description></item>
                    /// <item><description>KGB_EARLY_WARNING: Baseline early warning.</description></item>
                    /// <item><description>KGB_BROKEN_LINE: Baseline breach.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VDM_BATCH_FINISH</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The unique identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_6340134343289405440_20241124_639873707610</para>
                    /// </summary>
                    [NameInMap("UniqueKey")]
                    [Validation(Required=false)]
                    public string UniqueKey { get; set; }

                }

                /// <summary>
                /// <para>The list of alert recipients.</para>
                /// </summary>
                [NameInMap("AlertReceiverList")]
                [Validation(Required=false)]
                public List<ListAlertEventsResponseBodyListResultDataAlertReceiverList> AlertReceiverList { get; set; }
                public class ListAlertEventsResponseBodyListResultDataAlertReceiverList : TeaModel {
                    /// <summary>
                    /// <para>The list of alert channel types.</para>
                    /// </summary>
                    [NameInMap("AlertChannelTypeList")]
                    [Validation(Required=false)]
                    public List<string> AlertChannelTypeList { get; set; }

                    /// <summary>
                    /// <para>The list of custom alert channel IDs.</para>
                    /// </summary>
                    [NameInMap("CustomAlertChannelIdList")]
                    [Validation(Required=false)]
                    public List<string> CustomAlertChannelIdList { get; set; }

                    /// <summary>
                    /// <para>The name of the on-call schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("OnCallTableName")]
                    [Validation(Required=false)]
                    public string OnCallTableName { get; set; }

                    /// <summary>
                    /// <para>The type of the alert recipient. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ON_CALL_TABLE: On-call schedule.</description></item>
                    /// <item><description>USER_DEFINED: Custom user.</description></item>
                    /// <item><description>OWNER: Owner.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OWNER</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The list of alert users.</para>
                    /// </summary>
                    [NameInMap("UserList")]
                    [Validation(Required=false)]
                    public List<ListAlertEventsResponseBodyListResultDataAlertReceiverListUserList> UserList { get; set; }
                    public class ListAlertEventsResponseBodyListResultDataAlertReceiverListUserList : TeaModel {
                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ADMIN</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The project.</para>
                /// </summary>
                [NameInMap("BelongProject")]
                [Validation(Required=false)]
                public ListAlertEventsResponseBodyListResultDataBelongProject BelongProject { get; set; }
                public class ListAlertEventsResponseBodyListResultDataBelongProject : TeaModel {
                    /// <summary>
                    /// <para>The business unit name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>biz_1</para>
                    /// </summary>
                    [NameInMap("BizName")]
                    [Validation(Required=false)]
                    public string BizName { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_1</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                }

                /// <summary>
                /// <para>The expiration time of the do-not-disturb mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-25 00:00:00</para>
                /// </summary>
                [NameInMap("DoNotDisturbEndTime")]
                [Validation(Required=false)]
                public string DoNotDisturbEndTime { get; set; }

                /// <summary>
                /// <para>The first alert time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-25 10:02:47</para>
                /// </summary>
                [NameInMap("FirstAlertTime")]
                [Validation(Required=false)]
                public string FirstAlertTime { get; set; }

                /// <summary>
                /// <para>The alert event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The latest alert time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-25 10:02:47</para>
                /// </summary>
                [NameInMap("LatestAlertTime")]
                [Validation(Required=false)]
                public string LatestAlertTime { get; set; }

                /// <summary>
                /// <para>The alert status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALERTING: Alerting.</description></item>
                /// <item><description>DO_NOT_DISTURB: Do not disturb.</description></item>
                /// <item><description>SILENCING: Alerting (silenced).</description></item>
                /// <item><description>FINISH: Completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FINISH</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total number of alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalAlertTimes")]
                [Validation(Required=false)]
                public long? TotalAlertTimes { get; set; }

                /// <summary>
                /// <para>The URL information.</para>
                /// </summary>
                [NameInMap("UrlConfig")]
                [Validation(Required=false)]
                public ListAlertEventsResponseBodyListResultDataUrlConfig UrlConfig { get; set; }
                public class ListAlertEventsResponseBodyListResultDataUrlConfig : TeaModel {
                    /// <summary>
                    /// <para>The URL of the alert configuration page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dataphin.com/ops/test3">https://dataphin.com/ops/test3</a></para>
                    /// </summary>
                    [NameInMap("AlertConfigUrl")]
                    [Validation(Required=false)]
                    public string AlertConfigUrl { get; set; }

                    /// <summary>
                    /// <para>The URL of the log page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dataphin.com/ops/test2">https://dataphin.com/ops/test2</a></para>
                    /// </summary>
                    [NameInMap("LogUrl")]
                    [Validation(Required=false)]
                    public string LogUrl { get; set; }

                    /// <summary>
                    /// <para>The URL of the alert object page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dataphin.com/ops/test1">https://dataphin.com/ops/test1</a></para>
                    /// </summary>
                    [NameInMap("ObjectUrl")]
                    [Validation(Required=false)]
                    public string ObjectUrl { get; set; }

                }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
