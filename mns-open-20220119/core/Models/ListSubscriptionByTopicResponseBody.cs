// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListSubscriptionByTopicResponseBody : TeaModel {
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
        public ListSubscriptionByTopicResponseBodyData Data { get; set; }
        public class ListSubscriptionByTopicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The entries on the current page.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListSubscriptionByTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListSubscriptionByTopicResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>The time when the subscription was created, in Unix time format.</para>
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
                public ListSubscriptionByTopicResponseBodyDataPageDataDlqPolicy DlqPolicy { get; set; }
                public class ListSubscriptionByTopicResponseBodyDataPageDataDlqPolicy : TeaModel {
                    /// <summary>
                    /// <para>The destination queue for dead-letter messages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dead-letter-queue</para>
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
                /// <para>The tag for message filtering in the subscription. Only messages with the same tag are pushed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>important</para>
                /// </summary>
                [NameInMap("FilterTag")]
                [Validation(Required=false)]
                public string FilterTag { get; set; }

                /// <summary>
                /// <para>The time when the subscription properties were last modified. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1449554806</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// <para>The format of the message content pushed to the endpoint.
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
                /// <para>The retry policy for message push failures to the endpoint. Valid values:</para>
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
                /// <para>The subscription name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySubscription</para>
                /// </summary>
                [NameInMap("SubscriptionName")]
                [Validation(Required=false)]
                public string SubscriptionName { get; set; }

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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
