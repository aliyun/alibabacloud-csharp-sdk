// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public RunContractRuleGenerationResponseBodyOutput Output { get; set; }
        public class RunContractRuleGenerationResponseBodyOutput : TeaModel {
            [NameInMap("ruleTaskId")]
            [Validation(Required=false)]
            public string RuleTaskId { get; set; }

            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<RunContractRuleGenerationResponseBodyOutputRules> Rules { get; set; }
            public class RunContractRuleGenerationResponseBodyOutputRules : TeaModel {
                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("ruleSequence")]
                [Validation(Required=false)]
                public string RuleSequence { get; set; }

                [NameInMap("ruleTag")]
                [Validation(Required=false)]
                public string RuleTag { get; set; }

                [NameInMap("ruleTitle")]
                [Validation(Required=false)]
                public string RuleTitle { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public RunContractRuleGenerationResponseBodyUsage Usage { get; set; }
        public class RunContractRuleGenerationResponseBodyUsage : TeaModel {
            [NameInMap("input")]
            [Validation(Required=false)]
            public long? Input { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

    }

}
