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
                public string Cipher { get; set; }
                public string ClientIpPool { get; set; }
                public bool? Compress { get; set; }
                public int? Connections { get; set; }
                public long? CreateTime { get; set; }
                public bool? EnableMultiFactorAuth { get; set; }
                public string IDaaSInstanceId { get; set; }
                public string IDaaSRegionId { get; set; }
                public string InternetIp { get; set; }
                public string LocalSubnet { get; set; }
                public int? MaxConnections { get; set; }
                public string Name { get; set; }
                public int? Port { get; set; }
                public string Proto { get; set; }
                public string RegionId { get; set; }
                public string SslVpnServerId { get; set; }
                public string VpnGatewayId { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
