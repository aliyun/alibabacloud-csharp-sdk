// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskTypeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about baseline types.
        /// </summary>
        [NameInMap("RiskTypes")]
        [Validation(Required=false)]
        public List<DescribeRiskTypeResponseBodyRiskTypes> RiskTypes { get; set; }
        public class DescribeRiskTypeResponseBodyRiskTypes : TeaModel {
            /// <summary>
            /// The alias of the baseline type.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The baseline type flag of the current user version. Valid values:
            /// 
            /// - **true**: Have access
            /// - **false**: No permissions
            /// </summary>
            [NameInMap("AuthFlag")]
            [Validation(Required=false)]
            public bool? AuthFlag { get; set; }

            /// <summary>
            /// An array that consists of the information about baseline subtypes.
            /// </summary>
            [NameInMap("SubTypes")]
            [Validation(Required=false)]
            public List<DescribeRiskTypeResponseBodyRiskTypesSubTypes> SubTypes { get; set; }
            public class DescribeRiskTypeResponseBodyRiskTypesSubTypes : TeaModel {
                /// <summary>
                /// The alias of the baseline subtype.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The baseline subtype permission flag of the current user version. Valid values:
                /// 
                /// - **true**: Have access
                /// - **false**: No permissions
                /// </summary>
                [NameInMap("AuthFlag")]
                [Validation(Required=false)]
                public bool? AuthFlag { get; set; }

                /// <summary>
                /// An array that consists of the check details about the baseline subtype.
                /// </summary>
                [NameInMap("CheckDetails")]
                [Validation(Required=false)]
                public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails> CheckDetails { get; set; }
                public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails : TeaModel {
                    /// <summary>
                    /// The description of the baseline.
                    /// </summary>
                    [NameInMap("CheckDesc")]
                    [Validation(Required=false)]
                    public string CheckDesc { get; set; }

                    /// <summary>
                    /// The ID of the baseline.
                    /// </summary>
                    [NameInMap("CheckId")]
                    [Validation(Required=false)]
                    public long? CheckId { get; set; }

                    /// <summary>
                    /// The baseline.
                    /// </summary>
                    [NameInMap("CheckItem")]
                    [Validation(Required=false)]
                    public string CheckItem { get; set; }

                    /// <summary>
                    /// An array that consists of the rule details about the baseline.
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules> Rules { get; set; }
                    public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules : TeaModel {
                        /// <summary>
                        /// Indicates whether the baseline can be edited. Valid values:
                        /// 
                        /// *   **0**: no
                        /// *   **1**: yes
                        /// </summary>
                        [NameInMap("Optional")]
                        [Validation(Required=false)]
                        public int? Optional { get; set; }

                        /// <summary>
                        /// An array that consists of the parameters in the rule for the baseline.
                        /// </summary>
                        [NameInMap("ParamList")]
                        [Validation(Required=false)]
                        public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                        public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList : TeaModel {
                            /// <summary>
                            /// If the value of paramType is 1, this parameter is empty. If the value of paramType is 2, this parameter provides the options that can be selected for paramType.
                            /// </summary>
                            [NameInMap("EnumValue")]
                            [Validation(Required=false)]
                            public string EnumValue { get; set; }

                            /// <summary>
                            /// The maximum value of the parameter.
                            /// </summary>
                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public int? MaxValue { get; set; }

                            /// <summary>
                            /// The minimum value of the parameter.
                            /// </summary>
                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public int? MinValue { get; set; }

                            /// <summary>
                            /// The default value of the parameter.
                            /// </summary>
                            [NameInMap("ParamDefaultValue")]
                            [Validation(Required=false)]
                            public string ParamDefaultValue { get; set; }

                            /// <summary>
                            /// The description of the parameter.
                            /// </summary>
                            [NameInMap("ParamDesc")]
                            [Validation(Required=false)]
                            public string ParamDesc { get; set; }

                            /// <summary>
                            /// The name of the parameter.
                            /// </summary>
                            [NameInMap("ParamName")]
                            [Validation(Required=false)]
                            public string ParamName { get; set; }

                            /// <summary>
                            /// The configuration type of the parameter. Valid values:
                            /// 
                            /// *   **1**: input
                            /// *   **2**: selection
                            /// </summary>
                            [NameInMap("ParamType")]
                            [Validation(Required=false)]
                            public int? ParamType { get; set; }

                        }

                        /// <summary>
                        /// The description of the rule for the baseline.
                        /// </summary>
                        [NameInMap("RuleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        /// <summary>
                        /// The ID of the rule for the baseline.
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                    }

                }

                /// <summary>
                /// The operating system type of the server. Valid values:
                /// 
                /// - **windows**
                /// - **linux**
                /// </summary>
                [NameInMap("SupportedOs")]
                [Validation(Required=false)]
                public string SupportedOs { get; set; }

                /// <summary>
                /// The name of the baseline subtype.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// The name of the baseline type.
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
