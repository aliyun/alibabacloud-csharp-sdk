// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAICoachScriptPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListAICoachScriptPageResponseBodyList> List { get; set; }
        public class ListAICoachScriptPageResponseBodyList : TeaModel {
            [NameInMap("appendQuestionFlag")]
            [Validation(Required=false)]
            public string AppendQuestionFlag { get; set; }

            [NameInMap("assessmentScope")]
            [Validation(Required=false)]
            public string AssessmentScope { get; set; }

            [NameInMap("closingRemarks")]
            [Validation(Required=false)]
            public string ClosingRemarks { get; set; }

            [NameInMap("completeStrategy")]
            [Validation(Required=false)]
            public ListAICoachScriptPageResponseBodyListCompleteStrategy CompleteStrategy { get; set; }
            public class ListAICoachScriptPageResponseBodyListCompleteStrategy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("clickCompleteAutoEnd")]
                [Validation(Required=false)]
                public bool? ClickCompleteAutoEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>75</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("fullCoverageAutoEnd")]
                [Validation(Required=false)]
                public bool? FullCoverageAutoEnd { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss-ata.alibaba.com/front/live/banner1.png">https://oss-ata.alibaba.com/front/live/banner1.png</a></para>
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("customReplyRules")]
            [Validation(Required=false)]
            public List<ListAICoachScriptPageResponseBodyListCustomReplyRules> CustomReplyRules { get; set; }
            public class ListAICoachScriptPageResponseBodyListCustomReplyRules : TeaModel {
                [NameInMap("action")]
                [Validation(Required=false)]
                public ListAICoachScriptPageResponseBodyListCustomReplyRulesAction Action { get; set; }
                public class ListAICoachScriptPageResponseBodyListCustomReplyRulesAction : TeaModel {
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public ListAICoachScriptPageResponseBodyListCustomReplyRulesActionParameters Parameters { get; set; }
                    public class ListAICoachScriptPageResponseBodyListCustomReplyRulesActionParameters : TeaModel {
                        [NameInMap("assessPoint")]
                        [Validation(Required=false)]
                        public string AssessPoint { get; set; }

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
                public ListAICoachScriptPageResponseBodyListCustomReplyRulesMainCondition MainCondition { get; set; }
                public class ListAICoachScriptPageResponseBodyListCustomReplyRulesMainCondition : TeaModel {
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public ListAICoachScriptPageResponseBodyListCustomReplyRulesMainConditionParameters Parameters { get; set; }
                    public class ListAICoachScriptPageResponseBodyListCustomReplyRulesMainConditionParameters : TeaModel {
                        [NameInMap("assessPoint")]
                        [Validation(Required=false)]
                        public string AssessPoint { get; set; }

                    }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("sortNo")]
                [Validation(Required=false)]
                public int? SortNo { get; set; }

                [NameInMap("subCondition")]
                [Validation(Required=false)]
                public ListAICoachScriptPageResponseBodyListCustomReplyRulesSubCondition SubCondition { get; set; }
                public class ListAICoachScriptPageResponseBodyListCustomReplyRulesSubCondition : TeaModel {
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("dialogueTextFlag")]
            [Validation(Required=false)]
            public bool? DialogueTextFlag { get; set; }

            [NameInMap("dialogueTipFlag")]
            [Validation(Required=false)]
            public bool? DialogueTipFlag { get; set; }

            [NameInMap("evaluateReportFlag")]
            [Validation(Required=false)]
            public bool? EvaluateReportFlag { get; set; }

            [NameInMap("expressiveness")]
            [Validation(Required=false)]
            public Dictionary<string, string> Expressiveness { get; set; }

            [NameInMap("gifDynamicUrl")]
            [Validation(Required=false)]
            public string GifDynamicUrl { get; set; }

            [NameInMap("gifStaticUrl")]
            [Validation(Required=false)]
            public string GifStaticUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-25 14:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-25 14:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>student</para>
            /// </summary>
            [NameInMap("initiator")]
            [Validation(Required=false)]
            public string Initiator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("interactionType")]
            [Validation(Required=false)]
            public string InteractionType { get; set; }

            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod-ydsf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("openingRemarks")]
            [Validation(Required=false)]
            public string OpeningRemarks { get; set; }

            [NameInMap("orderAckFlag")]
            [Validation(Required=false)]
            public bool? OrderAckFlag { get; set; }

            [NameInMap("sampleDialogueList")]
            [Validation(Required=false)]
            public List<ListAICoachScriptPageResponseBodyListSampleDialogueList> SampleDialogueList { get; set; }
            public class ListAICoachScriptPageResponseBodyListSampleDialogueList : TeaModel {
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>student</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            [NameInMap("scoreConfig")]
            [Validation(Required=false)]
            public ListAICoachScriptPageResponseBodyListScoreConfig ScoreConfig { get; set; }
            public class ListAICoachScriptPageResponseBodyListScoreConfig : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("levelEnabled")]
                [Validation(Required=false)]
                public bool? LevelEnabled { get; set; }

                [NameInMap("levels")]
                [Validation(Required=false)]
                public List<ListAICoachScriptPageResponseBodyListScoreConfigLevels> Levels { get; set; }
                public class ListAICoachScriptPageResponseBodyListScoreConfigLevels : TeaModel {
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
                public int? PassScore { get; set; }

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

            [NameInMap("studentThinkTimeFlag")]
            [Validation(Required=false)]
            public bool? StudentThinkTimeFlag { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("weights")]
            [Validation(Required=false)]
            public ListAICoachScriptPageResponseBodyListWeights Weights { get; set; }
            public class ListAICoachScriptPageResponseBodyListWeights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("assessmentPoint")]
                [Validation(Required=false)]
                public int? AssessmentPoint { get; set; }

                [NameInMap("assessmentPointEnabled")]
                [Validation(Required=false)]
                public bool? AssessmentPointEnabled { get; set; }

                [NameInMap("customReplyRuleEnabled")]
                [Validation(Required=false)]
                public bool? CustomReplyRuleEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>86A90C40-D1AB-50DA-A4B1-0D545F80F2FE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
