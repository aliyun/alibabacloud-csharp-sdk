// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListFacesResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<ListFacesResponseBodyFaces> Faces { get; set; }
        public class ListFacesResponseBodyFaces : TeaModel {
            [NameInMap("IdStr")]
            [Validation(Required=false)]
            public string IdStr { get; set; }

            [NameInMap("PhotosCount")]
            [Validation(Required=false)]
            public int? PhotosCount { get; set; }

            [NameInMap("IsMe")]
            [Validation(Required=false)]
            public bool? IsMe { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public ListFacesResponseBodyFacesCover Cover { get; set; }
            public class ListFacesResponseBodyFacesCover : TeaModel {
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }
                [NameInMap("IdStr")]
                [Validation(Required=false)]
                public string IdStr { get; set; }
                [NameInMap("Mtime")]
                [Validation(Required=false)]
                public long? Mtime { get; set; }
                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public long? Ctime { get; set; }
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
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }
            };

            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }

            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Axis")]
            [Validation(Required=false)]
            public List<string> Axis { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
