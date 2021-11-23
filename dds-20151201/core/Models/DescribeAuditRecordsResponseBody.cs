// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditRecordsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditRecordsResponseBodyItems Items { get; set; }
        public class DescribeAuditRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLRecord")]
            [Validation(Required=false)]
            public List<DescribeAuditRecordsResponseBodyItemsSQLRecord> SQLRecord { get; set; }
            public class DescribeAuditRecordsResponseBodyItemsSQLRecord : TeaModel {
                public string AccountName { get; set; }
                public string DBName { get; set; }
                public string ExecuteTime { get; set; }
                public string HostAddress { get; set; }
                public long? ReturnRowCounts { get; set; }
                public string Syntax { get; set; }
                public string TableName { get; set; }
                public string ThreadID { get; set; }
                public long? TotalExecutionTimes { get; set; }
            }
        };

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
