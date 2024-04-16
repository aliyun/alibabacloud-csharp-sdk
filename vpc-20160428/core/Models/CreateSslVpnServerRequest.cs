// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateSslVpnServerRequest : TeaModel {
        /// <summary>
        /// The encryption algorithm that is used by the SSL-VPN connection.
        /// 
        /// *   If the client uses Tunnelblick or OpenVPN 2.4.0 or later, the SSL server dynamically negotiates with the client about the encryption algorithm and uses the most secure encryption algorithm that is supported by the SSL server and the client. The encryption algorithm that you specify for the SSL server does not take effect.
        /// 
        /// *   If the client uses OpenVPN of a version that is earlier than 2.4.0, the SSL server and the client use the encryption algorithm that you specify for the SSL server. You can specify one of the following encryption algorithms for the SSL server:
        /// 
        ///     *   **AES-128-CBC** (default)
        ///     *   **AES-192-CBC**
        ///     *   **AES-256-CBC**
        ///     *   **none**
        /// </summary>
        [NameInMap("Cipher")]
        [Validation(Required=false)]
        public string Cipher { get; set; }

        /// <summary>
        /// The client CIDR block.
        /// 
        /// It is the CIDR block from which an IP address is allocated to the virtual network interface controller (NIC) of the client. It is not the private CIDR block of the client.
        /// 
        /// If the client accesses the SSL server over an SSL-VPN connection, the VPN gateway assigns an IP address from the specified client CIDR block to the client. The client uses the assigned IP address to access cloud resources.
        /// 
        /// Make sure that the number of IP addresses in the client CIDR block is at least four times the maximum number of SSL-VPN connections supported by the VPN gateway.
        /// 
        /// <details>
        /// <summary>Click to view the reason.</summary>
        /// 
        /// For example, if you specify 192.168.0.0/24 as the client CIDR block, the system first divides a subnet CIDR block with a subnet mask of 30 from 192.168.0.0/24, such as 192.168.0.4/30. This subnet provides up to four IP addresses. Then, the system allocates an IP address from 192.168.0.4/30 to the client and uses the other three IP addresses to ensure network communication. In this case, one client consumes four IP addresses. Therefore, to ensure that an IP address is assigned to your client, you must make sure that the number of IP addresses in the client CIDR block is at least four times the maximum number of SSL-VPN connections supported by the VPN gateway with which the SSL server is associated.
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view the CIDR blocks that are not supported.</summary>
        /// 
        /// *   100.64.0.0~100.127.255.255
        /// *   127.0.0.0~127.255.255.255
        /// *   169.254.0.0~169.254.255.255
        /// *   224.0.0.0~239.255.255.255
        /// *   255.0.0.0~255.255.255.255
        /// </details>
        /// 
        /// <details>
        /// <summary>Click to view the recommended client CIDR blocks for different numbers of SSL-VPN connections.</summary>
        /// 
        /// *   If the number of SSL-VPN connections is 5, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 27 bits in length. Examples: 10.0.0.0/27 and 10.0.0.0/26.
        /// *   If the number of SSL-VPN connections is 10, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 26 bits in length. Examples: 10.0.0.0/26 and 10.0.0.0/25.
        /// *   If the number of SSL-VPN connections is 20, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 25 bits in length. Examples: 10.0.0.0/25 and 10.0.0.0/24.
        /// *   If the number of SSL-VPN connections is 50, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 24 bits in length. Examples: 10.0.0.0/24 and 10.0.0.0/23.
        /// *   If the number of SSL-VPN connections is 100, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 23 bits in length. Examples: 10.0.0.0/23 and 10.0.0.0/22.
        /// *   If the number of SSL-VPN connections is 200, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 22 bits in length. Examples: 10.0.0.0/22 and 10.0.0.0/21.
        /// *   If the number of SSL-VPN connections is 500, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 21 bits in length. Examples: 10.0.0.0/21 and 10.0.0.0/20.
        /// *   If the number of SSL-VPN connections is 1,000, we recommend that you specify a client CIDR block with a subnet mask that is less than or equal to 20 bits in length. Examples: 10.0.0.0/20 and 10.0.0.0/19.
        /// </details>
        /// 
        /// > - The subnet mask of the client CIDR block must be 16 to 29 bits in length.
        /// > - Make sure that the local CIDR block and the client CIDR block do not overlap with each other.
        /// > - We recommend that you use 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16, or one of their subnets as the client CIDR block. If you want to specify a public CIDR block as the client CIDR block, you must specify the public CIDR block as the user CIDR block of the virtual private cloud (VPC). This way, the VPC can access the public CIDR block. For more information, see [VPC FAQ](~~185311~~).
        /// > - After you create an SSL server, the system automatically adds routes that point to the client CIDR block to the VPC route table, which is not displayed in the console by default. Do not add routes that point to the client CIDR block to the VPC route table again. Otherwise, SSL-VPN connections cannot work as expected.
        /// </summary>
        [NameInMap("ClientIpPool")]
        [Validation(Required=false)]
        public string ClientIpPool { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable data compression. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("Compress")]
        [Validation(Required=false)]
        public bool? Compress { get; set; }

        /// <summary>
        /// Specifies whether to enable two-factor authentication. If you enable two-factor authentication, you must configure `IDaaSInstanceId` and `IDaaSRegionId`. Valid values:
        /// 
        /// *   **true**: enables this feature.
        /// *   **false** (default): disables this feature.
        /// 
        /// > - Two-factor authentication supports only earlier versions of IDaaS instances. If you do not have and cannot create earlier versions of IDaaS instances, you cannot enable two-factor authentication.
        /// > - If two-factor authentication is already enabled for existing SSL servers, you can continue to use two-factor authentication.
        /// </summary>
        [NameInMap("EnableMultiFactorAuth")]
        [Validation(Required=false)]
        public bool? EnableMultiFactorAuth { get; set; }

        /// <summary>
        /// The Identity as a Service (IDaaS) instance ID.
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
        /// It is the CIDR block that your client needs to access by using the SSL-VPN connection.
        /// 
        /// This value can be the CIDR block of a VPC, a vSwitch, a data center that is connected to a VPC by using an Express Connect circuit, or an Alibaba Cloud service such as Object Storage Service (OSS).
        /// 
        /// The subnet mask of the specified local CIDR block must be 8 to 32 bits in length. You cannot specify the following CIDR blocks as the local CIDR blocks:
        /// 
        /// *   100.64.0.0~100.127.255.255
        /// *   127.0.0.0~127.255.255.255
        /// *   169.254.0.0~169.254.255.255
        /// *   224.0.0.0~239.255.255.255
        /// *   255.0.0.0~255.255.255.255
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The SSL server name.
        /// 
        /// The name must be 1 to 100 characters in length and cannot start with `http://` or `https://`.
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
        /// The port that is used by the SSL server. Valid values of port numbers: **1** to **65535**. Default value: **1194**.
        /// 
        /// The following ports are not supported: **22**, **2222**, **22222**, **9000**, **9001**, **9002**, **7505**, **80**, **443**, **53**, **68**, **123**, **4510**, **4560**, **500**, and **4500**.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The protocol that is used by the SSL server. Valid values:
        /// 
        /// *   **TCP** (default)
        /// *   **UDP**
        /// </summary>
        [NameInMap("Proto")]
        [Validation(Required=false)]
        public string Proto { get; set; }

        /// <summary>
        /// The region ID of the VPN gateway.
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
