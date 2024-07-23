// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceEndpointsResponseBodyData Data { get; set; }
        public class DescribeDBInstanceEndpointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information of the endpoints of the instance.</para>
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
                    /// <para>The information about the endpoint.</para>
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
                            /// <para>The endpoints of the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rm****.mysql.rds.aliyuncs.com</para>
                            /// </summary>
                            [NameInMap("ConnectionString")]
                            [Validation(Required=false)]
                            public string ConnectionString { get; set; }

                            /// <summary>
                            /// <para>The IP address.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10.71.XX.XX</para>
                            /// </summary>
                            [NameInMap("IpAddress")]
                            [Validation(Required=false)]
                            public string IpAddress { get; set; }

                            /// <summary>
                            /// <para>The type of the IP address. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>Public</b>: Internet</description></item>
                            /// <item><description><b>Private</b>: internal network</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Private</para>
                            /// </summary>
                            [NameInMap("IpType")]
                            [Validation(Required=false)]
                            public string IpType { get; set; }

                            /// <summary>
                            /// <para>The port number of the endpoint.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3306</para>
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public string Port { get; set; }

                            /// <summary>
                            /// <para>The vSwitch ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vsw-bp12u14ecz****</para>
                            /// </summary>
                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                            /// <summary>
                            /// <para>The VPC ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vpc-bp17xdic25d****</para>
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The user-defined description of the endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>for readonly business</para>
                    /// </summary>
                    [NameInMap("EndpointDescription")]
                    [Validation(Required=false)]
                    public string EndpointDescription { get; set; }

                    /// <summary>
                    /// <para>The endpoint ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ep-****</para>
                    /// </summary>
                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// <para>The type of the endpoint. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Primary</b>: the read/write endpoint of the instance</description></item>
                    /// <item><description><b>Readonly</b>: the read-only endpoint of the instance</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Readonly</para>
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <para>The information about the node that is configured for the endpoint.</para>
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
                            /// <para>The instance ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rm-u****</para>
                            /// </summary>
                            [NameInMap("DBInstanceId")]
                            [Validation(Required=false)]
                            public string DBInstanceId { get; set; }

                            /// <summary>
                            /// <para>The node ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rn-****13p6tum4289h</para>
                            /// </summary>
                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                            /// <summary>
                            /// <para>The weight of the node. Read requests are distributed based on the weight.</para>
                            /// <para>Valid values: 0 to 100.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-u****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The version of the IP protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ipv4</b></description></item>
            /// <item><description><b>ipv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>777C4593-8053-427B-****105593277CAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
