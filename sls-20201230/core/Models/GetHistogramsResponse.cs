// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetHistogramsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetHistogramsResponseBody> Body { get; set; }
        public class GetHistogramsResponseBody : TeaModel {
            /// <summary>
            /// The start time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// 
            /// The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned.
            /// </summary>
            [NameInMap("from")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// The end time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// 
            /// The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the from parameter, but does not include the end time specified by the to parameter. If you specify the same value for the from and to parameters, the interval is invalid, and an error message is returned.
            /// </summary>
            [NameInMap("to")]
            [Validation(Required=false)]
            public long? To { get; set; }

            /// <summary>
            /// The number of logs that are generated within the subinterval.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// Indicates whether the query and analysis results in the subinterval is complete. Valid values:
            /// 
            /// Complete: The query is successful, and the complete query and analysis results are returned.
            /// 
            /// Incomplete: The query is successful, but the query and analysis results are incomplete. To obtain the complete results, you must repeat the request.
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

    }

}
