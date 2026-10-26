// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupSubscriptionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListConsumerGroupSubscriptionsResponseBodyData> Data { get; set; }
        public class ListConsumerGroupSubscriptionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consistency of the subscription relationship.</para>
            /// <list type="bullet">
            /// <item><description><para>false: The subscription relationship is inconsistent.</para>
            /// </description></item>
            /// <item><description><para>true: The subscription relationship is consistent.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("consistency")]
            [Validation(Required=false)]
            public bool? Consistency { get; set; }

            /// <summary>
            /// <para>The ID of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID-TEST</para>
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
            /// <para>The type of the filter expression.</para>
            /// <list type="bullet">
            /// <item><description><para>SQL: SQL filtering.</para>
            /// </description></item>
            /// <item><description><para>TAG: Tag filtering.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("filterExpressionType")]
            [Validation(Required=false)]
            public string FilterExpressionType { get; set; }

            /// <summary>
            /// <para>The consumption mode of the consumer group.</para>
            /// <list type="bullet">
            /// <item><description><para>BROADCASTING: The broadcast consumption mode.</para>
            /// </description></item>
            /// <item><description><para>CLUSTERING: The cluster consumption mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTERING</para>
            /// </summary>
            [NameInMap("messageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }

            /// <summary>
            /// <para>The subscription status.</para>
            /// <list type="bullet">
            /// <item><description><para>ONLINE: The consumer group is online. If a consumer group contains multiple consumers, the group is considered online as long as at least one consumer is online.</para>
            /// </description></item>
            /// <item><description><para>OFFLINE: The consumer group is offline. If a consumer group contains multiple consumers, the group is considered offline only when all consumers are offline.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("subscriptionStatus")]
            [Validation(Required=false)]
            public string SubscriptionStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the topic is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("topicCreated")]
            [Validation(Required=false)]
            public bool? TopicCreated { get; set; }

            /// <summary>
            /// <para>The topic to which the consumer group subscribes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_test</para>
            /// </summary>
            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

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
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// <para>5F4D9D5F-625B-59FF-BD4F-DA8284575DB4</para>
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
