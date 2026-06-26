// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PartitionSummaries : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. A null value indicates that the last page of results has been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hh=10</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The partitions.</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<PartitionSummary> Partitions { get; set; }

    }

}
