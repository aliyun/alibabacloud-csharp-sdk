// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
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
            /// <para>The alert event query results.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAlertEventsResponseBodyListResultData> Data { get; set; }
            public class ListAlertEventsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>The alert frequency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ONCE: instant alert</description></item>
                /// <item><description>PERIOD: periodic alert. Format: 1HOUR, 1MINUTE, 1SECOND.</description></item>
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
                    /// <item><description>ALL: all</description></item>
                    /// <item><description>DQE: data quality</description></item>
                    /// <item><description>OS: data service</description></item>
                    /// <item><description>STREAM: real-time computing</description></item>
                    /// <item><description>VDM_BATCH: offline computing</description></item>
                    /// <item><description>SOP: O&amp;M platform</description></item>
                    /// <item><description>REAL_TIME_PIPELINE: real-time integration</description></item>
                    /// <item><description>KGB: baseline monitoring</description></item>
                    /// </list>
                    /// <para>and more.</para>
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
                    /// <item><description>OS_API: API operation</description></item>
                    /// <item><description>OS_APPLICATION_SERVICE: service application</description></item>
                    /// <item><description>STREAM_TASK: real-time computing</description></item>
                    /// <item><description>REAL_TIME_PIPELINE_TASK: real-time integration</description></item>
                    /// <item><description>VDM_BATCH_SHELL: SHELL</description></item>
                    /// <item><description>VDM_BATCH_PYTHON: PYTHON</description></item>
                    /// <item><description>VDM_BATCH_DATAX: DATAX</description></item>
                    /// <item><description>VDM_BATCH_DLINK: DLINK</description></item>
                    /// <item><description>VDM_BATCH_VIRTUAL: VIRTUAL</description></item>
                    /// <item><description>VDM_BATCH_PYTHON37: PYTHON37</description></item>
                    /// <item><description>VDM_BATCH_PYTHON311: PYTHON311</description></item>
                    /// <item><description>VDM_BATCH_MAX_COMPUTE_SQL: MAXCOMPUTE_SQL</description></item>
                    /// <item><description>VDM_BATCH_MAX_COMPUTE_MR: MAXCOMPUTE_MR</description></item>
                    /// <item><description>VDM_BATCH_SPARK_JAR_ON_MAX_COMPUTE: SPARK_JAR_ON_MAX_COMPUTE</description></item>
                    /// <item><description>VDM_BATCH_HIVE_SQL: HIVE_SQL</description></item>
                    /// <item><description>VDM_BATCH_HADOOP_MR: HADOOP_MR</description></item>
                    /// <item><description>VDM_BATCH_SPARK_JAR_ON_HIVE: SPARK_JAR_ON_HIVE</description></item>
                    /// <item><description>VDM_BATCH_SPARK_SQL_ON_HIVE: SPARK_SQL_ON_HIVE</description></item>
                    /// <item><description>VDM_BATCH_SPARK_SQL: VDM_BATCH_SPARK_SQL</description></item>
                    /// <item><description>DQE_LOGICAL_TABLE: logical table</description></item>
                    /// <item><description>DQE_PHYSICAL_TABLE: physical table</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: real-time metadata table</description></item>
                    /// <item><description>DQE_DATA_SOURCE: data source</description></item>
                    /// <item><description>DQE_INDEX: metric</description></item>
                    /// <item><description>QD_DECISION_INVOKE: QD decision invocation</description></item>
                    /// <item><description>BASELINE: baseline</description></item>
                    /// </list>
                    /// <para>and more.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STREAM_TASK</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The alert reason.</para>
                /// </summary>
                [NameInMap("AlertReason")]
                [Validation(Required=false)]
                public ListAlertEventsResponseBodyListResultDataAlertReason AlertReason { get; set; }
                public class ListAlertEventsResponseBodyListResultDataAlertReason : TeaModel {
                    /// <summary>
                    /// <para>The list of alert reason parameters.</para>
                    /// </summary>
                    [NameInMap("AlertReasonParamList")]
                    [Validation(Required=false)]
                    public List<ListAlertEventsResponseBodyListResultDataAlertReasonAlertReasonParamList> AlertReasonParamList { get; set; }
                    public class ListAlertEventsResponseBodyListResultDataAlertReasonAlertReasonParamList : TeaModel {
                        /// <summary>
                        /// <para>The name of the alert reason parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>biz_date</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the alert reason parameter.</para>
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
                    /// <para>The alert reason type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DQE_COLUMN: field rule exception</description></item>
                    /// <item><description>DQE_DATA_SOURCE: data source rule exception</description></item>
                    /// <item><description>DQE_CUSTOMIZE: custom rule exception</description></item>
                    /// <item><description>DQE_TABLE: table rule exception</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: real-time table rule exception</description></item>
                    /// <item><description>DQE_INDEX: metric rule exception</description></item>
                    /// <item><description>OS_AVG_RESPONSE: average response time exception</description></item>
                    /// <item><description>OS_CALL_TIMES: call count exception</description></item>
                    /// <item><description>OS_ERROR_RATE: error rate exception</description></item>
                    /// <item><description>OS_OFFLINE: Offline percentage exception</description></item>
                    /// <item><description>STREAM_BIZ_DELAY: business delay too high</description></item>
                    /// <item><description>STREAM_DATA_RETENTION: data retention exceeds configuration</description></item>
                    /// <item><description>STREAM_MORE_THAN_FAILURE: failure frequency exceeds configuration</description></item>
                    /// <item><description>STREAM_TPS_OUT_RANGE: TPS out of range</description></item>
                    /// <item><description>STREAM_CHECKPOINT_FAILURE: checkpoint failures exceed configuration</description></item>
                    /// <item><description>STREAM_BACKPRESSURE: backpressure duration exceeds configuration</description></item>
                    /// <item><description>STREAM_JOB_FAILURE: job failure</description></item>
                    /// <item><description>VDM_BATCH_ERROR: error</description></item>
                    /// <item><description>VDM_BATCH_FINISH: completed</description></item>
                    /// <item><description>VDM_BATCH_TIME_OUT: execution timeout</description></item>
                    /// <item><description>VDM_BATCH_UNDONE: incomplete</description></item>
                    /// <item><description>VDM_BATCH_LOGIC_DATA_DELAY: data delay</description></item>
                    /// <item><description>QD_DECISION_CALL_TIMES: decision call count exception</description></item>
                    /// <item><description>QD_DECISION_MAX_RESPONSE: maximum response time exception</description></item>
                    /// <item><description>QD_DECISION_ERROR_RATE: error rate exception</description></item>
                    /// <item><description>QD_DECISION_PARAM_COUNT: decision parameter count exception</description></item>
                    /// <item><description>QD_DECISION_PARAM_PERCENTAGE: decision parameter percentage exception</description></item>
                    /// <item><description>QD_DECISION_PARAM_SUM: decision parameter sum exception</description></item>
                    /// <item><description>QD_DECISION_PARAM_AVG: decision parameter average exception</description></item>
                    /// <item><description>LOGICAL_INSTANCE_GENERATION: logical instance generation monitoring</description></item>
                    /// <item><description>KGB_TASK_ERROR: baseline task error</description></item>
                    /// <item><description>KGB_TASK_SLOW_DOWN: baseline task slowdown</description></item>
                    /// <item><description>KGB_EARLY_WARNING: baseline early warning</description></item>
                    /// <item><description>KGB_BROKEN_LINE: baseline breach</description></item>
                    /// </list>
                    /// <para>and more.</para>
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
                /// <para>The list of alert receivers.</para>
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
                    /// <para>The type of the alert receiver. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ON_CALL_TABLE: on-call schedule</description></item>
                    /// <item><description>USER_DEFINED: custom user</description></item>
                    /// <item><description>OWNER: owner.</description></item>
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
                /// <para>The project to which the alert belongs.</para>
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
                /// <para>The expiration time of the do-not-disturb period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-25 00:00:00</para>
                /// </summary>
                [NameInMap("DoNotDisturbEndTime")]
                [Validation(Required=false)]
                public string DoNotDisturbEndTime { get; set; }

                /// <summary>
                /// <para>The time of the first alert.</para>
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
                /// <para>The time of the latest alert.</para>
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
                /// <item><description>ALERTING: alerting</description></item>
                /// <item><description>DO_NOT_DISTURB: do not disturb</description></item>
                /// <item><description>SILENCING: alerting (cool-down period)</description></item>
                /// <item><description>FINISH: completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FINISH</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total number of alert occurrences.</para>
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
            /// <para>The total number of entries.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
