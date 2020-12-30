// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Backups")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyBackups Backups { get; set; }
        public class DescribeBackupsResponseBodyBackups : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyBackupsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyBackupsBackup : TeaModel {
                public string EndTime { get; set; }
                public string Status { get; set; }
                public string StartTime { get; set; }
                public long? Size { get; set; }
                public string BackupType { get; set; }
                public string BackupId { get; set; }
                public string ClusterId { get; set; }
                public string DataCenterId { get; set; }
            }
        };

    }

}
