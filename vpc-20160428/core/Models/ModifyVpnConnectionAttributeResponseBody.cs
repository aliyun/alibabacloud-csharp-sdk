// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeResponseBody : TeaModel {
        /// <summary>
        /// The timestamp generated when the IPsec-VPN connection was established. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The ID of the customer gateway associated with the IPsec-VPN connection.
        /// 
        /// This parameter is returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// The description of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether IPsec negotiations immediately start after the configuration takes effect. Valid values:
        /// 
        /// *   **true**: IPsec negotiations immediately start after the configuration takes effect.
        /// *   **false**: IPsec negotiations start when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// Indicates whether the DPD feature is enabled for the IPsec-VPN connection. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// 
        /// This parameter is returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values: Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// 
        /// This parameter is returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// Indicates whether BGP is enabled for the tunnel. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// This parameter is returned only by dual-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiations.
        /// 
        /// **IkeConfig** parameters are returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// The authentication algorithm in the IKE phase.
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// The encryption algorithm in the IKE phase.
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// The lifetime in the IKE phase. Unit: seconds.
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// The IKE negotiation mode.
            /// 
            /// *   **main**: This mode offers higher security during negotiations.
            /// *   **aggressive**: This mode is faster and has a higher success rate.
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// The DH group in the IKE phase.
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// The version of the IKE protocol.
            /// 
            /// *   **ikev1**
            /// *   **ikev2**
            /// 
            /// Compared with IKEv1, IKEv2 simplifies the SA negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.
            /// </summary>
            [NameInMap("IkeVersion")]
            [Validation(Required=false)]
            public string IkeVersion { get; set; }

            /// <summary>
            /// The identifier on the VPC side. The default value is the IP address of the VPN gateway. The value can be an FQDN or an IP address.
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// The pre-shared key.
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// The identifier on the data center side. The default value is the IP address of the customer gateway. The value can be a FQDN or an IP address.
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// The configuration of Phase 2 negotiations.
        /// 
        /// **IpsecConfig** parameters are returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIpsecConfig : TeaModel {
            /// <summary>
            /// The authentication algorithm in the IPsec phase.
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// The encryption algorithm in the IPsec phase.
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// The lifetime in the IPsec phase. Unit: seconds.
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// The DH group in the IPsec phase.
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// The CIDR block on the VPC side.
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// The name of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The CIDR block on the data center side.
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tunnel configuration of the IPsec-VPN connection.
        /// 
        /// **TunnelOptionsSpecification** parameters are returned only for dual-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification : TeaModel {
            [NameInMap("TunnelOptions")]
            [Validation(Required=false)]
            public List<ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
            public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions : TeaModel {
                /// <summary>
                /// The ID of the customer gateway associated with the tunnel.
                /// </summary>
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                /// <summary>
                /// Indicates whether the DPD feature is enabled for the tunnel. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public bool? EnableDpd { get; set; }

                /// <summary>
                /// Indicates whether NAT traversal is enabled for the tunnel. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public bool? EnableNatTraversal { get; set; }

                /// <summary>
                /// The IP address on the Alibaba Cloud side.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// The CA certificate of the tunnel peer.
                /// 
                /// This parameter is returned only if the VPN gateway is of the SM type.
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
                /// The tunnel status. Valid values:
                /// 
                /// *   **active**
                /// *   **updating**
                /// *   **deleting**
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The BGP configuration.
                /// </summary>
                [NameInMap("TunnelBgpConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                    /// <summary>
                    /// The ASN of the tunnel on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    /// <summary>
                    /// The BGP IP address of the tunnel on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    /// <summary>
                    /// The ASN of the tunnel peer.
                    /// </summary>
                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public long? PeerAsn { get; set; }

                    /// <summary>
                    /// The BGP IP address of the tunnel peer.
                    /// </summary>
                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    /// <summary>
                    /// The BGP CIDR block of the tunnel.
                    /// </summary>
                    [NameInMap("TunnelCidr")]
                    [Validation(Required=false)]
                    public string TunnelCidr { get; set; }

                }

                /// <summary>
                /// The tunnel ID.
                /// </summary>
                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                /// <summary>
                /// The configuration of Phase 1 negotiations.
                /// </summary>
                [NameInMap("TunnelIkeConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
                    /// <summary>
                    /// The authentication algorithm in the IKE phase.
                    /// </summary>
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    /// <summary>
                    /// The encryption algorithm in the IKE phase.
                    /// </summary>
                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    /// <summary>
                    /// The lifetime in the IKE phase. Unit: seconds.
                    /// </summary>
                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public long? IkeLifetime { get; set; }

                    /// <summary>
                    /// The IKE negotiation mode.
                    /// 
                    /// *   **main**: This mode offers higher security during negotiations.
                    /// *   **aggressive**: This mode is faster and has a higher success rate.
                    /// </summary>
                    [NameInMap("IkeMode")]
                    [Validation(Required=false)]
                    public string IkeMode { get; set; }

                    /// <summary>
                    /// The DH group in the IKE phase.
                    /// </summary>
                    [NameInMap("IkePfs")]
                    [Validation(Required=false)]
                    public string IkePfs { get; set; }

                    /// <summary>
                    /// The version of the IKE protocol.
                    /// </summary>
                    [NameInMap("IkeVersion")]
                    [Validation(Required=false)]
                    public string IkeVersion { get; set; }

                    /// <summary>
                    /// The identifier of the tunnel on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("LocalId")]
                    [Validation(Required=false)]
                    public string LocalId { get; set; }

                    /// <summary>
                    /// The pre-shared key.
                    /// </summary>
                    [NameInMap("Psk")]
                    [Validation(Required=false)]
                    public string Psk { get; set; }

                    /// <summary>
                    /// The identifier of the tunnel peer.
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
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
                    /// <summary>
                    /// The authentication algorithm in the IPsec phase.
                    /// </summary>
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    /// <summary>
                    /// The encryption algorithm in the IPsec phase.
                    /// </summary>
                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    /// <summary>
                    /// The lifetime in the IPsec phase. Unit: seconds.
                    /// </summary>
                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public long? IpsecLifetime { get; set; }

                    /// <summary>
                    /// The DH group in the IPsec phase.
                    /// </summary>
                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }

                /// <summary>
                /// The zone of the tunnel.
                /// </summary>
                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

            }

        }

        /// <summary>
        /// The health check configuration.
        /// 
        /// **VcoHealthCheck** parameters are returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// The destination IP address.
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled for the IPsec-VPN connection.
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// The interval between two consecutive health checks. Unit: seconds.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The maximum number of health check retries.
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public int? Retry { get; set; }

            /// <summary>
            /// The source IP address that is used for health checks.
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        /// <summary>
        /// The BGP configuration.
        /// 
        /// **VpnBgpConfig** parameters are returned only for single-tunnel IPsec-VPN connections.
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// Indicates whether BGP is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public string EnableBgp { get; set; }

            /// <summary>
            /// The ASN on the Alibaba Cloud side.
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public int? LocalAsn { get; set; }

            /// <summary>
            /// The BGP IP address on the Alibaba Cloud side.
            /// </summary>
            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            /// <summary>
            /// The ASN on the data center side.
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public int? PeerAsn { get; set; }

            /// <summary>
            /// The BGP IP address of the data center.
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// The negotiation state of BGP. Valid values:
            /// 
            /// *   **success**: normal
            /// *   **false**: abnormal
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The BGP CIDR block of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("TunnelCidr")]
            [Validation(Required=false)]
            public string TunnelCidr { get; set; }

        }

        /// <summary>
        /// The ID of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
