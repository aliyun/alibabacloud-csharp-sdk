// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateForwardingRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<CreateForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class CreateForwardingRulesResponseBodyForwardingRules : TeaModel {
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

        }

    }

}
