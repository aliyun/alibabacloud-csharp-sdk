// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The number of archived backup files that are retained.
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// The cycle based on which archived backup files are retained.
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// The number of days for which archived backup files are retained.
        /// </summary>
        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The backup interval. Unit: minutes.
        /// 
        /// *   If the instance runs MySQL, the interval is the same as the value of the Snapshot Backup Start Time parameter rather than the Snapshot Backup Period parameter in the ApsaraDB RDS console. For more information, see [Back up an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98818.html).
        /// *   If the instance runs SQL Server, the interval is the same as the log backup frequency.
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// Indicates whether the log backup feature is enabled. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disabled**
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
        /// > This parameter is returned only when the instance runs SQL Server and uses cloud disks.
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// The backup settings of the secondary instance. Valid values:
        /// 
        /// *   **1**: Secondary instance preferred
        /// *   **2**: Primary instance preferred
        /// 
        /// >  This parameter is available only for instances that run SQL Server on RDS Cluster Edition. This parameter is returned only when SupportModifyBackupPriority is set to True.
        /// </summary>
        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// The number of days for which data backup files are retained.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Indicates whether to enable the single-digit second backup feature. This feature allows ApsaraDB RDS to complete a backup within single-digit seconds. Valid values:
        /// 
        /// *   **Flash**: The single-digit second backup feature is enabled.
        /// *   **Standard**: The single-digit second backup feature is disabled.
        /// 
        /// > This parameter takes effect only when you set the **BackupPolicyMode** parameter to **DataBackupPolicy**.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The method that is used to compress backup data. Valid values:
        /// 
        /// *   **0**: Backup data is not compressed.
        /// *   **1**: Backup data is compressed by using zlib.
        /// *   **2**: Backup data is compressed by using zlib that invokes more than one thread in parallel for each backup.
        /// *   **4**: Backup data is compressed by using QuickLZ and can be used to restore individual databases or tables.
        /// *   **8**: Backup data is compressed by using QuickLZ but cannot be used to restore individual databases or tables.
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// Indicates whether the log backup feature is enabled. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// Indicates whether incremental backup is enabled. Valid values:
        /// 
        /// *   **True**: Incremental backup is enabled.
        /// *   **False**: Incremental backup is disabled.
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// Indicates whether the point-in-time restoration (PITR) feature is enabled. The PITR feature is an enhancement of the log backup feature. Valid values:
        /// 
        /// *   **True**
        /// *   **False**
        /// 
        /// >  This parameter is returned only when the instance runs MySQL. For more information, see [Configure the PITR feature](https://help.aliyun.com/document_detail/2666046.html).
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// Indicates whether the log backup deletion feature is enabled. If the disk usage exceeds 80% or the remaining disk space is less than 5 GB on the instance, this feature deletes binary log files. Valid values:
        /// 
        /// *   **Disable**
        /// *   **Enable**
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// The number of hours for which log backup files are retained on the instance.
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// The maximum storage usage that is allowed for log files on the instance.
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// The backup frequency of logs. Valid values:
        /// 
        /// *   **LogInterval**: Log backups are performed every 30 minutes.
        /// *   Default value: same as the value of the **PreferredBackupPeriod** parameter.
        /// 
        /// >  This parameter is returned only when the instance runs SQL Server.
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// The number of binary log files that you want to retain on the instance.
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// The number of days for which log backup files are retained.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The number of days during which you can restore data of the instance to any point in time.
        /// </summary>
        [NameInMap("PitrRetentionPeriod")]
        [Validation(Required=false)]
        public int? PitrRetentionPeriod { get; set; }

        /// <summary>
        /// The cycle based on which you want to perform a backup. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time when a data backup is performed. The time follows the ISO 8601 standard in the *HH:mm*Z-*HH:mm*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The time when the next backup is performed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// The policy that is used to retain archived backup files if the instance is released. Valid values:
        /// 
        /// *   **None**: No archived backup files are retained.
        /// *   **Lastest**: Only the last archived backup file is retained.
        /// *   **All**: All archived backup files are retained.
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the backup settings of a secondary instance can be modified. Valid values:
        /// 
        /// *   **True**
        /// *   **False**
        /// </summary>
        [NameInMap("SupportModifyBackupPriority")]
        [Validation(Required=false)]
        public bool? SupportModifyBackupPriority { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("SupportReleasedKeep")]
        [Validation(Required=false)]
        public int? SupportReleasedKeep { get; set; }

        /// <summary>
        /// Indicates whether the instance supports snapshot backups. Valid values:
        /// 
        /// *   **1**: The instance supports snapshot backups.
        /// *   **0**: The instance does not support snapshot backups.
        /// 
        /// >  This parameter is returned only when the instance runs SQL Server.
        /// </summary>
        [NameInMap("SupportVolumeShadowCopy")]
        [Validation(Required=false)]
        public int? SupportVolumeShadowCopy { get; set; }

        /// <summary>
        /// Indicates whether log backups for SQL Server are performed verery five minutes.
        /// 
        /// *   0: No
        /// *   1: Yes
        /// </summary>
        [NameInMap("SupportsHighFrequencyBackup")]
        [Validation(Required=false)]
        public long? SupportsHighFrequencyBackup { get; set; }

    }

}
