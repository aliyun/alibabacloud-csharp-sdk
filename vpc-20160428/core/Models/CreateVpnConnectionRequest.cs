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
        /// The Border Gateway Protocol (BGP) configuration:
        /// 
        /// *   **BgpConfig.EnableBgp**: specifies whether to enable BGP. Valid values: **true** and **false**. Default value: false.
        /// *   **BgpConfig.LocalAsn**: the ASN on the Alibaba Cloud side. Valid values: **1** to **4294967295**. Default value: **45104**.
        /// *   **BgpConfig.TunnelCidr**: the CIDR block of the IPsec tunnel. The CIDR block must fall within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
        /// *   **LocalBgpIp**: the BGP IP address on the Alibaba Cloud side. This IP address must fall within the CIDR block of the IPsec tunnel.
        /// 
        /// > 
        /// 
        /// *   This parameter is required when the VPN gateway has dynamic BGP enabled.
        /// 
        /// *   Before you configure BGP, we recommend that you learn about how BGP works and its limits. For more information, see [VPN Gateway supports BGP dynamic routing](~~170235~~).
        /// *   We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. Refer to the relevant documentation for the private ASN range.
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
        /// The ID of the customer gateway.
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Specify whether to immediately start IPsec negotiations after the configuration takes effect. Valid values:
        /// 
        /// *   **true**: immediately starts IPsec negotiations after the configuration is complete.
        /// *   **false** (default): starts IPsec negotiations when inbound traffic is received.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// Specifies whether to enable the dead peer detection (DPD) feature. Valid values:
        /// 
        /// *   **true** (default) The initiator of the IPsec-VPN connection sends DPD packets to verify the existence and availability of the peer. If no response is received from the peer within a specified period of time, the connection fails. ISAKMP SAs and IPsec SAs are deleted. The IPsec tunnel is also deleted.
        /// *   **false**: disables DPD. The IPsec initiator does not send DPD packets.
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Specifies whether to enable NAT traversal. Valid values:
        /// 
        /// *   **true** (default) After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the VPN tunnel.
        /// *   **false**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// Specifies whether to enable the BGP feature for the tunnel. Valid values: **true** and **false**. Default value: **false**.
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
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
        /// The configuration of Phase 1 negotiations:
        /// 
        /// *   **IkeConfig.Psk**: The pre-shared key that is used for authentication between the VPN gateway and the data center. The key must be 1 to 100 characters in length.
        /// 
        ///         If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the DescribeVpnConnection operation to query the pre-shared key generated by the system. 
        /// 
        ///           The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the data center. Otherwise, the connection between the data center and the VPN gateway cannot be established. 
        /// 
        /// *   **IkeConfig.IkeVersion**: the IKE version. Valid values: **ikev1** and **ikev2**. Default value: **ikev1**.
        /// 
        /// *   **IkeConfig.IkeMode**: the negotiation mode of IKEv1. Valid values: **main** and **aggressive**. Default value: **main**.
        /// 
        /// *   **IkeConfig.IkeEncAlg**: the encryption algorithm that is used in Phase 1 negotiations. Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
        /// 
        /// *   **IkeConfig.IkeAuthAlg**: the authentication algorithm that is used in Phase 1 negotiations. Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
        /// 
        /// *   **IkeConfig.IkePfs**: The Diffie-Hellman (DH) key exchange algorithm that is used in Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**. Default value: **group2**.
        /// 
        /// *   **IkeConfig.IkeLifetime**: the SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// 
        /// *   **IkeConfig.LocalId**: the identifier of the VPN gateway. The identifier of the VPN gateway cannot exceed 100 characters in length. The default value is the IP address of the VPN gateway.
        /// 
        /// *   **IkeConfig.RemoteId**: the identifier of the customer gateway. The identifier of the customer gateway cannot exceed 100 characters in length. The default value is the IP address of the customer gateway.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// The configurations of Phase 2 negotiations:
        /// 
        /// *   **IpsecConfig.IpsecEncAlg**: the encryption algorithm that is used in Phase 2 negotiations. Valid values: **aes**, **aes192**, **aes256**, **des**, and **3des**. Default value: **aes**.
        /// *   **IpsecConfig. IpsecAuthAlg**: the authentication algorithm that is used in Phase 2 negotiations. Valid values: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**. Default value: **md5**.
        /// *   **IpsecConfig. IpsecPfs**: the Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiations. Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**. Default value: **group2**.
        /// *   **IpsecConfig. IpsecLifetime**: the SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: **0** to **86400**. Default value: **86400**.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// The CIDR block on the virtual private cloud (VPC) side. The CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.
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
        /// The ID of the region where the IPsec-VPN connection is created. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The peer CA certificate when a ShangMi (SM) VPN gateway is used to establish the IPsec-VPN connection.
        /// 
        /// *   This parameter is required when an SM VPN gateway is used to establish the IPsec-VPN connection.
        /// *   You can ignore this parameter when a standard VPN gateway is used to create the IPsec-VPN connection.
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// The CIDR block on the data center side. This CIDR block is used in Phase 2 negotiations.
        /// 
        /// Separate CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.
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
        /// TunnelOptionsSpecification parameters are supported by dual-tunnel IPsec-VPN gateways. You can modify both the active and standby tunnels of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<CreateVpnConnectionRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class CreateVpnConnectionRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// The ID of the customer gateway associated with the tunnel. 
            /// 
            /// > - This parameter is required if the VPN gateway supports the dual-tunnel mode. 
            /// > - If the VPN gateway supports the dual-tunnel mode, you need to configure the active tunnel and standby tunnel by specifying the parameters in the **TunnelOptionsSpecification** array. Each IPsec-VPN connection supports only one active tunnel and one standby tunnel.
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// Specifies whether to enable the DPD feature for the tunnel. Valid values:
            /// 
            /// - **true** (default): The initiator of the IPsec-VPN connection sends DPD packets to verify the existence and availability of the peer. If no feedback is received from the peer within a specified period of time, the connection fails. ISAKMP SAs and IPsec SAs are deleted. The IPsec tunnel is also deleted. 
            /// - **false**
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// Specifies whether to enable NAT traversal for the tunnel. Valid values:
            /// 
            /// - **true** (default): After NAT traversal is enabled, the verification process for the peer UDP port is deleted from IKE negotiations. In addition, the NAT gateway in the tunnel can be found. 
            /// 
            /// - **false**: no
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// If the VPN gateway is of the SM type, you need to configure a CA certificate for the peer gateway device. 
            /// 
            /// - This parameter is required for an SM VPN gateway. 
            /// - You can ignore this parameter when a standard VPN gateway is used to create the IPsec-VPN connection.
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// The tunnel role. Valid values: 
            /// 
            /// - **master**
            /// - **slave**
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The BGP configurations.
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// The autonomous system number (ASN) on the Alibaba Cloud side. Valid values: **1** to **4294967295**. Default value: **45104**. 
                /// 
                /// > - After you enable BGP for the IPsec-VPN connection, you need to set **EnableTunnelsBgp** to true. 
                /// > - Before you configure BGP, we recommend that you learn about how BGP works and its limits. For more information, see [VPN Gateway supports BGP dynamic routing](~~170235~~).
                /// > - We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. Refer to the relevant documentation for the private ASN range.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// The BGP address on the Alibaba Cloud side. The address is an IP address that falls within the BGP CIDR block.
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// The BGP CIDR block of the tunnel. The CIDR block must belong to 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length. 
                /// 
                /// >The BGP CIDR block of each tunnel on a VPN gateway must be unique.
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// The configuration of Phase 1 negotiations.
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in Phase 1 negotiations. 
                /// 
                /// <props="intl"><ph>Valid values: **md5**, **sha1**, **sha256**, **sha384**, **sha512**. Default value: **md5**. </ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为普通型，则取值：**md5**、**sha1**、**sha256**、**sha384**、**sha512**。默认值：**md5**。</ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则取值为**sm3**（默认值）。</ph></props>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 1 negotiations. 
                /// 
                /// <props="intl"><ph>Valid values: **aes**, **aes192**, **aes256**, **des**, **3des**. Default value: **aes**. </ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为普通型，则取值为**aes**、**aes192**、**aes256**、**des**或**3des**。默认值：**aes**。</ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则取值为**sm4**（默认值）。</ph></props>
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
                /// The IKE negotiation mode. Valid values: **main** and **aggressive**. Default value: **main**. 
                /// 
                /// - **main**: This mode offers higher security during negotiations. 
                /// - **aggressive**: This mode is faster and has a higher success rate. 
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则协商模式仅支持**main**。</ph></props>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. 
                /// Default value: **group2**. Valid values: **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The IKE version. Valid values: **ikev1** and **ikev2**. Default value: **ikev1**. 
                /// Compared with IKEv1, IKEv2 simplifies the SA negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used. 
                ///    
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则IKE版本仅支持**ikev1**。</ph></props>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The identifier on the Alibaba Cloud side, which is used in Phase 1 negotiations. 
                /// The description can be up to 100 characters in length. The default identifier is the tunnel IP address. 
                /// You can set **LocalId** to a fully qualified domain name (FQDN). In this case, we recommend that you set Negotiation Mode to **aggressive**.
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// The pre-shared key, which is used for identity authentication between the tunnel and the tunnel peer. 
                /// 
                /// - The key must be 1 to 100 characters in length and can contain digits, letters, and the following characters: ```~!\`@#$%^&*()_-+={}[]|;:\",.<>/?```
                /// - If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](~~120374~~) operation to query the pre-shared key that is generated by the system. 
                /// 
                /// > Make sure that the tunnel and peer use the same pre-shared key. Otherwise, tunnel communication cannot be established.
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// The identifier of the tunnel peer, which is used in Phase 1 negotiations. 
                /// The description can be up to 100 characters in length. The default identifier is the IP address of the customer gateway. 
                /// You can set **RemoteId** to an FQDN. In this case, we recommend that you set Negotiation Mode to **aggressive**.
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// The configuration of Phase 2 negotiations.
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that was used in Phase 2 negotiations. 
                /// 
                /// <props="intl"><ph>Valid values: **md5**, **sha1**, **sha256**, **sha384**, **sha512**. Default value: **md5**. </ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为普通型，则取值：**md5**、**sha1**、**sha256**、**sha384**、**sha512**。默认值：**md5**。</ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则取值为**sm3**（默认值）。</ph></props>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in Phase 2 negotiations. 
                /// 
                /// <props="intl"><ph>Valid values: **aes**, **aes192**, **aes256**, **des**, **3des**. Default value: **aes**. </ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为普通型，则取值为**aes**、**aes192**、**aes256**、**des**或**3des**。默认值：**aes**。</ph></props>
                /// 
                /// <props="china"><ph>如果VPN网关实例类型为国密型，则取值为**sm4**（默认值）。</ph></props>
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
                /// The Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiations. Default value: **group2**. 
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
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
