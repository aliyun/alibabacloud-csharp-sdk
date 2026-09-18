// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>Filters Skills by creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for cursor-based pagination. Valid values: 1 to 100. Default value: <c>20</c>. If explicitly specified, cursor-based pagination takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned by the server for the next page. Do not pass this parameter for the first query. For subsequent queries, use the value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzIjoiZDc3ZGRhYmE3MDMwYWM1NCIsInAiOjJ9.vkKVySx9G26993sTNLZqwGSmgciRsrRm2SgsjOMJoCQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for compatible page-number-based pagination. Pages start from 1. Default value: <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for compatible page-number-based pagination. Valid values: 1 to 100. Default value: <c>20</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy match on the Skill name or description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>review</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>The query scope for Skills. Valid values: <c>SYSTEM</c> and <c>CUSTOM</c>. If omitted, both official and custom Skills are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Filters Skills by visibility. Common values are <c>user</c> and <c>tenant</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
