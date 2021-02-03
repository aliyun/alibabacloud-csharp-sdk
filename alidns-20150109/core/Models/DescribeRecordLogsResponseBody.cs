// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordLogsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("RecordLogs")]
        [Validation(Required=false)]
        public DescribeRecordLogsResponseBodyRecordLogs RecordLogs { get; set; }
        public class DescribeRecordLogsResponseBodyRecordLogs : TeaModel {
            [NameInMap("RecordLog")]
            [Validation(Required=false)]
            public List<DescribeRecordLogsResponseBodyRecordLogsRecordLog> RecordLog { get; set; }
            public class DescribeRecordLogsResponseBodyRecordLogsRecordLog : TeaModel {
                public string Action { get; set; }
                public long? ActionTimestamp { get; set; }
                public string ClientIp { get; set; }
                public string Message { get; set; }
                public string ActionTime { get; set; }
            }
        };

    }

}
