// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetNacosMcpServerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNacosMcpServerResponseBodyData Data { get; set; }
        public class GetNacosMcpServerResponseBodyData : TeaModel {
            [NameInMap("AllVersions")]
            [Validation(Required=false)]
            public List<GetNacosMcpServerResponseBodyDataAllVersions> AllVersions { get; set; }
            public class GetNacosMcpServerResponseBodyDataAllVersions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Is_latest")]
                [Validation(Required=false)]
                public bool? IsLatest { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-16</para>
                /// </summary>
                [NameInMap("Release_date")]
                [Validation(Required=false)]
                public string ReleaseDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.9</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("BackendEndpoints")]
            [Validation(Required=false)]
            public List<GetNacosMcpServerResponseBodyDataBackendEndpoints> BackendEndpoints { get; set; }
            public class GetNacosMcpServerResponseBodyDataBackendEndpoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/sse</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("Capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mcp-sse</para>
            /// </summary>
            [NameInMap("FrontProtocol")]
            [Validation(Required=false)]
            public string FrontProtocol { get; set; }

            /// <summary>
            /// <para>ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5e3c5211-d365-4013-8540-c4106ec2a5dc</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LocalServerConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> LocalServerConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mcp-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mcp-sse</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RemoteServerConfig")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataRemoteServerConfig RemoteServerConfig { get; set; }
            public class GetNacosMcpServerResponseBodyDataRemoteServerConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/sse</para>
                /// </summary>
                [NameInMap("ExportPath")]
                [Validation(Required=false)]
                public string ExportPath { get; set; }

                [NameInMap("ServiceRef")]
                [Validation(Required=false)]
                public GetNacosMcpServerResponseBodyDataRemoteServerConfigServiceRef ServiceRef { get; set; }
                public class GetNacosMcpServerResponseBodyDataRemoteServerConfigServiceRef : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DEFAULT</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("NamespaceId")]
                    [Validation(Required=false)]
                    public string NamespaceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mcp-service</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }

            [NameInMap("ToolSpec")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataToolSpec ToolSpec { get; set; }
            public class GetNacosMcpServerResponseBodyDataToolSpec : TeaModel {
                [NameInMap("SecuritySchemes")]
                [Validation(Required=false)]
                public object SecuritySchemes { get; set; }

                [NameInMap("SpecificationType")]
                [Validation(Required=false)]
                public string SpecificationType { get; set; }

                [NameInMap("ToolDecryptStatus")]
                [Validation(Required=false)]
                public string ToolDecryptStatus { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<GetNacosMcpServerResponseBodyDataToolSpecTools> Tools { get; set; }
                public class GetNacosMcpServerResponseBodyDataToolSpecTools : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a weather query tool</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("InputSchema")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> InputSchema { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("ToolsMeta")]
                [Validation(Required=false)]
                public Dictionary<string, DataToolSpecToolsMetaValue> ToolsMeta { get; set; }

            }

            [NameInMap("VersionDetail")]
            [Validation(Required=false)]
            public GetNacosMcpServerResponseBodyDataVersionDetail VersionDetail { get; set; }
            public class GetNacosMcpServerResponseBodyDataVersionDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsLatest")]
                [Validation(Required=false)]
                public bool? IsLatest { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-16</para>
                /// </summary>
                [NameInMap("ReleaseDate")]
                [Validation(Required=false)]
                public string ReleaseDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.11.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>72FC625E-9629-591B-9C01-3F0BFDAB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
