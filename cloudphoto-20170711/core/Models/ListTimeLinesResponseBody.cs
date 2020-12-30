// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListTimeLinesResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public int? NextCursor { get; set; }

        [NameInMap("TimeLines")]
        [Validation(Required=false)]
        public List<ListTimeLinesResponseBodyTimeLines> TimeLines { get; set; }
        public class ListTimeLinesResponseBodyTimeLines : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("PhotosCount")]
            [Validation(Required=false)]
            public int? PhotosCount { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Photos")]
            [Validation(Required=false)]
            public List<ListTimeLinesResponseBodyTimeLinesPhotos> Photos { get; set; }
            public class ListTimeLinesResponseBodyTimeLinesPhotos : TeaModel {
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("TakenAt")]
                [Validation(Required=false)]
                public long? TakenAt { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("ShareExpireTime")]
                [Validation(Required=false)]
                public long? ShareExpireTime { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("IdStr")]
                [Validation(Required=false)]
                public string IdStr { get; set; }

                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public long? Ctime { get; set; }

                [NameInMap("Mtime")]
                [Validation(Required=false)]
                public long? Mtime { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("IsVideo")]
                [Validation(Required=false)]
                public bool? IsVideo { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Like")]
                [Validation(Required=false)]
                public long? Like { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
