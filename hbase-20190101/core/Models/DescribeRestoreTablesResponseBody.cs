// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreTablesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreFull")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreFull RestoreFull { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreFull : TeaModel {
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public string DataSize { get; set; }

            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

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

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RestoreIncrDetail")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreIncrDetail RestoreIncrDetail { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreIncrDetail : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            [NameInMap("RestoreDelay")]
            [Validation(Required=false)]
            public string RestoreDelay { get; set; }

            [NameInMap("RestoreStartTs")]
            [Validation(Required=false)]
            public string RestoreStartTs { get; set; }

            [NameInMap("RestoredTs")]
            [Validation(Required=false)]
            public string RestoredTs { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RestoreSchema")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSchema RestoreSchema { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSchema : TeaModel {
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

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

            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RestoreSummary")]
        [Validation(Required=false)]
        public DescribeRestoreTablesResponseBodyRestoreSummary RestoreSummary { get; set; }
        public class DescribeRestoreTablesResponseBodyRestoreSummary : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("RestoreToDate")]
            [Validation(Required=false)]
            public string RestoreToDate { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

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
