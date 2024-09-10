// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportListRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to pin the report. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// The state of the report. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

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
        /// The report version. Valid values:
        /// 
        /// *   **1.0.0**
        /// *   **2.0.0**
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

}
