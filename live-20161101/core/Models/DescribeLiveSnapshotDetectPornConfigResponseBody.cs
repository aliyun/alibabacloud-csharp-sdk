// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotDetectPornConfigResponseBody : TeaModel {
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

        [NameInMap("LiveSnapshotDetectPornConfigList")]
        [Validation(Required=false)]
        public DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigList LiveSnapshotDetectPornConfigList { get; set; }
        public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigList : TeaModel {
            [NameInMap("LiveSnapshotDetectPornConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig> LiveSnapshotDetectPornConfig { get; set; }
            public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig : TeaModel {
                public string OssObject { get; set; }
                public string AppName { get; set; }
                public int? Interval { get; set; }
                public DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes Scenes { get; set; }
                public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes : TeaModel {
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public List<string> Scene { get; set; }

                }
                public string OssBucket { get; set; }
                public string DomainName { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

    }

}
