// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleDetailResponseBodyData Data { get; set; }
        public class GetRuleDetailResponseBodyData : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public GetRuleDetailResponseBodyDataConditions Conditions { get; set; }
            public class GetRuleDetailResponseBodyDataConditions : TeaModel {
                [NameInMap("ConditionBasicInfo")]
                [Validation(Required=false)]
                public List<GetRuleDetailResponseBodyDataConditionsConditionBasicInfo> ConditionBasicInfo { get; set; }
                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfo : TeaModel {
                    [NameInMap("CheckRange")]
                    [Validation(Required=false)]
                    public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRange CheckRange { get; set; }
                    public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRange : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Absolute")]
                        [Validation(Required=false)]
                        public bool? Absolute { get; set; }

                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeAnchor Anchor { get; set; }
                        public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeAnchor : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>7</para>
                            /// </summary>
                            [NameInMap("AnchorCid")]
                            [Validation(Required=false)]
                            public string AnchorCid { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("HitTime")]
                            [Validation(Required=false)]
                            public int? HitTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>AFTER</para>
                            /// </summary>
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                        }

                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeRange Range { get; set; }
                        public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeRange : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("From")]
                            [Validation(Required=false)]
                            public int? From { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("To")]
                            [Validation(Required=false)]
                            public int? To { get; set; }

                        }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("ConditionInfoCid")]
                    [Validation(Required=false)]
                    public string ConditionInfoCid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("OperLambda")]
                    [Validation(Required=false)]
                    public string OperLambda { get; set; }

                    [NameInMap("Operators")]
                    [Validation(Required=false)]
                    public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperators Operators { get; set; }
                    public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperators : TeaModel {
                        [NameInMap("OperatorBasicInfo")]
                        [Validation(Required=false)]
                        public List<GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfo> OperatorBasicInfo { get; set; }
                        public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>8</para>
                            /// </summary>
                            [NameInMap("Oid")]
                            [Validation(Required=false)]
                            public string Oid { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>operator demo</para>
                            /// </summary>
                            [NameInMap("OperName")]
                            [Validation(Required=false)]
                            public string OperName { get; set; }

                            [NameInMap("Param")]
                            [Validation(Required=false)]
                            public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParam Param { get; set; }
                            public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParam : TeaModel {
                                [NameInMap("AntModelInfo")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamAntModelInfo AntModelInfo { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamAntModelInfo : TeaModel {
                                    [NameInMap("AntModelInfo")]
                                    [Validation(Required=false)]
                                    public List<string> AntModelInfo { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Average")]
                                [Validation(Required=false)]
                                public bool? Average { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>DIALOGUE</para>
                                /// </summary>
                                [NameInMap("BeginType")]
                                [Validation(Required=false)]
                                public string BeginType { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("CheckType")]
                                [Validation(Required=false)]
                                public int? CheckType { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>gt</para>
                                /// </summary>
                                [NameInMap("CompareOperator")]
                                [Validation(Required=false)]
                                public string CompareOperator { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("ContextChatMatch")]
                                [Validation(Required=false)]
                                public bool? ContextChatMatch { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1000</para>
                                /// </summary>
                                [NameInMap("DelayTime")]
                                [Validation(Required=false)]
                                public int? DelayTime { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("DifferentRole")]
                                [Validation(Required=false)]
                                public bool? DifferentRole { get; set; }

                                [NameInMap("Excludes")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamExcludes Excludes { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamExcludes : TeaModel {
                                    [NameInMap("Excludes")]
                                    [Validation(Required=false)]
                                    public List<string> Excludes { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>3</para>
                                /// </summary>
                                [NameInMap("From")]
                                [Validation(Required=false)]
                                public int? From { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("FromEnd")]
                                [Validation(Required=false)]
                                public bool? FromEnd { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("HitTime")]
                                [Validation(Required=false)]
                                public int? HitTime { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("InSentence")]
                                [Validation(Required=false)]
                                public bool? InSentence { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>5000</para>
                                /// </summary>
                                [NameInMap("Interval")]
                                [Validation(Required=false)]
                                public int? Interval { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("KeywordExtension")]
                                [Validation(Required=false)]
                                public bool? KeywordExtension { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>3</para>
                                /// </summary>
                                [NameInMap("KeywordMatchSize")]
                                [Validation(Required=false)]
                                public int? KeywordMatchSize { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>8</para>
                                /// </summary>
                                [NameInMap("MaxEmotionChangeValue")]
                                [Validation(Required=false)]
                                public int? MaxEmotionChangeValue { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>4</para>
                                /// </summary>
                                [NameInMap("MinWordSize")]
                                [Validation(Required=false)]
                                public int? MinWordSize { get; set; }

                                [NameInMap("NotRegex")]
                                [Validation(Required=false)]
                                public string NotRegex { get; set; }

                                [NameInMap("OperKeyWords")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamOperKeyWords OperKeyWords { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamOperKeyWords : TeaModel {
                                    [NameInMap("OperKeyWord")]
                                    [Validation(Required=false)]
                                    public List<string> OperKeyWord { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xxx</para>
                                /// </summary>
                                [NameInMap("Phrase")]
                                [Validation(Required=false)]
                                public string Phrase { get; set; }

                                [NameInMap("Pvalues")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamPvalues Pvalues { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamPvalues : TeaModel {
                                    [NameInMap("Pvalues")]
                                    [Validation(Required=false)]
                                    public List<string> Pvalues { get; set; }

                                }

                                [NameInMap("References")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamReferences References { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamReferences : TeaModel {
                                    [NameInMap("Reference")]
                                    [Validation(Required=false)]
                                    public List<string> Reference { get; set; }

                                }

                                [NameInMap("Regex")]
                                [Validation(Required=false)]
                                public string Regex { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>80</para>
                                /// </summary>
                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public int? Score { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>90</para>
                                /// </summary>
                                [NameInMap("Similarity_threshold")]
                                [Validation(Required=false)]
                                public float? SimilarityThreshold { get; set; }

                                [NameInMap("SimilarlySentences")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamSimilarlySentences SimilarlySentences { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamSimilarlySentences : TeaModel {
                                    [NameInMap("SimilarlySentence")]
                                    [Validation(Required=false)]
                                    public List<string> SimilarlySentence { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Target")]
                                [Validation(Required=false)]
                                public int? Target { get; set; }

                                [NameInMap("TargetRole")]
                                [Validation(Required=false)]
                                public string TargetRole { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>4</para>
                                /// </summary>
                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public float? Threshold { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>280</para>
                                /// </summary>
                                [NameInMap("VelocityInMint")]
                                [Validation(Required=false)]
                                public int? VelocityInMint { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>REGULAR_EXPRESSION</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public GetRuleDetailResponseBodyDataRules Rules { get; set; }
            public class GetRuleDetailResponseBodyDataRules : TeaModel {
                [NameInMap("RuleBasicInfo")]
                [Validation(Required=false)]
                public List<GetRuleDetailResponseBodyDataRulesRuleBasicInfo> RuleBasicInfo { get; set; }
                public class GetRuleDetailResponseBodyDataRulesRuleBasicInfo : TeaModel {
                    [NameInMap("BusinessCategories")]
                    [Validation(Required=false)]
                    public GetRuleDetailResponseBodyDataRulesRuleBasicInfoBusinessCategories BusinessCategories { get; set; }
                    public class GetRuleDetailResponseBodyDataRulesRuleBasicInfoBusinessCategories : TeaModel {
                        [NameInMap("BusinessCategoryBasicInfo")]
                        [Validation(Required=false)]
                        public List<GetRuleDetailResponseBodyDataRulesRuleBasicInfoBusinessCategoriesBusinessCategoryBasicInfo> BusinessCategoryBasicInfo { get; set; }
                        public class GetRuleDetailResponseBodyDataRulesRuleBasicInfoBusinessCategoriesBusinessCategoryBasicInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>264971810</para>
                            /// </summary>
                            [NameInMap("Bid")]
                            [Validation(Required=false)]
                            public int? Bid { get; set; }

                            [NameInMap("BusinessName")]
                            [Validation(Required=false)]
                            public string BusinessName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("ServiceType")]
                            [Validation(Required=false)]
                            public int? ServiceType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public string Rid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7&amp;&amp;!8</para>
                    /// </summary>
                    [NameInMap("RuleLambda")]
                    [Validation(Required=false)]
                    public string RuleLambda { get; set; }

                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public GetRuleDetailResponseBodyDataRulesRuleBasicInfoTriggers Triggers { get; set; }
                    public class GetRuleDetailResponseBodyDataRulesRuleBasicInfoTriggers : TeaModel {
                        [NameInMap("Trigger")]
                        [Validation(Required=false)]
                        public List<string> Trigger { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4987D326-83D9-4A42-B9A5-0B27F9B40539</para>
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
