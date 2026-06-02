// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class MeetingFlashMinutesTextResponseBody : TeaModel {
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1778490366045000_62XXX</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<MeetingFlashMinutesTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class MeetingFlashMinutesTextResponseBodyParagraphList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7920000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这里是小钉</para>
            /// </summary>
            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<MeetingFlashMinutesTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class MeetingFlashMinutesTextResponseBodyParagraphListSentenceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7920000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这里是小钉</para>
                /// </summary>
                [NameInMap("sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7910000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("wordList")]
                [Validation(Required=false)]
                public List<MeetingFlashMinutesTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class MeetingFlashMinutesTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7920000</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7910000</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>单词</para>
                    /// </summary>
                    [NameInMap("word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

            [NameInMap("speakerDisplay")]
            [Validation(Required=false)]
            public MeetingFlashMinutesTextResponseBodyParagraphListSpeakerDisplay SpeakerDisplay { get; set; }
            public class MeetingFlashMinutesTextResponseBodyParagraphListSpeakerDisplay : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx">https://xxx</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>小钉</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7910000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("userId")]
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
