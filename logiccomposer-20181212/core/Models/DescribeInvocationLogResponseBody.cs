// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeInvocationLogResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<DescribeInvocationLogResponseBodyActions> Actions { get; set; }
        public class DescribeInvocationLogResponseBodyActions : TeaModel {
            [NameInMap("LoopCount")]
            [Validation(Required=false)]
            public int? LoopCount { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("InvocationId")]
            [Validation(Required=false)]
            public string InvocationId { get; set; }

            [NameInMap("ReturnCode")]
            [Validation(Required=false)]
            public string ReturnCode { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyActionsError Error { get; set; }
            public class DescribeInvocationLogResponseBodyActionsError : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }
            };

            [NameInMap("OutputsResult")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyActionsOutputsResult OutputsResult { get; set; }
            public class DescribeInvocationLogResponseBodyActionsOutputsResult : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }
                [NameInMap("ContentSize")]
                [Validation(Required=false)]
                public string ContentSize { get; set; }
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }
            };

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("InputsResult")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyActionsInputsResult InputsResult { get; set; }
            public class DescribeInvocationLogResponseBodyActionsInputsResult : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }
                [NameInMap("ContentSize")]
                [Validation(Required=false)]
                public string ContentSize { get; set; }
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }
            };

        }

        [NameInMap("TimeoutTime")]
        [Validation(Required=false)]
        public long? TimeoutTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Workflow")]
        [Validation(Required=false)]
        public DescribeInvocationLogResponseBodyWorkflow Workflow { get; set; }
        public class DescribeInvocationLogResponseBodyWorkflow : TeaModel {
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }
        };

        [NameInMap("InvocationError")]
        [Validation(Required=false)]
        public DescribeInvocationLogResponseBodyInvocationError InvocationError { get; set; }
        public class DescribeInvocationLogResponseBodyInvocationError : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
        };

        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public DescribeInvocationLogResponseBodyTrigger Trigger { get; set; }
        public class DescribeInvocationLogResponseBodyTrigger : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("InvocationId")]
            [Validation(Required=false)]
            public string InvocationId { get; set; }
            [NameInMap("ReturnCode")]
            [Validation(Required=false)]
            public string ReturnCode { get; set; }
            [NameInMap("Error")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyTriggerError Error { get; set; }
            public class DescribeInvocationLogResponseBodyTriggerError : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }
            [NameInMap("OutputsResult")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyTriggerOutputsResult OutputsResult { get; set; }
            public class DescribeInvocationLogResponseBodyTriggerOutputsResult : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("ContentSize")]
                [Validation(Required=false)]
                public string ContentSize { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("InputsResult")]
            [Validation(Required=false)]
            public DescribeInvocationLogResponseBodyTriggerInputsResult InputsResult { get; set; }
            public class DescribeInvocationLogResponseBodyTriggerInputsResult : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("ContentSize")]
                [Validation(Required=false)]
                public string ContentSize { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }
        };

        [NameInMap("ResponseResult")]
        [Validation(Required=false)]
        public DescribeInvocationLogResponseBodyResponseResult ResponseResult { get; set; }
        public class DescribeInvocationLogResponseBodyResponseResult : TeaModel {
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }
            [NameInMap("ContentSize")]
            [Validation(Required=false)]
            public string ContentSize { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

        [NameInMap("InvocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        [NameInMap("OutputsResult")]
        [Validation(Required=false)]
        public DescribeInvocationLogResponseBodyOutputsResult OutputsResult { get; set; }
        public class DescribeInvocationLogResponseBodyOutputsResult : TeaModel {
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }
            [NameInMap("ContentSize")]
            [Validation(Required=false)]
            public string ContentSize { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}
