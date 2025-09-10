// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAddonReleaseResponseBody : TeaModel {
        [NameInMap("release")]
        [Validation(Required=false)]
        public CreateAddonReleaseResponseBodyRelease Release { get; set; }
        public class CreateAddonReleaseResponseBodyRelease : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cs-gpu</para>
            /// </summary>
            [NameInMap("addonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("alertRuleCount")]
            [Validation(Required=false)]
            public long? AlertRuleCount { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<CreateAddonReleaseResponseBodyReleaseConditions> Conditions { get; set; }
            public class CreateAddonReleaseResponseBodyReleaseConditions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-04T16:10:22+08:00</para>
                /// </summary>
                [NameInMap("firstTransitionTime")]
                [Validation(Required=false)]
                public string FirstTransitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-04T16:10:22+08:00</para>
                /// </summary>
                [NameInMap("lastTransitionTime")]
                [Validation(Required=false)]
                public string LastTransitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The addon loaded successfully</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;phase\&quot;: \&quot;Created\&quot;, \&quot;executionDetails\&quot;: [], \&quot;invocations\&quot;: [], \&quot;latestExecError\&quot;: {\&quot;message\&quot;: \&quot;\&quot;, \&quot;code\&quot;: \&quot;\&quot;, \&quot;requestId\&quot;: \&quot;\&quot;, \&quot;extraInfo\&quot;: \&quot;\&quot;, \&quot;title\&quot;: \&quot;\&quot;}}</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Loaded</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;install&quot;:{&quot;mode&quot;:&quot;auto-install&quot;,&quot;listenPort&quot;:&quot;9400&quot;},&quot;discoverMode&quot;:&quot;instances&quot;,&quot;discover&quot;:{&quot;instances&quot;:&quot;worker-k8s-for-cs-c126d87c76218487e83ab322017f11b44&quot;},&quot;scrapeInterval&quot;:&quot;15&quot;,&quot;enableSecuritecs-nodeyGroupInjection&quot;:&quot;true&quot;,&quot;metricTags&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-05T15:21:30+08:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("dashboardCount")]
            [Validation(Required=false)]
            public long? DashboardCount { get; set; }

            [NameInMap("entityRules")]
            [Validation(Required=false)]
            public EntityGroupBase EntityRules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS</para>
            /// </summary>
            [NameInMap("envType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("exporterCount")]
            [Validation(Required=false)]
            public long? ExporterCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("haveConfig")]
            [Validation(Required=false)]
            public bool? HaveConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1654218965xxxxxx</para>
            /// </summary>
            [NameInMap("installUserId")]
            [Validation(Required=false)]
            public string InstallUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("parentAddonReleaseId")]
            [Validation(Required=false)]
            public string ParentAddonReleaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2e898e60-5e6a-46d1-a994-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("releaseId")]
            [Validation(Required=false)]
            public string ReleaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-gpu-integration-name</para>
            /// </summary>
            [NameInMap("releaseName")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-13T02:21:02Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>165421896xxxxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
