// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically advertise routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoConfigRoute")]
        [Validation(Required=false)]
        public bool? AutoConfigRoute { get; set; }

        /// <summary>
        /// <para>This parameter is supported if you modify the configurations of an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>BGP configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: specifies whether to enable BGP. Valid values: <b>true</b> and <b>false</b>.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn:</b> the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>.</para>
        /// <para>You can enter a value in two segments separated by a period (.). Each segment is 16 bits in length. Enter the number in each segment in decimal format.</para>
        /// <para>For example, if you enter 123.456, the ASN is 8061384. The ASN is calculated by using the following formula: 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr</b>: The CIDR block of the IPsec tunnel. The CIDR block must fall within 169.254.0.0/16 and the mask of the CIDR block must be 30 bits in length. The CIDR block cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
        /// <remarks>
        /// <para>The CIDR block of the IPsec tunnel for each IPsec-VPN connection on a VPN gateway must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp</b>: the BGP address on the Alibaba Cloud side. It must be an IP address that falls within the CIDR block of the IPsec tunnel.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the VPN gateway has dynamic BGP enabled.</description></item>
        /// <item><description>Before you add BGP configurations, we recommend that you learn about how BGP dynamic routing works and the limits. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</description></item>
        /// <item><description>We recommend that you use a private ASN to establish BGP connections to Alibaba Cloud. For information about the range of private ASNs, see the relevant documentation.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately start IPsec negotiations after the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: immediately starts IPsec negotiations after the configuration takes effect.</description></item>
        /// <item><description><b>false</b>: IPsec negotiations start when inbound traffic is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable the dead peer detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b>: enables the DPD feature. The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specific period of time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.</description></item>
        /// <item><description><b>false</b>: disables the DPD feature. The initiator of the IPsec-VPN connection does not send DPD packets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// <para>You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable NAT traversal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec tunnel.</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// <para>You can specify this parameter if you modify the configuration of a dual-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable BGP for the tunnel. Valid values: <b>true</b> and <b>false</b>.</para>
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
        /// <para>You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.</para>
        /// <para>The health check configuration:</para>
        /// <list type="bullet">
        /// <item><description><b>HealthCheckConfig.enable</b>: specifies whether to enable health checks. Valid values: <b>true</b> and <b>false</b>.</description></item>
        /// <item><description><b>HealthCheckConfig.dip</b>: the destination IP address that is used for health checks.</description></item>
        /// <item><description><b>HealthCheckConfig.sip</b>: the source IP address that is used for health checks.</description></item>
        /// <item><description><b>HealthCheckConfig.interval</b>: the interval between two consecutive health checks. Unit: seconds.</description></item>
        /// <item><description><b>HealthCheckConfig.retry</b>: the maximum number of health check retries.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:&quot;true&quot;,&quot;dip&quot;:&quot;192.168.1.1&quot;,&quot;sip&quot;:&quot;10.1.1.1&quot;,&quot;interval&quot;:&quot;3&quot;,&quot;retry&quot;:&quot;3&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported if you modify the configurations of an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The configurations of Phase 1 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key that is used for identity authentication between the VPN gateway and the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description>The key cannot contain space characters. The key must be 1 to 100 characters in length, and can contain digits, letters, and the following special characters: <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
        /// <item><description>If you do not specify a pre-shared key, the system randomly generates a 16-bit string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key that is automatically generated by the system.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the on-premises data center. Otherwise, connections between the on-premises data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: the version of the Internet Key Exchange (IKE) protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
        /// <para>Compared with IKEv1, IKEv2 simplifies the security association (SA) negotiation process and provides better support for scenarios with multiple CIDR blocks.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: the negotiation mode of IKE. Valid values: <b>main</b> and <b>aggressive</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>main:</b> This mode offers higher security during negotiations.</description></item>
        /// <item><description><b>aggressive:</b> This mode supports faster negotiations and a higher success rate.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: the encryption algorithm that is used in Phase 1 negotiations.</para>
        /// <para>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: the authentication algorithm that is used in Phase 1 negotiations.</para>
        /// <para>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: the Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: the SA lifetime as a result of Phase 1 negotiations. Unit: seconds Valid values: <b>0 to 86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalId</b>: the identifier of the VPN gateway. The identifier cannot exceed 100 characters in length and cannot contain space characters. The default value is the IP address of the VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: the identifier of the customer gateway. The identifier cannot exceed 100 characters in length and cannot contain space characters. The default value is the IP address of the customer gateway.</para>
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
        /// <para>You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.</para>
        /// <para>The configuration of Phase 2 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecConfig.IpsecEncAlg</b>: the encryption algorithm that is used in Phase 2 negotiations.</para>
        /// <para>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig. IpsecAuthAlg</b>: the authentication algorithm that is used in Phase 2 negotiations.</para>
        /// <para>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig. IpsecPfs</b>: the DH key exchange algorithm that is used in Phase 1 negotiations. If you specify this parameter, packets of all protocols are forwarded. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig. IpsecLifetime:</b> the SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: <b>0 to 86400</b>.</para>
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
        /// <para>The CIDR block used to connect the virtual private cloud (VPC) to the data center. The CIDR block is used in Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>The following routing modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.</description></item>
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.</description></item>
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
        /// <para>The ID of the region in which the IPsec-VPN connection is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>You can specify this parameter if you modify the configuration of a single-tunnel IPsec-VPN connection.</para>
        /// <para>If the VPN gateway uses a ShangMi (SM) certificate, you can modify the CA certificate used by the IPsec peer.</para>
        /// <para>If the VPN gateway does not use an SM certificate, you cannot specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block on the data center side. This CIDR block is used in Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>The following routing modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.</description></item>
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.</description></item>
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
        /// <para>The tunnel configurations.</para>
        /// <para>You can specify parameters in the <b>TunnelOptionsSpecification</b> array when you modify the configurations of an IPsec-VPN connection in dual-tunnel mode. You can modify the configurations of both the active and standby tunnels of the IPsec-VPN connection.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The ID of the customer gateway associated with the tunnel.</para>
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
            /// <item><description><b>true</b>: enables DPD. The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within the specified period of time, the connection fails. In this case, ISAKMP SA and IPsec SA are deleted. The security tunnel is also deleted.</description></item>
            /// <item><description><b>false</b>: disables DPD. The initiator of the IPsec-VPN connection does not send DPD packets.</description></item>
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
            /// <item><description><b>true</b>: enables NAT traversal. After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec-VPN tunnel.</description></item>
            /// <item><description><b>false</b>: disables NAT traversal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// <para>If the VPN gateway uses an SM certificate, you can modify the CA certificate used by the IPsec peer.</para>
            /// <para>If the VPN gateway does not use an SM certificate, this parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("RemoteCaCertificate")]
            [Validation(Required=false)]
            public string RemoteCaCertificate { get; set; }

            /// <summary>
            /// <para>The tunnel role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: The tunnel is an active tunnel.</description></item>
            /// <item><description><b>slave</b>: The tunnel is a standby tunnel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The Border Gateway Protocol (BGP) configurations of the tunnel.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The ASN of the tunnel on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
                /// <remarks>
                /// <para> You can specify this parameter only if <b>EnableTunnelsBgp</b> is set to <b>true</b>.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>Before you add BGP configurations, we recommend that you learn about how BGP dynamic routing works and the limits. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</para>
                /// </description></item>
                /// <item><description><para>We recommend that you use a private ASN to establish BGP connections to Alibaba Cloud. For information about the range of private ASNs, see the relevant documentation.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP IP address of the tunnel on the Alibaba Cloud side. The address is an IP address that falls within the BGP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The BGP CIDR block of the tunnel.</para>
                /// <para>The CIDR block must fall within 169.254.0.0/16 and the mask of the CIDR block must be 30 bits in length. The CIDR block cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
                /// <remarks>
                /// <para> The BGP CIDR block of each tunnel must be unique on a VPN gateway.</para>
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
            /// <para>The configurations of Phase 1 negotiations.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm that is used in Phase 1 negotiations.</para>
                /// <para>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm that is used in Phase 1 negotiations.</para>
                /// <para>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime as a result of Phase 1 negotiations. Unit: seconds Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The negotiation mode of IKE. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>main:</b> This mode offers higher security during negotiations.</description></item>
                /// <item><description><b>aggressive:</b> This mode supports faster negotiations and a higher success rate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The version of the IKE protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
                /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for scenarios with multiple CIDR blocks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev1</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier on the Alibaba Cloud side, which is used in Phase 1 negotiations. The identifier cannot exceed 100 characters in length and cannot contain space characters. The default value is the IP address of the tunnel.</para>
                /// <para><b>LocalId</b> supports fully qualified domain names (FQDNs). If you use an FQDN, we recommend that you set the negotiation mode to <b>aggressive</b>.</para>
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
                /// <item><description>The key cannot contain space characters. The key must be 1 to 100 characters in length, and can contain digits, letters, and the following special characters: <c>~!\\`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
                /// <item><description>If you do not specify a pre-shared key, the system randomly generates a 16-bit string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key that is automatically generated by the system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The tunnel and the tunnel peer must use the same pre-shared key. Otherwise, the tunnel cannot be built.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// <para>The identifier of the tunnel peer, which is used in Phase 1 negotiations. The identifier cannot exceed 100 characters in length and cannot contain space characters. The default value is the IP address of the customer gateway that is associated with the tunnel.</para>
                /// <para><b>RemoteId</b> supports FQDNs. If you use an FQDN, we recommend that you set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.42.XX.XX</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The configurations of Phase 2 negotiations.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm that is used in Phase 2 negotiations.</para>
                /// <para>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm that is used in Phase 2 negotiations.</para>
                /// <para>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime as a result of Phase 2 negotiations. Unit: seconds Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public int? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiations.</para>
                /// <para>Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
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
