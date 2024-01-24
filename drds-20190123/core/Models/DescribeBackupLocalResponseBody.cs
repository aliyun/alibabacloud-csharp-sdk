// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupLocalResponseBody : TeaModel {
        /// <summary>
        /// The information about the backup policy.
        /// </summary>
        [NameInMap("BackupPolicyDO")]
        [Validation(Required=false)]
        public DescribeBackupLocalResponseBodyBackupPolicyDO BackupPolicyDO { get; set; }
        public class DescribeBackupLocalResponseBodyBackupPolicyDO : TeaModel {
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
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupLevel")]
            [Validation(Required=false)]
            public string BackupLevel { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public string BackupLog { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// No value is returned.
            /// </summary>
            [NameInMap("BackupPolicyMode")]
            [Validation(Required=false)]
            public string BackupPolicyMode { get; set; }

            /// <summary>
            /// No value is returned.
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
            /// No value is returned.
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
            /// Indicates whether the feature is enabled to forcibly delete binary log files if the used storage space of the instance exceeds 90% of the total storage space or the remaining storage space is less than 5 GB. Valid values:
            /// 
            /// *   1: The feature is enabled.
            /// *   0: The feature is disabled.
            /// </summary>
            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public long? HighSpaceUsageProtection { get; set; }

            /// <summary>
            /// The number of hours for which log backup files are retained on the instance. Valid values: 0 to 168. Default value: **18**. The value **0** indicates that log backup files are not retained.
            /// </summary>
            [NameInMap("LocalLogRetentionHours")]
            [Validation(Required=false)]
            public long? LocalLogRetentionHours { get; set; }

            /// <summary>
            /// The maximum storage usage that is allowed for local log files. Valid values: 0 to 50. Default value: 30.
            /// </summary>
            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public long? LocalLogRetentionSpace { get; set; }

            /// <summary>
            /// No value is returned.
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
            /// No value is returned.
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// No value is returned.
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
