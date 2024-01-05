// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2Request : TeaModel {
        /// <summary>
        /// The description of the backup policy.
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// The name of the backup policy.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The rules in the backup policy.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreatePolicyV2RequestRules> Rules { get; set; }
        public class CreatePolicyV2RequestRules : TeaModel {
            /// <summary>
            /// This parameter is required only if you set the **RuleType** parameter to **BACKUP**. This parameter specifies the backup type. Valid value: **COMPLETE**, which indicates full backup.
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// Specifies whether to enable the feature of keeping at least one backup version. Valid values:
            /// 
            /// *   0: The feature is disabled.
            /// *   1: The feature is enabled.
            /// </summary>
            [NameInMap("KeepLatestSnapshots")]
            [Validation(Required=false)]
            public long? KeepLatestSnapshots { get; set; }

            /// <summary>
            /// This parameter is required only if you set the **RuleType** parameter to **REPLICATION**. This parameter specifies the ID of the destination region.
            /// </summary>
            [NameInMap("ReplicationRegionId")]
            [Validation(Required=false)]
            public string ReplicationRegionId { get; set; }

            /// <summary>
            /// This parameter is required only if you set the **RuleType** parameter to **TRANSITION** or **REPLICATION**.
            /// 
            /// *   If the **RuleType** parameter is set to **TRANSITION**, this parameter specifies the retention period of the backup data. Minimum value: 1. Maximum value: 364635. Unit: days.
            /// *   If the **RuleType** parameter is set to **REPLICATION**, this parameter specifies the retention period of remote backups. Minimum value: 1. Maximum value: 364635. Unit: days.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// This parameter is required only if you set the **RuleType** parameter to **TRANSITION**. This parameter specifies the special retention rules.
            /// </summary>
            [NameInMap("RetentionRules")]
            [Validation(Required=false)]
            public List<CreatePolicyV2RequestRulesRetentionRules> RetentionRules { get; set; }
            public class CreatePolicyV2RequestRulesRetentionRules : TeaModel {
                /// <summary>
                /// The type of the special retention rule. Valid values:
                /// 
                /// *   **WEEKLY**: weekly backups
                /// *   **MONTHLY**: monthly backups
                /// *   **YEARLY**: yearly backups
                /// </summary>
                [NameInMap("AdvancedRetentionType")]
                [Validation(Required=false)]
                public string AdvancedRetentionType { get; set; }

                /// <summary>
                /// The retention period of the backup data. Minimum value: 1. Unit: days.
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// Specifies which backup is retained based on the special retention rule. Only the first backup can be retained.
                /// </summary>
                [NameInMap("WhichSnapshot")]
                [Validation(Required=false)]
                public long? WhichSnapshot { get; set; }

            }

            /// <summary>
            /// The type of the rule. Each backup policy must have at least one rule of the **BACKUP** type and only one rule of the **TRANSITION** type.
            /// 
            /// *   **BACKUP**: backup rule
            /// *   **TRANSITION**: lifecycle rule
            /// *   **REPLICATION**: replication rule
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// This parameter is required only if you set the **RuleType** parameter to **BACKUP**. This parameter specifies the backup schedule settings. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, `I|1631685600|P1D` specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
            /// 
            /// *   startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.
            /// *   interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

    }

}
