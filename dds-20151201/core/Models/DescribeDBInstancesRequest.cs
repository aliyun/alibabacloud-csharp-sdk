// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesRequest : TeaModel {
        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The endpoint of the node. You can call the [DescribeDBInstanceAttribute](~~62010~~) operation to query the endpoint of the node.
        /// </summary>
        [NameInMap("ConnectionDomain")]
        [Validation(Required=false)]
        public string ConnectionDomain { get; set; }

        /// <summary>
        /// The instance type. For more information about valid values, see [Instance types](~~57141~~).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The name of the instance. The name must meet the following requirements:
        /// 
        /// *   The name must start with a letter.
        /// *   It can contain digits, letters, underscores (\_), and hyphens (-).
        /// *   It must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The state of the instance. For more information about valid values, see [Instance states](~~63870~~).
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// The architecture of the instance. Valid values:
        /// 
        /// *   **sharding**: sharded cluster instance
        /// *   **replicate**: replica set or standalone instance
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// The type of the node in the instance. This parameter is used to filter standard or test instance.
        /// 
        /// 1.  Valid value for a standalone or DBFS instance.
        /// 2.  Valid value for a standard instance that comes in the replica set or sharded cluster architecture: standard
        /// 3.  Valid value when all instances are displayed: default
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **MongoDB**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// 
        /// *   **6.0**
        /// *   **5.0**
        /// *   **4.4**
        /// *   **4.2**
        /// *   **4.0**
        /// *   **3.4**
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The time when the instance expires.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Specifies whether the instance has expired. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **Classic**
        /// *   **VPC**
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value of this parameter must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of nodes in the replica set instance. Valid values:
        /// 
        /// *   **3**
        /// *   **5**
        /// *   **7**
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags of the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesRequestTag> Tag { get; set; }
        public class DescribeDBInstancesRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the instance. Valid values of N: **1** to **20**.
            /// 
            /// *   The key cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// *   It can be up to 64 characters in length.
            /// *   It cannot be an empty string.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the instance. Valid values of N: **1** to **20**.
            /// 
            /// *   The value cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// *   The value can be up to 128 characters in length.
            /// *   It can be an empty string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The vSwitch ID of the instance.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The VPC ID of the instance.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
