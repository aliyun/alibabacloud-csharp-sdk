// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEndpointsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceEndpointsResponseBodyData Data { get; set; }
        public class DescribeDBInstanceEndpointsResponseBodyData : TeaModel {
            [NameInMap("DBInstanceEndpoints")]
            [Validation(Required=false)]
            public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpoints DBInstanceEndpoints { get; set; }
            public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpoints : TeaModel {
                [NameInMap("DBInstanceEndpoint")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpoint> DBInstanceEndpoint { get; set; }
                public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpoint : TeaModel {
                    [NameInMap("AddressItems")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItems AddressItems { get; set; }
                    public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItems : TeaModel {
                        [NameInMap("AddressItem")]
                        [Validation(Required=false)]
                        public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItemsAddressItem> AddressItem { get; set; }
                        public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointAddressItemsAddressItem : TeaModel {
                            [NameInMap("ConnectionString")]
                            [Validation(Required=false)]
                            public string ConnectionString { get; set; }

                            [NameInMap("IpAddress")]
                            [Validation(Required=false)]
                            public string IpAddress { get; set; }

                            [NameInMap("IpType")]
                            [Validation(Required=false)]
                            public string IpType { get; set; }

                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                        }

                    }

                    [NameInMap("EndpointDescription")]
                    [Validation(Required=false)]
                    public string EndpointDescription { get; set; }

                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    [NameInMap("NodeItems")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItems NodeItems { get; set; }
                    public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItems : TeaModel {
                        [NameInMap("NodeItem")]
                        [Validation(Required=false)]
                        public List<DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItemsNodeItem> NodeItem { get; set; }
                        public class DescribeDBInstanceEndpointsResponseBodyDataDBInstanceEndpointsDBInstanceEndpointNodeItemsNodeItem : TeaModel {
                            [NameInMap("DBInstanceId")]
                            [Validation(Required=false)]
                            public string DBInstanceId { get; set; }

                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                }

            }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
