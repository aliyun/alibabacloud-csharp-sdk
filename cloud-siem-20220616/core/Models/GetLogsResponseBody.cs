// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetLogsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The results of the log query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLogsResponseBodyData Data { get; set; }
        public class GetLogsResponseBodyData : TeaModel {
            /// <summary>
            /// The result on the current page.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public GetLogsResponseBodyDataPageInfo PageInfo { get; set; }
            public class GetLogsResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The page number. Pages start from page 1.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of logs.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The content of the log.
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public GetLogsResponseBodyDataResponseData ResponseData { get; set; }
            public class GetLogsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The status of the log query. Valid values:
                /// 
                /// *   true: The query is complete and the returned result is complete.
                /// *   false: The query is complete but the returned result is incomplete. You must resend the request to obtain the complete result.
                /// </summary>
                [NameInMap("CompleteOrNot")]
                [Validation(Required=false)]
                public bool? CompleteOrNot { get; set; }

                /// <summary>
                /// The time period of the log query. Unit: milliseconds.
                /// </summary>
                [NameInMap("Cost")]
                [Validation(Required=false)]
                public long? Cost { get; set; }

                /// <summary>
                /// The number of entries returned.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// Indicated whether an analytic statement is contained. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("HasSql")]
                [Validation(Required=false)]
                public bool? HasSql { get; set; }

                /// <summary>
                /// The index fields of the logs.
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                /// <summary>
                /// The raw data generated in the query.
                /// </summary>
                [NameInMap("Lines")]
                [Validation(Required=false)]
                public List<object> Lines { get; set; }

            }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
