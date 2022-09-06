// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListProductByTagsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductInfos")]
        [Validation(Required=false)]
        public ListProductByTagsResponseBodyProductInfos ProductInfos { get; set; }
        public class ListProductByTagsResponseBodyProductInfos : TeaModel {
            [NameInMap("ProductInfo")]
            [Validation(Required=false)]
            public List<ListProductByTagsResponseBodyProductInfosProductInfo> ProductInfo { get; set; }
            public class ListProductByTagsResponseBodyProductInfosProductInfo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
