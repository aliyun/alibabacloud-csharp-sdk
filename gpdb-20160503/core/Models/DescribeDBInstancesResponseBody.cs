// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// 
                /// You can call the [DescribeDBInstanceAttribute](~~86910~~) operation to query the access mode of an instance.
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// The time when the instance was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The edition of the instance. Valid values:
                /// 
                /// *   **Basic**: Basic Edition
                /// *   **HighAvailability**: High-availability Edition
                /// *   **Finance**: Enterprise Edition
                /// </summary>
                [NameInMap("DBInstanceCategory")]
                [Validation(Required=false)]
                public string DBInstanceCategory { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The resource type of the instance. Valid values:
                /// 
                /// *   **Serverless**: Serverless mode
                /// *   **StorageElastic**: elastic storage mode
                /// *   **Classic**: reserved storage mode
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// The type of the network interface card (NIC) that is used by the instance. Valid values:
                /// 
                /// *   **0**: Internet
                /// *   **1**: internal network
                /// *   **2**: VPC
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The state of the instance. For more information, see [Instance statuses](~~86944~~).
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The database engine that the instance runs.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time of the instance. The time is displayed in UTC.
                /// 
                /// >  For pay-as-you-go instances, `2999-09-08T16:00:00Z` is returned.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The resource type of the instance. Valid values:
                /// 
                /// *   **cluster**: elastic storage mode or Serverless mode
                /// *   **replicaSet**: reserved storage mode
                /// </summary>
                [NameInMap("InstanceDeployType")]
                [Validation(Required=false)]
                public string InstanceDeployType { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Classic**
                /// *   **VPC**
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The lock mode of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked due to instance restoration.
                /// *   **LockByDiskQuota**: The instance is automatically locked due to exhausted storage.
                /// *   **LockReadInstanceByDiskQuota**: The instance is a read-only instance and is automatically locked due to exhausted storage.
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
                /// The number of coordinator nodes.
                /// </summary>
                [NameInMap("MasterNodeNum")]
                [Validation(Required=false)]
                public int? MasterNodeNum { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go
                /// *   **Prepaid**: subscription
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The number of compute nodes.
                /// </summary>
                [NameInMap("SegNodeNum")]
                [Validation(Required=false)]
                public string SegNodeNum { get; set; }

                /// <summary>
                /// The type of the Serverless mode. Valid values:
                /// 
                /// *   **Manual**: manual scheduling
                /// *   **Auto**: automatic scheduling
                /// 
                /// >  This parameter is returned only for instances in Serverless mode.
                /// </summary>
                [NameInMap("ServerlessMode")]
                [Validation(Required=false)]
                public string ServerlessMode { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// *   **cloud_essd**: enhanced SSD (ESSD)
                /// *   **cloud_efficiency**: ultra disk
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The tags of the instance. Each tag is a key-value pair.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyItemsDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
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
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
