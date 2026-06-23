// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMcpServerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The new custom request headers, specified as key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeadersShrink { get; set; }

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
        /// <para>The new service address. The address must start with<c>https://</c>.</para>
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
        /// <para>The new visibility scope. The fields in this object depend on the value of the <c>Visibility</c> parameter.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public string VisibilityScopeShrink { get; set; }

    }

}
