// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The created MCP Server.</para>
        /// </summary>
        [NameInMap("McpServer")]
        [Validation(Required=false)]
        public CreateMcpServerResponseBodyMcpServer McpServer { get; set; }
        public class CreateMcpServerResponseBodyMcpServer : TeaModel {
            /// <summary>
            /// <para>The time when the MCP Server was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The name of the MCP Server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>valueA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
