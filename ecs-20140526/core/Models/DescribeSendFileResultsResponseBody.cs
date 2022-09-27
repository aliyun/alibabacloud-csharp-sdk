// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeSendFileResultsResponseBodyInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeSendFileResultsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseBodyInvocationsInvocation : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileGroup")]
                [Validation(Required=false)]
                public string FileGroup { get; set; }

                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public string Overwrite { get; set; }

                [NameInMap("TargetDir")]
                [Validation(Required=false)]
                public string TargetDir { get; set; }

                [NameInMap("VmCount")]
                [Validation(Required=false)]
                public int? VmCount { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
