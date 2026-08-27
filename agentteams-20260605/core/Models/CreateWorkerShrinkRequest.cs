// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Agent runtime type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwenpaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The Agents configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agents-demo</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public string Agents { get; set; }

        /// <summary>
        /// <para>The list of channel configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public string ChannelsShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-demo</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of credential bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public string CredentialsShrink { get; set; }

        /// <summary>
        /// <para>The deployment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SelfHosted</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The list of team groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public string GroupsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst-demo</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The quota configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("LimitConfig")]
        [Validation(Required=false)]
        public string LimitConfigShrink { get; set; }

        /// <summary>
        /// <para>The list of MCP servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("McpServers")]
        [Validation(Required=false)]
        public string McpServersShrink { get; set; }

        /// <summary>
        /// <para>The model configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string ModelShrink { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker-demo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of skills.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public string SkillsShrink { get; set; }

        /// <summary>
        /// <para>The Soul configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>soul-demo</para>
        /// </summary>
        [NameInMap("Soul")]
        [Validation(Required=false)]
        public string Soul { get; set; }

        /// <summary>
        /// <para>The list of sub-agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Subagents")]
        [Validation(Required=false)]
        public string SubagentsShrink { get; set; }

        /// <summary>
        /// <para>The template configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        /// <summary>
        /// <para>The Worker version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
