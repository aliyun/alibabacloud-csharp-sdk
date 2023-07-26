// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisMonitorPerformanceResponseBody : TeaModel {
        /// <summary>
        /// Details of query execution.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisMonitorPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDiagnosisMonitorPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// The execution duration of the query. Unit: milliseconds.
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The ID of the query. It is a unique identifier of the query.
            /// </summary>
            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            /// <summary>
            /// The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The execution state of the query. Valid values:
            /// 
            /// *   **running**: The query is being executed.
            /// *   **finished**: The query is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The threshold for the number of queries.
        /// </summary>
        [NameInMap("PerformancesThreshold")]
        [Validation(Required=false)]
        public int? PerformancesThreshold { get; set; }

        /// <summary>
        /// Indicates whether the queries are truncated when the number of queries exceeds the threshold. Valid values:
        /// 
        /// *   **true**: The queries are truncated.
        /// *   **false**: The queries are not truncated.
        /// </summary>
        [NameInMap("PerformancesTruncated")]
        [Validation(Required=false)]
        public bool? PerformancesTruncated { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
