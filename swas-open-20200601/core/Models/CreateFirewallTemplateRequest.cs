// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateRequest : TeaModel {
        /// <summary>
        /// The description of the firewall template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The details of the firewall rule.
        /// </summary>
        [NameInMap("FirewallRule")]
        [Validation(Required=false)]
        public List<CreateFirewallTemplateRequestFirewallRule> FirewallRule { get; set; }
        public class CreateFirewallTemplateRequestFirewallRule : TeaModel {
            /// <summary>
            /// The port range. Valid values: 1 to 65535. Specify a port range in the format of \\<start port number>/\\<end port number>. Example: `1024/1055`, which indicates that the port range of 1024 to 1055.
            /// 
            /// >  If you set RuleProtocol to ICMP, you must set Port to -1/-1.
            /// 
            /// This parameter is required.
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
            /// *   ICMP
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// The source address to which you want to grant access permissions. CIDR blocks and IPv4 addresses are supported.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// The name of the firewall template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID of the simple application server to which the firewall template belongs. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
