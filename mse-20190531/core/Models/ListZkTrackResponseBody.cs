// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListZkTrackResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The track data.
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListZkTrackResponseBodyTraces> Traces { get; set; }
        public class ListZkTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// The access control list (ACL).
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// The data type. Valid values:
            /// 
            /// *   persist
            /// *   ephemeral
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// The type of the event. Valid values: For tracks of the Notify type:
            /// 
            /// *   NodeCreated
            /// *   NodeDeleted
            /// *   NodeDataChanged
            /// *   NodeChildrenChanged
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// Indicates whether the transaction ended.
            /// </summary>
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// The logging time.
            /// </summary>
            [NameInMap("LogDate")]
            [Validation(Required=false)]
            public string LogDate { get; set; }

            /// <summary>
            /// The transaction size.
            /// </summary>
            [NameInMap("MultiSize")]
            [Validation(Required=false)]
            public long? MultiSize { get; set; }

            /// <summary>
            /// The operation type. For tracks of the Push type:
            /// 
            /// *   Create
            /// *   Update
            /// *   Delete
            /// *   SetAcl
            /// *   Multi
            /// 
            /// For tracks of the Pull type:
            /// 
            /// *   GetData
            /// *   GetChild
            /// *   GetStat
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// The path.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The result.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The session ID.
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// The timestamp (not available).
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// The type of the track. Valid values:
            /// 
            /// *   Push
            /// *   Pull
            /// *   Notify
            /// </summary>
            [NameInMap("TraceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

            /// <summary>
            /// The time to live (TTL).
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// Indicates whether to enable the monitoring feature.
            /// </summary>
            [NameInMap("Watch")]
            [Validation(Required=false)]
            public bool? Watch { get; set; }

        }

    }

}
