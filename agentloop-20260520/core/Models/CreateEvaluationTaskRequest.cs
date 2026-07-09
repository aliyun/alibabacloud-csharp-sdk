// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The task source. If this parameter is not specified, the backend uses <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The data source and execution configuration. When <c>dataType</c> is set to <c>trace</c>, the backend automatically populates the SLS Project and sets <c>storeName</c> to <c>logstore-tracing</c>. For trace-level evaluation, set <c>dataScope</c> to <c>trace</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataScope&quot;:&quot;trace&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// <para>The filter conditions for evaluation data. This parameter supports a JSON object or a JSON string. Common fields include <c>query</c>, <c>provided</c>, <c>maxRecords</c>, and <c>samplingRate</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;query&quot;:&quot;serviceName=\&quot;checkout-service\&quot;&quot;,&quot;maxRecords&quot;:10,&quot;samplingRate&quot;:100}</para>
        /// </summary>
        [NameInMap("dataFilter")]
        [Validation(Required=false)]
        public string DataFilter { get; set; }

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
        /// <para>The description of the evaluation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>评估线上 Agent 链路任务完成度</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of evaluator configurations. This parameter cannot be empty. Within the same task, <c>evaluatorRef</c> takes precedence as the unique identifier. Otherwise, <c>name</c> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;,&quot;resultName&quot;:&quot;agent_task_completion&quot;,&quot;resultType&quot;:&quot;score&quot;,&quot;variableMapping&quot;:{&quot;input&quot;:&quot;trace.input&quot;,&quot;output&quot;:&quot;trace.output&quot;,&quot;agent_trajectory&quot;:&quot;trace.agent_trajectory&quot;}}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The task execution strategy. This parameter supports a JSON object or a JSON string. Set this parameter to <c>backfill</c> for historical data backfill or <c>continuous</c> for continuous evaluation of new data.</para>
        /// </summary>
        [NameInMap("runStrategies")]
        [Validation(Required=false)]
        public RunStrategies RunStrategies { get; set; }

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
        /// <para>The evaluation task mode. Set this parameter to <c>batch</c> to create a persistent evaluation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("taskMode")]
        [Validation(Required=false)]
        public string TaskMode { get; set; }

        /// <summary>
        /// <para>The task name. The name must be unique among non-deleted tasks within the same user and AgentSpace. The name can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion_eval</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The idempotency token. This query parameter is declared in CloudSpec, but the backend does not currently perform idempotency comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
