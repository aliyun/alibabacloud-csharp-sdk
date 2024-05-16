// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class QueryMessageResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. If the request is successful, 200 is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The messages.
        /// </summary>
        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public List<QueryMessageResponseBodyMessageList> MessageList { get; set; }
        public class QueryMessageResponseBodyMessageList : TeaModel {
            /// <summary>
            /// The check value of the chaincode.
            /// </summary>
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public long? Checksum { get; set; }

            /// <summary>
            /// The message key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Indicates whether the key is truncated.
            /// </summary>
            [NameInMap("KeyTruncated")]
            [Validation(Required=false)]
            public bool? KeyTruncated { get; set; }

            /// <summary>
            /// The consumer offset of the partition.
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public long? Offset { get; set; }

            /// <summary>
            /// The partition ID.
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }

            /// <summary>
            /// The size of the key after serialization. Unit: bytes.
            /// </summary>
            [NameInMap("SerializedKeySize")]
            [Validation(Required=false)]
            public int? SerializedKeySize { get; set; }

            /// <summary>
            /// The size of the value after serialization. Unit: bytes.
            /// </summary>
            [NameInMap("SerializedValueSize")]
            [Validation(Required=false)]
            public int? SerializedValueSize { get; set; }

            /// <summary>
            /// The time when the message was created. The value of this parameter is a UNIX timestamp in milliseconds.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The time type.
            /// </summary>
            [NameInMap("TimestampType")]
            [Validation(Required=false)]
            public string TimestampType { get; set; }

            /// <summary>
            /// The topic name.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The truncated size of the message key. Unit: bytes.
            /// 
            /// >  A maximum of 1 KB content can be displayed for each message. Content that exceeds 1 KB is automatically truncated. For more information, see [Query messages](https://help.aliyun.com/zh/apsaramq-for-kafka/query-messages).
            /// </summary>
            [NameInMap("TruncatedKeySize")]
            [Validation(Required=false)]
            public int? TruncatedKeySize { get; set; }

            /// <summary>
            /// The truncated size of the message value. Unit: bytes.
            /// 
            /// >  A maximum of 1 KB content can be displayed for each message. Content that exceeds 1 KB is automatically truncated. For more information, see [Query messages](https://help.aliyun.com/zh/apsaramq-for-kafka/query-messages).
            /// </summary>
            [NameInMap("TruncatedValueSize")]
            [Validation(Required=false)]
            public int? TruncatedValueSize { get; set; }

            /// <summary>
            /// The message value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// Indicates whether the value is truncated.
            /// </summary>
            [NameInMap("ValueTruncated")]
            [Validation(Required=false)]
            public bool? ValueTruncated { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
