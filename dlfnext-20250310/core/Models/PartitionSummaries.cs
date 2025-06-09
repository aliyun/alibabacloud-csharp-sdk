// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class PartitionSummaries : TeaModel {
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>Current page of partition profiles</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<PartitionSummary> Partitions { get; set; }

    }

}
