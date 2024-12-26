// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetConsumerGroupSubscriptionResponseBodyData> Data { get; set; }
        public class GetConsumerGroupSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The connection details.</para>
            /// </summary>
            [NameInMap("connectionDTO")]
            [Validation(Required=false)]
            public GetConsumerGroupSubscriptionResponseBodyDataConnectionDTO ConnectionDTO { get; set; }
            public class GetConsumerGroupSubscriptionResponseBodyDataConnectionDTO : TeaModel {
                /// <summary>
                /// <para>The client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.50.191@19908#-2093249153#1534215565#40385215750900</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The public IP address of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("egressIp")]
                [Validation(Required=false)]
                public string EgressIp { get; set; }

                /// <summary>
                /// <para>The host name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The language used by the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The consumption mode of the consumer group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BROADCASTING: broadcasting consumption</description></item>
                /// <item><description>CLUSTERING: clustering consumption</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BROADCASTING</para>
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// <para>The client version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The subscription details.</para>
            /// </summary>
            [NameInMap("subscriptionDTO")]
            [Validation(Required=false)]
            public GetConsumerGroupSubscriptionResponseBodyDataSubscriptionDTO SubscriptionDTO { get; set; }
            public class GetConsumerGroupSubscriptionResponseBodyDataSubscriptionDTO : TeaModel {
                /// <summary>
                /// <para>The consumer group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_inspector_group</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <para>The filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("filterExpression")]
                [Validation(Required=false)]
                public string FilterExpression { get; set; }

                /// <summary>
                /// <para>The type of the filter expression. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SQL: filters messages by using SQL expressions.</description></item>
                /// <item><description>TAG: filters messages by using tags.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNSPECIFIED</para>
                /// </summary>
                [NameInMap("filterExpressionType")]
                [Validation(Required=false)]
                public string FilterExpressionType { get; set; }

                /// <summary>
                /// <para>The consumption mode of the consumer group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BROADCASTING: broadcasting consumption</description></item>
                /// <item><description>CLUSTERING: clustering consumption</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BROADCASTING</para>
                /// </summary>
                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                /// <summary>
                /// <para>The subscription status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ONLINE: The consumer group is online. If the consumer group contains multiple consumers, this value is returned if at least one of the consumers is online.</description></item>
                /// <item><description>OFFLINE: The consumer group is offline. If the consumer group contains multiple consumers, this value is returned only if all consumers are offline.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("subscriptionStatus")]
                [Validation(Required=false)]
                public string SubscriptionStatus { get; set; }

                /// <summary>
                /// <para>The topic to which the consumer group subscribes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Topic_normal_inspector</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
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
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>157DF7D4-53FB-58C6-BEBC-A9400E7EF68A</para>
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
