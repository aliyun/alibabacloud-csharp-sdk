// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeClusterBackupListResponseBody : TeaModel {
        /// <summary>
        /// The backup sets of the instance. An instance backup contains the backup sets of all nodes in the instance.
        /// </summary>
        [NameInMap("ClusterBackups")]
        [Validation(Required=false)]
        public List<DescribeClusterBackupListResponseBodyClusterBackups> ClusterBackups { get; set; }
        public class DescribeClusterBackupListResponseBodyClusterBackups : TeaModel {
            /// <summary>
            /// The backup sets of all nodes in the instance.
            /// </summary>
            [NameInMap("Backups")]
            [Validation(Required=false)]
            public List<DescribeClusterBackupListResponseBodyClusterBackupsBackups> Backups { get; set; }
            public class DescribeClusterBackupListResponseBodyClusterBackupsBackups : TeaModel {
                /// <summary>
                /// The public download URL of the backup file.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end time of the backup. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the backup file.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// The internal download URL of the backup file.
                /// 
                /// >  You can use this URL to download the backup file from an Elastic Compute Service (ECS) instance that is connected to the ApsaraDB for Redis instance. The ECS instance must belong to the same classic network or reside in the same virtual private cloud (VPC) as the ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The backup name.
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// The size of the backup file. Unit: bytes.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public string BackupSize { get; set; }

                /// <summary>
                /// The start time of the backup. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the backup. Valid values:
                /// 
                /// *   **OK**
                /// *   **ERROR**
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The database engine. The return value is **redis**.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The additional information.
                /// </summary>
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeClusterBackupListResponseBodyClusterBackupsBackupsExtraInfo ExtraInfo { get; set; }
                public class DescribeClusterBackupListResponseBodyClusterBackupsBackupsExtraInfo : TeaModel {
                    /// <summary>
                    /// The engine version.
                    /// </summary>
                    [NameInMap("CustinsDbVersion")]
                    [Validation(Required=false)]
                    public string CustinsDbVersion { get; set; }

                }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the backup set is available. Valid values:
                /// 
                /// *   **0**: unavailable
                /// *   **1**: available
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

            }

            /// <summary>
            /// The end time of the backup.
            /// </summary>
            [NameInMap("ClusterBackupEndTime")]
            [Validation(Required=false)]
            public string ClusterBackupEndTime { get; set; }

            /// <summary>
            /// The ID of the backup set.
            /// </summary>
            [NameInMap("ClusterBackupId")]
            [Validation(Required=false)]
            public string ClusterBackupId { get; set; }

            /// <summary>
            /// The backup mode.
            /// </summary>
            [NameInMap("ClusterBackupMode")]
            [Validation(Required=false)]
            public string ClusterBackupMode { get; set; }

            /// <summary>
            /// The size of the backup set.
            /// </summary>
            [NameInMap("ClusterBackupSize")]
            [Validation(Required=false)]
            public string ClusterBackupSize { get; set; }

            /// <summary>
            /// The start time of the backup.
            /// </summary>
            [NameInMap("ClusterBackupStartTime")]
            [Validation(Required=false)]
            public string ClusterBackupStartTime { get; set; }

            /// <summary>
            /// The status of the backup set.
            /// 
            /// *   OK
            /// *   RUNNING
            /// *   Failed
            /// </summary>
            [NameInMap("ClusterBackupStatus")]
            [Validation(Required=false)]
            public string ClusterBackupStatus { get; set; }

            /// <summary>
            /// Indicates whether the backup set is valid. A value of 0 indicates that node-level backups failed or have not been completed.
            /// </summary>
            [NameInMap("IsAvail")]
            [Validation(Required=false)]
            public int? IsAvail { get; set; }

            /// <summary>
            /// The backup progress. The system displays only the progress of running backup tasks.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The memory size of a single node during a full backup. Unit: MB.
            /// </summary>
            [NameInMap("ShardClassMemory")]
            [Validation(Required=false)]
            public int? ShardClassMemory { get; set; }

        }

        /// <summary>
        /// This parameter does not take effect. Ignore this parameter.
        /// </summary>
        [NameInMap("FreeSize")]
        [Validation(Required=false)]
        public long? FreeSize { get; set; }

        /// <summary>
        /// The size of the full backup file of the instance. Unit: bytes. Full backups originate from scheduled backups, manual backups, and backups generated during cache analysis.
        /// 
        /// >  The value of this parameter is independent of the number and size of returned backup sets. Instead, it represents the size of all valid full backups of the instance.
        /// </summary>
        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        /// <summary>
        /// The size of the log backup file of the instance. Unit: bytes. This parameter is valid only when flashback is enabled.
        /// 
        /// >  The value of this parameter is independent of the number and size of returned backup sets. Instead, it represents the size of all valid log backups of the instance.
        /// </summary>
        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
