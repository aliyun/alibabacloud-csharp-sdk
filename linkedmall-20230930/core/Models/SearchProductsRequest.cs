// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SearchProductsRequest : TeaModel {
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        [NameInMap("distributionHighPrice")]
        [Validation(Required=false)]
        public long? DistributionHighPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>244（2.44%）</para>
        /// </summary>
        [NameInMap("distributionHighPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionHighPriceRatio { get; set; }

        [NameInMap("distributionLowPrice")]
        [Validation(Required=false)]
        public long? DistributionLowPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>133（1.33%）</para>
        /// </summary>
        [NameInMap("distributionLowPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionLowPriceRatio { get; set; }

        [NameInMap("highMarkPrice")]
        [Validation(Required=false)]
        public long? HighMarkPrice { get; set; }

        [NameInMap("highPrice")]
        [Validation(Required=false)]
        public long? HighPrice { get; set; }

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
        [NameInMap("inGroupEndTime")]
        [Validation(Required=false)]
        public string InGroupEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("inGroupStartTime")]
        [Validation(Required=false)]
        public string InGroupStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Low</para>
        /// </summary>
        [NameInMap("inventoryRiskLevel")]
        [Validation(Required=false)]
        public string InventoryRiskLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxxxx</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        [NameInMap("lowMarkPrice")]
        [Validation(Required=false)]
        public long? LowMarkPrice { get; set; }

        [NameInMap("lowPrice")]
        [Validation(Required=false)]
        public long? LowPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyEndTime")]
        [Validation(Required=false)]
        public string ModifyEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyStartTime")]
        [Validation(Required=false)]
        public string ModifyStartTime { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Taobao</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Sellable</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PIDxxxx</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Rate0</para>
        /// </summary>
        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public string TaxRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JingXiao</para>
        /// </summary>
        [NameInMap("tradeModeAndCredit")]
        [Validation(Required=false)]
        public string TradeModeAndCredit { get; set; }

    }

}
