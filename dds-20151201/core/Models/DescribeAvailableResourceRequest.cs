// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// The instance type of the instance.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The architecture of the instance. Valid values:
        /// 
        /// *   **normal**: replica set instance
        /// *   **sharding**: sharded cluster instance
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The major engine version of the instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid** (default): subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~61933~~) operation to query the latest available regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of nodes, only applicable to replica sets.
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
        /// The storage type of the instance. Valid values:
        /// 
        /// *   local_ssd: local SSD
        /// *   cloud_essd1: PL1 enhanced SSD (ESSD)
        /// *   cloud_essd2: PL2 ESSD
        /// *   cloud_essd3: PL3 ESSD
        /// *   cloud_auto: ESSD AutoPL disk
        /// 
        /// This parameter is empty by default, which indicates all types of storage resources are queried.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The ID of the zone. You can call the [DescribeRegions](~~61933~~) operation to query the available zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
