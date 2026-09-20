// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18D9CC47-D913-48BF-AB6B-4FA9B28FBDB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The full restore details.</para>
        /// </summary>
        [NameInMap("RestoreFull")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreFull RestoreFull { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreFull : TeaModel {
            /// <summary>
            /// <para>The total data size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2 kB</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public string DataSize { get; set; }

            /// <summary>
            /// <para>The number of failed full restores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RestoreFullDetails")]
            [Validation(Required=false)]
            public DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetails RestoreFullDetails { get; set; }
            public class DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetails : TeaModel {
                [NameInMap("RestoreFullDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail> RestoreFullDetail { get; set; }
                public class DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail : TeaModel {
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
            /// <para>The total speed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00 MB/s</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <para>The number of successful restores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The incremental restore details.</para>
        /// </summary>
        [NameInMap("RestoreIncrDetail")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreIncrDetail RestoreIncrDetail { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreIncrDetail : TeaModel {
            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The completion progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/0</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The synchronization latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 ms</para>
            /// </summary>
            [NameInMap("RestoreDelay")]
            [Validation(Required=false)]
            public string RestoreDelay { get; set; }

            /// <summary>
            /// <para>The synchronization start position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-02T18:00:00Z</para>
            /// </summary>
            [NameInMap("RestoreStartTs")]
            [Validation(Required=false)]
            public string RestoreStartTs { get; set; }

            /// <summary>
            /// <para>The synchronization position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("RestoredTs")]
            [Validation(Required=false)]
            public string RestoredTs { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The schema restore details.</para>
        /// </summary>
        [NameInMap("RestoreSchema")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSchema RestoreSchema { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSchema : TeaModel {
            /// <summary>
            /// <para>The number of failed restores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RestoreSchemaDetails")]
            [Validation(Required=false)]
            public DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetails RestoreSchemaDetails { get; set; }
            public class DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetails : TeaModel {
                [NameInMap("RestoreSchemaDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail> RestoreSchemaDetail { get; set; }
                public class DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

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
            /// <para>The number of successful restores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The restore summary.</para>
        /// </summary>
        [NameInMap("RestoreSummary")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSummary RestoreSummary { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSummary : TeaModel {
            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:51Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201105144514</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <para>The point in time to which data is restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-04T05:15:00Z</para>
            /// </summary>
            [NameInMap("RestoreToDate")]
            [Validation(Required=false)]
            public string RestoreToDate { get; set; }

            /// <summary>
            /// <para>The restore start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:14Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The target cluster for the restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-m5e2t34kr54wgxxxx</para>
            /// </summary>
            [NameInMap("TargetCluster")]
            [Validation(Required=false)]
            public string TargetCluster { get; set; }

        }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyTables Tables { get; set; }
        public class DescribeRestoreTablesResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<string> Table { get; set; }

        }

    }

}
