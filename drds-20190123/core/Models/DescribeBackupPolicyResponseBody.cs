// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the backup policy.
        /// </summary>
        [NameInMap("BackupPolicyDO")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDO BackupPolicyDO { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDO : TeaModel {
            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupAppName")]
            [Validation(Required=false)]
            public string BackupAppName { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupDbName")]
            [Validation(Required=false)]
            public string BackupDbName { get; set; }

            /// <summary>
            /// The backup level. Valid values:
            /// 
            /// *   **db**: database backup
            /// *   **instance**: instance backup
            /// </summary>
            [NameInMap("BackupLevel")]
            [Validation(Required=false)]
            public string BackupLevel { get; set; }

            /// <summary>
            /// Indicates whether the log backup feature is enabled. Valid values:
            /// 
            /// *   **1**: The log backup feature is enabled.
            /// *   **0**: The log backup feature is disabled.
            /// </summary>
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public string BackupLog { get; set; }

            /// <summary>
            /// The backup mode. Valid values:
            /// 
            /// *   **logic**: logical backup
            /// *   **phy**: fast backup
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// The type of the backup policy. Valid values:
            /// 
            /// *   **DataBackupPolicy**: a data backup policy
            /// *   **LogBackupPolicy**: a log backup policy
            /// </summary>
            [NameInMap("BackupPolicyMode")]
            [Validation(Required=false)]
            public string BackupPolicyMode { get; set; }

            /// <summary>
            /// The retention period of backup files. Unit: days.
            /// </summary>
            [NameInMap("BackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? BackupRetentionPeriod { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// The retention period of data backup files. Unit: days.
            /// </summary>
            [NameInMap("DataBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? DataBackupRetentionPeriod { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public long? HighSpaceUsageProtection { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("LocalLogRetentionHours")]
            [Validation(Required=false)]
            public long? LocalLogRetentionHours { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public long? LocalLogRetentionSpace { get; set; }

            /// <summary>
            /// The retention period of log backup files. Unit: days.
            /// </summary>
            [NameInMap("LogBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? LogBackupRetentionPeriod { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("NextBackupActuallyTime")]
            [Validation(Required=false)]
            public string NextBackupActuallyTime { get; set; }

            /// <summary>
            /// The backup cycle. You can specify multiple backup cycles. Separate multiple backup cycles with commas (,). Valid values:
            /// 
            /// *   **0**: every Monday
            /// *   **1**: every Tuesday
            /// *   **2**: every Wednesday
            /// *   **3**: every Thursday
            /// *   **4**: every Friday
            /// *   **5**: every Saturday
            /// *   **6**: every Sunday
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// The time range in which a backup is performed. The time is displayed in UTC.
            /// </summary>
            [NameInMap("PreferredBackupTime")]
            [Validation(Required=false)]
            public string PreferredBackupTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
