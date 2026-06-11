// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of aggregation task group IDs. The value must be a string that can be parsed as a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;aggTaskGroup-xxx&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupIds")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupIds { get; set; }

        /// <summary>
        /// <para>A list of aggregation task group names. The value must be a string that can be parsed as a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;apiserver_request_total&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupNames")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupNames { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28036394xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name to search for. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The status of the aggregation task group. Valid values are \<c>Running\\</c> and \<c>Stopped\\</c>. The default value is \<c>Running\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the resource group.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the target Prometheus instance for the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

    }

}
