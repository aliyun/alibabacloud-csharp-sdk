// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The execution ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        /// <summary>
        /// <para>Specifies to query task executions that stop running at or later than the specified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        /// <summary>
        /// <para>The status of the execution. Valid values: Running, Started, Success, Failed, Waiting, Cancelled, Pending, and Skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-xxx</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 20 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeChildTaskExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildTaskExecution { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Sorts the task executions to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>StartDate</b>: specifies that the task executions are sorted based on the time when they are created. This is the default value.</description></item>
        /// <item><description><b>EndDate</b>: specifies that the task executions are sorted based on the time when the time when they stop running.</description></item>
        /// <item><description><b>Status</b>: specifies that the task executions are sorted based on their statuses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ3NjFENDdB</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to show the child nodes in the loop task. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-exec-xxx</para>
        /// </summary>
        [NameInMap("ParentTaskExecutionId")]
        [Validation(Required=false)]
        public string ParentTaskExecutionId { get; set; }

        /// <summary>
        /// <para>The ID of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the task executions to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ascending</b>: ascending order.</description></item>
        /// <item><description><b>Descending</b>: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StartDate</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Specifies to query task executions that stop running at or before the specified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        /// <summary>
        /// <para>Specifies to query task executions that start to run at or later than the specified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        /// <summary>
        /// <para>Specifies to query task executions that start to run at or before the specified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The execution ID of the parent node. In a loop task, set this parameter to the execution ID of the parent node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::Sleep</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-exec-xxx</para>
        /// </summary>
        [NameInMap("TaskExecutionId")]
        [Validation(Required=false)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// <para>The action of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>describeInstance</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
