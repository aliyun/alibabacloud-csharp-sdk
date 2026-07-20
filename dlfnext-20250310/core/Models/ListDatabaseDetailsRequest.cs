// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListDatabaseDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The SQL-style right fuzzy match pattern for database names. The percent sign (%) wildcard is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database%</para>
        /// </summary>
        [NameInMap("databaseNamePattern")]
        [Validation(Required=false)]
        public string DatabaseNamePattern { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// <para>Default value: 1000.</para>
        /// <para>Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. If the response does not include this token, pass an empty string (&quot;&quot;) or an empty character (\&quot;\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
