// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The number of days for which data backup files are retained.
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Indicates whether log backup is enabled. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// The number of days for which the log backup files are retained.
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// The cycle based on which backups are performed. If more than one day of the week are specified, the days of the week are separated by commas (,). Valid value:
        /// 
        /// *   Monday
        /// *   Tuesday
        /// *   Wednesday
        /// *   Thursday
        /// *   Friday
        /// *   Saturday
        /// *   Sunday
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The data backup time. The time is in the HH:mmZ-HH:mmZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
