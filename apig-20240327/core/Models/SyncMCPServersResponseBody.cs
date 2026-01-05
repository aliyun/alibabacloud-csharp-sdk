// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SyncMCPServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SyncMCPServersResponseBodyData Data { get; set; }
        public class SyncMCPServersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP servers that failed to synchronize.</para>
            /// </summary>
            [NameInMap("failedMcpServers")]
            [Validation(Required=false)]
            public List<SyncMCPServersResponseBodyDataFailedMcpServers> FailedMcpServers { get; set; }
            public class SyncMCPServersResponseBodyDataFailedMcpServers : TeaModel {
                /// <summary>
                /// <para>The name of the MCP server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-fail</para>
                /// </summary>
                [NameInMap("mcpServerName")]
                [Validation(Required=false)]
                public string McpServerName { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// </summary>
                [NameInMap("protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

            }

            /// <summary>
            /// <para>The list of MCP servers successfully synchronized.</para>
            /// </summary>
            [NameInMap("succeedMcpServers")]
            [Validation(Required=false)]
            public List<SyncMCPServersResponseBodyDataSucceedMcpServers> SucceedMcpServers { get; set; }
            public class SyncMCPServersResponseBodyDataSucceedMcpServers : TeaModel {
                /// <summary>
                /// <para>The name of the MCP server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-success</para>
                /// </summary>
                [NameInMap("mcpServerName")]
                [Validation(Required=false)]
                public string McpServerName { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// </summary>
                [NameInMap("protocols")]
                [Validation(Required=false)]
                public List<string> Protocols { get; set; }

            }

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
        /// <para>2F46B9E7-67EF-5C8A-BA52-D38D5B32AF2C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
