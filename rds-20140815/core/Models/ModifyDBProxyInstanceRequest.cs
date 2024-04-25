// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// An internal parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The number of proxy instances that are enabled. If the value of this parameter is 0, the database proxy feature is disabled for the instance. Valid values: **1** to **60**.
        /// 
        /// >  The capability of the database proxy to process requests increases with the number of proxy instances that are enabled. You can monitor the load on the instance and specify an appropriate number of proxy instances based on the load monitoring data.
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// The type of database proxy that is enabled for the instance. Set the value to **DedicatedProxy**.
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// The point in time at which you want to apply the new database proxy settings. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// >  If you set the **EffectiveTime** parameter to **SpecificTime**, you must specify the EffectiveSpecificTime parameter.
        /// </summary>
        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        /// <summary>
        /// The time when you want to apply the new database proxy settings. Valid values:
        /// 
        /// *   **Immediate**: ApsaraDB RDS immediately applies the new settings.
        /// *   **MaintainTime**: ApsaraDB RDS applies the new settings during the maintenance window that you specified. For more information, see [Modify the maintenance window](~~26249~~).
        /// *   **SpecificTime**: ApsaraDB RDS applies the new settings at a specified point in time.
        /// 
        /// Default value: **MaintainTime**.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
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

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

    }

}
