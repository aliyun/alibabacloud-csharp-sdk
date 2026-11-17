// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SearchProductsRequest : TeaModel {
        /// <summary>
        /// <para>The brand name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Plants</para>
        /// </summary>
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <para>The list of category IDs.</para>
        /// </summary>
        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>The end time of the creation. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the creation. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// <para>The cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>899192313AB192938441CCW</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The maximum distribution purchase price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("distributionHighPrice")]
        [Validation(Required=false)]
        public long? DistributionHighPrice { get; set; }

        /// <summary>
        /// <para>The maximum distribution premium rate. A value of 244 indicates 2.44%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>244</para>
        /// </summary>
        [NameInMap("distributionHighPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionHighPriceRatio { get; set; }

        /// <summary>
        /// <para>The minimum distribution purchase price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("distributionLowPrice")]
        [Validation(Required=false)]
        public long? DistributionLowPrice { get; set; }

        /// <summary>
        /// <para>The minimum distribution premium rate. A value of 133 indicates 1.33%.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133</para>
        /// </summary>
        [NameInMap("distributionLowPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionLowPriceRatio { get; set; }

        /// <summary>
        /// <para>The maximum strikethrough price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("highMarkPrice")]
        [Validation(Required=false)]
        public long? HighMarkPrice { get; set; }

        /// <summary>
        /// <para>The maximum suggested retail price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("highPrice")]
        [Validation(Required=false)]
        public long? HighPrice { get; set; }

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
        /// <para>The end time when the product was added to the inventory. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("inGroupEndTime")]
        [Validation(Required=false)]
        public string InGroupEndTime { get; set; }

        /// <summary>
        /// <para>The start time when the product was added to the inventory. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("inGroupStartTime")]
        [Validation(Required=false)]
        public string InGroupStartTime { get; set; }

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
        /// <para>The LM product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxxx</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        /// <summary>
        /// <para>The minimum strikethrough price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("lowMarkPrice")]
        [Validation(Required=false)]
        public long? LowMarkPrice { get; set; }

        /// <summary>
        /// <para>The minimum suggested retail price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("lowPrice")]
        [Validation(Required=false)]
        public long? LowPrice { get; set; }

        /// <summary>
        /// <para>The end time of the modification. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyEndTime")]
        [Validation(Required=false)]
        public string ModifyEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the modification. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyStartTime")]
        [Validation(Required=false)]
        public string ModifyStartTime { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be used in combination with the sort direction parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>soldQuantity (sorts by sales volume. If not specified, the default is descending order of creation time)</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort direction.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be used in combination with the sort field parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Maximum value: 20.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Taobao (sourced from Taobao)
        /// Tmall (sourced from Tmall)
        /// Cbu (sourced from the 1688 distribution platform)</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
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
        /// <para>The product status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sellable</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <para>The ID of the purchaser.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PIDxxxx</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>The tax rate.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can combine multiple tax rate enum values. Separate the values with commas (,). Example: Rate0,Rate1.</description></item>
        /// <item><description>HasRate cannot be combined with other enum values.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Rate0</para>
        /// </summary>
        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public string TaxRate { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JingXiao</para>
        /// </summary>
        [NameInMap("tradeModeAndCredit")]
        [Validation(Required=false)]
        public string TradeModeAndCredit { get; set; }

    }

}
