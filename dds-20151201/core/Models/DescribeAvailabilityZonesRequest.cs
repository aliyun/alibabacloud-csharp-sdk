// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesRequest : TeaModel {
        /// <summary>
        /// Specifies the language of the returned values of the **RegionName** and **ZoneName** parameters. Default value: zh. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The database engine type of the instance. Valid values:
        /// 
        /// *   **normal**: replica set instance
        /// *   **sharding**: sharded cluster instance
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("ExcludeSecondaryZoneId")]
        [Validation(Required=false)]
        public string ExcludeSecondaryZoneId { get; set; }

        [NameInMap("ExcludeZoneId")]
        [Validation(Required=false)]
        public string ExcludeZoneId { get; set; }

        /// <summary>
        /// The billing method of the instance. Default value: PrePaid. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The edition of the ApsaraDB for MongoDB instance. The instance can be of a high-availability edition or beta edition.
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The zones to be displayed. The values include the zones in which you can create an instance that uses cloud disks, the zones in which you can create an instance that uses local disks, and the zones in which you can create an instance that uses cloud disks and local disks.
        /// </summary>
        [NameInMap("StorageSupport")]
        [Validation(Required=false)]
        public string StorageSupport { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_essd1**: PL1.enhanced SSD (ESSD)
        /// *   **cloud_essd2**: PL2 ESSD.
        /// *   **cloud_essd3**: PL3 ESSD.
        /// *   **local_ssd**: local SSD.
        /// 
        /// > 
        /// 
        /// *   Instances of MongoDB 4.4 and later only support cloud disks. **cloud_essd1** is selected if you leave this parameter empty.
        /// 
        /// *   Instances of MongoDB 4.2 and earlier support only local disks. **local_ssd** is selected if you leave this parameter empty.
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
