// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsRequest : TeaModel {
        /// <summary>
        /// 执行的模板类型列表。可分为Other、TimerTrigger、EventTrigger、AlarmTrigger。此参数和Categories参数只能同时传入一个，推荐使用Categories。
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// The type of the execution template. Valid values: Other, TimerTrigger, EventTrigger, and AlarmTrigger.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 执行的深度，可分为RootDepth、FirstChildDepth
        /// RootDepth只返回主执行，FirstChildDepth只返回第一层的子执行。此参数和IncludeChildExecution参数只能同时传入一个，推荐使用Depth。
        /// </summary>
        [NameInMap("Depth")]
        [Validation(Required=false)]
        public string Depth { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The earliest end time. The executions that stop running at or later than the specified time are queried.
        /// </summary>
        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        /// <summary>
        /// The latest end time. The executions that stop running at or earlier than the specified time are queried.
        /// </summary>
        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        /// <summary>
        /// The executor.
        /// </summary>
        [NameInMap("ExecutedBy")]
        [Validation(Required=false)]
        public string ExecutedBy { get; set; }

        /// <summary>
        /// The ID of the execution.
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Specifies whether to include child executions. Default value: False.
        /// </summary>
        [NameInMap("IncludeChildExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildExecution { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 10 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The execution mode. Valid values:
        /// 
        /// *   **Automatic**
        /// *   **Debug**
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the parent execution.
        /// </summary>
        [NameInMap("ParentExecutionId")]
        [Validation(Required=false)]
        public string ParentExecutionId { get; set; }

        /// <summary>
        /// The RAM role.
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instances you want to query belong.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the Elastic Compute Service (ECS) resource.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The name of the resource template.
        /// </summary>
        [NameInMap("ResourceTemplateName")]
        [Validation(Required=false)]
        public string ResourceTemplateName { get; set; }

        /// <summary>
        /// The field that is used to sort the executions to query. Valid values:
        /// 
        /// *   **StartDate**: specifies that the executions are sorted based on the time when they are created. This is the default value.
        /// *   **EndDate**: specifies that the executions are sorted based on the time when they stop running.
        /// *   **Status**: specifies that the executions are sorted based on their states.
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// The order in which you want to sort the results. Valid values:
        /// 
        /// *   **Ascending**: ascending order.
        /// *   **Descending**: descending order. This is the default value.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// The earliest start time. The executions that start to run at or later than the specified time are queried.
        /// </summary>
        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        /// <summary>
        /// The latest start time. The executions that start to run at or earlier than the specified point in time are queried.
        /// </summary>
        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        /// <summary>
        /// The status of the execution. Valid values: Running, Started, Success, Failed, Waiting, Cancelled, Pending, and Skipped.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags for the execution.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// The name of the template. All templates whose names contain the specified template name are queried.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
