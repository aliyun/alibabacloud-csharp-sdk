// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryCloudRecordTextResponseBodyParagraphList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7940</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172045153000</para>
            /// </summary>
            [NameInMap("NextTtoken")]
            [Validation(Required=false)]
            public long? NextTtoken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>嘿！你好，这里是小钉</para>
            /// </summary>
            [NameInMap("Paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44444</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("SentenceList")]
            [Validation(Required=false)]
            public List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryCloudRecordTextResponseBodyParagraphListSentenceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7940</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这里是小钉</para>
                /// </summary>
                [NameInMap("Sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7940</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("WordList")]
                [Validation(Required=false)]
                public List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7940</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7940</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这里</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1631172050535000#0</para>
                    /// </summary>
                    [NameInMap("WordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7940</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
