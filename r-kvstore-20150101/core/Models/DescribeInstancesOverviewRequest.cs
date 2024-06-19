// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesOverviewRequest : TeaModel {
        /// <summary>
        /// The architecture of the instance. Valid values:
        /// 
        /// *   **cluster**: cluster architecture
        /// *   **standard**: standard architecture
        /// *   **rwsplit**: read/write splitting architecture
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

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
        /// The edition of the instance. Valid values:
        /// 
        /// *   **Community**: Community Edition
        /// *   **Enterprise**: Enhanced Edition (Tair)
        /// </summary>
        [NameInMap("EditionType")]
        [Validation(Required=false)]
        public string EditionType { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The instance type of the instance. For more information, see [Instance types](https://help.aliyun.com/document_detail/107984.html).
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The IDs of instances.
        /// 
        /// > By default, all instances that belong to this account are queried. If you specify multiple instance IDs, separate the instance IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The state of the instance. Valid values:
        /// 
        /// *   **Normal**: The instance is normal.
        /// *   **Creating**: The instance is being created.
        /// *   **Changing**: The configurations of the instance are being changed.
        /// *   **Inactive**: The instance is disabled.
        /// *   **Flushing**: The instance is being released.
        /// *   **Released**: The instance is released.
        /// *   **Transforming**: The billing method of the instance is being changed.
        /// *   **Unavailable**: The instance is unavailable.
        /// *   **Error**: The instance failed to be created.
        /// *   **Migrating**: The instance is being migrated.
        /// *   **BackupRecovering**: The instance is being restored from a backup.
        /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
        /// *   **NetworkModifying**: The network type of the instance is being changed.
        /// *   **SSLModifying**: The SSL certificate of the instance is being changed.
        /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
        /// 
        /// > For more information about instance states, see [Instance states and impacts](https://help.aliyun.com/document_detail/200740.html).
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The category of the instance. Valid values:
        /// 
        /// *   **Tair**
        /// *   **Redis**
        /// *   **Memcache**
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **CLASSIC**: classic network
        /// *   **VPC**: Virtual Private Cloud (VPC)
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
        /// The private IP address of the instance.
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// The ID of the region in which the instances you want to query reside. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instances you want to query belong.
        /// 
        /// > You can query resource group IDs by using the ApsaraDB for Redis console or by calling the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation. For more information, see [View basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
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
        /// The keyword used for fuzzy search. The keyword can be based on an instance ID or an instance description.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
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
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
