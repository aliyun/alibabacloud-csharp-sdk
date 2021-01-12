// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSQLLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLRecord")]
            [Validation(Required=false)]
            public List<DescribeSQLLogRecordsResponseBodyItemsSQLRecord> SQLRecord { get; set; }
            public class DescribeSQLLogRecordsResponseBodyItemsSQLRecord : TeaModel {
                public string DBName { get; set; }
                public string AccountName { get; set; }
                public string HostAddress { get; set; }
                public string SQLText { get; set; }
                public long? TotalExecutionTimes { get; set; }
                public long? ReturnRowCounts { get; set; }
                public string ExecuteTime { get; set; }
                public string ThreadID { get; set; }
            }
        };

    }

}
