// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateApplicationVersionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a395011f-a247-400f-bc69-28796749fd52</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-c11iig67g863rih8</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        [NameInMap("InteractionConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestInteractionConfig InteractionConfig { get; set; }
        public class CreateApplicationVersionRequestInteractionConfig : TeaModel {
            [NameInMap("SilenceDetectionConfig")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
            public class CreateApplicationVersionRequestInteractionConfigSilenceDetectionConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

        }

        [NameInMap("ScriptProfile")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestScriptProfile ScriptProfile { get; set; }
        public class CreateApplicationVersionRequestScriptProfile : TeaModel {
            [NameInMap("AgentProfile")]
            [Validation(Required=false)]
            public CreateApplicationVersionRequestScriptProfileAgentProfile AgentProfile { get; set; }
            public class CreateApplicationVersionRequestScriptProfileAgentProfile : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PromptsJson")]
                [Validation(Required=false)]
                public string PromptsJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SFM_PROMPTS_DEFAULT</para>
                /// </summary>
                [NameInMap("ScriptProfileTemplateId")]
                [Validation(Required=false)]
                public string ScriptProfileTemplateId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20904943-f711-494f-9f1f-e7f340f37707</para>
        /// </summary>
        [NameInMap("SourceVersionId")]
        [Validation(Required=false)]
        public string SourceVersionId { get; set; }

        [NameInMap("SynthesizerConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestSynthesizerConfig SynthesizerConfig { get; set; }
        public class CreateApplicationVersionRequestSynthesizerConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PitchRate")]
            [Validation(Required=false)]
            public int? PitchRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-156</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public int? SpeechRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aiqi</para>
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

        [NameInMap("TranscriberConfig")]
        [Validation(Required=false)]
        public CreateApplicationVersionRequestTranscriberConfig TranscriberConfig { get; set; }
        public class CreateApplicationVersionRequestTranscriberConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NlsAccessType")]
            [Validation(Required=false)]
            public string NlsAccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("NlsEngine")]
            [Validation(Required=false)]
            public string NlsEngine { get; set; }

        }

    }

}
