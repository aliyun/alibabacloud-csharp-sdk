// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// The queried clusters.
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
                /// The edition of the cluster. Valid values:
                /// 
                /// *   **BASIC**: reserved mode for Basic Edition.
                /// *   **CLUSTER**: reserved mode for Cluster Edition.
                /// *   **MIXED_STORAGE**: elastic mode for Cluster Edition.
                /// 
                /// > For more information about cluster editions, see [Editions](~~205001~~).
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The commodity code. **ads** is returned.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The specifications of computing resources that are used in the cluster in elastic mode. The increase of computing resources can speed up queries. You can adjust the value of this parameter to scale the cluster.
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// The public endpoint that is used to connect to the cluster.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The time when the cluster was created. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC. Example: *2021-04-01T09:50:18Z*.
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
                /// The network type of the cluster. **VPC** is returned.
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// The state of the cluster. For more information, see [Cluster states](~~143075~~).
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// The type of the cluster. Valid values:
                /// 
                /// *   **Common**: common cluster.
                /// *   **RDS_ANALYSIS**: MySQL analytic instance.
                /// </summary>
                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                /// <summary>
                /// The instance type of the cluster.
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// The number of node groups.
                /// </summary>
                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                /// <summary>
                /// The storage capacity of the cluster. Unit: GB.
                /// </summary>
                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                /// <summary>
                /// The version of the database engine. **3.0** is returned.
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// The disk type of the cluster. Valid values:
                /// 
                /// *   **local_ssd**: local disk.
                /// *   **cloud**: basic disk.
                /// *   **cloud_ssd**: standard SSD.
                /// *   **cloud_efficiency**: ultra disk.
                /// *   **cloud_essd**: PL1 enhanced SSD (ESSD).
                /// *   **cloud_essd2**: PL2 ESSD.
                /// *   **cloud_essd3**: PL3 ESSD.
                /// 
                /// > For more information, see [ESSDs](~~122389~~).
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The ID of the Data Transmission Service (DTS) synchronization task. This parameter is returned only for MySQL analytic instances.
                /// </summary>
                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                /// <summary>
                /// The number of elastic I/O units (EIUs). For more information, see [Use EIUs to scale up storage resources](~~189505~~).
                /// 
                /// > This parameter is returned only for clusters in elastic mode.
                /// </summary>
                [NameInMap("ElasticIOResource")]
                [Validation(Required=false)]
                public int? ElasticIOResource { get; set; }

                /// <summary>
                /// The engine of the cluster. **AnalyticDB** is returned.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The number of compute nodes that are used by the cluster in elastic mode.
                /// </summary>
                [NameInMap("ExecutorCount")]
                [Validation(Required=false)]
                public string ExecutorCount { get; set; }

                /// <summary>
                /// The time when the cluster expires. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC. Example: *2999-09-08T16:00:00Z*.
                /// 
                /// > 
                /// 
                /// *   If the billing method of the cluster is subscription, the actual expiration time is returned.
                /// 
                /// *   If the billing method of the cluster is pay-as-you-go, **2999-09-08T16:00:00Z** is returned.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the cluster has expired. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// The public IP address of the cluster.
                /// </summary>
                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                /// <summary>
                /// The port number that is used to connect to the cluster.
                /// </summary>
                [NameInMap("InnerPort")]
                [Validation(Required=false)]
                public string InnerPort { get; set; }

                /// <summary>
                /// The lock mode of the cluster. Valid values:
                /// 
                /// *   **Unlock**: The cluster is not locked.
                /// *   **ManualLock**: The cluster is manually locked.
                /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
                /// *   **LockByRestoration**: The cluster is automatically locked due to cluster restoration.
                /// *   **LockByDiskQuota**: The cluster is automatically locked when it has used 90% of its storage.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The reason why the cluster is locked.
                /// 
                /// > This parameter is returned only when the cluster was locked. **instance_expire** is returned.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The mode of the cluster. Valid values:
                /// 
                /// *   **flexible**: elastic mode.
                /// *   **reserver**: reserved mode.
                /// 
                /// > 
                /// 
                /// *   For more information about cluster modes, see [Editions](~~205001~~).
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The billing method of the cluster. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go.
                /// *   **Prepaid**: subscription.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the cluster. Default value: 3306.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The ID of the ApsaraDB RDS instance from which data is synchronized to the cluster. This parameter is returned only for MySQL analytic instances.
                /// </summary>
                [NameInMap("RdsInstanceId")]
                [Validation(Required=false)]
                public string RdsInstanceId { get; set; }

                /// <summary>
                /// The region ID of the cluster.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The specifications of storage resources that are used in the cluster in elastic mode. These resources are used to read and write data. You can increase the value of this parameter to improve the read and write performance of the cluster.
                /// </summary>
                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                /// <summary>
                /// The tags that are added to the cluster.
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
                        /// The tag key.
                        /// 
                        /// > You can call the [TagResources](~~179253~~) operation to add tags to a cluster.
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
                /// The ID of the cluster that is deployed in the VPC.
                /// </summary>
                [NameInMap("VPCCloudInstanceId")]
                [Validation(Required=false)]
                public string VPCCloudInstanceId { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID of the cluster.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID of the cluster.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The zone ID of the cluster.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
