// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachScriptResponseBody : TeaModel {
        [NameInMap("appendQuestionFlag")]
        [Validation(Required=false)]
        public bool? AppendQuestionFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>point</para>
        /// </summary>
        [NameInMap("assessmentScope")]
        [Validation(Required=false)]
        public string AssessmentScope { get; set; }

        [NameInMap("checkCheatConfig")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyCheckCheatConfig CheckCheatConfig { get; set; }
        public class GetAICoachScriptResponseBodyCheckCheatConfig : TeaModel {
            [NameInMap("checkImage")]
            [Validation(Required=false)]
            public bool? CheckImage { get; set; }

            [NameInMap("checkVoice")]
            [Validation(Required=false)]
            public bool? CheckVoice { get; set; }

        }

        [NameInMap("completeStrategy")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyCompleteStrategy CompleteStrategy { get; set; }
        public class GetAICoachScriptResponseBodyCompleteStrategy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("abnormalQuitSessionExpired")]
            [Validation(Required=false)]
            public int? AbnormalQuitSessionExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("abnormalQuitSessionExpiredFlag")]
            [Validation(Required=false)]
            public bool? AbnormalQuitSessionExpiredFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("clickCompleteAutoEnd")]
            [Validation(Required=false)]
            public bool? ClickCompleteAutoEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("durationFlag")]
            [Validation(Required=false)]
            public bool? DurationFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("fullCoverageAutoEnd")]
            [Validation(Required=false)]
            public bool? FullCoverageAutoEnd { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://demo.com">https://demo.com</a></para>
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("dialogueInputTextLimit")]
        [Validation(Required=false)]
        public int? DialogueInputTextLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dialogueTextFlag")]
        [Validation(Required=false)]
        public bool? DialogueTextFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dialogueTipFlag")]
        [Validation(Required=false)]
        public bool? DialogueTipFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("dialogueVoiceLimit")]
        [Validation(Required=false)]
        public int? DialogueVoiceLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("evaluateReportFlag")]
        [Validation(Required=false)]
        public bool? EvaluateReportFlag { get; set; }

        [NameInMap("expressiveness")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Expressiveness { get; set; }

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
        /// <para>coach</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        [NameInMap("interactionInputTypes")]
        [Validation(Required=false)]
        public List<string> InteractionInputTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("interactionType")]
        [Validation(Required=false)]
        public int? InteractionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("orderAckFlag")]
        [Validation(Required=false)]
        public bool? OrderAckFlag { get; set; }

        [NameInMap("pointDeductionRuleList")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodyPointDeductionRuleList> PointDeductionRuleList { get; set; }
        public class GetAICoachScriptResponseBodyPointDeductionRuleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("punishmentTypes")]
            [Validation(Required=false)]
            public List<string> PunishmentTypes { get; set; }

            [NameInMap("ruleValue")]
            [Validation(Required=false)]
            public string RuleValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("points")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodyPoints> Points { get; set; }
        public class GetAICoachScriptResponseBodyPoints : TeaModel {
            [NameInMap("answerList")]
            [Validation(Required=false)]
            public List<GetAICoachScriptResponseBodyPointsAnswerList> AnswerList { get; set; }
            public class GetAICoachScriptResponseBodyPointsAnswerList : TeaModel {
                [NameInMap("answerValues")]
                [Validation(Required=false)]
                public List<GetAICoachScriptResponseBodyPointsAnswerListAnswerValues> AnswerValues { get; set; }
                public class GetAICoachScriptResponseBodyPointsAnswerListAnswerValues : TeaModel {
                    [NameInMap("answerName")]
                    [Validation(Required=false)]
                    public string AnswerName { get; set; }

                    [NameInMap("answerWeight")]
                    [Validation(Required=false)]
                    public int? AnswerWeight { get; set; }

                    [NameInMap("keywordValues")]
                    [Validation(Required=false)]
                    public List<GetAICoachScriptResponseBodyPointsAnswerListAnswerValuesKeywordValues> KeywordValues { get; set; }
                    public class GetAICoachScriptResponseBodyPointsAnswerListAnswerValuesKeywordValues : TeaModel {
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
                    public List<GetAICoachScriptResponseBodyPointsAnswerListAnswerValuesScoringRules> ScoringRules { get; set; }
                    public class GetAICoachScriptResponseBodyPointsAnswerListAnswerValuesScoringRules : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("enabledKeyword")]
                [Validation(Required=false)]
                public bool? EnabledKeyword { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nameList")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                [NameInMap("operators")]
                [Validation(Required=false)]
                public string Operators { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public List<GetAICoachScriptResponseBodyPointsAnswerListParameters> Parameters { get; set; }
                public class GetAICoachScriptResponseBodyPointsAnswerListParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normalKnowledge</para>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("questionDescription")]
            [Validation(Required=false)]
            public string QuestionDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sortNo")]
            [Validation(Required=false)]
            public int? SortNo { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sampleDialogueList")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodySampleDialogueList> SampleDialogueList { get; set; }
        public class GetAICoachScriptResponseBodySampleDialogueList : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>coach</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("sparringTipContent")]
        [Validation(Required=false)]
        public string SparringTipContent { get; set; }

        [NameInMap("sparringTipTitle")]
        [Validation(Required=false)]
        public string SparringTipTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("studentThinkTimeFlag")]
        [Validation(Required=false)]
        public bool? StudentThinkTimeFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("studentThinkTimeLimit")]
        [Validation(Required=false)]
        public int? StudentThinkTimeLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("weights")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyWeights Weights { get; set; }
        public class GetAICoachScriptResponseBodyWeights : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("abilityEvaluation")]
            [Validation(Required=false)]
            public int? AbilityEvaluation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("abilityEvaluationEnabled")]
            [Validation(Required=false)]
            public bool? AbilityEvaluationEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("assessmentPoint")]
            [Validation(Required=false)]
            public int? AssessmentPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("expressiveness")]
            [Validation(Required=false)]
            public int? Expressiveness { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("expressivenessEnabled")]
            [Validation(Required=false)]
            public bool? ExpressivenessEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pointDeductionRule")]
            [Validation(Required=false)]
            public int? PointDeductionRule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("pointDeductionRuleEnabled")]
            [Validation(Required=false)]
            public bool? PointDeductionRuleEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("standard")]
            [Validation(Required=false)]
            public int? Standard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("standardEnabled")]
            [Validation(Required=false)]
            public bool? StandardEnabled { get; set; }

        }

    }

}
