// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentFeatureResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvironmentFeatureResponseBodyData Data { get; set; }
        public class DescribeEnvironmentFeatureResponseBodyData : TeaModel {
            /// <summary>
            /// The installation information about the feature.
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeature Feature { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeature : TeaModel {
                /// <summary>
                /// The alias of the feature.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The configuration of the feature.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, string> Config { get; set; }

                /// <summary>
                /// The description of the feature.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The environment ID.
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// The URL of the icon.
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// The language.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// The latest version number.
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                /// <summary>
                /// Whether or not it is a managed component.
                /// </summary>
                [NameInMap("Managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// The name of the feature.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The installation status of the agent.
                /// 
                /// *   Installing: The agent is being installed.
                /// *   Success: The agent is installed.
                /// *   Failed: The agent failed to be installed.
                /// *   UnInstall: The agent is uninstalled or has not been installed.
                /// *   Uninstalling: The agent is being uninstalled.
                /// *   UnInstallFailed: The agent failed to be uninstalled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The status of the feature.
            /// </summary>
            [NameInMap("FeatureStatus")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeatureStatus FeatureStatus { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatus : TeaModel {
                /// <summary>
                /// Binded resource ID.
                /// </summary>
                [NameInMap("BindResourceId")]
                [Validation(Required=false)]
                public string BindResourceId { get; set; }

                /// <summary>
                /// The containers of the feature.
                /// </summary>
                [NameInMap("FeatureContainers")]
                [Validation(Required=false)]
                public List<DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers> FeatureContainers { get; set; }
                public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers : TeaModel {
                    /// <summary>
                    /// The container parameters.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// The container image.
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// The container name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// IPs for Pod.
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

                /// <summary>
                /// The Kubernetes resource name of the feature.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The security group ID.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The status of the agent. Valid values:
                /// 
                /// *   Success: The agent is running.
                /// *   Failed: The agent failed to run.
                /// *   Not Found: The agent is not installed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
