// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartAgentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aoe****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelId</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RtcConfig")]
        [Validation(Required=false)]
        public StartAgentRequestRtcConfig RtcConfig { get; set; }
        public class StartAgentRequestRtcConfig : TeaModel {
            [NameInMap("TargetUserIds")]
            [Validation(Required=false)]
            public List<string> TargetUserIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>423341</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76dasgb****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("VoiceChatConfig")]
        [Validation(Required=false)]
        public StartAgentRequestVoiceChatConfig VoiceChatConfig { get; set; }
        public class StartAgentRequestVoiceChatConfig : TeaModel {
            [NameInMap("ASRConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigASRConfig ASRConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigASRConfig : TeaModel {
                [NameInMap("LanguageHints")]
                [Validation(Required=false)]
                public List<string> LanguageHints { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("MaxSentenceSilence")]
                [Validation(Required=false)]
                public int? MaxSentenceSilence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SemanticPunctuationEnabled")]
                [Validation(Required=false)]
                public bool? SemanticPunctuationEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vocab-xxx-24ee19fa8cfb4d52902170a0xxxxxxxx</para>
                /// </summary>
                [NameInMap("VocabularyId")]
                [Validation(Required=false)]
                public string VocabularyId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatMode")]
            [Validation(Required=false)]
            public int? ChatMode { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterruptMode")]
            [Validation(Required=false)]
            public int? InterruptMode { get; set; }

            [NameInMap("LLMConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigLLMConfig LLMConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigLLMConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HistoryDepth")]
                [Validation(Required=false)]
                public int? HistoryDepth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxToken")]
                [Validation(Required=false)]
                public int? MaxToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("TopP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx">https://xxxxx</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

            [NameInMap("TTSConfig")]
            [Validation(Required=false)]
            public StartAgentRequestVoiceChatConfigTTSConfig TTSConfig { get; set; }
            public class StartAgentRequestVoiceChatConfigTTSConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("FilterBrackets")]
                [Validation(Required=false)]
                public List<int?> FilterBrackets { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cosyvoice-v1</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Pitch")]
                [Validation(Required=false)]
                public double? Pitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>longxiaoxia</para>
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

        }

    }

}
