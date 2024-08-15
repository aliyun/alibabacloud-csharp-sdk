// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceEndpointsResponseBodyData Data { get; set; }
        public class DescribeDBInstanceEndpointsResponseBodyData : TeaModel {
            /// <summary>
            /// The information of the endpoints of the instance.
            /// </summary>
            [NameInMap("DBInstanceEndpoints")]
            [Validation(Required=false)]
            public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpoints DBInstanceEndpoints { get; set; }
            public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpoints : TeaModel {
                [NameInMap("DBInstanceEndpoint")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpoint> DBInstanceEndpoint { get; set; }
                public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpoint : TeaModel {
                    /// <summary>
                    /// The information about the endpoint.
                    /// </summary>
                    [NameInMap("AddressItems")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItems AddressItems { get; set; }
                    public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItems : TeaModel {
                        [NameInMap("AddressItem")]
                        [Validation(Required=false)]
                        public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItemsAddressItem> AddressItem { get; set; }
                        public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItemsAddressItem : TeaModel {
                            /// <summary>
                            /// The endpoints of the instance.
                            /// </summary>
                            [NameInMap("ConnectionString")]
                            [Validation(Required=false)]
                            public string ConnectionString { get; set; }

                            /// <summary>
                            /// The IP address.
                            /// </summary>
                            [NameInMap("IpAddress")]
                            [Validation(Required=false)]
                            public string IpAddress { get; set; }

                            /// <summary>
                            /// The type of the IP address. Valid values:
                            /// 
                            /// *   **Public**: Internet
                            /// *   **Private**: internal network
                            /// </summary>
                            [NameInMap("IpType")]
                            [Validation(Required=false)]
                            public string IpType { get; set; }

                            /// <summary>
                            /// The port number of the endpoint.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                            /// <summary>
                            /// The vSwitch ID.
                            /// </summary>
                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                            /// <summary>
                            /// The VPC ID.
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                        }

                    }

                    /// <summary>
                    /// The user-defined description of the endpoint.
                    /// </summary>
                    [NameInMap("EndpointDescription")]
                    [Validation(Required=false)]
                    public string EndpointDescription { get; set; }

                    /// <summary>
                    /// The endpoint ID of the instance.
                    /// </summary>
                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// The type of the endpoint. Valid values:
                    /// 
                    /// *   **Primary**: the read/write endpoint of the instance
                    /// *   **Readonly**: the read-only endpoint of the instance
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// The information about the node that is configured for the endpoint.
                    /// </summary>
                    [NameInMap("NodeItems")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItems NodeItems { get; set; }
                    public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItems : TeaModel {
                        [NameInMap("NodeItem")]
                        [Validation(Required=false)]
                        public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItemsNodeItem> NodeItem { get; set; }
                        public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItemsNodeItem : TeaModel {
                            /// <summary>
                            /// The instance ID.
                            /// </summary>
                            [NameInMap("DBInstanceId")]
                            [Validation(Required=false)]
                            public string DBInstanceId { get; set; }

                            /// <summary>
                            /// The node ID.
                            /// </summary>
                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                            /// <summary>
                            /// The weight of the node. Read requests are distributed based on the weight.
                            /// 
                            /// Valid values: 0 to 100.
                            /// </summary>
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// The version of the IP protocol. Valid values:
            /// 
            /// *   **ipv4**
            /// *   **ipv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
