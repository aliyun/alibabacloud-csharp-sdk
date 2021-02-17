// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeShardingNetworkAddressResponseBody : TeaModel {
        [NameInMap("CompatibleConnections")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyCompatibleConnections CompatibleConnections { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyCompatibleConnections : TeaModel {
            [NameInMap("CompatibleConnection")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection> CompatibleConnection { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection : TeaModel {
                public string VswitchId { get; set; }
                public string ExpiredTime { get; set; }
                public string NetworkType { get; set; }
                public string Port { get; set; }
                public string NetworkAddress { get; set; }
                public string VPCId { get; set; }
                public string IPAddress { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NetworkAddresses")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyNetworkAddresses NetworkAddresses { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyNetworkAddresses : TeaModel {
            [NameInMap("NetworkAddress")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress> NetworkAddress { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress : TeaModel {
                public string NodeType { get; set; }
                public string VswitchId { get; set; }
                public string ExpiredTime { get; set; }
                public string NetworkType { get; set; }
                public string Role { get; set; }
                public string Port { get; set; }
                public string VPCId { get; set; }
                public string NetworkAddress { get; set; }
                public string NodeId { get; set; }
                public string IPAddress { get; set; }
            }
        };

    }

}
