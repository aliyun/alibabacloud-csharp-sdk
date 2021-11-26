// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleDetailResponseBody : TeaModel {
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
                        [NameInMap("Absolute")]
                        [Validation(Required=false)]
                        public bool? Absolute { get; set; }
                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeAnchor Anchor { get; set; }
                        public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeAnchor : TeaModel {
                            [NameInMap("AnchorCid")]
                            [Validation(Required=false)]
                            public string AnchorCid { get; set; }

                            [NameInMap("HitTime")]
                            [Validation(Required=false)]
                            public int? HitTime { get; set; }

                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                        }
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeRange Range { get; set; }
                        public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoCheckRangeRange : TeaModel {
                            [NameInMap("From")]
                            [Validation(Required=false)]
                            public int? From { get; set; }

                            [NameInMap("To")]
                            [Validation(Required=false)]
                            public int? To { get; set; }

                        }
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }
                    };

                    [NameInMap("ConditionInfoCid")]
                    [Validation(Required=false)]
                    public string ConditionInfoCid { get; set; }

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
                            public string Oid { get; set; }
                            public string OperName { get; set; }
                            public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParam Param { get; set; }
                            public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParam : TeaModel {
                                [NameInMap("AntModelInfo")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamAntModelInfo AntModelInfo { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamAntModelInfo : TeaModel {
                                    [NameInMap("AntModelInfo")]
                                    [Validation(Required=false)]
                                    public List<string> AntModelInfo { get; set; }
                                };

                                [NameInMap("Average")]
                                [Validation(Required=false)]
                                public bool? Average { get; set; }

                                [NameInMap("BeginType")]
                                [Validation(Required=false)]
                                public string BeginType { get; set; }

                                [NameInMap("CheckType")]
                                [Validation(Required=false)]
                                public int? CheckType { get; set; }

                                [NameInMap("CompareOperator")]
                                [Validation(Required=false)]
                                public string CompareOperator { get; set; }

                                [NameInMap("ContextChatMatch")]
                                [Validation(Required=false)]
                                public bool? ContextChatMatch { get; set; }

                                [NameInMap("DelayTime")]
                                [Validation(Required=false)]
                                public int? DelayTime { get; set; }

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
                                };

                                [NameInMap("From")]
                                [Validation(Required=false)]
                                public int? From { get; set; }

                                [NameInMap("FromEnd")]
                                [Validation(Required=false)]
                                public bool? FromEnd { get; set; }

                                [NameInMap("HitTime")]
                                [Validation(Required=false)]
                                public int? HitTime { get; set; }

                                [NameInMap("InSentence")]
                                [Validation(Required=false)]
                                public bool? InSentence { get; set; }

                                [NameInMap("Interval")]
                                [Validation(Required=false)]
                                public int? Interval { get; set; }

                                [NameInMap("KeywordExtension")]
                                [Validation(Required=false)]
                                public bool? KeywordExtension { get; set; }

                                [NameInMap("KeywordMatchSize")]
                                [Validation(Required=false)]
                                public int? KeywordMatchSize { get; set; }

                                [NameInMap("MaxEmotionChangeValue")]
                                [Validation(Required=false)]
                                public int? MaxEmotionChangeValue { get; set; }

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
                                };

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
                                };

                                [NameInMap("References")]
                                [Validation(Required=false)]
                                public GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamReferences References { get; set; }
                                public class GetRuleDetailResponseBodyDataConditionsConditionBasicInfoOperatorsOperatorBasicInfoParamReferences : TeaModel {
                                    [NameInMap("Reference")]
                                    [Validation(Required=false)]
                                    public List<string> Reference { get; set; }
                                };

                                [NameInMap("Regex")]
                                [Validation(Required=false)]
                                public string Regex { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public int? Score { get; set; }

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
                                };

                                [NameInMap("Target")]
                                [Validation(Required=false)]
                                public int? Target { get; set; }

                                [NameInMap("TargetRole")]
                                [Validation(Required=false)]
                                public string TargetRole { get; set; }

                                [NameInMap("Threshold")]
                                [Validation(Required=false)]
                                public float? Threshold { get; set; }

                                [NameInMap("VelocityInMint")]
                                [Validation(Required=false)]
                                public int? VelocityInMint { get; set; }

                            }
                            public string Type { get; set; }
                        }
                    };

                }

            }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
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
                            public int? Bid { get; set; }
                            public string BusinessName { get; set; }
                            public int? ServiceType { get; set; }
                        }
                    };

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public string Rid { get; set; }

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
                    };

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
