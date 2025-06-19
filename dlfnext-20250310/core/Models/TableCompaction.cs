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

        [NameInMap("lastCompactedFileTime")]
        [Validation(Required=false)]
        public long? LastCompactedFileTime { get; set; }

        [NameInMap("maxLevel0FileCount")]
        [Validation(Required=false)]
        public string MaxLevel0FileCount { get; set; }

        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

    }

}
