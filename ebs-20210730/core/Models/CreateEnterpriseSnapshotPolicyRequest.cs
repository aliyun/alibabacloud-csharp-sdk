// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Snapshot replication destination information.
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
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
            /// The list of destination regions.
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// The region ID of the destination. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The region ID . You can call the [DescribeRegions](~~354276~~) operation to query the most recent list of regions in which snapshot policy is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the snapshot policy.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The snapshot retention rule.
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
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
            /// 
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
        public CreateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// The time when the policy will to be scheduled. Valid values: Set the parameter in a cron expression.
            /// 
            /// For example, you can use 0 0 4 1/1 * ? to specify 04:00:00 (UTC+8) on the first day of each month.
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
        public CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
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
            public List<CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// The periodic unit for specially retained snapshots. If configured to WEEKS, it provides special retention for the first snapshot of each week. The retention period is determined by TimeUnit and TimeInterval. The range of values are:
                /// - WEEKS
                /// - MONTHS
                /// - YEARS
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
        /// - ENABLED: Enable snapshot policy execution.
        /// 
        /// - DISABLED: Disable snapshot policy execution.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Advanced snapshot features.
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
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

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEnterpriseSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Binding target type, valid value:
        /// 
        /// - DISK
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
