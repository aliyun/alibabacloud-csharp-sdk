// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class SearchTracesResponseBody : TeaModel {
        /// <summary>
        /// The information about the returned page.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// The information about the trace.
            /// </summary>
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public SearchTracesResponseBodyPageBeanTraceInfos TraceInfos { get; set; }
            public class SearchTracesResponseBodyPageBeanTraceInfos : TeaModel {
                [NameInMap("TraceInfo")]
                [Validation(Required=false)]
                public List<SearchTracesResponseBodyPageBeanTraceInfosTraceInfo> TraceInfo { get; set; }
                public class SearchTracesResponseBodyPageBeanTraceInfosTraceInfo : TeaModel {
                    /// <summary>
                    /// The time used to call the trace. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// The name of the span.
                    /// </summary>
                    [NameInMap("OperationName")]
                    [Validation(Required=false)]
                    public string OperationName { get; set; }

                    /// <summary>
                    /// The IP address of the server where the span resides.
                    /// </summary>
                    [NameInMap("ServiceIp")]
                    [Validation(Required=false)]
                    public string ServiceIp { get; set; }

                    /// <summary>
                    /// The name of the application.
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    /// <summary>
                    /// The map of tags.
                    /// </summary>
                    [NameInMap("TagMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> TagMap { get; set; }

                    /// <summary>
                    /// The time when the span was generated. Unit: microseconds.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// The ID of the trace.
                    /// </summary>
                    [NameInMap("TraceID")]
                    [Validation(Required=false)]
                    public string TraceID { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
