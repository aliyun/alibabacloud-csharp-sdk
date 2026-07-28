// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically configure routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Automatically configure routes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not automatically configure routes.</para>
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
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>BGP configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: Specifies whether to enable the BGP feature. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn</b>: The autonomous system number on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
        /// <para>  You can enter the autonomous system number in the two-segment format: the first 16 bits.the last 16 bits. Enter each segment in decimal format.</para>
        /// <para>  For example, if you enter 123.456, the autonomous system number is 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr</b>: The IPsec tunnel CIDR block. The CIDR block must fall within 169.254.0.0/16 and have a mask length of 30 bits. The CIDR block cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp</b>: The BGP address on the Alibaba Cloud side. This address is an IP address within the IPsec tunnel CIDR block.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before you add BGP configurations, learn about how the dynamic routing feature works and its limits. For more information, see <a href="https://help.aliyun.com/document_detail/445767.html">Configure BGP dynamic routing</a>.</description></item>
        /// <item><description>Use a private autonomous system number to establish a BGP connection with Alibaba Cloud. Refer to the relevant documentation for the range of private autonomous system numbers.</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The customer gateway ID.</para>
        /// <remarks>
        /// <para>This parameter is required only when you create a single-tunnel IPsec-VPN connection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-p0w2jemrcj5u61un8****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the IPsec-VPN connection. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, the IPsec-VPN connection is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the configuration takes effect immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system initiates IPsec protocol negotiation immediately after the configuration is complete.</description></item>
        /// <item><description><b>false</b> (default): The system initiates IPsec protocol negotiation only when traffic enters the IPsec-VPN connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Enables the DPD feature. The IPsec initiator sends DPD packets to check the existence and availability of the peer. If no correct response is received within the specified time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.</para>
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
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable NAT traversal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Enables NAT traversal. After NAT traversal is enabled, the verification of the UDP port number is removed during IKE negotiation, and NAT gateway devices along the VPN tunnel can be discovered.</para>
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
        /// <para>This parameter is supported when you create a dual-tunnel IPsec-VPN connection.</para>
        /// <para>Specifies whether to enable the BGP dynamic routing feature for the tunnels. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// <remarks>
        /// <para>Before you add BGP configurations, learn about how the BGP dynamic routing feature works and its limits. For more information, see <a href="https://help.aliyun.com/document_detail/445767.html">Configure BGP dynamic routing</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>Health check configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HealthCheckConfig.enable</b>: Specifies whether to enable health checks. Valid values: <b>true</b> or <b>false</b> (default).</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.dip</b>: The destination IP address of the health check. Enter an IP address of the on-premises data center that can be accessed from the VPC side through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.sip</b>: The source IP address of the health check. Enter an IP address on the VPC side that can be accessed from the on-premises data center through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.interval</b>: The retry interval of the health check. Unit: seconds. Default value: <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.retry</b>: The number of retry packets sent during the health check. Default value: <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.Policy</b>: Specifies whether to withdraw published routes when the health check fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>revoke_route</b> (default): Withdraw published routes.</description></item>
        /// <item><description><b>reserve_route</b>: Do not withdraw published routes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:&quot;true&quot;,&quot;dip&quot;:&quot;192.168.1.1&quot;,&quot;sip&quot;:&quot;10.1.1.1&quot;,&quot;interval&quot;:&quot;3&quot;,&quot;retry&quot;:&quot;3&quot;,&quot;Policy&quot;: &quot;revoke_route&quot;}</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public string HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>This parameter is supported when you create a single-tunnel IPsec-VPN connection.</para>
        /// <para>Phase 1 negotiation configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key used for identity authentication between the VPN gateway and the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description>The key must be 1 to 100 characters in length and can contain digits, uppercase and lowercase letters, and the following characters. It cannot contain spaces. <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
        /// <item><description>If you do not specify a pre-shared key, the system randomly generates a string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key that is automatically generated by the system.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The pre-shared key on the IPsec-VPN connection side must be the same as the authentication key on the on-premises data center side. Otherwise, the connection between the on-premises data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: The version of the IKE protocol. Valid values: <b>ikev1</b> or <b>ikev2</b>. Default value: <b>ikev1</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: The negotiation mode. Valid values: <b>main</b> or <b>aggressive</b>. Default value: <b>main</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: The encryption algorithm used in Phase 1 negotiation. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: The authentication algorithm used in Phase 1 negotiation. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>. Default value: <b>md5</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, or <b>group14</b>. Default value: <b>group2</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: The lifetime of the SA generated in Phase 1 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalId</b>: The identifier on the Alibaba Cloud side of the IPsec-VPN connection. The identifier is limited to 100 characters in length and cannot contain spaces. The default value is empty.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: The identifier on the on-premises data center side of the IPsec-VPN connection. The identifier is limited to 100 characters in length and cannot contain spaces. The default value is the IP address of the customer gateway.</para>
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
        /// <para>Phase 2 negotiation configuration: </para>
        /// <list type="bullet">
        /// <item><description><para><b>IpsecConfig.IpsecEncAlg</b>: The encryption algorithm used in Phase 2 negotiation. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecAuthAlg</b>: The authentication algorithm used in Phase 2 negotiation. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>. Default value: <b>md5</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecPfs</b>: The Diffie-Hellman key exchange algorithm used in Phase 2 negotiation. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, or <b>group14</b>. Default value: <b>group2</b>.   </para>
        /// </description></item>
        /// <item><description><para><b>IpsecConfig.IpsecLifetime</b>: The lifetime of the SA generated in Phase 2 negotiation. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
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
        /// <para>The CIDR block on the VPC side that needs to communicate with the on-premises data center. This CIDR block is used in Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>Notes on the routing mode of the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the policy-based routing mode is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The network type of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b> (default): public network. The IPsec-VPN connection establishes an encrypted communication channel over the Internet.</description></item>
        /// <item><description><b>private</b>: private network. The IPsec-VPN connection establishes an encrypted communication channel over a private network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// <para>The region ID of the IPsec-VPN connection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The CA certificate of the peer.</para>
        /// <remarks>
        /// <para>This parameter is not in effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCert")]
        [Validation(Required=false)]
        public string RemoteCaCert { get; set; }

        /// <summary>
        /// <para>The CIDR block on the on-premises data center side that needs to communicate with the VPC. This CIDR block is used in Phase 2 negotiation.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>Notes on the routing mode of the IPsec-VPN connection:</para>
        /// <list type="bullet">
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to 0.0.0.0/0, the destination routing mode is used.</description></item>
        /// <item><description>If both <b>LocalSubnet</b> and <b>RemoteSubnet</b> are set to specific CIDR blocks, the policy-based routing mode is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.3.0/24,10.1.4.0/24</para>
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPsec-VPN connection belongs.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the resource group ID.</description></item>
        /// <item><description>If you do not specify a resource group ID, the IPsec-VPN connection belongs to the default resource group after it is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of tags to add to the IPsec-VPN connection.</para>
        /// <para>You can add up to 20 tags to an IPsec-VPN connection at a time.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVpnAttachmentRequestTags> Tags { get; set; }
        public class CreateVpnAttachmentRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. Once specified, the tag key cannot be an empty string.</para>
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
            /// <para>The tag value can be up to 128 characters in length and can be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The bandwidth specification of a single VPN tunnel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard (default): standard. The default bandwidth is 1 Gbps.</description></item>
        /// <item><description>Large: large. The default bandwidth is 3 Gbps.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("TunnelBandwidth")]
        [Validation(Required=false)]
        public string TunnelBandwidth { get; set; }

        /// <summary>
        /// <para>The tunnel configurations.</para>
        /// <list type="bullet">
        /// <item><description>The parameters in the <b>TunnelOptionsSpecification</b> array are supported when you create a dual-tunnel IPsec-VPN connection.</description></item>
        /// <item><description>When you create a dual-tunnel IPsec-VPN connection, you must add two tunnels at the same time to ensure link redundancy for the IPsec-VPN connection. Only two tunnels can be added to an IPsec-VPN connection.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<CreateVpnAttachmentRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class CreateVpnAttachmentRequestTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The customer gateway ID associated with the tunnel.</para>
            /// <remarks>
            /// <para>This parameter is required when you create a dual-tunnel IPsec-VPN connection.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cgw-p0w2jemrcj5u61un8****</para>
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Dead Peer Detection (DPD) feature for the tunnel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Enables the DPD feature. The IPsec initiator sends DPD packets to check the existence and availability of the peer. If no correct response is received within the specified time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.</para>
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
            /// <item><description><para><b>true</b> (default): Enables NAT traversal. After NAT traversal is enabled, the verification of the UDP port number is removed during IKE negotiation, and NAT gateway devices along the tunnel can be discovered.</para>
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
            /// <para>The BGP configuration for the tunnel.</para>
            /// <remarks>
            /// <para>This parameter is required when you enable BGP for the IPsec-VPN connection (set <b>EnableTunnelsBgp</b> to <b>true</b>).</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The autonomous system number on the local end (Alibaba Cloud side) of the tunnel. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
                /// <remarks>
                /// <para>We recommend that you use a private autonomous system number to establish a BGP connection with Alibaba Cloud. Refer to the relevant documentation for the range of private autonomous system numbers.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP address on the local end (Alibaba Cloud side) of the tunnel. This address is an IP address within the BGP CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The BGP CIDR block of the tunnel. The CIDR block must fall within 169.254.0.0/16 and have a mask length of 30 bits. The CIDR block cannot be 169.254.0.0/30, 169.254.1.0/30, 169.254.2.0/30, 169.254.3.0/30, 169.254.4.0/30, 169.254.5.0/30, 169.254.6.0/30, or 169.254.169.252/30.</para>
                /// <remarks>
                /// <para>The tunnel CIDR blocks of the two tunnels under an IPsec-VPN connection must be different.</para>
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
            /// <para>The Phase 1 negotiation configuration.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 1 negotiation. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>. Default value: <b>sha1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 1 negotiation. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the SA generated in Phase 1 negotiation. Unit: seconds.</para>
                /// <para>Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// <para>The negotiation mode of the IKE version. Valid values: <b>main</b> or <b>aggressive</b>. Default value: <b>main</b>.   </para>
                /// <list type="bullet">
                /// <item><description><b>main</b>: main mode. The negotiation process is more secure.</description></item>
                /// <item><description><b>aggressive</b>: aggressive mode. The negotiation is faster and has a higher success rate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation. Default value: <b>group2</b>.<br>Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, <b>group14</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The version of the IKE protocol. Valid values: <b>ikev1</b> or <b>ikev2</b>. Default value: <b>ikev2</b>.</para>
                /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR-block scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev2</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier on the local end (Alibaba Cloud side) of the tunnel, which is used in Phase 1 negotiation. The identifier is limited to 100 characters in length and cannot contain spaces. The default value is the IP address of the tunnel.</para>
                /// <para><b>LocalId</b> supports the FQDN format. If you use the FQDN format, we recommend that you set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.1</para>
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// <para>The pre-shared key used for identity authentication between the tunnel and the tunnel peer.</para>
                /// <list type="bullet">
                /// <item><description><para>The key must be 1 to 100 characters in length and can contain digits, uppercase and lowercase letters, and the following characters. It cannot contain spaces. <c>~!\\`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></para>
                /// </description></item>
                /// <item><description><para>If you do not specify a pre-shared key, the system randomly generates a 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526939.html">DescribeVpnAttachments</a> operation to query the pre-shared key that is automatically generated by the system.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The pre-shared keys of the tunnel and the tunnel peer must be the same. Otherwise, the system cannot establish the tunnel.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456****</para>
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// <para>The identifier of the tunnel peer, which is used in Phase 1 negotiation. The identifier is limited to 100 characters in length and cannot contain spaces. The default value is the IP address of the customer gateway associated with the tunnel.</para>
                /// <para><b>RemoteId</b> supports the FQDN format. If you use the FQDN format, we recommend that you set the negotiation mode to <b>aggressive</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.2</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The order in which the tunnel is created.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: the first tunnel.</description></item>
            /// <item><description><b>2</b>: the second tunnel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TunnelIndex")]
            [Validation(Required=false)]
            public int? TunnelIndex { get; set; }

            /// <summary>
            /// <para>The Phase 2 negotiation configuration.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                /// <summary>
                /// <para>The authentication algorithm used in Phase 2 negotiation.</para>
                /// <para>Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, <b>sha512</b>. Default value: <b>sha1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha1</para>
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used in Phase 2 negotiation. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, or <b>3des</b>. Default value: <b>aes</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes</para>
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// <para>The lifetime of the SA generated in Phase 2 negotiation. Unit: seconds.</para>
                /// <para>Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// <para>The Diffie-Hellman key exchange algorithm used in Phase 2 negotiation. Default value: <b>group2</b>.   </para>
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

    }

}
