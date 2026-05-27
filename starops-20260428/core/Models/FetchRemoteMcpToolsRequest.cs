// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class FetchRemoteMcpToolsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("connection")]
        [Validation(Required=false)]
        public FetchRemoteMcpToolsRequestConnection Connection { get; set; }
        public class FetchRemoteMcpToolsRequestConnection : TeaModel {
            [NameInMap("auth")]
            [Validation(Required=false)]
            public FetchRemoteMcpToolsRequestConnectionAuth Auth { get; set; }
            public class FetchRemoteMcpToolsRequestConnectionAuth : TeaModel {
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
            /// <para>This parameter is required.</para>
            /// 
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

        }

        [NameInMap("network")]
        [Validation(Required=false)]
        public FetchRemoteMcpToolsRequestNetwork Network { get; set; }
        public class FetchRemoteMcpToolsRequestNetwork : TeaModel {
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

    }

}
