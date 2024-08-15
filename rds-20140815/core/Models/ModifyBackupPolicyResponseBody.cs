// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The method that is used to compress backups. Valid values:
        /// 
        /// *   **0:** Backups are not compressed.
        /// *   **1**: Backups are compressed by using the zlib tool.
        /// *   **2**: Backups are compressed in parallel by using the zlib tool.
        /// *   **4**: Backups are compressed by using the QuickLZ tool and can be used to restore individual databases and tables.
        /// *   **8**: Backups are compressed by using the QuickLZ tool but cannot be used to restore individual databases or tables. This value is supported only for instances that run MySQL 8.0.
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        /// <summary>
        /// Indicates whether the log backup feature is enabled. Valid values:
        /// 
        /// *   **1**: The feature is enabled.
        /// *   **0**: The feature is disabled.
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// Specifies whether to forcefully delete log backup files from the instance when the storage usage of the instance exceeds 80% or the amount of remaining storage on the instance is less than 5 GB.
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// The number of hours for which log backup files are retained on the instance.
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// The maximum storage usage that is allowed for log backup files on the instance.
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// The number of binary log files on the instance.
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
