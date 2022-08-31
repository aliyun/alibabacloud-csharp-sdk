// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDiagnosticReportListResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ReportList")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticReportListResponseBodyReportList> ReportList { get; set; }
        public class DescribeDiagnosticReportListResponseBodyReportList : TeaModel {
            [NameInMap("DiagnosticTime")]
            [Validation(Required=false)]
            public string DiagnosticTime { get; set; }

            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
