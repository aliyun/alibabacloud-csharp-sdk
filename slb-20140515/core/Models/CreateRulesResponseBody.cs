// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public CreateRulesResponseBodyRules Rules { get; set; }
        public class CreateRulesResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<CreateRulesResponseBodyRulesRule> Rule { get; set; }
            public class CreateRulesResponseBodyRulesRule : TeaModel {
                public string RuleName { get; set; }
                public string RuleId { get; set; }
            }
        };

    }

}
