// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the project created in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JV1sRTisRMi****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The basic parameters set when creating a task. The required parameters vary depending on the task type.</para>
        /// <list type="bullet">
        /// <item><description><para>When type=offline (offline task), you must set the SourceLanguage and FileUrl parameters.</para>
        /// </description></item>
        /// <item><description><para>When type=realtime (real-time meeting task), you must additionally set the SourceLanguage, Format, and SampleRate parameters.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public CreateTaskRequestInput Input { get; set; }
        public class CreateTaskRequestInput : TeaModel {
            /// <summary>
            /// <para>The multi-channel audio and video processing mode.</para>
            /// </summary>
            [NameInMap("AudioChannelMode")]
            [Validation(Required=false)]
            public string AudioChannelMode { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS URL of the original audio or video file. This parameter is required when you create an offline transcription task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/zzz/1.wav">http://xxx.com/zzz/1.wav</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The encoding format of the audio stream data when you create a real-time meeting, such as pcm. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pcm</b></description></item>
            /// <item><description><b>opus</b></description></item>
            /// <item><description><b>aac</b></description></item>
            /// <item><description><b>speex</b></description></item>
            /// <item><description><b>mp3</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pcm</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The preferred languages. This parameter takes effect only when SourceLanguage is set to &quot;multilingual&quot;. It restricts the output languages of the model.</para>
            /// </summary>
            [NameInMap("LanguageHints")]
            [Validation(Required=false)]
            public List<string> LanguageHints { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable multi-channel audio stream recognition. This parameter needs to be set only in real-time recording scenarios. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MultipleStreamsEnabled")]
            [Validation(Required=false)]
            public bool? MultipleStreamsEnabled { get; set; }

            /// <summary>
            /// <para>After configuring OSS information in the console, you can specify an OSS write path to save results directly to your custom OSS bucket.</para>
            /// </summary>
            [NameInMap("OutputPath")]
            [Validation(Required=false)]
            public string OutputPath { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the callback feature.
            /// To enable the callback feature, configure the callback type and address in the console, and set this parameter to true when creating a task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProgressiveCallbacksEnabled")]
            [Validation(Required=false)]
            public bool? ProgressiveCallbacksEnabled { get; set; }

            /// <summary>
            /// <para>The sample rate of the audio stream data when you create a real-time meeting. Valid values: 8000 and 16000.</para>
            /// <list type="bullet">
            /// <item><description><b>8000</b>: telephone customer service scenarios.</description></item>
            /// <item><description><b>16000</b>: real-time meeting audio capture scenarios.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16000</para>
            /// </summary>
            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            /// <summary>
            /// <para>The language model used for audio transcription. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// <item><description><b>fspk</b>: Chinese-English free speaking</description></item>
            /// <item><description><b>ja</b>: Japanese</description></item>
            /// <item><description><b>yue</b>: Cantonese</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("SourceLanguage")]
            [Validation(Required=false)]
            public string SourceLanguage { get; set; }

            /// <summary>
            /// <para>The TaskId returned when you create a real-time recording. You can use this ID to end the real-time recording. Set this parameter only when ending a real-time recording. Do not set it at other times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9922c84c087044eda18659c128b56c84</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The custom identifier set by the user to associate with this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

        }

        /// <summary>
        /// <para>The algorithm-related parameters set when creating a task. You can set these as needed.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public CreateTaskRequestParameters Parameters { get; set; }
        public class CreateTaskRequestParameters : TeaModel {
            [NameInMap("AutoChapters")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersAutoChapters AutoChapters { get; set; }
            public class CreateTaskRequestParametersAutoChapters : TeaModel {
                [NameInMap("ChapterGranularity")]
                [Validation(Required=false)]
                public string ChapterGranularity { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the chapter overview feature. When enabled, chapter titles and chapter summaries are generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoChaptersEnabled")]
            [Validation(Required=false)]
            public bool? AutoChaptersEnabled { get; set; }

            /// <summary>
            /// <para>The conversation content extraction parameter object.</para>
            /// </summary>
            [NameInMap("ContentExtraction")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersContentExtraction ContentExtraction { get; set; }
            public class CreateTaskRequestParametersContentExtraction : TeaModel {
                /// <summary>
                /// <para>The list of extraction dimensions for conversation content extraction, including the name and definition of each extraction item.</para>
                /// </summary>
                [NameInMap("ExtractionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersContentExtractionExtractionContents> ExtractionContents { get; set; }
                public class CreateTaskRequestParametersContentExtractionExtractionContents : TeaModel {
                    /// <summary>
                    /// <para>The extraction dimension definition for conversation content extraction.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    /// <summary>
                    /// <para>The extraction dimension name for conversation content extraction.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The scene description for conversation content extraction.</para>
                /// </summary>
                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

                [NameInMap("SpeakerMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> SpeakerMap { get; set; }

            }

            /// <summary>
            /// <para>The business user ID.</para>
            /// </summary>
            [NameInMap("ContentExtractionEnabled")]
            [Validation(Required=false)]
            public bool? ContentExtractionEnabled { get; set; }

            /// <summary>
            /// <para>The custom prompt control parameter object.</para>
            /// </summary>
            [NameInMap("CustomPrompt")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersCustomPrompt CustomPrompt { get; set; }
            public class CreateTaskRequestParametersCustomPrompt : TeaModel {
                /// <summary>
                /// <para>The list of custom prompt parameters.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersCustomPromptContents> Contents { get; set; }
                public class CreateTaskRequestParametersCustomPromptContents : TeaModel {
                    /// <summary>
                    /// <para>The model specified for the prompt.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tingwu-turbo</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>The custom name of the prompt, used to match output results.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>summary-demo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The custom content of the prompt.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Summarize the following conversation:{Transcription}</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    /// <summary>
                    /// <para>The format of the {Transcription} tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("TransType")]
                    [Validation(Required=false)]
                    public string TransType { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether to enable the custom prompt feature. When enabled, you can enter a personalized custom prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CustomPromptEnabled")]
            [Validation(Required=false)]
            public bool? CustomPromptEnabled { get; set; }

            /// <summary>
            /// <para>The extra parameters. In most cases, you do not need to set this parameter.</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersExtraParams ExtraParams { get; set; }
            public class CreateTaskRequestParametersExtraParams : TeaModel {
                [NameInMap("DomainEducationEnabled")]
                [Validation(Required=false)]
                public bool? DomainEducationEnabled { get; set; }

                /// <summary>
                /// <para>The return format of the full-text summary.</para>
                /// </summary>
                [NameInMap("FullTextSummaryFormat")]
                [Validation(Required=false)]
                public string FullTextSummaryFormat { get; set; }

                /// <summary>
                /// <para>The number of keywords to extract.</para>
                /// </summary>
                [NameInMap("MaxKeywords")]
                [Validation(Required=false)]
                public int? MaxKeywords { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Nfix. In most cases, you do not need to set this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NfixEnabled")]
                [Validation(Required=false)]
                public bool? NfixEnabled { get; set; }

                [NameInMap("OcrAuxiliaryEnabled")]
                [Validation(Required=false)]
                public bool? OcrAuxiliaryEnabled { get; set; }

                [NameInMap("TranslateLlmSceneEnabled")]
                [Validation(Required=false)]
                public bool? TranslateLlmSceneEnabled { get; set; }

                /// <summary>
                /// <para>The translation hotword configuration.</para>
                /// </summary>
                [NameInMap("TranslationHotwordMap")]
                [Validation(Required=false)]
                public CreateTaskRequestParametersExtraParamsTranslationHotwordMap TranslationHotwordMap { get; set; }
                public class CreateTaskRequestParametersExtraParamsTranslationHotwordMap : TeaModel {
                    /// <summary>
                    /// <para>The business scenario type.</para>
                    /// </summary>
                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("bizUserId")]
                    [Validation(Required=false)]
                    public string BizUserId { get; set; }

                }

            }

            /// <summary>
            /// <para>The identity recognition parameter object.</para>
            /// </summary>
            [NameInMap("IdentityRecognition")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersIdentityRecognition IdentityRecognition { get; set; }
            public class CreateTaskRequestParametersIdentityRecognition : TeaModel {
                /// <summary>
                /// <para>The list of identity contents for identity recognition, including the identity name and description.</para>
                /// </summary>
                [NameInMap("IdentityContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersIdentityRecognitionIdentityContents> IdentityContents { get; set; }
                public class CreateTaskRequestParametersIdentityRecognitionIdentityContents : TeaModel {
                    /// <summary>
                    /// <para>The identity description.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The identity name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The scene description for identity recognition.</para>
                /// </summary>
                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the identity recognition feature.</para>
            /// </summary>
            [NameInMap("IdentityRecognitionEnabled")]
            [Validation(Required=false)]
            public bool? IdentityRecognitionEnabled { get; set; }

            [NameInMap("LlmOutputLanguage")]
            [Validation(Required=false)]
            public string LlmOutputLanguage { get; set; }

            /// <summary>
            /// <para>The control parameters for the intelligent meeting notes feature, which supports algorithm processing for action items, keywords, and key content. If you enable MeetingAssistanceEnabled but do not specify algorithm types through MeetingAssistance, all types are called and returned by default.</para>
            /// </summary>
            [NameInMap("MeetingAssistance")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersMeetingAssistance MeetingAssistance { get; set; }
            public class CreateTaskRequestParametersMeetingAssistance : TeaModel {
                /// <summary>
                /// <para>When the intelligent meeting notes feature is enabled, pass in the expected feature parameter types. Supported types: action items (Actions) and key information (KeyInformation). Key information includes keywords and key content (key sentences).</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the intelligent meeting notes feature. When enabled, results such as keywords, key content, and action items are generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MeetingAssistanceEnabled")]
            [Validation(Required=false)]
            public bool? MeetingAssistanceEnabled { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable PPT extraction and PPT summarization. When enabled, PPT frames are extracted from the video file and corresponding summaries are generated. Enable this parameter only for offline transcription when the source file is a video file. Results cannot be generated in real-time recording scenarios or offline transcription scenarios where the source file is audio only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PptExtractionEnabled")]
            [Validation(Required=false)]
            public bool? PptExtractionEnabled { get; set; }

            /// <summary>
            /// <para>The service inspection parameter object.</para>
            /// </summary>
            [NameInMap("ServiceInspection")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersServiceInspection ServiceInspection { get; set; }
            public class CreateTaskRequestParametersServiceInspection : TeaModel {
                /// <summary>
                /// <para>The list of inspection dimensions for service inspection, including the dimension name and definition. The definition specifies the criteria that the large language model uses to determine whether a dimension is matched.</para>
                /// </summary>
                [NameInMap("InspectionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersServiceInspectionInspectionContents> InspectionContents { get; set; }
                public class CreateTaskRequestParametersServiceInspectionInspectionContents : TeaModel {
                    /// <summary>
                    /// <para>The inspection dimension definition for service inspection.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The inspection dimension name for service inspection.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The description of the inspection target and focus for service inspection.</para>
                /// </summary>
                [NameInMap("InspectionIntroduction")]
                [Validation(Required=false)]
                public string InspectionIntroduction { get; set; }

                /// <summary>
                /// <para>The conversation scene description for service inspection.</para>
                /// </summary>
                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

                [NameInMap("SpeakerMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> SpeakerMap { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the service inspection feature. Default value: false.</para>
            /// </summary>
            [NameInMap("ServiceInspectionEnabled")]
            [Validation(Required=false)]
            public bool? ServiceInspectionEnabled { get; set; }

            /// <summary>
            /// <para>The summarization control parameters.</para>
            /// </summary>
            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersSummarization Summarization { get; set; }
            public class CreateTaskRequestParametersSummarization : TeaModel {
                /// <summary>
                /// <para>When the summarization feature is enabled, pass in the expected summarization types. Supported types: full-text summary (Paragraph), speaker summary (Conversational), and Q&amp;A review summary (QuestionsAnswering).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Paragraph</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the summarization feature. When enabled, results such as full-text summaries and speaker summaries can be generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SummarizationEnabled")]
            [Validation(Required=false)]
            public bool? SummarizationEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the spoken-to-written text conversion feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TextPolishEnabled")]
            [Validation(Required=false)]
            public bool? TextPolishEnabled { get; set; }

            /// <summary>
            /// <para>The audio/video or audio stream transcoding module.</para>
            /// </summary>
            [NameInMap("Transcoding")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscoding Transcoding { get; set; }
            public class CreateTaskRequestParametersTranscoding : TeaModel {
                /// <summary>
                /// <para>Specifies whether to generate an audio waveform from the original audio/video file or audio stream and save it. Currently, only MP3 format is supported. This parameter is optional when creating offline file transcription or real-time meetings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SpectrumEnabled")]
                [Validation(Required=false)]
                public bool? SpectrumEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to convert the original audio/video file or audio stream to MP3 format for storage. Currently, only MP3 format is supported. This parameter is optional when creating offline file transcription or real-time meetings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("TargetAudioFormat")]
                [Validation(Required=false)]
                public string TargetAudioFormat { get; set; }

                /// <summary>
                /// <para>Specifies whether to convert the original video file to MP4 format for storage. Currently, only MP4 format is supported. This parameter is meaningful only when creating offline file transcription and the original file is in video format. Typically, you do not need to set this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("TargetVideoFormat")]
                [Validation(Required=false)]
                public string TargetVideoFormat { get; set; }

                /// <summary>
                /// <para>Specifies whether to extract video thumbnails from the original video file and save them. This parameter is meaningful only when creating offline file transcription and the original file is in video format. Typically, you do not need to set this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("VideoThumbnailEnabled")]
                [Validation(Required=false)]
                public bool? VideoThumbnailEnabled { get; set; }

            }

            /// <summary>
            /// <para>The speech transcription control parameters.</para>
            /// </summary>
            [NameInMap("Transcription")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscription Transcription { get; set; }
            public class CreateTaskRequestParametersTranscription : TeaModel {
                /// <summary>
                /// <para>Sets the output level for speech recognition results of the active speaker in real-time recording scenarios.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results when a complete sentence is recognized.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns results for both intermediate results and complete sentences.</para>
                /// </description></item>
                /// </list>
                /// <para>Set this parameter as needed only in real-time recording scenarios when MultipleStreamsEnabled is set to true. This parameter does not need to be set for offline transcription scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable audio event detection during speech transcription to determine whether events such as music exist in the audio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AudioEventDetectionEnabled")]
                [Validation(Required=false)]
                public bool? AudioEventDetectionEnabled { get; set; }

                /// <summary>
                /// <para>The speaker diarization parameters.</para>
                /// </summary>
                [NameInMap("Diarization")]
                [Validation(Required=false)]
                public CreateTaskRequestParametersTranscriptionDiarization Diarization { get; set; }
                public class CreateTaskRequestParametersTranscriptionDiarization : TeaModel {
                    /// <summary>
                    /// <para>Sets the speaker diarization parameter.</para>
                    /// <para>If not set: speaker role differentiation is not used. </para>
                    /// <para>0: the number of speakers is undetermined.</para>
                    /// <para>2: the number of speakers is 2.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SpeakerCount")]
                    [Validation(Required=false)]
                    public int? SpeakerCount { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to enable speaker diarization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DiarizationEnabled")]
                [Validation(Required=false)]
                public bool? DiarizationEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable disfluency removal during speech transcription. Enabled by default.</para>
                /// </summary>
                [NameInMap("DisfluencyEnabled")]
                [Validation(Required=false)]
                public bool? DisfluencyEnabled { get; set; }

                /// <summary>
                /// <para>Sets the speech transcription model to improve transcription accuracy in specific domains.</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>Sets the output level for speech recognition results. Default value: 1.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results when a complete sentence is recognized.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns results for both intermediate results and complete sentences.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                [NameInMap("Phrase")]
                [Validation(Required=false)]
                public Dictionary<string, object> Phrase { get; set; }

                /// <summary>
                /// <para>The vocabulary ID of the hot words.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ce9c2a34b6d847bf92a77d0a196f****</para>
                /// </summary>
                [NameInMap("PhraseId")]
                [Validation(Required=false)]
                public string PhraseId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable profanity filtering during speech transcription. Enabled by default.</para>
                /// </summary>
                [NameInMap("ProfanityFilterEnabled")]
                [Validation(Required=false)]
                public bool? ProfanityFilterEnabled { get; set; }

                [NameInMap("RealtimeDiarizationEnabled")]
                [Validation(Required=false)]
                public bool? RealtimeDiarizationEnabled { get; set; }

            }

            /// <summary>
            /// <para>The translation control parameters.</para>
            /// </summary>
            [NameInMap("Translation")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranslation Translation { get; set; }
            public class CreateTaskRequestParametersTranslation : TeaModel {
                /// <summary>
                /// <para>Sets the output level for translation results of the active speaker in real-time recording scenarios.</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Returns results when a complete sentence is recognized.</description></item>
                /// <item><description><b>2</b>: Returns results for both intermediate results and complete sentences.</description></item>
                /// </list>
                /// <para>Set this parameter as needed only in real-time recording scenarios when MultipleStreamsEnabled is set to true. This parameter does not need to be set for offline transcription scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                /// <summary>
                /// <para>Sets the output level for real-time translation results. Default value: 1.</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Returns results when a complete sentence is recognized.</description></item>
                /// <item><description><b>2</b>: Returns results for both intermediate results and complete sentences.</description></item>
                /// </list>
                /// <para>Set this parameter as needed only in real-time recording scenarios. This parameter does not need to be set for offline transcription scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                /// <summary>
                /// <para>The target languages to set when the translation feature is enabled. Chinese, English, and Japanese are supported.</para>
                /// </summary>
                [NameInMap("TargetLanguages")]
                [Validation(Required=false)]
                public List<string> TargetLanguages { get; set; }

                /// <summary>
                /// <para>Specifies whether to use large language model-based translation. Default value: false.</para>
                /// </summary>
                [NameInMap("TranslateLlmSceneEnabled")]
                [Validation(Required=false)]
                public bool? TranslateLlmSceneEnabled { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the translation feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TranslationEnabled")]
            [Validation(Required=false)]
            public bool? TranslationEnabled { get; set; }

        }

        /// <summary>
        /// <para>The operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>start: creates a task. This is the default value. In most cases, you do not need to explicitly set this parameter.</description></item>
        /// <item><description>stop: stops a real-time meeting task. This value is used in real-time meeting scenarios. After a meeting ends, set this parameter to stop and trigger the call.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: When ending a real-time recording, you must set this parameter to stop.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>offline</b>: offline task, such as offline transcription.</description></item>
        /// <item><description><b>realtime</b>: real-time task, such as creating a real-time recording.</description></item>
        /// </list>
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
