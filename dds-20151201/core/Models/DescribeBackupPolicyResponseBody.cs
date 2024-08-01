// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The frequency at which high-frequency backup is created. Valid values:
        /// 
        /// *   **-1**: High-frequency backup is disabled.
        /// *   **15**: every 15 minutes.
        /// *   **30**: every 30 minutes.
        /// *   **60**: every hour.
        /// *   **120**: every 2 hours.
        /// *   **180**: every 3 hours.
        /// *   **240**: every 4 hours.
        /// *   **360**: every 6 hours.
        /// *   **480**: every 8 hours.
        /// *   **720**: every 12 hours.
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        /// <summary>
        /// The retention period of the backup data. Unit: day.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

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

        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// Indicates whether the log backup feature is enabled. Valid values:
        /// 
        /// *   **0** (default): The log backup feature is disabled.
        /// *   **1**: The log backup feature is enabled.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        [NameInMap("EnableCrossLogBackup")]
        [Validation(Required=false)]
        public int? EnableCrossLogBackup { get; set; }

        /// <summary>
        /// The retention period of high-frequency backups. Unit: day.
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public string HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// The number of days for which log backups are retained. Valid values: 7 to 730.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

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
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time range during which the backup was created. The time follows the ISO 8601 standard in the *HH:mm*Z-*HH:mm*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
