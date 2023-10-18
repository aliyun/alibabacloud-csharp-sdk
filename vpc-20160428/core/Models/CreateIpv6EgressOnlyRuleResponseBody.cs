// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpv6EgressOnlyRuleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the egress-only rule.
        /// </summary>
        [NameInMap("Ipv6EgressRuleId")]
        [Validation(Required=false)]
        public string Ipv6EgressRuleId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
