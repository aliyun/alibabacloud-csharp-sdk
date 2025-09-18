// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableCompaction : TeaModel {
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("cuUsage")]
        [Validation(Required=false)]
        public double? CuUsage { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("lastCompactedFileTime")]
        [Validation(Required=false)]
        [Obsolete]
        public long? LastCompactedFileTime { get; set; }

        [NameInMap("latencyFileEarliestTime")]
        [Validation(Required=false)]
        public long? LatencyFileEarliestTime { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("maxLevel0FileCount")]
        [Validation(Required=false)]
        [Obsolete]
        public string MaxLevel0FileCount { get; set; }

        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

    }

}
