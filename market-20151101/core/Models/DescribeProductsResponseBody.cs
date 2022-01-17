// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProductsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductItems")]
        [Validation(Required=false)]
        public DescribeProductsResponseBodyProductItems ProductItems { get; set; }
        public class DescribeProductsResponseBodyProductItems : TeaModel {
            [NameInMap("ProductItem")]
            [Validation(Required=false)]
            public List<DescribeProductsResponseBodyProductItemsProductItem> ProductItem { get; set; }
            public class DescribeProductsResponseBodyProductItemsProductItem : TeaModel {
                public long? CategoryId { get; set; }
                public string Code { get; set; }
                public string DeliveryDate { get; set; }
                public string DeliveryWay { get; set; }
                public string ImageUrl { get; set; }
                public string Name { get; set; }
                public string OperationSystem { get; set; }
                public string PriceInfo { get; set; }
                public string Score { get; set; }
                public string ShortDescription { get; set; }
                public string SuggestedPrice { get; set; }
                public long? SupplierId { get; set; }
                public string SupplierName { get; set; }
                public string Tags { get; set; }
                public string TargetUrl { get; set; }
                public string WarrantyDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
