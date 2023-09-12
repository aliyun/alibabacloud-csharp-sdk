// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryMetricByPageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned for the request. Valid values:
        /// 
        /// *   2XX: The request was successful.
        /// *   3XX: A redirection message was returned.
        /// *   4XX: The request was invalid.
        /// *   5XX: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMetricByPageResponseBodyData Data { get; set; }
        public class QueryMetricByPageResponseBodyData : TeaModel {
            /// <summary>
            /// Whether the paging query ends.
            /// 
            /// true: end.
            /// false: Need to continue pagination (continue to query after CurrentPage+1).
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// The data entries returned.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Items { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   `true`: The call was successful.
        /// *   `false`: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
