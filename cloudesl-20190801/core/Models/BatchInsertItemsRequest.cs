// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class BatchInsertItemsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemInfo")]
        [Validation(Required=false)]
        public List<BatchInsertItemsRequestItemInfo> ItemInfo { get; set; }
        public class BatchInsertItemsRequestItemInfo : TeaModel {
            [NameInMap("ActionPrice")]
            [Validation(Required=false)]
            public int? ActionPrice { get; set; }

            [NameInMap("BePromotion")]
            [Validation(Required=false)]
            public bool? BePromotion { get; set; }

            [NameInMap("BeSourceCode")]
            [Validation(Required=false)]
            public bool? BeSourceCode { get; set; }

            [NameInMap("BrandName")]
            [Validation(Required=false)]
            public string BrandName { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("CompanyId")]
            [Validation(Required=false)]
            public string CompanyId { get; set; }

            [NameInMap("CustomizeFeatureA")]
            [Validation(Required=false)]
            public string CustomizeFeatureA { get; set; }

            [NameInMap("CustomizeFeatureB")]
            [Validation(Required=false)]
            public string CustomizeFeatureB { get; set; }

            [NameInMap("CustomizeFeatureC")]
            [Validation(Required=false)]
            public string CustomizeFeatureC { get; set; }

            [NameInMap("CustomizeFeatureD")]
            [Validation(Required=false)]
            public string CustomizeFeatureD { get; set; }

            [NameInMap("CustomizeFeatureE")]
            [Validation(Required=false)]
            public string CustomizeFeatureE { get; set; }

            [NameInMap("CustomizeFeatureF")]
            [Validation(Required=false)]
            public string CustomizeFeatureF { get; set; }

            [NameInMap("CustomizeFeatureG")]
            [Validation(Required=false)]
            public string CustomizeFeatureG { get; set; }

            [NameInMap("CustomizeFeatureH")]
            [Validation(Required=false)]
            public string CustomizeFeatureH { get; set; }

            [NameInMap("CustomizeFeatureI")]
            [Validation(Required=false)]
            public string CustomizeFeatureI { get; set; }

            [NameInMap("CustomizeFeatureJ")]
            [Validation(Required=false)]
            public string CustomizeFeatureJ { get; set; }

            [NameInMap("EnergyEfficiency")]
            [Validation(Required=false)]
            public string EnergyEfficiency { get; set; }

            [NameInMap("ExtraAttribute")]
            [Validation(Required=false)]
            public string ExtraAttribute { get; set; }

            [NameInMap("ForestFirstId")]
            [Validation(Required=false)]
            public string ForestFirstId { get; set; }

            [NameInMap("ForestSecondId")]
            [Validation(Required=false)]
            public string ForestSecondId { get; set; }

            [NameInMap("ItemBarCode")]
            [Validation(Required=false)]
            public string ItemBarCode { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemInfoIndex")]
            [Validation(Required=false)]
            public int? ItemInfoIndex { get; set; }

            [NameInMap("ItemQrCode")]
            [Validation(Required=false)]
            public string ItemQrCode { get; set; }

            [NameInMap("ItemShortTitle")]
            [Validation(Required=false)]
            public string ItemShortTitle { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("MemberPrice")]
            [Validation(Required=false)]
            public int? MemberPrice { get; set; }

            [NameInMap("ModelNumber")]
            [Validation(Required=false)]
            public string ModelNumber { get; set; }

            [NameInMap("OptionGroups")]
            [Validation(Required=false)]
            public string OptionGroups { get; set; }

            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public int? OriginalPrice { get; set; }

            [NameInMap("PriceUnit")]
            [Validation(Required=false)]
            public string PriceUnit { get; set; }

            [NameInMap("ProductionPlace")]
            [Validation(Required=false)]
            public string ProductionPlace { get; set; }

            [NameInMap("PromotionEnd")]
            [Validation(Required=false)]
            public string PromotionEnd { get; set; }

            [NameInMap("PromotionReason")]
            [Validation(Required=false)]
            public string PromotionReason { get; set; }

            [NameInMap("PromotionStart")]
            [Validation(Required=false)]
            public string PromotionStart { get; set; }

            [NameInMap("PromotionText")]
            [Validation(Required=false)]
            public string PromotionText { get; set; }

            [NameInMap("Rank")]
            [Validation(Required=false)]
            public string Rank { get; set; }

            [NameInMap("SaleSpec")]
            [Validation(Required=false)]
            public string SaleSpec { get; set; }

            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

            [NameInMap("SourceCode")]
            [Validation(Required=false)]
            public string SourceCode { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

            [NameInMap("SuggestPrice")]
            [Validation(Required=false)]
            public int? SuggestPrice { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
