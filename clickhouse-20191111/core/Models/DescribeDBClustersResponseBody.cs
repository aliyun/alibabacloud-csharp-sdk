// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// The details of the clusters.
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
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// The site ID. Valid values:
                /// 
                /// *   **26842**: the China site (aliyun.com)
                /// *   **26888**: the international site (alibabacloud.com)
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// The edition of the cluster. Valid values:
                /// 
                /// *   **Basic**: Single-replica Edition
                /// *   **HighAvailability**: Double-replica Edition
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The commodity code of the cluster.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The VPC endpoint of the cluster.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The version number of the backend management system of ApsaraDB for ClickHouse. Valid values:
                /// 
                /// *   **v1**
                /// *   **v2**
                /// </summary>
                [NameInMap("ControlVersion")]
                [Validation(Required=false)]
                public string ControlVersion { get; set; }

                /// <summary>
                /// The time when the cluster was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the cluster.
                /// </summary>
                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The network type of the cluster. Only VPC is supported.
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// The state of the cluster. Valid values:
                /// 
                /// *   **Preparing**: The cluster is being prepared.
                /// *   **Creating**: The cluster is being created.
                /// *   **Running**: The cluster is running.
                /// *   **Deleting**: The cluster is being deleted.
                /// *   **SCALING_OUT**: The storage capacity of the cluster is being expanded.
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// The specifications of the cluster.
                /// 
                /// *   Valid values when the cluster is of Single-replica Edition: -**S4**: 4 CPU cores and 16 GB of memory -**S8**: 8 CPU cores and 32 GB of memory
                /// 
                ///     *   **S16**: 16 CPU cores and 64 GB of memory
                ///     *   **S32**: 32 CPU cores and 128 GB of memory
                ///     *   **S64**: 64 CPU cores and 256 GB of memory
                ///     *   **S104**: 104 CPU cores and 384 GB of memory
                /// 
                /// *   Valid values when the cluster is of Double-replica Edition: -**C4**: 4 CPU cores and 16 GB of memory -**C8**: 8 CPU cores and 32 GB of memory -**C16**: 16 CPU cores and 64 GB of memory -**C32**: 32 CPU cores and 128 GB of memory -**C64**: 64 CPU cores and 256 GB of memory -**C104**: 104 CPU cores and 384 GB of memory
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// The number of nodes.
                /// 
                /// *   Valid values when the cluster is of Single-replica Edition: 1 to 48.
                /// *   Valid values when the cluster is of Double-replica Edition: 1 to 24.
                /// </summary>
                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                /// <summary>
                /// The storage capacity of each node. Valid values: 100 to 32000. Unit: GB.
                /// 
                /// >  This value is a multiple of 100.
                /// </summary>
                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                [NameInMap("DbVersion")]
                [Validation(Required=false)]
                public string DbVersion { get; set; }

                /// <summary>
                /// The time when the cluster expired. The time is in the yyyy-MM-ddTHH:mm:ssZ format.
                /// 
                /// >  Pay-as-you-go clusters never expire. If the cluster is a pay-as-you-go cluster, an empty string is returned for this parameter.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The extended storage space.
                /// </summary>
                [NameInMap("ExtStorageSize")]
                [Validation(Required=false)]
                public int? ExtStorageSize { get; set; }

                /// <summary>
                /// The extended storage type. Valid values:
                /// 
                /// *   **CloudSSD**: standard SSD.
                /// *   **CloudESSD**: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.
                /// *   **CloudESSD_PL2**: The cluster uses an ESSD of PL 2.
                /// *   **CloudESSD_PL3**: The cluster uses an ESSD of PL 3.
                /// *   **CloudEfficiency**: The cluster uses an ultra disk.
                /// </summary>
                [NameInMap("ExtStorageType")]
                [Validation(Required=false)]
                public string ExtStorageType { get; set; }

                /// <summary>
                /// Indicates whether the cluster has expired. Valid values:
                /// 
                /// *   **true**: The cluster has expired.
                /// *   **false**: The cluster has not expired.
                /// </summary>
                [NameInMap("IsExpired")]
                [Validation(Required=false)]
                public string IsExpired { get; set; }

                /// <summary>
                /// The lock mode of the cluster. Valid values:
                /// 
                /// *   **Unlock**: The cluster is not locked.
                /// *   **ManualLock**: The cluster is manually locked.
                /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
                /// *   **LockByRestoration**: The cluster is automatically locked because the cluster is about to be rolled back.
                /// *   **LockByDiskQuota**: The cluster is automatically locked because the disk space is exhausted.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The cause why the cluster was locked.
                /// 
                /// >  If the value of the LockMode parameter is Unlock, an empty string is returned for this parameter.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The billing method of the cluster. Valid values:
                /// 
                /// *   **Postpaid**: The cluster uses the pay-as-you-go billing method.
                /// *   **Prepaid**: The cluster uses the subscription billing method.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The HTTP port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the cluster belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of a data migration task.
                /// </summary>
                [NameInMap("ScaleOutStatus")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus ScaleOutStatus { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus : TeaModel {
                    /// <summary>
                    /// The progress of the data migration task in percentage.
                    /// 
                    /// >  This parameter is returned only when the cluster is in the SCALING_OUT state.
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// The progress of the data migration task. This value is displayed in the following format: Data volume that has been migrated/Total data volume.
                    /// 
                    /// >  This parameter is returned only when the cluster is in the SCALING_OUT state.
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                }

                /// <summary>
                /// The storage type of the cluster. Valid values:
                /// 
                /// *   **CloudESSD**: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.
                /// *   **CloudESSD_PL2**: The cluster uses an ESSD of PL 2.
                /// *   **CloudESSD_PL3**: The cluster uses an ESSD of PL 3.
                /// *   **CloudEfficiency**: The cluster uses an ultra disk.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The tags.
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
                        /// The tag name.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC in which the cluster is deployed.
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) in which the cluster is deployed.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
