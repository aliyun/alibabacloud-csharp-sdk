// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The database engine that the instance runs.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 30 to 100.
        /// 
        /// Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of logical reads.
        /// </summary>
        [NameInMap("PhysicalIORead")]
        [Validation(Required=false)]
        public long? PhysicalIORead { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The slow query logs returned.
        /// </summary>
        [NameInMap("SlowLogs")]
        [Validation(Required=false)]
        public List<DescribeDatabaseSlowLogRecordsResponseBodySlowLogs> SlowLogs { get; set; }
        public class DescribeDatabaseSlowLogRecordsResponseBodySlowLogs : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// The time when the execution of the SQL statement started. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// 
            /// >  The time displayed in the Simple Application Server console is in the format of UTC+8.
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
            /// The lock duration of the SQL statement. Unit: seconds.
            /// </summary>
            [NameInMap("LockTimes")]
            [Validation(Required=false)]
            public long? LockTimes { get; set; }

            /// <summary>
            /// The number of rows parsed by the SQL statement.
            /// </summary>
            [NameInMap("ParseRowCounts")]
            [Validation(Required=false)]
            public long? ParseRowCounts { get; set; }

            /// <summary>
            /// The execution duration of the slow query. Unit: millisecond.
            /// </summary>
            [NameInMap("QueryTimeMS")]
            [Validation(Required=false)]
            public long? QueryTimeMS { get; set; }

            /// <summary>
            /// The execution duration of the slow query. Unit: seconds.
            /// </summary>
            [NameInMap("QueryTimes")]
            [Validation(Required=false)]
            public long? QueryTimes { get; set; }

            /// <summary>
            /// The number of rows returned by the SQL statement.
            /// </summary>
            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            /// <summary>
            /// The details of the SQL statement.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
