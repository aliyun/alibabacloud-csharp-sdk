// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallRulesRequest : TeaModel {
        /// <summary>
        /// The client token.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Details about the firewall rules.
        /// </summary>
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public List<CreateFirewallRulesRequestFirewallRules> FirewallRules { get; set; }
        public class CreateFirewallRulesRequestFirewallRules : TeaModel {
            /// <summary>
            /// The port number.
            /// 
            /// *   When the transport layer protocol is TCP and/or UDP, the port number range is 1 to 65535. Specify a port range in the format of \\<Start port number>/\\<End port number>. Example: 1/200.
            /// *   When the transport layer protocol is ICMP, the port number range is -1/-1, which indicates all ports.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The description of the firewall rule.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The transport layer protocol. Valid values:
            /// 
            /// *   TCP
            /// *   UDP
            /// *   TCP+UDP
            /// *   ICMP
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// The IP address or CIDR block that is allowed in the firewall rule.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// The ID of the simple application server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the simple application server. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags that you want to add to the firewall. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFirewallRulesRequestTag> Tag { get; set; }
        public class CreateFirewallRulesRequestTag : TeaModel {
            /// <summary>
            /// The tag key. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
