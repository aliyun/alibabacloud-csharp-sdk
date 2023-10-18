// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyTunnelAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the customer gateway associated with the customer gateway.
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Indicates whether DPD is enabled. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// Indicates whether NAT traversal is enabled. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// The tunnel IP address.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The peer CA certificate when a VPN gateway that uses an SM certificate is used to create the IPsec connection.
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tunnel role. Valid values:
        /// 
        /// *   **master**
        /// *   **slave**
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
        public ModifyTunnelAttributeResponseBodyTunnelBgpConfig TunnelBgpConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelBgpConfig : TeaModel {
            /// <summary>
            /// Indicates whether the BGP feature is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public bool? EnableBgp { get; set; }

            /// <summary>
            /// The local ASN.
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public long? LocalAsn { get; set; }

            /// <summary>
            /// The BGP IP address of the tunnel.
            /// </summary>
            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            /// <summary>
            /// The peer ASN.
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
            /// The CIDR block to which the tunnel BGP IP address belongs.
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
        /// The configurations of IKE Phase 1.
        /// </summary>
        [NameInMap("TunnelIkeConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelIkeConfig TunnelIkeConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIkeConfig : TeaModel {
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
            /// The DH group.
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// The IKE version. Valid values:
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
            /// The tunnel identifier. The identifier supports FQDNs and IP addresses. The default value is the tunnel IP address.
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
            /// The peer identifier. The identifier supports FQDNs and IP addresses. The default identifier is the IP address of the customer gateway associated with the tunnel.
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// The configurations of IPsec Phase 2.
        /// </summary>
        [NameInMap("TunnelIpsecConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelIpsecConfig TunnelIpsecConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIpsecConfig : TeaModel {
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
            /// The DH group.
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// The tunnel zone.
        /// </summary>
        [NameInMap("ZoneNo")]
        [Validation(Required=false)]
        public string ZoneNo { get; set; }

    }

}
