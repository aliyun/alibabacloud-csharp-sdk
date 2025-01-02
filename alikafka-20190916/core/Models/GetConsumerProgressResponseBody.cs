// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code. If the request is successful, 200 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The consumer progress of the consumer group.</para>
        /// </summary>
        [NameInMap("ConsumerProgress")]
        [Validation(Required=false)]
        public GetConsumerProgressResponseBodyConsumerProgress ConsumerProgress { get; set; }
        public class GetConsumerProgressResponseBodyConsumerProgress : TeaModel {
            /// <summary>
            /// <para>The time when the last message consumed by the consumer group was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1566874931671</para>
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// <para>The details of rebalances in the consumer group.</para>
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
                    /// <para>The number of rebalances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public long? Generation { get; set; }

                    /// <summary>
                    /// <para>The group ID of the subscriber.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>falcon-uat</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The time when the last rebalance occurred. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1709199270</para>
                    /// </summary>
                    [NameInMap("LastRebalanceTimestamp")]
                    [Validation(Required=false)]
                    public long? LastRebalanceTimestamp { get; set; }

                    /// <summary>
                    /// <para>The cause of the rebalance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>removing member consumer-1-cd14eb9c-379b-4b8e-9bbd-76f147f8536f on LeaveGroup</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>Indicates whether new members are added to the consumer group in the rebalance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("RebalanceSuccess")]
                    [Validation(Required=false)]
                    public bool? RebalanceSuccess { get; set; }

                    /// <summary>
                    /// <para>The duration of the rebalance. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RebalanceTimeConsuming")]
                    [Validation(Required=false)]
                    public long? RebalanceTimeConsuming { get; set; }

                }

            }

            /// <summary>
            /// <para>The consumer progress of each topic to which the consumer group subscribes.</para>
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
                    /// <para>The time when the last consumed message in the topic was generated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1566874931649</para>
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// <para>The consumer offsets.</para>
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
                            /// <para>The latest offset in the partition of the topic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>9</para>
                            /// </summary>
                            [NameInMap("BrokerOffset")]
                            [Validation(Required=false)]
                            public long? BrokerOffset { get; set; }

                            /// <summary>
                            /// <para>Client ID of the application.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>client-id-KafkaConsumerDemo</para>
                            /// </summary>
                            [NameInMap("ClientId")]
                            [Validation(Required=false)]
                            public string ClientId { get; set; }

                            /// <summary>
                            /// <para>The IP address of the client.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>172.16.11.3</para>
                            /// </summary>
                            [NameInMap("ClientIp")]
                            [Validation(Required=false)]
                            public string ClientIp { get; set; }

                            /// <summary>
                            /// <para>The consumer offset in the partition of the topic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>9</para>
                            /// </summary>
                            [NameInMap("ConsumerOffset")]
                            [Validation(Required=false)]
                            public long? ConsumerOffset { get; set; }

                            /// <summary>
                            /// <para>The time when the last consumed message in the partition was generated.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1566874931649</para>
                            /// </summary>
                            [NameInMap("LastTimestamp")]
                            [Validation(Required=false)]
                            public long? LastTimestamp { get; set; }

                            /// <summary>
                            /// <para>Member ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>client-id-KafkaConsumerDemo-70b64883-a911-4882-8084-598b958848b4</para>
                            /// </summary>
                            [NameInMap("MemberId")]
                            [Validation(Required=false)]
                            public string MemberId { get; set; }

                            /// <summary>
                            /// <para>The partition ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Partition")]
                            [Validation(Required=false)]
                            public int? Partition { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kafka-test</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// <para>The number of unconsumed messages in the topic to which the consumer group subscribes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of unconsumed messages in all topics to which the consumer group subscribes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>252820E1-A2E6-45F2-B4C9-1056B8CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
