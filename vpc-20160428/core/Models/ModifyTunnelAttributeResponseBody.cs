// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyTunnelAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the customer gateway associated with the customer gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cgw-p0wx48ayhrygitm80****</para>
        /// </summary>
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// <para>Indicates whether DPD is enabled. Valid values:</para>
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
        /// <para>Indicates whether NAT traversal is enabled. Valid values:</para>
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
        /// <para>The tunnel IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.XX.XX.87</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The peer CA certificate when a VPN gateway that uses an SM certificate is used to create the IPsec connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- MIIB7zCCAZW**** -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F36FF0-9544-3AEE-8673-A4647D50064C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tunnel role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>master</b></description></item>
        /// <item><description><b>slave</b></description></item>
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
        public ModifyTunnelAttributeResponseBodyTunnelBgpConfig TunnelBgpConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelBgpConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether the BGP feature is enabled. Valid values:</para>
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
            public bool? EnableBgp { get; set; }

            /// <summary>
            /// <para>The local ASN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65530</para>
            /// </summary>
            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public long? LocalAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address of the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.1</para>
            /// </summary>
            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            /// <summary>
            /// <para>The peer ASN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65531</para>
            /// </summary>
            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public long? PeerAsn { get; set; }

            /// <summary>
            /// <para>The BGP IP address of the peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.2</para>
            /// </summary>
            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            /// <summary>
            /// <para>The CIDR block to which the tunnel BGP IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169.254.11.0/30</para>
            /// </summary>
            [NameInMap("TunnelCidr")]
            [Validation(Required=false)]
            public string TunnelCidr { get; set; }

        }

        /// <summary>
        /// <para>The tunnel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tun-gbyz2e070xzo93****</para>
        /// </summary>
        [NameInMap("TunnelId")]
        [Validation(Required=false)]
        public string TunnelId { get; set; }

        /// <summary>
        /// <para>The Phase 1 configuration.</para>
        /// </summary>
        [NameInMap("TunnelIkeConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelIkeConfig TunnelIkeConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIkeConfig : TeaModel {
            /// <summary>
            /// <para>The IKE authentication algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IkeAuthAlg")]
            [Validation(Required=false)]
            public string IkeAuthAlg { get; set; }

            /// <summary>
            /// <para>The IKE encryption algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IkeEncAlg")]
            [Validation(Required=false)]
            public string IkeEncAlg { get; set; }

            /// <summary>
            /// <para>The IKE lifetime. Unit: seconds.</para>
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
            /// <para>The DH group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IkePfs")]
            [Validation(Required=false)]
            public string IkePfs { get; set; }

            /// <summary>
            /// <para>The IKE version.</para>
            /// <list type="bullet">
            /// <item><description><b>ikev1</b></description></item>
            /// <item><description><b>ikev2</b></description></item>
            /// </list>
            /// <para>Compared with IKEv1, IKEv2 simplifies the SA negotiation process and provides better support for scenarios with multiple CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ikev2</para>
            /// </summary>
            [NameInMap("IkeVersion")]
            [Validation(Required=false)]
            public string IkeVersion { get; set; }

            /// <summary>
            /// <para>The tunnel identifier. The identifier supports FQDNs and IP addresses. The default value is the tunnel IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.87</para>
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
            /// <para>The peer identifier. The identifier supports FQDNs and IP addresses. The default identifier is the IP address of the customer gateway associated with the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.207</para>
            /// </summary>
            [NameInMap("RemoteId")]
            [Validation(Required=false)]
            public string RemoteId { get; set; }

        }

        /// <summary>
        /// <para>The configurations of IPsec Phase 2.</para>
        /// </summary>
        [NameInMap("TunnelIpsecConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelIpsecConfig TunnelIpsecConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIpsecConfig : TeaModel {
            /// <summary>
            /// <para>The IPsec authentication algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha1</para>
            /// </summary>
            [NameInMap("IpsecAuthAlg")]
            [Validation(Required=false)]
            public string IpsecAuthAlg { get; set; }

            /// <summary>
            /// <para>The IPsec encryption algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes</para>
            /// </summary>
            [NameInMap("IpsecEncAlg")]
            [Validation(Required=false)]
            public string IpsecEncAlg { get; set; }

            /// <summary>
            /// <para>The IPsec lifetime. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("IpsecLifetime")]
            [Validation(Required=false)]
            public long? IpsecLifetime { get; set; }

            /// <summary>
            /// <para>The DH group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group2</para>
            /// </summary>
            [NameInMap("IpsecPfs")]
            [Validation(Required=false)]
            public string IpsecPfs { get; set; }

        }

        /// <summary>
        /// <para>The tunnel zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneNo")]
        [Validation(Required=false)]
        public string ZoneNo { get; set; }

    }

}
