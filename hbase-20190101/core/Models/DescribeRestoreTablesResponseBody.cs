// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreTablesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>18D9CC47-D913-48BF-AB6B-4FA9B28FBDB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreFull")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreFull RestoreFull { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreFull : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2 kB</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public string DataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

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

            [NameInMap("RestoreFullDetails")]
            [Validation(Required=false)]
            public DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetails RestoreFullDetails { get; set; }
            public class DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetails : TeaModel {
                [NameInMap("RestoreFullDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail> RestoreFullDetail { get; set; }
                public class DescribeRestoreTablesResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.2 kB</para>
                    /// </summary>
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-11-05T06:45:51Z</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>“”</para>
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
                    /// <para>2020-11-05T06:45:45Z</para>
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
            /// <para>0.00 MB/s</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RestoreIncrDetail")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreIncrDetail RestoreIncrDetail { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreIncrDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0/0</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 ms</para>
            /// </summary>
            [NameInMap("RestoreDelay")]
            [Validation(Required=false)]
            public string RestoreDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-02T18:00:00Z</para>
            /// </summary>
            [NameInMap("RestoreStartTs")]
            [Validation(Required=false)]
            public string RestoreStartTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("RestoredTs")]
            [Validation(Required=false)]
            public string RestoredTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
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

        }

        [NameInMap("RestoreSchema")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSchema RestoreSchema { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSchema : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

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

            [NameInMap("RestoreSchemaDetails")]
            [Validation(Required=false)]
            public DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetails RestoreSchemaDetails { get; set; }
            public class DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetails : TeaModel {
                [NameInMap("RestoreSchemaDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail> RestoreSchemaDetail { get; set; }
                public class DescribeRestoreTablesResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-11-05T06:45:18Z</para>
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
                    /// <para>2020-11-05T06:45:14Z</para>
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
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RestoreSummary")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSummary RestoreSummary { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:51Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20201105144514</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-04T05:15:00Z</para>
            /// </summary>
            [NameInMap("RestoreToDate")]
            [Validation(Required=false)]
            public string RestoreToDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:14Z</para>
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
