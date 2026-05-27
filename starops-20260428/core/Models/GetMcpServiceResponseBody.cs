// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetMcpServiceResponseBody : TeaModel {
        [NameInMap("mcpService")]
        [Validation(Required=false)]
        public GetMcpServiceResponseBodyMcpService McpService { get; set; }
        public class GetMcpServiceResponseBodyMcpService : TeaModel {
            [NameInMap("connection")]
            [Validation(Required=false)]
            public GetMcpServiceResponseBodyMcpServiceConnection Connection { get; set; }
            public class GetMcpServiceResponseBodyMcpServiceConnection : TeaModel {
                [NameInMap("auth")]
                [Validation(Required=false)]
                public GetMcpServiceResponseBodyMcpServiceConnectionAuth Auth { get; set; }
                public class GetMcpServiceResponseBodyMcpServiceConnectionAuth : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;token&quot;:&quot;example-token&quot;}</para>
                    /// </summary>
                    [NameInMap("keyInfo")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> KeyInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bearer</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("transport")]
                [Validation(Required=false)]
                public string Transport { get; set; }

            }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>log-query</para>
            /// </summary>
            [NameInMap("mcpServiceName")]
            [Validation(Required=false)]
            public string McpServiceName { get; set; }

            [NameInMap("network")]
            [Validation(Required=false)]
            public GetMcpServiceResponseBodyMcpServiceNetwork Network { get; set; }
            public class GetMcpServiceResponseBodyMcpServiceNetwork : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0.0.12</para>
                /// </summary>
                [NameInMap("accessIp")]
                [Validation(Required=false)]
                public string AccessIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("accessPort")]
                [Validation(Required=false)]
                public long? AccessPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mcp-xxx</para>
                /// </summary>
                [NameInMap("mcpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-xxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-xxx</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xxx</para>
                /// </summary>
                [NameInMap("vswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;query_logs&quot;}]</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<GetMcpServiceResponseBodyMcpServiceTools> Tools { get; set; }
            public class GetMcpServiceResponseBodyMcpServiceTools : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public Dictionary<string, object> Annotations { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("confirm")]
                [Validation(Required=false)]
                public bool? Confirm { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("execution")]
                [Validation(Required=false)]
                public Dictionary<string, object> Execution { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("icons")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Icons { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;query&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;query&quot;]}</para>
                /// </summary>
                [NameInMap("inputSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> InputSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>query_logs</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;}</para>
                /// </summary>
                [NameInMap("outputSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> OutputSchema { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
