// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetExperimentPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time, in millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The associated dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_customer_agent_level1</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>对比 checkout Agent 基线与优化版本</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of evaluators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;: &quot;Builtin.agent_task_completion&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The experiment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// <para>The list of experiment configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;: &quot;A&quot;, &quot;name&quot;: &quot;baseline&quot;, &quot;modelName&quot;: &quot;qwen-max&quot;}]</para>
        /// </summary>
        [NameInMap("experiments")]
        [Validation(Required=false)]
        public List<ExperimentConfig> Experiments { get; set; }

        /// <summary>
        /// <para>Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;question&quot;: &quot;如何退款？&quot;}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// <para>The experiment plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-plan-0242d983f5d340fd8479cf2c19eb279e</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The experiment plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_agent_experiment</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The custom query SQL clause in partial dataset mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status=\&quot;OK\&quot;</para>
        /// </summary>
        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

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
        /// <para>The list of selected data item IDs in partial dataset mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;019ef4d5-a0f0-7114-832d-5542d771cd8c&quot;]</para>
        /// </summary>
        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

        /// <summary>
        /// <para>The plan status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stopped</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time, in millisecond Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816600000</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
