// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SpeechFileTranscriberLite20211221.Models
{
    public class GetTaskResultResponseBody : TeaModel {
        [NameInMap("BizDuration")]
        [Validation(Required=false)]
        public int? BizDuration { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetTaskResultResponseBodyResult Result { get; set; }
        public class GetTaskResultResponseBodyResult : TeaModel {
            [NameInMap("Paragraphs")]
            [Validation(Required=false)]
            public List<GetTaskResultResponseBodyResultParagraphs> Paragraphs { get; set; }
            public class GetTaskResultResponseBodyResultParagraphs : TeaModel {
                public long? BeginTIme { get; set; }
                public long? ChannelId { get; set; }
                public long? EndTime { get; set; }
                public string Text { get; set; }
            }
            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<GetTaskResultResponseBodyResultSentences> Sentences { get; set; }
            public class GetTaskResultResponseBodyResultSentences : TeaModel {
                public long? BeginTime { get; set; }
                public long? ChannelId { get; set; }
                public float? EmotionValue { get; set; }
                public long? EndTime { get; set; }
                public int? SilenceDuration { get; set; }
                public string SpeakerId { get; set; }
                public int? SpeechRate { get; set; }
                public string Text { get; set; }
            }
            [NameInMap("Words")]
            [Validation(Required=false)]
            public List<GetTaskResultResponseBodyResultWords> Words { get; set; }
            public class GetTaskResultResponseBodyResultWords : TeaModel {
                public long? BeginTime { get; set; }
                public long? ChannelId { get; set; }
                public long? EndTime { get; set; }
                public string Word { get; set; }
            }
        };

        [NameInMap("SolveTime")]
        [Validation(Required=false)]
        public long? SolveTime { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

        [NameInMap("StatusText")]
        [Validation(Required=false)]
        public string StatusText { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
