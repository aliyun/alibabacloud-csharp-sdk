// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMinutesTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryMinutesTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryMinutesTextResponseBodyParagraphList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7910000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ParagraphId")]
            [Validation(Required=false)]
            public long? ParagraphId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44444</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("SentenceList")]
            [Validation(Required=false)]
            public List<QueryMinutesTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryMinutesTextResponseBodyParagraphListSentenceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7910000</para>
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
                /// <para>7910000</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("WordList")]
                [Validation(Required=false)]
                public List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryMinutesTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7910000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7910000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>单词</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172</para>
                    /// </summary>
                    [NameInMap("WordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7910000</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
