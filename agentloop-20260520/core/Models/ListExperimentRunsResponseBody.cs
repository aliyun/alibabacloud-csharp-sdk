// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListExperimentRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlIjoxfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of experiment run records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;recordId&quot;: &quot;exp-run-f6d419b0ed3d43a7b585948a55efc07b&quot;, &quot;experimentPlanId&quot;: &quot;exp-plan-0242d983f5d340fd8479cf2c19eb279e&quot;, &quot;recordName&quot;: &quot;arms_agent_experiment 2026/07/22 20:02:55&quot;, &quot;planName&quot;: &quot;arms_agent_experiment&quot;, &quot;status&quot;: &quot;evaluating&quot;, &quot;progress&quot;: 100.0, &quot;totalTasks&quot;: 40, &quot;completedTasks&quot;: 40, &quot;failedTasks&quot;: 0, &quot;dataSourceType&quot;: &quot;dataset-full&quot;, &quot;datasetId&quot;: &quot;arms_customer_agent_level1&quot;, &quot;modelNames&quot;: [&quot;qwen3.7-plus&quot;, &quot;qwen3.7-max&quot;], &quot;evaluationTaskId&quot;: &quot;eval-task-6bec93bfa03740dd86ce2bf1496e65fb&quot;, &quot;executedAt&quot;: 1784721775379, &quot;completedAt&quot;: 1784721811392}, {&quot;recordId&quot;: &quot;a5397261-6e6d-4e45-bf52-feb8686f7524&quot;, &quot;experimentPlanId&quot;: &quot;exp-plan-e95bff54685a4ae29ff3a834c1008a71&quot;, &quot;recordName&quot;: &quot;rca_benchmark_eval_experiment 2026/07/22 19:23:59&quot;, &quot;planName&quot;: &quot;rca_benchmark_eval_experiment&quot;, &quot;status&quot;: &quot;completed&quot;, &quot;progress&quot;: 100.0, &quot;totalTasks&quot;: 20, &quot;completedTasks&quot;: 20, &quot;failedTasks&quot;: 0, &quot;dataSourceType&quot;: &quot;dataset-full&quot;, &quot;datasetId&quot;: &quot;rca_benckmark_eval&quot;, &quot;modelNames&quot;: [], &quot;evaluationTaskId&quot;: &quot;eval-task-b1395b3bdf3e4dc994d7dcde7a66da45&quot;, &quot;executedAt&quot;: 1784719439255, &quot;completedAt&quot;: 1784719989371}]</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ExperimentRecord> Records { get; set; }

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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
