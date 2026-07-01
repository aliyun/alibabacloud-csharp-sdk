// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateAIAgentCallShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The AI agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The agent template configuration. The configuration you provide merges with the agent template configuration in the console. If you omit this parameter, the agent uses the default configuration from the console.</para>
        /// <remarks>
        /// <para>Compatibility with <c>TemplateConfig</c>: Fields in <c>AgentConfig</c> take precedence. If a field is specified in <c>TemplateConfig</c> but not in <c>AgentConfig</c>, the system uses the value from <c>TemplateConfig</c>. We recommend using <c>AgentConfig</c> instead of <c>TemplateConfig</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AgentConfig")]
        [Validation(Required=false)]
        public string AgentConfigShrink { get; set; }

        /// <summary>
        /// <para>The chat synchronization configuration.</para>
        /// </summary>
        [NameInMap("ChatSyncConfig")]
        [Validation(Required=false)]
        public string ChatSyncConfigShrink { get; set; }

        /// <summary>
        /// <para>Optional. The expiration time of the token in seconds. Default value: 3600. Value range: 0 to 604800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>A unique identifier for the session. If not provided, a new session is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fw1gr0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>This configuration merges with the agent template configuration in the console.</para>
        /// </description></item>
        /// <item><description><para>If you omit this parameter, the agent uses the default configuration from the console.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The agent template configuration. This parameter is deprecated. Use the AgentConfig parameter instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public string TemplateConfigShrink { get; set; }

        /// <summary>
        /// <para>User data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The username in the channel. If you do not specify a username, one is automatically generated. The username can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
