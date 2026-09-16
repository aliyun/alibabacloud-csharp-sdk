// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListArtifactLifecycleRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F92D82F9-A4C4-5A4A-97B9-E495BF1B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListArtifactLifecycleRuleResponseBodyRules> Rules { get; set; }
        public class ListArtifactLifecycleRuleResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>Indicates whether the rule is automatically executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638187989000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether DryRun mode is enabled. When DryRun mode is enabled, only lifecycle task scanning is performed and no actual data cleanup is executed. This mode is disabled by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>Indicates whether lifecycle management is enabled.</para>
            /// <para>Only one of this parameter and EnableDeleteUntaggedManifest can be set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDeleteTag")]
            [Validation(Required=false)]
            public bool? EnableDeleteTag { get; set; }

            /// <summary>
            /// <para>Indicates whether artifact cleanup is enabled.</para>
            /// <para>Only one of this parameter and EnableDeleteTag can be set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableDeleteUntaggedManifest")]
            [Validation(Required=false)]
            public bool? EnableDeleteUntaggedManifest { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-brlg4cbj2yl****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678341923385</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-ns</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>The next execution time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638187989000</para>
            /// </summary>
            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            /// <summary>
            /// <para>The list of lifecycle policies.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListArtifactLifecycleRuleResponseBodyRulesPolicies> Policies { get; set; }
            public class ListArtifactLifecycleRuleResponseBodyRulesPolicies : TeaModel {
                /// <summary>
                /// <para>The trigger condition of the lifecycle policy.</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public ListArtifactLifecycleRuleResponseBodyRulesPoliciesCondition Condition { get; set; }
                public class ListArtifactLifecycleRuleResponseBodyRulesPoliciesCondition : TeaModel {
                    /// <summary>
                    /// <para>The number of days since the last pull.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LastPullOlderThanDays")]
                    [Validation(Required=false)]
                    public int? LastPullOlderThanDays { get; set; }

                    /// <summary>
                    /// <para>The number of days since the last push.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LastPushOlderThanDays")]
                    [Validation(Required=false)]
                    public int? LastPushOlderThanDays { get; set; }

                    /// <summary>
                    /// <para>The number of latest image versions to retain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LatestTagCount")]
                    [Validation(Required=false)]
                    public int? LatestTagCount { get; set; }

                }

                /// <summary>
                /// <para>The image version filter condition.</para>
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public ListArtifactLifecycleRuleResponseBodyRulesPoliciesFilter Filter { get; set; }
                public class ListArtifactLifecycleRuleResponseBodyRulesPoliciesFilter : TeaModel {
                    /// <summary>
                    /// <para>The wildcard used to match image versions.</para>
                    /// </summary>
                    [NameInMap("TagWildcard")]
                    [Validation(Required=false)]
                    public string TagWildcard { get; set; }

                }

                /// <summary>
                /// <para>The lifecycle policy type.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_1</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The number of retained images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RetentionTagCount")]
            [Validation(Required=false)]
            public long? RetentionTagCount { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cralr-yqx1q5sir6d****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The execution cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEEK</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The cleanup scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The regular expression for retaining image versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*-alpine</para>
            /// </summary>
            [NameInMap("TagRegexp")]
            [Validation(Required=false)]
            public string TagRegexp { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
