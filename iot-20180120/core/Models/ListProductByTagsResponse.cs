// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListProductByTagsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ProductInfos")]
        [Validation(Required=true)]
        public ListProductByTagsResponseProductInfos ProductInfos { get; set; }
        public class ListProductByTagsResponseProductInfos : TeaModel {
            [NameInMap("ProductInfo")]
            [Validation(Required=true)]
            public List<ListProductByTagsResponseProductInfosProductInfo> ProductInfo { get; set; }
            public class ListProductByTagsResponseProductInfosProductInfo : TeaModel {
                public string ProductName { get; set; }
                public string ProductKey { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public int? NodeType { get; set; }
            }
        };

    }

}
