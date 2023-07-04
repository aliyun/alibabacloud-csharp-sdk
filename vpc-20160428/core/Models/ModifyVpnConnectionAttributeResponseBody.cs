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
        /// The ID of the customer gateway.
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
        /// *   **true:** IPsec negotiations immediately start after the configuration takes effect.
        /// *   **false:** IPsec negotiations start when inbound traffic is detected.
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// Indicates whether DPD is enabled. Valid values:
        /// 
        /// *   **false:** The DPD feature is disabled.
        /// *   **true:** The DPD feature is enabled.
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Indicates whether NAT traversal is enabled. Valid values:
        /// 
        /// *   **false:** NAT traversal is disabled.
        /// *   **true:** NAT traversal is enabled.
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// The configurations of Phase 1 negotiations.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// The IKE authentication algorithm.
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// The IKE encryption algorithm.
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// The IKE lifetime. Unit: seconds.
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// The IKE negotiation mode. Valid values:
            /// 
            /// *   **main:** This mode offers higher security during negotiations.
            /// *   **aggressive:** This mode is faster and has a higher success rate.
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// The Diffie-Hellman group.
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
            /// The identifier on the data center side. The default value is the IP address of the customer gateway. The value can be a fully qualified domain name (FQDN) or an IP address.
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// The configurations of Phase 2 negotiations.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIpsecConfig : TeaModel {
            /// <summary>
            /// The IPsec authentication algorithm.
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// The IPsec encryption algorithm.
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// The IPsec lifetime. Unit: seconds.
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// The Diffie-Hellman group.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification : TeaModel {
            [NameInMap("TunnelOptions")]
            [Validation(Required=false)]
            public List<ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
            public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions : TeaModel {
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public bool? EnableDpd { get; set; }

                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public bool? EnableNatTraversal { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("RemoteCaCertificate")]
                [Validation(Required=false)]
                public string RemoteCaCertificate { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TunnelBgpConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                    [NameInMap("BgpStatus")]
                    [Validation(Required=false)]
                    public string BgpStatus { get; set; }

                    [NameInMap("EnableBgp")]
                    [Validation(Required=false)]
                    public bool? EnableBgp { get; set; }

                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public long? PeerAsn { get; set; }

                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    [NameInMap("TunnelCidr")]
                    [Validation(Required=false)]
                    public string TunnelCidr { get; set; }

                }

                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                [NameInMap("TunnelIkeConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public long? IkeLifetime { get; set; }

                    [NameInMap("IkeMode")]
                    [Validation(Required=false)]
                    public string IkeMode { get; set; }

                    [NameInMap("IkePfs")]
                    [Validation(Required=false)]
                    public string IkePfs { get; set; }

                    [NameInMap("IkeVersion")]
                    [Validation(Required=false)]
                    public string IkeVersion { get; set; }

                    [NameInMap("LocalId")]
                    [Validation(Required=false)]
                    public string LocalId { get; set; }

                    [NameInMap("Psk")]
                    [Validation(Required=false)]
                    public string Psk { get; set; }

                    [NameInMap("RemoteId")]
                    [Validation(Required=false)]
                    public string RemoteId { get; set; }

                }

                [NameInMap("TunnelIpsecConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public long? IpsecLifetime { get; set; }

                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }

                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

            }

        }

        /// <summary>
        /// The health check configurations.
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// The destination IP address that was used for health checks.
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled. Valid values:
            /// 
            /// *   **true:** The health check feature is enabled.
            /// *   **false:** The health check feature is disabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// The interval between two consecutive health check retries. Unit: seconds.
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
            /// The source IP address that was used for health checks.
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        /// <summary>
        /// The BGP configurations.
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// Indicates whether BGP is enabled. Valid values:
            /// 
            /// *   **true:** BGP is enabled.
            /// *   **false:** BGP is disabled.
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
            /// The BGP IP address on the data center side.
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// The negotiation status of BGP. Valid values:
            /// 
            /// *   **success:** normal.
            /// *   **false:** abnormal.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The CIDR block of the IPsec tunnel.
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
