// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListExperimentRunsRequest : TeaModel {
        /// <summary>
        /// <para>Filters results by exact dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_customer_agent_level1</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>Filters results by fuzzy match on the experiment configuration name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experimentA</para>
        /// </summary>
        [NameInMap("experimentName")]
        [Validation(Required=false)]
        public string ExperimentName { get; set; }

        /// <summary>
        /// <para>Optional. Use <c>page</c> and <c>pageSize</c> for pagination instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Optional. Use <c>page</c> and <c>pageSize</c> for pagination instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlIjoxfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number, starting from 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters results by fuzzy match on experiment plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_agent_experiment</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>Filters results by status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>evaluating</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
