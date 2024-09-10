// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCustomizeReportStatusRequest : TeaModel {
        /// <summary>
        /// The time when the report is pinned. Unit: milliseconds.
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// The ID of the report.
        /// 
        /// >  You can call the [DescribeCustomizeReportList](~~DescribeCustomizeReportList~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The status of the report. Valid values:
        /// 
        /// *   **0**: disabled.
        /// *   **1**: enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

    }

}
