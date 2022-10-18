// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyData> Data { get; set; }
        public class ListProductsResponseBodyData : TeaModel {
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public long? DirectoryId { get; set; }

            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListProductsResponseBodyDataProductList> ProductList { get; set; }
            public class ListProductsResponseBodyDataProductList : TeaModel {
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public long? ProductId { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
