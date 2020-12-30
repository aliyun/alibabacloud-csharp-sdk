// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowJobHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("NodeInstances")]
        [Validation(Required=false)]
        public ListFlowJobHistoryResponseBodyNodeInstances NodeInstances { get; set; }
        public class ListFlowJobHistoryResponseBodyNodeInstances : TeaModel {
            [NameInMap("NodeInstance")]
            [Validation(Required=false)]
            public List<ListFlowJobHistoryResponseBodyNodeInstancesNodeInstance> NodeInstance { get; set; }
            public class ListFlowJobHistoryResponseBodyNodeInstancesNodeInstance : TeaModel {
                public string Type { get; set; }
                public string Status { get; set; }
                public bool? Pending { get; set; }
                public string EnvConf { get; set; }
                public long? RetryInterval { get; set; }
                public string ProjectId { get; set; }
                public string JobType { get; set; }
                public long? GmtModified { get; set; }
                public string ExternalInfo { get; set; }
                public string ExternalStatus { get; set; }
                public string JobName { get; set; }
                public string ExternalId { get; set; }
                public string ClusterId { get; set; }
                public int? MaxRetry { get; set; }
                public string FailAct { get; set; }
                public string JobParams { get; set; }
                public string ParamConf { get; set; }
                public string HostName { get; set; }
                public int? Retries { get; set; }
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public string RunConf { get; set; }
                public string NodeName { get; set; }
                public string JobId { get; set; }
                public long? GmtCreate { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
