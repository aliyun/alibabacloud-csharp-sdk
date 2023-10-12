// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetDiagnosticResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        [NameInMap("DiagnosticProduct")]
        [Validation(Required=false)]
        public string DiagnosticProduct { get; set; }

        [NameInMap("DiagnosticResult")]
        [Validation(Required=false)]
        public GetDiagnosticResponseBodyDiagnosticResult DiagnosticResult { get; set; }
        public class GetDiagnosticResponseBodyDiagnosticResult : TeaModel {
            [NameInMap("FailedResources")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailedResources { get; set; }

            [NameInMap("RosActionMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> RosActionMessages { get; set; }

            [NameInMap("StackMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackMessages { get; set; }

        }

        [NameInMap("DiagnosticTime")]
        [Validation(Required=false)]
        public string DiagnosticTime { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Recommends")]
        [Validation(Required=false)]
        public Dictionary<string, object> Recommends { get; set; }

        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
