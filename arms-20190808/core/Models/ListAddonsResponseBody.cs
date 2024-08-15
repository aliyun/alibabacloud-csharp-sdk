// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// Status code: 200 indicates success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The queried add-ons.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyData> Data { get; set; }
        public class ListAddonsResponseBodyData : TeaModel {
            /// <summary>
            /// The alias of the add-on.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The tags of the add-on.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// The dashboards.
            /// </summary>
            [NameInMap("Dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyDataDashboards : TeaModel {
                /// <summary>
                /// The description of the dashboard.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the dashboard.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The URL of the dashboard.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The description of the add-on.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The supported environments.
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// The dependencies of the environment.
                /// </summary>
                [NameInMap("Dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// Dependency cluster types.
                    /// </summary>
                    [NameInMap("ClusterTypes")]
                    [Validation(Required=false)]
                    public List<string> ClusterTypes { get; set; }

                    /// <summary>
                    /// The feature on which the environment depends.
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// The services.
                    /// </summary>
                    [NameInMap("Services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// The description of the environment.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the feature is enabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The tag of the environment.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The name of the environment.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The control policies in the environment.
                /// </summary>
                [NameInMap("Policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// The default alert status.
                    /// </summary>
                    [NameInMap("AlertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// The default installation status.
                    /// </summary>
                    [NameInMap("DefaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// Indicates whether a service account is enabled.
                    /// </summary>
                    [NameInMap("EnableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    /// <summary>
                    /// The metric check rule.
                    /// </summary>
                    [NameInMap("MetricCheckRule")]
                    [Validation(Required=false)]
                    public ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// The PromQL statements.
                        /// </summary>
                        [NameInMap("PromQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether a restart is required after the installation.
                    /// </summary>
                    [NameInMap("NeedRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    /// <summary>
                    /// The supported protocols.
                    /// </summary>
                    [NameInMap("Protocols")]
                    [Validation(Required=false)]
                    public List<ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// The description of the protocol.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The URL of the protocol icon.
                        /// </summary>
                        [NameInMap("Icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// The tag of the protocol.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The name of the protocol.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The target name of the add-on.
                    /// </summary>
                    [NameInMap("TargetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

            }

            /// <summary>
            /// The URL of the icon.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// The collection of keywords.
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// The language.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The time when the instance was last created.
            /// </summary>
            [NameInMap("LatestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// The name of the add-on.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the add-on can be installed only once.
            /// </summary>
            [NameInMap("Once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// The scenario.
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// The version of the agent.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The weight.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the alert rule was deleted. Valid values:
        /// 
        /// *   `true`: The alert rule was deleted.
        /// *   `false`: The alert rule failed to be deleted.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
