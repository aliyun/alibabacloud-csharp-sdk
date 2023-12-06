// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateDBInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The dedicated cluster ID. You can call the DescribeDedicatedHostGroups operation to query the dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The time when you want the system to start the migration. Valid values:
        /// 
        /// *   **Immediately**: The system immediately starts the migration. This is the default value.
        /// *   **MaintainTime**: The system starts the migration during the specified maintenance window.
        /// *   **Specified**: The system starts the migration at the specified point in time.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time when you want the system to start the migration. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > This parameter must be specified when you set **EffectiveTime** to **Specified**.
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// The ID of the host to which you want to migrate the primary instance. You can call the DescribeDedicatedHosts operation to query the host ID.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// The ID of the host to which you want to migrate the secondary instance. You can call the DescribeDedicatedHosts operation to query the host ID.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// The zone ID of the secondary instance.
        /// </summary>
        [NameInMap("ZoneIdForFollower")]
        [Validation(Required=false)]
        public string ZoneIdForFollower { get; set; }

        /// <summary>
        /// The zone ID of the logger instance.
        /// </summary>
        [NameInMap("ZoneIdForLog")]
        [Validation(Required=false)]
        public string ZoneIdForLog { get; set; }

    }

}
