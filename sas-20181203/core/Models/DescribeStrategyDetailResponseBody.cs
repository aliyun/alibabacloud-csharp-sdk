// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeStrategyDetailResponseBodyStrategy Strategy { get; set; }
        public class DescribeStrategyDetailResponseBodyStrategy : TeaModel {
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RiskTypeWhiteListQueryResultList")]
            [Validation(Required=false)]
            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList> RiskTypeWhiteListQueryResultList { get; set; }
            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultList : TeaModel {
                public string Alias { get; set; }
                public bool? On { get; set; }
                public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes> SubTypes { get; set; }
                public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypes : TeaModel {
                    public string Alias { get; set; }
                    public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails> CheckDetails { get; set; }
                    public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetails : TeaModel {
                        public string CheckDesc { get; set; }
                        public long? CheckId { get; set; }
                        public string CheckItem { get; set; }
                        public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules> Rules { get; set; }
                        public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRules : TeaModel {
                            public int? DefaultValue { get; set; }
                            public int? Optional { get; set; }
                            public List<DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList> ParamList { get; set; }
                            public class DescribeStrategyDetailResponseBodyStrategyRiskTypeWhiteListQueryResultListSubTypesCheckDetailsRulesParamList : TeaModel {
                                public string EnumValue { get; set; }
                                public int? MaxValue { get; set; }
                                public int? MinValue { get; set; }
                                public string ParamDefaultValue { get; set; }
                                public string ParamDesc { get; set; }
                                public string ParamName { get; set; }
                                public int? ParamType { get; set; }
                                public string Value { get; set; }
                            }
                            public string RuleDesc { get; set; }
                            public string RuleId { get; set; }
                        }
                    }
                    public bool? On { get; set; }
                    public string TypeName { get; set; }
                }
                public string TypeName { get; set; }
            }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
        };

    }

}
