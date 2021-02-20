// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSchedulerRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerRules")]
        [Validation(Required=false)]
        public List<DescribeSchedulerRulesResponseBodySchedulerRules> SchedulerRules { get; set; }
        public class DescribeSchedulerRulesResponseBodySchedulerRules : TeaModel {
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public DescribeSchedulerRulesResponseBodySchedulerRulesParam Param { get; set; }
            public class DescribeSchedulerRulesResponseBodySchedulerRulesParam : TeaModel {
                [NameInMap("ParamData")]
                [Validation(Required=false)]
                public DescribeSchedulerRulesResponseBodySchedulerRulesParamParamData ParamData { get; set; }
                public class DescribeSchedulerRulesResponseBodySchedulerRulesParamParamData : TeaModel {
                    [NameInMap("CloudInstanceId")]
                    [Validation(Required=false)]
                    public string CloudInstanceId { get; set; }

                }
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }
            };

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeSchedulerRulesResponseBodySchedulerRulesRules> Rules { get; set; }
            public class DescribeSchedulerRulesResponseBodySchedulerRulesRules : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public int? ValueType { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("RestoreDelay")]
                [Validation(Required=false)]
                public int? RestoreDelay { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
