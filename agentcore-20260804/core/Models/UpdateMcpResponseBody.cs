// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMcpResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>For the VIRTUAL type, the update status, revision number, and publish task ID are returned. For a standard MCP, the original empty data response is retained.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateMcpResponseBodyData Data { get; set; }
        public class UpdateMcpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currently applied revision number of the virtual MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appliedRevision")]
            [Validation(Required=false)]
            public long? AppliedRevision { get; set; }

            /// <summary>
            /// <para>The ID of the MCP service updated in this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-server-virtual-1</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The ID of the most recent publish task for the virtual MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-1234567890</para>
            /// </summary>
            [NameInMap("operationTaskId")]
            [Validation(Required=false)]
            public string OperationTaskId { get; set; }

            /// <summary>
            /// <para>The target revision number of the virtual MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The resource status after the update is accepted. The UPDATING status does not indicate that the update has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request processed successfully</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
