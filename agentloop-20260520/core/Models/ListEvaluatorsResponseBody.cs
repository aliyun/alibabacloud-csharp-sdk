// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListEvaluatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of evaluator summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;trace_task_completion&quot;,&quot;type&quot;:&quot;AGENT&quot;,&quot;latestVersion&quot;:&quot;1.0.0&quot;}]</para>
        /// </summary>
        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<ListEvaluatorsResponseBodyEvaluators> Evaluators { get; set; }
        public class ListEvaluatorsResponseBodyEvaluators : TeaModel {
            /// <summary>
            /// <para>The list of annotation tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;__en&quot;]</para>
            /// </summary>
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public List<string> Annotations { get; set; }

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
            /// <para>The evaluator description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Determines whether the agent has completed the user task</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pipeline task completion rate</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The latest version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_task_completion</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The evaluator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace_task_completion</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The evaluator properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentEvaluatorMode&quot;:&quot;raw_prompt&quot;}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("selectable")]
            [Validation(Required=false)]
            public bool? Selectable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The evaluator type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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

        /// <summary>
        /// <para>The number of entries per page used for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEzM30=</para>
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
        /// <para>The total number of evaluators that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
