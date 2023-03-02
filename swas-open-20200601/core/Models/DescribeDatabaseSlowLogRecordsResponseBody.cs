// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PhysicalIORead")]
        [Validation(Required=false)]
        public long? PhysicalIORead { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
