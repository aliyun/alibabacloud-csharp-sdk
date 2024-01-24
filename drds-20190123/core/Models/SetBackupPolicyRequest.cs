// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The databases to be backed up. Separate multiple databases with commas (,).
        /// 
        /// >  This parameter takes effect only when the backup level is database level.
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// The level of the backup. Valid values:
        /// 
        /// *   db: The database type.
        /// *   instance: instance
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// Specifies whether to enable log Backup. Valid values:
        /// 
        /// *   1: enabled.
        /// *   0: disabled.
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// The backup mode. Valid values:
        /// 
        /// *   **Logic **: logical backup
        /// *   **phy**: physical backup
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// The retention period of the backup data. Value range: 7 to 730.
        /// </summary>
        [NameInMap("DataBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The log retention period. Valid values: 7 to 730. This value must be less than or equal to the number of data backup days.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The end time of the backup.
        /// </summary>
        [NameInMap("PreferredBackupEndTime")]
        [Validation(Required=false)]
        public string PreferredBackupEndTime { get; set; }

        /// <summary>
        /// The backup cycle. Valid values:
        /// 
        /// *   0: Monday
        /// *   1: Tuesday
        /// *   2: Wednesday
        /// *   3: Thursday
        /// *   4: Friday
        /// *   5: Saturday
        /// *   6: Sunday
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The start time of the backup.
        /// </summary>
        [NameInMap("PreferredBackupStartTime")]
        [Validation(Required=false)]
        public string PreferredBackupStartTime { get; set; }

    }

}
