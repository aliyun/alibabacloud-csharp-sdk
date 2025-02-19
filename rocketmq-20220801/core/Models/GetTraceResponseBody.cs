// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetTraceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidConsumerGroupId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTraceResponseBodyData Data { get; set; }
        public class GetTraceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Broker trace info.</para>
            /// </summary>
            [NameInMap("brokerInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataBrokerInfo BrokerInfo { get; set; }
            public class GetTraceResponseBodyDataBrokerInfo : TeaModel {
                /// <summary>
                /// <para>Delay status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("delayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                /// <summary>
                /// <para>Operation list.</para>
                /// </summary>
                [NameInMap("operations")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataBrokerInfoOperations> Operations { get; set; }
                public class GetTraceResponseBodyDataBrokerInfoOperations : TeaModel {
                    /// <summary>
                    /// <para>Operation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("operateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    /// <summary>
                    /// <para>Operation type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADD</para>
                    /// </summary>
                    [NameInMap("operateType")]
                    [Validation(Required=false)]
                    public string OperateType { get; set; }

                }

                /// <summary>
                /// <para>Preset delivery time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("presetDelayTime")]
                [Validation(Required=false)]
                public string PresetDelayTime { get; set; }

                [NameInMap("recallResult")]
                [Validation(Required=false)]
                public string RecallResult { get; set; }

            }

            /// <summary>
            /// <para>Consumer trace info.</para>
            /// </summary>
            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodyDataConsumerInfos> ConsumerInfos { get; set; }
            public class GetTraceResponseBodyDataConsumerInfos : TeaModel {
                /// <summary>
                /// <para>Consume status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("consumeStatus")]
                [Validation(Required=false)]
                public string ConsumeStatus { get; set; }

                /// <summary>
                /// <para>The consumer group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_inspector_group</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <para>Dead letter info.</para>
                /// </summary>
                [NameInMap("deadLetterInfo")]
                [Validation(Required=false)]
                public GetTraceResponseBodyDataConsumerInfosDeadLetterInfo DeadLetterInfo { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosDeadLetterInfo : TeaModel {
                    /// <summary>
                    /// <para>MessageId.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7F000001001F7A4F0F29463F0376047D</para>
                    /// </summary>
                    [NameInMap("messageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    /// <summary>
                    /// <para>Arrival time in the dead letter queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("toDlqTime")]
                    [Validation(Required=false)]
                    public string ToDlqTime { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Register_Sync</para>
                    /// </summary>
                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                /// <summary>
                /// <para>Whether it is a dead letter message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("deadMessage")]
                [Validation(Required=false)]
                public bool? DeadMessage { get; set; }

                /// <summary>
                /// <para>Consumer record list.</para>
                /// </summary>
                [NameInMap("records")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataConsumerInfosRecords> Records { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosRecords : TeaModel {
                    /// <summary>
                    /// <para>Client host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx.xx.xx.xx</para>
                    /// </summary>
                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    /// <summary>
                    /// <para>Consume status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("consumeStatus")]
                    [Validation(Required=false)]
                    public string ConsumeStatus { get; set; }

                    /// <summary>
                    /// <para>Whether to consume fifo.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("fifoEnable")]
                    [Validation(Required=false)]
                    public bool? FifoEnable { get; set; }

                    /// <summary>
                    /// <para>Operation list.</para>
                    /// </summary>
                    [NameInMap("operations")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodyDataConsumerInfosRecordsOperations> Operations { get; set; }
                    public class GetTraceResponseBodyDataConsumerInfosRecordsOperations : TeaModel {
                        /// <summary>
                        /// <para>Whether it is a dead letter message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("deadMessage")]
                        [Validation(Required=false)]
                        public bool? DeadMessage { get; set; }

                        /// <summary>
                        /// <para>Invisible time, milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("invisibleTime")]
                        [Validation(Required=false)]
                        public long? InvisibleTime { get; set; }

                        /// <summary>
                        /// <para>Operation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-03-22 12:17:08</para>
                        /// </summary>
                        [NameInMap("operateTime")]
                        [Validation(Required=false)]
                        public string OperateTime { get; set; }

                        /// <summary>
                        /// <para>Operation type.</para>
                        /// 
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
                    /// <para>Consumer name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The message information.</para>
            /// </summary>
            [NameInMap("messageInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataMessageInfo MessageInfo { get; set; }
            public class GetTraceResponseBodyDataMessageInfo : TeaModel {
                /// <summary>
                /// <para>Message body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>Message born host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x.x.x.x</para>
                /// </summary>
                [NameInMap("bornHost")]
                [Validation(Required=false)]
                public string BornHost { get; set; }

                /// <summary>
                /// <para>Message born time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("bornTime")]
                [Validation(Required=false)]
                public string BornTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-u0t2ygjq505</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Message grpup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageGroup")]
                [Validation(Required=false)]
                public string MessageGroup { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0A79275A00207A4F0F2916C92F9A0B94</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>Message keys.</para>
                /// </summary>
                [NameInMap("messageKeys")]
                [Validation(Required=false)]
                public List<string> MessageKeys { get; set; }

                /// <summary>
                /// <para>Message tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageTag")]
                [Validation(Required=false)]
                public string MessageTag { get; set; }

                /// <summary>
                /// <para>Message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("messageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Message store host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x.x.x.x</para>
                /// </summary>
                [NameInMap("storeHost")]
                [Validation(Required=false)]
                public string StoreHost { get; set; }

                /// <summary>
                /// <para>Message store time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("storeTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Topic_normal_inspector</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>Message transaction id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("transactionId")]
                [Validation(Required=false)]
                public string TransactionId { get; set; }

                /// <summary>
                /// <para>Message user properties.</para>
                /// </summary>
                [NameInMap("userProperties")]
                [Validation(Required=false)]
                public Dictionary<string, string> UserProperties { get; set; }

            }

            /// <summary>
            /// <para>Producer trace info.</para>
            /// </summary>
            [NameInMap("producerInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataProducerInfo ProducerInfo { get; set; }
            public class GetTraceResponseBodyDataProducerInfo : TeaModel {
                /// <summary>
                /// <para>Producer record list.</para>
                /// </summary>
                [NameInMap("records")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataProducerInfoRecords> Records { get; set; }
                public class GetTraceResponseBodyDataProducerInfoRecords : TeaModel {
                    /// <summary>
                    /// <para>Arrive time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("arriveTime")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    /// <summary>
                    /// <para>Client host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx.xx.xx.xx</para>
                    /// </summary>
                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    /// <summary>
                    /// <para>Dead-letter queue message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0A79275A00207A4F0F2916C92F9A0B94</para>
                    /// </summary>
                    [NameInMap("dlqOriginMessageId")]
                    [Validation(Required=false)]
                    public string DlqOriginMessageId { get; set; }

                    /// <summary>
                    /// <para>Dead-letter queue topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_topic</para>
                    /// </summary>
                    [NameInMap("dlqOriginTopic")]
                    [Validation(Required=false)]
                    public string DlqOriginTopic { get; set; }

                    /// <summary>
                    /// <para>Message source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSOLE</para>
                    /// </summary>
                    [NameInMap("messageSource")]
                    [Validation(Required=false)]
                    public string MessageSource { get; set; }

                    /// <summary>
                    /// <para>Producer duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("produceDuration")]
                    [Validation(Required=false)]
                    public long? ProduceDuration { get; set; }

                    /// <summary>
                    /// <para>Producer status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("produceStatus")]
                    [Validation(Required=false)]
                    public string ProduceStatus { get; set; }

                    /// <summary>
                    /// <para>Producer time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-03-22 12:17:08</para>
                    /// </summary>
                    [NameInMap("produceTime")]
                    [Validation(Required=false)]
                    public string ProduceTime { get; set; }

                    [NameInMap("recallTime")]
                    [Validation(Required=false)]
                    public string RecallTime { get; set; }

                    /// <summary>
                    /// <para>Producer name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_test</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. The system generates a unique ID for each request. You can troubleshoot issues based on the request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7779A8FC-1BCD-5A1D-A603-C4A9BD8ADC49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
