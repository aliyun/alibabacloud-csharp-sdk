// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The number of days for which to retain full backup files. Valid values: 7 to 730.
        /// 
        /// >  If you leave this parameter empty, the default value 7 is used.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable real-time log backup. Valid values:
        /// 
        /// *   **Enable**
        /// 
        /// *   **Disable**
        /// 
        /// > If you leave this parameter empty, the default value Enable is used.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// The number of days for which to retain log backup files. Valid values: 7 to 730.
        /// 
        /// >  If you leave this parameter empty, the default value 7 is used.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The days of the week on which to perform full backup. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// >  To ensure data security, we recommend that you specify at least two values.
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The start time of the full backup within a time range. Specify the time range in the HH:mmZ-HH:mmZ format. The time must be in UTC.
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

    }

}
