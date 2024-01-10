// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeShardingNetworkAddressResponseBody : TeaModel {
        /// <summary>
        /// The endpoints of DynamoDB-compatible instances.
        /// </summary>
        [NameInMap("CompatibleConnections")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyCompatibleConnections CompatibleConnections { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyCompatibleConnections : TeaModel {
            [NameInMap("CompatibleConnection")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection> CompatibleConnection { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection : TeaModel {
                /// <summary>
                /// The remaining duration of the classic network endpoint. Unit: seconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The IP address of the instance.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                /// <summary>
                /// The network type of the instance.
                /// 
                /// *   **VPC**: virtual private cloud
                /// *   **Classic**: classic network
                /// *   **Public**: the Internet
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The port that is used to connect to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// 
                /// >  This parameter is returned when the network type is **VPC**.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch in the Virtual Private Cloud (VPC).
                /// 
                /// >  This parameter is returned when the network type is **VPC**.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// The endpoints of ApsaraDB for MongoDB instances.
        /// </summary>
        [NameInMap("NetworkAddresses")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyNetworkAddresses NetworkAddresses { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyNetworkAddresses : TeaModel {
            [NameInMap("NetworkAddress")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress> NetworkAddress { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress : TeaModel {
                /// <summary>
                /// The remaining duration of the classic network endpoint. Unit: seconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The IP address of the instance.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The connection string of the instance.
                /// </summary>
                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                /// <summary>
                /// The network type of the instance.
                /// 
                /// *   **VPC**: virtual private cloud
                /// *   **Classic**: classic network
                /// *   **Public**: the Internet
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The ID of the mongos node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **mongos**: mongos node
                /// *   **shard**: shard node
                /// *   **configserver**: Configserver node
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The port that is used to connect to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   Primary
                /// *   Secondary
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// 
                /// >  This parameter is returned when the network type is **VPC**.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch in the VPC.
                /// 
                /// >  This parameter is returned when the network type is **VPC**.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
