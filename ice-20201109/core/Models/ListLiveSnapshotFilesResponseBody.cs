// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotFilesResponseBody : TeaModel {
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ListLiveSnapshotFilesResponseBodyFileList> FileList { get; set; }
        public class ListLiveSnapshotFilesResponseBodyFileList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("IsOverlay")]
            [Validation(Required=false)]
            public bool? IsOverlay { get; set; }

            /// <summary>
            /// OSS bucket。
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            [NameInMap("OssObject")]
            [Validation(Required=false)]
            public string OssObject { get; set; }

        }

        [NameInMap("NextStartTime")]
        [Validation(Required=false)]
        public string NextStartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
