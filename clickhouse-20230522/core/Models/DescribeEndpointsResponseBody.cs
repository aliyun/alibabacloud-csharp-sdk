// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEndpointsResponseBodyData Data { get; set; }
        public class DescribeEndpointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of endpoint details.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<DescribeEndpointsResponseBodyDataEndpoints> Endpoints { get; set; }
            public class DescribeEndpointsResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// <para>The compute group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-ad321**-clickhouse</para>
                /// </summary>
                [NameInMap("ComputingGroupId")]
                [Validation(Required=false)]
                public string ComputingGroupId { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-****-clickhouse.clickhouseserver.pre.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The endpoint name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-*****-clickhouse</para>
                /// </summary>
                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.30.XX.XX</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VPC: virtual private cloud.</description></item>
                /// <item><description>PUBLIC: public network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The list of port details.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeEndpointsResponseBodyDataEndpointsPorts> Ports { get; set; }
                public class DescribeEndpointsResponseBodyDataEndpointsPorts : TeaModel {
                    /// <summary>
                    /// <para>The access port. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HttpPort: 8123</description></item>
                    /// <item><description>HttpsPort: 8443</description></item>
                    /// <item><description>TcpPort: 9000</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8123</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HttpPort: HTTP port.</description></item>
                    /// <item><description>HttpsPort: HTTPS port.</description></item>
                    /// <item><description>TcpPort: TCP port.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HttpPort</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-0xi8829****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf61z****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC-connected instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf61z****</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The network type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: virtual private cloud.</description></item>
            /// <item><description><b>PUBLIC</b>: public network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("InstanceNetworkType")]
            [Validation(Required=false)]
            public string InstanceNetworkType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
