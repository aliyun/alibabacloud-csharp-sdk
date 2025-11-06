// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class InstancePreivewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InstancePreivewResponseBodyData Data { get; set; }
        public class InstancePreivewResponseBodyData : TeaModel {
            [NameInMap("ExchangeNum")]
            [Validation(Required=false)]
            public int? ExchangeNum { get; set; }

            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public InstancePreivewResponseBodyDataInstances Instances { get; set; }
            public class InstancePreivewResponseBodyDataInstances : TeaModel {
                [NameInMap("InstancesVO")]
                [Validation(Required=false)]
                public List<InstancePreivewResponseBodyDataInstancesInstancesVO> InstancesVO { get; set; }
                public class InstancePreivewResponseBodyDataInstancesInstancesVO : TeaModel {
                    [NameInMap("AutoRenew")]
                    [Validation(Required=false)]
                    public bool? AutoRenew { get; set; }

                    [NameInMap("CeaseStatus")]
                    [Validation(Required=false)]
                    public bool? CeaseStatus { get; set; }

                    [NameInMap("ClassicEndpoint")]
                    [Validation(Required=false)]
                    public string ClassicEndpoint { get; set; }

                    [NameInMap("EnableDlqTtl")]
                    [Validation(Required=false)]
                    public bool? EnableDlqTtl { get; set; }

                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public long? Expire { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InvisibleTime")]
                    [Validation(Required=false)]
                    public int? InvisibleTime { get; set; }

                    [NameInMap("KmsKeyId")]
                    [Validation(Required=false)]
                    public string KmsKeyId { get; set; }

                    [NameInMap("MaxBindingCount")]
                    [Validation(Required=false)]
                    public int? MaxBindingCount { get; set; }

                    [NameInMap("MaxConnectionChannelCount")]
                    [Validation(Required=false)]
                    public int? MaxConnectionChannelCount { get; set; }

                    [NameInMap("MaxConnectionCount")]
                    [Validation(Required=false)]
                    public int? MaxConnectionCount { get; set; }

                    [NameInMap("MaxConsumeRetryTime")]
                    [Validation(Required=false)]
                    public int? MaxConsumeRetryTime { get; set; }

                    [NameInMap("MaxEIPTPS")]
                    [Validation(Required=false)]
                    public int? MaxEIPTPS { get; set; }

                    [NameInMap("MaxExchangeCount")]
                    [Validation(Required=false)]
                    public int? MaxExchangeCount { get; set; }

                    [NameInMap("MaxMsgBodyByte")]
                    [Validation(Required=false)]
                    public int? MaxMsgBodyByte { get; set; }

                    [NameInMap("MaxMsgDelayHour")]
                    [Validation(Required=false)]
                    public int? MaxMsgDelayHour { get; set; }

                    [NameInMap("MaxMsgTraceTime")]
                    [Validation(Required=false)]
                    public int? MaxMsgTraceTime { get; set; }

                    [NameInMap("MaxQueue")]
                    [Validation(Required=false)]
                    public int? MaxQueue { get; set; }

                    [NameInMap("MaxQueueConsumerCount")]
                    [Validation(Required=false)]
                    public int? MaxQueueConsumerCount { get; set; }

                    [NameInMap("MaxRetryInterval")]
                    [Validation(Required=false)]
                    public int? MaxRetryInterval { get; set; }

                    [NameInMap("MaxRetryTimes")]
                    [Validation(Required=false)]
                    public int? MaxRetryTimes { get; set; }

                    [NameInMap("MaxTPS")]
                    [Validation(Required=false)]
                    public int? MaxTPS { get; set; }

                    [NameInMap("MaxVhost")]
                    [Validation(Required=false)]
                    public int? MaxVhost { get; set; }

                    [NameInMap("OrderCreate")]
                    [Validation(Required=false)]
                    public long? OrderCreate { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    [NameInMap("PrivateEndpoint")]
                    [Validation(Required=false)]
                    public string PrivateEndpoint { get; set; }

                    [NameInMap("PublicEndpoint")]
                    [Validation(Required=false)]
                    public string PublicEndpoint { get; set; }

                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    [NameInMap("ServerlessRate")]
                    [Validation(Required=false)]
                    public double? ServerlessRate { get; set; }

                    [NameInMap("ServerlessSwitch")]
                    [Validation(Required=false)]
                    public bool? ServerlessSwitch { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public int? StorageSize { get; set; }

                    [NameInMap("SupportEIP")]
                    [Validation(Required=false)]
                    public bool? SupportEIP { get; set; }

                    [NameInMap("SupportMsgTrace")]
                    [Validation(Required=false)]
                    public bool? SupportMsgTrace { get; set; }

                    [NameInMap("SupportOpenSourceAuth")]
                    [Validation(Required=false)]
                    public bool? SupportOpenSourceAuth { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public InstancePreivewResponseBodyDataInstancesInstancesVOTags Tags { get; set; }
                    public class InstancePreivewResponseBodyDataInstancesInstancesVOTags : TeaModel {
                        [NameInMap("TagsVO")]
                        [Validation(Required=false)]
                        public List<InstancePreivewResponseBodyDataInstancesInstancesVOTagsTagsVO> TagsVO { get; set; }
                        public class InstancePreivewResponseBodyDataInstancesInstancesVOTagsTagsVO : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("UsedQueue")]
                    [Validation(Required=false)]
                    public int? UsedQueue { get; set; }

                    [NameInMap("UsedVhost")]
                    [Validation(Required=false)]
                    public int? UsedVhost { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public int? Version { get; set; }

                }

            }

            [NameInMap("QueueNum")]
            [Validation(Required=false)]
            public int? QueueNum { get; set; }

            [NameInMap("VhostNum")]
            [Validation(Required=false)]
            public int? VhostNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
