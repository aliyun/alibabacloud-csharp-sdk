// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCustomAgentsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on a single page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Omit this parameter for the first request. For subsequent requests, use the <c>NextToken</c> value from the previous response to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword for a fuzzy match by agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>Filters the results by visibility level. You can specify multiple levels.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public List<string> Visibility { get; set; }

    }

}
