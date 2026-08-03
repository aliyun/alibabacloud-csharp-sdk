// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachScriptResponseBody : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("appendQuestionFlag")]
        [Validation(Required=false)]
        public bool? AppendQuestionFlag { get; set; }

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

        [NameInMap("closingRemarks")]
        [Validation(Required=false)]
        public string ClosingRemarks { get; set; }

        [NameInMap("completeStrategy")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyCompleteStrategy CompleteStrategy { get; set; }
        public class GetAICoachScriptResponseBodyCompleteStrategy : TeaModel {
            [NameInMap("abnormalQuitSessionExpired")]
            [Validation(Required=false)]
            public int? AbnormalQuitSessionExpired { get; set; }

            [NameInMap("abnormalQuitSessionExpiredFlag")]
            [Validation(Required=false)]
            public bool? AbnormalQuitSessionExpiredFlag { get; set; }

            [NameInMap("clickCompleteAutoEnd")]
            [Validation(Required=false)]
            public bool? ClickCompleteAutoEnd { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("durationFlag")]
            [Validation(Required=false)]
            public bool? DurationFlag { get; set; }

            [NameInMap("fullCoverageAutoEnd")]
            [Validation(Required=false)]
            public bool? FullCoverageAutoEnd { get; set; }

        }

        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("customReplyRules")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodyCustomReplyRules> CustomReplyRules { get; set; }
        public class GetAICoachScriptResponseBodyCustomReplyRules : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public GetAICoachScriptResponseBodyCustomReplyRulesAction Action { get; set; }
            public class GetAICoachScriptResponseBodyCustomReplyRulesAction : TeaModel {
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public GetAICoachScriptResponseBodyCustomReplyRulesActionParameters Parameters { get; set; }
                public class GetAICoachScriptResponseBodyCustomReplyRulesActionParameters : TeaModel {
                    [NameInMap("assessPointId")]
                    [Validation(Required=false)]
                    public string AssessPointId { get; set; }

                    [NameInMap("customContent")]
                    [Validation(Required=false)]
                    public string CustomContent { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("logic")]
            [Validation(Required=false)]
            public string Logic { get; set; }

            [NameInMap("mainCondition")]
            [Validation(Required=false)]
            public GetAICoachScriptResponseBodyCustomReplyRulesMainCondition MainCondition { get; set; }
            public class GetAICoachScriptResponseBodyCustomReplyRulesMainCondition : TeaModel {
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public GetAICoachScriptResponseBodyCustomReplyRulesMainConditionParameters Parameters { get; set; }
                public class GetAICoachScriptResponseBodyCustomReplyRulesMainConditionParameters : TeaModel {
                    [NameInMap("assessPointId")]
                    [Validation(Required=false)]
                    public string AssessPointId { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("subCondition")]
            [Validation(Required=false)]
            public GetAICoachScriptResponseBodyCustomReplyRulesSubCondition SubCondition { get; set; }
            public class GetAICoachScriptResponseBodyCustomReplyRulesSubCondition : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("dialogueInputTextLimit")]
        [Validation(Required=false)]
        public int? DialogueInputTextLimit { get; set; }

        [NameInMap("dialogueTextFlag")]
        [Validation(Required=false)]
        public bool? DialogueTextFlag { get; set; }

        [NameInMap("dialogueTipFlag")]
        [Validation(Required=false)]
        public bool? DialogueTipFlag { get; set; }

        [NameInMap("dialogueVoiceLimit")]
        [Validation(Required=false)]
        public int? DialogueVoiceLimit { get; set; }

        [NameInMap("evaluateReportFlag")]
        [Validation(Required=false)]
        public bool? EvaluateReportFlag { get; set; }

        [NameInMap("expressiveness")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Expressiveness { get; set; }

        [NameInMap("expressivenessList")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodyExpressivenessList> ExpressivenessList { get; set; }
        public class GetAICoachScriptResponseBodyExpressivenessList : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("expressivenessId")]
            [Validation(Required=false)]
            public string ExpressivenessId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("extendCustomNameMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendCustomNameMap { get; set; }

        [NameInMap("gifDynamicUrl")]
        [Validation(Required=false)]
        public string GifDynamicUrl { get; set; }

        [NameInMap("gifStaticUrl")]
        [Validation(Required=false)]
        public string GifStaticUrl { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        [NameInMap("interactionInputTypes")]
        [Validation(Required=false)]
        public List<string> InteractionInputTypes { get; set; }

        [NameInMap("interactionType")]
        [Validation(Required=false)]
        public int? InteractionType { get; set; }

        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("openingRemarks")]
        [Validation(Required=false)]
        public string OpeningRemarks { get; set; }

        [NameInMap("orderAckFlag")]
        [Validation(Required=false)]
        public bool? OrderAckFlag { get; set; }

        [NameInMap("pointCoveredFlag")]
        [Validation(Required=false)]
        public bool? PointCoveredFlag { get; set; }

        [NameInMap("pointDeductionRuleList")]
        [Validation(Required=false)]
        public List<GetAICoachScriptResponseBodyPointDeductionRuleList> PointDeductionRuleList { get; set; }
        public class GetAICoachScriptResponseBodyPointDeductionRuleList : TeaModel {
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

            [NameInMap("scriptPointId")]
            [Validation(Required=false)]
            public string ScriptPointId { get; set; }

            [NameInMap("sortNo")]
            [Validation(Required=false)]
            public int? SortNo { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

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

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("scoreConfig")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyScoreConfig ScoreConfig { get; set; }
        public class GetAICoachScriptResponseBodyScoreConfig : TeaModel {
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("levelEnabled")]
            [Validation(Required=false)]
            public bool? LevelEnabled { get; set; }

            [NameInMap("levels")]
            [Validation(Required=false)]
            public List<GetAICoachScriptResponseBodyScoreConfigLevels> Levels { get; set; }
            public class GetAICoachScriptResponseBodyScoreConfigLevels : TeaModel {
                [NameInMap("max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("passScore")]
            [Validation(Required=false)]
            public string PassScore { get; set; }

        }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("sparringTipContent")]
        [Validation(Required=false)]
        public string SparringTipContent { get; set; }

        [NameInMap("sparringTipTitle")]
        [Validation(Required=false)]
        public string SparringTipTitle { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("studentThinkTimeFlag")]
        [Validation(Required=false)]
        public bool? StudentThinkTimeFlag { get; set; }

        [NameInMap("studentThinkTimeLimit")]
        [Validation(Required=false)]
        public int? StudentThinkTimeLimit { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("voiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

        [NameInMap("voiceLanguage")]
        [Validation(Required=false)]
        public string VoiceLanguage { get; set; }

        [NameInMap("weights")]
        [Validation(Required=false)]
        public GetAICoachScriptResponseBodyWeights Weights { get; set; }
        public class GetAICoachScriptResponseBodyWeights : TeaModel {
            [NameInMap("abilityEvaluation")]
            [Validation(Required=false)]
            public int? AbilityEvaluation { get; set; }

            [NameInMap("abilityEvaluationEnabled")]
            [Validation(Required=false)]
            public bool? AbilityEvaluationEnabled { get; set; }

            [NameInMap("assessmentPoint")]
            [Validation(Required=false)]
            public int? AssessmentPoint { get; set; }

            [NameInMap("assessmentPointEnabled")]
            [Validation(Required=false)]
            public bool? AssessmentPointEnabled { get; set; }

            [NameInMap("customReplyRuleEnabled")]
            [Validation(Required=false)]
            public bool? CustomReplyRuleEnabled { get; set; }

            [NameInMap("expressiveness")]
            [Validation(Required=false)]
            public int? Expressiveness { get; set; }

            [NameInMap("expressivenessEnabled")]
            [Validation(Required=false)]
            public bool? ExpressivenessEnabled { get; set; }

            [NameInMap("pointDeductionRule")]
            [Validation(Required=false)]
            public int? PointDeductionRule { get; set; }

            [NameInMap("pointDeductionRuleEnabled")]
            [Validation(Required=false)]
            public bool? PointDeductionRuleEnabled { get; set; }

            [NameInMap("similarPronunciationScoringEnabled")]
            [Validation(Required=false)]
            public bool? SimilarPronunciationScoringEnabled { get; set; }

            [NameInMap("standard")]
            [Validation(Required=false)]
            public int? Standard { get; set; }

            [NameInMap("standardEnabled")]
            [Validation(Required=false)]
            public bool? StandardEnabled { get; set; }

        }

    }

}
