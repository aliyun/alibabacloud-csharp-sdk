// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The database engine.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// Details of the slow query logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsLogRecords : TeaModel {
                /// <summary>
                /// The username of the database account that performs the operation.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The number of documents that are scanned during the operation.
                /// </summary>
                [NameInMap("DocsExamined")]
                [Validation(Required=false)]
                public long? DocsExamined { get; set; }

                /// <summary>
                /// The start time of the operation. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// The host IP address that is used to connect to the database.
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// The number of rows involved in index scans.
                /// </summary>
                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public long? KeysExamined { get; set; }

                /// <summary>
                /// The execution time of the statement. Unit: milliseconds.
                /// </summary>
                [NameInMap("QueryTimes")]
                [Validation(Required=false)]
                public string QueryTimes { get; set; }

                /// <summary>
                /// The number of rows returned by the SQL statement.
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// The SQL statement that is executed during the slow operation.
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// The name of the collection.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of slow query log entries returned on the page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
