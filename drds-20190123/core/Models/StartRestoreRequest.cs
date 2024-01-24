// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class StartRestoreRequest : TeaModel {
        /// <summary>
        /// The name of the database to be restored. Separate multiple databases with commas (,).
        /// 
        /// >  If you do not specify any database name, all databases in the instance are restored by default.
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// The ID of the DRDS backup set.
        /// 
        /// >  If you do not specify this parameter, the system restores data by time (PreferredBackupTime).
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

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
        /// The ID of the DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The restoration time of the instance, in the format of`  yyyy-MM-dd HH:mm:ss `.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

    }

}
