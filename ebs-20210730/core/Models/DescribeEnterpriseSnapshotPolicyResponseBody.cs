// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEnterpriseSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The returned snapshot policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeEnterpriseSnapshotPolicyResponseBodyPolicies> Policies { get; set; }
        public class DescribeEnterpriseSnapshotPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The time when the enterprise-level snapshot policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-24T06:03:35Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The replication rule of snapshots in the enterprise-level snapshot policy.</para>
            /// </summary>
            [NameInMap("CrossRegionCopyInfo")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the cross-region replication feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The destination regions that store snapshot copies.</para>
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions> Regions { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The retention period of snapshot copies in the destination region. Unit: day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("RetainDays")]
                    [Validation(Required=false)]
                    public int? RetainDays { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The disks that are associated with the snapshot policy.</para>
            /// </summary>
            [NameInMap("DiskIds")]
            [Validation(Required=false)]
            public List<string> DiskIds { get; set; }

            /// <summary>
            /// <para>Indicates whether snapshots are managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ManagedForEcs")]
            [Validation(Required=false)]
            public bool? ManagedForEcs { get; set; }

            /// <summary>
            /// <para>The name of the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esp-xxx</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>the resource group</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The retention rule of the enterprise-level snapshot policy.</para>
            /// </summary>
            [NameInMap("RetainRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule RetainRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule : TeaModel {
                /// <summary>
                /// <para>The maximum number of snapshots that can be retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The value of the retention period of snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// <para>The unit of the retention period of snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAYS</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            /// <summary>
            /// <para>The scheduling rule of the enterprise-level snapshot policy.</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule Schedule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule : TeaModel {
                /// <summary>
                /// <para>The cron expression of the enterprise-level snapshot policy.</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

            }

            /// <summary>
            /// <para>The special retention rules of the enterprise-level snapshot policy.</para>
            /// </summary>
            [NameInMap("SpecialRetainRules")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules SpecialRetainRules { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules : TeaModel {
                /// <summary>
                /// <para>Indicates whether the special retention period is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The special retention rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules> Rules { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRulesRules : TeaModel {
                    /// <summary>
                    /// <para>The unit of the special retention period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WEEKS</para>
                    /// </summary>
                    [NameInMap("SpecialPeriodUnit")]
                    [Validation(Required=false)]
                    public string SpecialPeriodUnit { get; set; }

                    /// <summary>
                    /// <para>The value of the retention period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimeInterval")]
                    [Validation(Required=false)]
                    public int? TimeInterval { get; set; }

                    /// <summary>
                    /// <para>The unit of the retention period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WEEKS</para>
                    /// </summary>
                    [NameInMap("TimeUnit")]
                    [Validation(Required=false)]
                    public string TimeUnit { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISABLED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The storage rule of snapshots in the enterprise-level snapshot policy.</para>
            /// </summary>
            [NameInMap("StorageRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule StorageRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule : TeaModel {
                /// <summary>
                /// <para>Indicates whether the instant access feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableImmediateAccess")]
                [Validation(Required=false)]
                public bool? EnableImmediateAccess { get; set; }

            }

            /// <summary>
            /// <para>the pair tags</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags> Tags { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag of the enterprise-level snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag of the enterprise-level snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The number of objects that are associated with the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TargetCount")]
            [Validation(Required=false)]
            public int? TargetCount { get; set; }

            /// <summary>
            /// <para>The type of the enterprise-level snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISK</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CA35A83-8D8A-5B67-BAA0-2E124F194DA4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
