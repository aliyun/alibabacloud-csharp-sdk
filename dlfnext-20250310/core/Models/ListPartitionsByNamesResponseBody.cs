// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPartitionsByNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>分区。</para>
        /// </summary>
        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<Partition> Partitions { get; set; }

    }

}
