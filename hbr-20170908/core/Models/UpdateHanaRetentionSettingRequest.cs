// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaRetentionSettingRequest : TeaModel {
        /// <summary>
        /// The ID of the SAP HANA instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Specifies whether to permanently retain the backup. Valid values:
        /// 
        /// *   true: The backup is permanently retained.
        /// *   false: The backup is retained for the specified number of days.
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The number of days for which the backup is retained. If you set the Disabled parameter to false, the backup is retained for the number of days specified by this parameter.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public long? RetentionDays { get; set; }

        /// <summary>
        /// The policy to update the retention period. Format: `I|{startTime}|{interval}`. The retention period is updated at an interval of {interval} starting from {startTime}.
        /// 
        /// *   startTime: the time at which the system starts to update the retention period. The time must follow the UNIX time format. Unit: seconds.
        /// *   interval: the interval at which the system updates the retention period. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of 1 hour and P1D specifies an interval of one day.
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
