// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of aggregation task group IDs. The value must be a JSON-parsable string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;aggTaskGroup-xxx&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupIds")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupIds { get; set; }

        /// <summary>
        /// <para>The list of aggregation task group names. The value must be a JSON-parsable string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;apiserver_request_total&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupNames")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupNames { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28036394xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name to search for. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The status of the aggregation task group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Stopped</description></item>
        /// </list>
        /// <para>Default value: Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The resource group tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the target Managed Service for Prometheus instance for the aggregation node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

    }

}
