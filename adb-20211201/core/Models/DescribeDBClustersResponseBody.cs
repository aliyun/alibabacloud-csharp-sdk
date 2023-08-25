// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// Details of the clusters.
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
                /// The billing method of the cluster. Valid values:
                /// 
                /// *   **ads**: pay-as-you-go
                /// *   **ads_pre**: subscription
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The specifications of the reserved computing resources. Each ACU is equivalent to 1 core and 4 GB memory. Computing resources serve compute operations. The amount of computing resources is proportional to the query speed of the cluster. You can scale computing resources based on your needs.
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// The public endpoint of the cluster.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The time when the cluster was created. The time follows the ISO 8601 standard in the *yyyy-mm-ddThh:mm:ssZ* format. The time is displayed in UTC.
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
                /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
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
                /// The state of the cluster. Valid values:
                /// 
                /// *   **Preparing**: The cluster is being prepared.
                /// *   **Creating**: The cluster is being created.
                /// *   **Running**: The cluster is running.
                /// *   **Deleting**: The cluster is being deleted.
                /// *   **Restoring**: The cluster is being restored from a backup.
                /// *   **ClassChanging**: The cluster specifications are being changed.
                /// *   **NetAddressCreating**: A network connection is being created.
                /// *   **NetAddressDeleting**: A network connection is being deleted.
                /// *   **NetAddressModifying**: A network connection is being modified.
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// The type of the cluster. By default, **Common** is returned, which indicates a common cluster.
                /// </summary>
                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                /// <summary>
                /// The version of the AnalyticDB for MySQL Data Lakehouse Edition cluster. Only the version **5.0** is supported.
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// The engine of the cluster. **AnalyticDB** is returned.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The time when the cluster expired. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
                /// 
                /// > *   The expiration time is returned for a subscription cluster.
                /// > *   An empty string is returned for a pay-as-you-go cluster.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the subscription cluster has expired. Valid values:
                /// 
                /// *   **true**: The cluster has expired.
                /// *   **false**: The cluster has not expired.
                /// 
                /// > *   If the cluster has expired, the system locks or releases the cluster within a specific time period. We recommend that you renew expired clusters. For more information, see [Renewal policy](~~135246~~).
                /// > *  This parameter is not returned for pay-as-you-go clusters.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// The lock state of the instance. Valid values:
                /// 
                /// *   **Unlock**: The cluster is not locked.
                /// *   **ManualLock**: The cluster is manually locked.
                /// *   **LockByExpiration**: The cluster is automatically locked due to cluster expiration.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The reason why the cluster is locked.
                /// 
                /// >  This parameter is returned only when the cluster is locked. The value is **instance_expire**.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The mode of the cluster. By default, **flexible** is returned, which indicates that the cluster is in elastic mode.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The billing method of the cluster. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go
                /// *   **Prepaid**: subscription
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The port number that is used to connect to the cluster.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The region ID of the cluster.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The remaining reserved computing resources that are available in the cluster. Each ACU is equivalent to 1 core and 4 GB memory.
                /// </summary>
                [NameInMap("ReservedACU")]
                [Validation(Required=false)]
                public string ReservedACU { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The specifications of the reserved storage resources. Each AnalyticDB compute unit (ACU) is equivalent to 1 core and 4 GB memory. Storage resources serve read and write requests. The amount of storage resources is proportional to the read and write performance of the cluster.
                /// </summary>
                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
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
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
