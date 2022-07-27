// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class OtsTableRestoreDetail : TeaModel {
        [NameInMap("BatchChannelCount")]
        [Validation(Required=false)]
        public int? BatchChannelCount { get; set; }

        [NameInMap("IndexNameSuffix")]
        [Validation(Required=false)]
        public string IndexNameSuffix { get; set; }

        [NameInMap("OverwriteExisting")]
        [Validation(Required=false)]
        public bool? OverwriteExisting { get; set; }

        [NameInMap("ReGenerateAutoIncrementPK")]
        [Validation(Required=false)]
        public bool? ReGenerateAutoIncrementPK { get; set; }

        [NameInMap("RestoreIndex")]
        [Validation(Required=false)]
        public bool? RestoreIndex { get; set; }

        [NameInMap("RestoreSearchIndex")]
        [Validation(Required=false)]
        public bool? RestoreSearchIndex { get; set; }

        [NameInMap("SearchIndexNameSuffix")]
        [Validation(Required=false)]
        public string SearchIndexNameSuffix { get; set; }

    }

}
