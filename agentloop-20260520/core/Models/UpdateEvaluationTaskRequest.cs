// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The new task configuration. Some fields that are set during creation cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataScope&quot;:&quot;trace&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// <para>The filter condition for evaluation data. A JSON object or JSON string is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;query&quot;:&quot;serviceName=\&quot;checkout-service\&quot; AND status=\&quot;OK\&quot;&quot;,&quot;maxRecords&quot;:10,&quot;samplingRate&quot;:50}</para>
        /// </summary>
        [NameInMap("dataFilter")]
        [Validation(Required=false)]
        public string DataFilter { get; set; }

        /// <summary>
        /// <para>The description of the evaluation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的链路 Trace 任务完成度评估</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new list of evaluator configurations. When specified, this list entirely replaces the existing evaluator list of the task, and the system re-validates evaluator uniqueness and variable mappings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;,&quot;resultName&quot;:&quot;agent_task_completion&quot;,&quot;resultType&quot;:&quot;score&quot;,&quot;variableMapping&quot;:{&quot;input&quot;:&quot;trace.input&quot;,&quot;output&quot;:&quot;trace.output&quot;,&quot;agent_trajectory&quot;:&quot;trace.agent_trajectory&quot;}}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The new task execution strategies. A JSON object or JSON string is supported. If the task is in <c>Completed</c>, <c>Terminated</c>, or <c>Failed</c> status and the new strategy enables backfill or continuous mode, the backend resets the task to <c>Pending</c> and triggers orchestration.</para>
        /// </summary>
        [NameInMap("runStrategies")]
        [Validation(Required=false)]
        public RunStrategies RunStrategies { get; set; }

        /// <summary>
        /// <para>The task status. Currently the backend only allows users to explicitly set this to <c>Terminated</c>. Other statuses are managed by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminated</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The key-value pairs of task tags. You do not need to specify this parameter by default. Specify this parameter only when you want to associate or filter tasks by business tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;:&quot;prod&quot;,&quot;serviceId&quot;:&quot;checkout-service&quot;,&quot;planId&quot;:&quot;plan-20260703&quot;}</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The idempotency token. CloudSpec declares this query parameter, but the backend does not currently perform idempotency comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
