// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDiagnosticReportListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The details of a diagnostic report.
        /// </summary>
        [NameInMap("ReportList")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticReportListResponseBodyReportList> ReportList { get; set; }
        public class DescribeDiagnosticReportListResponseBodyReportList : TeaModel {
            /// <summary>
            /// The time when the diagnosis was performed.
            /// </summary>
            [NameInMap("DiagnosticTime")]
            [Validation(Required=false)]
            public string DiagnosticTime { get; set; }

            /// <summary>
            /// The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, an empty string is returned.
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// The end time of the monitoring data.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The diagnostic score.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// The start time of the monitoring data.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
