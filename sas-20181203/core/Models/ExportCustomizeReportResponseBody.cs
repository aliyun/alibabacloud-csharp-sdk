// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportCustomizeReportResponseBody : TeaModel {
        /// <summary>
        /// The download URL of the security report.
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// The time when the security report was exported.
        /// </summary>
        [NameInMap("ExportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        /// <summary>
        /// The ID of the export task.
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

        /// <summary>
        /// The status of the export task. Valid values:
        /// 
        /// *   **fail**: The export task fails.
        /// *   **exporting**: The export task is being executed.
        /// *   **success**: The export task is successful.
        /// </summary>
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// The name of the report file that is exported.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The ID of the security report.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp when the download URL expires. Unit: seconds.
        /// </summary>
        [NameInMap("UrlExpiredTime")]
        [Validation(Required=false)]
        public long? UrlExpiredTime { get; set; }

    }

}
