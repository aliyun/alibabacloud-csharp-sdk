// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketMcpConfig : TeaModel {
        /// <summary>
        /// <para>Configuration for the MCP server.</para>
        /// </summary>
        [NameInMap("mcpServerConfig")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMcpServerConfig McpServerConfig { get; set; }
        public class HiMarketMcpConfigMcpServerConfig : TeaModel {
            /// <summary>
            /// <para>The domains managed by the server.</para>
            /// </summary>
            [NameInMap("domains")]
            [Validation(Required=false)]
            public List<HiMarketDomain> Domains { get; set; }

            /// <summary>
            /// <para>The base path for the service endpoint.</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>A unique name for the MCP server.</para>
        /// </summary>
        [NameInMap("mcpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        /// <summary>
        /// <para>Metadata for the configuration.</para>
        /// </summary>
        [NameInMap("meta")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMeta Meta { get; set; }
        public class HiMarketMcpConfigMeta : TeaModel {
            /// <summary>
            /// <para>The communication protocol. Can be <c>http</c> or <c>https</c>.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The tools associated with this configuration, typically provided as a JSON-formatted string.</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public string Tools { get; set; }

    }

}
