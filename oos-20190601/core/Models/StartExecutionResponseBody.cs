// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class StartExecutionResponseBody : TeaModel {
        /// <summary>
        /// The details of the execution.
        /// </summary>
        [NameInMap("Execution")]
        [Validation(Required=false)]
        public StartExecutionResponseBodyExecution Execution { get; set; }
        public class StartExecutionResponseBodyExecution : TeaModel {
            /// <summary>
            /// The number of executions.
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
            /// The information about in-progress tasks.
            /// </summary>
            [NameInMap("CurrentTasks")]
            [Validation(Required=false)]
            public List<StartExecutionResponseBodyExecutionCurrentTasks> CurrentTasks { get; set; }
            public class StartExecutionResponseBodyExecutionCurrentTasks : TeaModel {
                /// <summary>
                /// The action of the task.
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// The execution ID of the task.
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
            /// The time when the execution stopped.
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
            /// The GUID of the execution.
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// Indicates whether the execution is a parent execution.
            /// </summary>
            [NameInMap("IsParent")]
            [Validation(Required=false)]
            public bool? IsParent { get; set; }

            /// <summary>
            /// The loop mode.
            /// </summary>
            [NameInMap("LoopMode")]
            [Validation(Required=false)]
            public string LoopMode { get; set; }

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
            public string Parameters { get; set; }

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
            /// The security check mode.
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
            /// The status of the execution.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The status information of the execution.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The tags of the execution.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

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
            /// The time when the execution was last updated.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
