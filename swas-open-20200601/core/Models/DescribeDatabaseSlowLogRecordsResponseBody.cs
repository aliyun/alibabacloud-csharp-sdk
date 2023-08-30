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
        /// The database name.
        /// </summary>
        [NameInMap("SlowLogs")]
        [Validation(Required=false)]
        public List<DescribeDatabaseSlowLogRecordsResponseBodySlowLogs> SlowLogs { get; set; }
        public class DescribeDatabaseSlowLogRecordsResponseBodySlowLogs : TeaModel {
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            [NameInMap("LockTimes")]
            [Validation(Required=false)]
            public long? LockTimes { get; set; }

            [NameInMap("ParseRowCounts")]
            [Validation(Required=false)]
            public long? ParseRowCounts { get; set; }

            [NameInMap("QueryTimeMS")]
            [Validation(Required=false)]
            public long? QueryTimeMS { get; set; }

            [NameInMap("QueryTimes")]
            [Validation(Required=false)]
            public long? QueryTimes { get; set; }

            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

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
