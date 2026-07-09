// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluationTaskResponseBody : TeaModel {
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
        /// <para>The task source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The data source and execution configuration. Tasks with <c>dataType=trace</c> typically include <c>project</c>, <c>storeName</c>, and <c>dataScope</c> fields populated by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;project&quot;:&quot;agentspace-project&quot;,&quot;storeName&quot;:&quot;logstore-tracing&quot;,&quot;dataScope&quot;:&quot;trace&quot;}</para>
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
        /// <para>The filter conditions for evaluation data, returned by the backend as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;query&quot;:&quot;serviceName=\&quot;checkout-service\&quot;&quot;,&quot;maxRecords&quot;:10,&quot;samplingRate&quot;:100}</para>
        /// </summary>
        [NameInMap("dataFilter")]
        [Validation(Required=false)]
        public string DataFilter { get; set; }

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
        /// <para>The list of evaluator configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;,&quot;resultName&quot;:&quot;agent_task_completion&quot;,&quot;resultType&quot;:&quot;score&quot;,&quot;variableMapping&quot;:{&quot;input&quot;:&quot;trace.input&quot;,&quot;output&quot;:&quot;trace.output&quot;,&quot;agent_trajectory&quot;:&quot;trace.agent_trajectory&quot;}}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The region to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The structured configuration of the run strategy, including the parsed backfill strategy and continuous evaluation strategy.</para>
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
        /// <para>The key-value pairs of task tags. Empty if not set.</para>
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

}
