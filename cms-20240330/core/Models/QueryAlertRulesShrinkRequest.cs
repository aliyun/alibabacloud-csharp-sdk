// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request body for querying alert rules.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to read in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the position from which to start reading. Leave this parameter empty to read from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The query filter condition. The value is a JSON string whose fields have the same semantics as the request body. Supported fields include filter (uuid, displayName, labels, status, enabled, and more. Fields at the same level have an AND relationship), pagination (pageNumber and pageSize), and workspace. Specify either this parameter or the request body. If both are specified, the request body takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;filter&quot;:{&quot;displayName&quot;:{&quot;contains&quot;:&quot;my-rule&quot;}},&quot;pagination&quot;:{&quot;pageNumber&quot;:1,&quot;pageSize&quot;:20}}</para>
        /// </summary>
        [NameInMap("queryJson")]
        [Validation(Required=false)]
        public string QueryJson { get; set; }

    }

}
