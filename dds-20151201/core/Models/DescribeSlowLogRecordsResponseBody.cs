// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsLogRecords : TeaModel {
                public string ExecutionStartTime { get; set; }
                public string HostAddress { get; set; }
                public string QueryTimes { get; set; }
                public string TableName { get; set; }
                public string SQLText { get; set; }
                public long? ReturnRowCounts { get; set; }
                public long? KeysExamined { get; set; }
                public string DBName { get; set; }
                public long? DocsExamined { get; set; }
                public string AccountName { get; set; }
            }
        };

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

    }

}
