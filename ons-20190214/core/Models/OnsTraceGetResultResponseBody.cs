// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceGetResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84EE24D2-851F-40D6-B99E-4D6AB909****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the message trace.</para>
        /// </summary>
        [NameInMap("TraceData")]
        [Validation(Required=false)]
        public OnsTraceGetResultResponseBodyTraceData TraceData { get; set; }
        public class OnsTraceGetResultResponseBodyTraceData : TeaModel {
            /// <summary>
            /// <para>The point in time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570966857000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_111111111111_DOxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the message that is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1E05791C117818B4AAC23B1BB0CE****</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The key of the message that is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORDERID_100</para>
            /// </summary>
            [NameInMap("MsgKey")]
            [Validation(Required=false)]
            public string MsgKey { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>272967562652883649157096685****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>finish</b>: The task is complete.</description></item>
            /// <item><description><b>working</b>: The task is in progress.</description></item>
            /// <item><description><b>removed</b>: The task is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topic in which the message is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The details of the message trace.</para>
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
                    /// <para>The address of the producer that generated the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>30.5.**.**</c></para>
                    /// </summary>
                    [NameInMap("BornHost")]
                    [Validation(Required=false)]
                    public string BornHost { get; set; }

                    /// <summary>
                    /// <para>The period of time that the system took to send the message. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("CostTime")]
                    [Validation(Required=false)]
                    public int? CostTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0BC1F01800002A9F000000531246****</para>
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public string MsgId { get; set; }

                    /// <summary>
                    /// <para>The key of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ORDERID_100</para>
                    /// </summary>
                    [NameInMap("MsgKey")]
                    [Validation(Required=false)]
                    public string MsgKey { get; set; }

                    /// <summary>
                    /// <para>The ID of the group that contains the producer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_test</para>
                    /// </summary>
                    [NameInMap("PubGroupName")]
                    [Validation(Required=false)]
                    public string PubGroupName { get; set; }

                    /// <summary>
                    /// <para>The point in time when the message was sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570850870478</para>
                    /// </summary>
                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public long? PubTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the message is sent. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SEND_SUCCESS</b>: The message is sent.</description></item>
                    /// <item><description><b>SEND_FAILED</b>: The message failed to be sent.</description></item>
                    /// <item><description><b>SEND_ROLLBACK:</b> The message is a transactional message and is rolled back.</description></item>
                    /// <item><description><b>SEND_UNKNOWN:</b> The message is a transactional message and is not committed.</description></item>
                    /// <item><description><b>SEND_DELAY:</b> The message is a scheduled or delayed message and is waiting to be consumed at the specified point in time.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SEND_SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The consumption traces of the message.</para>
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
                            /// <para>The information about message consumption by consumers in the group.</para>
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
                                    /// <para>The address of the consumer.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para><c>30.5.**.**</c></para>
                                    /// </summary>
                                    [NameInMap("ClientHost")]
                                    [Validation(Required=false)]
                                    public string ClientHost { get; set; }

                                    /// <summary>
                                    /// <para>The period of time that the system took to consume the message. Unit: milliseconds.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>43</para>
                                    /// </summary>
                                    [NameInMap("CostTime")]
                                    [Validation(Required=false)]
                                    public int? CostTime { get; set; }

                                    /// <summary>
                                    /// <para>The number of attempts that the ApsaraMQ for RocketMQ broker tried to send the message to the consumer.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("ReconsumeTimes")]
                                    [Validation(Required=false)]
                                    public int? ReconsumeTimes { get; set; }

                                    /// <summary>
                                    /// <para>Indicates whether the message is consumed. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>CONSUME_FAILED</b>: The message failed to be consumed.</description></item>
                                    /// <item><description><b>CONSUME_SUCCESS</b>: The message is consumed.</description></item>
                                    /// <item><description><b>CONSUME_NOT_RETURN:</b> No responses are returned.</description></item>
                                    /// <item><description><b>SEND_UNKNOWN:</b> The message is a transactional message and is not committed.</description></item>
                                    /// <item><description><b>SEND_DELAY:</b> The message is a scheduled or delayed message and is waiting to be consumed at the specified point in time.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>CONSUME_SUCCESS</para>
                                    /// </summary>
                                    [NameInMap("Status")]
                                    [Validation(Required=false)]
                                    public string Status { get; set; }

                                    /// <summary>
                                    /// <para>The ID of the group that contains the consumer.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>GID_test</para>
                                    /// </summary>
                                    [NameInMap("SubGroupName")]
                                    [Validation(Required=false)]
                                    public string SubGroupName { get; set; }

                                    /// <summary>
                                    /// <para>The earliest point in time when the message was consumed.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1570851590511</para>
                                    /// </summary>
                                    [NameInMap("SubTime")]
                                    [Validation(Required=false)]
                                    public long? SubTime { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The number of consumption failures.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("FailCount")]
                            [Validation(Required=false)]
                            public int? FailCount { get; set; }

                            /// <summary>
                            /// <para>The ID of the consumer group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GID_test</para>
                            /// </summary>
                            [NameInMap("SubGroupName")]
                            [Validation(Required=false)]
                            public string SubGroupName { get; set; }

                            /// <summary>
                            /// <para>The number of successful consumptions.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("SuccessCount")]
                            [Validation(Required=false)]
                            public int? SuccessCount { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The tag of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TagA</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The topic to which the message belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// <para>The most recent point in time when the task was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570966877000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27296756265288****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
