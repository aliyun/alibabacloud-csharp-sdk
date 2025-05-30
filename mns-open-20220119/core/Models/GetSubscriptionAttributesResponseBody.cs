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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionAttributesResponseBodyData Data { get; set; }
        public class GetSubscriptionAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the subscription was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
                /// <para>The queue to which dead-letter messages are delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deadLetterTargetQueue</para>
                /// </summary>
                [NameInMap("DeadLetterTargetQueue")]
                [Validation(Required=false)]
                public string DeadLetterTargetQueue { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the dead-letter message delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The endpoint to which the messages are pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The tag that is used to filter messages. Only the messages that are attached with the specified tag can be pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>important</para>
            /// </summary>
            [NameInMap("FilterTag")]
            [Validation(Required=false)]
            public string FilterTag { get; set; }

            /// <summary>
            /// <para>The time when the subscription was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1449554962</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>The content format of the messages that are pushed to the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>XML</description></item>
            /// <item><description>JSON</description></item>
            /// <item><description>SIMPLIFIED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>XML</para>
            /// </summary>
            [NameInMap("NotifyContentFormat")]
            [Validation(Required=false)]
            public string NotifyContentFormat { get; set; }

            /// <summary>
            /// <para>The retry policy that is applied if an error occurs when Message Service (MNS) pushes messages to the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BACKOFF_RETRY</description></item>
            /// <item><description>EXPONENTIAL_DECAY_RETRY</description></item>
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

            /// <summary>
            /// <para>The name of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyTopic</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the topic owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789098****</para>
            /// </summary>
            [NameInMap("TopicOwner")]
            [Validation(Required=false)]
            public string TopicOwner { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response status.</para>
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
