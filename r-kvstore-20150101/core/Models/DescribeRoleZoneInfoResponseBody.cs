// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about each node in an ApsaraDB for Redis instance.</para>
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyNode Node { get; set; }
        public class DescribeRoleZoneInfoResponseBodyNode : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyNodeNodeInfo> NodeInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyNodeNodeInfo : TeaModel {
                /// <summary>
                /// <para>The current bandwidth of the node, which consists of the default bandwidth and the increased bandwidth. Unit: MB/s.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/206173.html">EnableAdditionalBandwidth</a> operation to specify the increased bandwidth.</description></item>
                /// <item><description>You can also use this parameter to calculate the increased bandwidth. For example, if the default bandwidth of the node is 96 MB/s and the returned value of this parameter is 100, the increased bandwidth is 4 MB/s.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CurrentBandWidth")]
                [Validation(Required=false)]
                public long? CurrentBandWidth { get; set; }

                /// <summary>
                /// <para>The minor version of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis-5.0_0.3.10</para>
                /// </summary>
                [NameInMap("CurrentMinorVersion")]
                [Validation(Required=false)]
                public string CurrentMinorVersion { get; set; }

                /// <summary>
                /// <para>The ID of the data shard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30381****</para>
                /// </summary>
                [NameInMap("CustinsId")]
                [Validation(Required=false)]
                public string CustinsId { get; set; }

                /// <summary>
                /// <para>The default bandwidth of the node. Unit: MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("DefaultBandWidth")]
                [Validation(Required=false)]
                public long? DefaultBandWidth { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-t4nlenc2p04uvb****</para>
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is a read replica. If the node is a read replica, <b>3</b> is returned.</para>
                /// <remarks>
                /// <para> If the node is not a read replica, no value is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InsType")]
                [Validation(Required=false)]
                public int? InsType { get; set; }

                /// <summary>
                /// <para>Indicates whether the minor version is the latest version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The minor version is not the latest version.</description></item>
                /// <item><description><b>1</b>: The minor version is the latest version.</description></item>
                /// </list>
                /// <remarks>
                /// <para> To update the minor version, call the <a href="https://help.aliyun.com/document_detail/129381.html">ModifyInstanceMinorVersion</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public int? IsLatestVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the bandwidth of the node is increased. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The bandwidth of the node is not increased.</description></item>
                /// <item><description><b>false</b>: The bandwidth of the node is increased.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsOpenBandWidthService")]
                [Validation(Required=false)]
                public bool? IsOpenBandWidthService { get; set; }

                /// <summary>
                /// <para>This parameter is used only for internal maintenance of ApsaraDB for Redis instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10065****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>db</b>: data node.</description></item>
                /// <item><description><b>proxy</b>: proxy node.</description></item>
                /// <item><description><b>normal</b>: regular node. This value is returned when the instance runs in the standard architecture.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: master node</description></item>
                /// <item><description><b>slave</b>: replica node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224B97FB-A275-4EAC-86E9-8922FEA2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
