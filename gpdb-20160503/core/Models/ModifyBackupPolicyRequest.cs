// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The number of days for which data backup files are retained. Default value: 7. Maximum value: 7. Valid values: 1 to 7.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic point-in-time backup.
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("EnableRecoveryPoint")]
        [Validation(Required=false)]
        public bool? EnableRecoveryPoint { get; set; }

        /// <summary>
        /// The cycle based on which backups are performed. If more than one day of the week is specified, the days of the week are separated by commas (,). Valid values:
        /// 
        /// *   Monday
        /// *   Tuesday
        /// *   Wednesday
        /// *   Thursday
        /// *   Friday
        /// *   Saturday
        /// *   Sunday
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The backup window. Specify the backup window in the HH:mmZ-HH:mmZ format. The backup window must be in UTC. Default value: 00:00-01:00.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The frequency of point-in-time backup.
        /// 
        /// *   1: per hour
        /// *   2: per 2 hours
        /// *   4: per 4 hours
        /// *   8: per 8 hours
        /// 
        /// Default value: 8.
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

    }

}
