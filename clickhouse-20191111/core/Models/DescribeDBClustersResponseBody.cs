// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("DBClusters")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyDBClusters DBClusters { get; set; }
        public class DescribeDBClustersResponseBodyDBClusters : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyDBClustersDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyDBClustersDBCluster : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>The site ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>26842</b>: the China site (aliyun.com)</description></item>
                /// <item><description><b>26888</b>: the international site (alibabacloud.com)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>26842</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <para>The edition of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: Single-replica Edition</description></item>
                /// <item><description><b>HighAvailability</b>: Double-replica Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The commodity code of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clickhouse_go_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The VPC endpoint of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp1fs5o051c61****.clickhouse.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The version number of the backend management system of ApsaraDB for ClickHouse. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v1</b></description></item>
                /// <item><description><b>v2</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("ControlVersion")]
                [Validation(Required=false)]
                public string ControlVersion { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-28T07:24:45Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc-bp108z124a8o7****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. Only VPC is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// <para>The state of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Preparing</b>: The cluster is being prepared.</description></item>
                /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
                /// <item><description><b>Running</b>: The cluster is running.</description></item>
                /// <item><description><b>Deleting</b>: The cluster is being deleted.</description></item>
                /// <item><description><b>SCALING_OUT</b>: The storage capacity of the cluster is being expanded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// <para>The specifications of the cluster.</para>
                /// <list type="bullet">
                /// <item><description><para>Valid values when the cluster is of Single-replica Edition: -<b>S4</b>: 4 CPU cores and 16 GB of memory -<b>S8</b>: 8 CPU cores and 32 GB of memory</para>
                /// <list type="bullet">
                /// <item><description><b>S16</b>: 16 CPU cores and 64 GB of memory</description></item>
                /// <item><description><b>S32</b>: 32 CPU cores and 128 GB of memory</description></item>
                /// <item><description><b>S64</b>: 64 CPU cores and 256 GB of memory</description></item>
                /// <item><description><b>S104</b>: 104 CPU cores and 384 GB of memory</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Valid values when the cluster is of Double-replica Edition: -<b>C4</b>: 4 CPU cores and 16 GB of memory -<b>C8</b>: 8 CPU cores and 32 GB of memory -<b>C16</b>: 16 CPU cores and 64 GB of memory -<b>C32</b>: 32 CPU cores and 128 GB of memory -<b>C64</b>: 64 CPU cores and 256 GB of memory -<b>C104</b>: 104 CPU cores and 384 GB of memory</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>C8</para>
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// <list type="bullet">
                /// <item><description>Valid values when the cluster is of Single-replica Edition: 1 to 48.</description></item>
                /// <item><description>Valid values when the cluster is of Double-replica Edition: 1 to 24.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                /// <summary>
                /// <para>The storage capacity of each node. Valid values: 100 to 32000. Unit: GB.</para>
                /// <remarks>
                /// <para> This value is a multiple of 100.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                /// <summary>
                /// <para>The engine version of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.8</para>
                /// </summary>
                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public string DbVersion { get; set; }

                /// <summary>
                /// <para>The time when the cluster expired. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// <remarks>
                /// <para> Pay-as-you-go clusters never expire. If the cluster is a pay-as-you-go cluster, an empty string is returned for this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2011-05-30T12:11:4Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The extended storage space.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100GB</para>
                /// </summary>
                [NameInMap("ExtStorageSize")]
                [Validation(Required=false)]
                public int? ExtStorageSize { get; set; }

                /// <summary>
                /// <para>The extended storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CloudSSD</b>: standard SSD.</description></item>
                /// <item><description><b>CloudESSD</b>: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.</description></item>
                /// <item><description><b>CloudESSD_PL2</b>: The cluster uses an ESSD of PL 2.</description></item>
                /// <item><description><b>CloudESSD_PL3</b>: The cluster uses an ESSD of PL 3.</description></item>
                /// <item><description><b>CloudEfficiency</b>: The cluster uses an ultra disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CloudESSD</para>
                /// </summary>
                [NameInMap("ExtStorageType")]
                [Validation(Required=false)]
                public string ExtStorageType { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The cluster has expired.</description></item>
                /// <item><description><b>false</b>: The cluster has not expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsExpired")]
                [Validation(Required=false)]
                public string IsExpired { get; set; }

                /// <summary>
                /// <para>The lock mode of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The cluster is automatically locked because the cluster is about to be rolled back.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The cluster is automatically locked because the disk space is exhausted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The cause why the cluster was locked.</para>
                /// <remarks>
                /// <para> If the value of the LockMode parameter is Unlock, an empty string is returned for this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>DISK_FULL</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The billing method of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: The cluster uses the pay-as-you-go billing method.</description></item>
                /// <item><description><b>Prepaid</b>: The cluster uses the subscription billing method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The HTTP port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8123</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the cluster belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-4690g37929****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The time window during which write operations are stopped for specification changes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-08T00:00:00+08:00,2025-02-12T00:00:00+08:00</para>
                /// </summary>
                [NameInMap("ScaleOutDisableWriteWindows")]
                [Validation(Required=false)]
                public string ScaleOutDisableWriteWindows { get; set; }

                /// <summary>
                /// <para>The status of a data migration task.</para>
                /// </summary>
                [NameInMap("ScaleOutStatus")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus ScaleOutStatus { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus : TeaModel {
                    /// <summary>
                    /// <para>The progress of the data migration task in percentage.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only when the cluster is in the SCALING_OUT state.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The progress of the data migration task. This value is displayed in the following format: Data volume that has been migrated/Total data volume.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only when the cluster is in the SCALING_OUT state.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0MB/60469MB</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                }

                /// <summary>
                /// <para>The storage type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CloudESSD</b>: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.</description></item>
                /// <item><description><b>CloudESSD_PL2</b>: The cluster uses an ESSD of PL 2.</description></item>
                /// <item><description><b>CloudESSD_PL3</b>: The cluster uses an ESSD of PL 3.</description></item>
                /// <item><description><b>CloudEfficiency</b>: The cluster uses an ultra disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CloudESSD</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyDBClustersDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyDBClustersDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyDBClustersDBClusterTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>department</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>it</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1gzt31twhlo0sa5****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC in which the cluster is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp175iuvg8nxqraf2****</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) in which the cluster is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp175iuvg8nxqraf2****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
