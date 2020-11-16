// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotDetectPornConfigResponse : TeaModel {
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

        [NameInMap("LiveSnapshotDetectPornConfigList")]
        [Validation(Required=true)]
        public DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigList LiveSnapshotDetectPornConfigList { get; set; }
        public class DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigList : TeaModel {
            [NameInMap("LiveSnapshotDetectPornConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig> LiveSnapshotDetectPornConfig { get; set; }
            public class DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string OssEndpoint { get; set; }
                public string OssBucket { get; set; }
                public string OssObject { get; set; }
                public int? Interval { get; set; }
                public DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes Scenes { get; set; }
                public class DescribeLiveSnapshotDetectPornConfigResponseLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes : TeaModel {
                    /// <summary>
                    /// scene
                    /// </summary>
                    [NameInMap("scene")]
                    [Validation(Required=true)]
                    public List<string> Scene { get; set; }

                }
            }
        };

    }

}
