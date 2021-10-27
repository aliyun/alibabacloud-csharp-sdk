// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListFirewallRulesResponseBody : TeaModel {
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public List<ListFirewallRulesResponseBodyFirewallRules> FirewallRules { get; set; }
        public class ListFirewallRulesResponseBodyFirewallRules : TeaModel {
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
