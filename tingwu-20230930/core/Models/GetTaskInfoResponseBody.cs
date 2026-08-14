// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class GetTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskInfoResponseBodyData Data { get; set; }
        public class GetTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>TSC.AudioFormat</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Audio format invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>URL link to the MP3 conversion result</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.mp3?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.mp3?Expires=1706064016</a></para>
            /// </summary>
            [NameInMap("OutputMp3Path")]
            [Validation(Required=false)]
            public string OutputMp3Path { get; set; }

            /// <summary>
            /// <para>URL link to the MP4 conversion result</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.mp4?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.mp4?Expires=1706064016</a></para>
            /// </summary>
            [NameInMap("OutputMp4Path")]
            [Validation(Required=false)]
            public string OutputMp4Path { get; set; }

            /// <summary>
            /// <para>URL link to the audio waveform graph</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.spectrum?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.spectrum?Expires=1706064016</a></para>
            /// </summary>
            [NameInMap("OutputSpectrumPath")]
            [Validation(Required=false)]
            public string OutputSpectrumPath { get; set; }

            /// <summary>
            /// <para>URL link to the video thumbnail</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.png?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_20231222101008.png?Expires=1706064016</a></para>
            /// </summary>
            [NameInMap("OutputThumbnailPath")]
            [Validation(Required=false)]
            public string OutputThumbnailPath { get; set; }

            /// <summary>
            /// <para>A collection of results from various algorithm processing tasks. The result is returned as an HTTP link, which the user can use to parse the native result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetTaskInfoResponseBodyDataResult Result { get; set; }
            public class GetTaskInfoResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Link to the result of the Auto Chapters feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_AutoChapters_20231222101215.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_AutoChapters_20231222101215.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("AutoChapters")]
                [Validation(Required=false)]
                public string AutoChapters { get; set; }

                /// <summary>
                /// <para>URL link to the result of conversation content extraction</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39</a>_ ContentExtraction_20231222101215.json?Expires=1706064016</para>
                /// </summary>
                [NameInMap("ContentExtraction")]
                [Validation(Required=false)]
                public string ContentExtraction { get; set; }

                /// <summary>
                /// <para>Link to the result of the Custom prompt</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39</a>_ CustomPrompt_20231222101215.json?Expires=1706064016</para>
                /// </summary>
                [NameInMap("CustomPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                /// <summary>
                /// <para>The URL link to the identity recognition result.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39</a>_ IdentityRecognition_20231222101215.json?Expires=1706064016</para>
                /// </summary>
                [NameInMap("IdentityRecognition")]
                [Validation(Required=false)]
                public string IdentityRecognition { get; set; }

                /// <summary>
                /// <para>URL link to the result of Intelligent Meeting Summary</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_MeetingAssistance_20231222101112.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_MeetingAssistance_20231222101112.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("MeetingAssistance")]
                [Validation(Required=false)]
                public string MeetingAssistance { get; set; }

                /// <summary>
                /// <para>URL link to the result of video PPT extraction and summarization</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_PptExtraction_20231222101215.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_PptExtraction_20231222101215.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("PptExtraction")]
                [Validation(Required=false)]
                public string PptExtraction { get; set; }

                /// <summary>
                /// <para>Link to the result of service inspection</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39</a>_ ServiceInspection_20231222101215.json?Expires=1706064016</para>
                /// </summary>
                [NameInMap("ServiceInspection")]
                [Validation(Required=false)]
                public string ServiceInspection { get; set; }

                /// <summary>
                /// <para>Link to the result of LLM-based summarization.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Summarization_20231222101215.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Summarization_20231222101215.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("Summarization")]
                [Validation(Required=false)]
                public string Summarization { get; set; }

                /// <summary>
                /// <para>Link to the result of spoken-to-written text conversion</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_TextPolish_20231222101215.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_TextPolish_20231222101215.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("TextPolish")]
                [Validation(Required=false)]
                public string TextPolish { get; set; }

                /// <summary>
                /// <para>Link to the result of speech transcription.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Transcription_20231222101008.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Transcription_20231222101008.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("Transcription")]
                [Validation(Required=false)]
                public string Transcription { get; set; }

                /// <summary>
                /// <para>URL link to the result of text translation</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Translation_20231222101215.json?Expires=1706064016">http://xxxx.com/tingwu/output/1738248324/094e964bf0e04e39/094e964bf0e04e39_Translation_20231222101215.json?Expires=1706064016</a></para>
                /// </summary>
                [NameInMap("Translation")]
                [Validation(Required=false)]
                public string Translation { get; set; }

            }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5394c6ee0fb474899d42215a3925c7e</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The custom ID set by the user when creating the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>Task Status.</para>
            /// <list type="bullet">
            /// <item><description>ONGOING: The job is in progress.</description></item>
            /// <item><description>COMPLETED: The job is completed.</description></item>
            /// <item><description>FAILED: The job has failed.</description></item>
            /// <item><description>INVALID: The job is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>Status description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, used only for joint debugging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35124E1C-AE99-5D6C-A52E-BD689D8D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
