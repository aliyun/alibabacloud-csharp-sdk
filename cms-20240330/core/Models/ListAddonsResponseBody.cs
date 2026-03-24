// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of available add-ons.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The alias of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resume_vector_alias</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>A list of tags for the add-on.</para>
            /// </summary>
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>A list of dashboards.</para>
            /// </summary>
            [NameInMap("dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyAddonsDashboards : TeaModel {
                /// <summary>
                /// <para>Dashboard description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Dashboard name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rum_view_link_rum_api</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The URL of the dashboard\&quot;s preview image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace api monitor test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>A list of supported integration policy types.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyAddonsEnvironments : TeaModel {
                /// <summary>
                /// <para>A list of associated Common Schemas.</para>
                /// </summary>
                [NameInMap("commonSchemaRefs")]
                [Validation(Required=false)]
                public List<ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs : TeaModel {
                    /// <summary>
                    /// <para>The group name of the Common Schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs-ecs</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <para>The version of the Common Schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1.4</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>A list of dependencies for the add-on.</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// <para>Supported cluster types.</para>
                    /// </summary>
                    [NameInMap("clusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    /// <summary>
                    /// <para>The probes on which the integration depends.</para>
                    /// </summary>
                    [NameInMap("features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// <para>A list of dependent services.</para>
                    /// </summary>
                    [NameInMap("services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// <para>The description of the integration policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>o11y-demo-cn-heyuan</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the add-on is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The label of the integration policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>容器环境</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The name of the integration policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Integration policy configuration.</para>
                /// </summary>
                [NameInMap("policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <para>The default status of the alert rule policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("alertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the add-on is installed by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to assign a Service Account to communicate with the Console API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    /// <summary>
                    /// <para>Metric check rule.</para>
                    /// </summary>
                    [NameInMap("metricCheckRule")]
                    [Validation(Required=false)]
                    public ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// <para>A list of Prometheus Query Language (PromQL) statements.</para>
                        /// </summary>
                        [NameInMap("promQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether to guide the user to restart pods after the add-on is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("needRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    /// <summary>
                    /// <para>The supported protocol types.</para>
                    /// </summary>
                    [NameInMap("protocols")]
                    [Validation(Required=false)]
                    public List<ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <para>Protocol description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Support OpenTelemetry Protocal</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Icon URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                        /// </summary>
                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// <para>Protocol display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OpenTelemetry</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>Protocol name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openTelemetry</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the target add-on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud-acs-ecs</para>
                    /// </summary>
                    [NameInMap("targetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

                /// <summary>
                /// <para>Integration Center policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS</para>
                /// </summary>
                [NameInMap("policyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <para>The URL of the icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>A list of keywords.</para>
            /// </summary>
            [NameInMap("keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>Language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time when the latest version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-03T03:15:56Z</para>
            /// </summary>
            [NameInMap("latestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rum_api_dashboard_explorer_link_metric_set</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the add-on can be installed only once.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// <para>The scenario of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>middleware</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The display weight of the add-on.</para>
            /// 
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
