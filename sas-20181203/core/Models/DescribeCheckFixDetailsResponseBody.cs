// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsResponseBody : TeaModel {
        [NameInMap("CheckFixDetails")]
        [Validation(Required=false)]
        public List<DescribeCheckFixDetailsResponseBodyCheckFixDetails> CheckFixDetails { get; set; }
        public class DescribeCheckFixDetailsResponseBodyCheckFixDetails : TeaModel {
            [NameInMap("CheckDesc")]
            [Validation(Required=false)]
            public string CheckDesc { get; set; }

            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules> Rules { get; set; }
            public class DescribeCheckFixDetailsResponseBodyCheckFixDetailsRules : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public int? DefaultValue { get; set; }

                [NameInMap("Optional")]
                [Validation(Required=false)]
                public int? Optional { get; set; }

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

                    [NameInMap("ParamDefaultValue")]
                    [Validation(Required=false)]
                    public string ParamDefaultValue { get; set; }

                    [NameInMap("ParamDesc")]
                    [Validation(Required=false)]
                    public string ParamDesc { get; set; }

                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

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

                [NameInMap("RuleDesc")]
                [Validation(Required=false)]
                public string RuleDesc { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

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
