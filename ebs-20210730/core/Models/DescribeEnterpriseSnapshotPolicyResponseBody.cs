// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEnterpriseSnapshotPolicyResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeEnterpriseSnapshotPolicyResponseBodyPolicies> Policies { get; set; }
        public class DescribeEnterpriseSnapshotPolicyResponseBodyPolicies : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CrossRegionCopyInfo")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions> Regions { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RetainDays")]
                    [Validation(Required=false)]
                    public int? RetainDays { get; set; }

                }

            }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("ManagedForEcs")]
            [Validation(Required=false)]
            public bool? ManagedForEcs { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// the resource group
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("RetainRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule RetainRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule : TeaModel {
                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule Schedule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule : TeaModel {
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

            }

            [NameInMap("SpecialRetainRules")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules SpecialRetainRules { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules> Rules { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules : TeaModel {
                    [NameInMap("SpecialPeriodUnit")]
                    [Validation(Required=false)]
                    public string SpecialPeriodUnit { get; set; }

                    [NameInMap("TimeInterval")]
                    [Validation(Required=false)]
                    public int? TimeInterval { get; set; }

                    [NameInMap("TimeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("StorageRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule StorageRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule : TeaModel {
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
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("TargetCount")]
            [Validation(Required=false)]
            public int? TargetCount { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
