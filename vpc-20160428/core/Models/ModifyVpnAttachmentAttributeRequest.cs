// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnAttachmentAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically configure routes. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AutoConfigRoute")]
        [Validation(Required=false)]
        public bool? AutoConfigRoute { get; set; }

        /// <summary>
        /// The Border Gateway Protocol (BGP) configuration:
        /// 
        /// *   **BgpConfig.EnableBgp**: specifies whether to enable BGP. Valid values:
        /// 
        ///     *   **true**
        ///     *   **false**
        /// 
        /// *   **BgpConfig.LocalAsn**: the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: **1** to **4294967295**.
        /// 
        ///     You can enter the ASN in two segments. Separate the first 16 bits of the ASN from the remaining 16 bits with a period (.). Enter the number in each segment in decimal format.
        /// 
        ///     For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.
        /// 
        /// *   **BgpConfig.TunnelCidr:** the CIDR block of the IPsec tunnel. The CIDR block falls within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
        /// 
        /// *   **LocalBgpIp:** the BGP IP address on the Alibaba Cloud side. This IP address must fall within the CIDR block of the IPsec tunnel.
        /// 
        /// > - Before you configure BGP, we recommend that you learn how BGP dynamic routing works and the limits of using BGP dynamic routing. For more information, see [BGP dynamic routing ](~~170235~~).
        /// > - We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. Refer to the relevant documentation for the private ASN range.
        /// </summary>
        [NameInMap("BgpConfig")]
        [Validation(Required=false)]
        public string BgpConfig { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The customer gateway associated with the IPsec-VPN connection.
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Specifies whether to immediately start IPsec negotiations after the configuration takes effect. Valid values:
        /// 
        /// *   **true**: immediately starts IPsec negotiations after the configuration is complete.
        /// *   **false**: starts IPsec negotiations when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// Specifies whether to enable the dead peer detection (DPD) feature. Valid values:
        /// 
        /// *   **true**: enables the DPD feature. The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specific period of time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.
        /// *   **false**: disables the DPD feature. The initiator of the IPsec-VPN connection does not send DPD packets.
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Specifies whether to enable NAT traversal. Valid values:
        /// 
        /// *   **true** After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec tunnel.
        /// *   **false**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// The health check configurations:
        /// 
        /// *   **HealthCheckConfig.enable**: specifies whether to enable the health check feature. Valid values:
        /// 
        ///     *   **true**
        ///     *   **false**
        /// 
        /// *   **HealthCheckConfig.dip**: the destination IP address that is used for health checks. Enter the IP address on the data center side that the VPC can communicate with through the IPsec-VPN connection.
        /// 
        /// *   **HealthCheckConfig.sip**: the source IP address that is used for health checks. Enter the IP address on the VPC side that the data center can communicate with through the IPsec-VPN connection.
        /// 
        /// *   **HealthCheckConfig.interval**: the interval between two consecutive health checks. Unit: seconds.
        /// 
        /// *   **HealthCheckConfig.retry:** the maximum number of health check retries.
        /// 
        /// *   **HealthCheckConfig.Policy**: specifies whether to withdraw advertised routes when health checks fail. Valid values:
        /// 
        ///     *   **revoke_route**
        ///     *   **reserve_route**
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiations:
        /// 
        /// *   **IkeConfig.Psk**: The pre-shared key that is used for authentication between the VPN gateway and the data center.
        /// 
        ///     *   The pre-shared key must be 1 to 100 characters in length and can contain letters, digits, and the following characters: ``~ ! ` @ # $ % ^ & * () _ - + = {} [] | ; : \" , . < > / ?``
        ///     *   If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](~~120374~~) operation to query the pre-shared key that is generated by the system.
        /// 
        ///     >The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the data center. Otherwise, you cannot establish a connection between the data center and the VPN gateway.
        /// 
        /// *   **IkeConfig.IkeVersion**: the Internet Key Exchange (IKE) version. Valid values: **ikev1** and **ikev2**.
        /// 
        /// *   **IkeConfig.IkeMode**: the negotiation mode. Valid values: **main** and **aggressive**.
        /// 
        /// *   **IkeConfig.IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiations. Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
        /// 
        /// *   **IkeConfig.IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiations. Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
        /// 
        /// *   **IkeConfig.IkePfs**: the Diffie-Hellman (DH) key exchange algorithm that is used in Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**.
        /// 
        /// *   **IkeConfig.IkeLifetime**: the security association (SA) lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**.
        /// 
        /// *   **IkeConfig.LocalIdIPsec**: the identifier of the IPsec-VPN connection on the Alibaba Cloud side. The identifier can be up to 100 characters in length.
        /// 
        /// *   **IkeConfig.RemoteId**: the identifier of the IPsec-VPN connection on the data center side. The identifier can be up to 100 characters in length.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// The configuration of Phase 2 negotiations:
        /// 
        /// *   **IpsecConfig.IpsecEncAlg:** the encryption algorithm that is used in Phase 2 negotiations. Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
        /// *   **IpsecConfig. IpsecAuthAlg:** the authentication algorithm that is used in Phase 2 negotiations. Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
        /// *   **IpsecConfig. IpsecPfs:** the DH key exchange algorithm that is used in Phase 2 negotiations. Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**.
        /// *   **IpsecConfig. IpsecLifetime**: the SA lifetime determined by Phase 2 negotiations. Unit: seconds. Valid values: **0** to **86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The CIDR block of the virtual private cloud (VPC) that communicates with the data center. The CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
        /// 
        /// The following routing modes are supported:
        /// 
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The name of the IPsec-VPN connection.
        /// 
        /// The name must be 1 to 100 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The network type of the IPsec-VPN connection. Valid values:
        /// 
        /// *   **public**: an encrypted connection over the Internet
        /// *   **private**: an encrypted connection over private networks
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// The ID of the region in which the IPsec-VPN connection is established.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The peer CA certificate when a ShangMi (SM) VPN gateway is used to create the IPsec-VPN connection.
        /// </summary>
        [NameInMap("RemoteCaCert")]
        [Validation(Required=false)]
        public string RemoteCaCert { get; set; }

        /// <summary>
        /// The CIDR block of the data center that communicates with the VPC. This CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.
        /// 
        /// The following routing modes are supported:
        /// 
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
