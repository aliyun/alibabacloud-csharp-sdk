// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachAssessmentPointResponseBody : TeaModel {
        [NameInMap("answerList")]
        [Validation(Required=false)]
        public List<GetAICoachAssessmentPointResponseBodyAnswerList> AnswerList { get; set; }
        public class GetAICoachAssessmentPointResponseBodyAnswerList : TeaModel {
            [NameInMap("answerValues")]
            [Validation(Required=false)]
            public List<GetAICoachAssessmentPointResponseBodyAnswerListAnswerValues> AnswerValues { get; set; }
            public class GetAICoachAssessmentPointResponseBodyAnswerListAnswerValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("answerName")]
                [Validation(Required=false)]
                public string AnswerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("answerWeight")]
                [Validation(Required=false)]
                public int? AnswerWeight { get; set; }

                [NameInMap("keywordValues")]
                [Validation(Required=false)]
                public List<GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesKeywordValues> KeywordValues { get; set; }
                public class GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesKeywordValues : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("keywordWeight")]
                [Validation(Required=false)]
                public int? KeywordWeight { get; set; }

                [NameInMap("scoringRules")]
                [Validation(Required=false)]
                public List<GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesScoringRules> ScoringRules { get; set; }
                public class GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesScoringRules : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabledKeyword")]
            [Validation(Required=false)]
            public bool? EnabledKeyword { get; set; }

            [NameInMap("nameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("operators")]
            [Validation(Required=false)]
            public string Operators { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetAICoachAssessmentPointResponseBodyAnswerListParameters> Parameters { get; set; }
            public class GetAICoachAssessmentPointResponseBodyAnswerListParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>441323200602114284</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("citations")]
        [Validation(Required=false)]
        public int? Citations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("documentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("documentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-24 12:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-24 12:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("kbId")]
        [Validation(Required=false)]
        public string KbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Cloudcode</para>
        /// </summary>
        [NameInMap("kbType")]
        [Validation(Required=false)]
        public string KbType { get; set; }

        [NameInMap("knowledgeList")]
        [Validation(Required=false)]
        public List<string> KnowledgeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pointId")]
        [Validation(Required=false)]
        public string PointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("questionDescription")]
        [Validation(Required=false)]
        public string QuestionDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("questionSample")]
        [Validation(Required=false)]
        public string QuestionSample { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4830493A-728F-5F19-BBCC-1443292E9C49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
