// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class GetSnapshotLinkResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSnapshotLinkResponseBodyData Data { get; set; }
        public class GetSnapshotLinkResponseBodyData : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<GetSnapshotLinkResponseBodyDataEcsList> EcsList { get; set; }
            public class GetSnapshotLinkResponseBodyDataEcsList : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
