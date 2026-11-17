// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkItemRunSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>The common business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution summaries generated for the current plan and current turn. Previous summaries are not returned until new summaries are generated for affected nodes that are re-run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;attemptId&quot;:&quot;attempt_1&quot;,&quot;planId&quot;:&quot;plan_v3&quot;,&quot;nodeKey&quot;:&quot;query.amount&quot;,&quot;nodeStatus&quot;:&quot;COMPLETED&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetWorkItemRunSummariesResponseBodyItems> Items { get; set; }
        public class GetWorkItemRunSummariesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the node attempt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attempt_1</para>
            /// </summary>
            [NameInMap("attemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>The sequence number of the node attempt, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attemptSeq")]
            [Validation(Required=false)]
            public long? AttemptSeq { get; set; }

            /// <summary>
            /// <para>The ID of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// <para>The name of the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales Analysis Assistant</para>
            /// </summary>
            [NameInMap("executorName")]
            [Validation(Required=false)]
            public string ExecutorName { get; set; }

            /// <summary>
            /// <para>The executor type, such as AGENT or HUMAN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("executorType")]
            [Validation(Required=false)]
            public string ExecutorType { get; set; }

            /// <summary>
            /// <para>The end time of the node, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:05:00Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The node key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeKey")]
            [Validation(Required=false)]
            public string NodeKey { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query sales amount</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node status, such as COMPLETED or FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("nodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>The ID of the associated physical plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan_v3</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The execution result of the node, as a JSON object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;rows&quot;:3}</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public object Result { get; set; }

            /// <summary>
            /// <para>The content of the execution summary. This field is empty if the summary is not generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed the sales amount query, returning a total of 3 rows of data</para>
            /// </summary>
            [NameInMap("runSummary")]
            [Validation(Required=false)]
            public object RunSummary { get; set; }

            /// <summary>
            /// <para>The reason for the execution summary failure. This field is empty if the generation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Model invocation timed out</para>
            /// </summary>
            [NameInMap("runSummaryError")]
            [Validation(Required=false)]
            public string RunSummaryError { get; set; }

            /// <summary>
            /// <para>The generation time of the execution summary, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:06:00Z</para>
            /// </summary>
            [NameInMap("runSummaryGeneratedAt")]
            [Validation(Required=false)]
            public string RunSummaryGeneratedAt { get; set; }

            /// <summary>
            /// <para>The list of data sources referenced in the execution summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;report.md&quot;}]</para>
            /// </summary>
            [NameInMap("runSummarySources")]
            [Validation(Required=false)]
            public List<object> RunSummarySources { get; set; }

            /// <summary>
            /// <para>The generation status of the execution summary, such as COMPLETED, FAILED, or PROCESSING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("runSummaryStatus")]
            [Validation(Required=false)]
            public string RunSummaryStatus { get; set; }

            /// <summary>
            /// <para>The list of tools used in the execution summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;SKILL&quot;,&quot;name&quot;:&quot;sql_query&quot;}]</para>
            /// </summary>
            [NameInMap("runSummaryTools")]
            [Validation(Required=false)]
            public List<GetWorkItemRunSummariesResponseBodyItemsRunSummaryTools> RunSummaryTools { get; set; }
            public class GetWorkItemRunSummariesResponseBodyItemsRunSummaryTools : TeaModel {
                /// <summary>
                /// <para>The name of the tool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales Analysis Assistant</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tool type, such as SKILL or MCP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The start time of the node, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:00:00Z</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <para>The sequence number of the node turn, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("turnSeq")]
            [Validation(Required=false)]
            public long? TurnSeq { get; set; }

        }

        /// <summary>
        /// <para>The common error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
