// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordTextResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryCloudRecordTextResponseBodyParagraphList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("NextTtoken")]
            [Validation(Required=false)]
            public long? NextTtoken { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("Paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("SentenceList")]
            [Validation(Required=false)]
            public List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryCloudRecordTextResponseBodyParagraphListSentenceList : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("WordList")]
                [Validation(Required=false)]
                public List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    [NameInMap("WordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
