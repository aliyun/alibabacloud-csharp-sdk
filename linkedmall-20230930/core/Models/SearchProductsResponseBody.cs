// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SearchProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cursor for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>899192313AB192938441CCW</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>The product collection.</para>
        /// </summary>
        [NameInMap("products")]
        [Validation(Required=false)]
        public List<SearchProductsResponseBodyProducts> Products { get; set; }
        public class SearchProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// <para>The brand name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Plants</para>
            /// </summary>
            [NameInMap("bandName")]
            [Validation(Required=false)]
            public string BandName { get; set; }

            /// <summary>
            /// <para>The reason why the product is unavailable for sale.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Insufficient inventory</para>
            /// </summary>
            [NameInMap("canNotSellReason")]
            [Validation(Required=false)]
            public string CanNotSellReason { get; set; }

            /// <summary>
            /// <para>Indicates whether the product is available for sale. This is a calculated value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            /// <summary>
            /// <para>The category chain.</para>
            /// </summary>
            [NameInMap("categoryChain")]
            [Validation(Required=false)]
            public List<SearchProductsResponseBodyProductsCategoryChain> CategoryChain { get; set; }
            public class SearchProductsResponseBodyProductsCategoryChain : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>201792301</para>
                /// </summary>
                [NameInMap("categoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is a leaf node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isLeaf")]
                [Validation(Required=false)]
                public bool? IsLeaf { get; set; }

                /// <summary>
                /// <para>The level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parent category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// <para>The billing cycle.</para>
            /// </summary>
            [NameInMap("credit")]
            [Validation(Required=false)]
            public List<string> Credit { get; set; }

            /// <summary>
            /// <para>The price difference range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>￥-9998.95 ~ ￥-9977.90</para>
            /// </summary>
            [NameInMap("diffPrice")]
            [Validation(Required=false)]
            public string DiffPrice { get; set; }

            /// <summary>
            /// <para>The distribution purchase price range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>￥0.05 ~ ￥21.10</para>
            /// </summary>
            [NameInMap("distributionPrice")]
            [Validation(Required=false)]
            public string DistributionPrice { get; set; }

            /// <summary>
            /// <para>The distribution premium rate range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-100.00% ~ -99.79%</para>
            /// </summary>
            [NameInMap("distributionPriceRatio")]
            [Validation(Required=false)]
            public string DistributionPriceRatio { get; set; }

            /// <summary>
            /// <para>The source platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Taobao (sourced from Taobao)
            /// Tmall (sourced from Tmall)
            /// Cbu (sourced from the 1688 distribution platform)</para>
            /// </summary>
            [NameInMap("externalPlatformType")]
            [Validation(Required=false)]
            public string ExternalPlatformType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Specifies whether the product is added to the inventory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("inGroup")]
            [Validation(Required=false)]
            public bool? InGroup { get; set; }

            /// <summary>
            /// <para>The time when the product was added to the inventory. The format is yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("inGroupTime")]
            [Validation(Required=false)]
            public string InGroupTime { get; set; }

            /// <summary>
            /// <para>The inventory risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("inventoryRiskLevel")]
            [Validation(Required=false)]
            public string InventoryRiskLevel { get; set; }

            /// <summary>
            /// <para>The invoice type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HasInvoice</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// <para>The LM product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx-xxxxx</para>
            /// </summary>
            [NameInMap("lmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            /// <summary>
            /// <para>The main image URL of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/xxx.jpg">https://img.alicdn.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("picUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            /// <summary>
            /// <para>The suggested retail price range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>￥9999.00 ~ ￥9999.00</para>
            /// </summary>
            [NameInMap("platformPrice")]
            [Validation(Required=false)]
            public string PlatformPrice { get; set; }

            /// <summary>
            /// <para>The strikethrough price range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>￥9999.00 ~ ￥9999.00</para>
            /// </summary>
            [NameInMap("platformReservePrice")]
            [Validation(Required=false)]
            public string PlatformReservePrice { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Plants</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The channel store name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("shopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            /// <summary>
            /// <para>The cumulative sales volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("soldQuantity")]
            [Validation(Required=false)]
            public string SoldQuantity { get; set; }

            /// <summary>
            /// <para>The tax code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3040203000000000000</para>
            /// </summary>
            [NameInMap("taxCode")]
            [Validation(Required=false)]
            public string TaxCode { get; set; }

            /// <summary>
            /// <para>The tax rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600 (6%)
            /// -100 (Tax-exempt)</para>
            /// </summary>
            [NameInMap("taxRate")]
            [Validation(Required=false)]
            public long? TaxRate { get; set; }

            /// <summary>
            /// <para>The sales mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JingXiao</para>
            /// </summary>
            [NameInMap("tradeMode")]
            [Validation(Required=false)]
            public string TradeMode { get; set; }

        }

        /// <summary>
        /// <para>The total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
