// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateMcpServerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The connection configuration of the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Transport&quot;:&quot;SSE&quot;,&quot;Url&quot;:&quot;<a href="https://example.com/mcp/sse%22,%22CustomHeaders%22:%7B%7D%7D">https://example.com/mcp/sse&quot;,&quot;CustomHeaders&quot;:{}}</a></para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

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
        public string VisibilityScopeShrink { get; set; }

    }

}
