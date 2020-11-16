// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=true)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Order")]
        [Validation(Required=true)]
        public string Order { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=true)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("LiveStreamSnapshotConfigList")]
        [Validation(Required=true)]
        public DescribeLiveSnapshotConfigResponseLiveStreamSnapshotConfigList LiveStreamSnapshotConfigList { get; set; }
        public class DescribeLiveSnapshotConfigResponseLiveStreamSnapshotConfigList : TeaModel {
            [NameInMap("LiveStreamSnapshotConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveSnapshotConfigResponseLiveStreamSnapshotConfigListLiveStreamSnapshotConfig> LiveStreamSnapshotConfig { get; set; }
            public class DescribeLiveSnapshotConfigResponseLiveStreamSnapshotConfigListLiveStreamSnapshotConfig : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public int? TimeInterval { get; set; }
                public string OssEndpoint { get; set; }
                public string OssBucket { get; set; }
                public string OverwriteOssObject { get; set; }
                public string SequenceOssObject { get; set; }
                public string CreateTime { get; set; }
                public string Callback { get; set; }
            }
        };

    }

}
