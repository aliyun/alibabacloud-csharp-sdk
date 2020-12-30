// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupTablesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("BackupRecords")]
        [Validation(Required=false)]
        public DescribeBackupTablesResponseBodyBackupRecords BackupRecords { get; set; }
        public class DescribeBackupTablesResponseBodyBackupRecords : TeaModel {
            [NameInMap("BackupRecord")]
            [Validation(Required=false)]
            public List<DescribeBackupTablesResponseBodyBackupRecordsBackupRecord> BackupRecord { get; set; }
            public class DescribeBackupTablesResponseBodyBackupRecordsBackupRecord : TeaModel {
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string Process { get; set; }
                public string DataSize { get; set; }
                public string Speed { get; set; }
                public string State { get; set; }
                public string Message { get; set; }
                public string Table { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeBackupTablesResponseBodyTables Tables { get; set; }
        public class DescribeBackupTablesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<string> Table { get; set; }
        };

    }

}
