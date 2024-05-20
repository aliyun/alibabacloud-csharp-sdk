// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterNetInfoItemsResponseBody : TeaModel {
        /// <summary>
        /// The network type of the cluster. Only VPC is supported.
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// Indicates whether Server Load Balancer (SLB) is activated in the VPC. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableSLB")]
        [Validation(Required=false)]
        public bool? EnableSLB { get; set; }

        /// <summary>
        /// The network information about the cluster.
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
                /// The endpoint that is used to connect to the database.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The HTTP port number.
                /// </summary>
                [NameInMap("HttpPort")]
                [Validation(Required=false)]
                public string HttpPort { get; set; }

                /// <summary>
                /// The HTTPS port number.
                /// </summary>
                [NameInMap("HttpsPort")]
                [Validation(Required=false)]
                public string HttpsPort { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The port number that is used in Java Database Connectivity (JDBC).
                /// </summary>
                [NameInMap("JdbcPort")]
                [Validation(Required=false)]
                public string JdbcPort { get; set; }

                /// <summary>
                /// The port of the MySQL instance.
                /// </summary>
                [NameInMap("MySQLPort")]
                [Validation(Required=false)]
                public string MySQLPort { get; set; }

                /// <summary>
                /// The network type of the endpoint. Valid values:
                /// 
                /// *   Public: public endpoint
                /// *   VPC: VPC
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// 
                /// >  If the value of the NetType parameter is set to Public, an empty string is returned.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID.
                /// 
                /// >  If the value of the NetType parameter is set to Public, an empty string is returned.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
