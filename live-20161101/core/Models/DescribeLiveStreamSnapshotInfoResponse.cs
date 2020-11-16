// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamSnapshotInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextStartTime")]
        [Validation(Required=true)]
        public string NextStartTime { get; set; }

        [NameInMap("LiveStreamSnapshotInfoList")]
        [Validation(Required=true)]
        public DescribeLiveStreamSnapshotInfoResponseLiveStreamSnapshotInfoList LiveStreamSnapshotInfoList { get; set; }
        public class DescribeLiveStreamSnapshotInfoResponseLiveStreamSnapshotInfoList : TeaModel {
            [NameInMap("LiveStreamSnapshotInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamSnapshotInfoResponseLiveStreamSnapshotInfoListLiveStreamSnapshotInfo> LiveStreamSnapshotInfo { get; set; }
            public class DescribeLiveStreamSnapshotInfoResponseLiveStreamSnapshotInfoListLiveStreamSnapshotInfo : TeaModel {
                public string OssEndpoint { get; set; }
                public string OssBucket { get; set; }
                public string OssObject { get; set; }
                public string CreateTime { get; set; }
            }
        };

    }

}
