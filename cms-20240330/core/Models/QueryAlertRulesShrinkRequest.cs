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
        /// <para>The client token that is used to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to return in the current read operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting position for the current read operation. If this parameter is left empty, the read operation starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The query filter conditions in JSON string format. The field semantics are the same as those in the request body. Supported fields include filter (such as uuid, displayName, labels, status, and enabled, where sibling fields use the AND logical operator), pagination (pageNumber and pageSize), and workspace. You must specify either this parameter or the body parameter. If both are specified, the body parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;filter&quot;:{&quot;displayName&quot;:{&quot;contains&quot;:&quot;my-rule&quot;}},&quot;pagination&quot;:{&quot;pageNumber&quot;:1,&quot;pageSize&quot;:20}}</para>
        /// </summary>
        [NameInMap("queryJson")]
        [Validation(Required=false)]
        public string QueryJson { get; set; }

    }

}
