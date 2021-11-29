// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowNodeInstanceResponseBody : TeaModel {
        [NameInMap("FlowNodeInstances")]
        [Validation(Required=false)]
        public ListFlowNodeInstanceResponseBodyFlowNodeInstances FlowNodeInstances { get; set; }
        public class ListFlowNodeInstanceResponseBodyFlowNodeInstances : TeaModel {
            [NameInMap("FlowNodeInstance")]
            [Validation(Required=false)]
            public List<ListFlowNodeInstanceResponseBodyFlowNodeInstancesFlowNodeInstance> FlowNodeInstance { get; set; }
            public class ListFlowNodeInstanceResponseBodyFlowNodeInstancesFlowNodeInstance : TeaModel {
                public string ClusterId { get; set; }
                public long? Duration { get; set; }
                public long? EndTime { get; set; }
                public string ExternalChildIds { get; set; }
                public string ExternalId { get; set; }
                public string ExternalInfo { get; set; }
                public string ExternalStatus { get; set; }
                public string ExternalSubId { get; set; }
                public string FailAct { get; set; }
                public string FlowId { get; set; }
                public string FlowInstanceId { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string HostName { get; set; }
                public string Id { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string JobParams { get; set; }
                public string JobType { get; set; }
                public string MaxRetry { get; set; }
                public string NodeName { get; set; }
                public bool? Pending { get; set; }
                public string ProjectId { get; set; }
                public int? Retries { get; set; }
                public string RetryInterval { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
