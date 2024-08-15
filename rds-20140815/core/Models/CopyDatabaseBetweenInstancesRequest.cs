// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CopyDatabaseBetweenInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set based on which you want to restore databases of the source instance. When you replicate databases by backup set, you can call the DescribeBackups operation to obtain the ID of the backup set.
        /// 
        /// >  You must specify one of the **BackupId** and **RestoreTime** parameters.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The source instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The names of the databases that you want to copy. Format: `Source database name 1,Source database name 2`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time when the system replicates databases. You can select a point in time within the backup retention period. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > You must specify one of the **BackupId** and **RestoreTime** parameters.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// Specifies whether to copy users and permissions.
        /// 
        /// *   **YES**: copies users and permissions. If the destination instance has a user whose name is the same as a user in the source instance, the permissions of the user in the source instance will also be granted to the user in the destination instance after you copy user permissions.
        /// *   **NO**: does not copy users and permissions.
        /// 
        /// Default value: **NO**.
        /// </summary>
        [NameInMap("SyncUserPrivilege")]
        [Validation(Required=false)]
        public string SyncUserPrivilege { get; set; }

        /// <summary>
        /// The destination instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

    }

}
