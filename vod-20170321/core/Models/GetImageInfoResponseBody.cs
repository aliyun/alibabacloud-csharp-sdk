// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoResponseBody : TeaModel {
        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public GetImageInfoResponseBodyImageInfo ImageInfo { get; set; }
        public class GetImageInfoResponseBodyImageInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }
            [NameInMap("Mezzanine")]
            [Validation(Required=false)]
            public GetImageInfoResponseBodyImageInfoMezzanine Mezzanine { get; set; }
            public class GetImageInfoResponseBodyImageInfoMezzanine : TeaModel {
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
