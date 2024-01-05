// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePoliciesV2ResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of results for each query.
        /// 
        /// Valid values: 10 to 100. Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The token that is used to obtain the next page of backup policies.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The backup policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePoliciesV2ResponseBodyPolicies> Policies { get; set; }
        public class DescribePoliciesV2ResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The time when the backup policy was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The number of data sources that are bound to the backup policy.
            /// </summary>
            [NameInMap("PolicyBindingCount")]
            [Validation(Required=false)]
            public long? PolicyBindingCount { get; set; }

            /// <summary>
            /// The description of the backup policy.
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// The ID of the backup policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

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
            public List<DescribePoliciesV2ResponseBodyPoliciesRules> Rules { get; set; }
            public class DescribePoliciesV2ResponseBodyPoliciesRules : TeaModel {
                /// <summary>
                /// This parameter is returned only if the value of the **RuleType** parameter is **BACKUP**. This parameter indicates the backup type. Only **COMPLETE** may be returned, which indicates full backup.
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// Indicates whether the feature of keeping at least one backup version is enabled. Valid values:
                /// 
                /// *   **0**: This feature is disabled.
                /// *   **1**: This feature is enabled.
                /// </summary>
                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                /// <summary>
                /// This parameter is returned only if the value of the **RuleType** parameter is **REPLICATION**. This parameter indicates the ID of the destination region.
                /// </summary>
                [NameInMap("ReplicationRegionId")]
                [Validation(Required=false)]
                public string ReplicationRegionId { get; set; }

                /// <summary>
                /// This parameter is returned only if the value of the **RuleType** parameter is **TRANSITION** or **REPLICATION**.
                /// 
                /// *   If the value of the **RuleType** parameter is **TRANSITION**, this parameter indicates the retention period of the backup data. Minimum value: 1. Unit: days.
                /// *   If the value of the **RuleType** parameter is **REPLICATION**, this parameter indicates the retention period of remote backups. Minimum value: 1. Unit: days.
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// This parameter is returned only if the value of the **RuleType** parameter is **TRANSITION**. This parameter indicates the special retention rules.
                /// </summary>
                [NameInMap("RetentionRules")]
                [Validation(Required=false)]
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules> RetentionRules { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules : TeaModel {
                    /// <summary>
                    /// The type of the special retention rule. Valid values:
                    /// 
                    /// *   **WEEKLY**: weekly backups.
                    /// *   **MONTHLY**: monthly backups.
                    /// *   **YEARLY**: yearly backups.
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
                    /// Indicates which backup is retained based on the special retention rule. Only the first backup can be retained.
                    /// </summary>
                    [NameInMap("WhichSnapshot")]
                    [Validation(Required=false)]
                    public long? WhichSnapshot { get; set; }

                }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The type of the rule. Each backup policy must have at least one rule of the **BACKUP** type and only one rule of the **TRANSITION** type.
                /// 
                /// *   **BACKUP**: the backup rule.
                /// *   **TRANSITION**: the lifecycle rule.
                /// *   **REPLICATION**: the replication rule.
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// This parameter is returned only if the value of the **RuleType** parameter is **BACKUP**. This parameter indicates the scheduling settings for the backups. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, `I|1631685600|P1D` indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
                /// 
                /// *   startTime: the time when the system starts to run a backup job. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// *   interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H indicates an interval of one hour. P1D indicates an interval of one day.
                /// </summary>
                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

            }

            /// <summary>
            /// The time when the backup policy was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
