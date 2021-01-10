// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotConfigResponseBody : TeaModel {
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("LiveStreamSnapshotConfigList")]
        [Validation(Required=false)]
        public DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList LiveStreamSnapshotConfigList { get; set; }
        public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList : TeaModel {
            [NameInMap("LiveStreamSnapshotConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig> LiveStreamSnapshotConfig { get; set; }
            public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig : TeaModel {
                public string OverwriteOssObject { get; set; }
                public int? TimeInterval { get; set; }
                public string AppName { get; set; }
                public string CreateTime { get; set; }
                public string OssBucket { get; set; }
                public string DomainName { get; set; }
                public string Callback { get; set; }
                public string SequenceOssObject { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

    }

}
