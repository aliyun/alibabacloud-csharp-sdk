// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class QueryMessageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public List<QueryMessageResponseBodyMessageList> MessageList { get; set; }
        public class QueryMessageResponseBodyMessageList : TeaModel {
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public long? Checksum { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("KeyTruncated")]
            [Validation(Required=false)]
            public bool? KeyTruncated { get; set; }

            [NameInMap("Offset")]
            [Validation(Required=false)]
            public long? Offset { get; set; }

            [NameInMap("Partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }

            [NameInMap("SerializedKeySize")]
            [Validation(Required=false)]
            public int? SerializedKeySize { get; set; }

            [NameInMap("SerializedValueSize")]
            [Validation(Required=false)]
            public int? SerializedValueSize { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TimestampType")]
            [Validation(Required=false)]
            public string TimestampType { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("TruncatedKeySize")]
            [Validation(Required=false)]
            public int? TruncatedKeySize { get; set; }

            [NameInMap("TruncatedValueSize")]
            [Validation(Required=false)]
            public int? TruncatedValueSize { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("ValueTruncated")]
            [Validation(Required=false)]
            public bool? ValueTruncated { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
