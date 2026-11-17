// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically publish route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Automatically publishes route entry.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not automatically publish route entry.</para>
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
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel pattern.</para>
        /// <para>The BGP configurations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: Specifies whether to enable the BGP feature. Valid values: <b>true</b> and <b>false</b>.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn</b>: The autonomous system number (ASN) on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>.  </para>
        /// <para> You can enter the ASN in a two-part format: the first 16 bits and the last 16 bits, separated by a period. Each part must be entered in decimal format.</para>
        /// <para>  For example, if you enter 123.456, the ASN is calculated as follows: 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr</b>: The CIDR block of the IPsec tunnel. The CIDR block must be a subnet with a mask length of 30 within 169.254.0.0/16, and cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
        /// <remarks>
        /// <para>The IPsec tunnel CIDR block of each IPsec-VPN connection under the same VPN gateway instance must be unique.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp</b>: The BGP IP address on the Alibaba Cloud side. This IP address must be within the IPsec tunnel CIDR block.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the BGP dynamic routing feature is enabled for the VPN gateway.</description></item>
        /// <item><description>Before adding BGP configurations, understand the working mechanism and limits of BGP dynamic routing. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</description></item>
        /// <item><description>Use a private ASN to establish a BGP connection with Alibaba Cloud. Refer to relevant documentation for the range of private ASNs.</description></item>
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
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether the configurations of the IPsec-VPN connection take effect immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes. The system immediately initiates IPsec negotiations after the configurations are completed.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No. The system initiates IPsec negotiations only when traffic is detected.</para>
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
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>Specifies whether to enable the dead peer detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the DPD feature. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified time, the peer is considered disconnected. IPsec deletes the ISAKMP SA and the corresponding IPsec SA, and the secure tunnel is also deleted.</para>
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
        /// <para>Specifies whether to enable the NAT traversal feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the NAT traversal feature. After this feature is enabled, the IKE negotiation process skips the verification of UDP port numbers and discovers NAT gateway devices in the VPN tunnel.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the NAT traversal feature.</para>
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
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in dual-tunnel mode.</para>
        /// <para>Specifies whether to enable the BGP feature for the tunnel. Valid values: <b>true</b> and <b>false</b>.</para>
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
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The health check configurations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HealthCheckConfig.enable</b>: Specifies whether to enable health checks. Valid values: <b>true</b> and <b>false</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.dip</b>: The destination IP address for health checks.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.sip</b>: The source IP address for health checks.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.interval</b>: The retry interval for health checks. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.retry</b>: The maximum number of health check retries.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:&quot;true&quot;,&quot;dip&quot;:&quot;192.168.1.1&quot;,&quot;sip&quot;:&quot;10.1.1.1&quot;,&quot;interval&quot;:&quot;3&quot;,&quot;retry&quot;:&quot;3&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The configurations for Phase 1 negotiations: </para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key used for authentication between the VPN gateway and the data center.</para>
        /// <list type="bullet">
        /// <item><description>The key must be 1 to 100 characters in length and can contain digits, letters, and the following special characters: <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c> It cannot contain spaces.</description></item>
        /// <item><description>If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the automatically generated pre-shared key.<remarks>
        /// <para>The pre-shared key on the IPsec-VPN connection side must be the same as the authentication key on the data center side. Otherwise, the connection between the data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: The version of the IKE protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>. </para>
        /// <para>  Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR block scenarios.</para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a ShangMi (SM) gateway, only <b>ikev1</b> is supported.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: The negotiation mode of the IKE version. Valid values: <b>main</b> and <b>aggressive</b>.   </para>
        /// <list type="bullet">
        /// <item><description><b>main</b>: The main mode. The negotiation process is highly secure.</description></item>
        /// <item><description><b>aggressive</b>: The aggressive mode. The negotiation process is fast and has a high success rate.</description></item>
        /// </list>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, only <b>main</b> is supported.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: The encryption algorithm used in Phase 1 negotiations.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm4</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: The authentication algorithm used in Phase 1 negotiations.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm3</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: The SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalId</b>: The identifier of the VPN gateway. The identifier can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the VPN gateway. </para>
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
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>The configurations for Phase 2 negotiations: </para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecConfig.IpsecEncAlg</b>: The encryption algorithm used in Phase 2 negotiations.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm4</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecAuthAlg</b>: The authentication algorithm used in Phase 2 negotiations.</para>
        /// <para>  &lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
        /// <para>  &lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm3</b>.</ph></para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecPfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiations for forwarding packets of all protocols. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecLifetime</b>: The SA lifetime determined by Phase 2 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
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
        /// <para>The CIDR block on the VPC side that needs to communicate with the data center. This parameter is used for Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>Routing modes of the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the interested traffic mode is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.0/24,10.1.2.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.  </para>
        /// <para>The name must be 1 to 100 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The region ID of the IPsec-VPN connection. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you modify an IPsec-VPN connection in single-tunnel mode.</para>
        /// <para>If the current VPN gateway is an SM VPN gateway, you can modify the CA certificate of the peer.</para>
        /// <para>If the current VPN gateway is a standard VPN gateway, this parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block on the data center side. This parameter is used for Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>Routing modes of the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the interested traffic mode is used.</description></item>
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
        /// <para>The parameters in the <b>TunnelOptionsSpecification</b> array are supported only when you modify an IPsec-VPN connection in dual-tunnel mode. You can modify the configurations of both the primary and secondary tunnels of the IPsec-VPN connection at the same time.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The instance ID of the customer gateway instance associated with the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cgw-1nmwbpgrp7ssqm1yn****</para>
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the dead peer detection (DPD) feature for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables the DPD feature. The IPsec initiator sends DPD packets to check whether the peer device is alive. If no correct response is received within the specified time, the peer is considered disconnected. IPsec deletes the ISAKMP SA and the corresponding IPsec SA, and the secure tunnel is also deleted.</para>
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
            /// <para>Specifies whether to enable the NAT traversal feature for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enables the NAT traversal feature. After this feature is enabled, the IKE negotiation process skips the verification of UDP port numbers and discovers NAT gateway devices in the VPN tunnel.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disables the NAT traversal feature.</para>
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
            /// <para>If the current VPN gateway is an SM VPN gateway, you can modify the CA certificate of the peer for the tunnel.</para>
            /// <para>If the current VPN gateway is a standard VPN gateway, this parameter is not supported.</para>
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
            /// <para>The BGP configurations of the tunnel.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The autonomous system number (ASN) on the Alibaba Cloud side of the tunnel. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter can be configured or modified only after you enable the BGP feature for the IPsec-VPN connection (that is, set <b>EnableTunnelsBgp</b> to <b>true</b>).</description></item>
                /// <item><description>Before adding BGP configurations, understand the working mechanism and limits of BGP dynamic routing. For more information, see <a href="https://help.aliyun.com/document_detail/2638220.html">Configure BGP dynamic routing</a>.</description></item>
                /// <item><description>Use a private ASN to establish a BGP connection with Alibaba Cloud. Refer to relevant documentation for the range of private ASNs.</description></item>
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
                /// <para>The BGP IP address on the Alibaba Cloud side of the tunnel. This IP address must be within the BGP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The BGP CIDR block of the tunnel.</para>
                /// <para>The CIDR block must be a subnet with a mask length of 30 within 169.254.0.0/16, and cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
                /// <remarks>
                /// <para>The BGP CIDR block of each tunnel under the same VPN gateway instance must be unique.</para>
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
            /// <para>The ID of the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tun-opsqc4d97wni27****</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <para>The configurations for Phase 1 negotiations.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 1 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm3</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 1 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm4</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The negotiation mode of the IKE version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>main</b>: The main mode. The negotiation process is highly secure.</description></item>
                /// <item><description><b>aggressive</b>: The aggressive mode. The negotiation process is fast and has a high success rate.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, only <b>main</b> is supported.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The version of the IKE protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
                /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR block scenarios.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, only <b>ikev1</b> is supported.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev1</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier on the Alibaba Cloud side of the tunnel, which is used for Phase 1 negotiations. The identifier can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the tunnel.</para>
                /// <para><b>LocalId</b> supports the FQDN format. If you use the FQDN format, set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.21.XX.XX</para>
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// <para>The pre-shared key used for authentication between the tunnel and the peer.</para>
                /// <list type="bullet">
                /// <item><description><para>The key must be 1 to 100 characters in length and can contain digits, letters, and the following special characters: <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c> It cannot contain spaces.</para>
                /// </description></item>
                /// <item><description><para>If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the automatically generated pre-shared key.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The pre-shared key of the tunnel must be the same as that of the peer. Otherwise, the system cannot establish the tunnel.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// <para>The identifier of the peer, which is used for Phase 1 negotiations. The identifier can be up to 100 characters in length and cannot contain spaces. The default value is the IP address of the customer gateway associated with the tunnel.</para>
                /// <para><b>RemoteId</b> supports the FQDN format. If you use the FQDN format, set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.42.XX.XX</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The configurations for Phase 2 negotiations.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnConnectionAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 2 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm3</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 2 negotiations.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;<ph>Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is a standard gateway, valid values are <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</ph></para>
                /// <para>&lt;props=&quot;china&quot;&gt;<ph>If the VPN gateway is an SM gateway, the only valid value is <b>sm4</b>.</ph></para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The SA lifetime determined by Phase 2 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public int? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in Phase 2 negotiations.</para>
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
