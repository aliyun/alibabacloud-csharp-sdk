// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBProxyInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the instance ID.
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
        /// The specific point in time when you want to perform the upgrade. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > If you set **UpgradeTime** to **SpecificTime**, you must specify SwitchTime.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The time when you want to upgrade the database proxy version of the instance. Valid values:
        /// 
        /// *   **MaintainTime**: ApsaraDB RDS performs the upgrade during the maintenance window that you specified. This is the default value. For more information, see [Modify the maintenance window](~~26249~~).
        /// *   **Immediate**: ApsaraDB RDS immediately performs the upgrade.
        /// *   **SpecificTime**: ApsaraDB RDS performs the upgrade at a specified point in time.
        /// 
        /// > 
        /// 
        /// *   If the instance runs MySQL, you can set this parameter to **MaintainTime**, **Immediate**, or **SpecificTime**.
        /// 
        /// *   If the instance runs PostgreSQL, you can set this parameter to **MaintainTime** or **Immediate**.
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
