// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class FetchRemoteMcpToolsRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("connection")]
        [Validation(Required=false)]
        public FetchRemoteMcpToolsRequestConnection Connection { get; set; }
        public class FetchRemoteMcpToolsRequestConnection : TeaModel {
            /// <summary>
            /// <para>The request body parameters.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public FetchRemoteMcpToolsRequestConnectionAuth Auth { get; set; }
            public class FetchRemoteMcpToolsRequestConnectionAuth : TeaModel {
                /// <summary>
                /// <para>The request body parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;token&quot;:&quot;example-token&quot;}</para>
                /// </summary>
                [NameInMap("keyInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> KeyInfo { get; set; }

                /// <summary>
                /// <para>The authentication type. Currently, only bearer is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bearer</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The access endpoint of the MCP service.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>The MCP service platform type. Valid values: AIGateway and Custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The timeout period for requests to the MCP service. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>The transport protocol of the MCP service. Valid values: http and sse.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

        }

        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public FetchRemoteMcpToolsRequestNetwork Network { get; set; }
        public class FetchRemoteMcpToolsRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The IP address used to access the MCP service over the VPC network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.12</para>
            /// </summary>
            [NameInMap("accessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <para>The port used to access the MCP service over the VPC network. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("accessPort")]
            [Validation(Required=false)]
            public long? AccessPort { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-xxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The MCP Server instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-xxx</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The network access mode of the MCP service. Valid values: public and vpc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The region where the VPC network resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

        }

    }

}
