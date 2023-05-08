// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyDetailResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the whitelist of risk items.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeStrategyDetailResponseBodyStrategy Strategy { get; set; }
        public class DescribeStrategyDetailResponseBodyStrategy : TeaModel {
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            /// <summary>
            /// The alias of the sub-check item.
            /// </summary>
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            /// <summary>
            /// The details of the rule.
            /// </summary>
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The time period during which the check starts. Valid values:
            /// 
            /// *   **0**: 00:00 to 06:00
            /// *   **6**: 06:00 to 12:00
            /// *   **12**: 12:00 to 18:00
            /// *   **18**: 18:00 to 24:00
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RiskSubTypeName")]
            [Validation(Required=false)]
            public string RiskSubTypeName { get; set; }

            /// <summary>
            /// The check item.
            /// </summary>
            [NameInMap("RiskTypeWhiteListQueryResultList")]
            [Validation(Required=false)]
            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList> RiskTypeWhiteListQueryResultList { get; set; }
            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList : TeaModel {
                /// <summary>
                /// The condition by which the baseline check policy is applied to the asset. Valid values:
                /// 
                /// *   **groupId**: the ID of the asset group
                /// *   **uuid**: the UUID of the asset
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The ID of the check item.
                /// </summary>
                [NameInMap("On")]
                [Validation(Required=false)]
                public bool? On { get; set; }

                /// <summary>
                /// The information about the rule parameter.
                /// </summary>
                [NameInMap("SubTypes")]
                [Validation(Required=false)]
                public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes> SubTypes { get; set; }
                public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes : TeaModel {
                    /// <summary>
                    /// The type of the baseline check policy. Valid values:
                    /// 
                    /// *   **common**: standard baseline check policy
                    /// *   **custom**: custom baseline check policy
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The data returned.
                    /// </summary>
                    [NameInMap("CheckDetails")]
                    [Validation(Required=false)]
                    public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails> CheckDetails { get; set; }
                    public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails : TeaModel {
                        /// <summary>
                        /// The name of the baseline check policy.
                        /// </summary>
                        [NameInMap("CheckDesc")]
                        [Validation(Required=false)]
                        public string CheckDesc { get; set; }

                        /// <summary>
                        /// The language of the content within the request and response. Default value: **zh**. Valid values:
                        /// 
                        /// *   **zh**: Chinese
                        /// *   **en**: English
                        /// </summary>
                        [NameInMap("CheckId")]
                        [Validation(Required=false)]
                        public long? CheckId { get; set; }

                        /// <summary>
                        /// The maximum value of the rule parameter.
                        /// </summary>
                        [NameInMap("CheckItem")]
                        [Validation(Required=false)]
                        public string CheckItem { get; set; }

                        /// <summary>
                        /// The ID of the baseline check policy.
                        /// </summary>
                        [NameInMap("Rules")]
                        [Validation(Required=false)]
                        public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules> Rules { get; set; }
                        public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules : TeaModel {
                            /// <summary>
                            /// The description of the check item.
                            /// </summary>
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public int? DefaultValue { get; set; }

                            /// <summary>
                            /// Indicates whether the sub-risk item is selected. Valid values:
                            /// 
                            /// *   **true**: yes
                            /// *   **false**: no
                            /// </summary>
                            [NameInMap("Optional")]
                            [Validation(Required=false)]
                            public int? Optional { get; set; }

                            /// <summary>
                            /// The specified value of the rule parameter.
                            /// </summary>
                            [NameInMap("ParamList")]
                            [Validation(Required=false)]
                            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList : TeaModel {
                                [NameInMap("EnumValue")]
                                [Validation(Required=false)]
                                public string EnumValue { get; set; }

                                /// <summary>
                                /// Queries the details of a baseline check policy.
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public int? MaxValue { get; set; }

                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public int? MinValue { get; set; }

                                /// <summary>
                                /// Indicates whether the rule is included in the policy. Valid values:
                                /// 
                                /// *   **1**: yes
                                /// *   **0**: no
                                /// </summary>
                                [NameInMap("ParamDefaultValue")]
                                [Validation(Required=false)]
                                public string ParamDefaultValue { get; set; }

                                [NameInMap("ParamDesc")]
                                [Validation(Required=false)]
                                public string ParamDesc { get; set; }

                                /// <summary>
                                /// The time when the baseline check based on the baseline check policy ends.
                                /// </summary>
                                [NameInMap("ParamName")]
                                [Validation(Required=false)]
                                public string ParamName { get; set; }

                                /// <summary>
                                /// WB01224678
                                /// </summary>
                                [NameInMap("ParamType")]
                                [Validation(Required=false)]
                                public int? ParamType { get; set; }

                                /// <summary>
                                /// An array that consists of sub-risk items.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// The check item.
                            /// </summary>
                            [NameInMap("RuleDesc")]
                            [Validation(Required=false)]
                            public string RuleDesc { get; set; }

                            /// <summary>
                            /// Indicates whether the risk item is selected. Valid values:
                            /// 
                            /// *   **true**: yes
                            /// *   **false**: no
                            /// </summary>
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                        }

                    }

                    /// <summary>
                    /// If the value of paramType is 2, this parameter provides the options that can be selected for the rule parameter.
                    /// </summary>
                    [NameInMap("On")]
                    [Validation(Required=false)]
                    public bool? On { get; set; }

                    /// <summary>
                    /// The description of the rule.
                    /// </summary>
                    [NameInMap("TypeName")]
                    [Validation(Required=false)]
                    public string TypeName { get; set; }

                }

                /// <summary>
                /// An array that consists of the details of custom check items.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The name of the rule parameter.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
