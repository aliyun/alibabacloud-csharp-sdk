// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class MigrateAvailableZoneRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > If the instance is deployed in a VPC, you must specify the **Vswitch** parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The time when the instance is migrated to the destination zone. Valid values:
        /// 
        /// *   **Immediately**: The instance is immediately migrated to the destination zone.
        /// *   **MaintainTime**: The instance is migrated to the destination zone during the maintenance window of the instance.
        /// 
        /// Default value: **Immediately**.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the vSwitch in the destination zone.
        /// 
        /// > If the instance is deployed in a VPC, you must specify this parameter.
        /// </summary>
        [NameInMap("Vswitch")]
        [Validation(Required=false)]
        public string Vswitch { get; set; }

        /// <summary>
        /// The ID of the destination zone.
        /// 
        /// > 
        /// 
        /// *   The source zone and the destination zone belong to the same region.
        /// 
        /// *   You can call the [DescribeRegions](~~61933~~) operation to query the zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
