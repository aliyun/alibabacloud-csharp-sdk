// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupSetsResponseBody : TeaModel {
        /// <summary>
        /// The list of backup sets.
        /// </summary>
        [NameInMap("BackupSets")]
        [Validation(Required=false)]
        public DescribeBackupSetsResponseBodyBackupSets BackupSets { get; set; }
        public class DescribeBackupSetsResponseBodyBackupSets : TeaModel {
            [NameInMap("backupSet")]
            [Validation(Required=false)]
            public List<DescribeBackupSetsResponseBodyBackupSetsBackupSet> BackupSet { get; set; }
            public class DescribeBackupSetsResponseBodyBackupSetsBackupSet : TeaModel {
                /// <summary>
                /// Backup Recovery duration.
                /// </summary>
                [NameInMap("BackupConsitentTime")]
                [Validation(Required=false)]
                public string BackupConsitentTime { get; set; }

                /// <summary>
                /// The list of backup databases.
                /// </summary>
                [NameInMap("BackupDbs")]
                [Validation(Required=false)]
                public DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs BackupDbs { get; set; }
                public class DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs : TeaModel {
                    [NameInMap("backupDb")]
                    [Validation(Required=false)]
                    public List<string> BackupDb { get; set; }

                }

                /// <summary>
                /// The end of the backup time which is in timestamp format (measured in millisecond).
                /// 
                /// >  0 indicates not finished.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public long? BackupEndTime { get; set; }

                /// <summary>
                /// The level of the backup. Valid values:
                /// 
                /// *   db: The database level.
                /// *   instance: the instance level.
                /// </summary>
                [NameInMap("BackupLevel")]
                [Validation(Required=false)]
                public string BackupLevel { get; set; }

                /// <summary>
                /// The backup method. Valid values:
                /// 
                /// *   logic: the logical backup.
                /// *   phy: fast backup
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The beginning of the backup time which is in timestamp format (measured in millisecond).
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public long? BackupStartTime { get; set; }

                /// <summary>
                /// The size of the backup set. Unit: MB.
                /// </summary>
                [NameInMap("BackupTotalSize")]
                [Validation(Required=false)]
                public string BackupTotalSize { get; set; }

                /// <summary>
                /// The type of the backup. Valid values:
                /// 
                /// *   manual: indicates a manual backup.
                /// *   auto: indicates an automatic backup.
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// Indicates whether the backup set can be restored. Valid values:
                /// </summary>
                [NameInMap("EnableRecovery")]
                [Validation(Required=false)]
                public bool? EnableRecovery { get; set; }

                /// <summary>
                /// The ID of the data backup file you want to use.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The status of the backup instance. Valid values:
                /// 
                /// *   \-1: Failed
                /// *   0: Not started
                /// *   1: The storage instance is running.
                /// *   2: Success
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
