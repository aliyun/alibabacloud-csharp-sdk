// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyInstanceRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The number of database proxies. If you set this parameter to 0, the database proxy feature is disabled for the instance. Valid values: **1** to **16**.
        /// 
        /// >  The capability of the database proxy feature to process requests increases with the number of database proxies that are enabled. You can monitor the load on the instance and specify an appropriate number of database proxies based on the load monitoring data.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// The database proxy type. Valid values:
        /// 
        /// *   **common**: general-purpose database proxy
        /// *   **exclusive** (default): dedicated database proxy
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// The point in time that you want to specify. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// >  If the **EffectiveTime** parameter is set to **SpecificTime**, you must specify this parameter.
        /// </summary>
        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        /// <summary>
        /// The effective time. Valid values:
        /// 
        /// *   **Immediate**: The effective time is immediate.
        /// *   **MaintainTime**: The effective time is within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.
        /// *   **SpecificTime**: The effective time is a specified point in time.
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
        /// The ID of the vSwitch in the destination zone. You can call the [DescribeVSwitches](https://help.aliyun.com/document_detail/610431.html) operation to query existing vSwitches.
        /// 
        /// >  Only database proxies for ApsaraDB RDS for MySQL instances that use cloud disks can be migrated to different zones.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

    }

}
