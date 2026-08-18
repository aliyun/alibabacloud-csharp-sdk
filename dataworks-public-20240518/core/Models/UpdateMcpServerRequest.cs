// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The new custom request headers (key-value pairs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomHeaders { get; set; }

        /// <summary>
        /// <para>The name of the MCP Server to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-server</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new transport protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSE</para>
        /// </summary>
        [NameInMap("Transport")]
        [Validation(Required=false)]
        public string Transport { get; set; }

        /// <summary>
        /// <para>The new service URL. The URL must start with <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The new visibility level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The new visibility scope. Provide the corresponding field based on the Visibility setting.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public UpdateMcpServerRequestVisibilityScope VisibilityScope { get; set; }
        public class UpdateMcpServerRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The list of visible project IDs. This parameter takes effect only when Visibility is set to <c>PROJECT</c>.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The list of visible user IDs. This parameter takes effect only when Visibility is set to <c>USER</c>.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
