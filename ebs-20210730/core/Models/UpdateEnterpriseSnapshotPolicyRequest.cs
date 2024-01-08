// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Snapshot replication destination information.
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
            /// <summary>
            /// Whether cross-region replication is enabled. The range of values:
            /// 
            /// - true
            /// 
            /// - false
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// Destination region information.
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// The region ID. You can call the [DescribeRegions](~~354276~~) operation to query the most recent list of regions in which async replication is supported.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Number of days to retain the destination snapshot. The range of values is greater than 1.
                /// </summary>
                [NameInMap("RetainDays")]
                [Validation(Required=false)]
                public int? RetainDays { get; set; }

            }

        }

        /// <summary>
        /// The description of the policy.
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The id of the policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The region ID . You can call the [DescribeRegions](~~354276~~) operation to query the most recent list of regions in which snapshot policy is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Snapshot retention rule.
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
            /// <summary>
            /// Maximum number of retained snapshots.
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// The time interval , valid value greater than 1.
            /// </summary>
            [NameInMap("TimeInterval")]
            [Validation(Required=false)]
            public int? TimeInterval { get; set; }

            /// <summary>
            /// The unit of time, valid values:
            /// 
            /// - DAYS
            /// - WEEKS
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        /// <summary>
        /// The rule for scheduling.
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// The time when the policy will to be scheduled. Valid values: Set the parameter in a cron expression.
            /// 
            /// For example, you can use `0 0 4 1/1 * ?` to specify 04:00:00 (UTC+8) on the first day of each month.
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

        }

        /// <summary>
        /// The special snapshot retention rules.
        /// </summary>
        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            /// <summary>
            /// Indicates whether the special retention is enabled.
            /// 
            /// *   true: enable
            /// *   false: disable
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The special retention rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// The periodic unit for specially retained snapshots. If configured to WEEKS, it provides special retention for the first snapshot of each week. The retention period is determined by TimeUnit and TimeInterval. The range of values are:
                /// - WEEKS
                /// - MONTHS
                /// - YEARS"
                /// </summary>
                [NameInMap("SpecialPeriodUnit")]
                [Validation(Required=false)]
                public string SpecialPeriodUnit { get; set; }

                /// <summary>
                /// Retention Time Value. The range of values is greater than 1.
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// Retention time unit for special snapshots. The range of values:
                /// 
                /// - DAYS
                /// 
                /// - WEEKS
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

        }

        /// <summary>
        /// The status of the policy. Valid values:
        /// 
        /// *   **ENABLED**: Enable snapshot policy execution.
        /// *   **DISABLED**: Disable snapshot policy execution.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Advanced snapshot features.
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
            /// <summary>
            /// Whether to enable the rapid availability of snapshots. The range of values:
            /// 
            /// - true
            /// 
            /// - false
            /// </summary>
            [NameInMap("EnableImmediateAccess")]
            [Validation(Required=false)]
            public bool? EnableImmediateAccess { get; set; }

        }

    }

}
