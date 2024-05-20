// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class ListWorkflowInstancesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListWorkflowInstancesResponseBodyData> Data { get; set; }
        public class ListWorkflowInstancesResponseBodyData : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("scheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

            [NameInMap("workflowInstanceId")]
            [Validation(Required=false)]
            public string WorkflowInstanceId { get; set; }

            [NameInMap("workflowVersion")]
            [Validation(Required=false)]
            public int? WorkflowVersion { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
