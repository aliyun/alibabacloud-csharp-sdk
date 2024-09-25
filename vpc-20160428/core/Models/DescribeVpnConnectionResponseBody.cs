// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance to which the transit router belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-lxxpbpalc776qz****</para>
        /// </summary>
        [NameInMap("AttachInstanceId")]
        [Validation(Required=false)]
        public string AttachInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the resource that is associated with the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CEN</b>: indicates that the IPsec-VPN connection is associated with a transit router of a Cloud Enterprise Network (CEN) instance.</description></item>
        /// <item><description><b>NO_ASSOCIATED</b>: indicates that the IPsec-VPN connection is not associated with any resource.</description></item>
        /// <item><description><b>VPNGW</b>: indicates that the IPsec-VPN connection is associated with a VPN gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CEN</para>
        /// </summary>
        [NameInMap("AttachType")]
        [Validation(Required=false)]
        public string AttachType { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the IPsec-VPN connection was established. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753817000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPsec-VPN connection is associated with a transit router that belongs to another Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccountAuthorized")]
        [Validation(Required=false)]
        public bool? CrossAccountAuthorized { get; set; }

        /// <summary>
        /// <para>The ID of the customer gateway associated with the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-bp1mvj4g9kogwwcxk****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>Indicates whether IPsec negotiations immediately start after the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Negotiations are reinitiated after the configuration is changed.</description></item>
        /// <item><description><b>false</b>: Negotiations are reinitiated after traffic is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>Indicates whether the dead peer detection (DPD) feature is enabled for the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <para>After you enable the DPD feature, the initiator of the IPsec-VPN connection sends DPD packets to check the existence and availability of the peer. If no response is received from the peer within a specified period of time, the connection fails. Then, the ISAKMP security association (SA), IPsec SA, and IPsec tunnel are deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// <para>Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>After NAT traversal is enabled, the initiator does not check the UDP ports during IKE negotiations and can automatically discover NAT gateway devices along the IPsec tunnel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// <para>Indicates whether BGP is enabled for the tunnel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 1 negotiations.</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyIkeConfig IkeConfig { get; set; }
        public class DescribeVpnConnectionResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// <para>The authentication algorithm in the IKE phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm in the IKE phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime in the IKE phase. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// <para>The IKE negotiation mode.</para>
            /// <list type="bullet">
            /// <item><description><b>main</b>: This mode offers higher security during negotiations.</description></item>
            /// <item><description><b>aggressive</b>: This mode is faster and has a higher success rate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// <para>The Diffie-Hellman (DH) group in the IKE phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// <para>The version of the IKE protocol.</para>
            /// <list type="bullet">
            /// <item><description><b>ikev1</b></description></item>
            /// <item><description><b>ikev2</b></description></item>
            /// </list>
            /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and is more suitable for scenarios in which multiple CIDR blocks are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ikev1</para>
            /// </summary>
            [NameInMap("IkeVersion")]
            [Validation(Required=false)]
            public string IkeVersion { get; set; }

            /// <summary>
            /// <para>The identifier of the IPsec-VPN connection on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.28.XX.XX</para>
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// <para>The pre-shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgw6dy****</para>
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// <para>The identifier of the IPsec-VPN connection on the data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139.34.XX.XX</para>
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// <para>The gateway IP address of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.XX.XX.162</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 2 negotiations.</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class DescribeVpnConnectionResponseBodyIpsecConfig : TeaModel {
            /// <summary>
            /// <para>The authentication algorithm in the IPsec phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm in the IPsec phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime in the IPsec phase. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// <para>The DH group in the IPsec phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// <para>The CIDR block on the Alibaba Cloud side.</para>
        /// <para>Multiple CIDR blocks are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipsec1</para>
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

        /// <summary>
        /// <para>The certificate authority (CA) certificate of the peer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW****</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block on the data center side.</para>
        /// <para>Multiple CIDR blocks are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2310D45-BCF6-4E2E-9082-B4503844BA4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPsec-VPN connection belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the IPsec-VPN connection. Unit: <b>Mbit/s</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The association state of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>active</b>: The IPsec-VPN connection is associated with a VPN gateway.</description></item>
        /// <item><description><b>init</b>: The IPsec-VPN connection is not associated with any resource and is being initialized.</description></item>
        /// <item><description><b>attaching</b>: The IPsec-VPN connection is being associated with a transit router.</description></item>
        /// <item><description><b>attached</b>: The IPsec-VPN connection is associated with a transit router.</description></item>
        /// <item><description><b>detaching</b>: The IPsec-VPN connection is being disassociated from a transit router.</description></item>
        /// <item><description><b>financialLocked</b>: The IPsec-VPN connection is locked due to overdue payments.</description></item>
        /// <item><description><b>provisioning</b>: The IPsec-VPN connection is being prepared.</description></item>
        /// <item><description><b>updating</b>: The IPsec-VPN connection is being updated.</description></item>
        /// <item><description><b>Upgrading</b>: The IPsec-VPN connection is being upgraded.</description></item>
        /// <item><description><b>deleted</b>: The IPsec-VPN connection is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>attached</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The state of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ike_sa_not_established</b>: Phase 1 negotiations failed.</description></item>
        /// <item><description><b>ike_sa_established</b>: Phase 1 negotiations succeeded.</description></item>
        /// <item><description><b>ipsec_sa_not_established</b>: Phase 2 negotiations failed.</description></item>
        /// <item><description><b>ipsec_sa_established</b>: Phase 2 negotiations succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ike_sa_not_established</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags added to the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyTags Tags { get; set; }
        public class DescribeVpnConnectionResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnConnectionResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
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

        }

        /// <summary>
        /// <para>The ID of the transit router with which the IPsec-VPN connection is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-p0we2edef9qr44a85****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The name of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouterName")]
        [Validation(Required=false)]
        public string TransitRouterName { get; set; }

        /// <summary>
        /// <para>The tunnel configuration of the IPsec-VPN connection.</para>
        /// <para>Parameters in <b>TunnelOptionsSpecification</b> are returned only if you query IPsec-VPN connections in dual-tunnel mode.</para>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecification : TeaModel {
            [NameInMap("TunnelOptions")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
            public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptions : TeaModel {
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
                /// <para>Indicates whether the DPD feature is enabled for the tunnel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public string EnableDpd { get; set; }

                /// <summary>
                /// <para>Indicates whether NAT traversal is enabled for the tunnel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public string EnableNatTraversal { get; set; }

                /// <summary>
                /// <para>The tunnel IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.21.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The CA certificate of the tunnel peer.</para>
                /// <para>This parameter is returned only if the VPN gateway is of the ShangMi (SM) type.</para>
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
                /// <para>The tunnel status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>active</b></description></item>
                /// <item><description><b>updating</b></description></item>
                /// <item><description><b>deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The state of the IPsec-VPN connection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ike_sa_not_established</b>: Phase 1 negotiations failed.</description></item>
                /// <item><description><b>ike_sa_established</b>: Phase 1 negotiations succeeded.</description></item>
                /// <item><description><b>ipsec_sa_not_established</b>: Phase 2 negotiations failed.</description></item>
                /// <item><description><b>ipsec_sa_established</b>: Phase 2 negotiations succeeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipsec_sa_established</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The BGP configurations.</para>
                /// </summary>
                [NameInMap("TunnelBgpConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                    /// <summary>
                    /// <para>The negotiation state of BGP. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>success</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("BgpStatus")]
                    [Validation(Required=false)]
                    public string BgpStatus { get; set; }

                    /// <summary>
                    /// <para>The ASN on the Alibaba Cloud side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65530</para>
                    /// </summary>
                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public string LocalAsn { get; set; }

                    /// <summary>
                    /// <para>The BGP address on the Alibaba Cloud side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.10.1</para>
                    /// </summary>
                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    /// <summary>
                    /// <para>The ASN of the tunnel peer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65531</para>
                    /// </summary>
                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public string PeerAsn { get; set; }

                    /// <summary>
                    /// <para>The BGP IP address of the tunnel peer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.10.2</para>
                    /// </summary>
                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    /// <summary>
                    /// <para>The BGP CIDR block of the tunnel.</para>
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
                /// <para>The configuration of Phase 1 negotiations.</para>
                /// </summary>
                [NameInMap("TunnelIkeConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
                    /// <summary>
                    /// <para>The authentication algorithm in the IKE phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha1</para>
                    /// </summary>
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    /// <summary>
                    /// <para>The encryption algorithm in the IKE phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aes</para>
                    /// </summary>
                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    /// <summary>
                    /// <para>The lifetime in the IKE phase. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public string IkeLifetime { get; set; }

                    /// <summary>
                    /// <para>The IKE negotiation mode.</para>
                    /// <list type="bullet">
                    /// <item><description><b>main</b>: This mode offers higher security during negotiations.</description></item>
                    /// <item><description><b>aggressive</b>: This mode is faster and has a higher success rate.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>main</para>
                    /// </summary>
                    [NameInMap("IkeMode")]
                    [Validation(Required=false)]
                    public string IkeMode { get; set; }

                    /// <summary>
                    /// <para>The Diffie-Hellman (DH) group in the IKE phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group2</para>
                    /// </summary>
                    [NameInMap("IkePfs")]
                    [Validation(Required=false)]
                    public string IkePfs { get; set; }

                    /// <summary>
                    /// <para>The version of the IKE protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ikev1</para>
                    /// </summary>
                    [NameInMap("IkeVersion")]
                    [Validation(Required=false)]
                    public string IkeVersion { get; set; }

                    /// <summary>
                    /// <para>The identifier of the tunnel on the Alibaba Cloud side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.21.XX.XX</para>
                    /// </summary>
                    [NameInMap("LocalId")]
                    [Validation(Required=false)]
                    public string LocalId { get; set; }

                    /// <summary>
                    /// <para>The pre-shared key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456****</para>
                    /// </summary>
                    [NameInMap("Psk")]
                    [Validation(Required=false)]
                    public string Psk { get; set; }

                    /// <summary>
                    /// <para>The identifier of the tunnel peer.</para>
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
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
                    /// <summary>
                    /// <para>The authentication algorithm in the IPsec phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha1</para>
                    /// </summary>
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    /// <summary>
                    /// <para>The encryption algorithm in the IPsec phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aes</para>
                    /// </summary>
                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    /// <summary>
                    /// <para>The lifetime in the IPsec phase. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public string IpsecLifetime { get; set; }

                    /// <summary>
                    /// <para>The DH group in the IPsec phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group2</para>
                    /// </summary>
                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }

                /// <summary>
                /// <para>The zone where the tunnel is deployed.</para>
                /// <para>You can call <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> to query zone IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The health check information about the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class DescribeVpnConnectionResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1</para>
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// <para>Indicates whether the health check feature is enabled for the IPsec-VPN connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Indicates whether advertised routes are withdrawn when the health check fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>revoke_route</b>: Advertised routes are withdrawn.</description></item>
            /// <item><description><b>reserve_route</b>: Advertised routes are not withdrawn.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>revoke_route</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The maximum number of health check retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public int? Retry { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

            /// <summary>
            /// <para>The state of the health check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>success</b>: normal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The Border Gateway Protocol (BGP) configuration of the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class DescribeVpnConnectionResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// <para>The authentication key of the BGP routing protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AuthKey****</para>
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>Indicates whether BGP is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public string EnableBgp { get; set; }

            /// <summary>
            /// <para>The ASN on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65531</para>
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public long? LocalAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.2</para>
            /// </summary>
            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            /// <summary>
            /// <para>The autonomous system number (ASN) of the peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65530</para>
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public long? PeerAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address of the peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.1</para>
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// <para>The negotiation state of the BGP routing protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: normal</description></item>
            /// <item><description><b>failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The BGP CIDR block of the IPsec-VPN connection. The CIDR block falls within 169.254.0.0/16. The subnet mask of the CIDR block must be 30 bits in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.0/30</para>
            /// </summary>
            [NameInMap("TunnelCidr")]
            [Validation(Required=false)]
            public string TunnelCidr { get; set; }

        }

        /// <summary>
        /// <para>The ID of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-bp1bbi27hojx80nck****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the IPsec-VPN connection is deployed.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> to query zone IDs and mapping between zone IDs and zone names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneNo")]
        [Validation(Required=false)]
        public string ZoneNo { get; set; }

    }

}
