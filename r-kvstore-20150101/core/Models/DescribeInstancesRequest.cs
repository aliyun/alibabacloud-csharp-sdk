// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesRequest : TeaModel {
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
        /// The billing method. Valid values:
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
        /// *   **Community**: ApsaraDB for Redis Community Edition
        /// *   **Enterprise**: ApsaraDB for Redis Enhanced Edition (Tair)
        /// </summary>
        [NameInMap("EditionType")]
        [Validation(Required=false)]
        public string EditionType { get; set; }

        /// <summary>
        /// The engine version of the instance. Valid values: **2.8**, **4.0**, and **5.0**.
        /// 
        /// Valid values:
        /// 
        /// *   1.0
        /// *   2.8
        /// *   4.0
        /// *   5.0
        /// *   6.0
        /// *   7.0
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Specifies whether the instance has expired. Valid values:
        /// 
        /// *   **true**: The instance has expired.
        /// *   **false**: The instance has not expired.
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// Specifies whether to return the child instances of distributed instances. Valid values:
        /// 
        /// *   **true**: Only child instances are returned.
        /// *   **false**: Child instances are not returned.
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// The instance type of the instance. For more information, see [Instance types](~~107984~~).
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The IDs of the instances that you want to query.
        /// 
        /// >  If you want to specify multiple instance IDs, separate the instance IDs with commas (,). You can specify a maximum of 30 instance IDs in a single request.
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
        /// *   **Unavailable**: The instance is suspended.
        /// *   **Error**: The instance failed to be created.
        /// *   **Migrating**: The instance is being migrated.
        /// *   **BackupRecovering**: The instance is being restored from a backup.
        /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
        /// *   **NetworkModifying**: The network type of the instance is being changed.
        /// *   **SSLModifying**: The SSL certificate of the instance is being changed.
        /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
        /// 
        /// > For more information about instance states, see [Instance states and impacts](~~200740~~).
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   **Tair**
        /// *   **Redis**
        /// *   **Memcache**
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   **CLASSIC**
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
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The private IP address of the instance.
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// > When you call this operation and specify the **Tag** parameter, you must also specify this parameter.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// 
        /// > You can query resource group IDs by using the ApsaraDB for Redis console or by calling the [ListResourceGroups](~~158855~~) operation. For more information, see [View basic information of a resource group](~~151181~~).
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
        /// The keyword used for fuzzy search. The keyword can be based on an instance name or an instance ID.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tags of the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// The tag key. A tag is a key-value pair.
            /// 
            /// >  A maximum of five key-value pairs can be specified at a time.
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
