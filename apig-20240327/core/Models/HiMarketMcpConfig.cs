// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketMcpConfig : TeaModel {
        /// <summary>
        /// <para>The MCP Server configuration.</para>
        /// </summary>
        [NameInMap("mcpServerConfig")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMcpServerConfig McpServerConfig { get; set; }
        public class HiMarketMcpConfigMcpServerConfig : TeaModel {
            /// <summary>
            /// <para>The list of associated domain names.</para>
            /// </summary>
            [NameInMap("domains")]
            [Validation(Required=false)]
            public List<HiMarketDomain> Domains { get; set; }

            /// <summary>
            /// <para>The path exposed by the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mcp</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The MCP Server name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-server</para>
        /// </summary>
        [NameInMap("mcpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMeta Meta { get; set; }
        public class HiMarketMcpConfigMeta : TeaModel {
            /// <summary>
            /// <para>The MCP protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StreamableHTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The MCP tool definitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;search\&quot;,\&quot;description\&quot;:\&quot;搜索工具\&quot;}]</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public string Tools { get; set; }

    }

}
