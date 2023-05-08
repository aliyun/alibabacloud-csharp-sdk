// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsResponseBody : TeaModel {
        /// <summary>
        /// The specified value of the rule parameter.
        /// </summary>
        [NameInMap("CheckFixDetails")]
        [Validation(Required=false)]
        public List<DescribeCheckFixDetailsResponseBodyCheckFixDetails> CheckFixDetails { get; set; }
        public class DescribeCheckFixDetailsResponseBodyCheckFixDetails : TeaModel {
            /// <summary>
            /// The description of the risk item.
            /// </summary>
            [NameInMap("CheckDesc")]
            [Validation(Required=false)]
            public string CheckDesc { get; set; }

            /// <summary>
            /// The minimum value of the rule parameter.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The information about the parameter.
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// The options that can be selected for the rule parameter if the value of the ParamType parameter is 2.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules> Rules { get; set; }
            public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules : TeaModel {
                /// <summary>
                /// The information about the rule parameter.
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// The language of the content within the request and response. Default value: **zh**. Valid values:
                /// 
                /// *   **zh**: Chinese
                /// *   **en**: English
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public int? DefaultValue { get; set; }

                /// <summary>
                /// The rule that is supported by the risk item.
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
                    /// The number of risk items that can be fixed.
                    /// </summary>
                    [NameInMap("ParamDefaultValue")]
                    [Validation(Required=false)]
                    public string ParamDefaultValue { get; set; }

                    /// <summary>
                    /// The ID of the risk item.
                    /// </summary>
                    [NameInMap("ParamDesc")]
                    [Validation(Required=false)]
                    public string ParamDesc { get; set; }

                    /// <summary>
                    /// The ID of the request, which is used to locate and troubleshoot issues.
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// Queries the parameters that you can configure to fix specified risk items.
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public int? ParamType { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the risk item.
                /// 
                /// >  You can call the [DescribeCheckWarningSummary](~~116179~~) operation to query the IDs of risk items.
                /// </summary>
                [NameInMap("RuleDesc")]
                [Validation(Required=false)]
                public string RuleDesc { get; set; }

                /// <summary>
                /// The data returned.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

                /// <summary>
                /// The specified value of the rule parameter.
                /// </summary>
                [NameInMap("VarName")]
                [Validation(Required=false)]
                public string VarName { get; set; }

            }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
