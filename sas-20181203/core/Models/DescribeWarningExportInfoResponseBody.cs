// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWarningExportInfoResponseBody : TeaModel {
        /// <summary>
        /// The number of baseline entries that are exported.
        /// </summary>
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// The status of the export task.
        /// 
        /// Valid values:
        /// 
        /// *   **init**: The task is being initialized.
        /// *   **exporting**: The task is in progress.
        /// *   **success**: The task is successful.
        /// </summary>
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// The name of the exported Excel file.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The ID of the export task for the baseline check result.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The URL at which you can download the exported Excel file.
        /// </summary>
        [NameInMap("Link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// The message that shows the export task result. The value is fixed as **successful**, which indicates that the export task is successful.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The progress percentage of the export task.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of baseline entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
