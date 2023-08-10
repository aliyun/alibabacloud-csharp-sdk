// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyTunnelAttributeResponseBody : TeaModel {
        [NameInMap("CustomerGatewayId")]
        [Validation(Required=false)]
        public string CustomerGatewayId { get; set; }

        [NameInMap("EnableDpd")]
        [Validation(Required=false)]
        public bool? EnableDpd { get; set; }

        [NameInMap("EnableNatTraversal")]
        [Validation(Required=false)]
        public bool? EnableNatTraversal { get; set; }

        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        [NameInMap("RemoteCaCertificate")]
        [Validation(Required=false)]
        public string RemoteCaCertificate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("TunnelBgpConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelBgpConfig TunnelBgpConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelBgpConfig : TeaModel {
            [NameInMap("EnableBgp")]
            [Validation(Required=false)]
            public bool? EnableBgp { get; set; }

            [NameInMap("LocalAsn")]
            [Validation(Required=false)]
            public long? LocalAsn { get; set; }

            [NameInMap("LocalBgpIp")]
            [Validation(Required=false)]
            public string LocalBgpIp { get; set; }

            [NameInMap("PeerAsn")]
            [Validation(Required=false)]
            public long? PeerAsn { get; set; }

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
        public ModifyTunnelAttributeResponseBodyTunnelIkeConfig TunnelIkeConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIkeConfig : TeaModel {
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

        [NameInMap("TunnelIpsecConfig")]
        [Validation(Required=false)]
        public ModifyTunnelAttributeResponseBodyTunnelIpsecConfig TunnelIpsecConfig { get; set; }
        public class ModifyTunnelAttributeResponseBodyTunnelIpsecConfig : TeaModel {
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

        [NameInMap("ZoneNo")]
        [Validation(Required=false)]
        public string ZoneNo { get; set; }

    }

}
