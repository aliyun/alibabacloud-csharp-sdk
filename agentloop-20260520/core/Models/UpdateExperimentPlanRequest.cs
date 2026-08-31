// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateExperimentPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benckmark_eval</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentspace-project</para>
        /// </summary>
        [NameInMap("datasetProject")]
        [Validation(Required=false)]
        public string DatasetProject { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benchmark_eval_experiment offline experiment</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of evaluators. Omitting this field indicates no modification. Passing an empty array clears the list.</para>
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
        /// <para>OFFLINE</para>
        /// </summary>
        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// <para>The list of experiment configurations. When specified, the entire list is replaced. The number of configurations must be 1 to 5.</para>
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
        /// <para>{&quot;question&quot;: &quot;How do I request a refund?&quot;}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// <para>The name of the associated data processing pipeline. This parameter is optional. If not specified, the value is not updated. If an empty character string is specified, the association is dissociated. After association, when an experiment under this plan finishes execution and writes results to the experiment result Logstore, the system filters by the traceId of the experiment trace and calls PreviewPipeline. The pipeline-processed results are then written together.</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The name of the experiment plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benchmark_eval_experiment</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The custom query SQL clause in partial dataset mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level &gt; 2</para>
        /// </summary>
        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>The list of selected data item IDs in partial dataset mode. Passing an empty array clears the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

    }

}
