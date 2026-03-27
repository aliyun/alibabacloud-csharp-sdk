// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyAddonsResponseBody : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyAddonsResponseBodyAddons> Addons { get; set; }
        public class ListIntegrationPolicyAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("dashboards")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyAddonsResponseBodyAddonsDashboards> Dashboards { get; set; }
            public class ListIntegrationPolicyAddonsResponseBodyAddonsDashboards : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MySQL Overview</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Observability integration.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyAddonsResponseBodyAddonsEnvironments> Environments { get; set; }
            public class ListIntegrationPolicyAddonsResponseBodyAddonsEnvironments : TeaModel {
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsDependencies Dependencies { get; set; }
                public class ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsDependencies : TeaModel {
                    [NameInMap("clusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    [NameInMap("features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    [NameInMap("services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>o11y-demo-cn-heyuan</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Cloud</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Cloud</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("policies")]
                [Validation(Required=false)]
                public ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPolicies Policies { get; set; }
                public class ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("alertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    [NameInMap("metricCheckRule")]
                    [Validation(Required=false)]
                    public ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        [NameInMap("promQl")]
                        [Validation(Required=false)]
                        public List<string> PromQl { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("needRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    [NameInMap("protocols")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListIntegrationPolicyAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://img.alixxxx">https://img.alixxxx</a></para>
                        /// </summary>
                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Golang</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>golang</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("targetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asert/mysql.svg</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-03T03:15:56Z</para>
            /// </summary>
            [NameInMap("latestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>container</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E00EF90-CEF9-57C9-9AE9-5AA937D37C03</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
