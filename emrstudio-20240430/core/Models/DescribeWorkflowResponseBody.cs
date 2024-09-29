// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>611AD6E6-BFE3-5897-AA12-569F79DBAF9B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public DescribeWorkflowResponseBodySchedule Schedule { get; set; }
        public class DescribeWorkflowResponseBodySchedule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ag-n72kong0832****</para>
            /// </summary>
            [NameInMap("alertGroupId")]
            [Validation(Required=false)]
            public string AlertGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("alertStrategy")]
            [Validation(Required=false)]
            public string AlertStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 * * * ? *</para>
            /// </summary>
            [NameInMap("cronExpr")]
            [Validation(Required=false)]
            public string CronExpr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>C-15F7AB9B53F1****</para>
            /// </summary>
            [NameInMap("emrClusterId")]
            [Validation(Required=false)]
            public string EmrClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>END</para>
            /// </summary>
            [NameInMap("failureStrategy")]
            [Validation(Required=false)]
            public string FailureStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wg-susqimrr649x****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("scheduleEndTime")]
            [Validation(Required=false)]
            public string ScheduleEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("scheduleStartTime")]
            [Validation(Required=false)]
            public string ScheduleStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("scheduleState")]
            [Validation(Required=false)]
            public string ScheduleState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MEDIUM</para>
            /// </summary>
            [NameInMap("workflowInstancePriority")]
            [Validation(Required=false)]
            public string WorkflowInstancePriority { get; set; }

        }

        [NameInMap("taskRelations")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTaskRelations> TaskRelations { get; set; }
        public class DescribeWorkflowResponseBodyTaskRelations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>t-n72kong0832****</para>
            /// </summary>
            [NameInMap("postTaskId")]
            [Validation(Required=false)]
            public string PostTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-n72kong0832****</para>
            /// </summary>
            [NameInMap("preTaskId")]
            [Validation(Required=false)]
            public string PreTaskId { get; set; }

        }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTasks> Tasks { get; set; }
        public class DescribeWorkflowResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>task description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-n72kong0832****</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("workflow")]
        [Validation(Required=false)]
        public DescribeWorkflowResponseBodyWorkflow Workflow { get; set; }
        public class DescribeWorkflowResponseBodyWorkflow : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PARALLEL</para>
            /// </summary>
            [NameInMap("executionType")]
            [Validation(Required=false)]
            public string ExecutionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wd-n72kong0832****</para>
            /// </summary>
            [NameInMap("parentDirectoryId")]
            [Validation(Required=false)]
            public string ParentDirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w-n72kong0832****</para>
            /// </summary>
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;prop&quot;:&quot;key1&quot;,&quot;value&quot;:&quot;value1&quot;}]</para>
            /// </summary>
            [NameInMap("workflowParams")]
            [Validation(Required=false)]
            public string WorkflowParams { get; set; }

        }

    }

}
