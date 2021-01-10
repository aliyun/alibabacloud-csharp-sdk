// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamSnapshotInfoResponseBody : TeaModel {
        [NameInMap("LiveStreamSnapshotInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoList LiveStreamSnapshotInfoList { get; set; }
        public class DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoList : TeaModel {
            [NameInMap("LiveStreamSnapshotInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoListLiveStreamSnapshotInfo> LiveStreamSnapshotInfo { get; set; }
            public class DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoListLiveStreamSnapshotInfo : TeaModel {
                public string OssObject { get; set; }
                public string CreateTime { get; set; }
                public string OssBucket { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextStartTime")]
        [Validation(Required=false)]
        public string NextStartTime { get; set; }

    }

}
