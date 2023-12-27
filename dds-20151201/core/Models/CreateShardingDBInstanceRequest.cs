// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateShardingDBInstanceRequest : TeaModel {
        /// <summary>
        /// The password of the root account. The password must meet the following requirements:
        /// 
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   The special characters include ! # $ % ^ & \* ( ) \_ + - =
        /// *   The password of the account must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// > This parameter is available and optional if you set the value of **ChargeType** to **PrePaid**.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PostPaid** (default): pay-as-you-go
        /// *   **PrePaid**: subscription
        /// 
        /// >  If you set this parameter to **PrePaid**, you must also specify the **Period** parameter.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ConfigServer nodes of the instance.
        /// </summary>
        [NameInMap("ConfigServer")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestConfigServer> ConfigServer { get; set; }
        public class CreateShardingDBInstanceRequestConfigServer : TeaModel {
            /// <summary>
            /// The instance type of the ConfigServer node. Valid values:
            /// 
            /// *   **mdb.shard.2x.xlarge.d**: 4 cores, 8 GB (dedicated). Only instances that run MongoDB 4.4 and later support this instance type.
            /// *   **dds.cs.mid** :1 core, 2 GB (general-purpose). Only instances that run MongoDB 4.2 and earlier support this instance type.
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            /// <summary>
            /// The storage space of the ConfigServer node. Unit: GB.
            /// 
            /// > The values that can be specified for this parameter vary based on the instance types. For more information, see [Sharded cluster instance types](~~311414~~).
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

        /// <summary>
        /// The name of the instance. The name of the instance must meet the following requirements:
        /// 
        /// *   The name must start with a letter.
        /// *   It can contain digits, letters, underscores (\_), and hyphens (-).
        /// *   It must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// Specifies whether to enable disk encryption.
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the custom key.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **MongoDB**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// *   **6.0**
        /// *   **5.0**
        /// *   **4.4**
        /// *   **4.2**
        /// *   **4.0**
        /// *   **3.4**
        /// 
        /// > *   For more information about the limits on database versions and storage engines, see [MongoDB versions and storage engines](~~61906~~).
        /// > *   If you call this operation to clone an instance, set the value of this parameter to the engine version of the source instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The global IP address whitelist template of the instance. Separate multiple templates with commas (,). The template name must be globally unique.
        /// </summary>
        [NameInMap("GlobalSecurityGroupIds")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupIds { get; set; }

        /// <summary>
        /// The ID of secondary zone 2 for multi-zone deployment. Valid values:
        /// 
        /// *   **cn-hangzhou-g**: Hangzhou Zone G
        /// *   **cn-hangzhou-h**: Hangzhou Zone H
        /// *   **cn-hangzhou-i**: Hangzhou Zone I
        /// *   **cn-hongkong-b**: Hong Kong Zone B
        /// *   **cn-hongkong-c**: Hong Kong Zone C
        /// *   **cn-hongkong-d**: Hong Kong Zone D
        /// *   **cn-wulanchabu-a**: Ulanqab Zone A
        /// *   **cn-wulanchabu-b**: Ulanqab Zone B
        /// *   **cn-wulanchabu-c**: Ulanqab Zone C
        /// *   **ap-southeast-1a**: Singapore Zone A
        /// *   **ap-southeast-1b**: Singapore Zone B
        /// *   **ap-southeast-1c**: Singapore Zone C
        /// *   **ap-southeast-5a**: Jakarta Zone A
        /// *   **ap-southeast-5b**: Jakarta Zone B
        /// *   **ap-southeast-5c**: Jakarta Zone C
        /// *   **eu-central-1a**: Frankfurt Zone A
        /// *   **eu-central-1b**: Frankfurt Zone B
        /// *   **eu-central-1c**: Frankfurt Zone C
        /// 
        /// > *   This parameter is available and required if you set the value of **EngineVersion** to **4.4** or **5.0**.
        /// > *   The value of this parameter cannot be the same as the value of **ZoneId** or **SecondaryZoneId**.
        /// > *   For more information about the multi-zone deployment policy of a sharded cluster instance, see [Create a multi-zone sharded cluster instance](~~117865~~).
        /// </summary>
        [NameInMap("HiddenZoneId")]
        [Validation(Required=false)]
        public string HiddenZoneId { get; set; }

        /// <summary>
        /// The mongos nodes of the instance.
        /// </summary>
        [NameInMap("Mongos")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestMongos> Mongos { get; set; }
        public class CreateShardingDBInstanceRequestMongos : TeaModel {
            /// <summary>
            /// The instance type of the mongos node. For more information, see [Sharded cluster instance types](~~311414~~).
            /// 
            /// > *   **N** specifies the serial number of the mongos node for which the instance type is specified. For example, **Mongos.2.Class** specifies the instance type of the second mongos node.
            /// > *   Valid values for **N**: **2** to **32**.
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

        }

        /// <summary>
        /// The network type of the instance. Set the value to VPC.
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
        /// The subscription period of the instance. Unit: months.
        /// 
        /// Valid values: **1** to **9**, **12**, **24**, **36**, and **60**.
        /// 
        /// > When you set the **ChargeType** parameter to **PrePaid**, this parameter is valid and required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The access protocol type of the instance. Valid values:
        /// 
        /// *   **mongodb**: the MongoDB protocol
        /// *   **dynamodb**: the DynamoDB protocol
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The provisioned IOPS. Valid values: 0 to 50000.
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The information of the shard node.
        /// </summary>
        [NameInMap("ReplicaSet")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestReplicaSet> ReplicaSet { get; set; }
        public class CreateShardingDBInstanceRequestReplicaSet : TeaModel {
            /// <summary>
            /// The instance type of the shard node. For more information, see [Sharded cluster instance types](~~311414~~).
            /// 
            /// > *   **N** specifies the serial number of the shard node for which the instance type is specified. For example, **ReplicaSet.2.Class** specifies the instance type of the second shard node.
            /// > *   Valid values for **N**: **2** to **32**.
            /// </summary>
            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            /// <summary>
            /// The number of read-only nodes in shard node N.
            /// 
            /// Valid values: **0**, 1, 2, 3, 4, and **5**. Default value: **0**.
            /// 
            /// >  **N** specifies the serial number of the shard node for which you want to set the number of read-only nodes. For example, **ReplicaSet.2.ReadonlyReplicas** specifies the number of read-only nodes in the second shard node.
            /// </summary>
            [NameInMap("ReadonlyReplicas")]
            [Validation(Required=false)]
            public int? ReadonlyReplicas { get; set; }

            /// <summary>
            /// The storage space of the shard node. Unit: GB.
            /// 
            /// > *   The values that can be specified for this parameter vary based on the instance types. For more information, see [Sharded cluster instance types](~~311414~~).
            /// > *   **N** specifies the serial number of the shard node for which the storage space is specified. For example, **ReplicaSet.2.Storage** specifies the storage space of the second shard node.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

        /// <summary>
        /// The resource group ID. For more information, see [View the basic information of a resource group](~~151181~~).
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
        /// The point in time to restore the instance, which must be within seven days. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in Coordinated Universal Time (UTC).
        /// 
        /// > This parameter is required only if you call this operation to clone an instance. If you specify this parameter, you must also specify **SrcDBInstanceId**.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The ID of secondary zone 1 for multi-zone deployment. Valid values:
        /// 
        /// *   **cn-hangzhou-g**: Hangzhou Zone G
        /// *   **cn-hangzhou-h**: Hangzhou Zone H
        /// *   **cn-hangzhou-i**: Hangzhou Zone I
        /// *   **cn-hongkong-b**: Hong Kong Zone B
        /// *   **cn-hongkong-c**: Hong Kong Zone C
        /// *   **cn-hongkong-d**: Hong Kong Zone D
        /// *   **cn-wulanchabu-a**: Ulanqab Zone A
        /// *   **cn-wulanchabu-b**: Ulanqab Zone B
        /// *   **cn-wulanchabu-c**: Ulanqab Zone C
        /// *   **ap-southeast-1a**: Singapore Zone A
        /// *   **ap-southeast-1b**: Singapore Zone B
        /// *   **ap-southeast-1c**: Singapore Zone C
        /// *   **ap-southeast-5a**: Jakarta Zone A
        /// *   **ap-southeast-5b**: Jakarta Zone B
        /// *   **ap-southeast-5c**: Jakarta Zone C
        /// *   **eu-central-1a**: Frankfurt Zone A
        /// *   **eu-central-1b**: Frankfurt Zone B
        /// *   **eu-central-1c**: Frankfurt Zone C
        /// 
        /// > *   This parameter is available and required if you set the value of **EngineVersion** to **4.4** or **5.0**.
        /// > *   The value of this parameter cannot be the same as the value of **ZoneId** or **HiddenZoneId**.
        /// > *   For more information about the multi-zone deployment policy of a sharded cluster instance, see [Create a multi-zone sharded cluster instance](~~117865~~).
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// The IP addresses in an IP address whitelist of the instance. Multiple IP addresses are separated by commas (,), and each IP address in the IP address whitelist must be unique. The following types of values are supported:
        /// 
        /// *   0.0.0.0/0
        /// *   IP addresses, such as 10.23.12.24.
        /// *   CIDR blocks, such as 10.23.12.0/24. In this case, 24 indicates that the prefix of each IP address is 24-bit long. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// > *   A maximum of 1,000 IP addresses and CIDR blocks can be configured for each instance.
        /// > *   If you enter 0.0.0.0/0, all IP addresses can access the instance. This may introduce security risks to the instance. Proceed with caution.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// The source instance ID.
        /// 
        /// > This parameter is required only if you call this operation to clone an instance. If you specify this parameter, you must also specify **RestoreTime**.
        /// </summary>
        [NameInMap("SrcDBInstanceId")]
        [Validation(Required=false)]
        public string SrcDBInstanceId { get; set; }

        /// <summary>
        /// The storage engine of the instance. Set the value to **WiredTiger**.
        /// 
        /// > *   If you call this operation to clone an instance, set the value of this parameter to the storage engine of the source instance.
        /// > *   For more information about the limits on database versions and storage engines, see [MongoDB versions and storage engines](~~61906~~).
        /// </summary>
        [NameInMap("StorageEngine")]
        [Validation(Required=false)]
        public string StorageEngine { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_essd1**: ESSD PL1
        /// *   **cloud_essd2**: ESSD PL2
        /// *   **cloud_essd3**: ESSD PL3
        /// *   **local_ssd**: local SSD
        /// 
        /// > *   Instances of MongoDB 4.4 and later support only cloud disks. **cloud_essd1** is selected if you leave this parameter empty.
        /// > *   Instances of MongoDB 4.2 and earlier support only local disks. **local_ssd** is selected if you leave this parameter empty.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The custom tags added to the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateShardingDBInstanceRequestTag> Tag { get; set; }
        public class CreateShardingDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// 
            /// > **N** specifies the serial number of the tag. For example, **Tag.1.Key** specifies the key of the first tag and **Tag.2.Key** specifies the key of the second tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// 
            /// > **N** specifies the serial number of the tag. For example, **Tag.1.Value** specifies the value of the first tag and **Tag.2.Value** specifies the value of the second tag.
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
        /// The ID of the VPC.
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
