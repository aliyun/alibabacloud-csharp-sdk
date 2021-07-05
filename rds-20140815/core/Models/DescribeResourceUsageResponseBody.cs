// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        [NameInMap("BackupOssDataSize")]
        [Validation(Required=false)]
        public long? BackupOssDataSize { get; set; }

        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        [NameInMap("ArchiveBackupSize")]
        [Validation(Required=false)]
        public long? ArchiveBackupSize { get; set; }

        [NameInMap("BackupOssLogSize")]
        [Validation(Required=false)]
        public long? BackupOssLogSize { get; set; }

        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        [NameInMap("ColdBackupSize")]
        [Validation(Required=false)]
        public long? ColdBackupSize { get; set; }

        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        [NameInMap("PaidBackupSize")]
        [Validation(Required=false)]
        public long? PaidBackupSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LogSize")]
        [Validation(Required=false)]
        public long? LogSize { get; set; }

        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

    }

}
