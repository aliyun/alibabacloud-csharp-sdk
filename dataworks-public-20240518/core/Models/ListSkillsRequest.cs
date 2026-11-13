// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not specify this parameter in the first request. In subsequent requests, specify the <c>NextToken</c> value returned in the previous response to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword used for fuzzy matching by skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis</para>
        /// </summary>
        [NameInMap("Q")]
        [Validation(Required=false)]
        public string Q { get; set; }

        /// <summary>
        /// <para>The visibility levels used to filter the results. You can specify multiple values.</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public List<string> Visibility { get; set; }

    }

}
