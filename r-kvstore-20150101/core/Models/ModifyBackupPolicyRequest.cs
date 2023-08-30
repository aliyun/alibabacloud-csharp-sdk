// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// Enables or disables the data flashback feature for the instance. Valid values:
        /// 
        /// *   **1**: enables the data flashback feature. Before you can use data flashback, you must make sure that AOF persistence is enabled for the instance (`appendonly` set to `yes`).
        /// *   **0** (default): disables the data flashback feature.
        /// 
        /// > This parameter is available only for Tair DRAM-based and persistent memory-optimized instances. For more information, see [Data flashback](~~443784~~).
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// The ID of the instance.
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
        /// *   **Monday**: every Monday
        /// *   **Tuesday**: every Tuesday
        /// *   **Wednesday**: every Wednesday
        /// *   **Thursday**: every Thursday
        /// *   **Friday**: every Friday
        /// *   **Saturday**: every Saturday
        /// *   **Sunday**: every Sunday
        /// 
        /// >  Separate multiple options with commas (,).
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time range to back up data. Specify the time in the ISO 8601 standard in the *HH:mm*Z-*HH:mm*Z format. The time must be in UTC.
        /// 
        /// >  The beginning and end of the time range must be on the hour. The duration must be an hour.
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
