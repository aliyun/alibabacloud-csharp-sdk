// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListImagesResponseBodyData Data { get; set; }
        public class ListImagesResponseBodyData : TeaModel {
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyDataImageList> ImageList { get; set; }
            public class ListImagesResponseBodyDataImageList : TeaModel {
                public string EntityId { get; set; }
                public long? CreatedAt { get; set; }
                public long? UpdatedAt { get; set; }
                public string DataId { get; set; }
                public string ExtraData { get; set; }
            }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
