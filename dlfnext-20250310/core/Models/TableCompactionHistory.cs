// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TableCompactionHistory : TeaModel {
        [NameInMap("afterFilesCount")]
        [Validation(Required=false)]
        public long? AfterFilesCount { get; set; }

        [NameInMap("afterFilesSize")]
        [Validation(Required=false)]
        public long? AfterFilesSize { get; set; }

        [NameInMap("beforeFilesCount")]
        [Validation(Required=false)]
        public long? BeforeFilesCount { get; set; }

        [NameInMap("beforeFilesLastCreationTime")]
        [Validation(Required=false)]
        public long? BeforeFilesLastCreationTime { get; set; }

        [NameInMap("beforeFilesSize")]
        [Validation(Required=false)]
        public long? BeforeFilesSize { get; set; }

        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("commitTime")]
        [Validation(Required=false)]
        public long? CommitTime { get; set; }

        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        [NameInMap("tableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

    }

}
