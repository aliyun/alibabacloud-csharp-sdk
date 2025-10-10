// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppAgentTemplateRequest : TeaModel {
        [NameInMap("AgentSilenceConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestAgentSilenceConfig AgentSilenceConfig { get; set; }
        public class ModifyAppAgentTemplateRequestAgentSilenceConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("AlertTimeout")]
            [Validation(Required=false)]
            public int? AlertTimeout { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public int? Strategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("WebhookTriggerTimeout")]
            [Validation(Required=false)]
            public int? WebhookTriggerTimeout { get; set; }

        }

        [NameInMap("AmbientSoundConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestAmbientSoundConfig AmbientSoundConfig { get; set; }
        public class ModifyAppAgentTemplateRequestAmbientSoundConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>white_noise</para>
            /// </summary>
            [NameInMap("SoundId")]
            [Validation(Required=false)]
            public string SoundId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AsrConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestAsrConfig AsrConfig { get; set; }
        public class ModifyAppAgentTemplateRequestAsrConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxSentenceSilence")]
            [Validation(Required=false)]
            public int? MaxSentenceSilence { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STT</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("VadConfig")]
            [Validation(Required=false)]
            public ModifyAppAgentTemplateRequestAsrConfigVadConfig VadConfig { get; set; }
            public class ModifyAppAgentTemplateRequestAsrConfigVadConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("InterruptSpeechDuration")]
                [Validation(Required=false)]
                public int? InterruptSpeechDuration { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0bb1776b1745123332074d1b6b</para>
            /// </summary>
            [NameInMap("VocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

            [NameInMap("WordWeights")]
            [Validation(Required=false)]
            public List<ModifyAppAgentTemplateRequestAsrConfigWordWeights> WordWeights { get; set; }
            public class ModifyAppAgentTemplateRequestAsrConfigWordWeights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>苹果</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        [NameInMap("BackChannelConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestBackChannelConfig BackChannelConfig { get; set; }
        public class ModifyAppAgentTemplateRequestBackChannelConfig : TeaModel {
            [NameInMap("UserTurnEnd")]
            [Validation(Required=false)]
            public bool? UserTurnEnd { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChatMode")]
        [Validation(Required=false)]
        public int? ChatMode { get; set; }

        [NameInMap("Greeting")]
        [Validation(Required=false)]
        public string Greeting { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231231312312131231</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InterruptConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestInterruptConfig InterruptConfig { get; set; }
        public class ModifyAppAgentTemplateRequestInterruptConfig : TeaModel {
            [NameInMap("SemanticsInterrupt")]
            [Validation(Required=false)]
            public bool? SemanticsInterrupt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InterruptMode")]
        [Validation(Required=false)]
        public int? InterruptMode { get; set; }

        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestLlmConfig LlmConfig { get; set; }
        public class ModifyAppAgentTemplateRequestLlmConfig : TeaModel {
            [NameInMap("AgentAppId")]
            [Validation(Required=false)]
            public string AgentAppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak-1213123123132123131</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("HistoryDepth")]
            [Validation(Required=false)]
            public int? HistoryDepth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MaxToken")]
            [Validation(Required=false)]
            public int? MaxToken { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("Temperature")]
            [Validation(Required=false)]
            public float? Temperature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("TopP")]
            [Validation(Required=false)]
            public float? TopP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://llm.example.aliyuns.com">https://llm.example.aliyuns.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>thirdparty</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>智能体模版</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TtsConfig")]
        [Validation(Required=false)]
        public ModifyAppAgentTemplateRequestTtsConfig TtsConfig { get; set; }
        public class ModifyAppAgentTemplateRequestTtsConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak-1213123123132123131</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("FilterBrackets")]
            [Validation(Required=false)]
            public List<int?> FilterBrackets { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tts</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("Pitch")]
            [Validation(Required=false)]
            public float? Pitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public float? Rate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>longwan</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
