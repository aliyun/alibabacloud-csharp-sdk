// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// Details about the forwarding rules.
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<DeleteForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class DeleteForwardingRulesResponseBodyForwardingRules : TeaModel {
            /// <summary>
            /// The ID of the forwarding rule.
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
