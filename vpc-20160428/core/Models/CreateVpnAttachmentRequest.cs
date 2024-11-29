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
        /// <item><description><b>true</b> (default)</description></item>
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
        /// <para>The Border Gateway Protocol (BGP) configurations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BgpConfig.EnableBgp</b>: specifies whether to enable BGP. Valid values: <b>true</b> and <b>false</b>. Default value: false.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.LocalAsn</b>: the ASN on the Alibaba Cloud side. Valid values: <b>1</b> to <b>4294967295</b>. Default value: <b>45104</b>.</para>
        /// <para>You can enter the ASN in two segments. Separate the first 16 bits of the ASN from the remaining 16 bits with a period (.). Enter the number in each segment in decimal format.</para>
        /// <para>For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.</para>
        /// </description></item>
        /// <item><description><para><b>BgpConfig.TunnelCidr</b>: the CIDR block of the IPsec tunnel. The CIDR block falls within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.</para>
        /// </description></item>
        /// <item><description><para><b>LocalBgpIp:</b> the BGP IP address on the Alibaba Cloud side. This IP address must fall within the CIDR block range of the IPsec tunnel.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before you configure BGP, we recommend that you learn about how BGP works and the limits. For more information, see <a href="https://help.aliyun.com/document_detail/170235.html">BGP dynamic routing </a>.</description></item>
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
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <item><description><b>false</b> (default): starts IPsec negotiations when inbound traffic is received.</description></item>
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
        /// <item><description><b>true</b> (default) The initiator of the IPsec-VPN connection sends DPD packets to verify the existence and availability of the peer. If no response is received from the peer within a specified period of time, the connection fails. ISAKMP SAs and IPsec SAs are deleted. The IPsec tunnel is also deleted.</description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>true</b> (default) After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the VPN tunnel.</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>The health check configuration:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HealthCheckConfig.enable</b>: specifies whether to enable health checks. Valid values: <b>true</b> and <b>false</b>. Default value: false.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.dip</b>: the destination IP address configured for health checks. Enter the IP address on the data center side that the VPC can communicate with through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.sip</b>: the source IP address configured for health checks. Enter the IP address on the VPC side that the data center can communicate with through the IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.interval</b>: the time interval of health check retries. Unit: seconds. Default value: <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.retry</b>: the maximum number of health check retries. Default value: <b>3</b>.</para>
        /// </description></item>
        /// <item><description><para><b>HealthCheckConfig.Policy</b>: specifies whether to withdraw published routes when health checks fail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>revoke_route</b> (default): withdraws published routes.</description></item>
        /// <item><description><b>reserve_route</b>: does not withdraw published routes.</description></item>
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
        /// <para>The configurations of Phase 1 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IkeConfig.Psk</b>: the pre-shared key that is used for identity authentication between the VPN gateway and the on-premises data center.</para>
        /// <list type="bullet">
        /// <item><description>The key must be 1 to 100 characters in length and can contain digits, letters, and the following special characters: <c>~!`@#$%^&amp;*()_-+={}[]|;:\\&quot;,.&lt;&gt;/?</c></description></item>
        /// <item><description>If you do not specify a pre-shared key, the system randomly generates a 16-bit string as the pre-shared key. You can call the <a href="https://help.aliyun.com/document_detail/2526951.html">DescribeVpnConnection</a> operation to query the pre-shared key that is automatically generated by the system.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the on-premises data center. Otherwise, connections between the on-premises data center and the VPN gateway cannot be established.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeVersion</b>: the version of the Internet Key Exchange (IKE) protocol. Valid values: <b>ikev1</b> and <b>ikev2</b>. Default value: <b>ikev1</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeMode</b>: the negotiation mode. Valid values: <b>main</b> and <b>aggressive</b>. Default value: <b>main</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeEncAlg:</b> the encryption algorithm that is used in Phase 1 negotiations. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>. Default value: <b>aes</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeAuthAlg</b>: the authentication algorithm that is used in Phase 1 negotiations. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkePfs</b>: the Diffie-Hellman key exchange algorithm that is used in Phase 1 negotiations. Valid values: <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>. Default value: <b>group2</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.IkeLifetime</b>: the SA lifetime as a result of Phase 1 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.LocalIdIPsec</b>: the identifier on the Alibaba Cloud side. The identifier cannot exceed 100 characters in length. This parameter is left empty by default.</para>
        /// </description></item>
        /// <item><description><para><b>IkeConfig.RemoteId</b>: the identifier on the data center side. The identifier cannot exceed 100 characters in length. The default value is the IP address of the customer gateway.</para>
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
        /// <para>The configurations of Phase 2 negotiations:</para>
        /// <list type="bullet">
        /// <item><description><b>IpsecConfig.IpsecEncAlg</b>: the encryption algorithm that is used in Phase 2 negotiations. Valid values: <b>aes</b>, <b>aes192</b>, <b>aes256</b>, <b>des</b>, and <b>3des</b>. Default value: <b>aes</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecAuthAlg</b>: the authentication algorithm that is used in Phase 2 negotiations. Valid values: <b>md5</b>, <b>sha1</b>, <b>sha256</b>, <b>sha384</b>, and <b>sha512</b>. Default value: <b>md5</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecPfs</b>: the Diffie-Hellman key exchange algorithm that is used in Phase 2 negotiations. Valid values: <b>disabled</b>, <b>group1</b>, <b>group2</b>, <b>group5</b>, and <b>group14</b>. Default value: <b>group2</b>.</description></item>
        /// <item><description><b>IpsecConfig. IpsecLifetime</b>: the SA lifetime that is determined by Phase 2 negotiations. Unit: seconds. Valid values: <b>0</b> to <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IpsecEncAlg&quot;:&quot;aes&quot;,&quot;IpsecAuthAlg&quot;:&quot;sha1&quot;,&quot;IpsecPfs&quot;:&quot;group2&quot;,&quot;IpsecLifetime&quot;:86400}</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public string IpsecConfig { get; set; }

        /// <summary>
        /// <para>The CIDR block on the VPC side. The CIDR block is used in Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.1.0/24,192.168.2.0/24.</para>
        /// <para>The following routing modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.</description></item>
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.</description></item>
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
        /// <item><description><b>public</b> (default)</description></item>
        /// <item><description><b>private</b></description></item>
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
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCert")]
        [Validation(Required=false)]
        public string RemoteCaCert { get; set; }

        /// <summary>
        /// <para>The CIDR block on the data center side. This CIDR block is used in Phase 2 negotiations.</para>
        /// <para>Separate multiple CIDR blocks with commas (,). Example: 192.168.3.0/24,192.168.4.0/24.</para>
        /// <para>The following routing modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to 0.0.0.0/0, the routing mode of the IPsec-VPN connection is set to Destination Routing Mode.</description></item>
        /// <item><description>If you set <b>LocalSubnet</b> and <b>RemoteSubnet</b> to specific CIDR blocks, the routing mode of the IPsec-VPN connection is set to Protected Data Flows.</description></item>
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
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group IDs.</description></item>
        /// <item><description>If you do not specify a resource group ID, the IPsec-VPN connection belongs to the default resource group.</description></item>
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
        /// <para>The tag value.</para>
        /// <para>The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values in each call.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVpnAttachmentRequestTags> Tags { get; set; }
        public class CreateVpnAttachmentRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string.</para>
            /// <para>It can be at most 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<CreateVpnAttachmentRequestTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class CreateVpnAttachmentRequestTunnelOptionsSpecification : TeaModel {
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
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
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

            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
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
            public CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class CreateVpnAttachmentRequestTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

        }

    }

}
