// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public DescribeVpnConnectionsResponseBodyVpnConnections VpnConnections { get; set; }
        public class DescribeVpnConnectionsResponseBodyVpnConnections : TeaModel {
            [NameInMap("VpnConnection")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection> VpnConnection { get; set; }
            public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnection : TeaModel {
                /// <summary>
                /// The ID of the CEN instance to which the transit router belongs.
                /// </summary>
                [NameInMap("AttachInstanceId")]
                [Validation(Required=false)]
                public string AttachInstanceId { get; set; }

                /// <summary>
                /// The type of the resource that is associated with the IPsec-VPN connection. Valid values:
                /// 
                /// *   **CEN**: indicates that the IPsec-VPN connection is associated with a transit router of a Cloud Enterprise Network (CEN) instance.
                /// *   **NO_ASSOCIATED**: indicates that the IPsec-VPN connection is not associated with any resource.
                /// *   **VPNGW**: indicates that the IPsec-VPN connection is associated with a VPN gateway.
                /// </summary>
                [NameInMap("AttachType")]
                [Validation(Required=false)]
                public string AttachType { get; set; }

                /// <summary>
                /// The timestamp generated when the IPsec-VPN connection was established. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether the IPsec-VPN connection is associated with a transit router that belongs to another Alibaba Cloud account. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("CrossAccountAuthorized")]
                [Validation(Required=false)]
                public bool? CrossAccountAuthorized { get; set; }

                /// <summary>
                /// The ID of the customer gateway associated with the IPsec-VPN connection.
                /// </summary>
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                /// <summary>
                /// Indicates whether IPsec negotiations immediately start after the configuration takes effect. Valid values:
                /// 
                /// *   **true**: Negotiations are reinitiated after the configuration is changed.
                /// *   **false**: Negotiations are reinitiated after traffic is detected.
                /// </summary>
                [NameInMap("EffectImmediately")]
                [Validation(Required=false)]
                public bool? EffectImmediately { get; set; }

                /// <summary>
                /// Indicates whether the dead peer detection (DPD) feature is enabled for the IPsec-VPN connection. Valid values:
                /// 
                /// *   **true**: The DPD feature is enabled.
                /// 
                ///     The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specific period of time, the connection fails. Then, the ISAKMP security association (SA), IPsec SA, and IPsec tunnel are deleted.
                /// 
                /// *   **false**: The DPD feature is disabled. The initiator of the IPsec-VPN connection does not send DPD packets.
                /// </summary>
                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public bool? EnableDpd { get; set; }

                /// <summary>
                /// Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values:
                /// 
                /// *   **true**
                /// 
                ///     After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec tunnel.
                /// 
                /// *   **false**
                /// </summary>
                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public bool? EnableNatTraversal { get; set; }

                /// <summary>
                /// Indicates whether BGP is enabled for the tunnel. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("EnableTunnelsBgp")]
                [Validation(Required=false)]
                public bool? EnableTunnelsBgp { get; set; }

                /// <summary>
                /// The configuration of Phase 1 negotiations.
                /// </summary>
                [NameInMap("IkeConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig IkeConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIkeConfig : TeaModel {
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
                    /// The Diffie-Hellman (DH) group in the IKE phase.
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
                    /// The identifier of the IPsec-VPN connection on the data center side.
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
                    /// The identifier of the IPsec-VPN connection on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("RemoteId")]
                    [Validation(Required=false)]
                    public string RemoteId { get; set; }

                }

                /// <summary>
                /// The gateway IP address of the IPsec-VPN connection.
                /// 
                /// >  This parameter is returned only if the IPsec-VPN connection is associated with a transit router.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// The configuration of Phase 2 negotiations.
                /// </summary>
                [NameInMap("IpsecConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig IpsecConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionIpsecConfig : TeaModel {
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
                /// The CIDR block on the Alibaba Cloud side.
                /// 
                /// Multiple CIDR blocks are separated by commas (,).
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
                /// The network type of the IPsec-VPN connection. Valid values:
                /// 
                /// *   **public**: an encrypted connection over the Internet
                /// *   **private**: an encrypted connection over private networks
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The certificate authority (CA) certificate of the peer.
                /// </summary>
                [NameInMap("RemoteCaCertificate")]
                [Validation(Required=false)]
                public string RemoteCaCertificate { get; set; }

                /// <summary>
                /// The CIDR block on the data center side.
                /// 
                /// Multiple CIDR blocks are separated by commas (,).
                /// </summary>
                [NameInMap("RemoteSubnet")]
                [Validation(Required=false)]
                public string RemoteSubnet { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The bandwidth specification of the IPsec-VPN connection. Unit: **Mbit/s**.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The association state of the IPsec-VPN connection. Valid values:
                /// 
                /// *   **active**: The IPsec-VPN connection is associated with a VPN gateway.
                /// *   **init**: The IPsec-VPN connection is not associated with any resource and is being initialized.
                /// *   **attaching**: The IPsec-VPN connection is being associated with a transit router.
                /// *   **attached**: The IPsec-VPN connection is associated with a transit router.
                /// *   **detaching**: The IPsec-VPN connection is being disassociated from a transit router.
                /// *   **financialLocked**: The IPsec-VPN connection is locked due to overdue payments.
                /// *   **provisioning**: The IPsec-VPN connection is being prepared.
                /// *   **updating**: The IPsec-VPN connection is being updated.
                /// *   **Upgrading**: The IPsec-VPN connection is being upgraded.
                /// *   **deleted**: The IPsec-VPN connection is deleted.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The state of the IPsec-VPN connection. Valid values:
                /// 
                /// *   **ike_sa_not_established**: Phase 1 negotiations failed.
                /// *   **ike_sa_established**: Phase 1 negotiations succeeded.
                /// *   **ipsec_sa_not_established**: Phase 2 negotiations failed.
                /// *   **ipsec_sa_established**: Phase 2 negotiations succeeded.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The list of tags added to the IPsec-VPN connection.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTag Tag { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTagTag> Tag { get; set; }
                    public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTagTag : TeaModel {
                        /// <summary>
                        /// The tag key of the IPsec-VPN connection.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the IPsec-VPN connection.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the transit router with which the IPsec-VPN connection is associated.
                /// </summary>
                [NameInMap("TransitRouterId")]
                [Validation(Required=false)]
                public string TransitRouterId { get; set; }

                /// <summary>
                /// The name of the transit router.
                /// </summary>
                [NameInMap("TransitRouterName")]
                [Validation(Required=false)]
                public string TransitRouterName { get; set; }

                /// <summary>
                /// The tunnel configuration of the IPsec-VPN connection.
                /// 
                /// Parameters in **TunnelOptionsSpecification** are returned only if you query IPsec-VPN connections in dual-tunnel mode.
                /// </summary>
                [NameInMap("TunnelOptionsSpecification")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecification : TeaModel {
                    [NameInMap("TunnelOptions")]
                    [Validation(Required=false)]
                    public List<DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
                    public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptions : TeaModel {
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
                        public string EnableDpd { get; set; }

                        /// <summary>
                        /// Indicates whether NAT traversal is enabled for the tunnel. Valid values:
                        /// 
                        /// *   **false**
                        /// *   **true**
                        /// </summary>
                        [NameInMap("EnableNatTraversal")]
                        [Validation(Required=false)]
                        public string EnableNatTraversal { get; set; }

                        /// <summary>
                        /// The tunnel IP address.
                        /// </summary>
                        [NameInMap("InternetIp")]
                        [Validation(Required=false)]
                        public string InternetIp { get; set; }

                        /// <summary>
                        /// The CA certificate of the tunnel peer.
                        /// 
                        /// This parameter is returned only if the VPN gateway is of the ShangMi (SM) type.
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
                        /// *   **deleted**
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// The state of the IPsec-VPN connection. Valid values:
                        /// 
                        /// *   **ike_sa_not_established**: Phase 1 negotiations failed.
                        /// *   **ike_sa_established**: Phase 1 negotiations succeeded.
                        /// *   **ipsec_sa_not_established**: Phase 2 negotiations failed.
                        /// *   **ipsec_sa_established**: Phase 2 negotiations succeeded.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The BGP configuration.
                        /// </summary>
                        [NameInMap("TunnelBgpConfig")]
                        [Validation(Required=false)]
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                            /// <summary>
                            /// The negotiation state of BGP. Valid values:
                            /// 
                            /// *   **success**: normal
                            /// *   **false**: abnormal
                            /// </summary>
                            [NameInMap("BgpStatus")]
                            [Validation(Required=false)]
                            public string BgpStatus { get; set; }

                            /// <summary>
                            /// The ASN of the tunnel on the Alibaba Cloud side.
                            /// </summary>
                            [NameInMap("LocalAsn")]
                            [Validation(Required=false)]
                            public string LocalAsn { get; set; }

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
                            public string PeerAsn { get; set; }

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
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
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
                            public string IkeLifetime { get; set; }

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
                        public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                        public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
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
                            public string IpsecLifetime { get; set; }

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
                /// The health check configuration of the IPsec-VPN connection.
                /// </summary>
                [NameInMap("VcoHealthCheck")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck VcoHealthCheck { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVcoHealthCheck : TeaModel {
                    /// <summary>
                    /// The destination IP address.
                    /// </summary>
                    [NameInMap("Dip")]
                    [Validation(Required=false)]
                    public string Dip { get; set; }

                    /// <summary>
                    /// Indicates whether the health check feature is enabled.
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
                    /// Indicates whether advertised routes are withdrawn when the health check fails. Valid values:
                    /// 
                    /// *   **revoke_route**: Advertised routes are withdrawn.
                    /// *   **reserve_route**: Advertised routes are not withdrawn.
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// The maximum number of health check retries.
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    /// <summary>
                    /// The source IP address.
                    /// </summary>
                    [NameInMap("Sip")]
                    [Validation(Required=false)]
                    public string Sip { get; set; }

                    /// <summary>
                    /// The state of the health check. Valid values:
                    /// 
                    /// *   **success**: normal
                    /// *   **failed**: abnormal
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The BGP configuration of the IPsec-VPN connection.
                /// </summary>
                [NameInMap("VpnBgpConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig VpnBgpConfig { get; set; }
                public class DescribeVpnConnectionsResponseBodyVpnConnectionsVpnConnectionVpnBgpConfig : TeaModel {
                    /// <summary>
                    /// The authentication key of the BGP routing protocol.
                    /// </summary>
                    [NameInMap("AuthKey")]
                    [Validation(Required=false)]
                    public string AuthKey { get; set; }

                    /// <summary>
                    /// The ASN on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    /// <summary>
                    /// The BGP IP address on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    /// <summary>
                    /// The autonomous system number (ASN) of the peer.
                    /// </summary>
                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public long? PeerAsn { get; set; }

                    /// <summary>
                    /// The BGP IP address of the peer.
                    /// </summary>
                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    /// <summary>
                    /// The negotiation state of the BGP routing protocol. Valid values:
                    /// 
                    /// *   **success**: normal
                    /// *   **false**: abnormal
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The BGP CIDR block of the IPsec-VPN connection. The CIDR block falls within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
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

    }

}
