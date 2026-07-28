// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnAttachmentAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance to which the transit router (vRouter) associated with the IPsec-VPN connection belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-c2r3m3zxkumoqz****</para>
        /// </summary>
        [NameInMap("AttachInstanceId")]
        [Validation(Required=false)]
        public string AttachInstanceId { get; set; }

        /// <summary>
        /// <para>The type of resource that the IPsec-VPN connection is associated with.</para>
        /// <list type="bullet">
        /// <item><description><b>CEN</b>: The IPsec-VPN connection is associated with a transit router instance.</description></item>
        /// <item><description><b>VPNGW</b>: The IPsec-VPN connection is associated with a VPN gateway instance.</description></item>
        /// <item><description><b>NO_ASSOCIATED</b>: The IPsec-VPN connection is not associated with any resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CEN</para>
        /// </summary>
        [NameInMap("AttachType")]
        [Validation(Required=false)]
        public string AttachType { get; set; }

        /// <summary>
        /// <para>The timestamp when the IPsec-VPN connection was created. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX time format, which represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1658201810000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the customer gateway associated with the IPsec-VPN connection.</para>
        /// <para>This parameter is returned only for single-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-p0w2jemrcj5u61un8****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>The description of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPsec-VPN connection configuration takes effect immediately. </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The configuration takes effect immediately.</description></item>
        /// <item><description><b>false</b>: The configuration does not take effect immediately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>Indicates whether DPD is enabled for the IPsec-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// <para>This parameter is returned only for single-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        /// <summary>
        /// <para>Indicates whether NAT traversal is enabled for the IPsec-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// <para>This parameter is returned only for single-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// <para>The enabling status of tunnel BGP.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// <para>This parameter is returned only for IPsec-VPN connections in dual-tunnel pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>The Phase 1 negotiation configuration.</para>
        /// <para>The parameters in the <b>IkeConfig</b> array are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// <para>The authentication algorithm for Phase 1 negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm for Phase 1 negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime of the SA negotiated in Phase 1. Unit: seconds.</para>
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
            /// <item><description><b>main</b>: main mode. The negotiation process is highly secure.</description></item>
            /// <item><description><b>aggressive</b>: aggressive mode. The negotiation is fast and has a high success rate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// <para>The Diffie-Hellman key exchange algorithm used in Phase 1 negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// <para>The IKE protocol version.</para>
            /// <list type="bullet">
            /// <item><description><b>ikev1</b></description></item>
            /// <item><description><b>ikev2</b></description></item>
            /// </list>
            /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for multi-CIDR-block scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ikev1</para>
            /// </summary>
            [NameInMap("IkeVersion")]
            [Validation(Required=false)]
            public string IkeVersion { get; set; }

            /// <summary>
            /// <para>The identifier on the Alibaba Cloud side of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.1</para>
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// <para>The pre-shared key used for identity authentication between the Alibaba Cloud IPsec-VPN connection and the on-premises data center.</para>
            /// <remarks>
            /// <para>The pre-shared key on the IPsec-VPN connection side must be the same as the authentication key on the on-premises data center side. Otherwise, a connection cannot be established between the on-premises data center and the VPN gateway.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234***</para>
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// <para>The identifier on the on-premises data center side of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.2</para>
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// <para>The Phase 2 negotiation configuration.</para>
        /// <para>The parameters in the <b>IpsecConfig</b> array are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIpsecConfig : TeaModel {
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
            /// <para>The encryption algorithm for Phase 2 negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime of the SA negotiated in Phase 2. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// <para>The Diffie-Hellman key exchange algorithm used in Phase 2 negotiation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// <para>The CIDR block on the Alibaba Cloud side that communicates with the on-premises data center, such as the VPC CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.0/24,10.1.2.0/24</para>
        /// </summary>
        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the IPsec-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: public network.</description></item>
        /// <item><description><b>private</b>: private network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The CIDR block on the on-premises data center side that communicates with Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.3.0/24,10.1.4.0/24</para>
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35822A84-867F-3936-A2E6-A4C4E3ED11C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPsec-VPN connection belongs.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the IPsec-VPN connection.</para>
        /// <para><b>M</b> in the return value indicates the unit <b>Mbps</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The status of the IPsec-VPN connection.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ike_sa_not_established</b>: Phase 1 negotiation failed.</para>
        /// </description></item>
        /// <item><description><para><b>ike_sa_established</b>: Phase 1 negotiation succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>ipsec_sa_not_established</b>: Phase 2 negotiation failed.</para>
        /// </description></item>
        /// <item><description><para><b>ipsec_sa_established</b>: Phase 2 negotiation succeeded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ike_sa_not_established</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tunnel configuration of the IPsec-VPN connection.</para>
        /// <para>The parameters in the <b>TunnelOptionsSpecification</b> array are returned only for dual-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public List<ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecification> TunnelOptionsSpecification { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecification : TeaModel {
            /// <summary>
            /// <para>The customer gateway ID associated with the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cgw-p0w2jemrcj5u61un8****</para>
            /// </summary>
            [NameInMap("CustomerGatewayId")]
            [Validation(Required=false)]
            public string CustomerGatewayId { get; set; }

            /// <summary>
            /// <para>Indicates whether DPD is enabled for the tunnel.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDpd")]
            [Validation(Required=false)]
            public bool? EnableDpd { get; set; }

            /// <summary>
            /// <para>Indicates whether NAT traversal is enabled for the tunnel.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableNatTraversal")]
            [Validation(Required=false)]
            public bool? EnableNatTraversal { get; set; }

            /// <summary>
            /// <para>The gateway IP address on the Alibaba Cloud side of the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.66</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The role of the tunnel.</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: The tunnel is the active tunnel.</description></item>
            /// <item><description><b>slave</b>: The tunnel is the standby tunnel.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The status of the tunnel.</para>
            /// <list type="bullet">
            /// <item><description><b>active</b>: normal.</description></item>
            /// <item><description><b>updating</b>: being updated.</description></item>
            /// <item><description><b>deleting</b>: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The BGP configuration of the tunnel.</para>
            /// </summary>
            [NameInMap("TunnelBgpConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelBgpConfig TunnelBgpConfig { get; set; }
            public class ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelBgpConfig : TeaModel {
                /// <summary>
                /// <para>The autonomous system number on the local end (Alibaba Cloud side) of the tunnel.
                /// [_single.resp.200.props.TunnelOptionsSpecification.items.TunnelBgpConfig.LocalBgpI</para>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public long? LocalAsn { get; set; }

                /// <summary>
                /// <para>The BGP address on the Alibaba Cloud side of the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.10.1</para>
                /// </summary>
                [NameInMap("LocalBgpIp")]
                [Validation(Required=false)]
                public string LocalBgpIp { get; set; }

                /// <summary>
                /// <para>The autonomous system number of the tunnel peer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65531</para>
                /// </summary>
                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public long? PeerAsn { get; set; }

                /// <summary>
                /// <para>The BGP address of the tunnel peer.</para>
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
            /// <para>tun-0jod7plwf2a0o9lvu****</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <para>The configuration of Phase 1 negotiation.</para>
            /// </summary>
            [NameInMap("TunnelIkeConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelIkeConfig TunnelIkeConfig { get; set; }
            public class ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelIkeConfig : TeaModel {
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
                /// <para>The negotiation mode of the IKE version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>main</b>: Main mode. This mode offers high negotiation security.</description></item>
                /// <item><description><b>aggressive</b>: Aggressive mode. This mode supports fast negotiation and a higher success rate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// <para>The DH group in the IKE phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group2</para>
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// <para>The IKE protocol version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev2</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier on the Alibaba Cloud side of the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.1</para>
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
                /// <para>47.XX.XX.2</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The creation order of the tunnel.</para>
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
            /// <para>The configuration of Phase 2 negotiation.</para>
            /// </summary>
            [NameInMap("TunnelIpsecConfig")]
            [Validation(Required=false)]
            public ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelIpsecConfig TunnelIpsecConfig { get; set; }
            public class ModifyVpnAttachmentAttributeResponseBodyTunnelOptionsSpecificationTunnelIpsecConfig : TeaModel {
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

        }

        /// <summary>
        /// <para>The health check configuration of the IPsec-VPN connection.</para>
        /// <para>The parameters in the <b>VcoHealthCheck</b> array are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// <para>The destination IP address of the health check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// <para>Indicates whether health checks are enabled for the IPsec-VPN connection.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The retry interval of the health check. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Indicates whether published routes are withdrawn when the health check fails.</para>
            /// <list type="bullet">
            /// <item><description><b>revoke_route</b>: Published routes are withdrawn.</description></item>
            /// <item><description><b>reserve_route</b>: Published routes are not withdrawn.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>revoke_route</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The number of health check retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public int? Retry { get; set; }

            /// <summary>
            /// <para>The source IP address of the health check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        /// <summary>
        /// <para>The BGP configuration of the IPsec-VPN connection.</para>
        /// <para>The parameters in the <b>VpnBgpConfig</b> array are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether BGP is enabled for the IPsec-VPN connection.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public string EnableBgp { get; set; }

            /// <summary>
            /// <para>The autonomous system number on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45104</para>
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public long? LocalAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.1</para>
            /// </summary>
            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            /// <summary>
            /// <para>The autonomous system number on the on-premises data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65535</para>
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public long? PeerAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address on the on-premises data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.2</para>
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// <para>The BGP negotiation status.</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: normal.</description></item>
            /// <item><description><b>false</b>: abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The IPsec tunnel CIDR block.</para>
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
        /// <para>vco-p0w5112fgnl2ihlmf****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway instance associated with the IPsec-VPN connection.</para>
        /// <para><b>vpn-not-exist</b>: The IPsec-VPN connection is not associated with a VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-not-exist</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
