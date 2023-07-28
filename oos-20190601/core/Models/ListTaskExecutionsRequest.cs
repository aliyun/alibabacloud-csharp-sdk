// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionsRequest : TeaModel {
        /// <summary>
        /// The execution ID of the task.
        /// </summary>
        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        /// <summary>
        /// Specifies to query task executions that stop running at or later than the specified time.
        /// </summary>
        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        /// <summary>
        /// The status of the execution. Valid values: Running, Started, Success, Failed, Waiting, Cancelled, Pending, and Skipped.
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 20 to 100. Default value: 50.
        /// </summary>
        [NameInMap("IncludeChildTaskExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildTaskExecution { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Sorts the task executions to query. Valid values:
        /// 
        /// *   **StartDate**: specifies that the task executions are sorted based on the time when they are created. This is the default value.
        /// *   **EndDate**: specifies that the task executions are sorted based on the time when the time when they stop running.
        /// *   **Status**: specifies that the task executions are sorted based on their statuses.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Specifies whether to show the child nodes in the loop task. Default value: False.
        /// </summary>
        [NameInMap("ParentTaskExecutionId")]
        [Validation(Required=false)]
        public string ParentTaskExecutionId { get; set; }

        /// <summary>
        /// The ID of the execution.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The order in which you want to sort the task executions to query. Valid values:
        /// 
        /// *   **Ascending**: ascending order.
        /// *   **Descending**: descending order. This is the default value.
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Specifies to query task executions that stop running at or before the specified time.
        /// </summary>
        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        /// <summary>
        /// Specifies to query task executions that start to run at or later than the specified time.
        /// </summary>
        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        /// <summary>
        /// Specifies to query task executions that start to run at or before the specified time.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The execution ID of the parent node. In a loop task, set this parameter to the execution ID of the parent node.
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [NameInMap("TaskExecutionId")]
        [Validation(Required=false)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// The action of the task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
