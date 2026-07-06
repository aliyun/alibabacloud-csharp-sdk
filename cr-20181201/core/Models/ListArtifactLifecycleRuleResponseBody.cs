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
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
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
        /// <para>The number of entries returned on each page.</para>
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
        /// <para>The list of lifecycle management rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListArtifactLifecycleRuleResponseBodyRules> Rules { get; set; }
        public class ListArtifactLifecycleRuleResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>Indicates whether the rule runs automatically.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <para>The creation time of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638187989000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is configured to delete tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDeleteTag")]
            [Validation(Required=false)]
            public bool? EnableDeleteTag { get; set; }

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
            /// <para>The last modification time of the rule.</para>
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
            /// <para>The next execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1638187989000</para>
            /// </summary>
            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListArtifactLifecycleRuleResponseBodyRulesPolicies> Policies { get; set; }
            public class ListArtifactLifecycleRuleResponseBodyRulesPolicies : TeaModel {
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public ListArtifactLifecycleRuleResponseBodyRulesPoliciesCondition Condition { get; set; }
                public class ListArtifactLifecycleRuleResponseBodyRulesPoliciesCondition : TeaModel {
                    [NameInMap("LastPullOlderThanDays")]
                    [Validation(Required=false)]
                    public int? LastPullOlderThanDays { get; set; }

                    [NameInMap("LastPushOlderThanDays")]
                    [Validation(Required=false)]
                    public int? LastPushOlderThanDays { get; set; }

                    [NameInMap("LatestTagCount")]
                    [Validation(Required=false)]
                    public int? LatestTagCount { get; set; }

                }

                [NameInMap("Filter")]
                [Validation(Required=false)]
                public ListArtifactLifecycleRuleResponseBodyRulesPoliciesFilter Filter { get; set; }
                public class ListArtifactLifecycleRuleResponseBodyRulesPoliciesFilter : TeaModel {
                    [NameInMap("TagWildcard")]
                    [Validation(Required=false)]
                    public string TagWildcard { get; set; }

                }

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
            /// <para>The number of image tags to retain.</para>
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
            /// <para>The execution schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEEK</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The scope of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The regular expression that matches image tags to retain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.*-alpine</para>
            /// </summary>
            [NameInMap("TagRegexp")]
            [Validation(Required=false)]
            public string TagRegexp { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
