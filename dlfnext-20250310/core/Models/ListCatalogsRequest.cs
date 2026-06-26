// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListCatalogsRequest : TeaModel {
        /// <summary>
        /// <para>The pattern of the catalog name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi</para>
        /// </summary>
        [NameInMap("catalogNamePattern")]
        [Validation(Required=false)]
        public string CatalogNamePattern { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If the response does not include this token, pass an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
