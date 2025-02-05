// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>JV1sRTisRMi****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public CreateTaskRequestInput Input { get; set; }
        public class CreateTaskRequestInput : TeaModel {
            [NameInMap("AudioChannelMode")]
            [Validation(Required=false)]
            public string AudioChannelMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/zzz/1.wav">http://xxx.com/zzz/1.wav</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pcm</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("LanguageHints")]
            [Validation(Required=false)]
            public List<string> LanguageHints { get; set; }

            [NameInMap("MultipleStreamsEnabled")]
            [Validation(Required=false)]
            public bool? MultipleStreamsEnabled { get; set; }

            [NameInMap("OutputPath")]
            [Validation(Required=false)]
            public string OutputPath { get; set; }

            [NameInMap("ProgressiveCallbacksEnabled")]
            [Validation(Required=false)]
            public bool? ProgressiveCallbacksEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16000</para>
            /// </summary>
            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("SourceLanguage")]
            [Validation(Required=false)]
            public string SourceLanguage { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public CreateTaskRequestParameters Parameters { get; set; }
        public class CreateTaskRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoChaptersEnabled")]
            [Validation(Required=false)]
            public bool? AutoChaptersEnabled { get; set; }

            [NameInMap("ContentExtraction")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersContentExtraction ContentExtraction { get; set; }
            public class CreateTaskRequestParametersContentExtraction : TeaModel {
                [NameInMap("ExtractionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersContentExtractionExtractionContents> ExtractionContents { get; set; }
                public class CreateTaskRequestParametersContentExtractionExtractionContents : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

                [NameInMap("SpeakerMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> SpeakerMap { get; set; }

            }

            [NameInMap("ContentExtractionEnabled")]
            [Validation(Required=false)]
            public bool? ContentExtractionEnabled { get; set; }

            [NameInMap("CustomPrompt")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersCustomPrompt CustomPrompt { get; set; }
            public class CreateTaskRequestParametersCustomPrompt : TeaModel {
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersCustomPromptContents> Contents { get; set; }
                public class CreateTaskRequestParametersCustomPromptContents : TeaModel {
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    [NameInMap("TransType")]
                    [Validation(Required=false)]
                    public string TransType { get; set; }

                }

            }

            [NameInMap("CustomPromptEnabled")]
            [Validation(Required=false)]
            public bool? CustomPromptEnabled { get; set; }

            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersExtraParams ExtraParams { get; set; }
            public class CreateTaskRequestParametersExtraParams : TeaModel {
                [NameInMap("DomainEducationEnabled")]
                [Validation(Required=false)]
                public bool? DomainEducationEnabled { get; set; }

                [NameInMap("MaxKeywords")]
                [Validation(Required=false)]
                public int? MaxKeywords { get; set; }

                [NameInMap("NfixEnabled")]
                [Validation(Required=false)]
                public bool? NfixEnabled { get; set; }

                [NameInMap("OcrAuxiliaryEnabled")]
                [Validation(Required=false)]
                public bool? OcrAuxiliaryEnabled { get; set; }

                [NameInMap("TranslateLlmSceneEnabled")]
                [Validation(Required=false)]
                public bool? TranslateLlmSceneEnabled { get; set; }

            }

            [NameInMap("MeetingAssistance")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersMeetingAssistance MeetingAssistance { get; set; }
            public class CreateTaskRequestParametersMeetingAssistance : TeaModel {
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MeetingAssistanceEnabled")]
            [Validation(Required=false)]
            public bool? MeetingAssistanceEnabled { get; set; }

            [NameInMap("PptExtractionEnabled")]
            [Validation(Required=false)]
            public bool? PptExtractionEnabled { get; set; }

            [NameInMap("ServiceInspection")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersServiceInspection ServiceInspection { get; set; }
            public class CreateTaskRequestParametersServiceInspection : TeaModel {
                [NameInMap("InspectionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersServiceInspectionInspectionContents> InspectionContents { get; set; }
                public class CreateTaskRequestParametersServiceInspectionInspectionContents : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("InspectionIntroduction")]
                [Validation(Required=false)]
                public string InspectionIntroduction { get; set; }

                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

                [NameInMap("SpeakerMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> SpeakerMap { get; set; }

            }

            [NameInMap("ServiceInspectionEnabled")]
            [Validation(Required=false)]
            public bool? ServiceInspectionEnabled { get; set; }

            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersSummarization Summarization { get; set; }
            public class CreateTaskRequestParametersSummarization : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Paragraph</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SummarizationEnabled")]
            [Validation(Required=false)]
            public bool? SummarizationEnabled { get; set; }

            [NameInMap("TextPolishEnabled")]
            [Validation(Required=false)]
            public bool? TextPolishEnabled { get; set; }

            [NameInMap("Transcoding")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscoding Transcoding { get; set; }
            public class CreateTaskRequestParametersTranscoding : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SpectrumEnabled")]
                [Validation(Required=false)]
                public bool? SpectrumEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("TargetAudioFormat")]
                [Validation(Required=false)]
                public string TargetAudioFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("TargetVideoFormat")]
                [Validation(Required=false)]
                public string TargetVideoFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("VideoThumbnailEnabled")]
                [Validation(Required=false)]
                public bool? VideoThumbnailEnabled { get; set; }

            }

            [NameInMap("Transcription")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscription Transcription { get; set; }
            public class CreateTaskRequestParametersTranscription : TeaModel {
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AudioEventDetectionEnabled")]
                [Validation(Required=false)]
                public bool? AudioEventDetectionEnabled { get; set; }

                [NameInMap("Diarization")]
                [Validation(Required=false)]
                public CreateTaskRequestParametersTranscriptionDiarization Diarization { get; set; }
                public class CreateTaskRequestParametersTranscriptionDiarization : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SpeakerCount")]
                    [Validation(Required=false)]
                    public int? SpeakerCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DiarizationEnabled")]
                [Validation(Required=false)]
                public bool? DiarizationEnabled { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                [NameInMap("PhraseId")]
                [Validation(Required=false)]
                public string PhraseId { get; set; }

            }

            [NameInMap("Translation")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranslation Translation { get; set; }
            public class CreateTaskRequestParametersTranslation : TeaModel {
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                [NameInMap("TargetLanguages")]
                [Validation(Required=false)]
                public List<string> TargetLanguages { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TranslationEnabled")]
            [Validation(Required=false)]
            public bool? TranslationEnabled { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>offline</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
