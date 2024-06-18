// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMinutesSummaryResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public QueryMinutesSummaryResponseBodySummary Summary { get; set; }
        public class QueryMinutesSummaryResponseBodySummary : TeaModel {
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryActions Actions { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryActions : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("SentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("AutoChapters")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryAutoChapters> AutoChapters { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryAutoChapters : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Headline")]
                [Validation(Required=false)]
                public string Headline { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("ConversationalSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> ConversationalSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryConversationalSummary : TeaModel {
                [NameInMap("SpeakerId")]
                [Validation(Required=false)]
                public string SpeakerId { get; set; }

                [NameInMap("SpeakerName")]
                [Validation(Required=false)]
                public string SpeakerName { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("KeySentences")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryKeySentences KeySentences { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryKeySentences : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("SentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("ParagraphSummary")]
            [Validation(Required=false)]
            public string ParagraphSummary { get; set; }

            [NameInMap("QuestionsAnsweringSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> QuestionsAnsweringSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary : TeaModel {
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("SentenceIdsOfAnswer")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfAnswer { get; set; }

                [NameInMap("SentenceIdsOfQuestion")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfQuestion { get; set; }

            }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
