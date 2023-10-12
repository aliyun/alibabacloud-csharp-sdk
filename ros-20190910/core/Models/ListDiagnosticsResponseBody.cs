// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListDiagnosticsResponseBody : TeaModel {
        [NameInMap("Diagnostics")]
        [Validation(Required=false)]
        public List<ListDiagnosticsResponseBodyDiagnostics> Diagnostics { get; set; }
        public class ListDiagnosticsResponseBodyDiagnostics : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DiagnosticKey")]
            [Validation(Required=false)]
            public string DiagnosticKey { get; set; }

            [NameInMap("DiagnosticProduct")]
            [Validation(Required=false)]
            public string DiagnosticProduct { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
