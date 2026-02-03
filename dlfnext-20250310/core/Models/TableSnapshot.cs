// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableSnapshot : TeaModel {
        [NameInMap("fileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        [NameInMap("fileSizeInBytes")]
        [Validation(Required=false)]
        public long? FileSizeInBytes { get; set; }

        [NameInMap("lastFileCreationTime")]
        [Validation(Required=false)]
        public long? LastFileCreationTime { get; set; }

        [NameInMap("recordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public Snapshot Snapshot { get; set; }

        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

    }

}
