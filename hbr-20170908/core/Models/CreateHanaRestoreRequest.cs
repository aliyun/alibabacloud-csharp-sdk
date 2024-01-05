// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateHanaRestoreRequest : TeaModel {
        /// <summary>
        /// The ID of the backup.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

        /// <summary>
        /// The backup prefix.
        /// </summary>
        [NameInMap("BackupPrefix")]
        [Validation(Required=false)]
        public string BackupPrefix { get; set; }

        /// <summary>
        /// Specifies whether to validate the differential backup and log backup. Valid values: true and false. If you set the value to true, HBR checks whether the required differential backup and log backup are available before the restore job starts. If the differential backup or log backup is unavailable, HBR does not start the restore job.
        /// </summary>
        [NameInMap("CheckAccess")]
        [Validation(Required=false)]
        public bool? CheckAccess { get; set; }

        /// <summary>
        /// Specifies whether to delete all log entries from the log area after the log entries are restored. Valid values: true and false. If you set the value to false, all log entries are deleted from the log area after the log entries are restored.
        /// </summary>
        [NameInMap("ClearLog")]
        [Validation(Required=false)]
        public bool? ClearLog { get; set; }

        /// <summary>
        /// The ID of the SAP HANA instance that you want to restore.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the database that you want to restore.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The log position to which you want to restore the database. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_LOG_POSITION**.
        /// </summary>
        [NameInMap("LogPosition")]
        [Validation(Required=false)]
        public long? LogPosition { get; set; }

        /// <summary>
        /// The ID of the client where the primary node of the SAP HANA resides.
        /// </summary>
        [NameInMap("MasterClientId")]
        [Validation(Required=false)]
        public string MasterClientId { get; set; }

        /// <summary>
        /// The recovery mode. Valid values:
        /// 
        /// *   **RECOVERY_TO_MOST_RECENT**: restores the database to the recently available state to which the database has been backed up.
        /// *   **RECOVERY_TO_POINT_IN_TIME**: restores the database to a specified point in time.
        /// *   **RECOVERY_TO_SPECIFIC_BACKUP**: restores the database to a specified backup.
        /// *   **RECOVERY_TO_LOG_POSITION**: restores the database to a specified log position.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The point in time to which you want to restore the database. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_POINT_IN_TIME**. HBR restores the database to a state closest to the specified point in time.
        /// </summary>
        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        /// <summary>
        /// The SID admin account that is created by SAP HANA.
        /// </summary>
        [NameInMap("SidAdmin")]
        [Validation(Required=false)]
        public string SidAdmin { get; set; }

        /// <summary>
        /// The name of the source system. This parameter specifies the name of the source database that you want to restore. You must set the parameter in the `<Source database name>@SID` format.
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
        /// Specifies whether to restore the database to a different instance.
        /// </summary>
        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        /// <summary>
        /// Specifies whether to use a catalog backup to restore the database. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_SPECIFIC_BACKUP**. If you do not use a catalog backup, you must specify the prefix of a backup file. Then, HBR finds the backup file based on the specified prefix and restores the backup file.
        /// </summary>
        [NameInMap("UseCatalog")]
        [Validation(Required=false)]
        public bool? UseCatalog { get; set; }

        /// <summary>
        /// Specifies whether to use a differential backup or an incremental backup to restore the database. Valid values: true and false. If you want to use a differential backup or an incremental backup to restore the database, set the value to true. If you set the value to false, HBR uses a log backup to restore the database.
        /// </summary>
        [NameInMap("UseDelta")]
        [Validation(Required=false)]
        public bool? UseDelta { get; set; }

        /// <summary>
        /// The ID of the vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

        /// <summary>
        /// The ID of the volume that you want to restore. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_LOG_POSITION**.
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public int? VolumeId { get; set; }

    }

}
