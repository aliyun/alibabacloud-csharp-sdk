// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetSubscriptionAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionAttributesResponseBodyData Data { get; set; }
        public class GetSubscriptionAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the subscription was created. The value is a UNIX timestamp that represents the number of seconds that have elapsed since 00:00:00 on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1449554806</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The dead-letter queue policy.</para>
            /// </summary>
            [NameInMap("DlqPolicy")]
            [Validation(Required=false)]
            public GetSubscriptionAttributesResponseBodyDataDlqPolicy DlqPolicy { get; set; }
            public class GetSubscriptionAttributesResponseBodyDataDlqPolicy : TeaModel {
                /// <summary>
                /// <para>The target queue to which dead-letter messages are delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deadLetterTargetQueue</para>
                /// </summary>
                [NameInMap("DeadLetterTargetQueue")]
                [Validation(Required=false)]
                public string DeadLetterTargetQueue { get; set; }

                /// <summary>
                /// <para>Indicates whether dead-letter message delivery is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The endpoint of the subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The tag used for message filtering. Only messages that have a matching tag are pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>important</para>
            /// </summary>
            [NameInMap("FilterTag")]
            [Validation(Required=false)]
            public string FilterTag { get; set; }

            /// <summary>
            /// <para>The time when the subscription properties were last modified. The value is a UNIX timestamp that represents the number of seconds that have elapsed since 00:00:00 on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1449554962</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>The format of the message content that is pushed to an endpoint.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>XML</para>
            /// </description></item>
            /// <item><description><para>JSON</para>
            /// </description></item>
            /// <item><description><para>SIMPLIFIED</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>XML</para>
            /// </summary>
            [NameInMap("NotifyContentFormat")]
            [Validation(Required=false)]
            public string NotifyContentFormat { get; set; }

            /// <summary>
            /// <para>The retry policy that is used when a message fails to be pushed to an endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BACKOFF_RETRY: backoff retry.</para>
            /// </description></item>
            /// <item><description><para>EXPONENTIAL_DECAY_RETRY: exponential decay retry.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BACKOFF_RETRY</para>
            /// </summary>
            [NameInMap("NotifyStrategy")]
            [Validation(Required=false)]
            public string NotifyStrategy { get; set; }

            /// <summary>
            /// <para>The name of the subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySubscription</para>
            /// </summary>
            [NameInMap("SubscriptionName")]
            [Validation(Required=false)]
            public string SubscriptionName { get; set; }

            [NameInMap("TenantRateLimitPolicy")]
            [Validation(Required=false)]
            public GetSubscriptionAttributesResponseBodyDataTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
            public class GetSubscriptionAttributesResponseBodyDataTenantRateLimitPolicy : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("MaxReceivesPerSecond")]
                [Validation(Required=false)]
                public int? MaxReceivesPerSecond { get; set; }

            }

            /// <summary>
            /// <para>The name of the topic to which the subscription belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyTopic</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The AccountId of the owner of the topic to which the subscription belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789098****</para>
            /// </summary>
            [NameInMap("TopicOwner")]
            [Validation(Required=false)]
            public string TopicOwner { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
