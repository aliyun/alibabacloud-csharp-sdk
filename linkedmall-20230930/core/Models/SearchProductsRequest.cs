// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SearchProductsRequest : TeaModel {
        /// <summary>
        /// <para>Brand name</para>
        /// 
        /// <b>Example:</b>
        /// <para>绿植</para>
        /// </summary>
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <para>Collection of category IDs</para>
        /// </summary>
        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// <para>Creation end time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// <para>Creation start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// <para>Upper limit of distribution purchase price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("distributionHighPrice")]
        [Validation(Required=false)]
        public long? DistributionHighPrice { get; set; }

        /// <summary>
        /// <para>Upper limit of distribution premium rate</para>
        /// 
        /// <b>Example:</b>
        /// <para>244（2.44%）</para>
        /// </summary>
        [NameInMap("distributionHighPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionHighPriceRatio { get; set; }

        /// <summary>
        /// <para>Lower limit of distribution purchase price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("distributionLowPrice")]
        [Validation(Required=false)]
        public long? DistributionLowPrice { get; set; }

        /// <summary>
        /// <para>Lower limit of distribution premium rate</para>
        /// 
        /// <b>Example:</b>
        /// <para>133（1.33%）</para>
        /// </summary>
        [NameInMap("distributionLowPriceRatio")]
        [Validation(Required=false)]
        public long? DistributionLowPriceRatio { get; set; }

        /// <summary>
        /// <para>Upper limit of strikethrough price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("highMarkPrice")]
        [Validation(Required=false)]
        public long? HighMarkPrice { get; set; }

        /// <summary>
        /// <para>Upper limit of suggested retail price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("highPrice")]
        [Validation(Required=false)]
        public long? HighPrice { get; set; }

        /// <summary>
        /// <para>Whether the product is in inventory</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("inGroup")]
        [Validation(Required=false)]
        public bool? InGroup { get; set; }

        /// <summary>
        /// <para>End time of the product’s entry period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("inGroupEndTime")]
        [Validation(Required=false)]
        public string InGroupEndTime { get; set; }

        /// <summary>
        /// <para>Inventory start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("inGroupStartTime")]
        [Validation(Required=false)]
        public string InGroupStartTime { get; set; }

        /// <summary>
        /// <para>Inventory risk level</para>
        /// 
        /// <b>Example:</b>
        /// <para>Low</para>
        /// </summary>
        [NameInMap("inventoryRiskLevel")]
        [Validation(Required=false)]
        public string InventoryRiskLevel { get; set; }

        /// <summary>
        /// <para>LM product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxxx</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        /// <summary>
        /// <para>Lower limit of strikethrough price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("lowMarkPrice")]
        [Validation(Required=false)]
        public long? LowMarkPrice { get; set; }

        /// <summary>
        /// <para>Lower limit of suggested retail price</para>
        /// 
        /// <b>Example:</b>
        /// <para>100（单位：分）</para>
        /// </summary>
        [NameInMap("lowPrice")]
        [Validation(Required=false)]
        public long? LowPrice { get; set; }

        /// <summary>
        /// <para>Modification end time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyEndTime")]
        [Validation(Required=false)]
        public string ModifyEndTime { get; set; }

        /// <summary>
        /// <para>Modification start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 12:23:34
        /// (yyyy-MM-dd HH:mm:ss)</para>
        /// </summary>
        [NameInMap("modifyStartTime")]
        [Validation(Required=false)]
        public string ModifyStartTime { get; set; }

        /// <summary>
        /// <para>Sort field</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Used in combination with the sort direction field</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>soldQuantity（按销量排序，不填默认创建时间倒序)</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Sort direction</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Used in combination with the sort field</description></item>
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
        /// <para>Page number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Maximum of 20 items per page</description></item>
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
        /// <para>Source platform</para>
        /// 
        /// <b>Example:</b>
        /// <para>Taobao（来源淘宝）
        /// Tmall（来源天猫）
        /// Cbu（来源1688分销货盘）</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>Product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>Product name</para>
        /// 
        /// <b>Example:</b>
        /// <para>绿植</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>Product status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sellable</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PIDxxxx</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>Tax rate</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Supports combining multiple tax rate enumeration values as request parameters. Use commas to separate them, for example: Rate0,Rate1.</para>
        /// </description></item>
        /// <item><description><para>HasRate cannot be combined with other enumeration values as request parameters.</para>
        /// </description></item>
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
        /// <para>Sales pattern</para>
        /// 
        /// <b>Example:</b>
        /// <para>JingXiao</para>
        /// </summary>
        [NameInMap("tradeModeAndCredit")]
        [Validation(Required=false)]
        public string TradeModeAndCredit { get; set; }

    }

}
