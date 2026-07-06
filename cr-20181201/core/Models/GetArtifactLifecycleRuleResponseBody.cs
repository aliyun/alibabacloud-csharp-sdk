// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactLifecycleRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies if the rule is executed automatically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571926439000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Specifies if lifecycle management is enabled.</para>
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
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The last modified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638259914000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-namespace</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The timestamp of the next scheduled execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1701878400000</para>
        /// </summary>
        [NameInMap("NextTime")]
        [Validation(Required=false)]
        public long? NextTime { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<GetArtifactLifecycleRuleResponseBodyPolicies> Policies { get; set; }
        public class GetArtifactLifecycleRuleResponseBodyPolicies : TeaModel {
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public GetArtifactLifecycleRuleResponseBodyPoliciesCondition Condition { get; set; }
            public class GetArtifactLifecycleRuleResponseBodyPoliciesCondition : TeaModel {
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
            public GetArtifactLifecycleRuleResponseBodyPoliciesFilter Filter { get; set; }
            public class GetArtifactLifecycleRuleResponseBodyPoliciesFilter : TeaModel {
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
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>724402D0-75CD-4794-BC20-7D37208****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of image versions to retain.</para>
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
        /// <para>cralr-a18bkiajy8****</para>
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
        /// <para>The regular expression that matches image tags to select versions for retention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*-alpine</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
