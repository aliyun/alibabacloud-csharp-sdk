// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
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
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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
                /// The specifications of reserved computing resources. Each ACU is approximately equal to 1 core and 4 GB memory. Computing resources are used to compute data. The increase in the computing resources can accelerate queries. You can scale computing resources based on your business requirements.
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
                /// The status of the cluster. Valid values:
                /// 
                /// *   **Preparing**
                /// 
                /// <!---->
                /// 
                /// *   **Creating**
                /// *   **Running**
                /// *   **Deleting**
                /// 
                /// <!---->
                /// 
                /// *   **Restoring**
                /// 
                /// <!---->
                /// 
                /// *   **ClassChanging**
                /// *   **NetAddressCreating**
                /// *   **NetAddressDeleting**
                /// *   **NetAddressModifying**
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

                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                /// <summary>
                /// The engine version of the AnalyticDB for MySQL Data Lakehouse Edition cluster. **5.0** is returned.
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                [NameInMap("ElasticIOResource")]
                [Validation(Required=false)]
                public int? ElasticIOResource { get; set; }

                /// <summary>
                /// The engine of the cluster. **AnalyticDB** is returned.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("ExecutorCount")]
                [Validation(Required=false)]
                public string ExecutorCount { get; set; }

                /// <summary>
                /// The time when the cluster expires. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
                /// 
                /// > 
                /// 
                /// *   If the billing method of the cluster is subscription, the actual expiration time is returned.
                /// 
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
                /// > 
                /// 
                /// *   If the cluster has expired, the system locks or releases the cluster within a period of time. We recommend that you renew the expired cluster. For more information, see [Renewal policy](https://help.aliyun.com/document_detail/135246.html).
                /// 
                /// *   This parameter is not returned for pay-as-you-go clusters.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                [NameInMap("InnerPort")]
                [Validation(Required=false)]
                public string InnerPort { get; set; }

                /// <summary>
                /// The lock status of the cluster. Valid values:
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
                public string Port { get; set; }

                [NameInMap("ProductForm")]
                [Validation(Required=false)]
                public string ProductForm { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

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
                /// The remaining reserved computing resources that are available in the cluster. Each ACU is approximately equal to 1 core and 4 GB memory.
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
                /// The specifications of reserved storage resources. Each AnalyticDB compute unit (ACU) is approximately equal to 1 core and 4 GB memory. Storage resources are used to read and write data. The increase in the storage resources can improve the read and write performance of the cluster.
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

                [NameInMap("TaskInfo")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTaskInfo TaskInfo { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfo : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StepList")]
                    [Validation(Required=false)]
                    public DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList StepList { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList : TeaModel {
                        [NameInMap("StepList")]
                        [Validation(Required=false)]
                        public List<DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList> StepList { get; set; }
                        public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList : TeaModel {
                            [NameInMap("EndTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("StepDesc")]
                            [Validation(Required=false)]
                            public string StepDesc { get; set; }

                            [NameInMap("StepName")]
                            [Validation(Required=false)]
                            public string StepName { get; set; }

                            [NameInMap("StepProgress")]
                            [Validation(Required=false)]
                            public string StepProgress { get; set; }

                            [NameInMap("StepStatus")]
                            [Validation(Required=false)]
                            public string StepStatus { get; set; }

                        }

                    }

                }

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
