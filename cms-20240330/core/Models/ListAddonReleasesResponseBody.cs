// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonReleasesResponseBody : TeaModel {
        [NameInMap("releases")]
        [Validation(Required=false)]
        public List<ListAddonReleasesResponseBodyReleases> Releases { get; set; }
        public class ListAddonReleasesResponseBodyReleases : TeaModel {
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

            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<ListAddonReleasesResponseBodyReleasesConditions> Conditions { get; set; }
            public class ListAddonReleasesResponseBodyReleasesConditions : TeaModel {
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
                /// <para>True</para>
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
            /// <para>2024-11-04T16:10:12+08:00</para>
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
            /// <para>policy-xxxxxxxxxxxx</para>
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
            /// <para>175xxxxxxxxx</para>
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

            [NameInMap("nextVersion")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-xxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("parentAddonReleaseId")]
            [Validation(Required=false)]
            public string ParentAddonReleaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-xxxxxxxxxxxxxx</para>
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
            /// <para>Release ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>7339d808-66f9-4d40-83fa-xxxxxxxxxxx</para>
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
            /// <para>container</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subAddonRelease")]
            [Validation(Required=false)]
            public ListAddonReleasesResponseBodyReleasesSubAddonRelease SubAddonRelease { get; set; }
            public class ListAddonReleasesResponseBodyReleasesSubAddonRelease : TeaModel {
                [NameInMap("ready")]
                [Validation(Required=false)]
                public int? Ready { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-04T16:10:23+08:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>175xxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.2</para>
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
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
