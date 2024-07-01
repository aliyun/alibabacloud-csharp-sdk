// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// The network type of the cluster. Only the Virtual Private Cloud (VPC) network type is supported. **VPC** is returned.
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// The network information about the cluster.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeClusterNetInfoResponseBodyItemsAddress : TeaModel {
                /// <summary>
                /// The endpoint of the cluster.
                /// 
                /// *   If the network type of the cluster is VPC, the VPC endpoint of the cluster is returned.
                /// *   If the network type of the cluster is Public, the public endpoint of the cluster is returned.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The prefix of the endpoint.
                /// 
                /// *   If the network type of the cluster is VPC, the prefix of the private endpoint is returned.
                /// *   If the network type of the cluster is Public, the prefix of the public endpoint is returned.
                /// </summary>
                [NameInMap("ConnectionStringPrefix")]
                [Validation(Required=false)]
                public string ConnectionStringPrefix { get; set; }

                /// <summary>
                /// The IP address of the endpoint.
                /// 
                /// *   If the network type of the cluster is VPC, the IP address of the private endpoint is returned.
                /// *   If the network type of the cluster is Public, the IP address of the public endpoint is returned.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the cluster. Valid values:
                /// 
                /// *   **Public**: Internet.
                /// *   **VPC**: VPC.
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the cluster. **3306** is returned.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public DescribeClusterNetInfoResponseBodyItemsAddressPorts Ports { get; set; }
                public class DescribeClusterNetInfoResponseBodyItemsAddressPorts : TeaModel {
                    [NameInMap("ports")]
                    [Validation(Required=false)]
                    public List<DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts> Ports { get; set; }
                    public class DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts : TeaModel {
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                }

                /// <summary>
                /// The VPC ID.
                /// 
                /// > If NetType is set to Public, an empty string is returned for this parameter.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID of the cluster.
                /// 
                /// > If NetType is set to Public, an empty string is returned for this parameter.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

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
