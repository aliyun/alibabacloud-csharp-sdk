// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaBackupSettingRequest : TeaModel {
        /// <summary>
        /// The configuration file for catalog backup.
        /// </summary>
        [NameInMap("CatalogBackupParameterFile")]
        [Validation(Required=false)]
        public string CatalogBackupParameterFile { get; set; }

        /// <summary>
        /// Specifies whether to use Backint to back up catalogs. Valid values:
        /// 
        /// *   true: Backint is used to back up catalogs.
        /// *   false: Backint is not used to back up catalogs.
        /// </summary>
        [NameInMap("CatalogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? CatalogBackupUsingBackint { get; set; }

        /// <summary>
        /// The ID of the SAP HANA instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The configuration file for data backup.
        /// </summary>
        [NameInMap("DataBackupParameterFile")]
        [Validation(Required=false)]
        public string DataBackupParameterFile { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic log backup. Valid values:
        /// 
        /// *   **true**: enables automatic log backup.
        /// *   **false**: disables automatic log backup.
        /// </summary>
        [NameInMap("EnableAutoLogBackup")]
        [Validation(Required=false)]
        public bool? EnableAutoLogBackup { get; set; }

        /// <summary>
        /// The configuration file for log backup.
        /// </summary>
        [NameInMap("LogBackupParameterFile")]
        [Validation(Required=false)]
        public string LogBackupParameterFile { get; set; }

        /// <summary>
        /// The interval at which logs are backed up. Unit: seconds.
        /// </summary>
        [NameInMap("LogBackupTimeout")]
        [Validation(Required=false)]
        public long? LogBackupTimeout { get; set; }

        /// <summary>
        /// Specifies whether to use Backint to back up logs. Valid values:
        /// 
        /// *   true: Backint is used to back up logs.
        /// *   false: Backint is not used to back up logs.
        /// </summary>
        [NameInMap("LogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? LogBackupUsingBackint { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
