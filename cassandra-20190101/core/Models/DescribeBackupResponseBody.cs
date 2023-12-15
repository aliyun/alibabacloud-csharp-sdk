// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeBackupResponseBody : TeaModel {
        [NameInMap("Backup")]
        [Validation(Required=false)]
        public DescribeBackupResponseBodyBackup Backup { get; set; }
        public class DescribeBackupResponseBodyBackup : TeaModel {
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("DataCenterId")]
            [Validation(Required=false)]
            public string DataCenterId { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
