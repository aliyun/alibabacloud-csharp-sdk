// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetHistogramsResponseBody : TeaModel {
        /// <summary>
        /// The data of the charts.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistogramsResponseBodyData Data { get; set; }
        public class GetHistogramsResponseBodyData : TeaModel {
            /// <summary>
            /// The distribution of logs.
            /// </summary>
            [NameInMap("Histograms")]
            [Validation(Required=false)]
            public List<GetHistogramsResponseBodyDataHistograms> Histograms { get; set; }
            public class GetHistogramsResponseBodyDataHistograms : TeaModel {
                /// <summary>
                /// Indicates whether the query results within the subinterval is complete. Valid values:
                /// 
                /// *   true: The query is complete and the returned result is complete.
                /// *   false: The query is complete but the returned result is incomplete. You must repeat the request to obtain the complete result.
                /// </summary>
                [NameInMap("CompletedOrNot")]
                [Validation(Required=false)]
                public bool? CompletedOrNot { get; set; }

                /// <summary>
                /// The number of logs within the subinterval.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The start time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public int? From { get; set; }

                /// <summary>
                /// The end time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public int? To { get; set; }

            }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The number of logs that are generated within the subinterval.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
