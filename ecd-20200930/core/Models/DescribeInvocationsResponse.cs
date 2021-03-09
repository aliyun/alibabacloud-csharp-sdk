// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Invocations")]
        [Validation(Required=true)]
        public List<DescribeInvocationsResponseInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseInvocations : TeaModel {
            [NameInMap("InvokeId")]
            [Validation(Required=true)]
            public string InvokeId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=true)]
            public string CreationTime { get; set; }

            [NameInMap("CommandType")]
            [Validation(Required=true)]
            public string CommandType { get; set; }

            [NameInMap("CommandContent")]
            [Validation(Required=true)]
            public string CommandContent { get; set; }

            [NameInMap("InvocationStatus")]
            [Validation(Required=true)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeDesktops")]
            [Validation(Required=true)]
            public List<DescribeInvocationsResponseInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseInvocationsInvokeDesktops : TeaModel {
                [NameInMap("DesktopId")]
                [Validation(Required=true)]
                public string DesktopId { get; set; }

                [NameInMap("Repeats")]
                [Validation(Required=true)]
                public int? Repeats { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=true)]
                public string InvocationStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=true)]
                public string CreationTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=true)]
                public string StartTime { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=true)]
                public string StopTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=true)]
                public string FinishTime { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=true)]
                public string UpdateTime { get; set; }

                [NameInMap("Output")]
                [Validation(Required=true)]
                public string Output { get; set; }

                [NameInMap("ExitCode")]
                [Validation(Required=true)]
                public long? ExitCode { get; set; }

                [NameInMap("Dropped")]
                [Validation(Required=true)]
                public int? Dropped { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=true)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorInfo")]
                [Validation(Required=true)]
                public string ErrorInfo { get; set; }

            }

        }

    }

}
