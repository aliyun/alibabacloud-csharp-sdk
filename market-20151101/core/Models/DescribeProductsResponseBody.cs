// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProductsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>53398003</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cmjj02****</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DeliveryDate")]
                [Validation(Required=false)]
                public string DeliveryDate { get; set; }

                [NameInMap("DeliveryWay")]
                [Validation(Required=false)]
                public string DeliveryWay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://oss.aliyuncs.com/photogallery/photo/1904996544835414/7549/767d6d07-8366-4822-b84e-61f6ea10d146.png">https://oss.aliyuncs.com/photogallery/photo/1904996544835414/7549/767d6d07-8366-4822-b84e-61f6ea10d146.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("OperationSystem")]
                [Validation(Required=false)]
                public string OperationSystem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;DiscountPrice\&quot;: 0.0, \&quot;TradePrice\&quot;: 15750.0, \&quot;Currency\&quot;: \&quot;CNY\&quot;, \&quot;OriginalPrice\&quot;: 15750.0, \&quot;RuleIds\&quot;: {\&quot;RuleId\&quot;: []}, \&quot;Coupons\&quot;: {\&quot;Coupon\&quot;: []}}</para>
                /// </summary>
                [NameInMap("PriceInfo")]
                [Validation(Required=false)]
                public string PriceInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

                [NameInMap("SuggestedPrice")]
                [Validation(Required=false)]
                public string SuggestedPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>228399</para>
                /// </summary>
                [NameInMap("SupplierId")]
                [Validation(Required=false)]
                public long? SupplierId { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/products/53616009/cmjj02****.html</para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("WarrantyDate")]
                [Validation(Required=false)]
                public string WarrantyDate { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A077D99E-0C4D-421E-A5D4-F533F6657817</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
