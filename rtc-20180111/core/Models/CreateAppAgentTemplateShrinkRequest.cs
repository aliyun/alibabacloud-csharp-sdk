// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateAppAgentTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent silence configuration.</para>
        /// </summary>
        [NameInMap("AgentSilenceConfig")]
        [Validation(Required=false)]
        public string AgentSilenceConfigShrink { get; set; }

        /// <summary>
        /// <para>The ambient environment configuration for the agent. If this parameter is not specified, the ambient environment configuration is not used.</para>
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
        /// <para>Specifies whether to enable video understanding. If enabled, the LLM must support multimodal data.</para>
        /// </summary>
        [NameInMap("EnableVideoUnderstanding")]
        [Validation(Required=false)]
        public bool? EnableVideoUnderstanding { get; set; }

        /// <summary>
        /// <para>The greeting message. The maximum length is 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Good morning, my friend!</para>
        /// </summary>
        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>The agent interruption configuration.</para>
        /// </summary>
        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public string InterruptConfigShrink { get; set; }

        /// <summary>
        /// <para>The interruption mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Interruption allowed (default).</description></item>
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
        /// <para>The preferred video stream for the agent to process when visual understanding is enabled. The agent can process only one video stream at a time. When both the camera stream and the screen sharing stream are pushed simultaneously, this parameter specifies the preferred stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The agent preferentially processes the camera stream.</description></item>
        /// <item><description>2: The agent preferentially processes the screen sharing stream.
        /// Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
