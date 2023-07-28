// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsResponseBody : TeaModel {
        /// <summary>
        /// The details of the task executions.
        /// </summary>
        [NameInMap("Executions")]
        [Validation(Required=false)]
        public List<ListExecutionsResponseBodyExecutions> Executions { get; set; }
        public class ListExecutionsResponseBodyExecutions : TeaModel {
            /// <summary>
            /// The type of the execution template. Valid values: Other, TimerTrigger, EventTrigger, and AlarmTrigger.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The number of tasks that are counted by execution status.
            /// </summary>
            [NameInMap("Counters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Counters { get; set; }

            /// <summary>
            /// The time when the execution was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The information about the tasks that are running.
            /// </summary>
            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<ListExecutionsResponseBodyExecutionsCurrentTasks> CurrentTasks { get; set; }
            public class ListExecutionsResponseBodyExecutionsCurrentTasks : TeaModel {
                /// <summary>
                /// The execution template of the task.
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// The ID of the task execution.
                /// </summary>
                [NameInMap("TaskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

                /// <summary>
                /// The name of the task.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// The description of the execution.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the execution stops running.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The account ID of the user who started the execution of the template.
            /// </summary>
            [NameInMap("ExecutedBy")]
            [Validation(Required=false)]
            public string ExecutedBy { get; set; }

            /// <summary>
            /// The unique ID of the execution.
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// Indicates whether the execution contains child executions.
            /// </summary>
            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }

            /// <summary>
            /// The time when the template was last successfully triggered.
            /// </summary>
            [NameInMap("LastSuccessfulTriggerTime")]
            [Validation(Required=false)]
            public string LastSuccessfulTriggerTime { get; set; }

            [NameInMap("LastTriggerOutputs")]
            [Validation(Required=false)]
            public string LastTriggerOutputs { get; set; }

            /// <summary>
            /// The status of the execution after the template was last triggered.
            /// </summary>
            [NameInMap("LastTriggerStatus")]
            [Validation(Required=false)]
            public string LastTriggerStatus { get; set; }

            [NameInMap("LastTriggerStatusMessage")]
            [Validation(Required=false)]
            public string LastTriggerStatusMessage { get; set; }

            /// <summary>
            /// The time when the template was last successfully triggered.
            /// </summary>
            [NameInMap("LastTriggerTime")]
            [Validation(Required=false)]
            public string LastTriggerTime { get; set; }

            /// <summary>
            /// The execution mode.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The output of the execution.
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// The input parameters of the execution.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            /// <summary>
            /// The ID of the parent execution.
            /// </summary>
            [NameInMap("ParentExecutionId")]
            [Validation(Required=false)]
            public string ParentExecutionId { get; set; }

            /// <summary>
            /// The role that started the execution of the template.
            /// </summary>
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the resource.
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// The security check mode. Valid values: Skip, and ConfirmEveryHighRiskAction.
            /// </summary>
            [NameInMap("SafetyCheck")]
            [Validation(Required=false)]
            public string SafetyCheck { get; set; }

            /// <summary>
            /// The time when the execution was started.
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// The status of the execution. Valid values: Started, Queued, Running, Waiting, Success, Failed, and Cancelled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The status of the task execution.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The reason for which the status occurs.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The tags of the execution.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// The target resource.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public string Targets { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The name of the template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The version number of the template.
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// The time when the execution was updated.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// The Waiting state.
            /// </summary>
            [NameInMap("WaitingStatus")]
            [Validation(Required=false)]
            public string WaitingStatus { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
