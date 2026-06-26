// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListFunctionsRequest : TeaModel {
        /// <summary>
        /// <para>A pattern to filter function names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>function%</para>
        /// </summary>
        [NameInMap("functionNamePattern")]
        [Validation(Required=false)]
        public string FunctionNamePattern { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. Use this token to retrieve the next page of results. Pass an empty string (&quot;&quot;) if this parameter is not returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
