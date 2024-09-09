// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetTraceResponseBody : TeaModel {
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
                [NameInMap("delayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                [NameInMap("operations")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataBrokerInfoOperations> Operations { get; set; }
                public class GetTraceResponseBodyDataBrokerInfoOperations : TeaModel {
                    [NameInMap("operateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    [NameInMap("operateType")]
                    [Validation(Required=false)]
                    public string OperateType { get; set; }

                }

                [NameInMap("presetDelayTime")]
                [Validation(Required=false)]
                public string PresetDelayTime { get; set; }

            }

            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<GetTraceResponseBodyDataConsumerInfos> ConsumerInfos { get; set; }
            public class GetTraceResponseBodyDataConsumerInfos : TeaModel {
                [NameInMap("consumeStatus")]
                [Validation(Required=false)]
                public string ConsumeStatus { get; set; }

                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                [NameInMap("deadLetterInfo")]
                [Validation(Required=false)]
                public GetTraceResponseBodyDataConsumerInfosDeadLetterInfo DeadLetterInfo { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosDeadLetterInfo : TeaModel {
                    [NameInMap("messageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    [NameInMap("toDlqTime")]
                    [Validation(Required=false)]
                    public string ToDlqTime { get; set; }

                    [NameInMap("topicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                [NameInMap("deadMessage")]
                [Validation(Required=false)]
                public bool? DeadMessage { get; set; }

                [NameInMap("records")]
                [Validation(Required=false)]
                public List<GetTraceResponseBodyDataConsumerInfosRecords> Records { get; set; }
                public class GetTraceResponseBodyDataConsumerInfosRecords : TeaModel {
                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    [NameInMap("consumeStatus")]
                    [Validation(Required=false)]
                    public string ConsumeStatus { get; set; }

                    [NameInMap("fifoEnable")]
                    [Validation(Required=false)]
                    public bool? FifoEnable { get; set; }

                    [NameInMap("operations")]
                    [Validation(Required=false)]
                    public List<GetTraceResponseBodyDataConsumerInfosRecordsOperations> Operations { get; set; }
                    public class GetTraceResponseBodyDataConsumerInfosRecordsOperations : TeaModel {
                        [NameInMap("deadMessage")]
                        [Validation(Required=false)]
                        public bool? DeadMessage { get; set; }

                        [NameInMap("invisibleTime")]
                        [Validation(Required=false)]
                        public long? InvisibleTime { get; set; }

                        [NameInMap("operateTime")]
                        [Validation(Required=false)]
                        public string OperateTime { get; set; }

                        [NameInMap("operateType")]
                        [Validation(Required=false)]
                        public string OperateType { get; set; }

                    }

                    /// <summary>
                    /// POP_CK
                    /// </summary>
                    [NameInMap("popCk")]
                    [Validation(Required=false)]
                    public string PopCk { get; set; }

                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("messageInfo")]
            [Validation(Required=false)]
            public GetTraceResponseBodyDataMessageInfo MessageInfo { get; set; }
            public class GetTraceResponseBodyDataMessageInfo : TeaModel {
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                [NameInMap("bornHost")]
                [Validation(Required=false)]
                public string BornHost { get; set; }

                [NameInMap("bornTime")]
                [Validation(Required=false)]
                public string BornTime { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("messageGroup")]
                [Validation(Required=false)]
                public string MessageGroup { get; set; }

                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("messageKeys")]
                [Validation(Required=false)]
                public List<string> MessageKeys { get; set; }

                [NameInMap("messageTag")]
                [Validation(Required=false)]
                public string MessageTag { get; set; }

                [NameInMap("messageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("setted")]
                [Validation(Required=false)]
                public bool? Setted { get; set; }

                [NameInMap("storeHost")]
                [Validation(Required=false)]
                public string StoreHost { get; set; }

                [NameInMap("storeTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

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
                    [NameInMap("arriveTime")]
                    [Validation(Required=false)]
                    public string ArriveTime { get; set; }

                    [NameInMap("clientHost")]
                    [Validation(Required=false)]
                    public string ClientHost { get; set; }

                    [NameInMap("dlqOriginMessageId")]
                    [Validation(Required=false)]
                    public string DlqOriginMessageId { get; set; }

                    [NameInMap("dlqOriginTopic")]
                    [Validation(Required=false)]
                    public string DlqOriginTopic { get; set; }

                    [NameInMap("messageSource")]
                    [Validation(Required=false)]
                    public string MessageSource { get; set; }

                    [NameInMap("produceDuration")]
                    [Validation(Required=false)]
                    public long? ProduceDuration { get; set; }

                    [NameInMap("produceStatus")]
                    [Validation(Required=false)]
                    public string ProduceStatus { get; set; }

                    [NameInMap("produceTime")]
                    [Validation(Required=false)]
                    public string ProduceTime { get; set; }

                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
