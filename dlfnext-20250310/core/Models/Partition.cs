// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Partition : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

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

        [NameInMap("spec")]
        [Validation(Required=false)]
        public Dictionary<string, object> Spec { get; set; }

        [NameInMap("storageAction")]
        [Validation(Required=false)]
        public string StorageAction { get; set; }

        [NameInMap("storageActionTimestamp")]
        [Validation(Required=false)]
        public long? StorageActionTimestamp { get; set; }

        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("totalBuckets")]
        [Validation(Required=false)]
        public int? TotalBuckets { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
