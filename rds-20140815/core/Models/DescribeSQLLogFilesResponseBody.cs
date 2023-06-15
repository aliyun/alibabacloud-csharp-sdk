// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogFilesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the returned audit log files.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogFilesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeSQLLogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeSQLLogFilesResponseBodyItemsLogFile : TeaModel {
                /// <summary>
                /// The name of the audit log file.
                /// </summary>
                [NameInMap("FileID")]
                [Validation(Required=false)]
                public string FileID { get; set; }

                /// <summary>
                /// The download URL of the audit log file. If the audit log file cannot be downloaded, this parameter is null.
                /// </summary>
                [NameInMap("LogDownloadURL")]
                [Validation(Required=false)]
                public string LogDownloadURL { get; set; }

                /// <summary>
                /// The time at which the last SQL statement recorded in the audit log file was executed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// The size of the audit log file. Unit: bytes.
                /// </summary>
                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public string LogSize { get; set; }

                /// <summary>
                /// The time at which the first SQL statement recorded in the audit log file was executed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogStartTime")]
                [Validation(Required=false)]
                public string LogStartTime { get; set; }

                /// <summary>
                /// The status of the audit log file. Valid values:
                /// 
                /// *   **Success**
                /// *   **Failed**
                /// *   **Generating**
                /// </summary>
                [NameInMap("LogStatus")]
                [Validation(Required=false)]
                public string LogStatus { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
