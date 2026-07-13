// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListProtectionPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProtectionPoliciesResponseBodyData Data { get; set; }
        public class ListProtectionPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response parameters.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListProtectionPoliciesResponseBodyDataContent> Content { get; set; }
            public class ListProtectionPoliciesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The attached resource category IDs.</para>
                /// </summary>
                [NameInMap("BoundResourceCategoryIds")]
                [Validation(Required=false)]
                public List<string> BoundResourceCategoryIds { get; set; }

                /// <summary>
                /// <para>The summary of the latest application result.</para>
                /// </summary>
                [NameInMap("LatestApplySummary")]
                [Validation(Required=false)]
                public ListProtectionPoliciesResponseBodyDataContentLatestApplySummary LatestApplySummary { get; set; }
                public class ListProtectionPoliciesResponseBodyDataContentLatestApplySummary : TeaModel {
                    /// <summary>
                    /// <para>The count statistics of application status.</para>
                    /// </summary>
                    [NameInMap("ApplyStatusCount")]
                    [Validation(Required=false)]
                    public List<ListProtectionPoliciesResponseBodyDataContentLatestApplySummaryApplyStatusCount> ApplyStatusCount { get; set; }
                    public class ListProtectionPoliciesResponseBodyDataContentLatestApplySummaryApplyStatusCount : TeaModel {
                        /// <summary>
                        /// <para>The application status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FAILED</para>
                        /// </summary>
                        [NameInMap("ApplyStatus")]
                        [Validation(Required=false)]
                        public string ApplyStatus { get; set; }

                        /// <summary>
                        /// <para>The count of resources by type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                    }

                    /// <summary>
                    /// <para>The time when the task was completed. Unix timestamp format, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1742167218</para>
                    /// </summary>
                    [NameInMap("CompleteTime")]
                    [Validation(Required=false)]
                    public long? CompleteTime { get; set; }

                    /// <summary>
                    /// <para>The count of resources by type.</para>
                    /// </summary>
                    [NameInMap("ResourceCount")]
                    [Validation(Required=false)]
                    public List<ListProtectionPoliciesResponseBodyDataContentLatestApplySummaryResourceCount> ResourceCount { get; set; }
                    public class ListProtectionPoliciesResponseBodyDataContentLatestApplySummaryResourceCount : TeaModel {
                        /// <summary>
                        /// <para>The count of resources by type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>The resource type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::OTS::Instance</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the policy was last applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1742167218</para>
                /// </summary>
                [NameInMap("LatestApplyTime")]
                [Validation(Required=false)]
                public long? LatestApplyTime { get; set; }

                /// <summary>
                /// <para>The task ID of the latest policy application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-123***7890</para>
                /// </summary>
                [NameInMap("LatestTaskId")]
                [Validation(Required=false)]
                public string LatestTaskId { get; set; }

                /// <summary>
                /// <para>The protection policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p-123***7890</para>
                /// </summary>
                [NameInMap("ProtectionPolicyId")]
                [Validation(Required=false)]
                public string ProtectionPolicyId { get; set; }

                /// <summary>
                /// <para>The protection policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyProtectionPolicy</para>
                /// </summary>
                [NameInMap("ProtectionPolicyName")]
                [Validation(Required=false)]
                public string ProtectionPolicyName { get; set; }

                /// <summary>
                /// <para>The region ID of the protection policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("ProtectionPolicyRegionId")]
                [Validation(Required=false)]
                public string ProtectionPolicyRegionId { get; set; }

                /// <summary>
                /// <para>The sub-protection policies.</para>
                /// </summary>
                [NameInMap("SubProtectionPolicies")]
                [Validation(Required=false)]
                public List<ListProtectionPoliciesResponseBodyDataContentSubProtectionPolicies> SubProtectionPolicies { get; set; }
                public class ListProtectionPoliciesResponseBodyDataContentSubProtectionPolicies : TeaModel {
                    /// <summary>
                    /// <para>The sub-protection policy configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;autoSnapshotPolicyId\&quot;:\&quot;sp-123***7890\&quot;}</para>
                    /// </summary>
                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    /// <summary>
                    /// <para>The sub-protection policy type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECS_AUTO_SNAPSHOT_POLICY</para>
                    /// </summary>
                    [NameInMap("SubProtectionPolicyType")]
                    [Validation(Required=false)]
                    public string SubProtectionPolicyType { get; set; }

                }

            }

            /// <summary>
            /// <para>The maximum number of results requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The paging token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAOTzWWYAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM4NzA3NTcwMzY2MjMwNzY2ODcyMzAzMTY2Nzg3ODY5MzY=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B2F09BF-CEBD-5A7E-AC01-E7F86169A5E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
