// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// The following parameters are no longer used. Ignore the parameters.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// This parameter is no longer used. Ignore this parameter.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// Details of the backup files.
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
                /// The names of the databases that are backed up. The default value is **all**, which indicates that all databases are backed up.
                /// </summary>
                [NameInMap("BackupDBNames")]
                [Validation(Required=false)]
                public string BackupDBNames { get; set; }

                /// <summary>
                /// The public download URL of the backup file.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end time of the backup.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the backup file.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public long? BackupId { get; set; }

                /// <summary>
                /// The internal download URL of the backup file.
                /// 
                /// >  You can use this URL to download the backup file from an Elastic Compute Service (ECS) instance that is connected to the ApsaraDB for Redis instance. The ECS instance must belong to the same classic network or reside in the same virtual private cloud (VPC) as the ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The ID of the backup task.
                /// </summary>
                [NameInMap("BackupJobID")]
                [Validation(Required=false)]
                public long? BackupJobID { get; set; }

                /// <summary>
                /// The backup method. Valid values:
                /// 
                /// *   **Logical**
                /// *   **Physical**
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
                /// The size of the backup file.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// The start time of the backup.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the backup. Valid values:
                /// 
                /// *   **Success**
                /// *   **Failed**
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The backup type. Valid values:
                /// 
                /// *   **FullBackup**
                /// *   **IncrementalBackup**
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The engine version (major version) of the instance.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The node ID.
                /// 
                /// >  If the instance uses the standard architecture, this parameter returns the instance ID.
                /// </summary>
                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

                [NameInMap("RecoverConfigMode")]
                [Validation(Required=false)]
                public string RecoverConfigMode { get; set; }

            }

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
        /// >  The value of this parameter is independent of the number and size of the returned backup sets. Instead, it reflects the total size of all valid full backups of the instance.
        /// </summary>
        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        /// <summary>
        /// The size of the log backup file of the instance. Unit: bytes. This value is valid only when flashback is enabled.
        /// 
        /// >  The value of this parameter is independent of the number and size of the returned backup sets. Instead, it reflects the total size of all valid log backups of the instance.
        /// </summary>
        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
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
        /// The total number of backup files that were returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
