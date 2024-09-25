// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidConsumerGroupId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTraceResponseBodyData Data { get; set; }
        public class GetTraceResponseBodyData : TeaModel {
            [NameInMap("brokerInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataBrokerInfo BrokerInfo { get; set; }
            public class GetTraceResponseBodyDataBrokerInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("delayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                [NameInMap("operations")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataBrokerInfoOperations> Operations { get; set; }
                public class GetTraceResponseBodyDataBrokerInfoOperations : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("operateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ADD</para>
                    /// </summary>
                    [NameInMap("operateType")]
                    [Validation(Required=false)]
                    public string OperateType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("presetDelayTime")]
                [Validation(Required=false)]
                public string PresetDelayTime { get; set; }

            }

            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodyDataConsumerInfos> ConsumerInfos { get; set; }
            public class GetTraceResponseBodyDataConsumerInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("consumeStatus")]
                [Validation(Required=false)]
                public string ConsumeStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GID_inspector_group</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                [NameInMap("deadLetterInfo")]
                [Validation(Required=false)]
                public GetTraceResponseBodyDataConsumerInfosDeadLetterInfo DeadLetterInfo { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosDeadLetterInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7F000001001F7A4F0F29463F0376047D</para>
                    /// </summary>
                    [NameInMap("messageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("toDlqTime")]
                    [Validation(Required=false)]
                    public string ToDlqTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Register_Sync</para>
                    /// </summary>
                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("deadMessage")]
                [Validation(Required=false)]
                public bool? DeadMessage { get; set; }

                [NameInMap("records")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataConsumerInfosRecords> Records { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosRecords : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx.xx.xx.xx</para>
                    /// </summary>
                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("consumeStatus")]
                    [Validation(Required=false)]
                    public string ConsumeStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("fifoEnable")]
                    [Validation(Required=false)]
                    public bool? FifoEnable { get; set; }

                    [NameInMap("operations")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodyDataConsumerInfosRecordsOperations> Operations { get; set; }
                    public class GetTraceResponseBodyDataConsumerInfosRecordsOperations : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("deadMessage")]
                        [Validation(Required=false)]
                        public bool? DeadMessage { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("invisibleTime")]
                        [Validation(Required=false)]
                        public long? InvisibleTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-03-22 12:17:08</para>
                        /// </summary>
                        [NameInMap("operateTime")]
                        [Validation(Required=false)]
                        public string OperateTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ADD</para>
                        /// </summary>
                        [NameInMap("operateType")]
                        [Validation(Required=false)]
                        public string OperateType { get; set; }

                    }

                    /// <summary>
                    /// <para>POP_CK</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("popCk")]
                    [Validation(Required=false)]
                    public string PopCk { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("messageInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataMessageInfo MessageInfo { get; set; }
            public class GetTraceResponseBodyDataMessageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>x.x.x.x</para>
                /// </summary>
                [NameInMap("bornHost")]
                [Validation(Required=false)]
                public string BornHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("bornTime")]
                [Validation(Required=false)]
                public string BornTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rmq-cn-u0t2ygjq505</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageGroup")]
                [Validation(Required=false)]
                public string MessageGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0A79275A00207A4F0F2916C92F9A0B94</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("messageKeys")]
                [Validation(Required=false)]
                public List<string> MessageKeys { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageTag")]
                [Validation(Required=false)]
                public string MessageTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("messageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("setted")]
                [Validation(Required=false)]
                public bool? Setted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>x.x.x.x</para>
                /// </summary>
                [NameInMap("storeHost")]
                [Validation(Required=false)]
                public string StoreHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("storeTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Topic_normal_inspector</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("transactionId")]
                [Validation(Required=false)]
                public string TransactionId { get; set; }

                [NameInMap("userProperties")]
                [Validation(Required=false)]
                public Dictionary<string, string> UserProperties { get; set; }

            }

            [NameInMap("producerInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataProducerInfo ProducerInfo { get; set; }
            public class GetTraceResponseBodyDataProducerInfo : TeaModel {
                [NameInMap("records")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataProducerInfoRecords> Records { get; set; }
                public class GetTraceResponseBodyDataProducerInfoRecords : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("arriveTime")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx.xx.xx.xx</para>
                    /// </summary>
                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0A79275A00207A4F0F2916C92F9A0B94</para>
                    /// </summary>
                    [NameInMap("dlqOriginMessageId")]
                    [Validation(Required=false)]
                    public string DlqOriginMessageId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_topic</para>
                    /// </summary>
                    [NameInMap("dlqOriginTopic")]
                    [Validation(Required=false)]
                    public string DlqOriginTopic { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CONSOLE</para>
                    /// </summary>
                    [NameInMap("messageSource")]
                    [Validation(Required=false)]
                    public string MessageSource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("produceDuration")]
                    [Validation(Required=false)]
                    public long? ProduceDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("produceStatus")]
                    [Validation(Required=false)]
                    public string ProduceStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("produceTime")]
                    [Validation(Required=false)]
                    public string ProduceTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>topic_test</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7779A8FC-1BCD-5A1D-A603-C4A9BD8ADC49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
