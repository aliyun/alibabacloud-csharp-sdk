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
                [NameInMap("answerName")]
                [Validation(Required=false)]
                public string AnswerName { get; set; }

                [NameInMap("answerWeight")]
                [Validation(Required=false)]
                public int? AnswerWeight { get; set; }

                [NameInMap("keywordValues")]
                [Validation(Required=false)]
                public List<GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesKeywordValues> KeywordValues { get; set; }
                public class GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesKeywordValues : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                [NameInMap("keywordWeight")]
                [Validation(Required=false)]
                public int? KeywordWeight { get; set; }

                [NameInMap("scoringRules")]
                [Validation(Required=false)]
                public List<GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesScoringRules> ScoringRules { get; set; }
                public class GetAICoachAssessmentPointResponseBodyAnswerListAnswerValuesScoringRules : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("enabledKeyword")]
            [Validation(Required=false)]
            public bool? EnabledKeyword { get; set; }

            [NameInMap("nameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            [NameInMap("operators")]
            [Validation(Required=false)]
            public string Operators { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetAICoachAssessmentPointResponseBodyAnswerListParameters> Parameters { get; set; }
            public class GetAICoachAssessmentPointResponseBodyAnswerListParameters : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("citations")]
        [Validation(Required=false)]
        public int? Citations { get; set; }

        [NameInMap("documentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        [NameInMap("documentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("kbId")]
        [Validation(Required=false)]
        public string KbId { get; set; }

        [NameInMap("kbType")]
        [Validation(Required=false)]
        public string KbType { get; set; }

        [NameInMap("knowledgeList")]
        [Validation(Required=false)]
        public List<string> KnowledgeList { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pointId")]
        [Validation(Required=false)]
        public string PointId { get; set; }

        [NameInMap("questionDescription")]
        [Validation(Required=false)]
        public string QuestionDescription { get; set; }

        [NameInMap("questionSample")]
        [Validation(Required=false)]
        public string QuestionSample { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
