// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the clusters.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                /// <summary>
                /// <para>The type of the AI node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SearchNode: search node</description></item>
                /// <item><description>DLNode: AI node</description></item>
                /// </list>
                /// <para>Enumeration values:</para>
                /// <list type="bullet">
                /// <item><description>SearchNode | DLNode: both</description></item>
                /// <item><description>DLNode: AI node</description></item>
                /// <item><description>SearchNode: search node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SearchNode</para>
                /// </summary>
                [NameInMap("AiType")]
                [Validation(Required=false)]
                public string AiType { get; set; }

                /// <summary>
                /// <para>The edition of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: Cluster Edition</description></item>
                /// <item><description><b>Basic</b>: Single Node Edition</description></item>
                /// <item><description><b>Archive</b>: X-Engine Edition</description></item>
                /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster (Database/Table) Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-14T05:58:42Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GDN-1</para>
                /// </summary>
                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-****************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The network type of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// <para>The state of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// <para>The specifications of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x4.large</para>
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBNodeNumber")]
                [Validation(Required=false)]
                public int? DBNodeNumber { get; set; }

                /// <summary>
                /// <para>The information about the nodes.</para>
                /// </summary>
                [NameInMap("DBNodes")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterDBNodes DBNodes { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterDBNodes : TeaModel {
                    [NameInMap("DBNode")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode> DBNode { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode : TeaModel {
                        /// <summary>
                        /// <para>The specifications of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>polar.mysql.x4.large</para>
                        /// </summary>
                        [NameInMap("DBNodeClass")]
                        [Validation(Required=false)]
                        public string DBNodeClass { get; set; }

                        /// <summary>
                        /// <para>The ID of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pi-****************</para>
                        /// </summary>
                        [NameInMap("DBNodeId")]
                        [Validation(Required=false)]
                        public string DBNodeId { get; set; }

                        /// <summary>
                        /// <para>The role of the node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Writer</b>: primary node</description></item>
                        /// <item><description><b>Reader</b>: read-only node</description></item>
                        /// <item><description><b>ColumnReader</b>: column store read-only node</description></item>
                        /// <item><description><b>AI</b>: AI node</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Reader</para>
                        /// </summary>
                        [NameInMap("DBNodeRole")]
                        [Validation(Required=false)]
                        public string DBNodeRole { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the hot standby feature is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ON</b></description></item>
                        /// <item><description><b>OFF</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OFF</para>
                        /// </summary>
                        [NameInMap("HotReplicaMode")]
                        [Validation(Required=false)]
                        public string HotReplicaMode { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the In-Memory Column Index (IMCI) feature is enabled. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ON</b></description></item>
                        /// <item><description><b>OFF</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OFF</para>
                        /// </summary>
                        [NameInMap("ImciSwitch")]
                        [Validation(Required=false)]
                        public string ImciSwitch { get; set; }

                        /// <summary>
                        /// <para>The region ID of the cluster.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the serverless feature is enabled for the node.</para>
                        /// <list type="bullet">
                        /// <item><description><b>ON</b> indicates that the serverless feature is enabled.</description></item>
                        /// <item><description>No value is returned if the serverless feature is disabled.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ON</para>
                        /// </summary>
                        [NameInMap("Serverless")]
                        [Validation(Required=false)]
                        public string Serverless { get; set; }

                        /// <summary>
                        /// <para>The zone ID of the cluster.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-i</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                /// <summary>
                /// <para>The version of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.6</para>
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster is protected from deletion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The cluster is not protected from deletion.</description></item>
                /// <item><description><b>1</b>: The cluster is protected from deletion.</description></item>
                /// </list>
                /// <remarks>
                /// <para> You cannot delete clusters that are protected from deletion.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeletionLock")]
                [Validation(Required=false)]
                public int? DeletionLock { get; set; }

                /// <summary>
                /// <para>The database engine of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POLARDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The expiration time of the cluster.</para>
                /// <remarks>
                /// <para> A specific value is returned only for subscription (<b>Prepaid</b>) clusters. For pay-as-you-go (<b>Postpaid</b>) clusters, no value is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-14T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> A specific value is returned only for subscription (<b>Prepaid</b>) clusters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("HotStandbyCluster")]
                [Validation(Required=false)]
                public string HotStandbyCluster { get; set; }

                /// <summary>
                /// <para>The lock state of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is unlocked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is locked due to cluster expiration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The memory size for local operations. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public string MemorySize { get; set; }

                /// <summary>
                /// <para>The billing method of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
                /// <item><description><b>Prepaid</b>: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prepaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The memory size for distributed operations. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3612</para>
                /// </summary>
                [NameInMap("RemoteMemorySize")]
                [Validation(Required=false)]
                public string RemoteMemorySize { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-************</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster is a serverless cluster. <b>AgileServerless</b> indicates the cluster is a serverless cluster. No value is returned for a common cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgileServerless</para>
                /// </summary>
                [NameInMap("ServerlessType")]
                [Validation(Required=false)]
                public string ServerlessType { get; set; }

                /// <summary>
                /// <para>The storage billing method of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
                /// <item><description><b>Prepaid</b>: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prepaid</para>
                /// </summary>
                [NameInMap("StoragePayType")]
                [Validation(Required=false)]
                public string StoragePayType { get; set; }

                /// <summary>
                /// <para>The storage that is billed based on the subscription billing method. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("StorageSpace")]
                [Validation(Required=false)]
                public long? StorageSpace { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>essdautopl</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The used storage. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3009413120</para>
                /// </summary>
                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public long? StorageUsed { get; set; }

                /// <summary>
                /// <para>Indicates whether multi-zone data consistency is enabled for the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ON</b>: Multi-zone data consistency is enabled. For Standard Edition clusters of Multi-zone Edition, this value is returned.</description></item>
                /// <item><description><b>OFF</b>: Multi-zone data consistency is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("StrictConsistency")]
                [Validation(Required=false)]
                public string StrictConsistency { get; set; }

                /// <summary>
                /// <para>The specification type of the compute node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Exclusive</b>: dedicated.</description></item>
                /// <item><description><b>General</b>: general-purpose.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exclusive</para>
                /// </summary>
                [NameInMap("SubCategory")]
                [Validation(Required=false)]
                public string SubCategory { get; set; }

                /// <summary>
                /// <para>The information about the tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MySQL</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.6</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-****************</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-***************</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <para>The zone ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of clusters returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
