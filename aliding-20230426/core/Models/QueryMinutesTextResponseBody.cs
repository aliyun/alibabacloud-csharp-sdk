// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMinutesTextResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryMinutesTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryMinutesTextResponseBodyParagraphList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("Paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("ParagraphId")]
            [Validation(Required=false)]
            public long? ParagraphId { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("SentenceList")]
            [Validation(Required=false)]
            public List<QueryMinutesTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryMinutesTextResponseBodyParagraphListSentenceList : TeaModel {
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
                public List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryMinutesTextResponseBodyParagraphListSentenceListWordList : TeaModel {
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

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
