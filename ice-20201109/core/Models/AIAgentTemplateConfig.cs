// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentTemplateConfig : TeaModel {
        /// <summary>
        /// <para>3D avatar parameters.</para>
        /// </summary>
        [NameInMap("AvatarChat3D")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigAvatarChat3D AvatarChat3D { get; set; }
        public class AIAgentTemplateConfigAvatarChat3D : TeaModel {
            /// <summary>
            /// <para>A list of hot words to improve ASR accuracy. A maximum of 128 words is supported.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language ID for Automatic Speech Recognition (ASR). Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>zh_mandarin</c>: Chinese</para>
            /// </description></item>
            /// <item><description><para><c>en</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>zh_en</c>: Chinese-English</para>
            /// </description></item>
            /// <item><description><para><c>es</c>: Spanish</para>
            /// </description></item>
            /// <item><description><para><c>jp</c>: Japanese</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_mandarin</para>
            /// </summary>
            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The maximum duration of silence in milliseconds before a sentence break is detected. Range: 200 to 1,200. Default: 400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>The ID of the avatar model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("AvatarId")]
            [Validation(Required=false)]
            public string AvatarId { get; set; }

            /// <summary>
            /// <para>Parameters for Alibaba Cloud Bailian. For details, see <a href="https://help.aliyun.com/document_detail/2858132.html">Bailian App Params</a>.</para>
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
            /// <para>Specifies whether to enable intelligent segmentation. If enabled, this feature intelligently merges pauses in a user\&quot;s speech into a single, complete sentence. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Push-to-Talk mode. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voice interruption. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable graceful shutdown. Default: <c>false</c>.</para>
            /// <list type="bullet">
            /// <item><description>If enabled, the agent finishes its current speech (up to 10 seconds) before stopping.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greeting message delivered when a user joins the session. If this parameter is omitted, the greeting configured in the agent template is used. Maximum length: 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>早上好，我的朋友！</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <para>A list of specific words or phrases that trigger a conversation interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            /// <summary>
            /// <para>The LLM/MLLM conversation history.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigAvatarChat3DLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigAvatarChat3DLlmHistory : TeaModel {
                /// <summary>
                /// <para>The text content of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the conversation participant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>user</c>: The user.</para>
                /// </description></item>
                /// <item><description><para><c>assistant</c>: The AI assistant.</para>
                /// </description></item>
                /// <item><description><para><c>system</c>: The system.</para>
                /// </description></item>
                /// <item><description><para><c>function</c>: A function call.</para>
                /// </description></item>
                /// <item><description><para><c>plugin</c>: A plugin.</para>
                /// </description></item>
                /// <item><description><para><c>tool</c>: A tool.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of conversation turns to retain in the LLM/MLLM history. Default: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM, applied when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位友好且乐于助人的助手，专注于为用户提供准确的信息和建议。</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>The maximum idle time in seconds with no interaction before the agent goes offline. Default: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to use voiceprint recognition. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits after a user leaves before closing the task. Default: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits for a user to join before closing the task. Default: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            /// <summary>
            /// <para>The interruption sensitivity threshold. A higher value makes it more difficult to interrupt the agent. Range: 0 to 11. Default: 11.</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Disables VAD.</para>
            /// </description></item>
            /// <item><description><para><c>1</c> to <c>10</c>: A higher value makes it more difficult to interrupt the agent.</para>
            /// </description></item>
            /// <item><description><para><c>11</c>: Offers lower audio distortion and stronger resistance to interference.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The ID of the Text-to-Speech (TTS) voice. Changes take effect on the next utterance. If omitted, the default voice from the agent template is used. This parameter applies only to preset TTS voices. Maximum length: 64 characters. For available values, see <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent voice effect samples</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>A list of available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID for voiceprint recognition. Default: not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speaking volume of the agent.</para>
            /// <list type="bullet">
            /// <item><description><para>If omitted, the system uses adaptive volume mode.</para>
            /// </description></item>
            /// <item><description><para>If specified, the valid range is 0 to 400. The output volume is calculated as: <c>Output Volume in Workflow</c> \* (<c>volume</c>/100). For example:</para>
            /// </description></item>
            /// </list>
            /// <ol>
            /// <item><description><para>If <c>volume</c> is <c>0</c>, the output is silent.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>100</c>, the output volume is the original volume.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>200</c>, the output volume is twice the original volume.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            /// <summary>
            /// <para>An initial user query that the agent addresses immediately when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>今天天气怎么样？</para>
            /// </summary>
            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <para>Workflow override parameters. Default: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

        /// <summary>
        /// <para>Vision agent parameters.</para>
        /// </summary>
        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVisionChat VisionChat { get; set; }
        public class AIAgentTemplateConfigVisionChat : TeaModel {
            /// <summary>
            /// <para>A list of hot words to improve ASR accuracy. A maximum of 128 words is supported.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language ID for Automatic Speech Recognition (ASR). Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>zh_mandarin</c>: Chinese</para>
            /// </description></item>
            /// <item><description><para><c>en</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>zh_en</c>: Chinese-English</para>
            /// </description></item>
            /// <item><description><para><c>es</c>: Spanish</para>
            /// </description></item>
            /// <item><description><para><c>jp</c>: Japanese</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_mandarin</para>
            /// </summary>
            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The maximum duration of silence in milliseconds before a sentence break is detected. Range: 200 to 1,200. Default: 400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>Parameters for Alibaba Cloud Bailian. For details, see <a href="https://help.aliyun.com/document_detail/2858132.html">Bailian App Params</a>.</para>
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
            /// <para>Specifies whether to enable intelligent segmentation. If enabled, this feature intelligently merges pauses in a user\&quot;s speech into a single, complete sentence. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Push-to-Talk mode. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voice interruption. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable graceful shutdown. Default: <c>false</c>.</para>
            /// <list type="bullet">
            /// <item><description>If enabled, the agent finishes its current speech (up to 10 seconds) before stopping.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greeting message delivered when a user joins the session. If this parameter is omitted, the greeting configured in the agent template is used. Maximum length: 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>早上好，我的朋友！</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <para>A list of specific words or phrases that trigger a conversation interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            /// <summary>
            /// <para>The LLM/MLLM conversation history.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVisionChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVisionChatLlmHistory : TeaModel {
                /// <summary>
                /// <para>The text content of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the conversation participant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>user</c>: The user.</para>
                /// </description></item>
                /// <item><description><para><c>assistant</c>: The AI assistant.</para>
                /// </description></item>
                /// <item><description><para><c>system</c>: The system.</para>
                /// </description></item>
                /// <item><description><para><c>function</c>: A function call.</para>
                /// </description></item>
                /// <item><description><para><c>plugin</c>: A plugin.</para>
                /// </description></item>
                /// <item><description><para><c>tool</c>: A tool.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of conversation turns to retain in the LLM/MLLM history. Default: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM, applied when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位友好且乐于助人的助手，专注于为用户提供准确的信息和建议。</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>The maximum idle time in seconds with no interaction before the agent goes offline. Default: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to use voiceprint recognition. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits after a user leaves before closing the task. Default: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits for a user to join before closing the task. Default: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            /// <summary>
            /// <para>The interruption sensitivity threshold. A higher value makes it more difficult to interrupt the agent. Range: 0 to 11. Default: 11.</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Disables VAD.</para>
            /// </description></item>
            /// <item><description><para><c>1</c> to <c>10</c>: A higher value makes it more difficult to interrupt the agent.</para>
            /// </description></item>
            /// <item><description><para><c>11</c>: Offers lower audio distortion and stronger resistance to interference.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The ID of the Text-to-Speech (TTS) voice. Changes take effect on the next utterance. If omitted, the default voice from the agent template is used. This parameter applies only to preset TTS voices. Maximum length: 64 characters. For available values, see <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent voice effect samples</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>A list of available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID for voiceprint recognition. Default: not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speaking volume of the agent.</para>
            /// <list type="bullet">
            /// <item><description><para>If omitted, the system uses adaptive volume mode.</para>
            /// </description></item>
            /// <item><description><para>If specified, the valid range is 0 to 400. The output volume is calculated as: <c>Output Volume in Workflow</c> \* (<c>volume</c>/100). For example:</para>
            /// </description></item>
            /// </list>
            /// <ol>
            /// <item><description><para>If <c>volume</c> is <c>0</c>, the output is silent.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>100</c>, the output volume is the original volume.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>200</c>, the output volume is twice the original volume.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            /// <summary>
            /// <para>An initial user query that the agent addresses immediately when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>今天天气怎么样？</para>
            /// </summary>
            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <para>Workflow override parameters. Default: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

        /// <summary>
        /// <para>Voice chat parameters.</para>
        /// </summary>
        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        public AIAgentTemplateConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentTemplateConfigVoiceChat : TeaModel {
            /// <summary>
            /// <para>A list of hot words to improve ASR accuracy. A maximum of 128 words is supported.</para>
            /// </summary>
            [NameInMap("AsrHotWords")]
            [Validation(Required=false)]
            public List<string> AsrHotWords { get; set; }

            /// <summary>
            /// <para>The language ID for Automatic Speech Recognition (ASR).
            /// Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>zh_mandarin</c>: Chinese</para>
            /// </description></item>
            /// <item><description><para><c>en</c>: English</para>
            /// </description></item>
            /// <item><description><para><c>zh_en</c>: Chinese-English</para>
            /// </description></item>
            /// <item><description><para><c>es</c>: Spanish</para>
            /// </description></item>
            /// <item><description><para><c>jp</c>: Japanese</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh_mandarin</para>
            /// </summary>
            [NameInMap("AsrLanguageId")]
            [Validation(Required=false)]
            public string AsrLanguageId { get; set; }

            /// <summary>
            /// <para>The maximum duration of silence in milliseconds before a sentence break is detected. Range: 200 to 1,200. Default: 400.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("AsrMaxSilence")]
            [Validation(Required=false)]
            public int? AsrMaxSilence { get; set; }

            /// <summary>
            /// <para>The URL of the agent\&quot;s avatar for voice chat. Default: none.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/a.jpg">http://example.com/a.jpg</a></para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <para>The type of the agent\&quot;s avatar URL. Default: none.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("AvatarUrlType")]
            [Validation(Required=false)]
            public string AvatarUrlType { get; set; }

            /// <summary>
            /// <para>Parameters for Alibaba Cloud Bailian. For details, see <a href="https://help.aliyun.com/document_detail/2858132.html">Bailian App Params</a>.</para>
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
            /// <para>Specifies whether to enable intelligent segmentation. If enabled, this feature intelligently merges pauses in a user\&quot;s speech into a single, complete sentence. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligentSegment")]
            [Validation(Required=false)]
            public bool? EnableIntelligentSegment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Push-to-Talk mode. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePushToTalk")]
            [Validation(Required=false)]
            public bool? EnablePushToTalk { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable voice interruption. Default: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable graceful shutdown. Default: <c>false</c>.</para>
            /// <list type="bullet">
            /// <item><description>If enabled, the agent finishes its current speech (up to 10 seconds) before stopping.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GracefulShutdown")]
            [Validation(Required=false)]
            public bool? GracefulShutdown { get; set; }

            /// <summary>
            /// <para>The greeting message delivered when a user joins the session. If this parameter is omitted, the greeting configured in the agent template is used. Maximum length: 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>早上好，我的朋友</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <para>A list of specific words or phrases that trigger a conversation interruption.</para>
            /// </summary>
            [NameInMap("InterruptWords")]
            [Validation(Required=false)]
            public List<string> InterruptWords { get; set; }

            /// <summary>
            /// <para>The LLM/MLLM conversation history.</para>
            /// </summary>
            [NameInMap("LlmHistory")]
            [Validation(Required=false)]
            public List<AIAgentTemplateConfigVoiceChatLlmHistory> LlmHistory { get; set; }
            public class AIAgentTemplateConfigVoiceChatLlmHistory : TeaModel {
                /// <summary>
                /// <para>The text content of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the conversation participant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>user</c>: The user.</para>
                /// </description></item>
                /// <item><description><para><c>assistant</c>: The AI assistant.</para>
                /// </description></item>
                /// <item><description><para><c>system</c>: The system.</para>
                /// </description></item>
                /// <item><description><para><c>function</c>: A function call.</para>
                /// </description></item>
                /// <item><description><para><c>plugin</c>: A plugin.</para>
                /// </description></item>
                /// <item><description><para><c>tool</c>: A tool.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of conversation turns to retain in the LLM/MLLM history. Default: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LlmHistoryLimit")]
            [Validation(Required=false)]
            public int? LlmHistoryLimit { get; set; }

            /// <summary>
            /// <para>The system prompt for the LLM, applied when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是一位友好且乐于助人的助手，专注于为用户提供准确的信息和建议。</para>
            /// </summary>
            [NameInMap("LlmSystemPrompt")]
            [Validation(Required=false)]
            public string LlmSystemPrompt { get; set; }

            /// <summary>
            /// <para>The maximum idle time in seconds with no interaction before the agent goes offline. Default: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public int? MaxIdleTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to use voiceprint recognition. Default: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseVoiceprint")]
            [Validation(Required=false)]
            public bool? UseVoiceprint { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits after a user leaves before closing the task. Default: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UserOfflineTimeout")]
            [Validation(Required=false)]
            public int? UserOfflineTimeout { get; set; }

            /// <summary>
            /// <para>The time in seconds that the agent waits for a user to join before closing the task. Default: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UserOnlineTimeout")]
            [Validation(Required=false)]
            public int? UserOnlineTimeout { get; set; }

            /// <summary>
            /// <para>The interruption sensitivity threshold. A higher value makes it more difficult to interrupt the agent. Range: 0 to 11. Default: 11.</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Disables Voice Activity Detection (VAD).</para>
            /// </description></item>
            /// <item><description><para><c>1</c> to <c>10</c>: A higher value makes it more difficult to interrupt the agent.</para>
            /// </description></item>
            /// <item><description><para><c>11</c>: Offers lower audio distortion and stronger resistance to interference.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("VadLevel")]
            [Validation(Required=false)]
            public int? VadLevel { get; set; }

            /// <summary>
            /// <para>The ID of the Text-to-Speech (TTS) voice. Changes take effect on the next utterance. If omitted, the default voice from the agent template is used. This parameter applies only to preset TTS voices. Maximum length: 64 characters. For available values, see <a href="https://help.aliyun.com/document_detail/449563.html">Intelligent voice effect samples</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

            /// <summary>
            /// <para>A list of available voices.</para>
            /// </summary>
            [NameInMap("VoiceIdList")]
            [Validation(Required=false)]
            public List<string> VoiceIdList { get; set; }

            /// <summary>
            /// <para>The unique ID for voiceprint recognition. Default: not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uniqueId</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

            /// <summary>
            /// <para>The speaking volume of the agent.</para>
            /// <list type="bullet">
            /// <item><description><para>If omitted, the system uses adaptive volume mode.</para>
            /// </description></item>
            /// <item><description><para>If specified, the valid range is 0 to 400. The output volume is calculated as: <c>Output Volume in Workflow</c> \* (<c>volume</c>/100). For example:</para>
            /// </description></item>
            /// </list>
            /// <ol>
            /// <item><description><para>If <c>volume</c> is <c>0</c>, the output is silent.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>100</c>, the output volume is the original volume.</para>
            /// </description></item>
            /// <item><description><para>If <c>volume</c> is <c>200</c>, the output volume is twice the original volume.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public long? Volume { get; set; }

            /// <summary>
            /// <para>An initial user query that the agent addresses immediately when the call starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>今天天气怎么样？</para>
            /// </summary>
            [NameInMap("WakeUpQuery")]
            [Validation(Required=false)]
            public string WakeUpQuery { get; set; }

            /// <summary>
            /// <para>Workflow override parameters. Default: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("WorkflowOverrideParams")]
            [Validation(Required=false)]
            public string WorkflowOverrideParams { get; set; }

        }

    }

}
