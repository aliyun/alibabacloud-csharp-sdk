// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListProductByTagsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ProductInfos")]
        [Validation(Required=true)]
        public ListProductByTagsResponseProductInfos ProductInfos { get; set; }
        public class ListProductByTagsResponseProductInfos : TeaModel {
            [NameInMap("ProductInfo")]
            [Validation(Required=true)]
            public List<ListProductByTagsResponseProductInfosProductInfo> ProductInfo { get; set; }
            public class ListProductByTagsResponseProductInfosProductInfo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=true)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=true)]
                public int? NodeType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

            }

        }

    }

}
