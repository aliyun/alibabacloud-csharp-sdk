// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCustomAgentsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not specify this parameter for the first query. For subsequent queries, specify the <c>NextToken</c> value returned from the previous query to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword used to perform a fuzzy match on agent names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>The visibility levels used to filter results. You can specify multiple values.</para>
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
