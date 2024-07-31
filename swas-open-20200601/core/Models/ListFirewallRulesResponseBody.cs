// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListFirewallRulesResponseBody : TeaModel {
        /// <summary>
        /// The array of firewall rules.
        /// </summary>
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public List<ListFirewallRulesResponseBodyFirewallRules> FirewallRules { get; set; }
        public class ListFirewallRulesResponseBodyFirewallRules : TeaModel {
            /// <summary>
            /// The firewall policy. Valid values:
            /// 
            /// *   accept: Access is allowed.
            /// *   drop: Access is refused.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The port range.
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
            /// The ID of the firewall rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The transport layer protocol. Valid values:
            /// 
            /// *   TCP
            /// *   UDP
            /// *   TCP+UDP
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// The source CIDR block.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// The tags of the firewall rule.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListFirewallRulesResponseBodyFirewallRulesTags> Tags { get; set; }
            public class ListFirewallRulesResponseBodyFirewallRulesTags : TeaModel {
                /// <summary>
                /// The key of tag N to be added to the firewall rule. Valid values of N: 1 to 20.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N to be added to the firewall rule. Valid values of N: 1 to 20.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
