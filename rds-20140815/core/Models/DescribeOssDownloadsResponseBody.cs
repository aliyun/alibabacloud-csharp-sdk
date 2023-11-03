// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOssDownloadsResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Details of the backup file.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeOssDownloadsResponseBodyItems Items { get; set; }
        public class DescribeOssDownloadsResponseBodyItems : TeaModel {
            [NameInMap("OssDownload")]
            [Validation(Required=false)]
            public List<DescribeOssDownloadsResponseBodyItemsOssDownload> OssDownload { get; set; }
            public class DescribeOssDownloadsResponseBodyItemsOssDownload : TeaModel {
                /// <summary>
                /// The backup type. Valid values:
                /// 
                /// *   **Database**: full backup file
                /// *   **Differential_Database**: incremental backup file
                /// *   **Transaction_Log**: log backup file
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The time when the backup file was created in the download list. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the backup file.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The end of the time range during which data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The name of the backup file stored in the Object Storage Service (OSS) bucket.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The size of the backup file. Unit: MB
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// Indicates whether the backup file is available. Valid values: **True and False**.
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public string IsAvailable { get; set; }

                /// <summary>
                /// The state of the backup file. Valid values:
                /// 
                /// *   **NoStart**
                /// *   **Downloading**
                /// *   **Finished**
                /// *   **DownloadFailed**
                /// *   **VerifyFailed**
                /// *   **Deleted**
                /// *   **DeleteFailed**
                /// *   **CheckSuccess**
                /// *   **CheckFailed**
                /// *   **Restoring**
                /// *   **Restored**
                /// *   **RestoreFailed**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the migration task.
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
