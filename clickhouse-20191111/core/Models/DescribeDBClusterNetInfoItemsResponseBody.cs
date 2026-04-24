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

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class DescribeDBClusterNetInfoItemsResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("HttpPort")]
                [Validation(Required=false)]
                public string HttpPort { get; set; }

                [NameInMap("HttpsPort")]
                [Validation(Required=false)]
                public string HttpsPort { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("JdbcPort")]
                [Validation(Required=false)]
                public string JdbcPort { get; set; }

                [NameInMap("MySQLPort")]
                [Validation(Required=false)]
                public string MySQLPort { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

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
