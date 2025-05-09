// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupLagResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Topic.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerGroupLagResponseBodyData Data { get; set; }
        public class GetConsumerGroupLagResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Consumer Group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID-TEST</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Region ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Backlog for each topic</para>
            /// </summary>
            [NameInMap("topicLagMap")]
            [Validation(Required=false)]
            public Dictionary<string, DataTopicLagMapValue> TopicLagMap { get; set; }

            /// <summary>
            /// <para>Total lag count</para>
            /// </summary>
            [NameInMap("totalLag")]
            [Validation(Required=false)]
            public GetConsumerGroupLagResponseBodyDataTotalLag TotalLag { get; set; }
            public class GetConsumerGroupLagResponseBodyDataTotalLag : TeaModel {
                /// <summary>
                /// <para>Delivery delay time, in seconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("deliveryDuration")]
                [Validation(Required=false)]
                public long? DeliveryDuration { get; set; }

                /// <summary>
                /// <para>The number of messages being consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("inflightCount")]
                [Validation(Required=false)]
                public long? InflightCount { get; set; }

                /// <summary>
                /// <para>Last consumption time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735629607846</para>
                /// </summary>
                [NameInMap("lastConsumeTimestamp")]
                [Validation(Required=false)]
                public long? LastConsumeTimestamp { get; set; }

                /// <summary>
                /// <para>Ready message count</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("readyCount")]
                [Validation(Required=false)]
                public long? ReadyCount { get; set; }

            }

        }

        /// <summary>
        /// <para>Dynamic error code</para>
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
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter instanceId is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5764C40-FB8C-53AE-B95D-96AB3D0E9375</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
