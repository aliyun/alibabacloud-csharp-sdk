// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallRulesResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the firewall rules that you created.
        /// </summary>
        [NameInMap("FirewallRuleIds")]
        [Validation(Required=false)]
        public List<string> FirewallRuleIds { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
