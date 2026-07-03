// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SyncMCPServersRequest : TeaModel {
        /// <summary>
        /// <para>The domain name IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtg***</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The list of Nacos MCP Servers to sync. If the list contains MCP Servers that have already been synced, include the mcpServerId.</para>
        /// </summary>
        [NameInMap("nacosMcpServers")]
        [Validation(Required=false)]
        public List<SyncMCPServersRequestNacosMcpServers> NacosMcpServers { get; set; }
        public class SyncMCPServersRequestNacosMcpServers : TeaModel {
            /// <summary>
            /// <para>The exposed URI path. This parameter is required when protocol is SSE or StreamableHTTP and type is RealMCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sse</para>
            /// </summary>
            [NameInMap("exposedUriPath")]
            [Validation(Required=false)]
            public string ExposedUriPath { get; set; }

            /// <summary>
            /// <para>The Nacos instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-24afmoioxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>MCP Server ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-d3s8qo6m1hknegofa3bg</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The MCP Server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The protocols.</para>
            /// </summary>
            [NameInMap("protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

        }

        /// <summary>
        /// <para>The Nacos namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src-d40mff6m1hkpt84vep60</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
