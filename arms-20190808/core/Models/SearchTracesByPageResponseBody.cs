// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTracesByPageResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesByPageResponseBodyPageBean : TeaModel {
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
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// The details of the returned traces.
            /// </summary>
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public List<SearchTracesByPageResponseBodyPageBeanTraceInfos> TraceInfos { get; set; }
            public class SearchTracesByPageResponseBodyPageBeanTraceInfos : TeaModel {
                /// <summary>
                /// The amount of time consumed by the trace. Unit: milliseconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// The name of the traced span.
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                /// <summary>
                /// The IP address of the host where the application resides.
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
                /// The timestamp.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The trace ID.
                /// </summary>
                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
