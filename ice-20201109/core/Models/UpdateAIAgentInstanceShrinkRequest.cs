// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateAIAgentInstanceShrinkRequest : TeaModel {
        [NameInMap("AgentConfig")]
        [Validation(Required=false)]
        public string AgentConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the AI agent that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The template configurations of the AI agent. The configurations are merged with the template configurations that are used to start the AI agent. For more information, see the definition of TemplateConfig.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public string TemplateConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;VoiceId&quot;:&quot;xiaoxia&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
