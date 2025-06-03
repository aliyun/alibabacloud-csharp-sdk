// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudNoteRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ws***z3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AutoChapters")]
        [Validation(Required=false)]
        public StartCloudNoteRequestAutoChapters AutoChapters { get; set; }
        public class StartCloudNoteRequestAutoChapters : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("CustomPrompt")]
        [Validation(Required=false)]
        public StartCloudNoteRequestCustomPrompt CustomPrompt { get; set; }
        public class StartCloudNoteRequestCustomPrompt : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CustomPromptContents")]
            [Validation(Required=false)]
            public List<StartCloudNoteRequestCustomPromptCustomPromptContents> CustomPromptContents { get; set; }
            public class StartCloudNoteRequestCustomPromptCustomPromptContents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tingwu-turbo</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>split-summary-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请帮我将下面的对话进行总结，根据发言人来总结:\n {Transcription}</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chat</para>
                /// </summary>
                [NameInMap("TransType")]
                [Validation(Required=false)]
                public string TransType { get; set; }

            }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        [NameInMap("LanguageHints")]
        [Validation(Required=false)]
        public List<string> LanguageHints { get; set; }

        [NameInMap("MeetingAssistance")]
        [Validation(Required=false)]
        public StartCloudNoteRequestMeetingAssistance MeetingAssistance { get; set; }
        public class StartCloudNoteRequestMeetingAssistance : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MeetingAssistanceType")]
            [Validation(Required=false)]
            public List<string> MeetingAssistanceType { get; set; }

        }

        [NameInMap("RealtimeSubtitle")]
        [Validation(Required=false)]
        public StartCloudNoteRequestRealtimeSubtitle RealtimeSubtitle { get; set; }
        public class StartCloudNoteRequestRealtimeSubtitle : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Translation")]
            [Validation(Required=false)]
            public StartCloudNoteRequestRealtimeSubtitleTranslation Translation { get; set; }
            public class StartCloudNoteRequestRealtimeSubtitleTranslation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TranslateLevel")]
                [Validation(Required=false)]
                public int? TranslateLevel { get; set; }

            }

        }

        [NameInMap("ServiceInspection")]
        [Validation(Required=false)]
        public StartCloudNoteRequestServiceInspection ServiceInspection { get; set; }
        public class StartCloudNoteRequestServiceInspection : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InspectionContents")]
            [Validation(Required=false)]
            public List<StartCloudNoteRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class StartCloudNoteRequestServiceInspectionInspectionContents : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售在开场白的时候主动向客户打招呼进行欢迎</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>到店欢迎-欢迎语</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请监测对话中销售人员表现是否接待热情、态度良好</para>
            /// </summary>
            [NameInMap("InspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>汽车门店线下销售场景</para>
            /// </summary>
            [NameInMap("SceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageConfig")]
        [Validation(Required=false)]
        public StartCloudNoteRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudNoteRequestStorageConfig : TeaModel {
            /// <summary>
            /// <para>accessKey。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAX***</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-bucket-for-recording</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// <para>secretKey。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APb6qWYEzKtYxE***</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        [NameInMap("Summarization")]
        [Validation(Required=false)]
        public StartCloudNoteRequestSummarization Summarization { get; set; }
        public class StartCloudNoteRequestSummarization : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public List<string> Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TextPolish")]
        [Validation(Required=false)]
        public StartCloudNoteRequestTextPolish TextPolish { get; set; }
        public class StartCloudNoteRequestTextPolish : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        [NameInMap("Transcription")]
        [Validation(Required=false)]
        public StartCloudNoteRequestTranscription Transcription { get; set; }
        public class StartCloudNoteRequestTranscription : TeaModel {
            [NameInMap("DiarizationEnabled")]
            [Validation(Required=false)]
            public bool? DiarizationEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b401a5da78e94xxxxc3129425c78b6a5</para>
            /// </summary>
            [NameInMap("PhraseId")]
            [Validation(Required=false)]
            public string PhraseId { get; set; }

            [NameInMap("SpeakerCount")]
            [Validation(Required=false)]
            public int? SpeakerCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TranscriptionLevel")]
            [Validation(Required=false)]
            public int? TranscriptionLevel { get; set; }

        }

    }

}
