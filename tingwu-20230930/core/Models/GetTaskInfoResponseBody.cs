// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class GetTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskInfoResponseBodyData Data { get; set; }
        public class GetTaskInfoResponseBodyData : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("OutputMp3Path")]
            [Validation(Required=false)]
            public string OutputMp3Path { get; set; }

            [NameInMap("OutputMp4Path")]
            [Validation(Required=false)]
            public string OutputMp4Path { get; set; }

            [NameInMap("OutputSpectrumPath")]
            [Validation(Required=false)]
            public string OutputSpectrumPath { get; set; }

            [NameInMap("OutputThumbnailPath")]
            [Validation(Required=false)]
            public string OutputThumbnailPath { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetTaskInfoResponseBodyDataResult Result { get; set; }
            public class GetTaskInfoResponseBodyDataResult : TeaModel {
                [NameInMap("AutoChapters")]
                [Validation(Required=false)]
                public string AutoChapters { get; set; }

                [NameInMap("CustomPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                [NameInMap("MeetingAssistance")]
                [Validation(Required=false)]
                public string MeetingAssistance { get; set; }

                [NameInMap("PptExtraction")]
                [Validation(Required=false)]
                public string PptExtraction { get; set; }

                [NameInMap("ServiceInspection")]
                [Validation(Required=false)]
                public string ServiceInspection { get; set; }

                [NameInMap("Summarization")]
                [Validation(Required=false)]
                public string Summarization { get; set; }

                [NameInMap("TextPolish")]
                [Validation(Required=false)]
                public string TextPolish { get; set; }

                [NameInMap("Transcription")]
                [Validation(Required=false)]
                public string Transcription { get; set; }

                [NameInMap("Translation")]
                [Validation(Required=false)]
                public string Translation { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c5394c6ee0fb474899d42215a3925c7e</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35124E1C-AE99-5D6C-A52E-BD689D8D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
