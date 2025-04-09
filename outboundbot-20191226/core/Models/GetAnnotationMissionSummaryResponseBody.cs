// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAnnotationMissionSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAnnotationMissionSummaryResponseBodyData Data { get; set; }
        public class GetAnnotationMissionSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>b3f2c931-5180-43ca-b4aa-2baee2d73c8b</para>
            /// </summary>
            [NameInMap("AnnotationMissionId")]
            [Validation(Required=false)]
            public string AnnotationMissionId { get; set; }

            [NameInMap("AsrSummaryInfo")]
            [Validation(Required=false)]
            public GetAnnotationMissionSummaryResponseBodyDataAsrSummaryInfo AsrSummaryInfo { get; set; }
            public class GetAnnotationMissionSummaryResponseBodyDataAsrSummaryInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddCustomizationDataCount")]
                [Validation(Required=false)]
                public int? AddCustomizationDataCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddVocabularyDataCount")]
                [Validation(Required=false)]
                public int? AddVocabularyDataCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationInvalid")]
                [Validation(Required=false)]
                public int? AnnotationInvalid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CharacterCorrectRate")]
                [Validation(Required=false)]
                public int? CharacterCorrectRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CharacterErrorRate")]
                [Validation(Required=false)]
                public int? CharacterErrorRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChatTotalCount")]
                [Validation(Required=false)]
                public int? ChatTotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoAnnotation")]
                [Validation(Required=false)]
                public int? NoAnnotation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SentenceErrorRate")]
                [Validation(Required=false)]
                public int? SentenceErrorRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WordErrorRate")]
                [Validation(Required=false)]
                public int? WordErrorRate { get; set; }

            }

            [NameInMap("IntentSummaryInfo")]
            [Validation(Required=false)]
            public GetAnnotationMissionSummaryResponseBodyDataIntentSummaryInfo IntentSummaryInfo { get; set; }
            public class GetAnnotationMissionSummaryResponseBodyDataIntentSummaryInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationCorrectCount")]
                [Validation(Required=false)]
                public int? AnnotationCorrectCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationInvalid")]
                [Validation(Required=false)]
                public int? AnnotationInvalid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChatTotalCount")]
                [Validation(Required=false)]
                public int? ChatTotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IntentUserSayCount")]
                [Validation(Required=false)]
                public int? IntentUserSayCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IntentionNotCoveredCount")]
                [Validation(Required=false)]
                public int? IntentionNotCoveredCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchErrorCount")]
                [Validation(Required=false)]
                public int? MatchErrorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoAnnotation")]
                [Validation(Required=false)]
                public int? NoAnnotation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TranslationUnrecognizedCount")]
                [Validation(Required=false)]
                public int? TranslationUnrecognizedCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>You are not authorized to perform this action. CDR:View privileges are required.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TagSummaryInfo")]
            [Validation(Required=false)]
            public GetAnnotationMissionSummaryResponseBodyDataTagSummaryInfo TagSummaryInfo { get; set; }
            public class GetAnnotationMissionSummaryResponseBodyDataTagSummaryInfo : TeaModel {
                [NameInMap("TagSummaryInfoDetailList")]
                [Validation(Required=false)]
                public List<GetAnnotationMissionSummaryResponseBodyDataTagSummaryInfoTagSummaryInfoDetailList> TagSummaryInfoDetailList { get; set; }
                public class GetAnnotationMissionSummaryResponseBodyDataTagSummaryInfoTagSummaryInfoDetailList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this action. CDR:View privileges are required.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
