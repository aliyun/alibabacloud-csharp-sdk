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
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        [NameInMap("NetworkAddresses")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyNetworkAddresses NetworkAddresses { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyNetworkAddresses : TeaModel {
            [NameInMap("NetworkAddress")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress> NetworkAddress { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress : TeaModel {
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
