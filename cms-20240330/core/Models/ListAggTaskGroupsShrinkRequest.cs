// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAggTaskGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of IDs for the aggregation task groups, which must be JSON parseable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;aggTaskGroup-xxx&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupIds")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupIds { get; set; }

        /// <summary>
        /// <para>List of names for the aggregation task groups, which must be JSON parseable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;apiserver_request_total&quot;]</para>
        /// </summary>
        [NameInMap("filterAggTaskGroupNames")]
        [Validation(Required=false)]
        public string FilterAggTaskGroupNames { get; set; }

        /// <summary>
        /// <para>Maximum number of records to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Query token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28036394xxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Name search, supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Status of the aggregation task group, either \&quot;Running\&quot; or \&quot;Stopped\&quot;. Default is Running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Resource group tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The target Prometheus instance ID for the aggregation task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-pq4apob9jm</para>
        /// </summary>
        [NameInMap("targetPrometheusId")]
        [Validation(Required=false)]
        public string TargetPrometheusId { get; set; }

    }

}
