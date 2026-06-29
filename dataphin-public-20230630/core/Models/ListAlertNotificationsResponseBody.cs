// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertNotificationsResponseBody : TeaModel {
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
                    /// <item><description>ALL: all.</description></item>
                    /// <item><description>DQE: data quality.</description></item>
                    /// <item><description>OS: data service.</description></item>
                    /// <item><description>STREAM: real-time computing.</description></item>
                    /// <item><description>VDM_BATCH: offline computing.</description></item>
                    /// <item><description>SOP: O&amp;M platform.</description></item>
                    /// <item><description>REAL_TIME_PIPELINE: real-time integration.</description></item>
                    /// <item><description>KGB: baseline monitoring.</description></item>
                    /// </list>
                    /// <para>And more.</para>
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
                    /// <item><description>OS_APPLICATION_SERVICE: service application.</description></item>
                    /// <item><description>STREAM_TASK: real-time computing.</description></item>
                    /// <item><description>REAL_TIME_PIPELINE_TASK: real-time integration.</description></item>
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
                    /// <item><description>DQE_LOGICAL_TABLE: logical table.</description></item>
                    /// <item><description>DQE_PHYSICAL_TABLE: physical table.</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: real-time meta table.</description></item>
                    /// <item><description>DQE_DATA_SOURCE: data source.</description></item>
                    /// <item><description>DQE_INDEX: metric.</description></item>
                    /// <item><description>QD_DECISION_INVOKE: QD decision invocation.</description></item>
                    /// <item><description>BASELINE: baseline.</description></item>
                    /// </list>
                    /// <para>And more.</para>
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
                    /// <item><description>DQE_COLUMN: field rule exception.</description></item>
                    /// <item><description>DQE_DATA_SOURCE: data source rule exception.</description></item>
                    /// <item><description>DQE_CUSTOMIZE: custom rule exception.</description></item>
                    /// <item><description>DQE_TABLE: table rule exception.</description></item>
                    /// <item><description>DQE_REALTIME_TABLE: real-time table rule exception.</description></item>
                    /// <item><description>DQE_INDEX: metric rule exception.</description></item>
                    /// <item><description>OS_AVG_RESPONSE: average response time exception.</description></item>
                    /// <item><description>OS_CALL_TIMES: call count exception.</description></item>
                    /// <item><description>OS_ERROR_RATE: error rate exception.</description></item>
                    /// <item><description>OS_OFFLINE: Offline percentage exception.</description></item>
                    /// <item><description>STREAM_BIZ_DELAY: business delay too high.</description></item>
                    /// <item><description>STREAM_DATA_RETENTION: data retention exceeds configuration.</description></item>
                    /// <item><description>STREAM_MORE_THAN_FAILURE: failure frequency exceeds configuration.</description></item>
                    /// <item><description>STREAM_TPS_OUT_RANGE: TPS out of range.</description></item>
                    /// <item><description>STREAM_CHECKPOINT_FAILURE: checkpoint failures exceed configuration.</description></item>
                    /// <item><description>STREAM_BACKPRESSURE: backpressure duration exceeds configuration.</description></item>
                    /// <item><description>STREAM_JOB_FAILURE: job execution failed.</description></item>
                    /// <item><description>VDM_BATCH_ERROR: error.</description></item>
                    /// <item><description>VDM_BATCH_FINISH: completed.</description></item>
                    /// <item><description>VDM_BATCH_TIME_OUT: execution timed out.</description></item>
                    /// <item><description>VDM_BATCH_UNDONE: not completed.</description></item>
                    /// <item><description>VDM_BATCH_LOGIC_DATA_DELAY: data delay.</description></item>
                    /// <item><description>QD_DECISION_CALL_TIMES: decision call count exception.</description></item>
                    /// <item><description>QD_DECISION_MAX_RESPONSE: maximum response time exception.</description></item>
                    /// <item><description>QD_DECISION_ERROR_RATE: error rate exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_COUNT: decision parameter count exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_PERCENTAGE: decision parameter percentage exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_SUM: decision parameter sum exception.</description></item>
                    /// <item><description>QD_DECISION_PARAM_AVG: decision parameter average exception.</description></item>
                    /// <item><description>LOGICAL_INSTANCE_GENERATION: logical instance generation monitoring.</description></item>
                    /// <item><description>KGB_TASK_ERROR: baseline task error.</description></item>
                    /// <item><description>KGB_TASK_SLOW_DOWN: baseline task slowdown.</description></item>
                    /// <item><description>KGB_EARLY_WARNING: baseline early warning.</description></item>
                    /// <item><description>KGB_BROKEN_LINE: baseline broken line.</description></item>
                    /// </list>
                    /// <para>And more.</para>
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
                /// <para>The receiver information.</para>
                /// </summary>
                [NameInMap("AlertReceiver")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertReceiver AlertReceiver { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertReceiver : TeaModel {
                    /// <summary>
                    /// <para>The push channel type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>VOICE: phone call.</description></item>
                    /// <item><description>SMS: text message.</description></item>
                    /// <item><description>MAIL: email.</description></item>
                    /// <item><description>DINGTALK_ROBOT: DingTalk robot.</description></item>
                    /// <item><description>DINGDING: DingTalk work notification.</description></item>
                    /// <item><description>CUSTOM: custom message channel.</description></item>
                    /// <item><description>WECHAT: WeCom.</description></item>
                    /// <item><description>FEISHU: Lark.</description></item>
                    /// <item><description>SILENCE: do not send.</description></item>
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
                    /// <para>The alert receiver type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ON_CALL_TABLE: on-call schedule.</description></item>
                    /// <item><description>USER_DEFINED: custom user.</description></item>
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
                    /// <para>The user information.</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser User { get; set; }
                    public class ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser : TeaModel {
                        /// <summary>
                        /// <para>The name of the alert receiver.</para>
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
                /// <para>The alert sending information.</para>
                /// </summary>
                [NameInMap("AlertSend")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertSend AlertSend { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertSend : TeaModel {
                    /// <summary>
                    /// <para>The alert reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不合法</para>
                    /// </summary>
                    [NameInMap("FailReason")]
                    [Validation(Required=false)]
                    public string FailReason { get; set; }

                    /// <summary>
                    /// <para>The push content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SendContent")]
                    [Validation(Required=false)]
                    public string SendContent { get; set; }

                    /// <summary>
                    /// <para>The push time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-11-25 10:02:47</para>
                    /// </summary>
                    [NameInMap("SendTime")]
                    [Validation(Required=false)]
                    public string SendTime { get; set; }

                    /// <summary>
                    /// <para>The push status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SUCCESS: Sent successfully.</description></item>
                    /// <item><description>FAILE: Failed to send.</description></item>
                    /// <item><description>SENDING: Sending in progress.</description></item>
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
            /// <para>The total number of records.</para>
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
