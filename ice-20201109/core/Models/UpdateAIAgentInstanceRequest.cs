// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateAIAgentInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The AI agent configuration to update. This configuration is merged with the existing configuration of the instance. For more information, see the AIAgentConfig definition. The following parameters in AIAgentConfig can be updated:</para>
        /// <list type="bullet">
        /// <item><description><para>VoiceId</para>
        /// </description></item>
        /// <item><description><para>EnableVoiceInterrupt</para>
        /// </description></item>
        /// <item><description><para>Greeting</para>
        /// </description></item>
        /// <item><description><para>Volume</para>
        /// </description></item>
        /// <item><description><para>EnablePushToTalk</para>
        /// </description></item>
        /// <item><description><para>UseVoiceprint</para>
        /// </description></item>
        /// <item><description><para>BailianAppParams</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AgentConfig")]
        [Validation(Required=false)]
        public AIAgentConfig AgentConfig { get; set; }

        /// <summary>
        /// <para>The ID of the AI agent instance.</para>
        /// <remarks>
        /// <para>This unique ID is returned after the AI agent instance starts successfully. For more information about starting an agent, see <a href="https://help.aliyun.com/document_detail/2846201.html">StartAIAgentInstance</a> and <a href="https://help.aliyun.com/document_detail/2846209.html">GenerateAIAgentCall</a>.</para>
        /// </remarks>
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
        /// <remarks>
        /// <para>The AI agent template configuration. This parameter is deprecated. Use the AgentConfig parameter instead.</para>
        /// </remarks>
        /// <para>The AI agent configuration to update. This configuration is merged with the existing configuration of the instance. For more information, see the <a href="https://help.aliyun.com/document_detail/2846193.html">AIAgentTemplateConfig</a> definition.
        /// The following parameters in AIAgentTemplateConfig can be updated:</para>
        /// <list type="bullet">
        /// <item><description><para>VoiceId (Voice ID)</para>
        /// </description></item>
        /// <item><description><para>EnableVoiceInterrupt (Enable voice interruption)</para>
        /// </description></item>
        /// <item><description><para>Greeting (Greeting)</para>
        /// </description></item>
        /// <item><description><para>Volume (Volume)</para>
        /// </description></item>
        /// <item><description><para>EnablePushToTalk (Enable push-to-talk)</para>
        /// </description></item>
        /// <item><description><para>UseVoiceprint (Use voiceprint)</para>
        /// </description></item>
        /// <item><description><para>AsrMaxSilence (ASR maximum silence duration)</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentTemplateConfig TemplateConfig { get; set; }

        /// <summary>
        /// <para>Custom user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VoiceId&quot;:&quot;xiaoxia&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
