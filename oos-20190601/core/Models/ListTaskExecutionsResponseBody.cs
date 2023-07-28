// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionsResponseBody : TeaModel {
        /// <summary>
        /// The details of the task executions.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The execution ID of the child node.
        /// </summary>
        [NameInMap("TaskExecutions")]
        [Validation(Required=false)]
        public List<ListTaskExecutionsResponseBodyTaskExecutions> TaskExecutions { get; set; }
        public class ListTaskExecutionsResponseBodyTaskExecutions : TeaModel {
            /// <summary>
            /// The output of the execution.
            /// </summary>
            [NameInMap("ChildExecutionId")]
            [Validation(Required=false)]
            public string ChildExecutionId { get; set; }

            /// <summary>
            /// The ID of the execution.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The execution ID of the parent node.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// The action of the task.
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// The Input parameters of the task execution.
            /// </summary>
            [NameInMap("ExtraData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraData { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("Loop")]
            [Validation(Required=false)]
            public Dictionary<string, object> Loop { get; set; }

            /// <summary>
            /// The status information of the task execution.
            /// </summary>
            [NameInMap("LoopBatchNumber")]
            [Validation(Required=false)]
            public int? LoopBatchNumber { get; set; }

            /// <summary>
            /// The time when the execution was created.
            /// </summary>
            [NameInMap("LoopItem")]
            [Validation(Required=false)]
            public string LoopItem { get; set; }

            /// <summary>
            /// The status of the task.
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("ParentTaskExecutionId")]
            [Validation(Required=false)]
            public string ParentTaskExecutionId { get; set; }

            /// <summary>
            /// Queries task executions. Multiple methods are supported to filter task executions.
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// The elements in the loop task.
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// The time when the task execution stopped running.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// The execution ID of the task.
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// The time when the execution was last updated.
            /// </summary>
            [NameInMap("TaskExecutionId")]
            [Validation(Required=false)]
            public string TaskExecutionId { get; set; }

            /// <summary>
            /// The time when the execution started.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The number of times for which the loop task is run.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The configuration and statistics information of the loop task. This parameter is returned only for the parent node of the loop task.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
