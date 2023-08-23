// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceGetResultResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the message trace.
        /// </summary>
        [NameInMap("TraceData")]
        [Validation(Required=false)]
        public OnsTraceGetResultResponseBodyTraceData TraceData { get; set; }
        public class OnsTraceGetResultResponseBodyTraceData : TeaModel {
            /// <summary>
            /// The point in time when the task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the message that is queried.
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// The key of the message that is queried.
            /// </summary>
            [NameInMap("MsgKey")]
            [Validation(Required=false)]
            public string MsgKey { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **finish**: The task is complete.
            /// *   **working**: The task is in progress.
            /// *   **removed**: The task is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The topic in which the message is stored.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The details of the message trace.
            /// </summary>
            [NameInMap("TraceList")]
            [Validation(Required=false)]
            public OnsTraceGetResultResponseBodyTraceDataTraceList TraceList { get; set; }
            public class OnsTraceGetResultResponseBodyTraceDataTraceList : TeaModel {
                [NameInMap("TraceMapDo")]
                [Validation(Required=false)]
                public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDo> TraceMapDo { get; set; }
                public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDo : TeaModel {
                    /// <summary>
                    /// The address of the producer that generated the message.
                    /// </summary>
                    [NameInMap("BornHost")]
                    [Validation(Required=false)]
                    public string BornHost { get; set; }

                    /// <summary>
                    /// The period of time that the system took to send the message. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("CostTime")]
                    [Validation(Required=false)]
                    public int? CostTime { get; set; }

                    /// <summary>
                    /// The ID of the message.
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public string MsgId { get; set; }

                    /// <summary>
                    /// The key of the message.
                    /// </summary>
                    [NameInMap("MsgKey")]
                    [Validation(Required=false)]
                    public string MsgKey { get; set; }

                    /// <summary>
                    /// The ID of the group that contains the producer.
                    /// </summary>
                    [NameInMap("PubGroupName")]
                    [Validation(Required=false)]
                    public string PubGroupName { get; set; }

                    /// <summary>
                    /// The point in time when the message was sent.
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public long? PubTime { get; set; }

                    /// <summary>
                    /// Indicates whether the message is sent. Valid values:
                    /// 
                    /// *   **SEND_SUCCESS**: The message is sent.
                    /// *   **SEND_FAILED**: The message failed to be sent.
                    /// *   **SEND_ROLLBACK:** The message is a transactional message and is rolled back.
                    /// *   **SEND_UNKNOWN:** The message is a transactional message and is not committed.
                    /// *   **SEND_DELAY:** The message is a scheduled or delayed message and is waiting to be consumed at the specified point in time.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The consumption traces of the message.
                    /// </summary>
                    [NameInMap("SubList")]
                    [Validation(Required=false)]
                    public OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubList SubList { get; set; }
                    public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubList : TeaModel {
                        [NameInMap("SubMapDo")]
                        [Validation(Required=false)]
                        public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDo> SubMapDo { get; set; }
                        public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDo : TeaModel {
                            /// <summary>
                            /// The information about message consumption by consumers in the group.
                            /// </summary>
                            [NameInMap("ClientList")]
                            [Validation(Required=false)]
                            public OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoClientList ClientList { get; set; }
                            public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoClientList : TeaModel {
                                [NameInMap("SubClientInfoDo")]
                                [Validation(Required=false)]
                                public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoClientListSubClientInfoDo> SubClientInfoDo { get; set; }
                                public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoClientListSubClientInfoDo : TeaModel {
                                    /// <summary>
                                    /// The address of the consumer.
                                    /// </summary>
                                    [NameInMap("ClientHost")]
                                    [Validation(Required=false)]
                                    public string ClientHost { get; set; }

                                    /// <summary>
                                    /// The period of time that the system took to consume the message. Unit: milliseconds.
                                    /// </summary>
                                    [NameInMap("CostTime")]
                                    [Validation(Required=false)]
                                    public int? CostTime { get; set; }

                                    /// <summary>
                                    /// The number of attempts that the ApsaraMQ for RocketMQ broker tried to send the message to the consumer.
                                    /// </summary>
                                    [NameInMap("ReconsumeTimes")]
                                    [Validation(Required=false)]
                                    public int? ReconsumeTimes { get; set; }

                                    /// <summary>
                                    /// Indicates whether the message is consumed. Valid values:
                                    /// 
                                    /// *   **CONSUME_FAILED**: The message failed to be consumed.
                                    /// *   **CONSUME_SUCCESS**: The message is consumed.
                                    /// *   **CONSUME_NOT_RETURN:** No responses are returned.
                                    /// *   **SEND_UNKNOWN:** The message is a transactional message and is not committed.
                                    /// *   **SEND_DELAY:** The message is a scheduled or delayed message and is waiting to be consumed at the specified point in time.
                                    /// </summary>
                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public string Status { get; set; }

                                    /// <summary>
                                    /// The ID of the group that contains the consumer.
                                    /// </summary>
                                    [NameInMap("SubGroupName")]
                                    [Validation(Required=false)]
                                    public string SubGroupName { get; set; }

                                    /// <summary>
                                    /// The earliest point in time when the message was consumed.
                                    /// </summary>
                                    [NameInMap("SubTime")]
                                    [Validation(Required=false)]
                                    public long? SubTime { get; set; }

                                }

                            }

                            /// <summary>
                            /// The number of consumption failures.
                            /// </summary>
                            [NameInMap("FailCount")]
                            [Validation(Required=false)]
                            public int? FailCount { get; set; }

                            /// <summary>
                            /// The ID of the consumer group.
                            /// </summary>
                            [NameInMap("SubGroupName")]
                            [Validation(Required=false)]
                            public string SubGroupName { get; set; }

                            /// <summary>
                            /// The number of successful consumptions.
                            /// </summary>
                            [NameInMap("SuccessCount")]
                            [Validation(Required=false)]
                            public int? SuccessCount { get; set; }

                        }

                    }

                    /// <summary>
                    /// The tag of the message.
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The topic to which the message belongs.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// The most recent point in time when the task was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// The ID of the user who created the task.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
