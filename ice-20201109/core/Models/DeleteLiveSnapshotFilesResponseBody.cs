// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesResponseBody : TeaModel {
        [NameInMap("DeleteFileResultList")]
        [Validation(Required=false)]
        public List<DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList> DeleteFileResultList { get; set; }
        public class DeleteLiveSnapshotFilesResponseBodyDeleteFileResultList : TeaModel {
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
