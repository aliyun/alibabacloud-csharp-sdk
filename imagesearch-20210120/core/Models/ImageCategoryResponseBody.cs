// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImageCategoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageCategoryResponseBodyData Data { get; set; }
        public class ImageCategoryResponseBodyData : TeaModel {
            [NameInMap("CateResult")]
            [Validation(Required=false)]
            public List<ImageCategoryResponseBodyDataCateResult> CateResult { get; set; }
            public class ImageCategoryResponseBodyDataCateResult : TeaModel {
                public float? Score { get; set; }
                public string Name { get; set; }
                public long? Id { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
