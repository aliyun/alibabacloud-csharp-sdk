// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// The queried AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster information.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAttributeResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClusterAttributeResponseBodyItemsDBCluster : TeaModel {
                /// <summary>
                /// The billing method of the cluster. Valid values:
                /// 
                /// *   **ads**: pay-as-you-go.
                /// *   **ads_pre**: subscription.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The specifications of reserved computing resources. Each ACU is equivalent to 1 core and 4 GB memory. Computing resources are used to compute data. The increase in the computing resources can accelerate queries. You can scale computing resources based on your business requirements.
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// The total amount of computing resources in the cluster. Each ACU is equivalent to 1 core and 4 GB memory.
                /// </summary>
                [NameInMap("ComputeResourceTotal")]
                [Validation(Required=false)]
                public string ComputeResourceTotal { get; set; }

                /// <summary>
                /// The public endpoint that is used to connect to the cluster.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The time when the cluster was created. The time follows the ISO 8601 standard in the `yyyy-MM-ddThh:mm:ssZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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
                /// *   **Preparing**
                /// *   **Creating**
                /// *   **Running**
                /// *   **Deleting**
                /// *   **Restoring**
                /// *   **ClassChanging**
                /// *   **NetAddressCreating**
                /// *   **NetAddressDeleting**
                /// *   **NetAddressModifying**
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// The cluster type. By default, **Common** is returned, which indicates a common cluster.
                /// </summary>
                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                /// <summary>
                /// The engine version of the AnalyticDB for MySQL Data Lakehouse Edition cluster. **5.0** is returned.
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
                /// The minor version of the cluster.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time of the cluster.
                /// 
                /// *   If the billing method of the cluster is subscription, the actual expiration time is returned.
                /// *   If the billing method of the cluster is pay-as-you-go, null is returned.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// Indicates whether the subscription cluster has expired. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// 
                /// > - If the cluster has expired, the system locks or releases the cluster within a period of time. We recommend that you renew the expired cluster. For more information, see [Renewal policy](https://help.aliyun.com/document_detail/135248.html).
                /// > - This parameter is not returned for pay-as-you-go clusters.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// The lock mode of the cluster. Valid values:
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
                /// >  This parameter is returned only when the cluster was locked. **instance_expire** is returned.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The maintenance window of the cluster. The time is displayed in the `HH:mmZ-HH:mmZ` format in UTC.
                /// 
                /// >  For more information about maintenance windows, see [Configure a maintenance window](https://help.aliyun.com/document_detail/122569.html).
                /// </summary>
                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// The mode of the cluster. By default, **flexible** is returned, which indicates that the cluster is in elastic mode.
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
                /// The port number that is used to connect to the cluster.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("ProductForm")]
                [Validation(Required=false)]
                public string ProductForm { get; set; }

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

                [NameInMap("ReservedNodeCount")]
                [Validation(Required=false)]
                public int? ReservedNodeCount { get; set; }

                [NameInMap("ReservedNodeSize")]
                [Validation(Required=false)]
                public string ReservedNodeSize { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The specifications of reserved storage resources. Each AnalyticDB compute unit (ACU) is equivalent to 1 core and 4 GB memory. Storage resources are used to read and write data. The increase in the storage resources can improve the read and write performance of the cluster.
                /// </summary>
                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                /// <summary>
                /// The total amount of storage resources in the cluster. Each ACU is equivalent to 1 core and 4 GB memory.
                /// </summary>
                [NameInMap("StorageResourceTotal")]
                [Validation(Required=false)]
                public string StorageResourceTotal { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("SupportedFeatures")]
                [Validation(Required=false)]
                public Dictionary<string, string> SupportedFeatures { get; set; }

                /// <summary>
                /// The tags that are added to the cluster.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClusterAttributeResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// 
                        /// >  You can call the [TagResources](https://help.aliyun.com/document_detail/179253.html) operation to add tags to a cluster.
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
                /// Indicates whether Elastic Network Interface (ENI) is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("UserENIStatus")]
                [Validation(Required=false)]
                public bool? UserENIStatus { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
