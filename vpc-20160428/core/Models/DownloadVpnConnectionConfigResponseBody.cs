// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DownloadVpnConnectionConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configuration of the IPsec-VPN connection.
        /// </summary>
        [NameInMap("VpnConnectionConfig")]
        [Validation(Required=false)]
        public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig VpnConnectionConfig { get; set; }
        public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig : TeaModel {
            /// <summary>
            /// The IKE configuration.
            /// </summary>
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig IkeConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig : TeaModel {
                /// <summary>
                /// The IKE authentication algorithm. Valid values: **sha1** and **MD5**.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The IKE encryption algorithm.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The IKE lifetime. Unit: seconds.
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// The IKE mode. Valid values: **main** and **aggressive**. The **main** mode offers higher security. If NAT traversal is enabled, we recommend that you use the **aggressive** mode.
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The DH group.
                /// </summary>
                [NameInMap("IkePfs")]
                [Validation(Required=false)]
                public string IkePfs { get; set; }

                /// <summary>
                /// The IKE version.
                /// </summary>
                [NameInMap("IkeVersion")]
                [Validation(Required=false)]
                public string IkeVersion { get; set; }

                /// <summary>
                /// The local ID. The default value is the IP address of the VPN gateway. You can specify the value as an IP address or in the FQDN format.
                /// </summary>
                [NameInMap("LocalId")]
                [Validation(Required=false)]
                public string LocalId { get; set; }

                /// <summary>
                /// The pre-shared key.
                /// </summary>
                [NameInMap("Psk")]
                [Validation(Required=false)]
                public string Psk { get; set; }

                /// <summary>
                /// The peer ID. The default value is the IP address of the customer gateway. You can specify the value as an IP address or in the fully qualified domain name (FQDN) format.
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// The configuration of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig IpsecConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig : TeaModel {
                /// <summary>
                /// The IPsec authentication algorithm. Valid values: **sha1** and **md5**.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The IPsec encryption algorithm.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The IPsec lifetime. Unit: seconds.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// The DH group.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

            /// <summary>
            /// The identifier of the VPN gateway.
            /// </summary>
            [NameInMap("Local")]
            [Validation(Required=false)]
            public string Local { get; set; }

            /// <summary>
            /// The CIDR block on the virtual private cloud (VPC) side.
            /// </summary>
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            /// <summary>
            /// The identifier of the customer gateway.
            /// </summary>
            [NameInMap("Remote")]
            [Validation(Required=false)]
            public string Remote { get; set; }

            /// <summary>
            /// The CIDR block on the data center side.
            /// </summary>
            [NameInMap("RemoteSubnet")]
            [Validation(Required=false)]
            public string RemoteSubnet { get; set; }

            [NameInMap("TunnelsConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfig TunnelsConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfig : TeaModel {
                [NameInMap("TunnelConfig")]
                [Validation(Required=false)]
                public List<DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfig> TunnelConfig { get; set; }
                public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfig : TeaModel {
                    [NameInMap("IkeConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig IkeConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig : TeaModel {
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

                    [NameInMap("IpsecConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig IpsecConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig : TeaModel {
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

                    [NameInMap("Local")]
                    [Validation(Required=false)]
                    public string Local { get; set; }

                    [NameInMap("Remote")]
                    [Validation(Required=false)]
                    public string Remote { get; set; }

                    [NameInMap("RightCaCert")]
                    [Validation(Required=false)]
                    public string RightCaCert { get; set; }

                    [NameInMap("TunnelId")]
                    [Validation(Required=false)]
                    public string TunnelId { get; set; }

                }

            }

        }

    }

}
