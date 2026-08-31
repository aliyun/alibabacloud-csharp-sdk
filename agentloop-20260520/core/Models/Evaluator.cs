// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class Evaluator : TeaModel {
        /// <summary>
        /// <para>The runtime configuration of the evaluator. For inline LLM evaluators, this must include configurations such as prompt. When referencing an existing evaluator, this parameter is typically not required and should only be specified when runtime parameters such as version need to be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;1.0.0&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The reference name of a registered evaluator. When specified, the evaluator definition is loaded by this reference with higher priority. Both built-in evaluators and custom evaluators are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Builtin.agent_task_completion</para>
        /// </summary>
        [NameInMap("evaluatorRef")]
        [Validation(Required=false)]
        public string EvaluatorRef { get; set; }

        /// <summary>
        /// <para>The evaluator-level data filter conditions. These take effect together with the task-level dataFilter.query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;query&quot;:&quot;serviceName=\&quot;checkout-service\&quot;&quot;}</para>
        /// </summary>
        [NameInMap("filters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filters { get; set; }

        /// <summary>
        /// <para>The evaluator name. Required for inline evaluators when evaluatorRef is not specified. The evaluatorRef or name must be unique within the same task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_task_completion</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The field name for the evaluation result. Required for inline evaluators. When referencing an existing evaluator, the metricName defined in the evaluator definition is used if this parameter is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_task_completion</para>
        /// </summary>
        [NameInMap("resultName")]
        [Validation(Required=false)]
        public string ResultName { get; set; }

        /// <summary>
        /// <para>The evaluation result type. Required for inline evaluators. When referencing an existing evaluator, defaults to score if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>score</para>
        /// </summary>
        [NameInMap("resultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The evaluator type. Defaults to LLM if not specified. Inline CODE evaluators are not currently supported. For the CODE type, reference a previously created evaluator by using evaluatorRef.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The variable extraction rule mapping that maps evaluator variables to a portion of the content within an evaluation data field. This is applicable when the variable value is not the entire field but a subset of the field content. This parameter shares the same variable name key space as variableMapping. Each variable can use only one of the two. Duplicate configurations cause an error. When referencing an existing evaluator, the variable names must exist in the evaluator definition. Call ListTraceFieldExtractionsPreview to perform a trial run for validation before saving.</para>
        /// </summary>
        [NameInMap("variableExtractorMapping")]
        [Validation(Required=false)]
        public Dictionary<string, EvaluatorVariableExtractorMappingValue> VariableExtractorMapping { get; set; }

        /// <summary>
        /// <para>The variable mapping that maps evaluator variables to evaluation data fields. Required for LLM/AGENT inline evaluators. When referencing an existing evaluator, the variable names must exist in the evaluator definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input&quot;:&quot;trace.input&quot;,&quot;output&quot;:&quot;trace.output&quot;,&quot;agent_trajectory&quot;:&quot;trace.agent_trajectory&quot;}</para>
        /// </summary>
        [NameInMap("variableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> VariableMapping { get; set; }

    }

}
