// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// The storage that is occupied by archived backup files on the instance. Unit: bytes.
        /// </summary>
        [NameInMap("ArchiveBackupSize")]
        [Validation(Required=false)]
        public long? ArchiveBackupSize { get; set; }

        /// <summary>
        /// The storage that is occupied by data backup files, excluding archived backup files, on the instance. Unit: bytes.
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// The storage that is occupied by log backup files, excluding archived backup files, on the instance. Unit: bytes.
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// The size of data backup files that are stored in Object Storage Service (OSS) buckets. Unit: bytes. The value 0 indicates no data backup files are stored in OSS buckets.
        /// </summary>
        [NameInMap("BackupOssDataSize")]
        [Validation(Required=false)]
        public long? BackupOssDataSize { get; set; }

        /// <summary>
        /// The size of log backup files that are stored in OSS buckets. Unit: bytes. The value 0 indicates no log backup files are stored in OSS buckets.
        /// </summary>
        [NameInMap("BackupOssLogSize")]
        [Validation(Required=false)]
        public long? BackupOssLogSize { get; set; }

        /// <summary>
        /// The storage that is used to store backup files. Unit: bytes. The value -1 indicates that no backup files are stored.
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// The storage that is used to store cold backup files. Unit: bytes. The value -1 indicates that no cold backup files are stored.
        /// </summary>
        [NameInMap("ColdBackupSize")]
        [Validation(Required=false)]
        public long? ColdBackupSize { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage that is used to store data files. Unit: bytes. The value -1 indicates that no data files are stored.
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// The total storage that is occupied by data files and log files on the instance. Unit: bytes. The value -1 indicates that no data files or log files are stored on the instance.
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// The database engine that the instance runs.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The storage that is used to store log files. Unit: bytes. The value -1 indicates that no log files are stored.
        /// </summary>
        [NameInMap("LogSize")]
        [Validation(Required=false)]
        public long? LogSize { get; set; }

        /// <summary>
        /// The backup storage for which you must pay. ApsaraDB RDS provides a free quota on backup storage. You must pay for the backup storage that exceeds the free quota. Unit: bytes.
        /// </summary>
        [NameInMap("PaidBackupSize")]
        [Validation(Required=false)]
        public long? PaidBackupSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The storage that is occupied to execute SQL statements on the instance. Unit: bytes. The value -1 indicates that no SQL statements are executed.
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

    }

}
