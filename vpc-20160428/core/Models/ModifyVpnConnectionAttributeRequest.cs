// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically publish routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatically publishes routes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not automatically publish routes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoConfigRoute")]
        [Validation(Required=false)]
        public bool? AutoConfigRoute { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a single-tunnel mode IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EnableBgp&quot;:&quot;true&quot;,&quot;LocalAsn&quot;:&quot;65530&quot;,&quot;TunnelCidr&quot;:&quot;169.254.11.0/30&quot;,&quot;LocalBgpIp&quot;:&quot;169.254.11.1&quot;}</para>
        /// </summary>
        [NameInMap("BgpConfig")]
        [Validation(Required=false)]
        public string BgpConfig { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether the configuration of the IPsec-VPN connection takes effect immediately. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a single-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the DPD feature. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified period of time, the peer is considered disconnected. The ISAKMP SA and the corresponding IPsec SA are deleted, and the security tunnel is also deleted.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the DPD feature. The IPsec initiator does not send DPD probe packets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Specifies whether to enable NAT traversal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables NAT traversal. After NAT traversal is enabled, the IKE negotiation process skips UDP port number verification and can discover NAT gateway devices in the VPN tunnel.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables NAT traversal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a dual-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable BGP for the tunnel. Valid values: <b>true</b> or <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a single-tunnel mode IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:&quot;true&quot;,&quot;dip&quot;:&quot;192.168.1.1&quot;,&quot;sip&quot;:&quot;10.1.1.1&quot;,&quot;interval&quot;:&quot;3&quot;,&quot;retry&quot;:&quot;3&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The configuration of Phase 1 negotiation:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key, which is used for identity authentication between the VPN gateway and the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description>The key must be 1 to 100 characters in length and can contain digits, uppercase letters, lowercase letters, and the following characters. It cannot contain spaces. <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
        /// <item><description>If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key that is automatically generated by the system.<remarks>
        /// <para>The pre-shared key on the IPsec-VPN connection side must be the same as the authentication key on the on-premises data center side. Otherwise, the connection between the on-premises data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: The version of the Internet Key Exchange protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
        /// <para>  Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR-block scenarios.</para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, only <b>ikev1</b> is supported for the IKE version.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: The negotiation mode of the IKE version. Valid values: <b>main</b> and <b>aggressive</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>main</b>: Main mode. This mode offers high negotiation security.</description></item>
        /// <item><description><b>aggressive</b>: Aggressive mode. This mode offers fast negotiation and a high success rate.</description></item>
        /// </list>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, only <b>main</b> is supported for the negotiation mode.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: The encryption algorithm used in Phase 1 negotiation.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, the only valid value is <b>sm4</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: The authentication algorithm used in Phase 1 negotiation.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, or <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is normal, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, or <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, the only valid value is <b>sm3</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, or <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: The lifetime of the SA negotiated in Phase 1. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalId</b>: The identifier of the VPN gateway. The identifier can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: The identifier of the customer gateway. The identifier can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the customer gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Psk&quot;:&quot;pgw6dy7d1i8i****&quot;,&quot;IkeVersion&quot;:&quot;ikev1&quot;,&quot;IkeMode&quot;:&quot;main&quot;,&quot;IkeEncAlg&quot;:&quot;aes&quot;,&quot;IkeAuthAlg&quot;:&quot;sha1&quot;,&quot;IkePfs&quot;:&quot;group2&quot;,&quot;IkeLifetime&quot;:86400,&quot;LocalId&quot;:&quot;116.64.XX.XX&quot;,&quot;RemoteId&quot;:&quot;139.18.XX.XX&quot;}</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a single-tunnel IPsec-VPN connection.</para>
        /// <para>The configuration of Phase 2 negotiation:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecConfig.IpsecEncAlg</b>: The encryption algorithm used in Phase 2 negotiation.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi, the only valid value is <b>sm4</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecAuthAlg</b>: The authentication algorithm used in Phase 2 negotiation.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi, the only valid value is <b>sm3</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecPfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation for forwarding packets of all protocols. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecLifetime</b>: The lifetime of the security association (SA) established in Phase 2 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IpsecEncAlg&quot;:&quot;aes&quot;,&quot;IpsecAuthAlg&quot;:&quot;sha1&quot;,&quot;IpsecPfs&quot;:&quot;group2&quot;,&quot;IpsecLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// <para>The CIDR block on the VPC side that needs to communicate with the on-premises data center. This parameter is used for Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>Description of the IPsec-VPN connection routing mode:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the protected data flow mode is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.0/24,10.1.2.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.</para>
        /// <para>The name must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
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
        /// <para>The region ID of the IPsec-VPN connection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify a single-tunnel mode IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block on the on-premises data center side, used for Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>Description of the routing mode for the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the protected data flow mode is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.1.0/24,10.2.2.0/24</para>
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
        /// <para>The tunnel configurations to modify.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The instance ID of the customer gateway associated with the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cgw-1nmwbpgrp7ssqm1yn****</para>
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables the DPD feature. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified period of time, the peer is considered disconnected. The ISAKMP SA and the corresponding IPsec SA are deleted, and the security tunnel is also deleted.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disables the DPD feature. The IPsec initiator does not send DPD packets.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable NAT traversal for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables NAT traversal. After NAT traversal is enabled, the IKE negotiation process skips UDP port number verification and can discover NAT gateway devices in the VPN tunnel.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disables NAT traversal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// <para>If the current VPN gateway instance is a Chinese SM-based VPN gateway, you can modify the peer CA certificate for the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// <para>The role of the tunnel.</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: The current tunnel is the primary tunnel.</description></item>
            /// <item><description><b>slave</b>: The current tunnel is the secondary tunnel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The BGP configuration of the tunnel to modify.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The autonomous system number (ASN) on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP IP address on the Alibaba Cloud side. This address is an IP address within the BGP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The BGP CIDR block of the tunnel.</para>
                /// <para>The CIDR block must be a /30 CIDR block within 169.254.0.0/16, and cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
                /// <remarks>
                /// <para>Within a VPN gateway instance, the BGP CIDR block of each tunnel must be unique.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.0/30</para>
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// <para>The tunnel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tun-opsqc4d97wni27****</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <para>The Phase 1 negotiation configuration.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm for Phase 1 negotiation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 1 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM, the only valid value is <b>sm4</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the security association (SA) generated by Phase 1 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The negotiation mode of the IKE version. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The version of the IKE protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev1</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier on the Alibaba Cloud side, which is used for Phase 1 negotiation. The value can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.21.XX.XX</para>
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// <para>The pre-shared key, which is used for identity authentication between the tunnel and the tunnel peer.</para>
                /// <list type="bullet">
                /// <item><description><para>The key must be 1 to 100 characters in length and can contain digits, uppercase letters, lowercase letters, and the following characters. It cannot contain spaces. <c>~!\\`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></para>
                /// </description></item>
                /// <item><description><para>If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key automatically generated by the system.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The pre-shared keys of the tunnel and the tunnel peer must be the same. Otherwise, the tunnel cannot be established.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// <para>The identifier of the tunnel peer, used for Phase 1 negotiation. The value can be up to 100 characters in length and cannot contain spaces. Default value: the IP address of the customer gateway associated with the tunnel.</para>
                /// <para>RemoteId supports the FQDN format. If you use the FQDN format, set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.42.XX.XX</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The Phase 2 negotiation configuration.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm for Phase 2 negotiation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 2 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM, the only valid value is <b>sm4</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the SA generated by Phase 2 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public int? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in phase 2 negotiation.</para>
                /// <para>Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, <b>group14</b>.</para>
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
        /// <para>The ID of the IPsec-VPN connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-bp1bbi27hojx80nck****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
