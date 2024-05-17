// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogsResponseBody : TeaModel {
        /// <summary>
        /// The details of the backup logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupLogsResponseBodyItems Items { get; set; }
        public class DescribeBackupLogsResponseBodyItems : TeaModel {
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public List<DescribeBackupLogsResponseBodyItemsBackupLog> BackupLog { get; set; }
            public class DescribeBackupLogsResponseBodyItemsBackupLog : TeaModel {
                /// <summary>
                /// The time when the backup task ended. The time follows the ISO 8601 standard in the `YYYY-MM-DD\\"T\\"HH:mm:ssZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupLogEndTime")]
                [Validation(Required=false)]
                public string BackupLogEndTime { get; set; }

                /// <summary>
                /// The ID of the backup log.
                /// </summary>
                [NameInMap("BackupLogId")]
                [Validation(Required=false)]
                public string BackupLogId { get; set; }

                /// <summary>
                /// The name of the backup log.
                /// </summary>
                [NameInMap("BackupLogName")]
                [Validation(Required=false)]
                public string BackupLogName { get; set; }

                /// <summary>
                /// The size of the backup log. Unit: bytes.
                /// </summary>
                [NameInMap("BackupLogSize")]
                [Validation(Required=false)]
                public string BackupLogSize { get; set; }

                /// <summary>
                /// The time when the backup task started. The time follows the ISO 8601 standard in the `YYYY-MM-DD\\"T\\"HH:mm:ssZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                /// <summary>
                /// The public URL used to download the backup log.
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// The internal URL used to download the backup log.
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// The time when the download URL expires.
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
