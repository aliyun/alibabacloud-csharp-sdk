// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListZkTrackResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListZkTrackResponseBodyTraces> Traces { get; set; }
        public class ListZkTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// ACL。
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("LogDate")]
            [Validation(Required=false)]
            public string LogDate { get; set; }

            [NameInMap("MultiSize")]
            [Validation(Required=false)]
            public long? MultiSize { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// SessionId。
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("TraceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

            /// <summary>
            /// TTL。
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            [NameInMap("Watch")]
            [Validation(Required=false)]
            public bool? Watch { get; set; }

        }

    }

}
