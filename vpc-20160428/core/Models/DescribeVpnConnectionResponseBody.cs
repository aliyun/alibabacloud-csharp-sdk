// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance to which the transit router instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-lxxpbpalc776qz****</para>
        /// </summary>
        [NameInMap("AttachInstanceId")]
        [Validation(Required=false)]
        public string AttachInstanceId { get; set; }

        /// <summary>
        /// <para>The type of resource associated with the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CEN</b>: The IPsec-VPN connection is associated with a transit router of a Cloud Enterprise Network (CEN) instance.</description></item>
        /// <item><description><b>NO_ASSOCIATED</b>: The IPsec-VPN connection is not associated with any resource.</description></item>
        /// <item><description><b>VPNGW</b>: The IPsec-VPN connection is associated with a VPN gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CEN</para>
        /// </summary>
        [NameInMap("AttachType")]
        [Validation(Required=false)]
        public string AttachType { get; set; }

        /// <summary>
        /// <para>The timestamp when the IPsec-VPN connection was created. Unit: milliseconds.
        /// The timestamp is in UNIX timestamp format, which indicates the total number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492753817000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the IPsec-VPN connection is associated with a cross-account transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <para>Indicates whether the configuration of the IPsec-VPN connection takes effect immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes. A reconnection is triggered after the configuration is changed.</description></item>
        /// <item><description><b>false</b>: No. A reconnection is triggered when traffic is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        /// <summary>
        /// <para>Indicates whether dead peer detection (DPD) is enabled for the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: DPD is disabled.</description></item>
        /// <item><description><b>true</b>: DPD is enabled.
        /// After DPD is enabled, the initiator of the IPsec-VPN connection sends DPD packets to check whether the peer device is alive. If no valid response is received within the specified time, the peer device is considered disconnected. The IPsec-VPN connection deletes the ISAKMP SA and the corresponding IPsec SA, and the secure tunnel is also deleted.</description></item>
        /// </list>
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
        /// <item><description><b>true</b>: NAT traversal is enabled.</description></item>
        /// <item><description><b>false</b>: NAT traversal is disabled.
        /// After NAT traversal is enabled, the verification of the UDP port number is skipped during the IKE negotiation process, and NAT gateway devices in the VPN tunnel can be discovered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        /// <summary>
        /// <para>The enabling status of BGP for the tunnel.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
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
            /// <para>The authentication algorithm at the IKE stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm at the IKE stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime of the IKE SA. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// <para>The IKE negotiation mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>main</b>: Main mode. The negotiation process is highly secure.</description></item>
            /// <item><description><b>aggressive</b>: Aggressive mode. The negotiation process is fast and has a high success rate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// <para>The Diffie-Hellman (DH) group at the IKE stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// <para>The IKE version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ikev1</b></description></item>
            /// <item><description><b>ikev2</b>
            /// Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for scenarios where multiple CIDR blocks are used.</description></item>
            /// </list>
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
            /// <para>The identifier of the peer on the data center side of the IPsec-VPN connection.</para>
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
            /// <para>The authentication algorithm at the IPsec stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm at the IPsec stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// <para>The lifetime of the IPsec SA. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// <para>The DH group at the IPsec stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// <para>The CIDR block on the Alibaba Cloud side of the IPsec-VPN connection.
        /// If multiple CIDR blocks are specified, they are separated by commas (,).</para>
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
        /// <item><description><b>public</b>: Internet. The IPsec-VPN connection establishes an encrypted communication channel over the Internet.</description></item>
        /// <item><description><b>private</b>: Private network. The IPsec-VPN connection establishes an encrypted communication channel over a private network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The CA certificate of the peer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW****</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The CIDR block on the data center side of the IPsec-VPN connection.
        /// If multiple CIDR blocks are specified, they are separated by commas (,).</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group information.</para>
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
        /// <para>The association status between the IPsec-VPN connection and the transit router instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>active</b>: The IPsec-VPN connection is associated with a VPN gateway instance and is in a normal state.</description></item>
        /// <item><description><b>init</b>: The IPsec-VPN connection is not associated with any resource, and the IPsec-VPN connection is being initialized.</description></item>
        /// <item><description><b>attaching</b>: The IPsec-VPN connection is being associated with the transit router instance.</description></item>
        /// <item><description><b>attached</b>: The IPsec-VPN connection is associated with the transit router instance.</description></item>
        /// <item><description><b>detaching</b>: The IPsec-VPN connection is being disassociated from the transit router instance.</description></item>
        /// <item><description><b>financialLocked</b>: The instance is locked due to overdue payments.</description></item>
        /// <item><description><b>provisioning</b>: The resource is being prepared.</description></item>
        /// <item><description><b>updating</b>: The IPsec-VPN connection is being updated.</description></item>
        /// <item><description><b>upgrading</b>: The IPsec-VPN connection is being upgraded.</description></item>
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
        /// <para>The status of the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ike_sa_not_established</b>: Phase 1 negotiation failed.</description></item>
        /// <item><description><b>ike_sa_established</b>: Phase 1 negotiation succeeded.</description></item>
        /// <item><description><b>ipsec_sa_not_established</b>: Phase 2 negotiation failed.</description></item>
        /// <item><description><b>ipsec_sa_established</b>: Phase 2 negotiation succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ike_sa_not_established</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyTags Tags { get; set; }
        public class DescribeVpnConnectionResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpnConnectionResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the transit router instance associated with the IPsec-VPN connection.</para>
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
        /// <para>The bandwidth specification of a single VPN tunnel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard (default): The standard type. The default bandwidth is 1 Gbps.</description></item>
        /// <item><description>Large: The large type. The default bandwidth is 3 Gbps.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("TunnelBandwidth")]
        [Validation(Required=false)]
        public string TunnelBandwidth { get; set; }

        [NameInMap("TunnelOptionsSpecification")]
        [Validation(Required=false)]
        public DescribeVpnConnectionResponseBodyTunnelOptionsSpecification TunnelOptionsSpecification { get; set; }
        public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecification : TeaModel {
            [NameInMap("TunnelOptions")]
            [Validation(Required=false)]
            public List<DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptions> TunnelOptions { get; set; }
            public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptions : TeaModel {
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                [NameInMap("EnableDpd")]
                [Validation(Required=false)]
                public string EnableDpd { get; set; }

                [NameInMap("EnableNatTraversal")]
                [Validation(Required=false)]
                public string EnableNatTraversal { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("RemoteCaCertificate")]
                [Validation(Required=false)]
                public string RemoteCaCertificate { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TunnelBgpConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig TunnelBgpConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelBgpConfig : TeaModel {
                    [NameInMap("BgpStatus")]
                    [Validation(Required=false)]
                    public string BgpStatus { get; set; }

                    [NameInMap("LocalAsn")]
                    [Validation(Required=false)]
                    public string LocalAsn { get; set; }

                    [NameInMap("LocalBgpIp")]
                    [Validation(Required=false)]
                    public string LocalBgpIp { get; set; }

                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public string PeerAsn { get; set; }

                    [NameInMap("PeerBgpIp")]
                    [Validation(Required=false)]
                    public string PeerBgpIp { get; set; }

                    [NameInMap("TunnelCidr")]
                    [Validation(Required=false)]
                    public string TunnelCidr { get; set; }

                }

                [NameInMap("TunnelId")]
                [Validation(Required=false)]
                public string TunnelId { get; set; }

                [NameInMap("TunnelIkeConfig")]
                [Validation(Required=false)]
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig TunnelIkeConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIkeConfig : TeaModel {
                    [NameInMap("IkeAuthAlg")]
                    [Validation(Required=false)]
                    public string IkeAuthAlg { get; set; }

                    [NameInMap("IkeEncAlg")]
                    [Validation(Required=false)]
                    public string IkeEncAlg { get; set; }

                    [NameInMap("IkeLifetime")]
                    [Validation(Required=false)]
                    public string IkeLifetime { get; set; }

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
                public DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig TunnelIpsecConfig { get; set; }
                public class DescribeVpnConnectionResponseBodyTunnelOptionsSpecificationTunnelOptionsTunnelIpsecConfig : TeaModel {
                    [NameInMap("IpsecAuthAlg")]
                    [Validation(Required=false)]
                    public string IpsecAuthAlg { get; set; }

                    [NameInMap("IpsecEncAlg")]
                    [Validation(Required=false)]
                    public string IpsecEncAlg { get; set; }

                    [NameInMap("IpsecLifetime")]
                    [Validation(Required=false)]
                    public string IpsecLifetime { get; set; }

                    [NameInMap("IpsecPfs")]
                    [Validation(Required=false)]
                    public string IpsecPfs { get; set; }

                }

                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The health check information of the IPsec-VPN connection.</para>
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
            /// <para>Indicates whether health checks are enabled for the IPsec-VPN connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Health checks are disabled.</description></item>
            /// <item><description><b>true</b>: Health checks are enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The retry interval for health checks. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Indicates whether to revoke published routes when a health check fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>revoke_route</b>: Revoke routes.</description></item>
            /// <item><description><b>reserve_route</b>: Do not revoke routes.</description></item>
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
            /// <para>The health check status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>failed</b>: Abnormal.</description></item>
            /// <item><description><b>success</b>: Normal.</description></item>
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
        /// <para>The BGP routing protocol configuration of the IPsec-VPN connection.</para>
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
            /// <para>The enabling status of the BGP routing protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
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
            /// <para>The negotiation status of the BGP routing protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: Normal.</description></item>
            /// <item><description><b>failed</b>: Abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The BGP CIDR block of the IPsec-VPN connection. The CIDR block must be a subnet of 169.254.0.0/16 with a subnet mask length of 30 bits.</para>
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
        /// <para>The ID of the VPN gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm2ogj****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the IPsec-VPN connection is deployed.
        /// You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query the mapping between zone IDs and zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneNo")]
        [Validation(Required=false)]
        public string ZoneNo { get; set; }

    }

}
