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
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyData> Data { get; set; }
        public class ListAddonsResponseBodyData : TeaModel {
            /// <summary>
            /// Ailas of the Addon.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// Categories list.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// Dashboard list.
            /// </summary>
            [NameInMap("Dashboards")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataDashboards> Dashboards { get; set; }
            public class ListAddonsResponseBodyDataDashboards : TeaModel {
                /// <summary>
                /// Description of the dashboard.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Name of the dashboard.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// URL of the dashboard.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// Description of the Addon.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Environment list.
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListAddonsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// Dependency list.
                /// </summary>
                [NameInMap("Dependencies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsDependencies Dependencies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsDependencies : TeaModel {
                    /// <summary>
                    /// Name of the Feature.
                    /// </summary>
                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Features { get; set; }

                    /// <summary>
                    /// Service list.
                    /// </summary>
                    [NameInMap("Services")]
                    [Validation(Required=false)]
                    public List<string> Services { get; set; }

                }

                /// <summary>
                /// Description of environment.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Whether to enable it.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// Label of the environment.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// Name of the environment.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Policies list.
                /// </summary>
                [NameInMap("Policies")]
                [Validation(Required=false)]
                public ListAddonsResponseBodyDataEnvironmentsPolicies Policies { get; set; }
                public class ListAddonsResponseBodyDataEnvironmentsPolicies : TeaModel {
                    /// <summary>
                    /// Default alert status.
                    /// </summary>
                    [NameInMap("AlertDefaultStatus")]
                    [Validation(Required=false)]
                    public string AlertDefaultStatus { get; set; }

                    /// <summary>
                    /// Default install status.
                    /// </summary>
                    [NameInMap("DefaultInstall")]
                    [Validation(Required=false)]
                    public bool? DefaultInstall { get; set; }

                    /// <summary>
                    /// Whether to enable a service account.
                    /// </summary>
                    [NameInMap("EnableServiceAccount")]
                    [Validation(Required=false)]
                    public bool? EnableServiceAccount { get; set; }

                    /// <summary>
                    /// Metric check rule PromQL.
                    /// </summary>
                    [NameInMap("MetricCheckRule")]
                    [Validation(Required=false)]
                    public ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesMetricCheckRule : TeaModel {
                        /// <summary>
                        /// PromQL list.
                        /// </summary>
                        [NameInMap("PromQL")]
                        [Validation(Required=false)]
                        public List<string> PromQL { get; set; }

                    }

                    /// <summary>
                    /// Whether to restart after integration.
                    /// </summary>
                    [NameInMap("NeedRestartAfterIntegration")]
                    [Validation(Required=false)]
                    public bool? NeedRestartAfterIntegration { get; set; }

                    /// <summary>
                    /// Protocol list.
                    /// </summary>
                    [NameInMap("Protocols")]
                    [Validation(Required=false)]
                    public List<ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols> Protocols { get; set; }
                    public class ListAddonsResponseBodyDataEnvironmentsPoliciesProtocols : TeaModel {
                        /// <summary>
                        /// Description of the Protocol.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// Icon address.
                        /// </summary>
                        [NameInMap("Icon")]
                        [Validation(Required=false)]
                        public string Icon { get; set; }

                        /// <summary>
                        /// Label of the Protocol.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// Name of the Protocol.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// Target Addon name.
                    /// </summary>
                    [NameInMap("TargetAddonName")]
                    [Validation(Required=false)]
                    public string TargetAddonName { get; set; }

                }

            }

            /// <summary>
            /// Icon address.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// Keyword list.
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// Language.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// Last installation time.
            /// </summary>
            [NameInMap("LatestReleaseCreateTime")]
            [Validation(Required=false)]
            public string LatestReleaseCreateTime { get; set; }

            /// <summary>
            /// Name of the Addon.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Whether to install it only once.
            /// </summary>
            [NameInMap("Once")]
            [Validation(Required=false)]
            public bool? Once { get; set; }

            /// <summary>
            /// Scene of the Addon.
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// Version of the Addon.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// Weight of the Addon.
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
