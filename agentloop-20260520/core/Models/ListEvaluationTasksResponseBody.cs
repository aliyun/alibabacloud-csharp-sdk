// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of evaluation task summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;taskId&quot;:&quot;eval-task-8b36f2e2b1f94f9c91ce7a4b0f6d9c25&quot;,&quot;taskName&quot;:&quot;trace_task_completion_eval&quot;,&quot;taskMode&quot;:&quot;batch&quot;,&quot;dataType&quot;:&quot;trace&quot;,&quot;status&quot;:&quot;Running&quot;}]</para>
        /// </summary>
        [NameInMap("evaluationTasks")]
        [Validation(Required=false)]
        public List<ListEvaluationTasksResponseBodyEvaluationTasks> EvaluationTasks { get; set; }
        public class ListEvaluationTasksResponseBodyEvaluationTasks : TeaModel {
            /// <summary>
            /// <para>The data source and execution configuration summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;storeName&quot;:&quot;logstore-tracing&quot;,&quot;dataScope&quot;:&quot;trace&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }

            /// <summary>
            /// <para>The creation time, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The data source type of the evaluation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace</para>
            /// </summary>
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The evaluation task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>评估线上 Agent 链路任务完成度</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The evaluator configuration summary, in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;}]</para>
            /// </summary>
            [NameInMap("evaluators")]
            [Validation(Required=false)]
            public string Evaluators { get; set; }

            /// <summary>
            /// <para>The structured run strategy configuration, including the parsed backfill strategy and continuous evaluation strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;backfill&quot;:{&quot;enabled&quot;:true,&quot;startTime&quot;:1782816000000,&quot;endTime&quot;:1782902400000},&quot;continuous&quot;:{&quot;enabled&quot;:true,&quot;intervalUnit&quot;:&quot;HOUR&quot;,&quot;intervalValue&quot;:1,&quot;dataDelayMinutes&quot;:5}}</para>
            /// </summary>
            [NameInMap("runStrategyConfig")]
            [Validation(Required=false)]
            public RunStrategies RunStrategyConfig { get; set; }

            /// <summary>
            /// <para>The evaluation task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The key-value pairs of task tags. This parameter is empty if no tags are set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;serviceId&quot;:&quot;checkout-service&quot;,&quot;env&quot;:&quot;prod&quot;}</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>The evaluation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eval-task-8b36f2e2b1f94f9c91ce7a4b0f6d9c25</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The evaluation task mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>batch</para>
            /// </summary>
            [NameInMap("taskMode")]
            [Validation(Required=false)]
            public string TaskMode { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace_task_completion_eval</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The last update time, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816600</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page used in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEwMSwib2Zmc2V0IjoyMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records. The total count is returned only on the first page. This value may be empty on subsequent pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>126</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
