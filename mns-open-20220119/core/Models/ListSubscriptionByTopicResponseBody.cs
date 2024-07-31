// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListSubscriptionByTopicResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSubscriptionByTopicResponseBodyData Data { get; set; }
        public class ListSubscriptionByTopicResponseBodyData : TeaModel {
            /// <summary>
            /// The data returned on the current page.
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListSubscriptionByTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListSubscriptionByTopicResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// The time when the subscription was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The endpoint to which the messages are pushed.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The tag that is used to filter messages. Only the messages that are attached with the specified tag can be pushed.
                /// </summary>
                [NameInMap("FilterTag")]
                [Validation(Required=false)]
                public string FilterTag { get; set; }

                /// <summary>
                /// The time when the subscription was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// The content format of the messages that are pushed to the endpoint. Valid values:
                /// 
                /// *   XML
                /// *   JSON
                /// *   SIMPLIFIED
                /// </summary>
                [NameInMap("NotifyContentFormat")]
                [Validation(Required=false)]
                public string NotifyContentFormat { get; set; }

                /// <summary>
                /// The retry policy that is applied if an error occurs when Message Service (MNS) pushes messages to the endpoint. Valid values:
                /// 
                /// *   BACKOFF_RETRY
                /// *   EXPONENTIAL_DECAY_RETRY
                /// </summary>
                [NameInMap("NotifyStrategy")]
                [Validation(Required=false)]
                public string NotifyStrategy { get; set; }

                /// <summary>
                /// The name of the subscription.
                /// </summary>
                [NameInMap("SubscriptionName")]
                [Validation(Required=false)]
                public string SubscriptionName { get; set; }

                /// <summary>
                /// The name of the topic.
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// The Alibaba Cloud account ID of the topic owner.
                /// </summary>
                [NameInMap("TopicOwner")]
                [Validation(Required=false)]
                public string TopicOwner { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            /// <summary>
            /// The number of entries on the current page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The response status.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
