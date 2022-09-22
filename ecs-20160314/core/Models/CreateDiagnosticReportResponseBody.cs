// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateDiagnosticReportResponseBody : TeaModel {
        [NameInMap("CommandInvokeResults")]
        [Validation(Required=false)]
        public CreateDiagnosticReportResponseBodyCommandInvokeResults CommandInvokeResults { get; set; }
        public class CreateDiagnosticReportResponseBodyCommandInvokeResults : TeaModel {
            [NameInMap("InvokeResult")]
            [Validation(Required=false)]
            public List<CreateDiagnosticReportResponseBodyCommandInvokeResultsInvokeResult> InvokeResult { get; set; }
            public class CreateDiagnosticReportResponseBodyCommandInvokeResultsInvokeResult : TeaModel {
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                [NameInMap("DataFileDir")]
                [Validation(Required=false)]
                public string DataFileDir { get; set; }

                [NameInMap("InvokeResult")]
                [Validation(Required=false)]
                public string InvokeResult { get; set; }

            }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
