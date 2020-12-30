// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public GetVideoInfoResponseBodyVideo Video { get; set; }
        public class GetVideoInfoResponseBodyVideo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }
            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public GetVideoInfoResponseBodyVideoSnapshots Snapshots { get; set; }
            public class GetVideoInfoResponseBodyVideoSnapshots : TeaModel {
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public List<string> Snapshot { get; set; }

            }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("CustomMediaInfo")]
            [Validation(Required=false)]
            public string CustomMediaInfo { get; set; }
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

    }

}
