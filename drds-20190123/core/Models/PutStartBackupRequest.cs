// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PutStartBackupRequest : TeaModel {
        /// <summary>
        /// If you need to back up data at the database level, you must specify the list of databases to be backed up, and separate multiple databases with commas (,).
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// The backup level. Valid values:
        /// 
        /// *   instance: instance
        /// *   db: The database type.
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// The backup mode. For more information, see [backup mode](~~108631~~) and the valid values are as follows:
        /// 
        /// *   phy: fast backup
        /// *   logic: Consistent backup
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

    }

}
