// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListAutoSnapshotPolicyAppliedDbfsResponseBody : TeaModel {
        [NameInMap("DbfsList")]
        [Validation(Required=false)]
        public List<ListAutoSnapshotPolicyAppliedDbfsResponseBodyDbfsList> DbfsList { get; set; }
        public class ListAutoSnapshotPolicyAppliedDbfsResponseBodyDbfsList : TeaModel {
            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }

            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SizeG")]
            [Validation(Required=false)]
            public long? SizeG { get; set; }

            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public string SnapshotCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
