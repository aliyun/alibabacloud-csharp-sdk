// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not pass this parameter for the first query. For subsequent queries, pass the NextToken returned in the previous response to obtain the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword for fuzzy matching by skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>The visibility levels used to filter results. Multiple values can be specified.</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public List<string> Visibility { get; set; }

    }

}
