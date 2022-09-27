// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                [NameInMap("CommandType")]
                [Validation(Required=false)]
                public string CommandType { get; set; }

                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public long? ExitCode { get; set; }

                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public bool? Timed { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("Timed")]
                [Validation(Required=false)]
                public bool? Timed { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

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
