// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupSummaryResponseBody : TeaModel {
        [NameInMap("Full")]
        [Validation(Required=false)]
        public DescribeBackupSummaryResponseBodyFull Full { get; set; }
        public class DescribeBackupSummaryResponseBodyFull : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public string HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("NextFullBackupDate")]
            [Validation(Required=false)]
            public string NextFullBackupDate { get; set; }

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

            [NameInMap("Records")]
            [Validation(Required=false)]
            public DescribeBackupSummaryResponseBodyFullRecords Records { get; set; }
            public class DescribeBackupSummaryResponseBodyFullRecords : TeaModel {
                [NameInMap("Record")]
                [Validation(Required=false)]
                public List<DescribeBackupSummaryResponseBodyFullRecordsRecord> Record { get; set; }
                public class DescribeBackupSummaryResponseBodyFullRecordsRecord : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-11-02T18:00:00Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.2 kB</para>
                    /// </summary>
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-11-02T18:02:04Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1/1</para>
                    /// </summary>
                    [NameInMap("Process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20201103020000</para>
                    /// </summary>
                    [NameInMap("RecordId")]
                    [Validation(Required=false)]
                    public string RecordId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.00 MB/s</para>
                    /// </summary>
                    [NameInMap("Speed")]
                    [Validation(Required=false)]
                    public string Speed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Incr")]
        [Validation(Required=false)]
        public DescribeBackupSummaryResponseBodyIncr Incr { get; set; }
        public class DescribeBackupSummaryResponseBodyIncr : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>266 B</para>
            /// </summary>
            [NameInMap("BackupLogSize")]
            [Validation(Required=false)]
            public string BackupLogSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-05T01:20:31Z</para>
            /// </summary>
            [NameInMap("Pos")]
            [Validation(Required=false)]
            public string Pos { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QueueLogNum")]
            [Validation(Required=false)]
            public string QueueLogNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RunningLogNum")]
            [Validation(Required=false)]
            public string RunningLogNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.00 MB/s</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>168793CB-7B31-43E7-ADAB-FE3E8D584D6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
