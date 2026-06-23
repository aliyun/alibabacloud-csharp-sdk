// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The MCP Server configuration.</para>
        /// </summary>
        [NameInMap("McpServer")]
        [Validation(Required=false)]
        public GetMcpServerResponseBodyMcpServer McpServer { get; set; }
        public class GetMcpServerResponseBodyMcpServer : TeaModel {
            /// <summary>
            /// <para>The connection configuration for the MCP Server.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMcpServerResponseBodyMcpServerConfig Config { get; set; }
            public class GetMcpServerResponseBodyMcpServerConfig : TeaModel {
                /// <summary>
                /// <para>The custom headers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("CustomHeaders")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomHeaders { get; set; }

                /// <summary>
                /// <para>The transport protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SSE</para>
                /// </summary>
                [NameInMap("Transport")]
                [Validation(Required=false)]
                public string Transport { get; set; }

                /// <summary>
                /// <para>The service address of the MCP Server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The creation time, provided as a timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The modification time, provided as a timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The modifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <para>The MCP Server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The visibility level. Valid values: TENANT (visible within the account), PROJECT (visible to specified projects), and USER (visible to specified users).</para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
