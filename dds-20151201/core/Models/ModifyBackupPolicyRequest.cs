// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The frequency at which high-frequency backups are created. Valid values:
        /// 
        /// *   **-1**: disables high-frequency backup.
        /// *   **15**: every 15 minutes.
        /// *   **30**: every 30 minutes.
        /// *   **60**: every hour.
        /// *   **120**: every 2 hours.
        /// *   **180**: every 3 hours.
        /// *   **240**: every 4 hours.
        /// *   **360**: every 6 hours.
        /// *   **480**: every 8 hours.
        /// *   **720**: every 12 hours.
        /// 
        /// > * If **SnapshotBackupType** is set to **Standard**, this parameter is set to **-1** and cannot be changed.
        /// > * High-frequency backup takes effect only when **SnapshotBackupType** is set to **Flash** and the value of this parameter is greater than 0.
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// The retention period of full backups.
        /// 
        /// > * If your instance is created before September 10, 2021, backups are retained for seven days by default.
        /// > * If your instance is created after September 10, 2021, backups are retained for 30 days by default.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable log backup. Default value: 0. Valid values:
        /// 
        /// *   **0**: disables log backup.
        /// *   **1**: enables log backup.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public long? EnableBackupLog { get; set; }

        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public long? HighFrequencyBackupRetention { get; set; }

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
        /// The day of a week on which to back up data. Valid values:
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
        /// The time range to back up data. Specify the time in the *HH:mm*Z-*HH:mm*Z format. The time must be in UTC.
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
        /// The snapshot backup type. Default value: Standard. Valid values:
        /// 
        /// *   **Flash**: single-digit second backup
        /// *   **Standard**: standard backup
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

    }

}
