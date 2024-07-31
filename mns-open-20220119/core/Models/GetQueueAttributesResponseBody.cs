// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetQueueAttributesResponseBody : TeaModel {
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
        public GetQueueAttributesResponseBodyData Data { get; set; }
        public class GetQueueAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of messages that are in the Active state in the queue. The value is an approximate number.
            /// </summary>
            [NameInMap("ActiveMessages")]
            [Validation(Required=false)]
            public long? ActiveMessages { get; set; }

            /// <summary>
            /// The time when the queue was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The total number of the messages that are in the Delayed state in the queue. The value is an approximate number.
            /// </summary>
            [NameInMap("DelayMessages")]
            [Validation(Required=false)]
            public long? DelayMessages { get; set; }

            /// <summary>
            /// The period after which all messages sent to the queue are consumed. Unit: seconds.
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// The total number of the messages that are in the Inactive state in the queue. The value is an approximate number.
            /// </summary>
            [NameInMap("InactiveMessages")]
            [Validation(Required=false)]
            public long? InactiveMessages { get; set; }

            /// <summary>
            /// The time when the queue was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// Indicates whether the logging feature is enabled. Valid values:
            /// 
            /// *   True
            /// *   False
            /// </summary>
            [NameInMap("LoggingEnabled")]
            [Validation(Required=false)]
            public bool? LoggingEnabled { get; set; }

            /// <summary>
            /// The maximum length of the message that is sent to the queue. Unit: bytes.
            /// </summary>
            [NameInMap("MaximumMessageSize")]
            [Validation(Required=false)]
            public long? MaximumMessageSize { get; set; }

            /// <summary>
            /// The maximum duration for which a message is retained in the queue. After the specified retention period ends, the message is deleted regardless of whether the message is received. Unit: seconds.
            /// </summary>
            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            /// <summary>
            /// The maximum duration for which long polling requests are held after the ReceiveMessage operation is called. Unit: seconds.
            /// </summary>
            [NameInMap("PollingWaitSeconds")]
            [Validation(Required=false)]
            public long? PollingWaitSeconds { get; set; }

            /// <summary>
            /// The name of the queue.
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetQueueAttributesResponseBodyDataTags> Tags { get; set; }
            public class GetQueueAttributesResponseBodyDataTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The duration for which a message stays in the Inactive state after the message is received from the queue. Valid values: 1 to 43200. Unit: seconds. Default value: 30.
            /// </summary>
            [NameInMap("VisibilityTimeout")]
            [Validation(Required=false)]
            public long? VisibilityTimeout { get; set; }

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
