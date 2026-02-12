// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerAccumulateResponseBody : TeaModel {
        /// <summary>
        /// <para>The message accumulation information about topics to which the specified consumer subscribes.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerAccumulateResponseBodyData Data { get; set; }
        public class OnsConsumerAccumulateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The transactions per second (TPS) for message consumption performed by consumers in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }

            /// <summary>
            /// <para>The consumption latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }

            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public OnsConsumerAccumulateResponseBodyDataDetailInTopicList DetailInTopicList { get; set; }
            public class OnsConsumerAccumulateResponseBodyDataDetailInTopicList : TeaModel {
                [NameInMap("DetailInTopicDo")]
                [Validation(Required=false)]
                public List<OnsConsumerAccumulateResponseBodyDataDetailInTopicListDetailInTopicDo> DetailInTopicDo { get; set; }
                public class OnsConsumerAccumulateResponseBodyDataDetailInTopicListDetailInTopicDo : TeaModel {
                    [NameInMap("DelayTime")]
                    [Validation(Required=false)]
                    public long? DelayTime { get; set; }

                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// <para>The point in time when the latest message consumed by a consumer in the consumer group was produced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1566231000000</para>
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether the consumer group is online. The consumer group is online if one of the consumers in the group is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The consumer group is online.</description></item>
            /// <item><description><b>false</b>: The consumer group is offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The total number of accumulated messages in all topics to which the consumer group subscribes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE817BFF-B389-43CD-9419-95011AC9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
