// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMinutesSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public QueryMinutesSummaryResponseBodySummary Summary { get; set; }
        public class QueryMinutesSummaryResponseBodySummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryActions Actions { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryActions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7910000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7901100</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("AutoChapters")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryAutoChapters> AutoChapters { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryAutoChapters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7910000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>章节的一句话标题</para>
                /// </summary>
                [NameInMap("Headline")]
                [Validation(Required=false)]
                public string Headline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7901100</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>章节总结</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("ConversationalSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> ConversationalSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryConversationalSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("SpeakerId")]
                [Validation(Required=false)]
                public string SpeakerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发言人姓名</para>
                /// </summary>
                [NameInMap("SpeakerName")]
                [Validation(Required=false)]
                public string SpeakerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发言人对应的总结</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("KeySentences")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryKeySentences KeySentences { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryKeySentences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7910000</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7901100</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>全文摘要结果，全文摘要通过两三百字的篇幅将最重要的信息呈现出来，用于快速了解记录内容与主旨</para>
            /// </summary>
            [NameInMap("ParagraphSummary")]
            [Validation(Required=false)]
            public string ParagraphSummary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("QuestionsAnsweringSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> QuestionsAnsweringSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>问题</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>回答</para>
                /// </summary>
                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("SentenceIdsOfAnswer")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfAnswer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("SentenceIdsOfQuestion")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfQuestion { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
