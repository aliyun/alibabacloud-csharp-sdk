// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The retention period for the backup data. Valid values: 7 to 730. Unit: day.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The day of a week when the system regularly backs up data. If you specify multiple days of a week, separate them with commas (,). Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The backup window. Specify the time in the ISO 8601 standard in the HH:mmZ-HH:mmZ format. The time must be in Coordinated Universal Time (UTC).
        /// 
        /// For example, if you set the backup window to 00:00Z-01:00Z, the data of the cluster can be backed up from 08:00 (UTC+8) to 09:00 (UTC+8).
        /// 
        /// This parameter is required.
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

    }

}
