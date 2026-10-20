// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListDatabaseDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The SQL-style right fuzzy match pattern for database names. The percent sign (%) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database%</para>
        /// </summary>
        [NameInMap("databaseNamePattern")]
        [Validation(Required=false)]
        public string DatabaseNamePattern { get; set; }

        /// <summary>
        /// <para>The page size.
        /// Default value:
        ///     1000
        /// Maximum value:
        ///     1000</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. If no token is provided in the response, pass an empty string (&quot;&quot;) or an empty character (\&quot;\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <para>The filter for the database deletion status. active indicates a normal database, and retained indicates a soft-deleted database that is still retained in the recycle bin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
