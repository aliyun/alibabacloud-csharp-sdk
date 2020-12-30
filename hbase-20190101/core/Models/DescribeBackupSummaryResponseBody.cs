// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Incr")]
        [Validation(Required=false)]
        public DescribeBackupSummaryResponseBodyIncr Incr { get; set; }
        public class DescribeBackupSummaryResponseBodyIncr : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }
            [NameInMap("Pos")]
            [Validation(Required=false)]
            public string Pos { get; set; }
            [NameInMap("QueueLogNum")]
            [Validation(Required=false)]
            public string QueueLogNum { get; set; }
            [NameInMap("BackupLogSize")]
            [Validation(Required=false)]
            public string BackupLogSize { get; set; }
            [NameInMap("RunningLogNum")]
            [Validation(Required=false)]
            public string RunningLogNum { get; set; }
        };

        [NameInMap("Full")]
        [Validation(Required=false)]
        public DescribeBackupSummaryResponseBodyFull Full { get; set; }
        public class DescribeBackupSummaryResponseBodyFull : TeaModel {
            [NameInMap("NextFullBackupDate")]
            [Validation(Required=false)]
            public string NextFullBackupDate { get; set; }
            [NameInMap("Records")]
            [Validation(Required=false)]
            public DescribeBackupSummaryResponseBodyFullRecords Records { get; set; }
            public class DescribeBackupSummaryResponseBodyFullRecords : TeaModel {
                [NameInMap("Record")]
                [Validation(Required=false)]
                public List<DescribeBackupSummaryResponseBodyFullRecordsRecord> Record { get; set; }
                public class DescribeBackupSummaryResponseBodyFullRecordsRecord : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    [NameInMap("Process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    [NameInMap("Speed")]
                    [Validation(Required=false)]
                    public string Speed { get; set; }

                    [NameInMap("RecordId")]
                    [Validation(Required=false)]
                    public string RecordId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                }

            }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public string HasMore { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

    }

}
