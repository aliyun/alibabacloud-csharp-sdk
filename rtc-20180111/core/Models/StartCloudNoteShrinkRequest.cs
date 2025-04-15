// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudNoteShrinkRequest : TeaModel {
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
        public string AutoChaptersShrink { get; set; }

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
        public string CustomPromptShrink { get; set; }

        [NameInMap("LanguageHints")]
        [Validation(Required=false)]
        public List<string> LanguageHints { get; set; }

        [NameInMap("MeetingAssistance")]
        [Validation(Required=false)]
        public string MeetingAssistanceShrink { get; set; }

        [NameInMap("RealtimeSubtitle")]
        [Validation(Required=false)]
        public string RealtimeSubtitleShrink { get; set; }

        [NameInMap("ServiceInspection")]
        [Validation(Required=false)]
        public string ServiceInspectionShrink { get; set; }

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
        public StartCloudNoteShrinkRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudNoteShrinkRequestStorageConfig : TeaModel {
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
        public string SummarizationShrink { get; set; }

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
        public string TextPolishShrink { get; set; }

        [NameInMap("Transcription")]
        [Validation(Required=false)]
        public string TranscriptionShrink { get; set; }

    }

}
