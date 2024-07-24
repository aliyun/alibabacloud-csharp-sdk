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
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2 kB</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public string DataSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-11-02T18:00:05Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>14/14</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00 MB/s</para>
                /// </summary>
                [NameInMap("Speed")]
                [Validation(Required=false)]
                public string Speed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-11-02T18:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCEEDED</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default:test1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
