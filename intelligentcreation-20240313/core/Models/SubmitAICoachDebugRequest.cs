// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SubmitAICoachDebugRequest : TeaModel {
        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public long? DataType { get; set; }

        [NameInMap("deductionRule")]
        [Validation(Required=false)]
        public SubmitAICoachDebugRequestDeductionRule DeductionRule { get; set; }
        public class SubmitAICoachDebugRequestDeductionRule : TeaModel {
            [NameInMap("deductionRuleId")]
            [Validation(Required=false)]
            public string DeductionRuleId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("punishmentTypes")]
            [Validation(Required=false)]
            public List<string> PunishmentTypes { get; set; }

            [NameInMap("ruleValue")]
            [Validation(Required=false)]
            public string RuleValue { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("dialogueList")]
        [Validation(Required=false)]
        public List<SubmitAICoachDebugRequestDialogueList> DialogueList { get; set; }
        public class SubmitAICoachDebugRequestDialogueList : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("expressiveness")]
        [Validation(Required=false)]
        public SubmitAICoachDebugRequestExpressiveness Expressiveness { get; set; }
        public class SubmitAICoachDebugRequestExpressiveness : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("expressivenessId")]
            [Validation(Required=false)]
            public string ExpressivenessId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

        }

        [NameInMap("point")]
        [Validation(Required=false)]
        public SubmitAICoachDebugRequestPoint Point { get; set; }
        public class SubmitAICoachDebugRequestPoint : TeaModel {
            [NameInMap("answerList")]
            [Validation(Required=false)]
            public List<SubmitAICoachDebugRequestPointAnswerList> AnswerList { get; set; }
            public class SubmitAICoachDebugRequestPointAnswerList : TeaModel {
                [NameInMap("answerValues")]
                [Validation(Required=false)]
                public List<SubmitAICoachDebugRequestPointAnswerListAnswerValues> AnswerValues { get; set; }
                public class SubmitAICoachDebugRequestPointAnswerListAnswerValues : TeaModel {
                    [NameInMap("answerName")]
                    [Validation(Required=false)]
                    public string AnswerName { get; set; }

                    [NameInMap("answerWeight")]
                    [Validation(Required=false)]
                    public long? AnswerWeight { get; set; }

                    [NameInMap("keywordValues")]
                    [Validation(Required=false)]
                    public List<SubmitAICoachDebugRequestPointAnswerListAnswerValuesKeywordValues> KeywordValues { get; set; }
                    public class SubmitAICoachDebugRequestPointAnswerListAnswerValuesKeywordValues : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("weight")]
                        [Validation(Required=false)]
                        public long? Weight { get; set; }

                    }

                    [NameInMap("keywordWeight")]
                    [Validation(Required=false)]
                    public long? KeywordWeight { get; set; }

                    [NameInMap("scoringRules")]
                    [Validation(Required=false)]
                    public List<SubmitAICoachDebugRequestPointAnswerListAnswerValuesScoringRules> ScoringRules { get; set; }
                    public class SubmitAICoachDebugRequestPointAnswerListAnswerValuesScoringRules : TeaModel {
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
                public List<SubmitAICoachDebugRequestPointAnswerListParameters> Parameters { get; set; }
                public class SubmitAICoachDebugRequestPointAnswerListParameters : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("score")]
                [Validation(Required=false)]
                public long? Score { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

            }

            [NameInMap("knowledgeList")]
            [Validation(Required=false)]
            public List<string> KnowledgeList { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("questionSample")]
            [Validation(Required=false)]
            public string QuestionSample { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

    }

}
