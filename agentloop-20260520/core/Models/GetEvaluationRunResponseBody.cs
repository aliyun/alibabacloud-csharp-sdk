// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluationRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time, in seconds-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The end time of the data window for the run, in seconds-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782902400</para>
        /// </summary>
        [NameInMap("dataEndTime")]
        [Validation(Required=false)]
        public long? DataEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the data window for the run, in seconds-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000</para>
        /// </summary>
        [NameInMap("dataStartTime")]
        [Validation(Required=false)]
        public long? DataStartTime { get; set; }

        /// <summary>
        /// <para>The list of progress details by evaluator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorName&quot;:&quot;Builtin.agent_task_completion&quot;,&quot;totalCount&quot;:100,&quot;successCount&quot;:96,&quot;failedCount&quot;:4}]</para>
        /// </summary>
        [NameInMap("evaluatorProgress")]
        [Validation(Required=false)]
        public List<GetEvaluationRunResponseBodyEvaluatorProgress> EvaluatorProgress { get; set; }
        public class GetEvaluationRunResponseBodyEvaluatorProgress : TeaModel {
            /// <summary>
            /// <para>The evaluator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Builtin.agent_task_completion</para>
            /// </summary>
            [NameInMap("evaluatorName")]
            [Validation(Required=false)]
            public string EvaluatorName { get; set; }

            /// <summary>
            /// <para>The number of failed entries for this evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// <para>The number of successful entries for this evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of entries for this evaluator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The evaluator configuration snapshot at the time the run was created, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evaluatorRef&quot;:&quot;Builtin.agent_task_completion&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public string Evaluators { get; set; }

        /// <summary>
        /// <para>The number of failed entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("failedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

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
        /// <para>The run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eval-run-4fd47f3d7e684e15b1d3d178c6a5b81a</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The run name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace_task_completion_eval-backfill</para>
        /// </summary>
        [NameInMap("runName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// <para>The run type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backfill</para>
        /// </summary>
        [NameInMap("runType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <para>The run status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of successful entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("successCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The evaluation task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eval-task-8b36f2e2b1f94f9c91ce7a4b0f6d9c25</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The total number of evaluation entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The update time, in seconds-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816600</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
