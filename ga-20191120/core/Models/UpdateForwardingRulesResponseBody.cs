// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateForwardingRulesResponseBody : TeaModel {
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<UpdateForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class UpdateForwardingRulesResponseBodyForwardingRules : TeaModel {
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
