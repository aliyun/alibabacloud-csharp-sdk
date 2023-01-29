// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListSnapshotLinksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public List<ListSnapshotLinksResponseBodySnapshotLinks> SnapshotLinks { get; set; }
        public class ListSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<ListSnapshotLinksResponseBodySnapshotLinksEcsList> EcsList { get; set; }
            public class ListSnapshotLinksResponseBodySnapshotLinksEcsList : TeaModel {
                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

            }

            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }

            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }

            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public int? SnapshotCount { get; set; }

            [NameInMap("SourceSize")]
            [Validation(Required=false)]
            public int? SourceSize { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
