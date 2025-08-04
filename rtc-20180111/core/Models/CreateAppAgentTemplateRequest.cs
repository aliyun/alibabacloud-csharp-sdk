// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateAppAgentTemplateRequest : TeaModel {
        [NameInMap("AgentSilenceConfig")]
        [Validation(Required=false)]
        public CreateAppAgentTemplateRequestAgentSilenceConfig AgentSilenceConfig { get; set; }
        public class CreateAppAgentTemplateRequestAgentSilenceConfig : TeaModel {
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
        public CreateAppAgentTemplateRequestAsrConfig AsrConfig { get; set; }
        public class CreateAppAgentTemplateRequestAsrConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
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
            public CreateAppAgentTemplateRequestAsrConfigVadConfig VadConfig { get; set; }
            public class CreateAppAgentTemplateRequestAsrConfigVadConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("InterruptSpeechDuration")]
                [Validation(Required=false)]
                public int? InterruptSpeechDuration { get; set; }

            }

            [NameInMap("WordWeights")]
            [Validation(Required=false)]
            public List<CreateAppAgentTemplateRequestAsrConfigWordWeights> WordWeights { get; set; }
            public class CreateAppAgentTemplateRequestAsrConfigWordWeights : TeaModel {
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
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InterruptMode")]
        [Validation(Required=false)]
        public int? InterruptMode { get; set; }

        [NameInMap("LlmConfig")]
        [Validation(Required=false)]
        public CreateAppAgentTemplateRequestLlmConfig LlmConfig { get; set; }
        public class CreateAppAgentTemplateRequestLlmConfig : TeaModel {
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
            /// <para>5</para>
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
            /// <para>0.9</para>
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
            /// <para>This parameter is required.</para>
            /// 
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
        public CreateAppAgentTemplateRequestTtsConfig TtsConfig { get; set; }
        public class CreateAppAgentTemplateRequestTtsConfig : TeaModel {
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
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>longcheng</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>70</para>
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
