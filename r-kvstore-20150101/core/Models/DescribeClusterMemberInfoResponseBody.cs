// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeClusterMemberInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data node information for the cluster instance.</para>
        /// </summary>
        [NameInMap("ClusterChildren")]
        [Validation(Required=false)]
        public List<DescribeClusterMemberInfoResponseBodyClusterChildren> ClusterChildren { get; set; }
        public class DescribeClusterMemberInfoResponseBodyClusterChildren : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the node. Unit: MB/s.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the <b>Service</b> parameter is set to <b>redis</b>, which indicates that the node is a data node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The number of days for which binary logs are retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("BinlogRetentionDays")]
            [Validation(Required=false)]
            public int? BinlogRetentionDays { get; set; }

            /// <summary>
            /// <para>The business type. The value is fixed as <b>ALIYUN</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The maximum memory capacity of a single data node. Unit: MB.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the <b>Service</b> parameter is set to <b>redis</b>, which indicates that the node is a data node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The specifications of the data node. For more information, see <a href="https://help.aliyun.com/document_detail/164477.html">Cloud-native instance specifications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis.shard.small.ce</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The maximum number of connections for the data node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public long? Connections { get; set; }

            /// <summary>
            /// <para>The current bandwidth of the node. Unit: MB/s. The value is the sum of the default bandwidth and the increased bandwidth of the node.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;This parameter is returned only when the instance is created in a dedicated cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CurrentBandWidth")]
            [Validation(Required=false)]
            public long? CurrentBandWidth { get; set; }

            /// <summary>
            /// <para>The storage space of the <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disk</a> for the data node. Unit: MB.</para>
            /// <remarks>
            /// <para>The ESSD cloud disk is used only for system operations, such as data persistence, and is not used as a medium for data access.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("DiskSizeMB")]
            [Validation(Required=false)]
            public int? DiskSizeMB { get; set; }

            /// <summary>
            /// <para>The replica set ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>501791111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1zxszhcgatnx****-db-0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of child nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReplicaSize")]
            [Validation(Required=false)]
            public int? ReplicaSize { get; set; }

            /// <summary>
            /// <para>The name of the resource group to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL_ZHANGJIAKOU_A</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>redis</b>: data node.</description></item>
            /// <item><description><b>redis_cs</b>: configuration server node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>redis</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The major version of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2****_176498472570****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D9F3768-EDA9-4811-943E-42C8006E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
