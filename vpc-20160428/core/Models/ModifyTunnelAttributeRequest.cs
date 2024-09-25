// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyTunnelAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the <b>client token</b>. The value of <b>RequestId</b> is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
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
        /// <para>The ID of the region in which the IPsec connection is established.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The tunnel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tun-gbyz2e070xzo93****</para>
        /// </summary>
        [NameInMap("TunnelId")]
        [Validation(Required=false)]
        public string TunnelId { get; set; }

        /// <summary>
        /// <para>The tunnel configurations.</para>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeRequestTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class ModifyTunnelAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the dead peer detection (DPD) feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: DPD is enabled. The IPsec initiator sends DPD packets to verify the existence and availability of the IPsec peer. If no response is received from the peer within a specified period of time, the IPsec peer is considered disconnected. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.</description></item>
            /// <item><description><b>false</b>: DPD is disabled. The IPsec initiator does not send DPD packets.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable NAT traversal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: NAT traversal is enabled. After NAT traversal is enabled, the initiator does not check the UDP ports during Internet Key Exchange (IKE) negotiations and can automatically discover NAT gateway devices along the IPsec-VPN tunnel.</description></item>
            /// <item><description><b>false</b>: NAT traversal is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// <para>The peer certificate authority (CA) certificate when you want to attach the IPsec connection to a virtual private network (VPN) gateway that uses a ShangMi (SM) certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// <para>The Border Gateway Protocol (BGP) configurations of the tunnel.</para>
            /// <para>If the BGP feature is not enabled for the tunnel, you must call the <a href="https://help.aliyun.com/document_detail/120381.html">ModifyVpnConnectionAttribute</a> operation to enable the BGP feature for the tunnel and configure BGP.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The local autonomous system number (ASN). Valid values: <b>1</b> to <b>4294967295</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP IP address of the tunnel. The IP address must fall into the <b>CIDR block</b> of the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.11.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The CIDR block of the tunnel.</para>
                /// <para>The CIDR block must fall into 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.11.0/30</para>
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// <para>The configurations of IKE Phase 1.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm that is used in IKE Phase 1 negotiations.</para>
                /// <list type="bullet">
                /// <item><description>Valid values when the IPsec connection is attached to a standard VPN gateway: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</description></item>
                /// <item><description>Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: <b>sm3</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm that is used in IKE Phase 1 negotiations.</para>
                /// <list type="bullet">
                /// <item><description>Valid values when the IPsec connection is attached to a standard VPN gateway: <b>aes</b>, <b>aes192</b>, <b>sha256</b>, <b>des</b>, and <b>3des</b>.</description></item>
                /// <item><description>Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: <b>sm4</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime that is used in IKE Phase 1 negotiations. Unit: seconds. Valid values: <b>0 to 86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The IKE negotiation mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>main:</b> This mode offers higher security during negotiations.</description></item>
                /// <item><description><b>aggressive:</b> This mode is faster and has a higher success rate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman (DH) key exchange algorithm that is used in IKE Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The IKE version. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev2</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The tunnel identifier. The identifier can be up to 100 characters in length, and supports fully qualified domain names (FQDNs) and IP addresses. The default identifier is the tunnel IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.87</para>
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// <para>The pre-shared key that is used to verify identities between the tunnel and peer.</para>
                /// <list type="bullet">
                /// <item><description>It must be 1 to 100 characters in length, and can contain letters, digits, and the following characters: <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
                /// <item><description>If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/120374.html">DescribeVpnConnection</a> operation to query the pre-shared key that is generated by the system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The pre-shared key that is configured for the tunnel and the tunnel peer must be the same. Otherwise, the system cannot establish the tunnel.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// <para>The peer identifier. The identifier can be up to 100 characters in length, and supports FQDNs and IP addresses. The default identifier is the IP address of the customer gateway associated with the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.207</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The configurations of IPsec Phase 2.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyTunnelAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm that is used in IPsec Phase 2 negotiations.</para>
                /// <list type="bullet">
                /// <item><description>Valid values when the IPsec connection is attached to a standard VPN gateway: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</description></item>
                /// <item><description>Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: <b>sm3</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm that is used in IPsec Phase 2 negotiations.</para>
                /// <list type="bullet">
                /// <item><description>Valid values when the IPsec connection is attached to a standard VPN gateway: <b>aes</b>, <b>aes192</b>, <b>sha256</b>, <b>des</b>, and <b>3des</b>.</description></item>
                /// <item><description>Valid values when the IPsec connection is attached to a VPN gateway that uses an SM certificate: <b>sm4</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime that is used in IPsec Phase 2 negotiations. Unit: seconds. Valid values: <b>0 to 86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The DH key exchange algorithm that is used in IPsec Phase 2 negotiations. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the IPsec connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-gw69vm1i71y354****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
