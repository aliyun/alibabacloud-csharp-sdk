// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-agentspace</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The filter condition for the task source. If not specified, tasks from the default source are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The data source type of the evaluation object. Use trace for trace evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. The default value is 20, and the maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page, obtained from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEyMywib2Zmc2V0IjoyMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The filter condition for the evaluation task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The mode of the evaluation task. If not specified, the backend defaults to batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("taskMode")]
        [Validation(Required=false)]
        public string TaskMode { get; set; }

        /// <summary>
        /// <para>The fuzzy search condition for the task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion_eval</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
