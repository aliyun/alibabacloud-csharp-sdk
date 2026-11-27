// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppAgentTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent silence configuration.</para>
        /// </summary>
        [NameInMap("AgentSilenceConfig")]
        [Validation(Required=false)]
        public string AgentSilenceConfigShrink { get; set; }

        /// <summary>
        /// <para>The agent ambient environment configuration. If this parameter is not specified, the ambient environment configuration is not used.</para>
        /// </summary>
        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public string AmbientSoundConfigShrink { get; set; }

        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The speech-to-text settings.</para>
        /// </summary>
        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public string AsrConfigShrink { get; set; }

        /// <summary>
        /// <para>The agent backchannel configuration.</para>
        /// </summary>
        [NameInMap("BackChannelConfig")]
        [Validation(Required=false)]
        public string BackChannelConfigShrink { get; set; }

        /// <summary>
        /// <para>The conversation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Natural conversation mode (default).</description></item>
        /// <item><description>2: Walkie-talkie mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChatMode")]
        [Validation(Required=false)]
        public int? ChatMode { get; set; }

        /// <summary>
        /// <para>If enabled, the LLM must support multimodal data.</para>
        /// </summary>
        [NameInMap("EnableVideoUnderstanding")]
        [Validation(Required=false)]
        public bool? EnableVideoUnderstanding { get; set; }

        /// <summary>
        /// <para>The greeting message. The maximum length is 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Good morning, my friend</para>
        /// </summary>
        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231231312312131231</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The agent interruption configuration.</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public string InterruptConfigShrink { get; set; }

        /// <summary>
        /// <para>The interruption mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Interruption supported (default).</description></item>
        /// <item><description>2: Interruption disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InterruptMode")]
        [Validation(Required=false)]
        public int? InterruptMode { get; set; }

        /// <summary>
        /// <para>The large language model settings.</para>
        /// </summary>
        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public string LlmConfigShrink { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The preferred video stream for the agent to understand after visual understanding is enabled. The agent can understand only one video stream. When both the camera stream and the screen sharing stream are pushed:</para>
        /// <para>1 - The agent prioritizes understanding the camera stream.</para>
        /// <para>2 - The agent prioritizes understanding the screen sharing stream.</para>
        /// <para>By default, the agent prioritizes understanding the camera stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PreferVideo")]
        [Validation(Required=false)]
        public int? PreferVideo { get; set; }

        /// <summary>
        /// <para>The text-to-speech settings.</para>
        /// </summary>
        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public string TtsConfigShrink { get; set; }

        /// <summary>
        /// <para>The agent type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Voice call (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
