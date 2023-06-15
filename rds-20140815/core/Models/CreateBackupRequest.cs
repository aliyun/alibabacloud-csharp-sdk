// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// The backup type. Valid values:
        /// 
        /// *   **Logical**: logical backup
        /// *   **Physical**: physical backup
        /// *   **Snapshot**: snapshot backup
        /// 
        /// Default value: **Physical**.
        /// 
        /// > 
        /// 
        /// *   You can perform a logical backup only when databases are created on the instance.
        /// 
        /// *   When you perform a snapshot backup on an ApsaraDB RDS for MariaDB instance, you must set this parameter to **Physical**.
        /// *   For more information about the supported backup types, see [Back up an ApsaraDB RDS for MySQL instance](~~98818~~).
        /// *   When you perform a snapshot backup on an ApsaraDB RDS for SQL Server instance that uses cloud disks, you must set this parameter to **Snapshot**.
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// The backup policy. Valid values:
        /// 
        /// *   **db**: a database-level backup.
        /// *   **instance**: an instance-level backup.
        /// 
        /// > You can specify this parameter when you perform a logical backup on an ApsaraDB RDS for MySQL instance. You can also specify this parameter when you perform a full physical backup on an ApsaraDB RDS for SQL Server instance.
        /// </summary>
        [NameInMap("BackupStrategy")]
        [Validation(Required=false)]
        public string BackupStrategy { get; set; }

        /// <summary>
        /// The backup method. Valid values:
        /// 
        /// *   **Auto**: full or incremental backup that is automatically selected
        /// *   **FullBackup**: full backup
        /// 
        /// Default value: **Auto**.
        /// 
        /// > 
        /// 
        /// *   You must set this parameter only when the instance runs SQL Server.
        /// 
        /// *   This parameter is valid only when you set the **BackupMethod** parameter to **Physical**.
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The names of the databases whose data you want to back up. Separate the names of the databases with commas (,).
        /// 
        /// > You can specify this parameter when you perform a logical backup on individual databases of an ApsaraDB RDS for MySQL instance. You can also specify this parameter when you perform a full physical backup on individual databases of an ApsaraDB RDS for SQL Server instance.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
