// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord> SQLSlowRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord : TeaModel {
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

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

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
