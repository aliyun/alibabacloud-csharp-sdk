// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class GetTaskInfoResponseBody : TeaModel {
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

            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetTaskInfoResponseBodyDataResult Result { get; set; }
            public class GetTaskInfoResponseBodyDataResult : TeaModel {
                [NameInMap("AutoChapters")]
                [Validation(Required=false)]
                public string AutoChapters { get; set; }

                [NameInMap("MeetingAssistance")]
                [Validation(Required=false)]
                public string MeetingAssistance { get; set; }

                [NameInMap("PptExtraction")]
                [Validation(Required=false)]
                public string PptExtraction { get; set; }

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

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
