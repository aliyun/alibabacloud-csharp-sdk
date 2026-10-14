// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExperimentRecord : TeaModel {
        /// <summary>
        /// <para>The completion time in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767229200000</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The number of completed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("completedTasks")]
        [Validation(Required=false)]
        public int? CompletedTasks { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values: simple, dataset-full, and dataset-partial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-full</para>
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-123456</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The SLS project where the dataset is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentspace-project</para>
        /// </summary>
        [NameInMap("datasetProject")]
        [Validation(Required=false)]
        public string DatasetProject { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model invocation timeout</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the associated evaluation task.</para>
        /// </summary>
        [NameInMap("evaluationTaskId")]
        [Validation(Required=false)]
        public string EvaluationTaskId { get; set; }

        /// <summary>
        /// <para>The list of evaluators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;Builtin.agent_correctness&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        /// <summary>
        /// <para>The execution time in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767225600000</para>
        /// </summary>
        [NameInMap("executedAt")]
        [Validation(Required=false)]
        public long? ExecutedAt { get; set; }

        /// <summary>
        /// <para>The list of experiment configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;:&quot;A&quot;,&quot;name&quot;:&quot;baseline&quot;,&quot;modelName&quot;:&quot;qwen-max&quot;}]</para>
        /// </summary>
        [NameInMap("experimentConfig")]
        [Validation(Required=false)]
        public List<ExperimentConfig> ExperimentConfig { get; set; }

        /// <summary>
        /// <para>The ID of the associated experiment plan.</para>
        /// </summary>
        [NameInMap("experimentPlanId")]
        [Validation(Required=false)]
        public string ExperimentPlanId { get; set; }

        /// <summary>
        /// <para>The number of failed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("failedTasks")]
        [Validation(Required=false)]
        public int? FailedTasks { get; set; }

        /// <summary>
        /// <para>The single-line input in SIMPLE mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;test&quot;,&quot;test2&quot;:1}</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        /// <summary>
        /// <para>The list of model names used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;qwen-max&quot;]</para>
        /// </summary>
        [NameInMap("modelNames")]
        [Validation(Required=false)]
        public List<string> ModelNames { get; set; }

        /// <summary>
        /// <para>The name of the associated experiment plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-eval</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The execution progress, ranging from 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public float? Progress { get; set; }

        /// <summary>
        /// <para>The custom query SQL clause in dataset-partial mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level &gt; 2</para>
        /// </summary>
        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>The experiment record ID.</para>
        /// </summary>
        [NameInMap("recordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The experiment record name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baseline-run</para>
        /// </summary>
        [NameInMap("recordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The list of selected data item IDs in dataset-partial mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;item-123456&quot;]</para>
        /// </summary>
        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

        /// <summary>
        /// <para>The status. Valid values: pending, running, completed, and failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalTasks")]
        [Validation(Required=false)]
        public int? TotalTasks { get; set; }

    }

}
