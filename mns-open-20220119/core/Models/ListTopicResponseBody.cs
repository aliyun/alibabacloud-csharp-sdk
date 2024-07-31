// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListTopicResponseBody : TeaModel {
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
        public ListTopicResponseBodyData Data { get; set; }
        public class ListTopicResponseBodyData : TeaModel {
            /// <summary>
            /// The data returned on the current page.
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListTopicResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// The time when the subscription was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The time when the subscription was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// Indicates whether the logging feature is enabled.
                /// 
                /// *   True
                /// *   False
                /// </summary>
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public bool? LoggingEnabled { get; set; }

                /// <summary>
                /// The maximum length of the message that is sent to the topic. Unit: bytes.
                /// </summary>
                [NameInMap("MaxMessageSize")]
                [Validation(Required=false)]
                public long? MaxMessageSize { get; set; }

                /// <summary>
                /// The number of messages in the topic.
                /// </summary>
                [NameInMap("MessageCount")]
                [Validation(Required=false)]
                public long? MessageCount { get; set; }

                /// <summary>
                /// The maximum duration for which a message is retained in the topic. After the specified retention period ends, the message is deleted regardless of whether the message is received. Unit: seconds.
                /// </summary>
                [NameInMap("MessageRetentionPeriod")]
                [Validation(Required=false)]
                public long? MessageRetentionPeriod { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListTopicResponseBodyDataPageDataTags> Tags { get; set; }
                public class ListTopicResponseBodyDataPageDataTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("TopicInnerUrl")]
                [Validation(Required=false)]
                public string TopicInnerUrl { get; set; }

                /// <summary>
                /// The name of the topic.
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("TopicUrl")]
                [Validation(Required=false)]
                public string TopicUrl { get; set; }

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
