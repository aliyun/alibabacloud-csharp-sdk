// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeJobStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobStatusResponseBodyData Data { get; set; }
        public class DescribeJobStatusResponseBodyData : TeaModel {
            [NameInMap("Active")]
            [Validation(Required=false)]
            public long? Active { get; set; }
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public long? CompletionTime { get; set; }
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public long? Succeeded { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
