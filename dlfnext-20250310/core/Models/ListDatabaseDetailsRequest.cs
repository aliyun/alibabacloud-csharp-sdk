// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListDatabaseDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The database name pattern for fuzzy matching. Supports the percent sign (%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>database%</para>
        /// </summary>
        [NameInMap("databaseNamePattern")]
        [Validation(Required=false)]
        public string DatabaseNamePattern { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.
        /// Default value: 1000.
        /// Maximum value: 1000.</para>
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
