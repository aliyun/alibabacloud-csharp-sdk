// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotConfigResponseBody : TeaModel {
        [NameInMap("LiveStreamSnapshotConfigList")]
        [Validation(Required=false)]
        public DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList LiveStreamSnapshotConfigList { get; set; }
        public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList : TeaModel {
            [NameInMap("LiveStreamSnapshotConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig> LiveStreamSnapshotConfig { get; set; }
            public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("OverwriteOssObject")]
                [Validation(Required=false)]
                public string OverwriteOssObject { get; set; }

                [NameInMap("SequenceOssObject")]
                [Validation(Required=false)]
                public string SequenceOssObject { get; set; }

                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

            }

        }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
