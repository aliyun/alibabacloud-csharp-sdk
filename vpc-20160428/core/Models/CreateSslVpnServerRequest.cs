// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSslVpnServerRequest : TeaModel {
        /// <summary>
        /// The encryption algorithm that is used in the SSL-VPN connection. Valid values:
        /// 
        /// *   **AES-128-CBC** (default): AES-128-CBC
        /// *   **AES-192-CBC**: AES-192-CBC
        /// *   **AES-256-CBC**: AES-256-CBC
        /// *   **none**: does not use an encryption algorithm.
        /// </summary>
        [NameInMap("Cipher")]
        [Validation(Required=false)]
        public string Cipher { get; set; }

        /// <summary>
        /// The client CIDR block.
        /// 
        /// The CIDR block that is allocated to the virtual network interface of the client. It is not the CIDR block where the client resides.
        /// 
        /// When the client accesses the destination network through an SSL-VPN connection, the VPN gateway allocates an IP address from the client CIDR block to the client.
        /// 
        /// >  This CIDR block cannot conflict with the CIDR block specified by **LocalSubnet**.
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable data compression. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        /// <summary>
        /// Specifies whether to enable two-factor authentication. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// 
        /// >  To enable two-factor authentication, make sure that the VPN gateway was created after 00:00:00 (UTC+8), March 5, 2020. Otherwise, two-factor authentication is not supported.
        /// </summary>
        [NameInMap("EnableMultiFactorAuth")]
        [Validation(Required=false)]
        public bool? EnableMultiFactorAuth { get; set; }

        /// <summary>
        /// The ID of the IDaaS instance.
        /// </summary>
        [NameInMap("IDaaSInstanceId")]
        [Validation(Required=false)]
        public string IDaaSInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the IDaaS instance is created.
        /// </summary>
        [NameInMap("IDaaSRegionId")]
        [Validation(Required=false)]
        public string IDaaSRegionId { get; set; }

        /// <summary>
        /// The local CIDR block.
        /// 
        /// The CIDR block to be accessed by the client through the SSL-VPN connection.
        /// 
        /// This value can be the CIDR block of a virtual private cloud (VPC), a vSwitch, a data center that is connected to a VPC through an Express Connect circuit, or Object Storage Service (OSS).
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The name of the SSL server.
        /// 
        /// The name must be 1 to 100 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port used by the SSL server. Default value: **1194**. The following ports cannot be used:
        /// 
        /// **22, 2222, 22222, 9000, 9001, 9002, 7505, 80, 443, 53, 68, 123, 4510, 4560, 500, and 4500**.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The protocol that is used by the SSL server. Valid values:
        /// 
        /// *   **TCP**: TCP
        /// *   **UDP** (default): UDP
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// The ID of the region where the VPN gateway is created.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
