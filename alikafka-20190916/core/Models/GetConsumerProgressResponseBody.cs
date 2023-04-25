// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressResponseBody : TeaModel {
        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The time when the last message consumed by the consumer group was generated.
        /// </summary>
        [NameInMap("ConsumerProgress")]
        [Validation(Required=false)]
        public GetConsumerProgressResponseBodyConsumerProgress ConsumerProgress { get; set; }
        public class GetConsumerProgressResponseBodyConsumerProgress : TeaModel {
            /// <summary>
            /// The number of messages that were not consumed in all topics. This is also known as the number of accumulated messages in all topics.
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// The number of messages that were not consumed in the topic. This is also known as the number of accumulated messages in the topic.
            /// </summary>
            [NameInMap("TopicList")]
            [Validation(Required=false)]
            public GetConsumerProgressResponseBodyConsumerProgressTopicList TopicList { get; set; }
            public class GetConsumerProgressResponseBodyConsumerProgressTopicList : TeaModel {
                [NameInMap("TopicList")]
                [Validation(Required=false)]
                public List<GetConsumerProgressResponseBodyConsumerProgressTopicListTopicList> TopicList { get; set; }
                public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicList : TeaModel {
                    /// <summary>
                    /// The name of the topic.
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// The ID of the partition.
                    /// </summary>
                    [NameInMap("OffsetList")]
                    [Validation(Required=false)]
                    public GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetList OffsetList { get; set; }
                    public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetList : TeaModel {
                        [NameInMap("OffsetList")]
                        [Validation(Required=false)]
                        public List<GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetListOffsetList> OffsetList { get; set; }
                        public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetListOffsetList : TeaModel {
                            /// <summary>
                            /// The consumer offset in the partition of the topic.
                            /// </summary>
                            [NameInMap("BrokerOffset")]
                            [Validation(Required=false)]
                            public long? BrokerOffset { get; set; }

                            /// <summary>
                            /// The time when the last consumed message in the partition was generated.
                            /// </summary>
                            [NameInMap("ConsumerOffset")]
                            [Validation(Required=false)]
                            public long? ConsumerOffset { get; set; }

                            /// <summary>
                            /// Queries the consumption status of a specified consumer group.
                            /// </summary>
                            [NameInMap("LastTimestamp")]
                            [Validation(Required=false)]
                            public long? LastTimestamp { get; set; }

                            /// <summary>
                            /// The latest offset in the partition of the topic.
                            /// </summary>
                            [NameInMap("Partition")]
                            [Validation(Required=false)]
                            public int? Partition { get; set; }

                        }

                    }

                    /// <summary>
                    /// The information about offsets in the topic.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// The time when the last consumed message in the topic was generated.
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// The consumption progress of each topic to which the consumer group is subscribed.
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The consumption status of the consumer group.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
