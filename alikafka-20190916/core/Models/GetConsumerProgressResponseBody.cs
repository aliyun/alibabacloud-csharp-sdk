// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. If the request is successful, 200 is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The consumer progress of the consumer group.
        /// </summary>
        [NameInMap("ConsumerProgress")]
        [Validation(Required=false)]
        public GetConsumerProgressResponseBodyConsumerProgress ConsumerProgress { get; set; }
        public class GetConsumerProgressResponseBodyConsumerProgress : TeaModel {
            /// <summary>
            /// The time when the last message consumed by the consumer group was generated.
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// The details of rebalances in the consumer group.
            /// </summary>
            [NameInMap("RebalanceInfoList")]
            [Validation(Required=false)]
            public GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoList RebalanceInfoList { get; set; }
            public class GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoList : TeaModel {
                [NameInMap("RebalanceInfoList")]
                [Validation(Required=false)]
                public List<GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoListRebalanceInfoList> RebalanceInfoList { get; set; }
                public class GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoListRebalanceInfoList : TeaModel {
                    /// <summary>
                    /// The number of rebalances.
                    /// </summary>
                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public long? Generation { get; set; }

                    /// <summary>
                    /// The group ID of the subscriber.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The time when the last rebalance occurred. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("LastRebalanceTimestamp")]
                    [Validation(Required=false)]
                    public long? LastRebalanceTimestamp { get; set; }

                    /// <summary>
                    /// The cause of the rebalance.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// Indicates whether new members are added to the consumer group in the rebalance.
                    /// </summary>
                    [NameInMap("RebalanceSuccess")]
                    [Validation(Required=false)]
                    public bool? RebalanceSuccess { get; set; }

                    /// <summary>
                    /// The duration of the rebalance. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("RebalanceTimeConsuming")]
                    [Validation(Required=false)]
                    public long? RebalanceTimeConsuming { get; set; }

                }

            }

            /// <summary>
            /// The consumer progress of each topic to which the consumer group subscribes.
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
                    /// The time when the last consumed message in the topic was generated.
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// The consumer offsets.
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
                            /// The latest offset in the partition of the topic.
                            /// </summary>
                            [NameInMap("BrokerOffset")]
                            [Validation(Required=false)]
                            public long? BrokerOffset { get; set; }

                            /// <summary>
                            /// The consumer offset in the partition of the topic.
                            /// </summary>
                            [NameInMap("ConsumerOffset")]
                            [Validation(Required=false)]
                            public long? ConsumerOffset { get; set; }

                            /// <summary>
                            /// The time when the last consumed message in the partition was generated.
                            /// </summary>
                            [NameInMap("LastTimestamp")]
                            [Validation(Required=false)]
                            public long? LastTimestamp { get; set; }

                            /// <summary>
                            /// The partition ID.
                            /// </summary>
                            [NameInMap("Partition")]
                            [Validation(Required=false)]
                            public int? Partition { get; set; }

                        }

                    }

                    /// <summary>
                    /// The topic name.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// The number of unconsumed messages in the topic to which the consumer group subscribes.
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// The total number of unconsumed messages in all topics to which the consumer group subscribes.
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
