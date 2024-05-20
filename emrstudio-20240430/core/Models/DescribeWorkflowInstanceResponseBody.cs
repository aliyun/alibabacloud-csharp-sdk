// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeWorkflowInstanceResponseBody : TeaModel {
        [NameInMap("alertGroupId")]
        [Validation(Required=false)]
        public string AlertGroupId { get; set; }

        [NameInMap("alertStrategy")]
        [Validation(Required=false)]
        public string AlertStrategy { get; set; }

        [NameInMap("emrClusterId")]
        [Validation(Required=false)]
        public string EmrClusterId { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("failureStrategy")]
        [Validation(Required=false)]
        public string FailureStrategy { get; set; }

        [NameInMap("isComplementData")]
        [Validation(Required=false)]
        public bool? IsComplementData { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("restartTime")]
        [Validation(Required=false)]
        public string RestartTime { get; set; }

        [NameInMap("runTimes")]
        [Validation(Required=false)]
        public int? RunTimes { get; set; }

        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        [NameInMap("workflowInstanceId")]
        [Validation(Required=false)]
        public string WorkflowInstanceId { get; set; }

        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        [NameInMap("workflowVersion")]
        [Validation(Required=false)]
        public int? WorkflowVersion { get; set; }

    }

}
