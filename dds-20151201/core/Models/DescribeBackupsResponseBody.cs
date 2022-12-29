// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// Details about backup sets.
        /// </summary>
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyBackups Backups { get; set; }
        public class DescribeBackupsResponseBodyBackups : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyBackupsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyBackupsBackup : TeaModel {
                /// <summary>
                /// The name of the database that has been backed up.
                /// </summary>
                [NameInMap("BackupDBNames")]
                [Validation(Required=false)]
                public string BackupDBNames { get; set; }

                /// <summary>
                /// The Internet download URL of the backup set. If the download URL is unavailable, this parameter is an empty string.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end of the backup time range. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format and displayed in UTC.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the backup set.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public int? BackupId { get; set; }

                /// <summary>
                /// The internal download URL of the backup set.
                /// 
                /// >  You can use this URL to download the backup set from on the ECS instance which is on the same network as the ApsaraDB for MongoDB instance.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The backup method. Valid values:
                /// 
                /// *   **Snapshot**
                /// *   **Physical**
                /// *   **Logical**
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// The backup mode.
                /// 
                /// *   **Automated**: automatic backup
                /// *   **Manual**: manual backup
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The size of the backup set. Unit: bytes.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// The beginning of the backup time range. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format and displayed in UTC.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the backup. Valid values:
                /// 
                /// *   **Success**: The backup task is successful.
                /// *   **Failed**: The backup task failed.
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The backup method.
                /// 
                /// *   **FullBackup**: a full backup
                /// *   **IncrementalBackup**: an incremental backup
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of backup sets that were returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
