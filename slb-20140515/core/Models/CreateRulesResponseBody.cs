// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateRulesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The forwarding rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public CreateRulesResponseBodyRules Rules { get; set; }
        public class CreateRulesResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<CreateRulesResponseBodyRulesRule> Rule { get; set; }
            public class CreateRulesResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The forwarding rule ID.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the forwarding rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

    }

}
