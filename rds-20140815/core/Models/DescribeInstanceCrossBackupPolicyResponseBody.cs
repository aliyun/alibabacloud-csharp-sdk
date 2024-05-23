// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceCrossBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The status of the cross-region backup feature on the instance. Valid values:
        /// 
        /// *   **Disable**
        /// *   **Enable**
        /// </summary>
        [NameInMap("BackupEnabled")]
        [Validation(Required=false)]
        public string BackupEnabled { get; set; }

        /// <summary>
        /// The point in time at which the cross-region backup feature is enabled. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("BackupEnabledTime")]
        [Validation(Required=false)]
        public string BackupEnabledTime { get; set; }

        /// <summary>
        /// The ID of the destination region where the cross-region backup files of the instance are stored.
        /// </summary>
        [NameInMap("CrossBackupRegion")]
        [Validation(Required=false)]
        public string CrossBackupRegion { get; set; }

        /// <summary>
        /// The policy that is used to save the cross-region backup files of the instance. Default value: **1**. The value 1 indicates that all cross-region backup files are saved.
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// The name of the instance. It must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-), and must start with a letter.
        /// 
        /// >  The value cannot start with http:// or https://.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The status of the instance. For more information, see [Instance state table](https://help.aliyun.com/document_detail/26315.html).
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// The database engine of the instance.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The lock status of the instance. Valid values:
        /// 
        /// *   **Unlock**: The instance is not locked.
        /// *   **ManualLock**: The instance is manually locked.
        /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
        /// *   **LockByRestoration**: The instance is automatically locked before a rollback.
        /// *   **LockByDiskQuota**: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// The status of the cross-region log backup feature on the instance. Valid values:
        /// 
        /// *   **Disable**
        /// *   **Enable**
        /// </summary>
        [NameInMap("LogBackupEnabled")]
        [Validation(Required=false)]
        public string LogBackupEnabled { get; set; }

        /// <summary>
        /// The time when cross-region log backup was enabled on the instance. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("LogBackupEnabledTime")]
        [Validation(Required=false)]
        public string LogBackupEnabledTime { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The policy that is used to retain the cross-region backup files of the instance. Default value: **1**. The value 1 indicates that the cross-region backup files of the instance are retained based on the specified retention period.
        /// </summary>
        [NameInMap("RetentType")]
        [Validation(Required=false)]
        public int? RetentType { get; set; }

        /// <summary>
        /// The number of days for which the cross-region backup files of the instance are retained. Valid values: **7 to 1825**.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
