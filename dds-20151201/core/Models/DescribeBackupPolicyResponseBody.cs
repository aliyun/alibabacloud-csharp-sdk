// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
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
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        /// <summary>
        /// The retention period of backups. Unit: days.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Indicates whether log backup is enabled. Default value: 0. Valid values:
        /// 
        /// *   **0**: disables log backup.
        /// *   **1**: enables log backup.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// The number of days for which to retain log backups. Valid values: 7 to 730.
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
        /// The time range to back up data. The time is in the *HH:mm*Z-*HH:mm*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
