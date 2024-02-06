// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RevokeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The transport layer protocol. The value of this parameter is case-sensitive. Valid values:
        /// 
        /// *   tcp: TCP.
        /// *   udp: UDP.
        /// *   icmp: ICMP.
        /// *   gre: GRE.
        /// *   all: all protocols.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The authorization policy. Valid values:
        /// 
        /// *   accept: allows access. This is the default value.
        /// *   drop: denies access and returns no responses.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The range of destination ports that correspond to the transport layer protocol for the security group rule. Valid values:
        /// 
        /// *   When the IpProtocol parameter is set to tcp or udp, the port number range is **1** to **65535**. The start port number and the end port number are separated by a forward slash (/). Correct example: **1/200**. Incorrect example: **200/1**.
        /// *   When the IpProtocol parameter is set to icmp, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to gre, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to all, the port number range is **-1/-1**, which indicates all ports.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// The priority of security group rule N. Valid values: **1** to **100**. Default value: **1**.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ID of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The source CIDR block. CIDR blocks and IPv4 addresses are supported. Default value: 0.0.XX.XX/0.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// The range of source ports that correspond to the transport layer protocol for the security group rule. Valid values:
        /// 
        /// *   When the IpProtocol parameter is set to tcp or udp, the port number range is **1** to **65535**. The start port number and the end port number are separated by a forward slash (/). Correct example: **1/200**. Incorrect example: **200/1**.
        /// *   When the IpProtocol parameter is set to icmp, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to gre, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to all, the port number range is **-1/-1**, which indicates all ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

    }

}
