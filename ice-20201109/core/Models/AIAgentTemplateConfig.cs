// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentTemplateConfig : TeaModel {
        /// <summary>
        /// <para>The parameters of the 3D avatar.</para>
        /// </summary>
        [NameInMap("AvatarChat3D")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigAvatarChat3D AvatarChat3D { get; set; }
        public class AIAgentTemplateConfigAvatarChat3D : TeaModel {
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The threshold used to determine the end of a sentence. If the duration of silence exceeds this threshold, the system determines that a sentence ends. Unit: milliseconds. Default value: 400. Valid values: 200 to 1200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>The ID of the avatar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            /// <summary>
            /// <para>The parameters of the application center of Alibaba Cloud Model Studio. For more information about the parameter format, see <a href="https://help.aliyun.com/document_detail/2858132.html">Parameters of the application center of Alibaba Cloud Model Studio</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("CharBreak")]
            [Validation(Required=false)]
            public bool? CharBreak { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the intercom mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent can be interrupted by voice. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent supports graceful shutdown. Default value: false.</para>
            /// <list type="bullet">
            /// <item><description>Graceful shutdown: When the intelligent agent is stopped, it completes its current sentence before stopping. However, the intelligent agent can speak for 10 seconds at most.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greetings spoken by the intelligent agent when it joins the meeting. If you do not specify this parameter, the system uses the default greetings specified in the template of the intelligent agent. The greetings can be up to 128 characters in length.</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigAvatarChat3DLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigAvatarChat3DLlmHistory : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voiceprint recognition. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The timeout period after the user leaves the meeting. Unit: seconds. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period before the user joins the meeting. Unit: seconds. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The voice ID of the intelligent agent. The modification takes effect in the next sentence. If you do not specify this parameter, the system uses the default voice ID specified in the template of the intelligent agent. This parameter takes effect only for the preset TTS model. The ID can be up to 64 characters in length. For more information about the available voices, visit <a href="url">https://help.aliyun.com/zh/ims/developer-reference/smart-voice-effect-example</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID of the voiceprint. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speech volume of the intelligent agent.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is not specified, the adaptive volume mode recommended by Alibaba Cloud is used by default.</description></item>
            /// <item><description>To specify this parameter, enter a value between 0 and 400. The output volume is calculated by using the following formula: Output volume = Voice output volume specified in the workflow × Volume/100. Example:</description></item>
            /// </list>
            /// <ol>
            /// <item><description>If Volume is set to 0, the output volume is 0.</description></item>
            /// <item><description>If Volume is set to 100, the output volume is the voice output volume specified in the workflow.</description></item>
            /// <item><description>If Volume is set to 200, the output volume is twice the voice output volume specified in the workflow.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

        /// <summary>
        /// <para>The parameters of the visual intelligent agent.</para>
        /// </summary>
        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVisionChat VisionChat { get; set; }
        public class AIAgentTemplateConfigVisionChat : TeaModel {
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The threshold used to determine the end of a sentence. If the duration of silence exceeds this threshold, the system determines that a sentence ends. Unit: milliseconds. Default value: 400. Valid values: 200 to 1200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>The parameters of the application center of Alibaba Cloud Model Studio. For more information about the parameter format, see <a href="https://help.aliyun.com/document_detail/2858132.html">Parameters of the application center of Alibaba Cloud Model Studio</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("CharBreak")]
            [Validation(Required=false)]
            public bool? CharBreak { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable intelligent sentence segmentation. This feature intelligently combines the segments of a speech into a single sentence if brief pauses occur when users are speaking. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the intercom mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent can be interrupted by voice. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent supports graceful shutdown. Default value: false.</para>
            /// <para>Graceful shutdown: When the intelligent agent is stopped, it completes its current sentence before stopping. However, the intelligent agent can speak for 10 seconds at most.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greetings spoken by the intelligent agent when it joins the meeting. If you do not specify this parameter, the system uses the default greetings specified in the template of the intelligent agent. The value can be up to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Good morning, my friend!</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVisionChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVisionChatLlmHistory : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voiceprint recognition. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The timeout period after the user leaves the meeting. Unit: seconds. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period before the user joins the meeting. Unit: seconds. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The voice ID of the intelligent agent. The modification takes effect in the next sentence. If you do not specify this parameter, the system uses the default voice ID specified in the template of the intelligent agent. This parameter takes effect only for the preset TTS model. The ID can be up to 64 characters in length. For more information about the available voices, visit <a href="url">https://help.aliyun.com/zh/ims/developer-reference/smart-voice-effect-example</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID of the voiceprint. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speech volume of the intelligent agent.</para>
            /// <para>If this parameter is not specified, the adaptive volume mode recommended by Alibaba Cloud is used by default.</para>
            /// <para>To specify this parameter, enter a value between 0 and 400. The output volume is calculated by using the following formula: Output volume = Voice output volume specified in the workflow × Volume/100. Example:</para>
            /// <para>If Volume is set to 0, the output volume is 0.</para>
            /// <para>If Volume is set to 100, the output volume is the voice output volume specified in the workflow.</para>
            /// <para>If Volume is set to 200, the output volume is twice the voice output volume specified in the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

        /// <summary>
        /// <para>The voice call parameters.</para>
        /// </summary>
        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentTemplateConfigVoiceChat : TeaModel {
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The threshold used to determine the end of a sentence. If the duration of silence exceeds this threshold, the system determines that a sentence ends. Unit: milliseconds. Default value: 400. Valid values: 200 to 1200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com/a.jpg">http://example.com/a.jpg</a></para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("AvatarUrlType")]
            [Validation(Required=false)]
            public string AvatarUrlType { get; set; }

            /// <summary>
            /// <para>The parameters of the application center of Alibaba Cloud Model Studio. For more information about the parameter format, see <a href="https://help.aliyun.com/document_detail/2858132.html">Parameters of the application center of Alibaba Cloud Model Studio</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BailianAppParams")]
            [Validation(Required=false)]
            public string BailianAppParams { get; set; }

            [NameInMap("CharBreak")]
            [Validation(Required=false)]
            public bool? CharBreak { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the intercom mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent can be interrupted by voice. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether the intelligent agent supports graceful shutdown. Default value: false.</para>
            /// <list type="bullet">
            /// <item><description>Graceful shutdown: When the intelligent agent is stopped, it completes its current sentence before stopping. However, the intelligent agent can speak for 10 seconds at most.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greetings spoken by the intelligent agent when it joins the meeting. If you do not specify this parameter, the system uses the default greetings specified in the template of the intelligent agent. The value can be up to 128 characters in length.</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVoiceChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVoiceChatLlmHistory : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voiceprint recognition. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The timeout period after the user leaves the meeting. Unit: seconds. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period before the user joins the meeting. Unit: seconds. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The voice ID of the intelligent agent. The modification takes effect in the next sentence. If you do not specify this parameter, the system uses the default voice ID specified in the template of the intelligent agent. This parameter takes effect only for the preset TTS model. The ID can be up to 64 characters in length. For more information about the available voices, visit <a href="url">https://help.aliyun.com/zh/ims/developer-reference/smart-voice-effect-example</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID of the voiceprint. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speech volume of the intelligent agent.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is not specified, the adaptive volume mode recommended by Alibaba Cloud is used by default.</description></item>
            /// <item><description>To specify this parameter, enter a value between 0 and 400. The output volume is calculated by using the following formula: Output volume = Voice output volume specified in the workflow × Volume/100. Example:</description></item>
            /// </list>
            /// <ol>
            /// <item><description>If Volume is set to 0, the output volume is 0.</description></item>
            /// <item><description>If Volume is set to 100, the output volume is the voice output volume specified in the workflow.</description></item>
            /// <item><description>If Volume is set to 200, the output volume is twice the voice output volume specified in the workflow.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

    }

}
