// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeWorkflowResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public DescribeWorkflowResponseBodySchedule Schedule { get; set; }
        public class DescribeWorkflowResponseBodySchedule : TeaModel {
            [NameInMap("alertGroupId")]
            [Validation(Required=false)]
            public string AlertGroupId { get; set; }

            [NameInMap("alertStrategy")]
            [Validation(Required=false)]
            public string AlertStrategy { get; set; }

            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            [NameInMap("emrClusterId")]
            [Validation(Required=false)]
            public string EmrClusterId { get; set; }

            [NameInMap("failureStrategy")]
            [Validation(Required=false)]
            public string FailureStrategy { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("scheduleEndTime")]
            [Validation(Required=false)]
            public string ScheduleEndTime { get; set; }

            [NameInMap("scheduleStartTime")]
            [Validation(Required=false)]
            public string ScheduleStartTime { get; set; }

            [NameInMap("scheduleState")]
            [Validation(Required=false)]
            public string ScheduleState { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            [NameInMap("workflowInstancePriority")]
            [Validation(Required=false)]
            public string WorkflowInstancePriority { get; set; }

        }

        [NameInMap("taskRelations")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTaskRelations> TaskRelations { get; set; }
        public class DescribeWorkflowResponseBodyTaskRelations : TeaModel {
            [NameInMap("postTaskId")]
            [Validation(Required=false)]
            public string PostTaskId { get; set; }

            [NameInMap("preTaskId")]
            [Validation(Required=false)]
            public string PreTaskId { get; set; }

        }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTasks> Tasks { get; set; }
        public class DescribeWorkflowResponseBodyTasks : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("workflow")]
        [Validation(Required=false)]
        public DescribeWorkflowResponseBodyWorkflow Workflow { get; set; }
        public class DescribeWorkflowResponseBodyWorkflow : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("executionType")]
            [Validation(Required=false)]
            public string ExecutionType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentDirectoryId")]
            [Validation(Required=false)]
            public string ParentDirectoryId { get; set; }

            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

            [NameInMap("workflowParams")]
            [Validation(Required=false)]
            public string WorkflowParams { get; set; }

        }

    }

}
