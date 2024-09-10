// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportCustomizeReportRequest : TeaModel {
        /// <summary>
        /// The type of the security report that you want to export. Valid values:
        /// 
        /// *   **HTML**
        /// *   **PDF**
        /// 
        /// >  The default value is HTML. PDF is supported only for security reports in version 2.0.0.
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// The ID of the security report.
        /// 
        /// >  You can call the [DescribeCustomizeReportList](~~DescribeCustomizeReportList~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
