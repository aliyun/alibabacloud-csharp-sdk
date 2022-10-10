// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowLog")]
            [Validation(Required=false)]
            public List<DescribeSlowLogsResponseBodyItemsSQLSlowLog> SQLSlowLog { get; set; }
            public class DescribeSlowLogsResponseBodyItemsSQLSlowLog : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                [NameInMap("TotalExecutionCounts")]
                [Validation(Required=false)]
                public long? TotalExecutionCounts { get; set; }

                [NameInMap("TotalExecutionTimes")]
                [Validation(Required=false)]
                public long? TotalExecutionTimes { get; set; }

                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

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

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
