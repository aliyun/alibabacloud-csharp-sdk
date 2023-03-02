// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationResultResponseBody : TeaModel {
        [NameInMap("InvocationResult")]
        [Validation(Required=false)]
        public DescribeInvocationResultResponseBodyInvocationResult InvocationResult { get; set; }
        public class DescribeInvocationResultResponseBodyInvocationResult : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public long? ExitCode { get; set; }

            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            [NameInMap("InvokeUser")]
            [Validation(Required=false)]
            public string InvokeUser { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
