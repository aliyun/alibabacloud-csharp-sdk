// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The AgentSpace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-agentspace</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The filter condition for the task source. If this parameter is not specified, tasks from the default source are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The data source type of the evaluation object. Set this parameter to <c>trace</c> for trace-based evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
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
        /// <para>The evaluation task mode. If this parameter is not specified, the default value is <c>batch</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("taskMode")]
        [Validation(Required=false)]
        public string TaskMode { get; set; }

        /// <summary>
        /// <para>The fuzzy match condition for the task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion_eval</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
