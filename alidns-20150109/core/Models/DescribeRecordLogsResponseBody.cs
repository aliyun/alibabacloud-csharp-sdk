// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordLogsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RecordLogs")]
        [Validation(Required=false)]
        public DescribeRecordLogsResponseBodyRecordLogs RecordLogs { get; set; }
        public class DescribeRecordLogsResponseBodyRecordLogs : TeaModel {
            [NameInMap("RecordLog")]
            [Validation(Required=false)]
            public List<DescribeRecordLogsResponseBodyRecordLogsRecordLog> RecordLog { get; set; }
            public class DescribeRecordLogsResponseBodyRecordLogsRecordLog : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ActionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("ActionTimestamp")]
                [Validation(Required=false)]
                public long? ActionTimestamp { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
