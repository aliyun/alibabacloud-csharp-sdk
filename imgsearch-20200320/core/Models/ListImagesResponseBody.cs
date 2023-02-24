// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListImagesResponseBodyData Data { get; set; }
        public class ListImagesResponseBodyData : TeaModel {
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyDataImageList> ImageList { get; set; }
            public class ListImagesResponseBodyDataImageList : TeaModel {
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("ExtraData")]
                [Validation(Required=false)]
                public string ExtraData { get; set; }

                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public long? UpdatedAt { get; set; }

            }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
