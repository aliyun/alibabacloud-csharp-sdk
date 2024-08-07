// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// The details of backup sets.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// The end time of the backup task. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the backup set.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// The backup method. Only **Snapshot** may be returned.
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// The backup mode. Valid values:
                /// 
                /// *   **Automated**
                /// *   **Manual**
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The size of the backup set. Unit: bytes.
                /// 
                /// > After you delete the target snapshot backups, the storage space that is consumed by the backups is released. The released storage space is smaller than the size of the backup file, because the snapshots share specific data blocks. For more information, see [FAQ about backup](https://help.aliyun.com/document_detail/164881.html).
                /// </summary>
                [NameInMap("BackupSetSize")]
                [Validation(Required=false)]
                public string BackupSetSize { get; set; }

                /// <summary>
                /// The start time of the backup task. The time is displayed in UTC. Unit: seconds.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the backup set. Valid values:
                /// 
                /// *   **Success**
                /// *   **Failed**
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The type of the backup. Only **FullBackup** may be returned.
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The level of the backup set. Valid values:
                /// 
                /// *   **Level-1**
                /// *   **Level-2**
                /// </summary>
                [NameInMap("BackupsLevel")]
                [Validation(Required=false)]
                public string BackupsLevel { get; set; }

                /// <summary>
                /// The snapshot checkpoint time. The value follows the Unix time format. Unit: seconds.
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The expected expiration time of the backup set.
                /// > This parameter is supported only for instances that are enabled with sparse backup.
                /// </summary>
                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                /// <summary>
                /// The expected expiration type of the backup set (This parameter is supported only for instances that are enabled with sparse backup).
                /// 
                /// Valid values:
                /// 
                /// *   NEVER
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   EXPIRED
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   DELAY
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("ExpectExpireType")]
                [Validation(Required=false)]
                public string ExpectExpireType { get; set; }

                /// <summary>
                /// Indicates whether the backup set is available. Valid values:
                /// 
                /// *   **0**: The backup set is unavailable.
                /// *   **1**: The backup set is available.
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

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
        public string TotalRecordCount { get; set; }

    }

}
