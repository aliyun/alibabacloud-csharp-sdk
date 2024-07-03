// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// The queried backup sets.
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
                /// An array consisting of URLs from which you can download backup sets of individual databases.
                /// </summary>
                [NameInMap("BackupDownloadLinkByDB")]
                [Validation(Required=false)]
                public DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB BackupDownloadLinkByDB { get; set; }
                public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB : TeaModel {
                    [NameInMap("BackupDownloadLinkByDB")]
                    [Validation(Required=false)]
                    public List<DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB> BackupDownloadLinkByDB { get; set; }
                    public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB : TeaModel {
                        /// <summary>
                        /// The name of the database.
                        /// </summary>
                        [NameInMap("DataBase")]
                        [Validation(Required=false)]
                        public string DataBase { get; set; }

                        /// <summary>
                        /// The public URL from which you can download the backup set.
                        /// </summary>
                        [NameInMap("DownloadLink")]
                        [Validation(Required=false)]
                        public string DownloadLink { get; set; }

                        /// <summary>
                        /// The internal URL from which you can download the backup set.
                        /// </summary>
                        [NameInMap("IntranetDownloadLink")]
                        [Validation(Required=false)]
                        public string IntranetDownloadLink { get; set; }

                    }

                }

                /// <summary>
                /// The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, null is returned.
                /// 
                /// >  For example, if BackupMethod of an ApsaraDB RDS for SQL Server instance is set to **Snapshot**, a null string is returned.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end time of the backup task. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
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
                /// The initiator of the backup task. Valid values:
                /// 
                /// *   **System**
                /// *   **User**
                /// </summary>
                [NameInMap("BackupInitiator")]
                [Validation(Required=false)]
                public string BackupInitiator { get; set; }

                /// <summary>
                /// The URL that is used to download the backup set over an internal network. If the backup set cannot be downloaded, null is returned.
                /// 
                /// >  For example, if BackupMethod of an ApsaraDB RDS for SQL Server instance is set to **Snapshot**, a null string is returned.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The method that is used to generate the backup set. Valid values:
                /// 
                /// *   **Logical**: logical backup
                /// *   **Physical**: physical backup
                /// *   **Snapshot**: snapshot backup
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// The backup mode of the backup set. Valid values:
                /// 
                /// *   **Automated**
                /// *   **Manual**
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The size of the data backup file. Unit: bytes.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// The start time of the backup. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The state of the backup set.
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The backup type of the backup set. Valid values:
                /// 
                /// *   **FullBackup**
                /// *   **IncrementalBackup**
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The checksum. The value of this parameter is calculated by using the CRC64 algorithm.
                /// </summary>
                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                /// <summary>
                /// The point in time at which the data in the backup set is consistent. The return value of this parameter is a timestamp.
                /// 
                /// >  If the instance runs MySQL 5.6, a timestamp is returned. Otherwise, the value 0 is returned.
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                /// <summary>
                /// The backup mode of the backup set. Valid values:
                /// 
                /// *   0: the standard mode. This mode supports full backups and incremental backups.
                /// *   1: the copy-only mode. This mode supports only full backups.
                /// 
                /// >  This parameter is returned only when the instance runs SQL Server.
                /// </summary>
                [NameInMap("CopyOnlyBackup")]
                [Validation(Required=false)]
                public string CopyOnlyBackup { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The encryption information about the backup set.
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The ID of the instance that generates the backup set. This parameter is used to indicate whether the instance that generates the backup set is a primary instance or a secondary instance.
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// Indicates whether the backup set is available. Valid values:
                /// 
                /// *   **0**: The backup set is unavailable.
                /// *   **1**: The backup set is available.
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                /// <summary>
                /// The status of the backup set that is used to restore individual databases or tables. Valid values:
                /// 
                /// *   **OK**: The data backup file is normal.
                /// *   **LARGE**: The data backup file contains an abnormally large number of tables. It cannot be used to restore individual databases or tables.
                /// *   **EMPTY**: The data backup file is generated from a failed backup task.
                /// 
                /// >  If an empty string is returned, the data backup file cannot be used to restore individual databases or tables.
                /// </summary>
                [NameInMap("MetaStatus")]
                [Validation(Required=false)]
                public string MetaStatus { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The storage class of the backup set. Valid values:
                /// 
                /// *   **0**: regular storage
                /// *   **1**: archive storage
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// Indicates whether the backup set can be deleted. Valid values:
                /// 
                /// *   **Enabled**: The backup set can be deleted.
                /// *   **Disabled**: The backup set cannot be deleted.
                /// </summary>
                [NameInMap("StoreStatus")]
                [Validation(Required=false)]
                public string StoreStatus { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of backup sets on the current page.
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
        /// The size of the snapshot chain of the instance. Unit: bytes.
        /// </summary>
        [NameInMap("TotalEcsSnapshotSize")]
        [Validation(Required=false)]
        public long? TotalEcsSnapshotSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
