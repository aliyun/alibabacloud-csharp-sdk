// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("Invocations")]
        [Validation(Required=true)]
        public DescribeSendFileResultsResponseInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=true)]
            public List<DescribeSendFileResultsResponseInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseInvocationsInvocation : TeaModel {
                public string InvokeId { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string TargetDir { get; set; }
                public string ContentType { get; set; }
                public string Content { get; set; }
                public string FileOwner { get; set; }
                public string FileGroup { get; set; }
                public string FileMode { get; set; }
                public string Overwrite { get; set; }
                public int? VmCount { get; set; }
                public string CreationTime { get; set; }
                public string InvocationStatus { get; set; }
                public DescribeSendFileResultsResponseInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeSendFileResultsResponseInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=true)]
                    public List<DescribeSendFileResultsResponseInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeSendFileResultsResponseInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        [NameInMap("InstanceId")]
                        [Validation(Required=true)]
                        public string InstanceId { get; set; }

                        [NameInMap("InvocationStatus")]
                        [Validation(Required=true)]
                        public string InvocationStatus { get; set; }

                        [NameInMap("CreationTime")]
                        [Validation(Required=true)]
                        public string CreationTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=true)]
                        public string StartTime { get; set; }

                        [NameInMap("FinishTime")]
                        [Validation(Required=true)]
                        public string FinishTime { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=true)]
                        public string UpdateTime { get; set; }

                        [NameInMap("ErrorCode")]
                        [Validation(Required=true)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorInfo")]
                        [Validation(Required=true)]
                        public string ErrorInfo { get; set; }

                    }

                }
            }
        };

    }

}
