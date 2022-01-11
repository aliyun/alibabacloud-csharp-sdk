// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditRecordsResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditRecordsResponseBodyItems Items { get; set; }
        public class DescribeAuditRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public List<DescribeAuditRecordsResponseBodyItemsSQL> SQL { get; set; }
            public class DescribeAuditRecordsResponseBodyItemsSQL : TeaModel {
                public string AccountName { get; set; }
                public string DatabaseName { get; set; }
                public string ExecuteTime { get; set; }
                public string HostAddress { get; set; }
                public string IPAddress { get; set; }
                public string NodeId { get; set; }
                public string SQLText { get; set; }
                public string SQLType { get; set; }
                public string TotalExecutionTimes { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
