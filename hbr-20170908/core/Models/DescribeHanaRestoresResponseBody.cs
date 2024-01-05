// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaRestoresResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about restore jobs.
        /// </summary>
        [NameInMap("HanaRestore")]
        [Validation(Required=false)]
        public DescribeHanaRestoresResponseBodyHanaRestore HanaRestore { get; set; }
        public class DescribeHanaRestoresResponseBodyHanaRestore : TeaModel {
            [NameInMap("HanaRestores")]
            [Validation(Required=false)]
            public List<DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores> HanaRestores { get; set; }
            public class DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores : TeaModel {
                /// <summary>
                /// The ID of the backup.
                /// </summary>
                [NameInMap("BackupID")]
                [Validation(Required=false)]
                public long? BackupID { get; set; }

                /// <summary>
                /// The backup prefix.
                /// </summary>
                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                /// <summary>
                /// Indicates whether the differential backup and log backup are validated. Valid values:
                /// 
                /// *   true: HBR checks whether the required differential backup and log backup are available before the restore job starts. If the differential backup or log backup is unavailable, HBR does not start the restore job.
                /// *   false: HBR does not check whether the required differential backup and log backup are available before the restore job starts.
                /// </summary>
                [NameInMap("CheckAccess")]
                [Validation(Required=false)]
                public bool? CheckAccess { get; set; }

                /// <summary>
                /// Indicates whether all log entries are deleted from the log area after the log entries are restored. Valid values: true and false. If the return value is false, all log entries are deleted from the log area after the log entries are restored.
                /// </summary>
                [NameInMap("ClearLog")]
                [Validation(Required=false)]
                public bool? ClearLog { get; set; }

                /// <summary>
                /// The ID of the SAP HANA instance that is restored.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The current recovery phase. This value is obtained from SAP HANA.
                /// </summary>
                [NameInMap("CurrentPhase")]
                [Validation(Required=false)]
                public int? CurrentPhase { get; set; }

                /// <summary>
                /// The current progress. This value is obtained from SAP HANA.
                /// </summary>
                [NameInMap("CurrentProgress")]
                [Validation(Required=false)]
                public long? CurrentProgress { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The ID of the database recovery.
                /// </summary>
                [NameInMap("DatabaseRestoreId")]
                [Validation(Required=false)]
                public long? DatabaseRestoreId { get; set; }

                /// <summary>
                /// The time when the restore job ends. This value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The log position to which the database is restored. This parameter is returned only if the value of the Mode parameter is **RECOVERY_TO_LOG_POSITION**.
                /// </summary>
                [NameInMap("LogPosition")]
                [Validation(Required=false)]
                public long? LogPosition { get; set; }

                /// <summary>
                /// The maximum recovery phase. This value is obtained from SAP HANA.
                /// </summary>
                [NameInMap("MaxPhase")]
                [Validation(Required=false)]
                public int? MaxPhase { get; set; }

                /// <summary>
                /// The maximum progress. This value is obtained from SAP HANA.
                /// </summary>
                [NameInMap("MaxProgress")]
                [Validation(Required=false)]
                public long? MaxProgress { get; set; }

                /// <summary>
                /// The details of the recovery phase.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The recovery mode. Valid values:
                /// 
                /// *   **RECOVERY_TO_MOST_RECENT**: The database is restored to the recently available state to which the database has been backed up.
                /// *   **RECOVERY_TO_POINT_IN_TIME**: The database is restored to a specified point in time.
                /// *   **RECOVERY_TO_SPECIFIC_BACKUP**: The database is restored to a specified backup.
                /// *   **RECOVERY_TO_LOG_POSITION**: The database is restored to a specified log position.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The recovery phase.
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// The point in time at which the database is restored.
                /// </summary>
                [NameInMap("ReachedTime")]
                [Validation(Required=false)]
                public long? ReachedTime { get; set; }

                /// <summary>
                /// The point in time to which the database is restored. This parameter is returned only if the value of the Mode parameter is **RECOVERY_TO_POINT_IN_TIME**. HBR restores the database to a state closest to the specified point in time.
                /// </summary>
                [NameInMap("RecoveryPointInTime")]
                [Validation(Required=false)]
                public long? RecoveryPointInTime { get; set; }

                /// <summary>
                /// The ID of the restore job.
                /// </summary>
                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                /// <summary>
                /// The name of the source system. This parameter indicates the name of the source database that is restored. Format: `<Source database name>@SID`.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The ID of the source SAP HANA instance.
                /// </summary>
                [NameInMap("SourceClusterId")]
                [Validation(Required=false)]
                public string SourceClusterId { get; set; }

                /// <summary>
                /// The time when the restore job starts. This value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The recovery status. This value is obtained from SAP HANA.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The status of the restore job. Valid values:
                /// 
                /// *   **RUNNING**: The restore job is running.
                /// *   **COMPLETE**: The restore job is completed.
                /// *   **PARTIAL_COMPLETE**: The restore job is partially completed.
                /// *   **FAILED**: The restore job has failed.
                /// *   **CANCELED**: The restore job is canceled.
                /// *   **EXPIRED**: The restore job has timed out.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether the database is restored to a different instance. Valid values:
                /// 
                /// *   true: The database is restored to a different instance.
                /// *   false: The database is restored within the same instance.
                /// </summary>
                [NameInMap("SystemCopy")]
                [Validation(Required=false)]
                public bool? SystemCopy { get; set; }

                /// <summary>
                /// Indicates whether a catalog backup is used to restore the database. This parameter is returned only if the value of the Mode parameter is **RECOVERY_TO_SPECIFIC_BACKUP**. If the return value is false, HBR finds the backup file based on the specified prefix and then restores the backup file.
                /// </summary>
                [NameInMap("UseCatalog")]
                [Validation(Required=false)]
                public bool? UseCatalog { get; set; }

                /// <summary>
                /// Indicates whether a differential backup or an incremental backup is used to restore the database. Valid values: true and false. If the return value is true, HBR uses a differential backup or an incremental backup to restore the database. If the return value is false, HBR uses a log backup to restore the database.
                /// </summary>
                [NameInMap("UseDelta")]
                [Validation(Required=false)]
                public bool? UseDelta { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

                /// <summary>
                /// The ID of the volume that is restored. This parameter is returned only if the value of the Mode parameter is **RECOVERY_TO_LOG_POSITION**.
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public int? VolumeId { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
