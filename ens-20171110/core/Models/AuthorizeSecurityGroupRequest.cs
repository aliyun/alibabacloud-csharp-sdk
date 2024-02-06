// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AuthorizeSecurityGroupRequest : TeaModel {
        /// <summary>
        /// The transport layer protocol. The values of this parameter are case-sensitive. Valid values:
        /// 
        /// *   tcp
        /// *   udp
        /// *   icmp
        /// *   gre
        /// *   all: All protocols are supported.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The action of security group rule N that determines whether to allow inbound access. Valid values:
        /// 
        /// *   accept: allows access.
        /// *   drop: denies access and returns no responses.
        /// 
        /// Default value: accept.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The range of destination ports that correspond to the transport layer protocol for security group rule N. Valid values:
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
        /// The priority of the security group rule. Valid values: **1** to **100**.
        /// 
        /// Default value: **1**.
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
        /// The source IPv4 CIDR block. CIDR blocks and IPv4 addresses are supported.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// The range of port numbers that correspond to the transport layer protocol for the source security group. Valid values:
        /// 
        /// *   When the IpProtocol parameter is set to tcp or udp, the port number range is **1 to 65535**. The start port number and the end port number are separated by a forward slash (/). Correct example: **1/200**. Incorrect example: **200/1**.
        /// *   When the IpProtocol parameter is set to icmp, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to gre, the port number range is **-1/-1**, which indicates all ports.
        /// *   When the IpProtocol parameter is set to all, the port number range is **-1/-1**, which indicates all ports.
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

    }

}
