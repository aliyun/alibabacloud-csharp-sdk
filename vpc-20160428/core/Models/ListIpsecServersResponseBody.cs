// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpsecServersResponseBody : TeaModel {
        [NameInMap("IpsecServers")]
        [Validation(Required=false)]
        public List<ListIpsecServersResponseBodyIpsecServers> IpsecServers { get; set; }
        public class ListIpsecServersResponseBodyIpsecServers : TeaModel {
            [NameInMap("ClientIpPool")]
            [Validation(Required=false)]
            public string ClientIpPool { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("EffectImmediately")]
            [Validation(Required=false)]
            public bool? EffectImmediately { get; set; }

            [NameInMap("IDaaSInstanceId")]
            [Validation(Required=false)]
            public string IDaaSInstanceId { get; set; }

            [NameInMap("IkeConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIkeConfig IkeConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIkeConfig : TeaModel {
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

                [NameInMap("RemoteId")]
                [Validation(Required=false)]
                public string RemoteId { get; set; }

            }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IpsecConfig")]
            [Validation(Required=false)]
            public ListIpsecServersResponseBodyIpsecServersIpsecConfig IpsecConfig { get; set; }
            public class ListIpsecServersResponseBodyIpsecServersIpsecConfig : TeaModel {
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

            [NameInMap("IpsecServerId")]
            [Validation(Required=false)]
            public string IpsecServerId { get; set; }

            [NameInMap("IpsecServerName")]
            [Validation(Required=false)]
            public string IpsecServerName { get; set; }

            [NameInMap("LocalSubnet")]
            [Validation(Required=false)]
            public string LocalSubnet { get; set; }

            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            [NameInMap("MultiFactorAuthEnabled")]
            [Validation(Required=false)]
            public bool? MultiFactorAuthEnabled { get; set; }

            [NameInMap("OnlineClientCount")]
            [Validation(Required=false)]
            public int? OnlineClientCount { get; set; }

            [NameInMap("Psk")]
            [Validation(Required=false)]
            public string Psk { get; set; }

            [NameInMap("PskEnabled")]
            [Validation(Required=false)]
            public bool? PskEnabled { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("VpnGatewayId")]
            [Validation(Required=false)]
            public string VpnGatewayId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
