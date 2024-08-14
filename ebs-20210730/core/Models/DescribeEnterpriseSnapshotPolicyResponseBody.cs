// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEnterpriseSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
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
        /// The returned snapshot policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeEnterpriseSnapshotPolicyResponseBodyPolicies> Policies { get; set; }
        public class DescribeEnterpriseSnapshotPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The time when the enterprise-level snapshot policy was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The replication rule of snapshots in the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("CrossRegionCopyInfo")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo : TeaModel {
                /// <summary>
                /// Indicates whether the cross-region replication feature is enabled.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The destination regions that store snapshot copies.
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions> Regions { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions : TeaModel {
                    /// <summary>
                    /// The ID of the destination region.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The retention period of snapshot copies in the destination region. Unit: day.
                    /// </summary>
                    [NameInMap("RetainDays")]
                    [Validation(Required=false)]
                    public int? RetainDays { get; set; }

                }

            }

            /// <summary>
            /// The description of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The disks that are associated with the snapshot policy.
            /// </summary>
            [NameInMap("DiskIds")]
            [Validation(Required=false)]
            public List<string> DiskIds { get; set; }

            /// <summary>
            /// Indicates whether snapshots are managed.
            /// </summary>
            [NameInMap("ManagedForEcs")]
            [Validation(Required=false)]
            public bool? ManagedForEcs { get; set; }

            /// <summary>
            /// The name of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// the resource group
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The retention rule of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("RetainRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule RetainRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule : TeaModel {
                /// <summary>
                /// The maximum number of snapshots that can be retained.
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// The value of the retention period of snapshots.
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// The unit of the retention period of snapshots.
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            /// <summary>
            /// The scheduling rule of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule Schedule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule : TeaModel {
                /// <summary>
                /// The cron expression of the enterprise-level snapshot policy.
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

            }

            /// <summary>
            /// The special retention rules of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("SpecialRetainRules")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules SpecialRetainRules { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules : TeaModel {
                /// <summary>
                /// Indicates whether the special retention period is enabled.
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
                    /// The unit of the special retention period.
                    /// </summary>
                    [NameInMap("SpecialPeriodUnit")]
                    [Validation(Required=false)]
                    public string SpecialPeriodUnit { get; set; }

                    /// <summary>
                    /// The value of the retention period.
                    /// </summary>
                    [NameInMap("TimeInterval")]
                    [Validation(Required=false)]
                    public int? TimeInterval { get; set; }

                    /// <summary>
                    /// The unit of the retention period.
                    /// </summary>
                    [NameInMap("TimeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

            /// <summary>
            /// The status of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The storage rule of snapshots in the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("StorageRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule StorageRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule : TeaModel {
                /// <summary>
                /// Indicates whether the instant access feature is enabled.
                /// </summary>
                [NameInMap("EnableImmediateAccess")]
                [Validation(Required=false)]
                public bool? EnableImmediateAccess { get; set; }

            }

            /// <summary>
            /// the pair tags
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags> Tags { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags : TeaModel {
                /// <summary>
                /// The key of the tag of the enterprise-level snapshot policy.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag of the enterprise-level snapshot policy.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The number of objects that are associated with the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("TargetCount")]
            [Validation(Required=false)]
            public int? TargetCount { get; set; }

            /// <summary>
            /// The type of the enterprise-level snapshot policy.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The request ID.
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
