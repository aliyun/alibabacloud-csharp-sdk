// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateMcpServerRequest : TeaModel {
        /// <summary>
        /// <para>The connection configuration of the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Transport&quot;:&quot;SSE&quot;,&quot;Url&quot;:&quot;<a href="https://example.com/mcp/sse%22,%22CustomHeaders%22:%7B%7D%7D">https://example.com/mcp/sse&quot;,&quot;CustomHeaders&quot;:{}}</a></para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public CreateMcpServerRequestConfig Config { get; set; }
        public class CreateMcpServerRequestConfig : TeaModel {
            /// <summary>
            /// <para>The custom request headers in key-value pairs. Reserved headers cannot be overwritten.</para>
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
            /// <para>The service URL of the MCP server. It must start with <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The name of the MCP server. The name must be unique at the tenant level. It must start with a lowercase letter and can contain only lowercase letters, digits, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-server</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The visibility level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. Specify the corresponding field based on the value of Visibility.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateMcpServerRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateMcpServerRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The IDs of the projects in which the MCP server is visible. This parameter takes effect only when Visibility is set to <c>PROJECT</c>.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the users who can see the MCP server. This parameter takes effect only when Visibility is set to <c>USER</c>.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
