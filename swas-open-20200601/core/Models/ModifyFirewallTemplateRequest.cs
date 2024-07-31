// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ModifyFirewallTemplateRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the firewall template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the firewall template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FirewallTemplateId")]
        [Validation(Required=false)]
        public string FirewallTemplateId { get; set; }

        /// <summary>
        /// The firewall rule in the template.
        /// </summary>
        [NameInMap("FirewallTemplateRule")]
        [Validation(Required=false)]
        public List<ModifyFirewallTemplateRequestFirewallTemplateRule> FirewallTemplateRule { get; set; }
        public class ModifyFirewallTemplateRequestFirewallTemplateRule : TeaModel {
            /// <summary>
            /// The ID of the firewall rule.
            /// 
            /// This parameter is required.
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
            /// The remarks of the firewall template rule.
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
        /// The ID of the simple application server to which the firewall template is applied.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the firewall template.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID of the simple application server. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
