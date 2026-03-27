// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAddonResponseBodyData Data { get; set; }
        public class GetAddonResponseBodyData : TeaModel {
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
            public List<GetAddonResponseBodyDataDashboards> Dashboards { get; set; }
            public class GetAddonResponseBodyDataDashboards : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rum_api_dot_metric_set</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://iac-service-transfer.oss-cn-hangzhou.aliyuncs.com/78c5_288850010070719968_bdcf7cca781844c8ac4add133791713f">http://iac-service-transfer.oss-cn-hangzhou.aliyuncs.com/78c5_288850010070719968_bdcf7cca781844c8ac4add133791713f</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>o11y-demo-cn-heyuan</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<GetAddonResponseBodyDataEnvironments> Environments { get; set; }
            public class GetAddonResponseBodyDataEnvironments : TeaModel {
                [NameInMap("commonSchemaRefs")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyDataEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsCommonSchemaRefs : TeaModel {
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public GetAddonResponseBodyDataEnvironmentsDependencies Dependencies { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsDependencies : TeaModel {
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
                /// <para>Observability integration.</para>
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
                /// <para>cs-default-umodel-1752755202744_k8s.metric.high_level_metric_deployment_cn-hangzhou/c0a686118449c4390b9cc0a07ea3e0e85</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("policies")]
                [Validation(Required=false)]
                public GetAddonResponseBodyDataEnvironmentsPolicies Policies { get; set; }
                public class GetAddonResponseBodyDataEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
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
                    public GetAddonResponseBodyDataEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class GetAddonResponseBodyDataEnvironmentsPoliciesMetricCheckRule : TeaModel {
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
                    public List<GetAddonResponseBodyDataEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class GetAddonResponseBodyDataEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Prometheus Metrics</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>icon URL</para>
                        /// </summary>
                        [NameInMap("icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>rum_api_dot_metric_set</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cs-default</para>
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
            /// <para>icon URL</para>
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
            /// <para>2023-09-12 12:30:30</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
