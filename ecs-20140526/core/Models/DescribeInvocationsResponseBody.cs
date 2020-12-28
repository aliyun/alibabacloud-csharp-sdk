// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
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

        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeInstances")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeInstances> InvokeInstances { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeInstances : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Dropped")]
                [Validation(Required=false)]
                public int? Dropped { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("InstanceInvokeStatus")]
                [Validation(Required=false)]
                public string InstanceInvokeStatus { get; set; }

            }

            [NameInMap("CommandId")]
            [Validation(Required=false)]
            public string CommandId { get; set; }

            [NameInMap("InvokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            [NameInMap("Timed")]
            [Validation(Required=false)]
            public bool? Timed { get; set; }

            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
