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

            [NameInMap("RebalanceInfoList")]
            [Validation(Required=false)]
            public GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoList RebalanceInfoList { get; set; }
            public class GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoList : TeaModel {
                [NameInMap("RebalanceInfoList")]
                [Validation(Required=false)]
                public List<GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoListRebalanceInfoList> RebalanceInfoList { get; set; }
                public class GetConsumerProgressResponseBodyConsumerProgressRebalanceInfoListRebalanceInfoList : TeaModel {
                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public long? Generation { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("LastRebalanceTimestamp")]
                    [Validation(Required=false)]
                    public long? LastRebalanceTimestamp { get; set; }

                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("RebalanceSuccess")]
                    [Validation(Required=false)]
                    public bool? RebalanceSuccess { get; set; }

                    [NameInMap("RebalanceTimeConsuming")]
                    [Validation(Required=false)]
                    public long? RebalanceTimeConsuming { get; set; }

                }

            }

            [NameInMap("TopicList")]
            [Validation(Required=false)]
            public GetConsumerProgressResponseBodyConsumerProgressTopicList TopicList { get; set; }
            public class GetConsumerProgressResponseBodyConsumerProgressTopicList : TeaModel {
                [NameInMap("TopicList")]
                [Validation(Required=false)]
                public List<GetConsumerProgressResponseBodyConsumerProgressTopicListTopicList> TopicList { get; set; }
                public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicList : TeaModel {
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    [NameInMap("OffsetList")]
                    [Validation(Required=false)]
                    public GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetList OffsetList { get; set; }
                    public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetList : TeaModel {
                        [NameInMap("OffsetList")]
                        [Validation(Required=false)]
                        public List<GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetListOffsetList> OffsetList { get; set; }
                        public class GetConsumerProgressResponseBodyConsumerProgressTopicListTopicListOffsetListOffsetList : TeaModel {
                            [NameInMap("Accumulate")]
                            [Validation(Required=false)]
                            public long? Accumulate { get; set; }

                            [NameInMap("BrokerOffset")]
                            [Validation(Required=false)]
                            public long? BrokerOffset { get; set; }

                            [NameInMap("ClientId")]
                            [Validation(Required=false)]
                            public string ClientId { get; set; }

                            [NameInMap("ClientIp")]
                            [Validation(Required=false)]
                            public string ClientIp { get; set; }

                            [NameInMap("ConsumerOffset")]
                            [Validation(Required=false)]
                            public long? ConsumerOffset { get; set; }

                            [NameInMap("LastTimestamp")]
                            [Validation(Required=false)]
                            public long? LastTimestamp { get; set; }

                            [NameInMap("MemberId")]
                            [Validation(Required=false)]
                            public string MemberId { get; set; }

                            [NameInMap("Partition")]
                            [Validation(Required=false)]
                            public int? Partition { get; set; }

                        }

                    }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

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

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

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
