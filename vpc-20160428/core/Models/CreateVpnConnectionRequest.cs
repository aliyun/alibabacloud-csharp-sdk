// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnConnectionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically configure routes. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("AutoConfigRoute")]
        [Validation(Required=false)]
        public bool? AutoConfigRoute { get; set; }

        /// <summary>
        /// This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// BGP configuration:
        /// 
        /// *   **BgpConfig.EnableBgp**: specifies whether to enable BGP. Valid values: **true** and **false** (default).
        /// 
        /// *   **BgpConfig.LocalAsn:** the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: **1** to **4294967295**. Default value: **45104**.
        /// 
        ///     You can enter a value in two segments separated by a period (.). Each segment is 16 bits in length. Enter the number in each segment in decimal format.
        /// 
        ///     For example, if you enter 123.456, the ASN is 8061384. The ASN is calculated by using the following formula: 123 × 65536 + 456 = 8061384.
        /// 
        /// *   **BgpConfig.TunnelCidr**: The CIDR block of the IPsec tunnel. The CIDR block must belong to 169.254.0.0/16 and the subnet mask is 30 bits in length.
        /// 
        ///     >The CIDR block of the IPsec tunnel for each IPsec-VPN connection on a VPN gateway must be unique.
        /// 
        /// *   **LocalBgpIp**: the BGP address on the Alibaba Cloud side. It must be an IP address that falls within the CIDR block of the IPsec tunnel.
        /// 
        /// > *   Before you add BGP configurations, we recommend that you learn about how BGP works and the limits. For more information, see [VPN Gateway supports BGP dynamic routing](https://help.aliyun.com/document_detail/170235.html).
        /// > *   We recommend that you use private ASN to establish BGP connections to Alibaba Cloud. Refer to the relevant documentation for the private ASN range.
        /// </summary>
        [NameInMap("BgpConfig")]
        [Validation(Required=false)]
        public string BgpConfig { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// When you create an IPsec-VPN connection in single-tunnel mode, this parameter is required.
        /// 
        /// The ID of the customer gateway.
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Specifies whether to immediately start IPsec negotiations. Valid values:
        /// 
        /// *   **true**: immediately starts IPsec negotiations.
        /// *   **false** (default): starts IPsec negotiations when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// Specifies whether to enable the dead peer detection (DPD) feature. Valid values:
        /// 
        /// *   **true** (default) The initiator of the IPsec-VPN connection sends DPD packets to verify the existence and availability of the peer. If no feedback is received from the peer within a specified period of time, the connection fails. ISAKMP SAs and IPsec SAs are deleted. The IPsec tunnel is also deleted.
        /// *   **false**
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// Specifies whether to enable NAT traversal. Valid values:
        /// 
        /// *   **true** (default) After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the VPN tunnel.
        /// *   **false**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in dual-tunnel mode.
        /// 
        /// Specifies whether to enable the BGP feature for the tunnel. Valid values: **true** and **false**. Default value: false.
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// The health check configuration:
        /// 
        /// *   **HealthCheckConfig.enable**: specifies whether to enable health checks. Valid values: **true** and **false**. Default value: false.
        /// *   **HealthCheckConfig.dip**: the destination IP address configured for health checks.
        /// *   **HealthCheckConfig.sip:** the source IP address that is used for health checks.
        /// *   **HealthCheckConfig.interval**: the time interval of health check retries. Unit: seconds. Default value: **3**.
        /// *   **HealthCheckConfig.retry**: the maximum number of health check retries. Default value: **3**.
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// The configurations of Phase 1 negotiations:
        /// 
        /// *   **IkeConfig.Psk**: The pre-shared key that is used for authentication between the VPN gateway and the on-premises database.
        /// 
        ///     *   The key must be 1 to 100 characters in length and can contain digits, letters, and the following characters: ``~!\\`@#$%^&*()_-+={}[]|;:\\",.<>/?``
        /// 
        ///     *   If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](https://help.aliyun.com/document_detail/2526951.html) operation to query the pre-shared key that is generated by the system.
        /// 
        ///          >The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the on-premises database. Otherwise, the on-premises database and the VPN gateway cannot establish a connection.
        /// 
        /// *   **IkeConfig.IkeVersion**: the version of the Internet Key Exchange (IKE) protocol. Valid values: **ikev1** and **ikev2**. Default value: **ikev1**.
        /// 
        ///     Compared with IKEv1, IKEv2 simplifies the security association (SA) negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.
        /// 
        /// *   **IkeConfig.IkeMode**: the negotiation mode of IKE. Valid values: **main** and **aggressive**. Default value: **main**.
        /// 
        ///     *   **main:** This mode offers higher security during negotiations.
        ///     *   **aggressive:** This mode is faster and has a higher success rate.
        /// 
        /// *   **IkeConfig.IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiations.
        /// 
        ///     Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
        /// 
        /// *   **IkeConfig.IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiations.
        /// 
        ///     Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
        /// 
        /// *   **IkeConfig.IkePfs**: the Diffie-Hellman (DH) key exchange algorithm that is used in Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**. Default value: **group2**.
        /// 
        /// *   **IkeConfig.IkeLifetime**: the SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// 
        /// *   **IkeConfig.LocalId**: the identifier of the VPN gateway. The value can be up to 100 characters in length. The default value is the IP address of the VPN gateway.
        /// 
        /// *   **IkeConfig.RemoteId**: the identifier of the customer gateway. The value can be up to 100 characters in length. The default value is the IP address of the customer gateway.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// The configurations of Phase 2 negotiations:
        /// 
        /// *   **IpsecConfig.IpsecEncAlg**: the encryption algorithm that is used in Phase 2 negotiations.
        /// 
        ///     Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
        /// 
        /// *   **IpsecConfig. IpsecAuthAlg**: the authentication algorithm that is used in Phase 2 negotiations.
        /// 
        ///     Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
        /// 
        /// *   **IpsecConfig. IpsecPfs**: the DH key exchange algorithm that is used in Phase 2 negotiations. Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**. Default value: **group2**.
        /// 
        /// *   **IpsecConfig. IpsecLifetime**: the SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The CIDR block of the virtual private cloud (VPC) that needs to communicate with the on-premises database. The CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
        /// 
        /// The following routing modes are supported:
        /// 
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.
        /// 
        /// This parameter is required.
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
        /// The ID of the region where the IPsec-VPN connection is created. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is available if you create an IPsec-VPN connection in single-tunnel mode.
        /// 
        /// The certificate authority (CA) certificate. If the VPN gateway is of the ShangMi (SM) type, you need to configure a CA certificate for the peer gateway device.
        /// 
        /// *   If an SM VPN gateway is used to create the IPsec-VPN connection, this parameter is required.
        /// *   If a standard VPN gateway is used to create the IPsec-VPN connection, leave this parameter empty.
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// The CIDR block of the on-premises database that needs to communicate with the VPC. The CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.
        /// 
        /// The following routing modes are supported:
        /// 
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.
        /// *   If you set **LocalSubnet** and **RemoteSubnet** to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.
        /// 
        /// This parameter is required.
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
        /// The tag value.
        /// 
        /// The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
        /// 
        /// Each tag key corresponds to one tag value. You can specify up to 20 tag values in each call.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVpnConnectionRequestTags> Tags { get; set; }
        public class CreateVpnConnectionRequestTags : TeaModel {
            /// <summary>
            /// The tag key. The tag key cannot be an empty string.
            /// 
            /// It can be at most 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify at most 20 tag keys in each call.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// 
            /// Each tag key corresponds to one tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The tunnel configurations.
        /// 
        /// *   You can specify the parameters in the **TunnelOptionsSpecification** array if you create an IPsec-VPN connection in dual-tunnel mode.
        /// *   If you create an IPsec-VPN connection in dual-tunnel mode, you need to configure an active tunnel and a standby tunnel. Each IPsec-VPN connection supports only one active tunnel and one standby tunnel.
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<CreateVpnConnectionRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class CreateVpnConnectionRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// The ID of the customer gateway associated with the tunnel.
            /// 
            /// > *   This parameter is required if the VPN gateway supports the dual-tunnel mode.
            /// >*   You can specify the parameters in the **TunnelOptionsSpecification** array if you create an IPsec-VPN connection in dual-tunnel mode.
            /// >*   If you create an IPsec-VPN connection in dual-tunnel mode, you need to configure an active tunnel and a standby tunnel. Each IPsec-VPN connection supports only one active tunnel and one standby tunnel.
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// Specifies whether to enable DPD for the tunnel. Valid values:
            /// 
            /// *   **true** (default) The initiator of the IPsec-VPN connection sends DPD packets to verify the existence and availability of the peer. If no feedback is received from the peer within a specified period of time, the connection fails. ISAKMP SAs and IPsec SAs are deleted. The IPsec tunnel is also deleted.
            /// *   **false**
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// Specifies whether to enable NAT traversal for the tunnel. Valid values:
            /// 
            /// *   **true** (default) After NAT traversal is enabled, the verification process for the peer UDP port is deleted from IKE negotiations. In addition, the NAT gateway in the tunnel can be found.
            /// *   **false**
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// The CA certificate. If the VPN gateway is of the SM type, you must configure a CA certificate for the peer gateway device.
            /// 
            /// *   If an SM VPN gateway is used to create the IPsec-VPN connection, this parameter is required.
            /// *   If a standard VPN gateway is used to create the IPsec-VPN connection, leave this parameter empty.
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// The role of the tunnel. Valid values:
            /// 
            /// *   **master**: The tunnel is the active tunnel.
            /// *   **slave**: The tunnel is the standby tunnel.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The BGP configurations for the tunnel.
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// The ASN on the Alibaba Cloud side. Valid values: **1** to **4294967295**. Default value: **45104**.
                /// 
                /// > *   If you set **EnableTunnelsBgp** to **true**, this parameter is required.
                /// >*   Before you configure BGP, we recommend that you learn about how BGP works and its limits. For more information, see [VPN Gateway supports BGP dynamic routing](https://help.aliyun.com/document_detail/170235.html).
                /// >*   We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. For information about the range of private ASNs, see the relevant documentation.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// The BGP address on the Alibaba Cloud side. The address is an IP address that falls within the BGP CIDR block range.
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
            /// The configurations of Phase 1 negotiations.
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in Phase 1 negotiations.
                /// 
                /// Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 1 negotiations.
                /// 
                /// Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is determined by Phase 1 negotiations. Unit: seconds.
                /// 
                /// Valid values: **0** to **86400**. Default value: **86400**.
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// The negotiation mode of IKE. Valid values: **main** and **aggressive**. Default value: **main**.
                /// 
                /// *   **main**: This mode offers higher security during negotiations.
                /// *   **aggressive**: This mode is faster and has a higher success rate.
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The DH key exchange algorithm that is used in Phase 1 negotiations. Default value: **group2**.\\
                /// Valid values: **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The version of the IKE protocol. Valid values: **ikev1** and **ikev2**. Default value: **ikev1**.
                /// 
                /// Compared with IKEv1, IKEv2 simplifies the SA negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The identifier on the Alibaba Cloud side, which is used in Phase 1 negotiations. The value can be up to 100 characters in length. The default identifier is the IP address of the tunnel.
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
                /// The identifier of the tunnel peer, which is used in Phase 1 negotiations. The value can be up to 100 characters in length. The default identifier is the IP address of the customer gateway associated with the tunnel.
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
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in Phase 2 negotiations.
                /// 
                /// Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 2 negotiations.
                /// 
                /// Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is determined by Phase 2 negotiations. Unit: seconds.
                /// 
                /// Valid values: **0** to **86400**. Default value: **86400**.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// The DH key exchange algorithm that is used in Phase 2 negotiations. Default value: **group2**.
                /// 
                /// Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

        }

        /// <summary>
        /// The ID of the VPN gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
