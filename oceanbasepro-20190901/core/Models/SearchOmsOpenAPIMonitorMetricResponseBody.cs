// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SearchOmsOpenAPIMonitorMetricResponseBody : TeaModel {
        /// <summary>
        /// The suggestions (old).
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// The error code (old).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time spent in processing the request, in seconds.
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        /// <summary>
        /// The business data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchOmsOpenAPIMonitorMetricResponseBodyData> Data { get; set; }
        public class SearchOmsOpenAPIMonitorMetricResponseBodyData : TeaModel {
            /// <summary>
            /// connector data point
            /// </summary>
            [NameInMap("DataPoints")]
            [Validation(Required=false)]
            public List<SearchOmsOpenAPIMonitorMetricResponseBodyDataDataPoints> DataPoints { get; set; }
            public class SearchOmsOpenAPIMonitorMetricResponseBodyDataDataPoints : TeaModel {
                /// <summary>
                /// A millisecond-level timestamp.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The value corresponding to the time.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// The name of the metric.
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// metric tags
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

        }

        /// <summary>
        /// The error details.
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public SearchOmsOpenAPIMonitorMetricResponseBodyErrorDetail ErrorDetail { get; set; }
        public class SearchOmsOpenAPIMonitorMetricResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// The error code (new).
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error level. Valid values: CRITICAL, ERROR, and WARN.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The error description (new).
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The suggestions (new).
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

        }

        /// <summary>
        /// The error description (old).
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page size, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total count, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
