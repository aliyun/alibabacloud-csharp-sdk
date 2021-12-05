// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DownloadVpnConnectionConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpnConnectionConfig")]
        [Validation(Required=false)]
        public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig VpnConnectionConfig { get; set; }
        public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfig : TeaModel {
            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig IkeConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIkeConfig : TeaModel {
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
            public DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig IpsecConfig { get; set; }
            public class DownloadVpnConnectionConfigResponseBodyVpnConnectionConfigIpsecConfig : TeaModel {
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
            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }
            [NameInMap("Remote")]
            [Validation(Required=false)]
            public string Remote { get; set; }
            [NameInMap("RemoteSubnet")]
            [Validation(Required=false)]
            public string RemoteSubnet { get; set; }
        };

    }

}
