// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnAttachmentAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance to which the transit router associated with the IPsec-VPN connection belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-c2r3m3zxkumoqz****</para>
        /// </summary>
        [NameInMap("AttachInstanceId")]
        [Validation(Required=false)]
        public string AttachInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the resource that is associated with the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CEN</b>: The IPsec-VPN connection is associated with a transit router.</description></item>
        /// <item><description><b>VPNGW</b>: The IPsec-VPN connection is associated with a VPN gateway.</description></item>
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
        /// <para>The timestamp generated when the IPsec-VPN connection was established. Unit: milliseconds.</para>
        /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1658201810000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the customer gateway associated with the IPsec-VPN connection.</para>
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
        /// <para>Indicates whether IPsec negotiations immediately start after the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <item><description><b>true</b></description></item>
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
        /// <para>Indicates whether NAT traversal is enabled for the IPsec-VPN connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
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
        /// <para>The configuration of Phase 1 negotiations.</para>
        /// </summary>
        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIkeConfig : TeaModel {
            /// <summary>
            /// <para>The authentication algorithm that is used in Phase 1 negotiations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that is used in Phase 1 negotiations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// <para>The SA lifetime that is determined by Phase 1 negotiations. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IkeLifetime")]
            [Validation(Required=false)]
            public long? IkeLifetime { get; set; }

            /// <summary>
            /// <para>The negotiation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("IkeMode")]
            [Validation(Required=false)]
            public string IkeMode { get; set; }

            /// <summary>
            /// <para>The DH key exchange algorithm that is used in Phase 1 negotiations.</para>
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
            /// <para>The identifier of the IPsec-VPN connection on the Alibaba Cloud side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.1</para>
            /// </summary>
            [NameInMap("LocalId")]
            [Validation(Required=false)]
            public string LocalId { get; set; }

            /// <summary>
            /// <para>The pre-shared key that is used for identity authentication between the VPN gateway and the data center.</para>
            /// <remarks>
            /// <para> The pre-shared key of the IPsec-VPN connection must be the same as the authentication key of the data center. Otherwise, you cannot establish a connection between the data center and the VPN gateway.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234***</para>
            /// </summary>
            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            /// <summary>
            /// <para>The identifier of the IPsec-VPN connection on the data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.2</para>
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// <para>The configuration of Phase 2 negotiations.</para>
        /// </summary>
        [NameInMap("IpsecConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyIpsecConfig : TeaModel {
            /// <summary>
            /// <para>The authentication algorithm that is used in Phase 2 negotiations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>md5</para>
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that is used in Phase 2 negotiations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// <para>The SA lifetime that is determined by Phase 2 negotiations. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// <para>The DH key exchange algorithm that is used in Phase 2 negotiations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// <para>The CIDR block of the VPC with which the data center can communicate.</para>
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
        /// <para>The CIDR block of the data center with which the VPC can communicate.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth specification of the IPsec-VPN connection.</para>
        /// <para>A value of <b>M</b> in the response indicates <b>Mbit/s</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

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
        /// <para>The health check configuration of the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVcoHealthCheck : TeaModel {
            /// <summary>
            /// <para>The destination IP address that is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            /// <summary>
            /// <para>Indicates whether the health check feature is enabled for the IPsec-VPN connection. Valid values:</para>
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
            /// <para>The interval between two consecutive health check retries. Unit: seconds.</para>
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
        /// <para>The BGP configuration of the IPsec-VPN connection.</para>
        /// </summary>
        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnAttachmentAttributeResponseBodyVpnBgpConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether BGP is enabled for the IPsec-VPN connection. Valid values:</para>
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
            /// <para>The ASN on the data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65535</para>
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public long? PeerAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address on the data center side.</para>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The CIDR block of the IPsec tunnel.</para>
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
        /// <para>The ID of the VPN gateway associated with the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-p0wa1c1018pmeb6cu****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
