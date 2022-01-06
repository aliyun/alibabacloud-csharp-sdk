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
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public int? NodeType { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
