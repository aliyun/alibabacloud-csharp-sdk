// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvironmentFeatureResponseBodyData Data { get; set; }
        public class DescribeEnvironmentFeatureResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The installation information about the feature.</para>
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeature Feature { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeature : TeaModel {
                /// <summary>
                /// <para>The alias of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prometheus agent.</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The configuration of the feature.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, string> Config { get; set; }

                /// <summary>
                /// <para>The description of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collect Metric data using the Prometheus collection specification.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-xxxxx</para>
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The URL of the icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxx">http://xxx</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

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
                /// <para>The latest version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.17</para>
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the component is fully managed.</para>
                /// </summary>
                [NameInMap("Managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// <para>The name of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>metric-agent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The installation status of the agent.</para>
                /// <list type="bullet">
                /// <item><description>Installing: The agent is being installed.</description></item>
                /// <item><description>Success: The agent is installed.</description></item>
                /// <item><description>Failed: The agent failed to be installed.</description></item>
                /// <item><description>UnInstall: The agent is uninstalled or has not been installed.</description></item>
                /// <item><description>Uninstalling: The agent is being uninstalled.</description></item>
                /// <item><description>UnInstallFailed: The agent failed to be uninstalled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.17</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The status of the feature.</para>
            /// </summary>
            [NameInMap("FeatureStatus")]
            [Validation(Required=false)]
            public DescribeEnvironmentFeatureResponseBodyDataFeatureStatus FeatureStatus { get; set; }
            public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatus : TeaModel {
                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c013823b55e4b4d6bb6b6f28682bd38a7</para>
                /// </summary>
                [NameInMap("BindResourceId")]
                [Validation(Required=false)]
                public string BindResourceId { get; set; }

                /// <summary>
                /// <para>The containers of the feature.</para>
                /// </summary>
                [NameInMap("FeatureContainers")]
                [Validation(Required=false)]
                public List<DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers> FeatureContainers { get; set; }
                public class DescribeEnvironmentFeatureResponseBodyDataFeatureStatusFeatureContainers : TeaModel {
                    /// <summary>
                    /// <para>The container parameters.</para>
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public List<string> Args { get; set; }

                    /// <summary>
                    /// <para>The container image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-cn-hangzhou-vpc.ack.aliyuncs.com/acs/arms-prometheus-agent:v4.0.0</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The container name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>arms-prometheus-operator</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The IP address of the pod.</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

                /// <summary>
                /// <para>The Kubernetes resource name of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prometheus-ack-arms-prometheus</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms-prom</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1c9fcexoalq9po6cp8</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The status of the agent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success: The agent is running.</description></item>
                /// <item><description>Failed: The agent failed to run.</description></item>
                /// <item><description>Not Found: The agent is not installed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1qt6ict0dbxgv4wer8l</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The feature configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01FF8DD9-A09C-47A1-895A-B6E321BE77B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
