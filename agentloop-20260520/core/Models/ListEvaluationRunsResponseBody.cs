// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluationRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of run summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;runId&quot;:&quot;eval-run-4fd47f3d7e684e15b1d3d178c6a5b81a&quot;,&quot;runType&quot;:&quot;backfill&quot;,&quot;status&quot;:&quot;Running&quot;,&quot;totalCount&quot;:100}]</para>
        /// </summary>
        [NameInMap("evaluationRuns")]
        [Validation(Required=false)]
        public List<ListEvaluationRunsResponseBodyEvaluationRuns> EvaluationRuns { get; set; }
        public class ListEvaluationRunsResponseBodyEvaluationRuns : TeaModel {
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
            /// <para>The end time of the data window for this run, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782902400</para>
            /// </summary>
            [NameInMap("dataEndTime")]
            [Validation(Required=false)]
            public long? DataEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the data window for this run, in seconds-level UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000</para>
            /// </summary>
            [NameInMap("dataStartTime")]
            [Validation(Required=false)]
            public long? DataStartTime { get; set; }

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

        /// <summary>
        /// <para>The number of entries per page used in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEyMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of runs that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
