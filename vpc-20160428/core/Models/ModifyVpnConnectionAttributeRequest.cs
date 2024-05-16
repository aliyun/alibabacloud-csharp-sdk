// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically advertise routes. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AutoConfigRoute")]
        [Validation(Required=false)]
        public bool? AutoConfigRoute { get; set; }

        /// <summary>
        /// This parameter is supported by single-tunnel IPsec-VPN connections.
        /// 
        /// The Border Gateway Protocol (BGP) configurations:
        /// 
        /// *   **BgpConfig.EnableBgp:** specifies whether to enable BGP. Valid values: **true** and **false**.
        /// 
        /// *   **BgpConfig.LocalAsn:** the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: **1** to **4294967295**.
        /// 
        ///     You can enter the ASN in two segments. Separate the first 16 bits of the ASN from the remaining 16 bits with a period (.). Enter the number in each segment in decimal format.
        /// 
        ///     For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.
        /// 
        /// *   **BgpConfig.TunnelCidr**: the CIDR block of the IPsec tunnel. The CIDR block must belong to 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
        /// 
        ///     > The CIDR block of the IPsec tunnel of each IPsec-VPN connection must be unique on a VPN gateway.
        /// 
        /// *   **LocalBgpIp**: the BGP IP address on the Alibaba Cloud side. This IP address must fall within the CIDR block range of the IPsec tunnel.
        /// 
        /// > - This parameter is required when the VPN gateway has dynamic BGP enabled.
        /// > - Before you configure BGP, we recommend that you learn about how BGP works and its limits. For more information, see [BGP dynamic routing ](https://help.aliyun.com/document_detail/170235.html).
        /// > - We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. For information about the range of private ASNs, see the relevant documentation.
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
        /// Specifies whether to immediately start IPsec negotiations after the configuration takes effect. Valid values:
        /// 
        /// *   **true**: immediately starts IPsec negotiations after the configuration takes effect.
        /// *   **false**: IPsec negotiations start when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.
        /// 
        /// Specifies whether to enable the dead peer detection (DPD) feature. Valid values:
        /// 
        /// *   **true:**: enables the DPD feature. The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specific period of time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.
        /// *   **false**: disables the DPD feature. The initiator of the IPsec-VPN connection does not send DPD packets.
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.
        /// 
        /// Specifies whether to enable NAT traversal. Valid values:
        /// 
        /// *   **true** After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec tunnel.
        /// *   **false**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a dual-tunnel IPsec-VPN connection.
        /// 
        /// Specifies whether to enable BGP for the tunnel. Valid values: **true** and **false**.
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.
        /// 
        /// The health check configuration:
        /// 
        /// *   **HealthCheckConfig.enable**: specifies whether to enable health checks. Valid values: **true** and **false**.
        /// *   **HealthCheckConfig.dip**: the destination IP address that is used for health checks.
        /// *   **HealthCheckConfig.sip**: the source IP address that is used for health checks.
        /// *   **HealthCheckConfig.interval**: the interval between two consecutive health checks. Unit: seconds.
        /// *   **HealthCheckConfig.retry**: the maximum number of health check retries.
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// This parameter is supported by single-tunnel IPsec-VPN connections.
        /// 
        /// The configurations of Phase 1 negotiations:
        /// 
        /// *   **IkeConfig.Psk**: the pre-shared key that is used for authentication between the VPN gateway and the data center.
        /// 
        ///     *   It must be 1 to 100 characters in length, and can contain letters, digits, and the following characters: ``~!`@#$%^&*()_-+={}[]|;:\\",.<>/?``
        ///     *   If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](https://help.aliyun.com/document_detail/2526951.html) operation to query the pre-shared key that is generated by the system.
        /// 
        ///      > The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the on-premises database. Otherwise, the on-premises database and the VPN gateway cannot establish a connection.
        /// 
        /// *   **IkeConfig.IkeVersion**: the version of the Internet Key Exchange (IKE) protocol. Valid values: **ikev1** and **ikev2**.
        /// 
        ///     Compared with IKEv1, IKEv2 simplifies the security association (SA) negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.
        /// 
        /// *   **IkeConfig.IkeMode**: the negotiation mode of IKE. Valid values: **main** and **aggressive**.
        /// 
        ///     *   **main**: This mode offers higher security during negotiations.
        ///     *   **aggressive**: This mode is faster and has a higher success rate.
        /// 
        /// *   **IkeConfig.IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiations.
        /// 
        ///     Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
        /// 
        /// *   **IkeConfig.IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiations.
        /// 
        ///     Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
        /// 
        /// *   **IkeConfig.IkePfs**: the Diffie-Hellman (DH) key exchange algorithm that is used in Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**.
        /// 
        /// *   **IkeConfig.IkeLifetime**: the security association (SA) lifetime that is determined by Phase 1 negotiations. Unit: seconds. Valid values: **0 to 86400**.
        /// 
        /// *   **IkeConfig.LocalId**: the identifier of the VPN gateway. The identifier cannot exceed 100 characters in length. The default value is the IP address of the VPN gateway.
        /// 
        /// *   **IkeConfig.RemoteId**: the identifier of the customer gateway. The identifier cannot exceed 100 characters in length. The default value is the IP address of the customer gateway.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.
        /// 
        /// The configuration of Phase 2 negotiations:
        /// 
        /// *   **IpsecConfig.IpsecEncAlg**: the encryption algorithm that is used in Phase 2 negotiations.
        /// 
        ///     Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
        /// 
        /// *   **IpsecConfig. IpsecAuthAlg**: the authentication algorithm that is used in Phase 2 negotiations.
        /// 
        ///     Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
        /// 
        /// *   **IpsecConfig. IpsecPfs**: the DH key exchange algorithm that is used in Phase 1 negotiations. If you specify this parameter, packets of all protocols are forwarded. Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**.
        /// 
        /// *   **IpsecConfig. IpsecLifetime:** the SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: **0 to 86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The CIDR block used to connect the virtual private cloud (VPC) to the data center. The CIDR block is used in Phase 2 negotiations.
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the IPsec-VPN connection is created.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.
        /// 
        /// If the VPN gateway uses a ShangMi (SM) certificate, you can modify the CA certificate used by the IPsec peer.
        /// 
        /// If the VPN gateway does not use an SM certificate, you cannot specify this parameter.
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// The CIDR block on the data center side. This CIDR block is used in Phase 2 negotiations.
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
        /// The tunnel configurations.
        /// 
        /// You can specify the parameters in **TunnelOptionsSpecification** if you modify the configuration of a dual-tunnel IPsec-VPN connection. You can modify both the active and standby tunnels of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// Specifies whether to enable the Dead Peer Detection (DPD) feature for the tunnel. Valid values:
            /// 
            /// *   **true** The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specified period of time, the connection fails. ISAKMP SA and IPsec SA are deleted. The security tunnel is also deleted.
            /// *   **false**
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// Specifies whether to enable NAT traversal for the tunnel. Valid values:
            /// 
            /// *   **true** After NAT traversal is enabled, the initiator does not check the UDP ports during Internet Key Exchange (IKE) negotiations and can automatically discover NAT gateway devices along the IPsec-VPN tunnel.
            /// *   **false**
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// If the VPN gateway uses an SM certificate, you can modify the CA certificate used by the IPsec peer.
            /// 
            /// If the VPN gateway does not use an SM certificate, this parameter is not supported.
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// The tunnel role. Valid values:
            /// 
            /// *   **master**: The tunnel is an active tunnel.
            /// *   **slave**: The tunnel is a standby tunnel.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The Border Gateway Protocol (BGP) configurations of the tunnel.
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// The ASN of the tunnel on the Alibaba Cloud side. Valid values: **1** to **4294967295**. Default value: **45104**.
                /// 
                /// > - You can specify or modify this parameter if BGP is enabled for the IPsec-VPN connection (**EnableTunnelsBgp** is set to **true**).
                /// > - Before you configure BGP, we recommend that you learn about how BGP works and its limits. For more information, see [VPN Gateway supports BGP dynamic routing](https://help.aliyun.com/document_detail/170235.html).
                /// > - We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. For information about the range of private ASNs, see the relevant documentation.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// The BGP IP address of the tunnel on the Alibaba Cloud side. The address is an IP address that falls within the BGP CIDR block range.
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// The BGP CIDR block of the tunnel. The CIDR block must belong to 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
                /// 
                /// >  The BGP CIDR block of a tunnel associated with a VPN gateway must be unique.
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// **TunnelOptionsSpecification** parameters are supported by dual-tunnel IPsec-VPN gateways. You can modify both the active and standby tunnels of the IPsec-VPN connection.
            /// 
            /// The tunnel ID.
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// The configurations of Phase 1 negotiations.
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in Phase 1 negotiations.
                /// 
                /// Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 1 negotiations.
                /// 
                /// Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**.
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// The IKE negotiation mode. Valid values:
                /// 
                /// *   **main**: This mode offers higher security during negotiations.
                /// *   **aggressive**: This mode is faster and has a higher success rate.
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The DH key exchange algorithm that is used in Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The version of the IKE protocol. Valid values: **ikev1** and **ikev2**.
                /// 
                /// Compared with IKEv1, IKEv2 simplifies the security association (SA) negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The identifier on the Alibaba Cloud side, which is used in Phase 1 negotiations. The identifier cannot exceed 100 characters in length. The default identifier is the IP address of the tunnel.
                /// 
                /// You can set **LocalId** to a fully qualified domain name (FQDN). In this case, we recommend that you set IkeMode to **aggressive**.
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// The pre-shared key, which is used for identity authentication between the tunnel and the tunnel peer.
                /// 
                /// *   The key must be 1 to 100 characters in length and can contain digits, letters, and the following characters: ``~!\\`@#$%^&*()_-+={}[]|;:\\",.<>/?``
                /// *   If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](https://help.aliyun.com/document_detail/2526951.html) operation to query the pre-shared key that is generated by the system.
                /// 
                /// >  The tunnel and the tunnel peer must use the same pre-shared key. Otherwise, the tunnel cannot be established.
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// The identifier of the tunnel peer, which is used in Phase 1 negotiations. The identifier cannot exceed 100 characters in length. The default identifier is the IP address of the customer gateway associated with the tunnel.
                /// 
                /// You can set **RemoteId** to an FQDN. In this case, we recommend that you set IkeMode to **aggressive**.
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// The configurations of Phase 2 negotiations.
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in Phase 2 negotiations.
                /// 
                /// Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 2 negotiations.
                /// 
                /// Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: **0** to **86400**.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public int? IpsecLifetime { get; set; }

                /// <summary>
                /// The DH key exchange algorithm that is used in Phase 2 negotiations.
                /// 
                /// Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

        }

        /// <summary>
        /// The ID of the IPsec-VPN connection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
