// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The frequency at which high-frequency backup is created. Valid values:
        /// 
        /// *   **-1**: High-frequency backup is disabled.
        /// *   **30**: High-frequency backups are generated every 30 minutes.
        /// *   **60**: High-frequency backups are generated every 1 hour.
        /// *   **120**: High-frequency backups are generated every 2 hours.
        /// *   **180**: High-frequency backups are generated every 3 hours.
        /// *   **240**: High-frequency backups are generated every 4 hours.
        /// *   **360**: High-frequency backups are generated every 6 hours.
        /// *   **480**: High-frequency backups are generated every 8 hours.
        /// *   **720**: High-frequency backups are generated every 12 hours.
        /// 
        /// > 
        /// 
        /// *   If the **SnapshotBackupType** parameter is set to **Standard**, this parameter is set to -1 and cannot be changed.
        /// 
        /// *   High-frequency backup takes effect only when the **SnapshotBackupType** parameter is set to **Flash** and the value of this parameter is greater than 0.
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// The retention period of full backups.
        /// 
        /// > 
        /// 
        /// *   If your instance is created before September 10, 2021, backups are retained for seven days by default.
        /// 
        /// *   If your instance is created after September 10, 2021, backups are retained for 30 days by default.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        [NameInMap("CrossRetentionValue")]
        [Validation(Required=false)]
        public int? CrossRetentionValue { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// Specifies whether to enable the log backup feature. Valid values:
        /// 
        /// *   **0** (default): The log backup feature is disabled.
        /// *   **1**: The log backup feature is enabled.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public long? EnableBackupLog { get; set; }

        [NameInMap("EnableCrossLogBackup")]
        [Validation(Required=false)]
        public int? EnableCrossLogBackup { get; set; }

        /// <summary>
        /// The number of days for which high-frequency backups are retained. Before you use this parameter, make sure that you specify the BackupInterval parameter. By default, high-frequency backups are retained for one day.
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public long? HighFrequencyBackupRetention { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The number of days for which log backups are retained. Default value: 7.
        /// 
        /// Valid values: 7 to 730.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The day of a week when the system regularly backs up data. Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// >  Separate multiple values with commas (,).
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The start time of the backup. Specify the time in the ISO 8601 standard in the *HH:mm*Z-*HH:mm*Z format. The time must be in UTC.
        /// 
        /// >  The time range is 1 hour.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The snapshot backup type. Valid values:
        /// 
        /// *   **Flash**: single-digit second backup
        /// *   **Standard** (default): standard backup
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
