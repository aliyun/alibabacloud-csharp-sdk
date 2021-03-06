// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class CreateAlbumResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Album")]
        [Validation(Required=false)]
        public CreateAlbumResponseBodyAlbum Album { get; set; }
        public class CreateAlbumResponseBodyAlbum : TeaModel {
            [NameInMap("IdStr")]
            [Validation(Required=false)]
            public string IdStr { get; set; }
            [NameInMap("PhotosCount")]
            [Validation(Required=false)]
            public long? PhotosCount { get; set; }
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public CreateAlbumResponseBodyAlbumCover Cover { get; set; }
            public class CreateAlbumResponseBodyAlbumCover : TeaModel {
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

            }
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
