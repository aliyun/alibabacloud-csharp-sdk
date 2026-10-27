// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available integration components.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The alias of the integration component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resume_vector_alias</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The list of tags for the integration component.</para>
            /// </summary>
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The list of dashboards.</para>
            /// </summary>
            [NameInMap("dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyAddonsDashboards : TeaModel {
                /// <summary>
                /// <para>The description of the dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rum_view_link_rum_api</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The URL of the dashboard preview image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace api monitor test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of supported integration policy types.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyAddonsEnvironments : TeaModel {
                /// <summary>
                /// <para>The list of associated common schemas.</para>
                /// </summary>
                [NameInMap("commonSchemaRefs")]
                [Validation(Required=false)]
                public List<ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsCommonSchemaRefs : TeaModel {
                    /// <summary>
                    /// <para>The group name of the common schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs-ecs</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <para>The version of the common schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1.4</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The list of dependencies for the integration component.</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// <para>The supported cluster types.</para>
                    /// </summary>
                    [NameInMap("clusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    /// <summary>
                    /// <para>The probes required for integration dependencies.</para>
                    /// </summary>
                    [NameInMap("features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// <para>The list of dependent services.</para>
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
                /// <para>Specifies whether it is enabled.</para>
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
                /// <para>Container environment</para>
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
                /// <para>The integration policy configurations.</para>
                /// </summary>
                [NameInMap("policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyAddonsEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyAddonsEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <para>The enabling status of the default policy for alert rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("alertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to install by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("defaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to assign a service account for communication with the console API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    /// <summary>
                    /// <para>The metric check rule.</para>
                    /// </summary>
                    [NameInMap("metricCheckRule")]
                    [Validation(Required=false)]
                    public ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// <para>The list of PromQL query statements.</para>
                        /// </summary>
                        [NameInMap("promQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to initiate a pod restart guide immediately after the plug-in installation is completed during integration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("needRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    /// <summary>
                    /// <para>The supported protocol types for configuration.</para>
                    /// </summary>
                    [NameInMap("protocols")]
                    [Validation(Required=false)]
                    public List<ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyAddonsEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <para>The protocol description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Support OpenTelemetry Protocal</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The icon URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                        /// </summary>
                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// <para>The display name of the protocol.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OpenTelemetry</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The protocol name.</para>
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
                /// <para>The integration center policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS</para>
                /// </summary>
                [NameInMap("policyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            /// <summary>
            /// <para>The icon URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The list of keywords.</para>
            /// </summary>
            [NameInMap("keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time of the latest release. The time is in ISO 8601 format and includes the UTC identifier or time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-03T03:15:56Z</para>
            /// </summary>
            [NameInMap("latestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the integration component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rum_api_dashboard_explorer_link_metric_set</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether the component can be installed only once.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// <para>The component scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>middleware</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The component version.</para>
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
            /// <para>The display weight of the integration component.</para>
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
