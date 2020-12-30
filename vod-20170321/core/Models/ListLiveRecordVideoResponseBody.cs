// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLiveRecordVideoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("LiveRecordVideoList")]
        [Validation(Required=false)]
        public ListLiveRecordVideoResponseBodyLiveRecordVideoList LiveRecordVideoList { get; set; }
        public class ListLiveRecordVideoResponseBodyLiveRecordVideoList : TeaModel {
            [NameInMap("LiveRecordVideo")]
            [Validation(Required=false)]
            public List<ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo> LiveRecordVideo { get; set; }
            public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("CateId")]
                [Validation(Required=false)]
                public int? CateId { get; set; }

                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoSnapshots Snapshots { get; set; }
                public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }
                };

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                [NameInMap("TemplateGroupId")]
                [Validation(Required=false)]
                public string TemplateGroupId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

            }
        };

    }

}
