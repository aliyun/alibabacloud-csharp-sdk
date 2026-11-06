// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSyncMCPServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSyncMCPServerResponseBodyData Data { get; set; }
        public class ListSyncMCPServerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of domain IDs bound to the Nacos MCP export for this gateway, excluding the default domain name. If not configured, the value is [].</para>
            /// </summary>
            [NameInMap("domainIds")]
            [Validation(Required=false)]
            public List<string> DomainIds { get; set; }

            /// <summary>
            /// <para>The list of synchronized (whitelisted) MCP server names, which are derived from the AllowMcpServers in the MCP Bridge registration configuration. If not configured, the value is [].</para>
            /// </summary>
            [NameInMap("mcpServers")]
            [Validation(Required=false)]
            public List<string> McpServers { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>211B1C7E-DD93-58D3-AA4B-9B392B63258C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
