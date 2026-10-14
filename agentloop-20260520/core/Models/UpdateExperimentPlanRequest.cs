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
        /// <para>The list of evaluators. If this parameter is omitted, the list remains unchanged. If an empty array is passed, the list is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;: &quot;Builtin.agent_task_completion&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The experiment type. Valid values: OFFLINE (offline experiment) and ONLINE (online experiment).</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFFLINE</para>
        /// </summary>
        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// <para>The list of experiment configurations. When passed, the entire list is replaced. The number of items must be between 1 and 5.</para>
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
        /// <para>{&quot;question&quot;: &quot;How do I get a refund?&quot;}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// <para>The name of the associated data processing pipeline. This parameter is optional. If it is not passed, the association is not updated. If an empty character string is passed, the pipeline is dissociated. After the association is configured, when an experiment under this plan executes and completes writing the experiment results to the Logstore, the system filters the results by the traceId of the current experiment trace and invokes PreviewPipeline to write the results processed by the pipeline.</para>
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
        /// <para>The list of selected data item IDs in partial dataset mode. If an empty array is passed, the list is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

    }

}
