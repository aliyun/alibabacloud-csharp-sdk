// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DownloadVpnConnectionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C68048B-0F70-40DA-B8AE-1B79B5CF62E3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the peer gateway device.</para>
        /// </summary>
        [NameInMap("VpnConnectionConfig")]
        [Validation(Required=false)]
        public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig VpnConnectionConfig { get; set; }
        public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig : TeaModel {
            /// <summary>
            /// <para>The configurations of Phase 1 negotiations.</para>
            /// </summary>
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig IkeConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig : TeaModel {
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
                /// <para>The IKE negotiation mode. Valid values:</para>
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
                /// <para>The IKE version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ikev1</para>
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// <para>The identifier of the customer gateway. FQDN and IP formats are supported. The default value is the IP address of the customer gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.62.XX.XX</para>
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
                /// <para>The identifier of the VPN gateway. FQDN and IP formats are supported. The default value is the IP address of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.196.XX.XX</para>
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// <para>The configurations of Phase 2 negotiations.</para>
            /// </summary>
            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig IpsecConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig : TeaModel {
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
            /// <para>The identifier of the customer gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139.196.XX.XX</para>
            /// </summary>
            [NameInMap("Local")]
            [Validation(Required=false)]
            public string Local { get; set; }

            /// <summary>
            /// <para>The CIDR block on the data center side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            /// <summary>
            /// <para>The identifier of the VPN gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.62.XX.XX</para>
            /// </summary>
            [NameInMap("Remote")]
            [Validation(Required=false)]
            public string Remote { get; set; }

            /// <summary>
            /// <para>The CIDR block on the virtual private cloud (VPC) side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("RemoteSubnet")]
            [Validation(Required=false)]
            public string RemoteSubnet { get; set; }

            /// <summary>
            /// <para>The tunnel configurations of the peer gateway device.</para>
            /// <para>The parameters in <b>TunnelsConfig</b> are returned only when the IPsec-VPN connection supports the dual-tunnel mode.</para>
            /// </summary>
            [NameInMap("TunnelsConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfig TunnelsConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfig : TeaModel {
                [NameInMap("TunnelConfig")]
                [Validation(Required=false)]
                public List<DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfig> TunnelConfig { get; set; }
                public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfig : TeaModel {
                    /// <summary>
                    /// <para>The configurations of Phase 1 negotiations.</para>
                    /// </summary>
                    [NameInMap("IkeConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig IkeConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig : TeaModel {
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
                        /// <para>The IKE negotiation mode. Valid values:</para>
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
                        /// <para>The IKE version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ikev1</para>
                        /// </summary>
                        [NameInMap("IkeVersion")]
                        [Validation(Required=false)]
                        public string IkeVersion { get; set; }

                        /// <summary>
                        /// <para>The identifier of the tunnel on the data center side.</para>
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
                        /// <para>pgw6dy7d1i8i****</para>
                        /// </summary>
                        [NameInMap("Psk")]
                        [Validation(Required=false)]
                        public string Psk { get; set; }

                        /// <summary>
                        /// <para>The identifier of the tunnel on the Alibaba Cloud side.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47.24.XX.XX</para>
                        /// </summary>
                        [NameInMap("RemoteId")]
                        [Validation(Required=false)]
                        public string RemoteId { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of Phase 2 negotiations.</para>
                    /// </summary>
                    [NameInMap("IpsecConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig IpsecConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig : TeaModel {
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
                    /// <para>The identifier of the tunnel on the data center side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.21.XX.XX</para>
                    /// </summary>
                    [NameInMap("Local")]
                    [Validation(Required=false)]
                    public string Local { get; set; }

                    /// <summary>
                    /// <para>The identifier of the tunnel on the Alibaba Cloud side.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.24.XX.XX</para>
                    /// </summary>
                    [NameInMap("Remote")]
                    [Validation(Required=false)]
                    public string Remote { get; set; }

                    /// <summary>
                    /// <para>The tunnel ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tun-opsqc4d97wni27****</para>
                    /// </summary>
                    [NameInMap("TunnelId")]
                    [Validation(Required=false)]
                    public string TunnelId { get; set; }

                }

            }

        }

    }

}
