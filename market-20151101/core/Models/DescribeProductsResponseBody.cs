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
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DeliveryDate")]
                [Validation(Required=false)]
                public string DeliveryDate { get; set; }

                [NameInMap("DeliveryWay")]
                [Validation(Required=false)]
                public string DeliveryWay { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OperationSystem")]
                [Validation(Required=false)]
                public string OperationSystem { get; set; }

                [NameInMap("PriceInfo")]
                [Validation(Required=false)]
                public string PriceInfo { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

                [NameInMap("SuggestedPrice")]
                [Validation(Required=false)]
                public string SuggestedPrice { get; set; }

                [NameInMap("SupplierId")]
                [Validation(Required=false)]
                public long? SupplierId { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("WarrantyDate")]
                [Validation(Required=false)]
                public string WarrantyDate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
