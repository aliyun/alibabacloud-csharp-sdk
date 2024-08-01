// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// The time when the instance is migrated to the destination zone. Valid values:
        /// 
        /// *   **Immediately**: The instance is immediately migrated to the destination zone.
        /// *   **MaintainTime**: The instance is migrated during the maintenance period of the instance.
        /// 
        /// Default value: **Immediately**.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  If the network type of the instance is VPC, you must specify the **Vswitch** parameter .
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// >  This parameter is valid and required only when the network type of the instance is VPC.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the destination zone to which you want to migrate the ApsaraDB for MongoDB instance.
        /// 
        /// > * The destination and source zones must be in one region.
        /// > * You can call [DescribeRegions](https://help.aliyun.com/document_detail/61933.html) to query the zone IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
