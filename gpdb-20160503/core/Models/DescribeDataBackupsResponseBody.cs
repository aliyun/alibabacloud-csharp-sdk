// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataBackupsResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataBackupsResponseBodyItems> Items { get; set; }
        public class DescribeDataBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// The UTC time when the backup ended. The time is in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// The local time when the backup ended. The time is in the yyyy-MM-dd HH:mm:ss format. The time is your local time.
            /// </summary>
            [NameInMap("BackupEndTimeLocal")]
            [Validation(Required=false)]
            public string BackupEndTimeLocal { get; set; }

            /// <summary>
            /// The method that is used to generate the backup set. Valid values:
            /// 
            /// *   **Logical**: logical backup
            /// *   **Physical**: physical backup
            /// *   **Snapshot**: snapshot backup
            /// </summary>
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            /// <summary>
            /// The backup mode.
            /// 
            /// Valid values for full backup:
            /// 
            /// *   Automated: automatic backup
            /// *   Manual: manual backup
            /// 
            /// Valid values for point-in-time backup:
            /// 
            /// *   Automated: point-in-time backup after full backup
            /// *   Manual: manual point-in-time backup
            /// *   Period: point-in-time backup that is triggered by a backup policy
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// The ID of the backup set.
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            /// <summary>
            /// The size of the backup file. Unit: bytes.
            /// </summary>
            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            /// <summary>
            /// The UTC time when the backup started. The time is in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// The local time when the backup started. The time is in the yyyy-MM-dd HH:mm:ss format. The time is your local time.
            /// </summary>
            [NameInMap("BackupStartTimeLocal")]
            [Validation(Required=false)]
            public string BackupStartTimeLocal { get; set; }

            /// <summary>
            /// The status of the backup set. Valid values:
            /// 
            /// *   Success
            /// *   Failure
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// The name of a point-in-time backup set or the full backup set.
            /// </summary>
            [NameInMap("BaksetName")]
            [Validation(Required=false)]
            public string BaksetName { get; set; }

            /// <summary>
            /// *   For full backup, this parameter indicates the point in time at which the data in the data backup file is consistent.
            /// *   For point-in-time backup, this parameter indicates that the returned point in time is a timestamp.
            /// </summary>
            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public long? ConsistentTime { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The type of the backup. Valid values:
            /// 
            /// *   DATA: full backup
            /// *   RESTOREPOI: point-in-time backup
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total backup set size. Unit: Byte.
        /// </summary>
        [NameInMap("TotalBackupSize")]
        [Validation(Required=false)]
        public long? TotalBackupSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
