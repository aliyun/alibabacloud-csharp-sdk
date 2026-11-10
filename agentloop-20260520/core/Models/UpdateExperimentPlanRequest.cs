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
        /// <para>The list of evaluators. If omitted, the list is not modified. If an empty array is passed, the list is cleared. When configured, evaluation is automatically triggered upon experiment completion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;: &quot;Builtin.agent_task_completion&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The type of the experiment. Valid values: OFFLINE (offline experiment) and ONLINE (online experiment).</para>
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
        /// <para>{&quot;question&quot;: &quot;How do I request a refund?&quot;}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// <para>The name of the associated data processing pipeline. This parameter is optional. If you do not specify this parameter, the association is not updated. If you specify an empty string, the association is removed. After the association is established, when an experiment under this plan completes and writes experiment results to a Logstore, the system filters the data by the traceId of the current experiment trace and calls PreviewPipeline to write the pipeline-processed trace results together with the experiment results.</para>
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
