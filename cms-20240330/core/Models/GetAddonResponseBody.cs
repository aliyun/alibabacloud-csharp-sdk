// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAddonResponseBodyData Data { get; set; }
        public class GetAddonResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alias of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resume_vector_alias</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The list of component categories.</para>
            /// </summary>
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The list of dashboards.</para>
            /// </summary>
            [NameInMap("dashboards")]
            [Validation(Required=false)]
            public List<GetAddonResponseBodyDataDashboards> Dashboards { get; set; }
            public class GetAddonResponseBodyDataDashboards : TeaModel {
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
                /// <para>rum_api_dot_metric_set</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The URL of the preview image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://iac-service-transfer.oss-cn-hangzhou.aliyuncs.com/78c5_288850010070719968_bdcf7cca781844c8ac4add133791713f">http://iac-service-transfer.oss-cn-hangzhou.aliyuncs.com/78c5_288850010070719968_bdcf7cca781844c8ac4add133791713f</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The description of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>o11y-demo-cn-heyuan</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment information.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<GetAddonResponseBodyDataEnvironments> Environments { get; set; }
            public class GetAddonResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// <para>The list of associated common schemas.</para>
                /// </summary>
                [NameInMap("commonSchemaRefs")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyDataEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsCommonSchemaRefs : TeaModel {
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
                    /// <para>0.1.3</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The dependencies.</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public GetAddonResponseBodyDataEnvironmentsDependencies Dependencies { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// <para>The dependencies on cluster types.</para>
                    /// </summary>
                    [NameInMap("clusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    /// <summary>
                    /// <para>The dependencies on probes.</para>
                    /// </summary>
                    [NameInMap("features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// <para>The dependencies on activated services.</para>
                    /// </summary>
                    [NameInMap("services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Observability integration.</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The display name of the environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>容器环境</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The name of the add-on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-default-umodel-1752755202744_k8s.metric.high_level_metric_deployment_cn-hangzhou/c0a686118449c4390b9cc0a07ea3e0e85</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// </summary>
                [NameInMap("policies")]
                [Validation(Required=false)]
                public GetAddonResponseBodyDataEnvironmentsPolicies Policies { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <para>The status of the default policy for alert rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
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
                    /// <para>Indicates whether a service account is assigned for communication with the console API.</para>
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
                    public GetAddonResponseBodyDataEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class GetAddonResponseBodyDataEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// <para>The data check rule that is used after installation.</para>
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
                    /// <para>The protocol.</para>
                    /// </summary>
                    [NameInMap("protocols")]
                    [Validation(Required=false)]
                    public List<GetAddonResponseBodyDataEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class GetAddonResponseBodyDataEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <para>The description of the protocol.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Support OpenTelemetry Protocol</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The URL of the icon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>icon URL</para>
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
                        /// <para>The name of the protocol.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OpenTelemetry</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the target add-on to which the system redirects.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-default</para>
                    /// </summary>
                    [NameInMap("targetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

                /// <summary>
                /// <para>The type of the integration policy.</para>
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
            /// <para><a href="https://xxxxx">https://xxxxx</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The keywords.</para>
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
            /// <para>The time when the latest version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-12 12:30:30</para>
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
            /// <para>The weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
