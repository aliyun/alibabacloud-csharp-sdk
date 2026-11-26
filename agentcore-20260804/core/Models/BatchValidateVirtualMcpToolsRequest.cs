// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class BatchValidateVirtualMcpToolsRequest : TeaModel {
        /// <summary>
        /// <para>The batch validation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public BatchValidateVirtualMcpToolsRequestBody Body { get; set; }
        public class BatchValidateVirtualMcpToolsRequestBody : TeaModel {
            /// <summary>
            /// <para>The saved virtual MCP IDs in the current workspace. You can specify 1 to 20 unique IDs. The server validates the IDs based on the saved tool selections, revision numbers, and digest baselines. A single batch can involve up to 10 different source MCPs, and up to 10 sources can be checked concurrently in each round.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("mcpIds")]
            [Validation(Required=false)]
            public List<string> McpIds { get; set; }

        }

    }

}
