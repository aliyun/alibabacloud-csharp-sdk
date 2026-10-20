// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPartitionSummariesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of data. If it is not provided in the response, pass an empty string (&quot;&quot;) or an empty character (\&quot;\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <para>The partition name pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hh=10</para>
        /// </summary>
        [NameInMap("partitionNamePattern")]
        [Validation(Required=false)]
        public string PartitionNamePattern { get; set; }

    }

}
