// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskTypeResponseBody : TeaModel {
        /// <summary>
        /// The description of the rule for the baseline.
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
            /// The description of the parameter.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// An array that consists of the rule details about the baseline.
            /// </summary>
            [NameInMap("SubTypes")]
            [Validation(Required=false)]
            public List<DescribeRiskTypeResponseBodyRiskTypesSubTypes> SubTypes { get; set; }
            public class DescribeRiskTypeResponseBodyRiskTypesSubTypes : TeaModel {
                /// <summary>
                /// The configuration type of the parameter. Valid values:
                /// 
                /// *   **1**: input
                /// *   **2**: selection
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The language of the content within the request and response. Default value: **zh**. Valid values:
                /// 
                /// *   **zh**: Chinese
                /// *   **en**: English
                /// </summary>
                [NameInMap("CheckDetails")]
                [Validation(Required=false)]
                public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails> CheckDetails { get; set; }
                public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails : TeaModel {
                    /// <summary>
                    /// The alias of the baseline subtype.
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
                    /// The name of the baseline subtype.
                    /// </summary>
                    [NameInMap("CheckItem")]
                    [Validation(Required=false)]
                    public string CheckItem { get; set; }

                    /// <summary>
                    /// The minimum value of the parameter.
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules> Rules { get; set; }
                    public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules : TeaModel {
                        /// <summary>
                        /// The name of the parameter.
                        /// </summary>
                        [NameInMap("Optional")]
                        [Validation(Required=false)]
                        public int? Optional { get; set; }

                        /// <summary>
                        /// The description of the baseline.
                        /// </summary>
                        [NameInMap("ParamList")]
                        [Validation(Required=false)]
                        public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                        public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRulesParamList : TeaModel {
                            [NameInMap("EnumValue")]
                            [Validation(Required=false)]
                            public string EnumValue { get; set; }

                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public int? MaxValue { get; set; }

                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public int? MinValue { get; set; }

                            /// <summary>
                            /// The ID of the request, which is used to locate and troubleshoot issues.
                            /// </summary>
                            [NameInMap("ParamDefaultValue")]
                            [Validation(Required=false)]
                            public string ParamDefaultValue { get; set; }

                            [NameInMap("ParamDesc")]
                            [Validation(Required=false)]
                            public string ParamDesc { get; set; }

                            /// <summary>
                            /// Queries baseline types.
                            /// </summary>
                            [NameInMap("ParamName")]
                            [Validation(Required=false)]
                            public string ParamName { get; set; }

                            [NameInMap("ParamType")]
                            [Validation(Required=false)]
                            public int? ParamType { get; set; }

                        }

                        /// <summary>
                        /// An array that consists of the information about baseline subtypes.
                        /// </summary>
                        [NameInMap("RuleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        /// <summary>
                        /// The maximum value of the parameter.
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                    }

                }

                /// <summary>
                /// An array that consists of the check details about the baseline subtype.
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// The alias of the baseline type.
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
