// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DownloadVpnConnectionConfigResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the peer gateway device.
        /// </summary>
        [NameInMap("VpnConnectionConfig")]
        [Validation(Required=false)]
        public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig VpnConnectionConfig { get; set; }
        public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig : TeaModel {
            /// <summary>
            /// The configurations of Phase 1 negotiations.
            /// </summary>
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig IkeConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm in the IKE phase.
                /// </summary>
                [NameInMap("IkeAuthAlg")]
                [Validation(Required=false)]
                public string IkeAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm in the IKE phase.
                /// </summary>
                [NameInMap("IkeEncAlg")]
                [Validation(Required=false)]
                public string IkeEncAlg { get; set; }

                /// <summary>
                /// The lifetime in the IKE phase. Unit: seconds.
                /// </summary>
                [NameInMap("IkeLifetime")]
                [Validation(Required=false)]
                public long? IkeLifetime { get; set; }

                /// <summary>
                /// The IKE negotiation mode. Valid values:
                /// 
                /// *   **main**: This mode offers higher security during negotiations.
                /// *   **aggressive**: This mode is faster and has a higher success rate.
                /// </summary>
                [NameInMap("IkeMode")]
                [Validation(Required=false)]
                public string IkeMode { get; set; }

                /// <summary>
                /// The DH group in the IKE phase.
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
                /// The identifier of the customer gateway. FQDN and IP formats are supported. The default value is the IP address of the customer gateway.
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
                /// The identifier of the VPN gateway. FQDN and IP formats are supported. The default value is the IP address of the VPN gateway.
                /// </summary>
                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            /// <summary>
            /// The configurations of Phase 2 negotiations.
            /// </summary>
            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig IpsecConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig : TeaModel {
                /// <summary>
                /// The authentication algorithm in the IPsec phase.
                /// </summary>
                [NameInMap("IpsecAuthAlg")]
                [Validation(Required=false)]
                public string IpsecAuthAlg { get; set; }

                /// <summary>
                /// The encryption algorithm in the IPsec phase.
                /// </summary>
                [NameInMap("IpsecEncAlg")]
                [Validation(Required=false)]
                public string IpsecEncAlg { get; set; }

                /// <summary>
                /// The lifetime in the IPsec phase. Unit: seconds.
                /// </summary>
                [NameInMap("IpsecLifetime")]
                [Validation(Required=false)]
                public long? IpsecLifetime { get; set; }

                /// <summary>
                /// The DH group in the IPsec phase.
                /// </summary>
                [NameInMap("IpsecPfs")]
                [Validation(Required=false)]
                public string IpsecPfs { get; set; }

            }

            /// <summary>
            /// The identifier of the customer gateway.
            /// </summary>
            [NameInMap("Local")]
            [Validation(Required=false)]
            public string Local { get; set; }

            /// <summary>
            /// The CIDR block on the data center side.
            /// </summary>
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            /// <summary>
            /// The identifier of the VPN gateway.
            /// </summary>
            [NameInMap("Remote")]
            [Validation(Required=false)]
            public string Remote { get; set; }

            /// <summary>
            /// The CIDR block on the virtual private cloud (VPC) side.
            /// </summary>
            [NameInMap("RemoteSubnet")]
            [Validation(Required=false)]
            public string RemoteSubnet { get; set; }

            /// <summary>
            /// The tunnel configurations of the peer gateway device.
            /// 
            /// The parameters in **TunnelsConfig** are returned only when the IPsec-VPN connection supports the dual-tunnel mode.
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
                    /// The configurations of Phase 1 negotiations.
                    /// </summary>
                    [NameInMap("IkeConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig IkeConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIkeConfig : TeaModel {
                        /// <summary>
                        /// The authentication algorithm in the IKE phase.
                        /// </summary>
                        [NameInMap("IkeAuthAlg")]
                        [Validation(Required=false)]
                        public string IkeAuthAlg { get; set; }

                        /// <summary>
                        /// The encryption algorithm in the IKE phase.
                        /// </summary>
                        [NameInMap("IkeEncAlg")]
                        [Validation(Required=false)]
                        public string IkeEncAlg { get; set; }

                        /// <summary>
                        /// The lifetime in the IKE phase. Unit: seconds.
                        /// </summary>
                        [NameInMap("IkeLifetime")]
                        [Validation(Required=false)]
                        public long? IkeLifetime { get; set; }

                        /// <summary>
                        /// The IKE negotiation mode. Valid values:
                        /// 
                        /// *   **main**: This mode offers higher security during negotiations.
                        /// *   **aggressive**: This mode is faster and has a higher success rate.
                        /// </summary>
                        [NameInMap("IkeMode")]
                        [Validation(Required=false)]
                        public string IkeMode { get; set; }

                        /// <summary>
                        /// The DH group in the IKE phase.
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
                        /// The identifier of the tunnel on the data center side.
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
                        /// The identifier of the tunnel on the Alibaba Cloud side.
                        /// </summary>
                        [NameInMap("RemoteId")]
                        [Validation(Required=false)]
                        public string RemoteId { get; set; }

                    }

                    /// <summary>
                    /// The configurations of Phase 2 negotiations.
                    /// </summary>
                    [NameInMap("IpsecConfig")]
                    [Validation(Required=false)]
                    public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig IpsecConfig { get; set; }
                    public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigTunnelsConfigTunnelConfigIpsecConfig : TeaModel {
                        /// <summary>
                        /// The authentication algorithm in the IPsec phase.
                        /// </summary>
                        [NameInMap("IpsecAuthAlg")]
                        [Validation(Required=false)]
                        public string IpsecAuthAlg { get; set; }

                        /// <summary>
                        /// The encryption algorithm in the IPsec phase.
                        /// </summary>
                        [NameInMap("IpsecEncAlg")]
                        [Validation(Required=false)]
                        public string IpsecEncAlg { get; set; }

                        /// <summary>
                        /// The lifetime in the IPsec phase. Unit: seconds.
                        /// </summary>
                        [NameInMap("IpsecLifetime")]
                        [Validation(Required=false)]
                        public long? IpsecLifetime { get; set; }

                        /// <summary>
                        /// The DH group in the IPsec phase.
                        /// </summary>
                        [NameInMap("IpsecPfs")]
                        [Validation(Required=false)]
                        public string IpsecPfs { get; set; }

                    }

                    /// <summary>
                    /// The identifier of the tunnel on the data center side.
                    /// </summary>
                    [NameInMap("Local")]
                    [Validation(Required=false)]
                    public string Local { get; set; }

                    /// <summary>
                    /// The identifier of the tunnel on the Alibaba Cloud side.
                    /// </summary>
                    [NameInMap("Remote")]
                    [Validation(Required=false)]
                    public string Remote { get; set; }

                    /// <summary>
                    /// The tunnel ID.
                    /// </summary>
                    [NameInMap("TunnelId")]
                    [Validation(Required=false)]
                    public string TunnelId { get; set; }

                }

            }

        }

    }

}
