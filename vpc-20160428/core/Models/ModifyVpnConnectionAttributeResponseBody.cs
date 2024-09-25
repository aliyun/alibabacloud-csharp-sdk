// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeResponseBody : TeaModel {
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
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether IPsec negotiations immediately start after the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: IPsec negotiations immediately start after the configuration takes effect.</description></item>
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
        /// <para>Indicates whether the DPD feature is enabled for the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <para>Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <para>Indicates whether BGP is enabled for the tunnel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>This parameter is returned only by dual-tunnel IPsec-VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTunnelsBgp")]
        [Validation(Required=false)]
        public bool? EnableTunnelsBgp { get; set; }

        /// <summary>
        /// <para>The configuration of Phase 1 negotiations.</para>
        /// <para><b>IkeConfig</b> parameters are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIkeConfig : TeaModel {
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
            /// <para>The DH group in the IKE phase.</para>
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
            /// <para>The identifier on the VPC side. The default value is the IP address of the VPN gateway. The value can be an FQDN or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.64.XX.XX</para>
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// <para>The pre-shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgw6dy7d1i8i****</para>
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// <para>The identifier on the data center side. The default value is the IP address of the customer gateway. The value can be a FQDN or an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139.18.XX.XX</para>
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// <para>The configuration of Phase 2 negotiations.</para>
        /// <para><b>IpsecConfig</b> parameters are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIpsecConfig : TeaModel {
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
        /// <para>The CIDR block on the VPC side.</para>
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
        /// <para>The CIDR block on the data center side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.1.0/24,10.2.2.0/24</para>
        /// </summary>
        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DB79D0C-5F27-4AB5-995B-79BE55102F90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPsec-VPN connection belongs.</para>
        /// <para>The IPsec-VPN connection and the VPN gateway associated with the IPsec-VPN connection belong to the same resource group. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tunnel configuration of the IPsec-VPN connection.</para>
        /// <para><b>TunnelOptionsSpecification</b> parameters are returned only for dual-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecification : TeaModel {
            [NameInMap("TunnelOptions")]
            [Validation(Required=false)]
            public List<ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
            public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptions : TeaModel {
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
                public bool? EnableDpd { get; set; }

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
                public bool? EnableNatTraversal { get; set; }

                /// <summary>
                /// <para>The IP address on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.21.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The CA certificate of the tunnel peer.</para>
                /// <para>This parameter is returned only if the VPN gateway is of the SM type.</para>
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
                /// <para>The BGP configuration.</para>
                /// </summary>
                [NameInMap("TunnelBgpConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                    /// <summary>
                    /// <para>The ASN of the tunnel on the Alibaba Cloud side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65530</para>
                    /// </summary>
                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public long? LocalAsn { get; set; }

                    /// <summary>
                    /// <para>The BGP IP address of the tunnel on the Alibaba Cloud side.</para>
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
                    public long? PeerAsn { get; set; }

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
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
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
                    /// <item><description><b>main:</b> This mode offers higher security during negotiations.</description></item>
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
                    /// <para>The DH group in the IKE phase.</para>
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
                /// <para>The configuration of Phase 2 negotiations.</para>
                /// </summary>
                [NameInMap("TunnelIpsecConfig")]
                [Validation(Required=false)]
                public ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                public class ModifyVpnConnectionAttributeResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
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
                /// <para>The zone of the tunnel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-5a</para>
                /// </summary>
                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The health check configuration.</para>
        /// <para><b>VcoHealthCheck</b> parameters are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// <para>Indicates whether the health check feature is enabled for the IPsec-VPN connection.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The maximum number of health check retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retry")]
            [Validation(Required=false)]
            public int? Retry { get; set; }

            /// <summary>
            /// <para>The source IP address that is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.1.1</para>
            /// </summary>
            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        /// <summary>
        /// <para>The BGP configuration.</para>
        /// <para><b>VpnBgpConfig</b> parameters are returned only for single-tunnel IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig : TeaModel {
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
            /// <para>65530</para>
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public int? LocalAsn { get; set; }

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
            /// <para>The ASN on the data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65531</para>
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public int? PeerAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address of the data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.2</para>
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// <para>The negotiation state of BGP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: normal</description></item>
            /// <item><description><b>false</b>: abnormal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The BGP CIDR block of the IPsec-VPN connection.</para>
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

    }

}
