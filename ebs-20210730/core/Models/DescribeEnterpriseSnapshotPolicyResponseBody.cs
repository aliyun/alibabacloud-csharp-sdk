// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEnterpriseSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token (Token) returned for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeEnterpriseSnapshotPolicyResponseBodyPolicies> Policies { get; set; }
        public class DescribeEnterpriseSnapshotPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-24T06:03:35Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The snapshot cross-region copy information.</para>
            /// </summary>
            [NameInMap("CrossRegionCopyInfo")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether cross-region copy is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The destination region information.</para>
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions> Regions { get; set; }
                public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesCrossRegionCopyInfoRegions : TeaModel {
                    /// <summary>
                    /// <para>The snapshot copy destination region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The number of days to retain snapshots at the destination region.</para>
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
            /// <para>The snapshot policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The list of bound cloud disk IDs.</para>
            /// </summary>
            [NameInMap("DiskIds")]
            [Validation(Required=false)]
            public List<string> DiskIds { get; set; }

            /// <summary>
            /// <para>The snapshot managed status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ManagedForEcs")]
            [Validation(Required=false)]
            public bool? ManagedForEcs { get; set; }

            /// <summary>
            /// <para>The snapshot policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The snapshot policy ID.</para>
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
            /// <para>The snapshot policy retention rule.</para>
            /// </summary>
            [NameInMap("RetainRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule RetainRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesRetainRule : TeaModel {
                /// <summary>
                /// <para>The retention count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The time interval of the retention rule. The unit is specified by the TimeUnit parameter. The value must be greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// <para>The retention time unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAYS</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            /// <summary>
            /// <para>The snapshot policy schedule rule.</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule Schedule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSchedule : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

            }

            /// <summary>
            /// <para>The special retention rules for the snapshot policy.</para>
            /// </summary>
            [NameInMap("SpecialRetainRules")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules SpecialRetainRules { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesSpecialRetainRules : TeaModel {
                /// <summary>
                /// <para>Indicates whether special retention is enabled.</para>
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
                    /// <para>The special period unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WEEKS</para>
                    /// </summary>
                    [NameInMap("SpecialPeriodUnit")]
                    [Validation(Required=false)]
                    public string SpecialPeriodUnit { get; set; }

                    /// <summary>
                    /// <para>The time interval of the retention rule. The unit is specified by the TimeUnit parameter. The value must be greater than 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TimeInterval")]
                    [Validation(Required=false)]
                    public int? TimeInterval { get; set; }

                    /// <summary>
                    /// <para>The retention time unit.</para>
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
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DISABLED</description></item>
            /// <item><description>ENABLED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DISABLED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The snapshot policy storage rule.</para>
            /// </summary>
            [NameInMap("StorageRule")]
            [Validation(Required=false)]
            public DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule StorageRule { get; set; }
            public class DescribeEnterpriseSnapshotPolicyResponseBodyPoliciesStorageRule : TeaModel {
                /// <summary>
                /// <para>Indicates whether instant access is enabled for snapshots.</para>
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
                /// <para>The tag key of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The number of bound targets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TargetCount")]
            [Validation(Required=false)]
            public int? TargetCount { get; set; }

            /// <summary>
            /// <para>The type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DISK</description></item>
            /// </list>
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
        /// <para>549BB71F-6778-53CE-AA73-E94ACE802AB4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
