// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListSupportedProductsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListSupportedProductsResponseBodyProducts> Products { get; set; }
        public class ListSupportedProductsResponseBodyProducts : TeaModel {
            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            [NameInMap("ProductNameZh")]
            [Validation(Required=false)]
            public string ProductNameZh { get; set; }

            [NameInMap("ResourceTypeList")]
            [Validation(Required=false)]
            public List<ListSupportedProductsResponseBodyProductsResourceTypeList> ResourceTypeList { get; set; }
            public class ListSupportedProductsResponseBodyProductsResourceTypeList : TeaModel {
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("TypeNameEn")]
                [Validation(Required=false)]
                public string TypeNameEn { get; set; }

                [NameInMap("TypeNameZh")]
                [Validation(Required=false)]
                public string TypeNameZh { get; set; }

                [NameInMap("TypePageLink")]
                [Validation(Required=false)]
                public string TypePageLink { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
