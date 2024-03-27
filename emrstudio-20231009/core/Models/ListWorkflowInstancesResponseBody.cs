// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class ListWorkflowInstancesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListWorkflowInstancesResponseBodyData> Data { get; set; }
        public class ListWorkflowInstancesResponseBodyData : TeaModel {
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("runTimes")]
            [Validation(Required=false)]
            public string RunTimes { get; set; }

            [NameInMap("scheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

            [NameInMap("workflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            [NameInMap("workflowVersion")]
            [Validation(Required=false)]
            public string WorkflowVersion { get; set; }

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
