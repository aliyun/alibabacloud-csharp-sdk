// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesRequest : TeaModel {
        /// <summary>
        /// The language of the values of the returned **RegionName** and **ZoneName** parameters. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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
        /// The database engine version of the instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The secondary zone ID that is excluded from the query results. You can configure the ExcludeZoneId and ExcludeSecondaryZoneId parameters to specify the IDs of multiple zones that are excluded from the query results.
        /// </summary>
        [NameInMap("ExcludeSecondaryZoneId")]
        [Validation(Required=false)]
        public string ExcludeSecondaryZoneId { get; set; }

        /// <summary>
        /// The zone ID that is excluded from the query results.
        /// </summary>
        [NameInMap("ExcludeZoneId")]
        [Validation(Required=false)]
        public string ExcludeZoneId { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PrePaid** (default): subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The edition of the instance. High-Available Edition and Preview Edition (dbfs) are supported.
        /// </summary>
        [NameInMap("MongoType")]
        [Validation(Required=false)]
        public string MongoType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query the latest available regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of nodes. This parameter is available only for replica set instances.
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// The ID of the resource group. For more information, see [View basic information of a resource group](~~151181~~).
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
        /// The storage type of the instance. 
        /// - **cloud**: The system displays only zones in which cloud disk-based instances can be deployed. 
        /// - **local**: The system displays only zones in which local disk-based instances can be deployed. 
        /// - **default** or null: The system displays only zones in which cloud disk-based and local disk-based instances can be deployed.
        /// </summary>
        [NameInMap("StorageSupport")]
        [Validation(Required=false)]
        public string StorageSupport { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_essd1**: PL1 enhanced SSD (ESSD)
        /// *   **cloud_essd2**: PL2 ESSD
        /// *   **cloud_essd3**: PL3 ESSD
        /// *   **local_ssd**: Local SSD
        /// 
        /// > *   Instances that run MongoDB 4.4 or later support only cloud disks. **cloud_essd1** is selected if you leave this parameter empty.
        /// > *   Instances that run MongoDB 4.2 and earlier support only local disks. **local_ssd** is selected if you leave this parameter empty.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeRegions](~~61933~~) operation to query available zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
