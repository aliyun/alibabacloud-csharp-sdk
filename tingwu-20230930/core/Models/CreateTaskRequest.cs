// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the project that you created in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JV1sRTisRMi****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The basic input parameters for creating a task. The required parameters vary based on the task type.</para>
        /// <list type="bullet">
        /// <item><description><para>For an offline task (<c>type=&quot;offline&quot;</c>), you must specify the <c>SourceLanguage</c> and <c>FileUrl</c> parameters.</para>
        /// </description></item>
        /// <item><description><para>For a real-time task (<c>type=&quot;realtime&quot;</c>), you must also specify the <c>SourceLanguage</c>, <c>Format</c>, and <c>SampleRate</c> parameters.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public CreateTaskRequestInput Input { get; set; }
        public class CreateTaskRequestInput : TeaModel {
            /// <summary>
            /// <para>Multi-channel audio or video processing mode.</para>
            /// </summary>
            [NameInMap("AudioChannelMode")]
            [Validation(Required=false)]
            public string AudioChannelMode { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS URL of the source audio or video file. This parameter is required when you create an offline transcription task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/zzz/1.wav">http://xxx.com/zzz/1.wav</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The encoding format of the audio stream data. This parameter is required when you create a real-time recording task. The following values are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pcm</b></para>
            /// </description></item>
            /// <item><description><para><b>opus</b></para>
            /// </description></item>
            /// <item><description><para><b>aac</b></para>
            /// </description></item>
            /// <item><description><para><b>speex</b></para>
            /// </description></item>
            /// <item><description><para><b>mp3</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pcm</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Preferred languages. This applies only when SourceLanguage is multilingual. It restricts the output language of the model.</para>
            /// </summary>
            [NameInMap("LanguageHints")]
            [Validation(Required=false)]
            public List<string> LanguageHints { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable multi-channel audio stream recognition. This parameter applies only to real-time recording scenarios. The default value is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MultipleStreamsEnabled")]
            [Validation(Required=false)]
            public bool? MultipleStreamsEnabled { get; set; }

            /// <summary>
            /// <para>After you configure OSS settings in the console, specify an OSS path to save results directly to your OSS bucket.</para>
            /// </summary>
            [NameInMap("OutputPath")]
            [Validation(Required=false)]
            public string OutputPath { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable callbacks. To receive callbacks, you must configure the callback type and URL in the console and set this parameter to <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProgressiveCallbacksEnabled")]
            [Validation(Required=false)]
            public bool? ProgressiveCallbacksEnabled { get; set; }

            /// <summary>
            /// <para>The sample rate of the audio stream data. This parameter is required when you create a real-time recording task. The supported values are 8000 and 16000.</para>
            /// <list type="bullet">
            /// <item><description><para><b>8000</b>: Suitable for telephony and customer service scenarios.</para>
            /// </description></item>
            /// <item><description><para><b>16000</b>: Suitable for real-time meeting audio capture scenarios.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16000</para>
            /// </summary>
            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public int? SampleRate { get; set; }

            /// <summary>
            /// <para>The language model for speech transcription. The following values are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn</b>: Chinese</para>
            /// </description></item>
            /// <item><description><para><b>en</b>: English</para>
            /// </description></item>
            /// <item><description><para><b>fspk</b>: Chinese-English code-switching</para>
            /// </description></item>
            /// <item><description><para><b>ja</b>: Japanese</para>
            /// </description></item>
            /// <item><description><para><b>yue</b>: Cantonese</para>
            /// </description></item>
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
            /// <para>The task ID that is returned when you create a real-time recording. This ID is required to stop the recording. Specify this parameter only when stopping a real-time recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9922c84c087044eda18659c128b56c84</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>A custom identifier that you can set for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

        }

        /// <summary>
        /// <para>Algorithm-related parameters for customizing task processing.</para>
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
            /// <para>Specifies whether to generate a chapter summary, which includes chapter titles and summaries for each chapter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoChaptersEnabled")]
            [Validation(Required=false)]
            public bool? AutoChaptersEnabled { get; set; }

            /// <summary>
            /// <para>Conversation content extraction parameters.</para>
            /// </summary>
            [NameInMap("ContentExtraction")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersContentExtraction ContentExtraction { get; set; }
            public class CreateTaskRequestParametersContentExtraction : TeaModel {
                /// <summary>
                /// <para>List of content extraction dimensions. Each dimension includes a name and definition.</para>
                /// </summary>
                [NameInMap("ExtractionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersContentExtractionExtractionContents> ExtractionContents { get; set; }
                public class CreateTaskRequestParametersContentExtractionExtractionContents : TeaModel {
                    /// <summary>
                    /// <para>Definition of the content extraction dimension.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    /// <summary>
                    /// <para>Name of the content extraction dimension.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>Description of the conversation scenario for content extraction.</para>
                /// </summary>
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

            /// <summary>
            /// <para>Parameters to control the custom prompt feature.</para>
            /// </summary>
            [NameInMap("CustomPrompt")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersCustomPrompt CustomPrompt { get; set; }
            public class CreateTaskRequestParametersCustomPrompt : TeaModel {
                /// <summary>
                /// <para>A list of custom prompt parameters.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersCustomPromptContents> Contents { get; set; }
                public class CreateTaskRequestParametersCustomPromptContents : TeaModel {
                    /// <summary>
                    /// <para>The model to use for the prompt.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tingwu-turbo</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>A custom name for the prompt, used to identify the corresponding output.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>summary-demo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The content of the custom prompt.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>总结一下下面的对话内容:{Transcription}</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    /// <summary>
                    /// <para>Specifies the format for the <c>{Transcription}</c> tag.</para>
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
            /// <para>Specifies whether to enable the custom prompt feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CustomPromptEnabled")]
            [Validation(Required=false)]
            public bool? CustomPromptEnabled { get; set; }

            /// <summary>
            /// <para>Extended parameters for advanced use cases. You do not typically need to configure these parameters.</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersExtraParams ExtraParams { get; set; }
            public class CreateTaskRequestParametersExtraParams : TeaModel {
                [NameInMap("DomainEducationEnabled")]
                [Validation(Required=false)]
                public bool? DomainEducationEnabled { get; set; }

                /// <summary>
                /// <para>Full-text summary format.</para>
                /// </summary>
                [NameInMap("FullTextSummaryFormat")]
                [Validation(Required=false)]
                public string FullTextSummaryFormat { get; set; }

                /// <summary>
                /// <para>Maximum number of keywords.</para>
                /// </summary>
                [NameInMap("MaxKeywords")]
                [Validation(Required=false)]
                public int? MaxKeywords { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable nfix. You do not typically need to configure this parameter.</para>
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

                [NameInMap("TranslationHotwordMap")]
                [Validation(Required=false)]
                public CreateTaskRequestParametersExtraParamsTranslationHotwordMap TranslationHotwordMap { get; set; }
                public class CreateTaskRequestParametersExtraParamsTranslationHotwordMap : TeaModel {
                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("bizUserId")]
                    [Validation(Required=false)]
                    public string BizUserId { get; set; }

                }

            }

            /// <summary>
            /// <para>Identity recognition parameters.</para>
            /// </summary>
            [NameInMap("IdentityRecognition")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersIdentityRecognition IdentityRecognition { get; set; }
            public class CreateTaskRequestParametersIdentityRecognition : TeaModel {
                /// <summary>
                /// <para>List of identities, including identity name and description.</para>
                /// </summary>
                [NameInMap("IdentityContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersIdentityRecognitionIdentityContents> IdentityContents { get; set; }
                public class CreateTaskRequestParametersIdentityRecognitionIdentityContents : TeaModel {
                    /// <summary>
                    /// <para>Identity description.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Identity name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Description of the scenario for identity recognition.</para>
                /// </summary>
                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

            }

            /// <summary>
            /// <para>Enable identity recognition.</para>
            /// </summary>
            [NameInMap("IdentityRecognitionEnabled")]
            [Validation(Required=false)]
            public bool? IdentityRecognitionEnabled { get; set; }

            [NameInMap("LlmOutputLanguage")]
            [Validation(Required=false)]
            public string LlmOutputLanguage { get; set; }

            /// <summary>
            /// <para>Parameters for the intelligent minutes feature, which supports processing for action items, keywords, and key points. If <c>MeetingAssistanceEnabled</c> is set to <c>true</c> but you do not specify this object, all analysis types are enabled by default.</para>
            /// </summary>
            [NameInMap("MeetingAssistance")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersMeetingAssistance MeetingAssistance { get; set; }
            public class CreateTaskRequestParametersMeetingAssistance : TeaModel {
                /// <summary>
                /// <para>The types of analysis to perform when the intelligent minutes feature is enabled. Supported values: <c>Actions</c> (action items) and <c>KeyInformation</c> (key information, including keywords and key points).</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to generate intelligent minutes, which include keywords, key points, and action items.</para>
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
            /// <para>Specifies whether to enable PPT extraction. If enabled, the service extracts slides from the video file and generates corresponding summaries. This feature applies only to offline transcription tasks with a video source file and has no effect on other task types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PptExtractionEnabled")]
            [Validation(Required=false)]
            public bool? PptExtractionEnabled { get; set; }

            /// <summary>
            /// <para>Service quality inspection parameters.</para>
            /// </summary>
            [NameInMap("ServiceInspection")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersServiceInspection ServiceInspection { get; set; }
            public class CreateTaskRequestParametersServiceInspection : TeaModel {
                /// <summary>
                /// <para>List of inspection dimensions for service quality inspection. Each dimension includes a name and definition, which tells the Large Language Model how to evaluate whether the dimension is met.</para>
                /// </summary>
                [NameInMap("InspectionContents")]
                [Validation(Required=false)]
                public List<CreateTaskRequestParametersServiceInspectionInspectionContents> InspectionContents { get; set; }
                public class CreateTaskRequestParametersServiceInspectionInspectionContents : TeaModel {
                    /// <summary>
                    /// <para>Definition of the inspection dimension.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Name of the inspection dimension.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>Description of the inspection goals and focus areas for service quality inspection.</para>
                /// </summary>
                [NameInMap("InspectionIntroduction")]
                [Validation(Required=false)]
                public string InspectionIntroduction { get; set; }

                /// <summary>
                /// <para>Description of the conversation scenario for service quality inspection.</para>
                /// </summary>
                [NameInMap("SceneIntroduction")]
                [Validation(Required=false)]
                public string SceneIntroduction { get; set; }

                [NameInMap("SpeakerMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> SpeakerMap { get; set; }

            }

            /// <summary>
            /// <para>Enable service quality inspection. Default is false.</para>
            /// </summary>
            [NameInMap("ServiceInspectionEnabled")]
            [Validation(Required=false)]
            public bool? ServiceInspectionEnabled { get; set; }

            /// <summary>
            /// <para>Parameters for the summarization feature.</para>
            /// </summary>
            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersSummarization Summarization { get; set; }
            public class CreateTaskRequestParametersSummarization : TeaModel {
                /// <summary>
                /// <para>The types of summaries to generate. This parameter is required when summarization is enabled. Supported types include <c>Paragraph</c> (full-text summary), <c>Conversational</c> (speaker summary), and <c>QuestionsAnswering</c> (Q\&amp;A summary).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Paragraph</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public List<string> Types { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the summarization feature, which can generate results such as a full-text summary and a speaker summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SummarizationEnabled")]
            [Validation(Required=false)]
            public bool? SummarizationEnabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the spoken-to-written conversion feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TextPolishEnabled")]
            [Validation(Required=false)]
            public bool? TextPolishEnabled { get; set; }

            /// <summary>
            /// <para>Parameters for transcoding source audio/video files or audio streams.</para>
            /// </summary>
            [NameInMap("Transcoding")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscoding Transcoding { get; set; }
            public class CreateTaskRequestParametersTranscoding : TeaModel {
                /// <summary>
                /// <para>Specifies whether to generate and save an audio waveform from the source audio/video file or audio stream. This parameter is optional for offline transcription and real-time recording tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SpectrumEnabled")]
                [Validation(Required=false)]
                public bool? SpectrumEnabled { get; set; }

                /// <summary>
                /// <para>Specifies the target format for the transcoded audio. Set to <c>mp3</c> to transcode the source audio into MP3 format for storage. This parameter is optional for offline transcription and real-time recording tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp3</para>
                /// </summary>
                [NameInMap("TargetAudioFormat")]
                [Validation(Required=false)]
                public string TargetAudioFormat { get; set; }

                /// <summary>
                /// <para>Specifies the target format for the transcoded video. Set to <c>mp4</c> to transcode the source video into MP4 format for storage. This parameter applies only to offline transcription tasks with a video source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("TargetVideoFormat")]
                [Validation(Required=false)]
                public string TargetVideoFormat { get; set; }

                /// <summary>
                /// <para>Specifies whether to extract and save video thumbnails from the source video file. This parameter applies only to offline transcription tasks with a video source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("VideoThumbnailEnabled")]
                [Validation(Required=false)]
                public bool? VideoThumbnailEnabled { get; set; }

            }

            /// <summary>
            /// <para>Parameters to control the speech transcription process.</para>
            /// </summary>
            [NameInMap("Transcription")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranscription Transcription { get; set; }
            public class CreateTaskRequestParametersTranscription : TeaModel {
                /// <summary>
                /// <para>Specifies the level of detail for speech transcription results for the active speaker in a real-time recording scenario.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results only when a complete sentence is recognized.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns both intermediate and final results as they are recognized.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter applies only to real-time recordings when <c>MultipleStreamsEnabled</c> is set to <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable sound event detection, which identifies non-speech events in the audio, such as music.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AudioEventDetectionEnabled")]
                [Validation(Required=false)]
                public bool? AudioEventDetectionEnabled { get; set; }

                /// <summary>
                /// <para>Parameters for the speaker diarization feature.</para>
                /// </summary>
                [NameInMap("Diarization")]
                [Validation(Required=false)]
                public CreateTaskRequestParametersTranscriptionDiarization Diarization { get; set; }
                public class CreateTaskRequestParametersTranscriptionDiarization : TeaModel {
                    /// <summary>
                    /// <para>Specifies the number of speakers to identify.</para>
                    /// <para>If this parameter is not set, speakers are not differentiated in the transcript.</para>
                    /// <para>Set the value to <c>0</c> to identify an unknown number of speakers.</para>
                    /// <para>Set the value to <c>2</c> to identify two speakers.</para>
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

                [NameInMap("DisfluencyEnabled")]
                [Validation(Required=false)]
                public bool? DisfluencyEnabled { get; set; }

                /// <summary>
                /// <para>Set the speech transcription model to improve accuracy for specific domains.</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>Specifies the level of detail for the speech transcription results. Default value: <c>1</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results only when a complete sentence is recognized.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns both intermediate and final results as they are recognized.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                /// <summary>
                /// <para>The ID of the hotword list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ce9c2a34b6d847bf92a77d0a196f****</para>
                /// </summary>
                [NameInMap("PhraseId")]
                [Validation(Required=false)]
                public string PhraseId { get; set; }

                /// <summary>
                /// <para>Enable sensitive word filtering during speech transcription. Enabled by default.</para>
                /// </summary>
                [NameInMap("ProfanityFilterEnabled")]
                [Validation(Required=false)]
                public bool? ProfanityFilterEnabled { get; set; }

                [NameInMap("RealtimeDiarizationEnabled")]
                [Validation(Required=false)]
                public bool? RealtimeDiarizationEnabled { get; set; }

            }

            /// <summary>
            /// <para>Parameters to control the translation feature.</para>
            /// </summary>
            [NameInMap("Translation")]
            [Validation(Required=false)]
            public CreateTaskRequestParametersTranslation Translation { get; set; }
            public class CreateTaskRequestParametersTranslation : TeaModel {
                /// <summary>
                /// <para>Specifies the level of detail for real-time translation results for the active speaker.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results only for complete sentences.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns both intermediate and final results.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter applies only to real-time recordings when <c>MultipleStreamsEnabled</c> is set to <c>true</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AdditionalStreamOutputLevel")]
                [Validation(Required=false)]
                public int? AdditionalStreamOutputLevel { get; set; }

                /// <summary>
                /// <para>Specifies the level of detail for real-time translation results. Default value: <c>1</c>.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Returns results only for complete sentences.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Returns both intermediate and final results.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter applies only to real-time recordings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputLevel")]
                [Validation(Required=false)]
                public int? OutputLevel { get; set; }

                /// <summary>
                /// <para>The target languages for translation. This parameter is required if translation is enabled. Supported languages include Chinese, English, and Japanese.</para>
                /// </summary>
                [NameInMap("TargetLanguages")]
                [Validation(Required=false)]
                public List<string> TargetLanguages { get; set; }

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
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>start</b>: Creates a task. This is the default value and does not typically need to be set.</para>
        /// </description></item>
        /// <item><description><para><b>stop</b>: Stops a real-time recording task. This value is used only for real-time tasks. To end the recording, set this parameter to <c>stop</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>offline</b>: An offline task, such as an offline transcription.</para>
        /// </description></item>
        /// <item><description><para><b>realtime</b>: A real-time task, such as a real-time recording.</para>
        /// </description></item>
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
