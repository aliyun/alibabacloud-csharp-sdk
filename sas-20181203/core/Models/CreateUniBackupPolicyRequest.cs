// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the database account.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// Specifies whether the database is manually added. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("DatabaseAddByUser")]
        [Validation(Required=false)]
        public string DatabaseAddByUser { get; set; }

        /// <summary>
        /// The type of the database. Valid values:
        /// 
        /// *   **MYSQL**
        /// *   **ORACLE**
        /// *   **MSSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// The policy for full data backup. The value of this parameter is a JSON string. The JSON string contains the following fields:
        /// 
        /// *   **start**: the start time of a backup task.
        /// *   **interval**: the interval of backup tasks.
        /// *   **type**: the unit of the interval.
        /// *   **days**: the days of a week on which a backup task is performed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> FullPlan { get; set; }

        /// <summary>
        /// The policy for incremental data backup. The value of this parameter is a JSON string. The JSON string contains the following fields:
        /// 
        /// *   **start**: the start time of a backup task.
        /// *   **interval**: the interval of backup tasks.
        /// *   **type**: the unit of the interval.
        /// *   **days**: the days of a week on which a backup task is performed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> IncPlan { get; set; }

        /// <summary>
        /// The ID of the Elastic Compute Service (ECS) instance.
        /// 
        /// >  You can call the [DescribeUniBackupDatabase](~~DescribeUniBackupDatabase~~) operation to query the IDs of ECS instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the anti-ransomware policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The retention period of backup data.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// The maximum network bandwidth that is allowed during data backup. Unit: bytes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

        /// <summary>
        /// The region in which the server resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

        /// <summary>
        /// The UUID of the server whose data is backed up based on the anti-ransomware policy.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](https://help.aliyun.com/document_detail/141932.html) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
