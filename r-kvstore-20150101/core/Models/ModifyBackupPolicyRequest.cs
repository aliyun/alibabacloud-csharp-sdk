// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The number of days for which you want to retain data backup files. Valid values: 7 to 730. Default value: 7.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Enables or disables the data flashback feature for the instance. Valid values:
        /// 
        /// *   **1**: enables the data flashback feature. You must also enable AOF persistence by setting `appendonly` to `yes` in the parameter settings of the instance. Then, you can use the data flashback feature.
        /// *   **0** (default): disables the data flashback feature.
        /// 
        /// >  This parameter is available only for ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based and persistent memory-optimized instances. For more information, see [Data flashback](https://help.aliyun.com/document_detail/443784.html).
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The days of the week to back up data. Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// > Separate multiple options with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time range to back up data. Specify the time in the *HH:mm*Z-*HH:mm*Z format. The time is displayed in UTC.
        /// 
        /// > The beginning and end of the time range must be on the hour. The duration must be an hour.
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
