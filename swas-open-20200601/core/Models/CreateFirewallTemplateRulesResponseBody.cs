// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateRulesResponseBody : TeaModel {
        /// <summary>
        /// The firewall template rules.
        /// </summary>
        [NameInMap("FirewallTemplateRules")]
        [Validation(Required=false)]
        public List<CreateFirewallTemplateRulesResponseBodyFirewallTemplateRules> FirewallTemplateRules { get; set; }
        public class CreateFirewallTemplateRulesResponseBodyFirewallTemplateRules : TeaModel {
            /// <summary>
            /// The ID of the firewall template rule.
            /// </summary>
            [NameInMap("FirewallTemplateRuleId")]
            [Validation(Required=false)]
            public string FirewallTemplateRuleId { get; set; }

            /// <summary>
            /// The port range. Valid values: 1 to 65535. Specify a port range in the format of \\<start port number>/\\<end port number>. Example: `1024/1055`, which indicates that the port range of 1024 to 1055.
            /// 
            /// >  If you set RuleProtocol to ICMP, you must set Port to -1/-1.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The remarks of the firewall rule.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The transport layer protocol that the rule supports. Valid values:
            /// 
            /// *   TCP
            /// *   UDP
            /// *   TCP+UDP
            /// *   ICMP: the ICMP protocol
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// The source address to which you want to grant access permissions. CIDR blocks and IPv4 addresses are supported.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
