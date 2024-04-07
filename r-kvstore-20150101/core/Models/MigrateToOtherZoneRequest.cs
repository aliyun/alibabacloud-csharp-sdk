// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies the time when the database is switched after data is migrated. Valid values:
        /// 
        /// *   **Immediately**: immediately switched after the data is migrated.
        /// *   **MaintainTime**: switched within the maintenance window.
        /// *   **0**: immediately switched after the data is migrated.
        /// *   **1**: switched within the maintenance window.
        /// 
        /// >  Default value: **Immediately**.
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
        /// The ID of the destination secondary zone. You can call the [DescribeZones](~~DescribeZones~~) operation to query zone IDs.
        /// 
        /// >  You can specify this parameter to deploy the master node and replica node in different zones to implement zone-disaster recovery. This helps withstand data center-level breakdowns.
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// > *   The vSwitch must be deployed in the zone that is specified by the ZoneId parameter.
        /// > *   If the network type of the instance is VPC, this parameter is required.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the destination primary zone. You can call the [DescribeZones](~~94527~~) operation to query zone IDs.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
