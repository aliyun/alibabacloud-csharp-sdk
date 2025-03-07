// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code: 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried add-ons.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyData> Data { get; set; }
        public class ListAddonsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alias of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The tags of the add-on.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The dashboards.</para>
            /// </summary>
            [NameInMap("Dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyDataDashboards : TeaModel {
                /// <summary>
                /// <para>The description of the dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL monitors the market information, monitoring the connection information, usage information and other indicators</para>
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
            /// <para>The description of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Monitor database indicators with MySQL Exporter</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The supported environments.</para>
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// <para>The dependencies of the environment.</para>
                /// </summary>
                [NameInMap("Dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// <para>The supported cluster types.</para>
                    /// </summary>
                    [NameInMap("ClusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    /// <summary>
                    /// <para>The feature on which the environment depends.</para>
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// <para>The services.</para>
                    /// </summary>
                    [NameInMap("Services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// <para>The description of the environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The MySQL service is deployed in a Kubernetes cluster.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The tag of the environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Container</para>
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
                /// <para>The control policies in the environment.</para>
                /// </summary>
                [NameInMap("Policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// <para>The default alert status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("AlertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// <para>The default installation status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DefaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a service account is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false.</para>
                    /// </summary>
                    [NameInMap("EnableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    /// <summary>
                    /// <para>The metric check rule.</para>
                    /// </summary>
                    [NameInMap("MetricCheckRule")]
                    [Validation(Required=false)]
                    public ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// <para>The PromQL statements.</para>
                        /// </summary>
                        [NameInMap("PromQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether a restart is required after the installation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NeedRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    /// <summary>
                    /// <para>The supported protocols.</para>
                    /// </summary>
                    [NameInMap("Protocols")]
                    [Validation(Required=false)]
                    public List<ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols : TeaModel {
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
                        /// <para>The tag of the protocol.</para>
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
                    /// <para>The target name of the add-on.</para>
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
            /// <para>The URL of the icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx">http://xxxx</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The collection of keywords.</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time when the instance was last created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-22T16:56:29+08:00</para>
            /// </summary>
            [NameInMap("LatestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the add-on can be installed only once.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The version of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>857</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the alert rule was deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The alert rule was deleted.</description></item>
        /// <item><description><c>false</c>: The alert rule failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
