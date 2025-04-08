// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SearchProductsResponseBody : TeaModel {
        [NameInMap("products")]
        [Validation(Required=false)]
        public List<SearchProductsResponseBodyProducts> Products { get; set; }
        public class SearchProductsResponseBodyProducts : TeaModel {
            [NameInMap("bandName")]
            [Validation(Required=false)]
            public string BandName { get; set; }

            [NameInMap("canNotSellReason")]
            [Validation(Required=false)]
            public string CanNotSellReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("canSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("categoryChain")]
            [Validation(Required=false)]
            public List<SearchProductsResponseBodyProductsCategoryChain> CategoryChain { get; set; }
            public class SearchProductsResponseBodyProductsCategoryChain : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>201792301</para>
                /// </summary>
                [NameInMap("categoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("isLeaf")]
                [Validation(Required=false)]
                public bool? IsLeaf { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            [NameInMap("credit")]
            [Validation(Required=false)]
            public List<string> Credit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>￥-9998.95 ~ ￥-9977.90</para>
            /// </summary>
            [NameInMap("diffPrice")]
            [Validation(Required=false)]
            public string DiffPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>￥0.05 ~ ￥21.10</para>
            /// </summary>
            [NameInMap("distributionPrice")]
            [Validation(Required=false)]
            public string DistributionPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-100.00% ~ -99.79%</para>
            /// </summary>
            [NameInMap("distributionPriceRatio")]
            [Validation(Required=false)]
            public string DistributionPriceRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Taobao</para>
            /// </summary>
            [NameInMap("externalPlatformType")]
            [Validation(Required=false)]
            public string ExternalPlatformType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("inGroup")]
            [Validation(Required=false)]
            public bool? InGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-02 12:23:34
            /// (yyyy-MM-dd HH:mm:ss)</para>
            /// </summary>
            [NameInMap("inGroupTime")]
            [Validation(Required=false)]
            public string InGroupTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("inventoryRiskLevel")]
            [Validation(Required=false)]
            public string InventoryRiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HasInvoice</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx-xxxxx</para>
            /// </summary>
            [NameInMap("lmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/xxx.jpg">https://img.alicdn.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("picUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>￥9999.00 ~ ￥9999.00</para>
            /// </summary>
            [NameInMap("platformPrice")]
            [Validation(Required=false)]
            public string PlatformPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>￥9999.00 ~ ￥9999.00</para>
            /// </summary>
            [NameInMap("platformReservePrice")]
            [Validation(Required=false)]
            public string PlatformReservePrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("shopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("soldQuantity")]
            [Validation(Required=false)]
            public string SoldQuantity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3040203000000000000</para>
            /// </summary>
            [NameInMap("taxCode")]
            [Validation(Required=false)]
            public string TaxCode { get; set; }

            [NameInMap("taxRate")]
            [Validation(Required=false)]
            public long? TaxRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JingXiao</para>
            /// </summary>
            [NameInMap("tradeMode")]
            [Validation(Required=false)]
            public string TradeMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
