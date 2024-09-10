// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportListResponseBody : TeaModel {
        /// <summary>
        /// The reports.
        /// </summary>
        [NameInMap("ReportList")]
        [Validation(Required=false)]
        public List<DescribeCustomizeReportListResponseBodyReportList> ReportList { get; set; }
        public class DescribeCustomizeReportListResponseBodyReportList : TeaModel {
            /// <summary>
            /// Indicates whether the report is the default report. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// The timestamp when the report is pinned. Unit: milliseconds.
            /// </summary>
            [NameInMap("PinnedTime")]
            [Validation(Required=false)]
            public long? PinnedTime { get; set; }

            /// <summary>
            /// The most recent days for report statistics.
            /// </summary>
            [NameInMap("ReportDays")]
            [Validation(Required=false)]
            public int? ReportDays { get; set; }

            /// <summary>
            /// The end date on which the report is sent. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ReportEndDate")]
            [Validation(Required=false)]
            public long? ReportEndDate { get; set; }

            /// <summary>
            /// The ID of the report.
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public long? ReportId { get; set; }

            /// <summary>
            /// The start date on which the report is sent. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ReportStartDate")]
            [Validation(Required=false)]
            public long? ReportStartDate { get; set; }

            /// <summary>
            /// The state of the report. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// The type of the report. Valid values:
            /// 
            /// *   **0**: daily report
            /// *   **1**: weekly report
            /// *   **2**: monthly report
            /// *   **3**: report whose statistics are collected in a custom time range
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public int? ReportType { get; set; }

            /// <summary>
            /// The report version.
            /// </summary>
            [NameInMap("ReportVersion")]
            [Validation(Required=false)]
            public string ReportVersion { get; set; }

            /// <summary>
            /// The name of the report.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
