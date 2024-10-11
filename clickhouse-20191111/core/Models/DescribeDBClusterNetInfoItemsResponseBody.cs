// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterNetInfoItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The network type of the cluster. Only VPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>Indicates whether Server Load Balancer (SLB) is activated in the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSLB")]
        [Validation(Required=false)]
        public bool? EnableSLB { get; set; }

        /// <summary>
        /// <para>The network information about the cluster.</para>
        /// </summary>
        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                /// <summary>
                /// <para>The endpoint that is used to connect to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp1554t789i8e****.clickhouse.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The HTTP port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8123</para>
                /// </summary>
                [NameInMap("HttpPort")]
                [Validation(Required=false)]
                public string HttpPort { get; set; }

                /// <summary>
                /// <para>The HTTPS port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8443</para>
                /// </summary>
                [NameInMap("HttpsPort")]
                [Validation(Required=false)]
                public string HttpsPort { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.255.234.251</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The port number that is used in Java Database Connectivity (JDBC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("JdbcPort")]
                [Validation(Required=false)]
                public string JdbcPort { get; set; }

                /// <summary>
                /// <para>The port of the MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9004</para>
                /// </summary>
                [NameInMap("MySQLPort")]
                [Validation(Required=false)]
                public string MySQLPort { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Public: public endpoint</description></item>
                /// <item><description>VPC: VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// <remarks>
                /// <para> If the value of the NetType parameter is set to Public, an empty string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1gzt31twhlo0sa5****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// <remarks>
                /// <para> If the value of the NetType parameter is set to Public, an empty string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp175iuvg8nxqraf2****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A23C87D-87DF-4DA0-A50E-CB13F4F7923D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
