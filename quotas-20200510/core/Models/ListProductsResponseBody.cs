// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("ProductInfo")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProductInfo> ProductInfo { get; set; }
        public class ListProductsResponseBodyProductInfo : TeaModel {
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("SecondCategoryId")]
            [Validation(Required=false)]
            public long? SecondCategoryId { get; set; }

            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            [NameInMap("SecondCategoryNameEn")]
            [Validation(Required=false)]
            public string SecondCategoryNameEn { get; set; }

            [NameInMap("SecondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
