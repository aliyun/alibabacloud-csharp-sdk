// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskTypes")]
        [Validation(Required=false)]
        public List<DescribeRiskTypeResponseBodyRiskTypes> RiskTypes { get; set; }
        public class DescribeRiskTypeResponseBodyRiskTypes : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("SubTypes")]
            [Validation(Required=false)]
            public List<DescribeRiskTypeResponseBodyRiskTypesSubTypes> SubTypes { get; set; }
            public class DescribeRiskTypeResponseBodyRiskTypesSubTypes : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("CheckDetails")]
                [Validation(Required=false)]
                public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails> CheckDetails { get; set; }
                public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetails : TeaModel {
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
                    public List<DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules> Rules { get; set; }
                    public class DescribeRiskTypeResponseBodyRiskTypesSubTypesCheckDetailsRules : TeaModel {
                        [NameInMap("Optional")]
                        [Validation(Required=false)]
                        public int? Optional { get; set; }

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

                        }

                        [NameInMap("RuleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                    }

                }

                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
