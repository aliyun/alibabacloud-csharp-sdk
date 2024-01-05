// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupsAsyncRequest : TeaModel {
        /// <summary>
        /// The ID of the SAP HANA instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Specifies whether to include differential backups in the query results. Valid values:
        /// 
        /// *   true: includes differential backups.
        /// *   false: excludes differential backups.
        /// </summary>
        [NameInMap("IncludeDifferential")]
        [Validation(Required=false)]
        public bool? IncludeDifferential { get; set; }

        /// <summary>
        /// Specifies whether to include incremental backups in the query results. Valid values:
        /// 
        /// *   true: includes incremental backups.
        /// *   false: excludes incremental backups.
        /// </summary>
        [NameInMap("IncludeIncremental")]
        [Validation(Required=false)]
        public bool? IncludeIncremental { get; set; }

        /// <summary>
        /// Specifies whether to include log backups in the query results. Valid values:
        /// 
        /// *   true: includes log backups.
        /// *   false: excludes log backups.
        /// </summary>
        [NameInMap("IncludeLog")]
        [Validation(Required=false)]
        public bool? IncludeLog { get; set; }

        /// <summary>
        /// The log position to which you want to restore the database. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_LOG_POSITION**.
        /// </summary>
        [NameInMap("LogPosition")]
        [Validation(Required=false)]
        public long? LogPosition { get; set; }

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
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The point in time to which you want to restore the database. This parameter is valid only if you set the Mode parameter to **RECOVERY_TO_POINT_IN_TIME**. HBR restores the database to a state closest to the specified point in time.
        /// </summary>
        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// Specifies whether to restore the database to a different instance. Valid values:
        /// 
        /// *   true: restores the database to a different instance.
        /// *   false: restores the database within the same instance.
        /// </summary>
        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        /// <summary>
        /// Specifies whether Backint is used. Valid values:
        /// 
        /// *   true: Backint is used.
        /// *   false: Backint is not used.
        /// </summary>
        [NameInMap("UseBackint")]
        [Validation(Required=false)]
        public bool? UseBackint { get; set; }

        /// <summary>
        /// The ID of the backup vault.
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
