// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnAttachmentAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance to which the transit router associated with the IPsec-VPN connection belongs.
        /// </summary>
        [NameInMap("AttachInstanceId")]
        [Validation(Required=false)]
        public string AttachInstanceId { get; set; }

        /// <summary>
        /// The type of the resource that is associated with the IPsec-VPN connection. Valid values:
        /// 
        /// *   **CEN**: The IPsec-VPN connection is associated with a transit router.
        /// *   **VPNGW**: The IPsec-VPN connection is associated with a VPN gateway.
        /// *   **NO_ASSOCIATED**: The IPsec-VPN connection is not associated with any resource.
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
        /// The ID of the customer gateway associated with the IPsec-VPN connection.
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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// Indicates whether the DPD feature is enabled for the IPsec-VPN connection. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// The configuration of Phase 1 negotiations.
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// The authentication algorithm that is used in Phase 1 negotiations.
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// The encryption algorithm that is used in Phase 1 negotiations.
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// The SA lifetime that is determined by Phase 1 negotiations. Unit: seconds.
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// The negotiation mode.
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// The DH key exchange algorithm that is used in Phase 1 negotiations.
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
            /// The identifier of the IPsec-VPN connection on the Alibaba Cloud side.
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// The pre-shared key that is used for identity authentication between the VPN gateway and the data center.
            /// 
            /// >  The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the data center. Otherwise, you cannot establish a connection between the data center and the VPN gateway.
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// The identifier of the IPsec-VPN connection on the data center side.
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// The configuration of Phase 2 negotiations.
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIpsecConfig : TeaModel {
            /// <summary>
            /// The authentication algorithm that is used in Phase 2 negotiations.
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// The encryption algorithm that is used in Phase 2 negotiations.
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// The SA lifetime that is determined by Phase 2 negotiations. Unit: seconds.
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// The DH key exchange algorithm that is used in Phase 2 negotiations.
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// The CIDR block of the VPC with which the data center can communicate.
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
        /// The CIDR block of the data center with which the VPC can communicate.
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

        /// <summary>
        /// The bandwidth specification of the IPsec-VPN connection.
        /// 
        /// A value of **M** in the response indicates **Mbit/s**.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

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
        /// The health check configuration of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// The destination IP address that is used for health checks.
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled for the IPsec-VPN connection. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
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
            /// The source IP address that is used for health checks.
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        /// <summary>
        /// The BGP configuration of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// Indicates whether BGP is enabled for the IPsec-VPN connection. Valid values:
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
            public long? LocalAsn { get; set; }

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
            public long? PeerAsn { get; set; }

            /// <summary>
            /// The BGP IP address on the data center side.
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
        /// The ID of the VPN gateway associated with the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
