// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkAclEntryRequest : TeaModel {
        /// <summary>
        /// The source CIDR block.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The description of the network ACL.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the ACL rule controls inbound or outbound access requests. Valid values:
        /// 
        /// *   **ingress**
        /// *   **egress**
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// The name must be 1 to 128 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("NetworkAclEntryName")]
        [Validation(Required=false)]
        public string NetworkAclEntryName { get; set; }

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The action that is performed on network traffic that matches the rule. Valid values:
        /// 
        /// *   **accept**: allows network traffic.
        /// *   **drop**: blocks network traffic.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The port range.
        /// 
        /// *   If you set **Protocol** to **all** or **icmp**, set this parameter to -1/-1, which specifies all ports.
        /// *   If you set **Protocol** to **tcp** or **udp**, the port can be **1 to 65535**. You can set this parameter to **1/200** or **80/80**, which specifies ports 1 to 200 or port 80.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// The priority of the rule. Valid values: **1 to 100**. Default value: **1**.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **icmp**: ICMP
        /// *   **tcp**: TCP
        /// *   **udp**: UDP
        /// *   **all**: all protocols
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
