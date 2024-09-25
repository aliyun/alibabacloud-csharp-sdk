// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetConsumerGroupSubscriptionResponseBodyData> Data { get; set; }
        public class GetConsumerGroupSubscriptionResponseBodyData : TeaModel {
            [NameInMap("connectionDTO")]
            [Validation(Required=false)]
            public GetConsumerGroupSubscriptionResponseBodyDataConnectionDTO ConnectionDTO { get; set; }
            public class GetConsumerGroupSubscriptionResponseBodyDataConnectionDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.50.191@19908#-2093249153#1534215565#40385215750900</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("egressIp")]
                [Validation(Required=false)]
                public string EgressIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BROADCASTING</para>
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("subscriptionDTO")]
            [Validation(Required=false)]
            public GetConsumerGroupSubscriptionResponseBodyDataSubscriptionDTO SubscriptionDTO { get; set; }
            public class GetConsumerGroupSubscriptionResponseBodyDataSubscriptionDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GID_inspector_group</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("filterExpression")]
                [Validation(Required=false)]
                public string FilterExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UNSPECIFIED</para>
                /// </summary>
                [NameInMap("filterExpressionType")]
                [Validation(Required=false)]
                public string FilterExpressionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BROADCASTING</para>
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("subscriptionStatus")]
                [Validation(Required=false)]
                public string SubscriptionStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Topic_normal_inspector</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter instanceId is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>157DF7D4-53FB-58C6-BEBC-A9400E7EF68A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
