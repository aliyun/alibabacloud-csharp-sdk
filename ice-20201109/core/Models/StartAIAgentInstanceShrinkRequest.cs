// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartAIAgentInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID configured in the <a href="https://ims.console.aliyun.com/ai/robot/list">IMS console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The agent template configuration. Values you provide merge with the template configuration set in the console. If you omit this parameter, the agent uses its default configuration from the console.</para>
        /// <remarks>
        /// <para>This field is compatible with TemplateConfig. Fields in AgentConfig take precedence. If TemplateConfig contains fields not defined in AgentConfig, those fields are used. Use AgentConfig instead of TemplateConfig.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AgentConfig")]
        [Validation(Required=false)]
        public string AgentConfigShrink { get; set; }

        /// <summary>
        /// <para>The chat history synchronization configuration.</para>
        /// </summary>
        [NameInMap("ChatSyncConfig")]
        [Validation(Required=false)]
        public string ChatSyncConfigShrink { get; set; }

        /// <summary>
        /// <para>The configuration required for the agent at runtime.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeConfig")]
        [Validation(Required=false)]
        public string RuntimeConfigShrink { get; set; }

        /// <summary>
        /// <para>A unique identifier for the chat session. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f213fbc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The agent template configuration. Values you provide merge with the template configuration set in the console. If you omit this parameter, the agent uses its default configuration from the console.</para>
        /// <remarks>
        /// <para>The agent template configuration. This field is deprecated. See the AgentConfig field.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public string TemplateConfigShrink { get; set; }

        /// <summary>
        /// <para>User-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
