// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupTablesResponseBody : TeaModel {
        [NameInMap("BackupRecords")]
        [Validation(Required=false)]
        public DescribeBackupTablesResponseBodyBackupRecords BackupRecords { get; set; }
        public class DescribeBackupTablesResponseBodyBackupRecords : TeaModel {
            [NameInMap("BackupRecord")]
            [Validation(Required=false)]
            public List<DescribeBackupTablesResponseBodyBackupRecordsBackupRecord> BackupRecord { get; set; }
            public class DescribeBackupTablesResponseBodyBackupRecordsBackupRecord : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public string DataSize { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                [NameInMap("Speed")]
                [Validation(Required=false)]
                public string Speed { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01262E9C-B0CC-4663-82FA-D50173649F92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeBackupTablesResponseBodyTables Tables { get; set; }
        public class DescribeBackupTablesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<string> Table { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
