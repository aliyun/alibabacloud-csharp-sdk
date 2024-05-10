// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyUniBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the database account.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The policy for full backup. The value of this parameter is a JSON string that contains the following fields:
        /// 
        /// *   **start**: the start time of a backup task
        /// *   **interval**: the interval of backup tasks
        /// *   **type**: the unit of the interval
        /// *   **days**: the days of a week on which a backup task is performed
        /// </summary>
        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> FullPlan { get; set; }

        /// <summary>
        /// The policy for incremental backup. The value of this parameter is a JSON string that contains the following fields:
        /// 
        /// *   **start**: the start time of a backup task
        /// *   **interval**: the interval of backup tasks
        /// *   **type**: the unit of the interval
        /// *   **days**: the days of a week on which a backup task is performed
        /// </summary>
        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> IncPlan { get; set; }

        /// <summary>
        /// The ID of the anti-ransomware policy.
        /// 
        /// > You can call the [DescribeUniBackupPolicies](~~DescribeUniBackupPolicies~~) operation to query the IDs of anti-ransomware policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// The name of the anti-ransomware policy.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The status of the anti-ransomware policy. Valid values:
        /// 
        /// *   **enabled**
        /// *   **disabled**
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// The retention period of the backup snapshot.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// The maximum network bandwidth that is allowed during data backup. Unit: bytes.
        /// </summary>
        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

    }

}
