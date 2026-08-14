// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCdnLinkageRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerRules")]
        [Validation(Required=false)]
        public List<DescribeCdnLinkageRulesResponseBodySchedulerRules> SchedulerRules { get; set; }
        public class DescribeCdnLinkageRulesResponseBodySchedulerRules : TeaModel {
            [NameInMap("CdnLinkageEnable")]
            [Validation(Required=false)]
            public int? CdnLinkageEnable { get; set; }

            [NameInMap("CdnLinkageRule")]
            [Validation(Required=false)]
            public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule CdnLinkageRule { get; set; }
            public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule : TeaModel {
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Param")]
                [Validation(Required=false)]
                public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam Param { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam : TeaModel {
                    [NameInMap("ParamData")]
                    [Validation(Required=false)]
                    public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData ParamData { get; set; }
                    public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData : TeaModel {
                        [NameInMap("AccessQps")]
                        [Validation(Required=false)]
                        public long? AccessQps { get; set; }

                        [NameInMap("UpstreamQps")]
                        [Validation(Required=false)]
                        public long? UpstreamQps { get; set; }

                    }

                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules> Rules { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules : TeaModel {
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public int? ValueType { get; set; }

                }

            }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
