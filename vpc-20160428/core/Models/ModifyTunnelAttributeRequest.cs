// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyTunnelAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the **client token**. The value of **RequestId** is different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the IPsec connection is established.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
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
        /// The tunnel ID.
        /// </summary>
        [NameInMap("TunnelId")]
        [Validation(Required=false)]
        public string TunnelId { get; set; }

        /// <summary>
        /// The tunnel configurations.
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeRequestTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class ModifyTunnelAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// Specifies whether to enable the dead peer detection (DPD) feature. Valid values:
            /// 
            /// *   **true**: DPD is enabled. The IPsec initiator sends DPD packets to verify the existence and availability of the IPsec peer. If no response is received from the peer within a specified period of time, the IPsec peer is considered disconnected. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.
            /// *   **false**: DPD is disabled. The IPsec initiator does not send DPD packets.
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// Specifies whether to enable NAT traversal. Valid values:
            /// 
            /// *   **true**: NAT traversal is enabled. After NAT traversal is enabled, the initiator does not check the UDP ports during Internet Key Exchange (IKE) negotiations and can automatically discover NAT gateway devices along the IPsec-VPN tunnel.
            /// *   **false**: NAT traversal is disabled.
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// The peer certificate authority (CA) certificate when you want to attach the IPsec connection to a virtual private network (VPN) gateway that uses a ShangMi (SM) certificate.
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// The Border Gateway Protocol (BGP) configurations of the tunnel.
            /// 
            /// If the BGP feature is not enabled for the tunnel, you must call the [ModifyVpnConnectionAttribute](~~120381~~) operation to enable the BGP feature for the tunnel and configure BGP.
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// The local autonomous system number (ASN). Valid values: **1** to **4294967295**.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// The BGP IP address of the tunnel. The IP address must fall into the **CIDR block** of the tunnel.
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// The CIDR block of the tunnel.
                /// 
                /// The CIDR block must fall into 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// The configurations of IKE Phase 1.
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in IKE Phase 1 negotiations.
                /// 
                /// *   Valid values when the IPsec connection is attached to a standard VPN gateway: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
                /// *   Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: **sm3**.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in IKE Phase 1 negotiations.
                /// 
                /// *   Valid values when the IPsec connection is attached to a standard VPN gateway: **aes**, **aes192**, **sha256**, **des**, and **3des**.
                /// *   Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: **sm4**.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is used in IKE Phase 1 negotiations. Unit: seconds. Valid values: **0 to 86400**.
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
                /// The Diffie-Hellman (DH) key exchange algorithm that is used in IKE Phase 1 negotiations. Valid values: **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The IKE version. Valid values: **ikev1** and **ikev2**.
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The tunnel identifier. The identifier can be up to 100 characters in length, and supports fully qualified domain names (FQDNs) and IP addresses. The default identifier is the tunnel IP address.
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// The pre-shared key that is used to verify identities between the tunnel and peer.
                /// 
                /// *   It must be 1 to 100 characters in length, and can contain letters, digits, and the following characters: ``~!`@#$%^&*()_-+={}[]|;:\",.<>/?``
                /// *   If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the [DescribeVpnConnection](~~120374~~) operation to query the pre-shared key that is generated by the system.
                /// 
                /// >  The pre-shared key that is configured for the tunnel and the tunnel peer must be the same. Otherwise, the system cannot establish the tunnel.
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// The peer identifier. The identifier can be up to 100 characters in length, and supports FQDNs and IP addresses. The default identifier is the IP address of the customer gateway associated with the tunnel.
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
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm that is used in IPsec Phase 2 negotiations.
                /// 
                /// *   Valid values when the IPsec connection is attached to a standard VPN gateway: **md5**, **sha1**, **sha256**, **sha384**, and **sha512**.
                /// *   Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: **sm3**.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm that is used in IPsec Phase 2 negotiations.
                /// 
                /// *   Valid values when the IPsec connection is attached to a standard VPN gateway: **aes**, **aes192**, **sha256**, **des**, and **3des**.
                /// *   Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: **sm4**.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The SA lifetime that is used in IPsec Phase 2 negotiations. Unit: seconds. Valid values: **0 to 86400**.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// The DH key exchange algorithm that is used in IPsec Phase 2 negotiations. Valid values: **disabled**, **group1**, **group2**, **group5**, and **group14**.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

        }

        /// <summary>
        /// The ID of the IPsec connection.
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
