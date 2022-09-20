// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnConnectionAttributeResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EffectImmediately")]
        [Validation(Required=false)]
        public bool? EffectImmediately { get; set; }

        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        [NameInMap("IkeConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyIkeConfig IkeConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIkeConfig : TeaModel {
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
        public ModifyVpnConnectionAttributeResponseBodyIpsecConfig IpsecConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyIpsecConfig : TeaModel {
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

        [NameInMap("LocalSubnet")]
        [Validation(Required=false)]
        public string LocalSubnet { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RemoteSubnet")]
        [Validation(Required=false)]
        public string RemoteSubnet { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VcoHealthCheck")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck VcoHealthCheck { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVcoHealthCheck : TeaModel {
            [NameInMap("Dip")]
            [Validation(Required=false)]
            public string Dip { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("Retry")]
            [Validation(Required=false)]
            public int? Retry { get; set; }

            [NameInMap("Sip")]
            [Validation(Required=false)]
            public string Sip { get; set; }

        }

        [NameInMap("VpnBgpConfig")]
        [Validation(Required=false)]
        public ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig VpnBgpConfig { get; set; }
        public class ModifyVpnConnectionAttributeResponseBodyVpnBgpConfig : TeaModel {
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public string EnableBgp { get; set; }

            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public int? LocalAsn { get; set; }

            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public int? PeerAsn { get; set; }

            [NameInMap("PeerBgpIp")]
            [Validation(Required=false)]
            public string PeerBgpIp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TunnelCidr")]
            [Validation(Required=false)]
            public string TunnelCidr { get; set; }

        }

        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
