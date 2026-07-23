// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateExperimentPlanRequest : TeaModel {
        /// <summary>
        /// <para>The associated dataset ID. If this parameter is not specified, the execution phase processes in simple mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benckmark_eval</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description of the experiment plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benchmark_eval_experiment offline experiment.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The evaluator list. If configured, evaluation is automatically triggered when the experiment completes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;: &quot;Builtin.agent_correctness&quot;, &quot;name&quot;: &quot;Builtin.agent_correctness&quot;, &quot;type&quot;: &quot;AGENT&quot;, &quot;resultName&quot;: &quot;Builtin.agent_correctness&quot;, &quot;resultType&quot;: &quot;score&quot;, &quot;variableMapping&quot;: {&quot;input&quot;: &quot;experiment_input&quot;, &quot;output&quot;: &quot;experiment_output&quot;, &quot;expected_output&quot;: &quot;dataset.ground_truth_json&quot;}, &quot;filters&quot;: {&quot;query&quot;: &quot;&quot;, &quot;sample&quot;: &quot;100&quot;}, &quot;config&quot;: {&quot;variables&quot;: [], &quot;prompt&quot;: &quot;&quot;}}, {&quot;evaluatorRef&quot;: &quot;rca-toxicity-safety-accuracy&quot;, &quot;name&quot;: &quot;rca-toxicity-safety-accuracy&quot;, &quot;type&quot;: &quot;AGENT&quot;, &quot;resultName&quot;: &quot;rca-toxicity-safety-accuracy&quot;, &quot;resultType&quot;: &quot;score&quot;, &quot;variableMapping&quot;: {&quot;input&quot;: &quot;experiment_input&quot;, &quot;output&quot;: &quot;experiment_output&quot;, &quot;question&quot;: &quot;dataset.question&quot;, &quot;expected_output&quot;: &quot;dataset.ground_truth_json&quot;, &quot;payload_json&quot;: &quot;dataset.payload_json&quot;}, &quot;filters&quot;: {&quot;query&quot;: &quot;&quot;, &quot;sample&quot;: &quot;100&quot;}, &quot;config&quot;: {&quot;variables&quot;: [], &quot;prompt&quot;: &quot;&quot;}}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The experiment type. Set this parameter to <c>OFFLINE</c> or <c>ONLINE</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFFLINE</para>
        /// </summary>
        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// <para>The experiment configuration list. A maximum of 5 entries are supported. For offline experiments, this parameter can be omitted or set to an empty array. For online experiments, at least one entry is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;: &quot;A&quot;, &quot;name&quot;: &quot;experimentA&quot;, &quot;modelName&quot;: &quot;qwen3.7-plus&quot;, &quot;modelProvider&quot;: &quot;dashscope&quot;, &quot;modelParameters&quot;: {&quot;temperature&quot;: 0.7, &quot;topP&quot;: 0.8, &quot;presencePenalty&quot;: 0.0, &quot;frequencyPenalty&quot;: 0.0}, &quot;promptTemplate&quot;: [{&quot;role&quot;: &quot;system&quot;, &quot;content&quot;: &quot;You are an Alibaba Cloud ARMS product Q&amp;A bot&quot;}, {&quot;role&quot;: &quot;user&quot;, &quot;content&quot;: &quot;{{input}}&quot;}]}, {&quot;label&quot;: &quot;B&quot;, &quot;name&quot;: &quot;experimentB&quot;, &quot;modelName&quot;: &quot;qwen3.7-max&quot;, &quot;modelProvider&quot;: &quot;dashscope&quot;, &quot;modelParameters&quot;: {&quot;temperature&quot;: 0.7, &quot;topP&quot;: 0.8, &quot;presencePenalty&quot;: 0.0, &quot;frequencyPenalty&quot;: 0.0}, &quot;promptTemplate&quot;: [{&quot;role&quot;: &quot;system&quot;, &quot;content&quot;: &quot;You are an Alibaba Cloud ARMS product Q&amp;A bot&quot;}, {&quot;role&quot;: &quot;user&quot;, &quot;content&quot;: &quot;{{input}}&quot;}]}]</para>
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
        /// <para>The experiment plan name. The name must be unique within the same AgentSpace under the same account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benchmark_eval_experiment</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The custom query SQL clause in partial dataset mode. This parameter can be used when <c>selectedItemIds</c> is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status=\&quot;OK\&quot;</para>
        /// </summary>
        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>The list of selected data item IDs in partial dataset mode. Use this parameter together with <c>datasetId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;019ef4d5-a0f0-7114-832d-5542d771cd8c&quot;, &quot;019f1729-be9b-7769-a006-8e98023ad7ad&quot;]</para>
        /// </summary>
        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

    }

}
