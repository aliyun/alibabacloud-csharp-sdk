// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The number of archived backup files that are retained. Default value: **1**. Valid values:
        /// 
        /// *   Valid values when **ArchiveBackupKeepPolicy** is set to **ByMonth**: **1** to **31**.
        /// *   Valid values when **ArchiveBackupKeepPolicy** is set to **ByWeek**: **1** to **7**.
        /// 
        /// > *   You do not need to specify this parameter when **ArchiveBackupKeepPolicy** is set to **KeepAll**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public int? ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// The retention period of archived backup files. The number of archived backup files that can be retained within the specified retention period is specified by **ArchiveBackupKeepCount**. Default value: **0**. Valid values:
        /// 
        /// *   **ByMonth**
        /// *   **ByWeek**
        /// *   **KeepAll**
        /// 
        /// > This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// The number of days for which the archived backup is retained. The default value **0** specifies that the backup archiving feature is disabled. Valid values: **30** to **1095**.
        /// 
        /// > This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The frequency at which you want to perform a snapshot backup on the instance. Valid values:
        /// 
        /// *   **-1**: No backup frequencies are specified.
        /// *   **30**: A snapshot backup is performed every 30 minutes.
        /// *   **60**: A snapshot backup is performed every 60 minutes.
        /// *   **120**: A snapshot backup is performed every 120 minutes.
        /// *   **240**: A snapshot backup is performed every 240 minutes.
        /// *   **480**: A snapshot backup is performed every 480 minutes.
        /// 
        /// > *   You can configure a backup policy by using this parameter and the **PreferredBackupPeriod** parameter. For example, if you set **PreferredBackupPeriod** to Saturday,Sunday and BackupInterval to \\*\\*-1\\*\\*, a snapshot backup is performed on every Saturday and Sunday.
        /// > *   If the instance runs PostgreSQL, BackupInterval is supported only when the instance is equipped with cloud disks.
        /// > *   If the instance runs SQL Server, BackupInterval is supported only when the snapshot backup feature is enabled for the instance. For more information, see [Enable snapshot backups for an ApsaraDB RDS for SQL Server instance](https://help.aliyun.com/document_detail/211143.html).
        /// > *   If **Category** is set to **Flash**, BackupInterval is invalid.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// Specifies whether to enable the log backup feature. Valid values:
        /// 
        /// *   **Enable**: enables the feature.
        /// *   **Disabled**: disables the feature.
        /// 
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// The backup method of the instance. Valid values:
        /// 
        /// *   **Physical**: physical backup
        /// *   **Snapshot**: snapshot backup
        /// 
        /// Default value: **Physical**.
        /// 
        /// > *   This parameter takes effect only on instances that run SQL Server with cloud disks.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// The type of the backup. Valid values:
        /// 
        /// *   **DataBackupPolicy**: data backup
        /// *   **LogBackupPolicy**: log backup
        /// </summary>
        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        /// <summary>
        /// Specifies whether the backup settings of a secondary instance are configured. Valid values:
        /// 
        /// *   **1**: secondary instance preferred
        /// *   **2**: primary instance preferred
        /// 
        /// > *   This parameter is suitable only for instances that run SQL Server on RDS Cluster Edition.
        /// > *   This parameter takes effect only when **BackupMethod** is set to **Physical**. If **BackupMethod** is set to **Snapshot**, backups are forcefully performed on the primary instance that runs SQL Server on RDS Cluster Edition.
        /// </summary>
        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// The number of days for which you want to retain data backup files. Valid values: **7 to 730**.
        /// 
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Specifies whether to enable the single-digit second backup feature. Valid values:
        /// 
        /// *   **Flash**: enables the feature.
        /// *   **Standard**: disables the feature.
        /// 
        /// > This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The format that is used to compress backup data. Valid values:
        /// 
        /// *   **0**: Backups are not compressed.
        /// *   **1**: The zlib tool is used to compress backups into .tar.gz files.
        /// *   **2**: The zlib tool is used to compress backups in parallel.
        /// *   **4**: The QuickLZ tool is used to compress backups into .xb.gz files. This compression format is supported for instances that run MySQL 5.6 or MySQL 5.7. Backups in this compression format can be used to restore individual databases and tables. For more information, see [Restore individual databases and tables of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/103175.html).
        /// *   **8**: The QuickLZ tool is used to compress backups into .xb.gz files. This compression format is supported only for instances that run MySQL 8.0. Backups in this compression format cannot be used to restore individual databases and tables.
        /// 
        /// > This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable the log backup feature. Valid values:
        /// 
        /// *   **True** or **1**: enables the log backup feature.
        /// *   **False** or **0**: disables the log backup feature.
        /// 
        /// > 
        /// 
        /// *   You must specify this parameter when you set the **BackupPolicyMode** parameter to **LogBackupPolicy**.
        /// 
        /// *   This parameter takes effect only when you set the **BackupPolicyMode** parameter to **LogBackupPolicy**.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// Specifies whether to enable incremental backup. Valid values:
        /// 
        /// *   **false** (default): disables the feature.
        /// *   **true**: enables the feature.
        /// 
        /// > *   This parameter takes effect only on instances that run SQL Server with cloud disks.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// Specifies whether to forcefully delete log backup files from the instance when the storage usage of the instance exceeds 80% or the amount of remaining storage on the instance is less than 5 GB. Valid values: **Enable and Disable**. You can retain the default value.
        /// 
        /// > *   You must specify this parameter when you set the **BackupPolicyMode** parameter to **LogBackupPolicy**.
        /// > *   This parameter takes effect only when you set the **BackupPolicyMode** parameter to **LogBackupPolicy**.
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// The number of hours for which you want to retain log backup files on the instance. Valid values: **0 to 168**. The value 0 specifies that log backup files are not retained on the instance. The value 168 is calculated based on the following formula: 7 × 24.
        /// 
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **LogBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **LogBackupPolicy**.
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public string LocalLogRetentionHours { get; set; }

        /// <summary>
        /// The maximum storage usage that is allowed for log backup files on the instance. If the storage usage for log backup files on the instance exceeds the value of this parameter, the system deletes earlier log backup files until the storage usage falls below the value of this parameter. Valid values:**0 to 50**. You can retain the default value.
        /// 
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **LogBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **LogBackupPolicy**.
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// The frequency at which you want to back up the logs of the instance. Valid values:
        /// 
        /// *   **LogInterval**: A log backup is performed every 30 minutes.
        /// *   The default value is the same as the data backup frequency.
        /// 
        /// > *   The value **LogInterval** is supported only for instances that run SQL Server.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// The number of binary log files that you want to retain on the instance. Default value: **60**. Valid values: **6** to **100**.
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only when you set the **BackupPolicyMode** parameter to **LogBackupPolicy**.
        /// 
        /// *   If the instance runs MySQL, you can set this parameter to \\*\\*-1\\*\\*. The value \\*\\*-1\\*\\* specifies that an unlimited number of binary log files can be retained on the instance.
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// The number of days for which the log backup is retained. Valid values: **7 to 730**. The log backup retention period cannot be longer than the data backup retention period.
        /// 
        /// > *   If you enable the log backup feature, you can specify the log backup retention period. This parameter is supported for instances that run MySQL and PostgreSQL.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy** or **LogBackupPolicy**.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The backup cycle. Specify at least two days of the week and separate the days with commas (,). Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// > *   You can configure a backup policy by using this parameter and the **BackupInterval** parameter. For example, if you set this parameter to Saturday,Sunday and the **BackupInterval** parameter to 30, a backup is performed every 30 minutes on every Saturday and Sunday.
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time at which you want to perform a backup. Specify the time in the ISO 8601 standard in the *HH:mm*Z-*HH:mm*Z format. The time must be in UTC.
        /// 
        /// > *   This parameter must be specified when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// > *   This parameter takes effect only when **BackupPolicyMode** is set to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The policy that is used to retain archived backup files if the instance is released. Valid values:
        /// 
        /// *   **None**: No archived backup files are retained.
        /// *   **Lastest**: Only the last archived backup file is retained.
        /// *   **All**: All archived backup files are retained.
        /// 
        /// > *   This parameter takes effect only when you set the **BackupPolicyMode** parameter to **DataBackupPolicy**.
        /// > *   If the instance uses cloud disks and was created on or after February 1, 2024, this parameter is automatically set to **Lastest**. If the instance uses local disks in the same scenario, this parameter is automatically set to **None**. For more information, see [Backup for deleted instances](https://help.aliyun.com/document_detail/2836955.html).
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
