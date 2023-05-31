// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the parameters.
        /// </summary>
        [NameInMap("CheckFixDetails")]
        [Validation(Required=false)]
        public List<DescribeCheckFixDetailsResponseBodyCheckFixDetails> CheckFixDetails { get; set; }
        public class DescribeCheckFixDetailsResponseBodyCheckFixDetails : TeaModel {
            /// <summary>
            /// The detailed description of the risk item.
            /// </summary>
            [NameInMap("CheckDesc")]
            [Validation(Required=false)]
            public string CheckDesc { get; set; }

            /// <summary>
            /// The ID of the risk item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The description of the risk item.
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// An array consisting of the rules that are supported by the risk item.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules> Rules { get; set; }
            public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules : TeaModel {
                /// <summary>
                /// The ID of the risk item.
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// The default value of the rule.
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public int? DefaultValue { get; set; }

                /// <summary>
                /// Indicates whether the rule is optional. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public int? Optional { get; set; }

                /// <summary>
                /// An array that consists of the rule parameters.
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRulesParamList> ParamList { get; set; }
                public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRulesParamList : TeaModel {
                    /// <summary>
                    /// The options that can be selected for the rule parameter if the value of the ParamType parameter is 2.
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
                    /// The ID of the rule.
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    /// <summary>
                    /// The specified value of the rule parameter.
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
                /// The ID of the rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The specified value of the rule parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

                /// <summary>
                /// The name of the variable.
                /// </summary>
                [NameInMap("VarName")]
                [Validation(Required=false)]
                public string VarName { get; set; }

            }

        }

        /// <summary>
        /// The number of risk items that can be fixed.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
