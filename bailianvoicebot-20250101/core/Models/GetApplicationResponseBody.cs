// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyData Data { get; set; }
        public class GetApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a395011f-a247-400f-bc69-28796749fd52</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1730081561000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DraftVersion")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyDataDraftVersion DraftVersion { get; set; }
            public class GetApplicationResponseBodyDataDraftVersion : TeaModel {
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionInteractionConfig InteractionConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionInteractionConfig : TeaModel {
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionScriptProfile ScriptProfile { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionScriptProfile : TeaModel {
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataDraftVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetApplicationResponseBodyDataDraftVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>6a50b67072d44788951de29758432d94</para>
                        /// </summary>
                        [NameInMap("AgentProfileId")]
                        [Validation(Required=false)]
                        public string AgentProfileId { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Temperature")]
                    [Validation(Required=false)]
                    public string Temperature { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("TopP")]
                    [Validation(Required=false)]
                    public string TopP { get; set; }

                }

                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataDraftVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionSynthesizerConfig : TeaModel {
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
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aixia</para>
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
                public GetApplicationResponseBodyDataDraftVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetApplicationResponseBodyDataDraftVersionTranscriberConfig : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>743219815472857088</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("NluAccessType")]
            [Validation(Required=false)]
            public string NluAccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROMPTS</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            [NameInMap("PublishedVersion")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyDataPublishedVersion PublishedVersion { get; set; }
            public class GetApplicationResponseBodyDataPublishedVersion : TeaModel {
                [NameInMap("InteractionConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionInteractionConfig InteractionConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionInteractionConfig : TeaModel {
                    [NameInMap("SilenceDetectionConfig")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig SilenceDetectionConfig { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionInteractionConfigSilenceDetectionConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                }

                [NameInMap("ScriptProfile")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionScriptProfile ScriptProfile { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionScriptProfile : TeaModel {
                    [NameInMap("AgentProfile")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyDataPublishedVersionScriptProfileAgentProfile AgentProfile { get; set; }
                    public class GetApplicationResponseBodyDataPublishedVersionScriptProfileAgentProfile : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>b97b6822dd624c32b6c2a54d717db718</para>
                        /// </summary>
                        [NameInMap("AgentProfileId")]
                        [Validation(Required=false)]
                        public string AgentProfileId { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Temperature")]
                    [Validation(Required=false)]
                    public string Temperature { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("TopP")]
                    [Validation(Required=false)]
                    public string TopP { get; set; }

                }

                [NameInMap("SynthesizerConfig")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyDataPublishedVersionSynthesizerConfig SynthesizerConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionSynthesizerConfig : TeaModel {
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
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("PitchRate")]
                    [Validation(Required=false)]
                    public int? PitchRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-20</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aixia</para>
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
                public GetApplicationResponseBodyDataPublishedVersionTranscriberConfig TranscriberConfig { get; set; }
                public class GetApplicationResponseBodyDataPublishedVersionTranscriberConfig : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>47889c1f-dd3f-4ace-9587-a13a3563e678</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1730081561000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D771A1B6-3D5F-174A-BEE1-98CE1000D337</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
