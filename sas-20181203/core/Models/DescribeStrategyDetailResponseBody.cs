// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the baseline check policy.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeStrategyDetailResponseBodyStrategy Strategy { get; set; }
        public class DescribeStrategyDetailResponseBodyStrategy : TeaModel {
            /// <summary>
            /// The type of the baseline check policy that you want to query. Valid values:
            /// 
            /// *   **common**: standard baseline check policy
            /// *   **custom**: custom baseline check policy
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            /// <summary>
            /// The check interval of the policy.
            /// </summary>
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            /// <summary>
            /// The time period during which the check starts. Valid values:
            /// 
            /// *   **0**: 00:00 to 06:00
            /// *   **6**: 06:00 to 12:00
            /// *   **12**: 12:00 to 18:00
            /// *   **18**: 18:00 to 24:00
            /// </summary>
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            /// <summary>
            /// The end time of the check. Specify the time in the HH:mm:ss format.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The ID of the baseline check policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The name of the baseline check policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The subtype of the baselines. 
            /// 
            /// > You can call the [DescribeRiskType](~~DescribeRiskType~~) operation to query the subtypes of baselines.
            /// </summary>
            [NameInMap("RiskSubTypeName")]
            [Validation(Required=false)]
            public string RiskSubTypeName { get; set; }

            /// <summary>
            /// The information about the whitelist of risk items.
            /// </summary>
            [NameInMap("RiskTypeWhiteListQueryResultList")]
            [Validation(Required=false)]
            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList> RiskTypeWhiteListQueryResultList { get; set; }
            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList : TeaModel {
                /// <summary>
                /// The alias of the check item.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// Indicates whether the check item is selected. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("On")]
                [Validation(Required=false)]
                public bool? On { get; set; }

                /// <summary>
                /// The information about sub-check items.
                /// </summary>
                [NameInMap("SubTypes")]
                [Validation(Required=false)]
                public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes> SubTypes { get; set; }
                public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes : TeaModel {
                    /// <summary>
                    /// The alias of the check item.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The details of custom check items.
                    /// </summary>
                    [NameInMap("CheckDetails")]
                    [Validation(Required=false)]
                    public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails> CheckDetails { get; set; }
                    public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails : TeaModel {
                        /// <summary>
                        /// The description of the check item.
                        /// </summary>
                        [NameInMap("CheckDesc")]
                        [Validation(Required=false)]
                        public string CheckDesc { get; set; }

                        /// <summary>
                        /// The ID of the check item.
                        /// </summary>
                        [NameInMap("CheckId")]
                        [Validation(Required=false)]
                        public long? CheckId { get; set; }

                        /// <summary>
                        /// The check item.
                        /// </summary>
                        [NameInMap("CheckItem")]
                        [Validation(Required=false)]
                        public string CheckItem { get; set; }

                        /// <summary>
                        /// The details of rules.
                        /// </summary>
                        [NameInMap("Rules")]
                        [Validation(Required=false)]
                        public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules> Rules { get; set; }
                        public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules : TeaModel {
                            /// <summary>
                            /// The default value of the rule.
                            /// </summary>
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public int? DefaultValue { get; set; }

                            /// <summary>
                            /// Indicates whether the rule can be selected. Valid values:
                            /// 
                            /// *   **1**: yes
                            /// *   **0**: no
                            /// </summary>
                            [NameInMap("Optional")]
                            [Validation(Required=false)]
                            public int? Optional { get; set; }

                            /// <summary>
                            /// The rule parameters.
                            /// </summary>
                            [NameInMap("ParamList")]
                            [Validation(Required=false)]
                            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList : TeaModel {
                                /// <summary>
                                /// The options that can be selected for the rule parameter if the value of ParamType is set to 2.
                                /// </summary>
                                [NameInMap("EnumValue")]
                                [Validation(Required=false)]
                                public string EnumValue { get; set; }

                                /// <summary>
                                /// The maximum value of the rule parameter.
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public int? MaxValue { get; set; }

                                /// <summary>
                                /// The minimum value of the rule parameter.
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public int? MinValue { get; set; }

                                /// <summary>
                                /// The default value of the rule parameter.
                                /// </summary>
                                [NameInMap("ParamDefaultValue")]
                                [Validation(Required=false)]
                                public string ParamDefaultValue { get; set; }

                                /// <summary>
                                /// The description of the rule parameter.
                                /// </summary>
                                [NameInMap("ParamDesc")]
                                [Validation(Required=false)]
                                public string ParamDesc { get; set; }

                                /// <summary>
                                /// The name of the rule parameter.
                                /// </summary>
                                [NameInMap("ParamName")]
                                [Validation(Required=false)]
                                public string ParamName { get; set; }

                                /// <summary>
                                /// The type of the rule parameter. Valid values:
                                /// 
                                /// *   **1**: input
                                /// *   **2**: selection
                                /// </summary>
                                [NameInMap("ParamType")]
                                [Validation(Required=false)]
                                public int? ParamType { get; set; }

                                /// <summary>
                                /// The configured value of the rule parameter.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// The description of the rule.
                            /// </summary>
                            [NameInMap("RuleDesc")]
                            [Validation(Required=false)]
                            public string RuleDesc { get; set; }

                            /// <summary>
                            /// The rule ID.
                            /// </summary>
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                        }

                    }

                    /// <summary>
                    /// Indicates whether the sub-check item is selected. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("On")]
                    [Validation(Required=false)]
                    public bool? On { get; set; }

                    /// <summary>
                    /// The operating system type of the server. Valid values:
                    /// *   **windows**
                    /// *   **linux**
                    /// </summary>
                    [NameInMap("SupportedOs")]
                    [Validation(Required=false)]
                    public string SupportedOs { get; set; }

                    /// <summary>
                    /// The type of the sub-check item.
                    /// </summary>
                    [NameInMap("TypeName")]
                    [Validation(Required=false)]
                    public string TypeName { get; set; }

                }

                /// <summary>
                /// The name of the check item.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// The start time of the check. Specify the time in the HH:mm:ss format.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The method that is used to apply the baseline check policy. Valid values:
            /// 
            /// *   **groupId**: asset groups
            /// *   **uuid**: assets
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The type of the baseline check policy. Valid values:
            /// 
            /// *   **1**: standard policies
            /// *   **2**: custom policies
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
