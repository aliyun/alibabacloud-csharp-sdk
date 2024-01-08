// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEnterpriseSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The list of policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeEnterpriseSnapshotPolicyResponseBodyPolicies> Policies { get; set; }
        public class DescribeEnterpriseSnapshotPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// Creation Time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Snapshot replication destination information.
            /// </summary>
            [NameInMap("CrossRegionCopyInfo")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo : TeaModel {
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
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions> Regions { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions : TeaModel {
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

            [NameInMap("DiskIds")]
            [Validation(Required=false)]
            public List<string> DiskIds { get; set; }

            /// <summary>
            /// Indicates whether it is an ECS snapshot policy，The range of values:
            /// 
            /// - true
            /// - false
            /// </summary>
            [NameInMap("ManagedForEcs")]
            [Validation(Required=false)]
            public bool? ManagedForEcs { get; set; }

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
            /// The resource group
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The snapshot retention rule.
            /// </summary>
            [NameInMap("RetainRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule RetainRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule : TeaModel {
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
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule Schedule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule : TeaModel {
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
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules SpecialRetainRules { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules : TeaModel {
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
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules> Rules { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules : TeaModel {
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
            /// - ENABLED: Enable policy execution.
            /// 
            /// - DISABLED: Disable policy execution.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Advanced snapshot features.
            /// </summary>
            [NameInMap("StorageRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule StorageRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule : TeaModel {
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
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags> Tags { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags : TeaModel {
                /// <summary>
                /// The key of a tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of a tag.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// Number of bound targets.
            /// </summary>
            [NameInMap("TargetCount")]
            [Validation(Required=false)]
            public int? TargetCount { get; set; }

            /// <summary>
            /// The target type.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
