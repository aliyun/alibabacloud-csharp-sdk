// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class ListFaceImagesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("FaceImages")]
        [Validation(Required=false)]
        public List<ListFaceImagesResponseBodyFaceImages> FaceImages { get; set; }
        public class ListFaceImagesResponseBodyFaceImages : TeaModel {
            [NameInMap("FaceRectangle")]
            [Validation(Required=false)]
            public List<float?> FaceRectangle { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("FaceImageId")]
            [Validation(Required=false)]
            public long? FaceImageId { get; set; }

        }

    }

}
