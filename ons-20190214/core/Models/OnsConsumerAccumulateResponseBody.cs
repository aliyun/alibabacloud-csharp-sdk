// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerAccumulateResponseBody : TeaModel {
        /// <summary>
        /// The message accumulation information about topics to which the specified consumer subscribes.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerAccumulateResponseBodyData Data { get; set; }
        public class OnsConsumerAccumulateResponseBodyData : TeaModel {
            /// <summary>
            /// The transactions per second (TPS) for message consumption performed by consumers in the group.
            /// </summary>
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }

            /// <summary>
            /// The consumption latency.
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }

            /// <summary>
            /// The information about each topic to which the consumer group subscribes. If the **Detail** parameter in the request is set to **false**, the value of this parameter is empty.
            /// </summary>
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public OnsConsumerAccumulateResponseBodyDataDetailInTopicList DetailInTopicList { get; set; }
            public class OnsConsumerAccumulateResponseBodyDataDetailInTopicList : TeaModel {
                [NameInMap("DetailInTopicDo")]
                [Validation(Required=false)]
                public List<OnsConsumerAccumulateResponseBodyDataDetailInTopicListDetailInTopicDo> DetailInTopicDo { get; set; }
                public class OnsConsumerAccumulateResponseBodyDataDetailInTopicListDetailInTopicDo : TeaModel {
                    /// <summary>
                    /// The maximum latency of message consumption in the topic.
                    /// </summary>
                    [NameInMap("DelayTime")]
                    [Validation(Required=false)]
                    public long? DelayTime { get; set; }

                    /// <summary>
                    /// The point in time when the latest consumed message in the topic was produced.
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// The topic name.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// The number of accumulated messages in the topic.
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// The point in time when the latest message consumed by a consumer in the consumer group was produced.
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// Indicates whether the consumer group is online. The consumer group is online if one of the consumers in the group is online. Valid values:
            /// 
            /// *   **true**: The consumer group is online.
            /// *   **false**: The consumer group is offline.
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// The total number of accumulated messages in all topics to which the consumer group subscribes.
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
