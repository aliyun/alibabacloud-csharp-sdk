// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of the database engine.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// An array that consists of the information about each slow log.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord> SQLSlowRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord : TeaModel {
                /// <summary>
                /// The name of the application that is connected to the instance.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// The hostname of the client.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("ClientHostName")]
                [Validation(Required=false)]
                public string ClientHostName { get; set; }

                /// <summary>
                /// The duration during which the SQL statement is processed by the CPU. Unit: milliseconds.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The time when the execution of the SQL statement started. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// The name and IP address of the client that is connected to the database.
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// The number of rows that are affected by the last SQL statement.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("LastRowsAffectedCount")]
                [Validation(Required=false)]
                public long? LastRowsAffectedCount { get; set; }

                /// <summary>
                /// The lock duration of the query. Unit: seconds.
                /// </summary>
                [NameInMap("LockTimes")]
                [Validation(Required=false)]
                public long? LockTimes { get; set; }

                /// <summary>
                /// The number of logical reads.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("LogicalIORead")]
                [Validation(Required=false)]
                public long? LogicalIORead { get; set; }

                /// <summary>
                /// The number of parsed rows.
                /// </summary>
                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                /// <summary>
                /// The number of physical reads.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("PhysicalIORead")]
                [Validation(Required=false)]
                public long? PhysicalIORead { get; set; }

                /// <summary>
                /// The execution duration of the query. Unit: milliseconds.
                /// </summary>
                [NameInMap("QueryTimeMS")]
                [Validation(Required=false)]
                public long? QueryTimeMS { get; set; }

                /// <summary>
                /// The execution duration of the query. Unit: seconds.
                /// </summary>
                [NameInMap("QueryTimes")]
                [Validation(Required=false)]
                public long? QueryTimes { get; set; }

                /// <summary>
                /// The number of rows returned.
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// The number of affected rows.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("RowsAffectedCount")]
                [Validation(Required=false)]
                public long? RowsAffectedCount { get; set; }

                /// <summary>
                /// The unique ID of the SQL statement.
                /// </summary>
                [NameInMap("SQLHash")]
                [Validation(Required=false)]
                public string SQLHash { get; set; }

                /// <summary>
                /// The details of the SQL statement.
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// The name of the user.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The number of I/O writes.
                /// 
                /// > This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("WriteIOCount")]
                [Validation(Required=false)]
                public long? WriteIOCount { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of SQL log reports on the current page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
