// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertNotificationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. OK indicates that the request is successful.</para>
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
        public ListAlertNotificationsResponseBodyListResult ListResult { get; set; }
        public class ListAlertNotificationsResponseBodyListResult : TeaModel {
            /// <summary>
            /// <para>The list of push records.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAlertNotificationsResponseBodyListResultData> Data { get; set; }
            public class ListAlertNotificationsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>The alert event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AlertEventId")]
                [Validation(Required=false)]
                public string AlertEventId { get; set; }

                /// <summary>
                /// <para>The alert object.</para>
                /// </summary>
                [NameInMap("AlertObject")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertObject AlertObject { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertObject : TeaModel {
                    /// <summary>
                    /// <para>The object name.</para>
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
                    /// <item><description>KGB: Baseline monitoring.
                    /// etc.</description></item>
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
                    /// <para>VDM_BATCH_SHELL</para>
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
                public ListAlertNotificationsResponseBodyListResultDataAlertReason AlertReason { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertReason : TeaModel {
                    /// <summary>
                    /// <para>The list of alert parameters.</para>
                    /// </summary>
                    [NameInMap("AlertReasonParamList")]
                    [Validation(Required=false)]
                    public List<ListAlertNotificationsResponseBodyListResultDataAlertReasonAlertReasonParamList> AlertReasonParamList { get; set; }
                    public class ListAlertNotificationsResponseBodyListResultDataAlertReasonAlertReasonParamList : TeaModel {
                        /// <summary>
                        /// <para>The alert parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>biz_date</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The alert parameter value.</para>
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
                    /// <para>20241125</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The alert reason type. Valid values:</para>
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
                    /// <item><description>STREAM_JOB_FAILURE: Execution failed.</description></item>
                    /// <item><description>VDM_BATCH_ERROR: Error occurred.</description></item>
                    /// <item><description>VDM_BATCH_FINISH: Completed.</description></item>
                    /// <item><description>VDM_BATCH_TIME_OUT: Execution timed out.</description></item>
                    /// <item><description>VDM_BATCH_UNDONE: Incomplete.</description></item>
                    /// <item><description>VDM_BATCH_LOGIC_DATA_DELAY: Data delay.</description></item>
                    /// <item><description>QD_DECISION_CALL_TIMES: Decision call count exception.</description></item>
                    /// <item><description>QD_DECISION_MAX_RESPONSE: Maximum response time exception.</description></item>
                    /// <item><description>QD_DECISION_ERROR_RATE: Error rate exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_COUNT: Decision parameter statistics count exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_PERCENTAGE: Decision parameter statistics percentage exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_SUM: Decision parameter sum exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_AVG: Decision parameter average exception.</description></item>
                    /// <item><description>LOGICAL_INSTANCE_GENERATION: Logical instance generation monitoring.</description></item>
                    /// <item><description>KGB_TASK_ERROR: Baseline task error.</description></item>
                    /// <item><description>KGB_TASK_SLOW_DOWN: Baseline task slowed down.</description></item>
                    /// <item><description>KGB_EARLY_WARNING: Baseline early warning.</description></item>
                    /// <item><description>KGB_BROKEN_LINE: Baseline SLA breached.
                    /// etc.</description></item>
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
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("UniqueKey")]
                    [Validation(Required=false)]
                    public string UniqueKey { get; set; }

                }

                /// <summary>
                /// <para>The recipient information.</para>
                /// </summary>
                [NameInMap("AlertReceiver")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertReceiver AlertReceiver { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertReceiver : TeaModel {
                    /// <summary>
                    /// <para>The push channel type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>VOICE: Voice calls.</description></item>
                    /// <item><description>SMS: Text messages.</description></item>
                    /// <item><description>MAIL: Email.</description></item>
                    /// <item><description>DINGTALK_ROBOT: DingTalk robot.</description></item>
                    /// <item><description>DINGDING: DingTalk work notification.</description></item>
                    /// <item><description>CUSTOM: Custom message channel.</description></item>
                    /// <item><description>WECHAT: WeCom.</description></item>
                    /// <item><description>FEISHU: Lark.</description></item>
                    /// <item><description>SILENCE: No notification.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SMS</para>
                    /// </summary>
                    [NameInMap("AlertChannelType")]
                    [Validation(Required=false)]
                    public string AlertChannelType { get; set; }

                    /// <summary>
                    /// <para>The custom message channel ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("CustomAlertChannelId")]
                    [Validation(Required=false)]
                    public string CustomAlertChannelId { get; set; }

                    /// <summary>
                    /// <para>The on-call schedule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("OnCallTableId")]
                    [Validation(Required=false)]
                    public string OnCallTableId { get; set; }

                    /// <summary>
                    /// <para>The on-call schedule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("OnCallTableName")]
                    [Validation(Required=false)]
                    public string OnCallTableName { get; set; }

                    /// <summary>
                    /// <para>The alert recipient type. Valid values:</para>
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
                    /// <para>The user information.</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser User { get; set; }
                    public class ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser : TeaModel {
                        /// <summary>
                        /// <para>The alert recipient name.</para>
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
                /// <para>The alert delivery information.</para>
                /// </summary>
                [NameInMap("AlertSend")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertSend AlertSend { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertSend : TeaModel {
                    /// <summary>
                    /// <para>The alert reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Invalid</para>
                    /// </summary>
                    [NameInMap("FailReason")]
                    [Validation(Required=false)]
                    public string FailReason { get; set; }

                    /// <summary>
                    /// <para>The delivery content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SendContent")]
                    [Validation(Required=false)]
                    public string SendContent { get; set; }

                    /// <summary>
                    /// <para>The delivery time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-11-25 10:02:47</para>
                    /// </summary>
                    [NameInMap("SendTime")]
                    [Validation(Required=false)]
                    public string SendTime { get; set; }

                    /// <summary>
                    /// <para>The delivery status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SUCCESS: Delivered successfully.</description></item>
                    /// <item><description>FAILE: Delivery failed.</description></item>
                    /// <item><description>SENDING: Delivering.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

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
