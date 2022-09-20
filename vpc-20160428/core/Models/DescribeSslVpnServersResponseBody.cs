// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnServersResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SslVpnServers")]
        [Validation(Required=false)]
        public DescribeSslVpnServersResponseBodySslVpnServers SslVpnServers { get; set; }
        public class DescribeSslVpnServersResponseBodySslVpnServers : TeaModel {
            [NameInMap("SslVpnServer")]
            [Validation(Required=false)]
            public List<DescribeSslVpnServersResponseBodySslVpnServersSslVpnServer> SslVpnServer { get; set; }
            public class DescribeSslVpnServersResponseBodySslVpnServersSslVpnServer : TeaModel {
                [NameInMap("Cipher")]
                [Validation(Required=false)]
                public string Cipher { get; set; }

                [NameInMap("ClientIpPool")]
                [Validation(Required=false)]
                public string ClientIpPool { get; set; }

                [NameInMap("Compress")]
                [Validation(Required=false)]
                public bool? Compress { get; set; }

                [NameInMap("Connections")]
                [Validation(Required=false)]
                public int? Connections { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("EnableMultiFactorAuth")]
                [Validation(Required=false)]
                public bool? EnableMultiFactorAuth { get; set; }

                [NameInMap("IDaaSInstanceId")]
                [Validation(Required=false)]
                public string IDaaSInstanceId { get; set; }

                [NameInMap("IDaaSRegionId")]
                [Validation(Required=false)]
                public string IDaaSRegionId { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("LocalSubnet")]
                [Validation(Required=false)]
                public string LocalSubnet { get; set; }

                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Proto")]
                [Validation(Required=false)]
                public string Proto { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SslVpnServerId")]
                [Validation(Required=false)]
                public string SslVpnServerId { get; set; }

                [NameInMap("VpnGatewayId")]
                [Validation(Required=false)]
                public string VpnGatewayId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
