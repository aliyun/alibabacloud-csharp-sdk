// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnAttachmentAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically configure routes. Valid values:</para>
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
        /// <para>The Border Gateway Protocol (BGP) configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: specifies whether to enable BGP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn</b>: the autonomous system number (ASN) on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>.</para>
        /// <para>You can enter the ASN in two segments. Separate the first 16 bits of the ASN from the remaining 16 bits with a period (.). Enter the number in each segment in decimal format.</para>
        /// <para>For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr:</b> the CIDR block of the IPsec tunnel. The CIDR block falls within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.</para>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp:</b> the BGP IP address on the Alibaba Cloud side. This IP address must fall within the CIDR block of the IPsec tunnel.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before you configure BGP, we recommend that you learn how BGP dynamic routing works and the limits of using BGP dynamic routing. For more information, see <a href="https://help.aliyun.com/document_detail/170235.html">BGP dynamic routing </a>.</description></item>
        /// <item><description>We recommend that you use a private ASN to establish a connection with Alibaba Cloud over BGP. Refer to the relevant documentation for the private ASN range.</description></item>
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
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The customer gateway associated with the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-p0w2jemrcj5u61un8****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately start IPsec negotiations after the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: immediately starts IPsec negotiations after the configuration is complete.</description></item>
        /// <item><description><b>false</b>: starts IPsec negotiations when inbound traffic is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dead peer detection (DPD) feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the DPD feature. The initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no feedback is received from the peer within a specific period of time, the connection fails. Then, the ISAKMP SA, IPsec SA, and IPsec tunnel are deleted.</description></item>
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
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>The health check configurations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HealthCheckConfig.enable</b>: specifies whether to enable the health check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.dip</b>: the destination IP address that is used for health checks. Enter the IP address on the data center side that the VPC can communicate with through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.sip</b>: the source IP address that is used for health checks. Enter the IP address on the VPC side that the data center can communicate with through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.interval</b>: the interval between two consecutive health checks. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.retry:</b> the maximum number of health check retries.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.Policy</b>: specifies whether to withdraw advertised routes when health checks fail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>revoke_route</b></description></item>
        /// <item><description><b>reserve_route</b></description></item>
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
        /// <para>The configuration of Phase 1 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: The pre-shared key that is used for authentication between the VPN gateway and the data center.</para>
        /// <list type="bullet">
        /// <item><description>The pre-shared key must be 1 to 100 characters in length and can contain letters, digits, and the following characters: <c>~ ! ` @ # $ % ^ &amp; * () _ - + = {} [] | ; : \\&quot; , . &lt; &gt; / ?</c></description></item>
        /// <item><description>If you do not specify a pre-shared key, the system generates a random 16-character string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/120374.html">DescribeVpnConnection</a> operation to query the pre-shared key that is generated by the system.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the data center. Otherwise, you cannot establish a connection between the data center and the VPN gateway.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: the Internet Key Exchange (IKE) version. Valid values: <b>ikev1</b> and <b>ikev2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: the negotiation mode. Valid values: <b>main</b> and <b>aggressive</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg</b>: the encryption algorithm that is used in Phase 1 negotiations. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: the authentication algorithm that is used in Phase 1 negotiations. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: the Diffie-Hellman (DH) key exchange algorithm that is used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: the security association (SA) lifetime determined by Phase 1 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalIdIPsec</b>: the identifier of the IPsec-VPN connection on the Alibaba Cloud side. The identifier can be up to 100 characters in length.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: the identifier of the IPsec-VPN connection on the data center side. The identifier can be up to 100 characters in length.</para>
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
        /// <para>The configuration of Phase 2 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><b>IpsecConfig.IpsecEncAlg:</b> the encryption algorithm that is used in Phase 2 negotiations. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecAuthAlg:</b> the authentication algorithm that is used in Phase 2 negotiations. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecPfs:</b> the DH key exchange algorithm that is used in Phase 2 negotiations. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecLifetime</b>: the SA lifetime determined by Phase 2 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IpsecEncAlg&quot;:&quot;aes&quot;,&quot;IpsecAuthAlg&quot;:&quot;sha1&quot;,&quot;IpsecPfs&quot;:&quot;group2&quot;,&quot;IpsecLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// <para>The CIDR block of the virtual private cloud (VPC) that communicates with the data center. The CIDR block is used in Phase 2 negotiations.</para>
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

        /// <summary>
        /// <para>The network type of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: an encrypted connection over the Internet</description></item>
        /// <item><description><b>private</b>: an encrypted connection over private networks</description></item>
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
        /// <para>The ID of the region in which the IPsec-VPN connection is established.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The peer CA certificate when a ShangMi (SM) VPN gateway is used to create the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c20ycDI1NnYxIENBIChURVNUIFN****</para>
        /// </summary>
        [NameInMap("RemoteCaCert")]
        [Validation(Required=false)]
        public string RemoteCaCert { get; set; }

        /// <summary>
        /// <para>The CIDR block of the data center that communicates with the VPC. This CIDR block is used in Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>The following routing modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.</description></item>
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.3.0/24,10.1.4.0/24</para>
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
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecification : TeaModel {
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                [NameInMap("TunnelCidr")]
                [Validation(Required=false)]
                public string TunnelCidr { get; set; }

            }

            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
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

            [NameInMap("TunnelIndex")]
            [Validation(Required=false)]
            public int? TunnelIndex { get; set; }

            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnAttachmentAttributeRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public int? IpsecLifetime { get; set; }

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
        /// <para>vco-p0w5112fgnl2ihlmf****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
