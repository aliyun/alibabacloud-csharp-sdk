// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluationRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The end time of the run data window. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782902400</para>
        /// </summary>
        [NameInMap("dataEndTime")]
        [Validation(Required=false)]
        public long? DataEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the run data window. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000</para>
        /// </summary>
        [NameInMap("dataStartTime")]
        [Validation(Required=false)]
        public long? DataStartTime { get; set; }

        /// <summary>
        /// <para>The progress list by evaluator dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorName&quot;:&quot;Builtin.agent_task_completion&quot;,&quot;totalCount&quot;:100,&quot;successCount&quot;:96,&quot;failedCount&quot;:4}]</para>
        /// </summary>
        [NameInMap("evaluatorProgress")]
        [Validation(Required=false)]
        public List<GetEvaluationRunResponseBodyEvaluatorProgress> EvaluatorProgress { get; set; }
        public class GetEvaluationRunResponseBodyEvaluatorProgress : TeaModel {
            /// <summary>
            /// <para>The name of the evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Builtin.agent_task_completion</para>
            /// </summary>
            [NameInMap("evaluatorName")]
            [Validation(Required=false)]
            public string EvaluatorName { get; set; }

            /// <summary>
            /// <para>The number of failed items for the evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// <para>The number of successful items for the evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of items for the evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The snapshot of the evaluator configuration when the run is created. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public string Evaluators { get; set; }

        /// <summary>
        /// <para>The number of failed items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("failedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The snapshot of the evaluator quality scores and coverage for the current run. This field is empty if the feature is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("qualityMetrics")]
        [Validation(Required=false)]
        public Dictionary<string, object> QualityMetrics { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eval-run-4fd47f3d7e684e15b1d3d178c6a5b81a</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The name of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion_eval-backfill</para>
        /// </summary>
        [NameInMap("runName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// <para>The type of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backfill</para>
        /// </summary>
        [NameInMap("runType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <para>The status of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of successful items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("successCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The ID of the evaluation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eval-task-8b36f2e2b1f94f9c91ce7a4b0f6d9c25</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The total number of evaluated items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The update time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816600</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
