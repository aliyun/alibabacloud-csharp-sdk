// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateMigrateTaskRequest : TeaModel {
        /// <summary>
        /// The type of the migration task. Valid values:
        /// 
        /// *   **FULL**: The migration task migrates full backup files.
        /// *   **UPDF**: The migration task migrates incremental or log backup files.
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// The consistency check method for the database. Valid values:
        /// 
        /// *   **SyncExecuteDBCheck**: synchronous database check
        /// *   **AsyncExecuteDBCheck**: asynchronous database check
        /// 
        /// Default value: **AsyncExecuteDBCheck** (compatible with SQL Server 2008 R2).
        /// 
        /// >  This parameter is valid when IsOnlineDB is set to **True**.
        /// </summary>
        [NameInMap("CheckDBMode")]
        [Validation(Required=false)]
        public string CheckDBMode { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the destination database.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// Specifies whether to make the restored database data available for user access. Valid values:
        /// 
        /// *   **True**
        /// *   **False**
        /// 
        /// > Set the value to **True** for instances that run SQL Server 2008 R2.
        /// </summary>
        [NameInMap("IsOnlineDB")]
        [Validation(Required=false)]
        public string IsOnlineDB { get; set; }

        /// <summary>
        /// The ID of the migration task.
        /// 
        /// *   If you set **BackupMode** to **FULL**, the value of this parameter is empty. The full backup mode is compatible with instance that runs SQL Server 2008 R2.
        /// *   If you set **BackupMode** to **UPDF**, the value of this parameter is the ID of the required full migration task.
        /// 
        /// > 
        /// 
        /// *   If you set **IsOnlineDB** to **True**, the value of **BackupMode** must be **FULL**.
        /// 
        /// *   If you set **IsOnlineDB** to **False**, the value of **BackupMode** must be **UPDF**.
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// The shared URL of the backup file in the OSS bucket. The URL must be encoded.
        /// 
        /// If you specify multiple URLs, separate them with vertical bars (|) and then encode them.
        /// 
        /// > This parameter is required for instances that run SQL Server 2008 R2.
        /// </summary>
        [NameInMap("OSSUrls")]
        [Validation(Required=false)]
        public string OSSUrls { get; set; }

        /// <summary>
        /// The information about the backup file in the OSS bucket.
        /// 
        /// The values consist of three parts that are separated by colons (:):
        /// 
        /// *   OSS endpoint: oss-ap-southeast-1.aliyuncs.com.
        /// *   Name of the OSS bucket: rdsmssqlsingapore.
        /// *   Key of the backup file in the OSS bucket: autotest\_2008R2\_TestMigration_FULL.bak.
        /// 
        /// > 
        /// 
        /// *   This parameter is optional for instances that run SQL Server 2008 R2.
        /// 
        /// *   This parameter is required for instances that run a database engine version later than SQL Server 2008 R2.
        /// </summary>
        [NameInMap("OssObjectPositions")]
        [Validation(Required=false)]
        public string OssObjectPositions { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
