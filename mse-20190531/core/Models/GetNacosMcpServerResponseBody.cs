// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetNacosMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNacosMcpServerResponseBodyData Data { get; set; }
        public class GetNacosMcpServerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>All version information of the current MCP server.</para>
            /// </summary>
            [NameInMap("AllVersions")]
            [Validation(Required=false)]
            public List<GetNacosMcpServerResponseBodyDataAllVersions> AllVersions { get; set; }
            public class GetNacosMcpServerResponseBodyDataAllVersions : TeaModel {
                /// <summary>
                /// <para>Indicates whether it is the latest version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Is_latest")]
                [Validation(Required=false)]
                public bool? IsLatest { get; set; }

                /// <summary>
                /// <para>The release date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16</para>
                /// </summary>
                [NameInMap("Release_date")]
                [Validation(Required=false)]
                public string ReleaseDate { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.9</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The backend service endpoints.</para>
            /// </summary>
            [NameInMap("BackendEndpoints")]
            [Validation(Required=false)]
            public List<GetNacosMcpServerResponseBodyDataBackendEndpoints> BackendEndpoints { get; set; }
            public class GetNacosMcpServerResponseBodyDataBackendEndpoints : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/sse</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The capabilities of the current MCP server.</para>
            /// </summary>
            [NameInMap("Capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the gateway is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The exposed protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-sse</para>
            /// </summary>
            [NameInMap("FrontProtocol")]
            [Validation(Required=false)]
            public string FrontProtocol { get; set; }

            /// <summary>
            /// <para>The ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5e3c5211-d365-4013-8540-c4106ec2a5dc</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The local MCP server configuration.</para>
            /// </summary>
            [NameInMap("LocalServerConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> LocalServerConfig { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-sse</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The remote server configuration.</para>
            /// </summary>
            [NameInMap("RemoteServerConfig")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataRemoteServerConfig RemoteServerConfig { get; set; }
            public class GetNacosMcpServerResponseBodyDataRemoteServerConfig : TeaModel {
                /// <summary>
                /// <para>The exposed path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/sse</para>
                /// </summary>
                [NameInMap("ExportPath")]
                [Validation(Required=false)]
                public string ExportPath { get; set; }

                /// <summary>
                /// <para>The service reference.</para>
                /// </summary>
                [NameInMap("ServiceRef")]
                [Validation(Required=false)]
                public GetNacosMcpServerResponseBodyDataRemoteServerConfigServiceRef ServiceRef { get; set; }
                public class GetNacosMcpServerResponseBodyDataRemoteServerConfigServiceRef : TeaModel {
                    /// <summary>
                    /// <para>The group to which the service belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEFAULT</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The namespace ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("NamespaceId")]
                    [Validation(Required=false)]
                    public string NamespaceId { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-service</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }

            /// <summary>
            /// <para>The tool specification.</para>
            /// </summary>
            [NameInMap("ToolSpec")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataToolSpec ToolSpec { get; set; }
            public class GetNacosMcpServerResponseBodyDataToolSpec : TeaModel {
                /// <summary>
                /// <para>The list of security authentication schemes in the MCP tool definition.</para>
                /// </summary>
                [NameInMap("SecuritySchemes")]
                [Validation(Required=false)]
                public object SecuritySchemes { get; set; }

                /// <summary>
                /// <para>The storage format type of the MCP tool definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cipher-kms-256</para>
                /// </summary>
                [NameInMap("SpecificationType")]
                [Validation(Required=false)]
                public string SpecificationType { get; set; }

                /// <summary>
                /// <para>The decryption result status of the MCP tool definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ToolDecryptStatus")]
                [Validation(Required=false)]
                public string ToolDecryptStatus { get; set; }

                /// <summary>
                /// <para>The list of tools.</para>
                /// </summary>
                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<GetNacosMcpServerResponseBodyDataToolSpecTools> Tools { get; set; }
                public class GetNacosMcpServerResponseBodyDataToolSpecTools : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a weather query tool</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The input schema of the tool.</para>
                    /// </summary>
                    [NameInMap("InputSchema")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> InputSchema { get; set; }

                    /// <summary>
                    /// <para>The tool name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The tool metadata map.</para>
                /// </summary>
                [NameInMap("ToolsMeta")]
                [Validation(Required=false)]
                public Dictionary<string, DataToolSpecToolsMetaValue> ToolsMeta { get; set; }

            }

            /// <summary>
            /// <para>The version details.</para>
            /// </summary>
            [NameInMap("VersionDetail")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataVersionDetail VersionDetail { get; set; }
            public class GetNacosMcpServerResponseBodyDataVersionDetail : TeaModel {
                /// <summary>
                /// <para>Indicates whether it is the latest version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsLatest")]
                [Validation(Required=false)]
                public bool? IsLatest { get; set; }

                /// <summary>
                /// <para>The release date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-16</para>
                /// </summary>
                [NameInMap("ReleaseDate")]
                [Validation(Required=false)]
                public string ReleaseDate { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.11.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The YAML configuration of the AI gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allowTools:</para>
            /// <list type="bullet">
            /// <item><description>demo-tool
            /// securityScheme: {}
            /// server:
            /// name: mcp-demo
            /// tools:</description></item>
            /// <item><description>args:<list type="bullet">
            /// <item><description>name: name
            /// description: name
            /// type: string
            /// description: a demo tool
            /// name: demo-tool</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("YamlConfig")]
            [Validation(Required=false)]
            public string YamlConfig { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72FC625E-9629-591B-9C01-3F0BFDAB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
