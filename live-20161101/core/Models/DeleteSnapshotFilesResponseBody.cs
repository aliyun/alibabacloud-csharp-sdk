// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteSnapshotFilesResponseBody : TeaModel {
        [NameInMap("FailureCount")]
        [Validation(Required=false)]
        public int? FailureCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotDeleteInfoList")]
        [Validation(Required=false)]
        public DeleteSnapshotFilesResponseBodySnapshotDeleteInfoList SnapshotDeleteInfoList { get; set; }
        public class DeleteSnapshotFilesResponseBodySnapshotDeleteInfoList : TeaModel {
            [NameInMap("SnapshotDeleteInfo")]
            [Validation(Required=false)]
            public List<DeleteSnapshotFilesResponseBodySnapshotDeleteInfoListSnapshotDeleteInfo> SnapshotDeleteInfo { get; set; }
            public class DeleteSnapshotFilesResponseBodySnapshotDeleteInfoListSnapshotDeleteInfo : TeaModel {
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
