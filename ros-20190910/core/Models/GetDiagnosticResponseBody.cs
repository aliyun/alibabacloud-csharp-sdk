// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetDiagnosticResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The keyword in the diagnosis.
        /// </summary>
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        /// <summary>
        /// The name of the diagnostic item.
        /// </summary>
        [NameInMap("DiagnosticProduct")]
        [Validation(Required=false)]
        public string DiagnosticProduct { get; set; }

        /// <summary>
        /// The diagnosis result.
        /// </summary>
        [NameInMap("DiagnosticResult")]
        [Validation(Required=false)]
        public GetDiagnosticResponseBodyDiagnosticResult DiagnosticResult { get; set; }
        public class GetDiagnosticResponseBodyDiagnosticResult : TeaModel {
            /// <summary>
            /// The resources that failed to be diagnosed.
            /// </summary>
            [NameInMap("FailedResources")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailedResources { get; set; }

            /// <summary>
            /// The information about Resource Orchestration Service (ROS) calling.
            /// </summary>
            [NameInMap("RosActionMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> RosActionMessages { get; set; }

            /// <summary>
            /// The stack information.
            /// </summary>
            [NameInMap("StackMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackMessages { get; set; }

        }

        /// <summary>
        /// The time when the diagnosis was performed.
        /// </summary>
        [NameInMap("DiagnosticTime")]
        [Validation(Required=false)]
        public string DiagnosticTime { get; set; }

        /// <summary>
        /// The HTTP status code
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
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
        /// The suggestion for the diagnosis.
        /// </summary>
        [NameInMap("Recommends")]
        [Validation(Required=false)]
        public Dictionary<string, object> Recommends { get; set; }

        /// <summary>
        /// The ID of the diagnostic report.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The diagnosis status. Valid values:
        /// 
        /// *   Running: The diagnosis is in progress.
        /// *   Complete: The diagnosis is complete.
        /// *   Failed: The diagnosis failed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The reason for the diagnosis status.
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

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
