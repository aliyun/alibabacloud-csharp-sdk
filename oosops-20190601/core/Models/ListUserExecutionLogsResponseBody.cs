// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListUserExecutionLogsResponseBody : TeaModel {
        [NameInMap("ExecutionLogs")]
        [Validation(Required=false)]
        public List<ListUserExecutionLogsResponseBodyExecutionLogs> ExecutionLogs { get; set; }
        public class ListUserExecutionLogsResponseBodyExecutionLogs : TeaModel {
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
