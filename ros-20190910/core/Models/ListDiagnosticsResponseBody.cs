// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListDiagnosticsResponseBody : TeaModel {
        /// <summary>
        /// The items that are diagnosed.
        /// </summary>
        [NameInMap("Diagnostics")]
        [Validation(Required=false)]
        public List<ListDiagnosticsResponseBodyDiagnostics> Diagnostics { get; set; }
        public class ListDiagnosticsResponseBodyDiagnostics : TeaModel {
            /// <summary>
            /// The time when the diagnostic report was generated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The keyword in the diagnosis.
            /// </summary>
            [NameInMap("DiagnosticKey")]
            [Validation(Required=false)]
            public string DiagnosticKey { get; set; }

            /// <summary>
            /// The product that is diagnosed.
            /// </summary>
            [NameInMap("DiagnosticProduct")]
            [Validation(Required=false)]
            public string DiagnosticProduct { get; set; }

            /// <summary>
            /// The ID of the diagnostic report.
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// The diagnosis status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned. The value 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        public string Success { get; set; }

    }

}
