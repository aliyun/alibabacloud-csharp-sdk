// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateMcpShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The address list of the MCP server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://example.com/mcp%22%5D">https://example.com/mcp&quot;]</a></para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public string AddressesShrink { get; set; }

        /// <summary>
        /// <para>The authentication information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;bearer&quot;,&quot;token&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AuthEnabled")]
        [Validation(Required=false)]
        public bool? AuthEnabled { get; set; }

        /// <summary>
        /// <para>The client idempotency token that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The creation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECT_PROXY</para>
        /// </summary>
        [NameInMap("CreateType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>The description of the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an MCP server.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Optional. Fuzzy matches by instance name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTeams</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The AgentTeams instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ins-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Required if Type is set to HTTP_TO_MCP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;:&quot;<a href="https://example.com/swagger.json%22%7D">https://example.com/swagger.json&quot;}</a></para>
        /// </summary>
        [NameInMap("SwaggerConfig")]
        [Validation(Required=false)]
        public string SwaggerConfig { get; set; }

    }

}
