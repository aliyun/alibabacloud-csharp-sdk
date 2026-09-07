// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentAddonsResponseBodyData Data { get; set; }
        public class ListEnvironmentAddonsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of addons.</para>
            /// </summary>
            [NameInMap("Addons")]
            [Validation(Required=false)]
            public List<ListEnvironmentAddonsResponseBodyDataAddons> Addons { get; set; }
            public class ListEnvironmentAddonsResponseBodyDataAddons : TeaModel {
                /// <summary>
                /// <para>The alias of the addon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The list of addon tags.</para>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <para>The list of dashboards.</para>
                /// </summary>
                [NameInMap("Dashboards")]
                [Validation(Required=false)]
                public List<ListEnvironmentAddonsResponseBodyDataAddonsDashboards> Dashboards { get; set; }
                public class ListEnvironmentAddonsResponseBodyDataAddonsDashboards : TeaModel {
                    /// <summary>
                    /// <para>The description of the dashboard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL监控大盘信息,监控了连接信息,使用信息等指标</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the dashboard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql-overview</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The URL of the dashboard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx">http://xxxx</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The description of the addon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通过 MySQL Exporter 监控数据库指标</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of supported environments.</para>
                /// </summary>
                [NameInMap("Environments")]
                [Validation(Required=false)]
                public List<ListEnvironmentAddonsResponseBodyDataAddonsEnvironments> Environments { get; set; }
                public class ListEnvironmentAddonsResponseBodyDataAddonsEnvironments : TeaModel {
                    /// <summary>
                    /// <para>The dependencies of the addon within the environment.</para>
                    /// </summary>
                    [NameInMap("Dependencies")]
                    [Validation(Required=false)]
                    public ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsDependencies Dependencies { get; set; }
                    public class ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsDependencies : TeaModel {
                        /// <summary>
                        /// <para>The required cluster types.</para>
                        /// </summary>
                        [NameInMap("ClusterTypes")]
                        [Validation(Required=false)]
                        public List<string> ClusterTypes { get; set; }

                        /// <summary>
                        /// <para>The features available for installation in the environment.</para>
                        /// </summary>
                        [NameInMap("Features")]
                        [Validation(Required=false)]
                        public Dictionary<string, bool?> Features { get; set; }

                        /// <summary>
                        /// <para>The dependent services.</para>
                        /// </summary>
                        [NameInMap("Services")]
                        [Validation(Required=false)]
                        public List<string> Services { get; set; }

                    }

                    /// <summary>
                    /// <para>The description of the environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL 服务部署在 Kubernetes 集群中。</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the addon is supported in this environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The label of the environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>容器环境</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The name of the environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CS</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The policies related to the addon in this environment.</para>
                    /// </summary>
                    [NameInMap("Policies")]
                    [Validation(Required=false)]
                    public ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPolicies Policies { get; set; }
                    public class ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPolicies : TeaModel {
                        /// <summary>
                        /// <para>The default status of the alert.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("AlertDefaultStatus")]
                        [Validation(Required=false)]
                        public string AlertDefaultStatus { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the addon is installed by default in the environment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("DefaultInstall")]
                        [Validation(Required=false)]
                        public bool? DefaultInstall { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a service account is enabled for the addon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableServiceAccount")]
                        [Validation(Required=false)]
                        public bool? EnableServiceAccount { get; set; }

                        /// <summary>
                        /// <para>The rules for checking metric status.</para>
                        /// </summary>
                        [NameInMap("MetricCheckRule")]
                        [Validation(Required=false)]
                        public ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                        public class ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPoliciesMetricCheckRule : TeaModel {
                            /// <summary>
                            /// <para>The PromQL query statements.</para>
                            /// </summary>
                            [NameInMap("PromQL")]
                            [Validation(Required=false)]
                            public List<string> PromQL { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether a restart is required after the addon is installed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("NeedRestartAfterIntegration")]
                        [Validation(Required=false)]
                        public bool? NeedRestartAfterIntegration { get; set; }

                        /// <summary>
                        /// <para>The list of supported protocols.</para>
                        /// </summary>
                        [NameInMap("Protocols")]
                        [Validation(Required=false)]
                        public List<ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPoliciesProtocols> Protocols { get; set; }
                        public class ListEnvironmentAddonsResponseBodyDataAddonsEnvironmentsPoliciesProtocols : TeaModel {
                            /// <summary>
                            /// <para>The description of the protocol.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ARMS</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The URL of the protocol icon.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://xxxxxxx">http://xxxxxxx</a></para>
                            /// </summary>
                            [NameInMap("Icon")]
                            [Validation(Required=false)]
                            public string Icon { get; set; }

                            /// <summary>
                            /// <para>The label of the protocol.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ARMS</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The name of the protocol.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>arms</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The target name of the addon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cloud-rds-mysql</para>
                        /// </summary>
                        [NameInMap("TargetAddonName")]
                        [Validation(Required=false)]
                        public string TargetAddonName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The URL of the addon icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx">http://xxxx</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The keywords for the addon.</para>
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public List<string> Keywords { get; set; }

                /// <summary>
                /// <para>The language of the addon metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The creation time of the latest release of the addon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-22T16:56:29+08:00</para>
                /// </summary>
                [NameInMap("LatestReleaseCreateTime")]
                [Validation(Required=false)]
                public string LatestReleaseCreateTime { get; set; }

                /// <summary>
                /// <para>The name of the addon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the addon can be installed only once per environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Once")]
                [Validation(Required=false)]
                public bool? Once { get; set; }

                /// <summary>
                /// <para>The application scenario of the addon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>database</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The addon version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The weight of the addon, which is used for sorting in the UI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>857</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the list contains V2 addons.</para>
            /// </summary>
            [NameInMap("ContainsV2Addon")]
            [Validation(Required=false)]
            public bool? ContainsV2Addon { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32940175-181B-4B93-966E-4BB69176****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values are <c>true</c> if the operation succeeded and <c>false</c> if it failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
