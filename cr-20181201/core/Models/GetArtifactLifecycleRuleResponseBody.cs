// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactLifecycleRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic execution is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571926439000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableDeleteUntaggedManifest")]
        [Validation(Required=false)]
        public bool? EnableDeleteUntaggedManifest { get; set; }

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
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed.</para>
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
        /// <para>The last modification time. This value is a UNIX timestamp in milliseconds.</para>
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
        /// <para>The next execution time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1701878400000</para>
        /// </summary>
        [NameInMap("NextTime")]
        [Validation(Required=false)]
        public long? NextTime { get; set; }

        /// <summary>
        /// <para>The list of lifecycle policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<GetArtifactLifecycleRuleResponseBodyPolicies> Policies { get; set; }
        public class GetArtifactLifecycleRuleResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The trigger condition of the lifecycle policy.</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public GetArtifactLifecycleRuleResponseBodyPoliciesCondition Condition { get; set; }
            public class GetArtifactLifecycleRuleResponseBodyPoliciesCondition : TeaModel {
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
            public GetArtifactLifecycleRuleResponseBodyPoliciesFilter Filter { get; set; }
            public class GetArtifactLifecycleRuleResponseBodyPoliciesFilter : TeaModel {
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
        /// <para>The image repository name.</para>
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
        /// <para>The number of images to retain.</para>
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
        /// <para>The regular expression used to match image versions to retain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*-alpine</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
