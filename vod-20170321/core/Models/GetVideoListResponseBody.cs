// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public GetVideoListResponseBodyVideoList VideoList { get; set; }
        public class GetVideoListResponseBodyVideoList : TeaModel {
            [NameInMap("Video")]
            [Validation(Required=false)]
            public List<GetVideoListResponseBodyVideoListVideo> Video { get; set; }
            public class GetVideoListResponseBodyVideoListVideo : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string StorageLocation { get; set; }
                public long? CateId { get; set; }
                public string VideoId { get; set; }
                public string Tags { get; set; }
                public string ModificationTime { get; set; }
                public GetVideoListResponseBodyVideoListVideoSnapshots Snapshots { get; set; }
                public class GetVideoListResponseBodyVideoListVideoSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }
                public string CateName { get; set; }
                public string Description { get; set; }
                public string AppId { get; set; }
                public long? Size { get; set; }
                public string CoverURL { get; set; }
                public float? Duration { get; set; }
                public string Title { get; set; }
            }
        };

    }

}
