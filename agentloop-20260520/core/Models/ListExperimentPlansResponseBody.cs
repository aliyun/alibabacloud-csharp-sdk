// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListExperimentPlansResponseBody : TeaModel {
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
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEwMX0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of experiment plan summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;planId&quot;: &quot;exp-plan-e95bff54685a4ae29ff3a834c1008a71&quot;, &quot;planName&quot;: &quot;rca_benchmark_eval_experiment&quot;, &quot;experimentType&quot;: &quot;offline&quot;, &quot;description&quot;: &quot;&quot;, &quot;status&quot;: &quot;pending&quot;, &quot;datasetId&quot;: &quot;rca_benckmark_eval&quot;, &quot;querySql&quot;: &quot;&quot;, &quot;experimentCount&quot;: 5, &quot;createdAt&quot;: 1784612365000, &quot;updatedAt&quot;: 1784619562000}, {&quot;planId&quot;: &quot;exp-plan-0242d983f5d340fd8479cf2c19eb279e&quot;, &quot;planName&quot;: &quot;arms_agent_experiment&quot;, &quot;experimentType&quot;: &quot;online&quot;, &quot;description&quot;: &quot;&quot;, &quot;status&quot;: &quot;stopped&quot;, &quot;datasetId&quot;: &quot;arms_customer_agent_level1&quot;, &quot;querySql&quot;: &quot;&quot;, &quot;experimentCount&quot;: 4, &quot;createdAt&quot;: 1784257858000, &quot;updatedAt&quot;: 1784721811000}, {&quot;planId&quot;: &quot;b7f0ad3d-3765-446a-a744-ab64ab8bf386&quot;, &quot;planName&quot;: &quot;arms_customer_agent_plan&quot;, &quot;experimentType&quot;: &quot;offline&quot;, &quot;description&quot;: &quot;&quot;, &quot;status&quot;: &quot;stopped&quot;, &quot;datasetId&quot;: &quot;arms_customer_agent_level1&quot;, &quot;querySql&quot;: &quot;where \&quot;input\&quot; LIKE \&quot;%探针%\&quot;&quot;, &quot;experimentCount&quot;: 65, &quot;createdAt&quot;: 1782310430000, &quot;updatedAt&quot;: 1784692254000}]</para>
        /// </summary>
        [NameInMap("plans")]
        [Validation(Required=false)]
        public List<ExperimentPlanData> Plans { get; set; }

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
        /// <para>The total number of records that match the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
