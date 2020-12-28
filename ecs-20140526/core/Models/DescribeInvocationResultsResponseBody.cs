// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Invocation")]
        [Validation(Required=false)]
        public DescribeInvocationResultsResponseBodyInvocation Invocation { get; set; }
        public class DescribeInvocationResultsResponseBodyInvocation : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("InvocationResults")]
            [Validation(Required=false)]
            public List<DescribeInvocationResultsResponseBodyInvocationInvocationResults> InvocationResults { get; set; }
            public class DescribeInvocationResultsResponseBodyInvocationInvocationResults : TeaModel {
                public string InvocationStatus { get; set; }
                public int? Repeats { get; set; }
                public string Output { get; set; }
                public string InstanceId { get; set; }
                public string CommandId { get; set; }
                public int? Dropped { get; set; }
                public string StopTime { get; set; }
                public long? ExitCode { get; set; }
                public string StartTime { get; set; }
                public string ErrorInfo { get; set; }
                public string ErrorCode { get; set; }
                public string FinishedTime { get; set; }
                public string InvokeId { get; set; }
                public string InvokeRecordStatus { get; set; }
                public string Username { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

    }

}
