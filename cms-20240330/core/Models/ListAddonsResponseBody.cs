// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsResponseBody : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>resume_vector_alias</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyAddonsDashboards : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rum_view_link_rum_api</para>
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
            /// <para>workspace api monitor test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyAddonsEnvironments : TeaModel {
                [NameInMap("commonSchemaRefs")]
                [Validation(Required=false)]
                public List<ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>acs-ecs</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1.4</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsDependencies : TeaModel {
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsPolicies : TeaModel {
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
                    public ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        [NameInMap("promQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

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
                    public List<ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Support OpenTelemetry Protocal</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                        /// </summary>
                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>OpenTelemetry</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>openTelemetry</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud-acs-ecs</para>
                    /// </summary>
                    [NameInMap("targetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS</para>
                /// </summary>
                [NameInMap("policyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
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
            /// <para>rum_api_dashboard_explorer_link_metric_set</para>
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
            /// <para>middleware</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
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
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
