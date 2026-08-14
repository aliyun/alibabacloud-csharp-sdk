// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically configure routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Automatically configures routes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not automatically configure routes.</para>
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
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The BGP configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: specifies whether to enable BGP. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn</b>: the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
        /// <para>  You can enter the ASN in the two-segment notation: the first 16 bits.the last 16 bits. Each segment is entered in decimal format.</para>
        /// <para>  For example, if you enter 123.456, the ASN is 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr</b>: the CIDR block of the IPsec tunnel. The CIDR block must be a /30 subnet within 169.254.0.0/16, and cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
        /// <remarks>
        /// <para>The IPsec tunnel CIDR block of each IPsec-VPN connection under a VPN gateway instance must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp</b>: the BGP IP address on the Alibaba Cloud side. This address must be an IP address within the IPsec tunnel CIDR block.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before you configure BGP, we recommend that you familiarize yourself with how BGP dynamic routing works and its limits. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</description></item>
        /// <item><description>We recommend that you use a private ASN to establish a BGP connection with Alibaba Cloud. Refer to the relevant documentation for the private ASN range.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EnableBgp&quot;:&quot;true&quot;,&quot;LocalAsn&quot;:&quot;45104&quot;,&quot;TunnelCidr&quot;:&quot;169.254.11.0/30&quot;,&quot;LocalBgpIp&quot;:&quot;169.254.11.1&quot;}</para>
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
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is supported and required when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-p0w2jemrcj5u61un8****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the IPsec-VPN connection configuration takes effect immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The system immediately initiates IPsec protocol negotiation after the configuration is complete.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): The system initiates IPsec protocol negotiation only when inbound traffic is detected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): DPD is enabled. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified period of time, the peer is considered disconnected. The ISAKMP SA and the corresponding IPsec SA are deleted, and the security tunnel is also deleted.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: DPD is disabled. The IPsec initiator does not send DPD probe packets.</para>
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
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Specifies whether to enable NAT traversal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Enables NAT traversal. After NAT traversal is enabled, the IKE negotiation process skips UDP port number verification and can discover NAT gateway devices in the VPN tunnel.</para>
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
        /// <para>This parameter is supported when you create an IPsec-VPN connection in dual-tunnel mode.</para>
        /// <para>Specifies whether to enable BGP for the tunnel. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Health check configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HealthCheckConfig.enable</b>: Specifies whether to enable health checks. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.dip</b>: The destination IP address of the health check.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.sip</b>: The source IP address of the health check.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.interval</b>: The retry interval of the health check. Unit: seconds. Default value: <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.retry</b>: The number of retry packets sent during the health check. Default value: <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:&quot;true&quot;,&quot;dip&quot;:&quot;192.168.10.1&quot;,&quot;sip&quot;:&quot;10.10.1.1&quot;,&quot;interval&quot;:&quot;3&quot;,&quot;retry&quot;:&quot;3&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Phase 1 negotiation configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key used for identity authentication between the VPN gateway and the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description><para>The key must be 1 to 100 characters in length and can contain digits, uppercase letters, lowercase letters, and the following characters. It cannot contain spaces. <c>~!\\`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></para>
        /// </description></item>
        /// <item><description><para>If you do not specify a pre-shared key, the system generates a random string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key automatically generated by the system.     </para>
        /// <remarks>
        /// <para>The pre-shared key on the IPsec-VPN connection side must be the same as the authentication key on the on-premises data center side. Otherwise, the connection between the on-premises data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: The version of the Internet Key Exchange protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>. Default value: <b>ikev1</b>.  </para>
        /// <para>  Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR-block scenarios.</para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, only <b>ikev1</b> is supported for the IKE version.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: The negotiation mode of the IKE version. Valid values: <b>main</b> and <b>aggressive</b>. Default value: <b>main</b>.   </para>
        /// <list type="bullet">
        /// <item><description><b>main</b>: Main mode. This mode offers high negotiation security.</description></item>
        /// <item><description><b>aggressive</b>: Aggressive mode. This mode supports rapid negotiation and a higher success rate.</description></item>
        /// </list>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, only <b>main</b> is supported for the negotiation mode.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: The encryption algorithm used in Phase 1 negotiation.</para>
        /// <para> &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>. Default value: <b>aes</b>. </ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;If the VPN gateway instance type is normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>. Default value: <b>aes</b>.</para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, the value is <b>sm4</b> (default).</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: The authentication algorithm used in Phase 1 negotiation.</para>
        /// <para> &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is normal, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM-based, the value is <b>sm3</b> (default).</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>. Default value: <b>group2</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: The lifetime of the SA generated in Phase 1 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalId</b>: The identifier of the VPN gateway. The value is limited to 100 characters and cannot contain spaces. Default value: the IP address of the VPN gateway. </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: The identifier of the customer gateway. The value is limited to 100 characters and cannot contain spaces. Default value: the IP address of the customer gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Psk&quot;:&quot;1234****&quot;,&quot;IkeVersion&quot;:&quot;ikev1&quot;,&quot;IkeMode&quot;:&quot;main&quot;,&quot;IkeEncAlg&quot;:&quot;aes&quot;,&quot;IkeAuthAlg&quot;:&quot;sha1&quot;,&quot;IkePfs&quot;:&quot;group2&quot;,&quot;IkeLifetime&quot;:86400,&quot;LocalId&quot;:&quot;47.XX.XX.1&quot;,&quot;RemoteId&quot;:&quot;47.XX.XX.2&quot;}</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public string IkeConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>The configuration of Phase 2 negotiation:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecConfig.IpsecEncAlg</b>: The encryption algorithm used in Phase 2 negotiation.</para>
        /// <para> &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>. </ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Standard, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.</ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM, the value is <b>sm4</b> (default).</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecAuthAlg</b>: The authentication algorithm used in Phase 2 negotiation.</para>
        /// <para> &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, or <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Standard, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, or <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
        /// <para> &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Chinese SM, the value is <b>sm3</b> (default).</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecPfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 2 negotiation. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, or <b>group14</b>. Default value: <b>group2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecLifetime</b>: The lifetime of the security association (SA) established in Phase 2 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
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
        /// <para>The CIDR block on the VPC side that needs to communicate with the on-premises data center. This is used for Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>Description of the routing mode for the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the protected data flow mode is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.1.0/24,10.10.2.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.</para>
        /// <para>The name must be 1 to 100 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPsec</para>
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
        /// <para>The region ID of the IPsec-VPN connection. You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create an IPsec-VPN connection in single-tunnel mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block of the on-premises data center that needs to communicate with the VPC. This is used for Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>Description of the IPsec-VPN connection routing mode:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the protected data flow mode is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.3.0/24,10.10.4.0/24</para>
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
        /// <para>The list of tags to add to the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVpnConnectionRequestTags> Tags { get; set; }
        public class CreateVpnConnectionRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. This value cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tunnel configurations.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<CreateVpnConnectionRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class CreateVpnConnectionRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The ID of the customer gateway associated with the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cgw-p0wy363lucf1uyae8****</para>
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Enables the DPD feature. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified period of time, the peer is considered disconnected. The ISAKMP SA and the corresponding IPsec SA are deleted, and the security tunnel is also deleted.</para>
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
            /// <item><description><para><b>true</b> (default): Enables NAT traversal. After NAT traversal is enabled, the IKE negotiation process skips UDP port number verification and can discover NAT gateway devices in the tunnel.</para>
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
            /// <para>If the current VPN gateway instance is a Chinese SM-based VPN gateway, you must configure the peer CA certificate for the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// <para>The role of the tunnel. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The BGP configuration for the tunnel.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The autonomous system number (ASN) on the Alibaba Cloud side of the tunnel. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is required when BGP is enabled for the IPsec-VPN connection (the <b>EnableTunnelsBgp</b> parameter is set to <b>true</b>).</description></item>
                /// <item><description>Before you configure BGP, we recommend that you familiarize yourself with how BGP dynamic routing works and its limits. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</description></item>
                /// <item><description>Use a private ASN to establish a BGP connection with Alibaba Cloud. Refer to the relevant documentation for the private ASN range.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP address of the tunnel on the Alibaba Cloud side. The address is an IP address within the BGP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The BGP CIDR block of the tunnel. The CIDR block must be a CIDR block within 169.254.0.0/16 with a mask length of 30 and cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.0/30</para>
                /// </summary>
                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            /// <summary>
            /// <para>The Phase 1 negotiation configuration.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 1 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi, the value is <b>sm3</b> (default).</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 1 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>. </ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi (China Cryptographic Algorithm), the value is <b>sm4</b> (default value).</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the Security Association (SA) negotiated in Phase 1. Unit: seconds.</para>
                /// <para>Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The negotiation mode of the IKE version. Valid values: <b>main</b> and <b>aggressive</b>. Default value: <b>main</b>.</para>
                /// <list type="bullet">
                /// <item><description><b>main</b>: Main mode. This mode offers high negotiation security.</description></item>
                /// <item><description><b>aggressive</b>: Aggressive mode. This mode offers fast negotiation and a high negotiation success rate.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is China Encryption, only <b>main</b> is supported as the negotiation mode.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in the first-phase negotiation. Default value: <b>group2</b>.</para>
                /// <para>Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The version of the IKE protocol. Valid values: <b>ikev1</b> or <b>ikev2</b>. Default value: <b>ikev1</b>.</para>
                /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR-block scenarios.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is China Encryption, only <b>ikev1</b> is supported for the IKE version.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev1</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier of the tunnel on the Alibaba Cloud side, which is used for Phase 1 negotiation. The value can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the tunnel.</para>
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
                /// <para>The identifier of the tunnel peer, which is used for Phase 1 negotiation. The value can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the customer gateway associated with the tunnel.</para>
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
            public CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class CreateVpnConnectionRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 2 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi, the value is <b>sm3</b> (default).</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 2 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>. </ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is Normal, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway instance type is ShangMi, the value is <b>sm4</b> (default value).</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the SA negotiated in Phase 2. Unit: seconds.</para>
                /// <para>Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in the second phase of negotiation. Default value: <b>group2</b>.</para>
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
        /// <para>The instance ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
