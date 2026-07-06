// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The consumption status.</para>
        /// </summary>
        [NameInMap("ConsumerProgress")]
        [Validation(Required=false)]
        public GetConsumerProgressResponseBodyConsumerProgress ConsumerProgress { get; set; }
        public class GetConsumerProgressResponseBodyConsumerProgress : TeaModel {
            /// <summary>
            /// <para>The latest time when a message was stored. This time is calculated based on the consumer offsets of all topics in the consumer group.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is not supported for topics on Serverless instances or topics that use local storage on provisioned instances. In these cases, -1 is returned.</para>
            /// </description></item>
            /// <item><description><para>For topics that use cloud storage on provisioned instances, this parameter returns the message creation timestamp. This happens only after you submit the consumer offset for a consumer group that was created in the console or by an API call. If the message has no creation timestamp, -1 is returned.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1566874931649</para>
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
            /// <para>The total number of unconsumed messages in all topics. This value is the message accumulation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

            /// <summary>
            /// <para>The status of the consumer group:</para>
            /// <list type="bullet">
            /// <item><description><para>UNKNOWN</para>
            /// </description></item>
            /// <item><description><para>PREPARING_REBALANCE</para>
            /// </description></item>
            /// <item><description><para>COMPLETING_REBALANCE</para>
            /// </description></item>
            /// <item><description><para>STABLE</para>
            /// </description></item>
            /// <item><description><para>DEAD</para>
            /// </description></item>
            /// <item><description><para>EMPTY</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STABLE</para>
            /// </summary>
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
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
