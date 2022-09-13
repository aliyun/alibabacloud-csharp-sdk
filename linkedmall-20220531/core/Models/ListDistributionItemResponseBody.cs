// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ListDistributionItemResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<ListDistributionItemResponseBodyModel> Model { get; set; }
        public class ListDistributionItemResponseBodyModel : TeaModel {
            [NameInMap("AuctionStatus")]
            [Validation(Required=false)]
            public int? AuctionStatus { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("BizTotalSaleNum")]
            [Validation(Required=false)]
            public long? BizTotalSaleNum { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CategoryChain")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelCategoryChain> CategoryChain { get; set; }
            public class ListDistributionItemResponseBodyModelCategoryChain : TeaModel {
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("Leaf")]
                [Validation(Required=false)]
                public bool? Leaf { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CumulativeSaleNum")]
            [Validation(Required=false)]
            public long? CumulativeSaleNum { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DiscountRateScope")]
            [Validation(Required=false)]
            public string DiscountRateScope { get; set; }

            [NameInMap("DisparityPriceScope")]
            [Validation(Required=false)]
            public string DisparityPriceScope { get; set; }

            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("IcQuantity")]
            [Validation(Required=false)]
            public long? IcQuantity { get; set; }

            [NameInMap("IsCanSell")]
            [Validation(Required=false)]
            public bool? IsCanSell { get; set; }

            [NameInMap("IsInventoryZero")]
            [Validation(Required=false)]
            public bool? IsInventoryZero { get; set; }

            [NameInMap("ItemDesc")]
            [Validation(Required=false)]
            public string ItemDesc { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemIdStr")]
            [Validation(Required=false)]
            public string ItemIdStr { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LinkRatio")]
            [Validation(Required=false)]
            public string LinkRatio { get; set; }

            [NameInMap("LmAttributeModels")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelLmAttributeModels> LmAttributeModels { get; set; }
            public class ListDistributionItemResponseBodyModelLmAttributeModels : TeaModel {
                [NameInMap("AttrId")]
                [Validation(Required=false)]
                public long? AttrId { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Restriction")]
                [Validation(Required=false)]
                public string Restriction { get; set; }

                [NameInMap("ScopeList")]
                [Validation(Required=false)]
                public List<string> ScopeList { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("LmShopId")]
            [Validation(Required=false)]
            public long? LmShopId { get; set; }

            [NameInMap("MainBizStatus")]
            [Validation(Required=false)]
            public int? MainBizStatus { get; set; }

            [NameInMap("MainBizTotalSaleNum")]
            [Validation(Required=false)]
            public long? MainBizTotalSaleNum { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("MainPriceCentScope")]
            [Validation(Required=false)]
            public string MainPriceCentScope { get; set; }

            [NameInMap("MaxAllowedCount")]
            [Validation(Required=false)]
            public int? MaxAllowedCount { get; set; }

            [NameInMap("MonthSaleNum")]
            [Validation(Required=false)]
            public long? MonthSaleNum { get; set; }

            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            [NameInMap("PremiumRateScope")]
            [Validation(Required=false)]
            public string PremiumRateScope { get; set; }

            [NameInMap("PriceCentScope")]
            [Validation(Required=false)]
            public string PriceCentScope { get; set; }

            [NameInMap("PropertiesJson")]
            [Validation(Required=false)]
            public string PropertiesJson { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservedPrice")]
            [Validation(Required=false)]
            public long? ReservedPrice { get; set; }

            [NameInMap("ReservedPriceScope")]
            [Validation(Required=false)]
            public string ReservedPriceScope { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }

            [NameInMap("SessionQuantity")]
            [Validation(Required=false)]
            public long? SessionQuantity { get; set; }

            [NameInMap("ShopId")]
            [Validation(Required=false)]
            public long? ShopId { get; set; }

            [NameInMap("SkuList")]
            [Validation(Required=false)]
            public List<ListDistributionItemResponseBodyModelSkuList> SkuList { get; set; }
            public class ListDistributionItemResponseBodyModelSkuList : TeaModel {
                [NameInMap("AdminStatus")]
                [Validation(Required=false)]
                public int? AdminStatus { get; set; }

                [NameInMap("AliyunPriceCent")]
                [Validation(Required=false)]
                public long? AliyunPriceCent { get; set; }

                [NameInMap("BenefitId")]
                [Validation(Required=false)]
                public string BenefitId { get; set; }

                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("CustomerStatus")]
                [Validation(Required=false)]
                public int? CustomerStatus { get; set; }

                [NameInMap("CustomizedAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomizedAttributeMap { get; set; }

                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public double? DiscountRate { get; set; }

                [NameInMap("DisparityPrice")]
                [Validation(Required=false)]
                public long? DisparityPrice { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IcStatus")]
                [Validation(Required=false)]
                public int? IcStatus { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmAttributeModels")]
                [Validation(Required=false)]
                public List<ListDistributionItemResponseBodyModelSkuListLmAttributeModels> LmAttributeModels { get; set; }
                public class ListDistributionItemResponseBodyModelSkuListLmAttributeModels : TeaModel {
                    [NameInMap("AttrId")]
                    [Validation(Required=false)]
                    public long? AttrId { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public int? Category { get; set; }

                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Restriction")]
                    [Validation(Required=false)]
                    public string Restriction { get; set; }

                    [NameInMap("ScopeList")]
                    [Validation(Required=false)]
                    public List<string> ScopeList { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("MainPriceCent")]
                [Validation(Required=false)]
                public long? MainPriceCent { get; set; }

                [NameInMap("MaxAllowedCount")]
                [Validation(Required=false)]
                public int? MaxAllowedCount { get; set; }

                [NameInMap("OriginalPriceCent")]
                [Validation(Required=false)]
                public long? OriginalPriceCent { get; set; }

                [NameInMap("PointPrice")]
                [Validation(Required=false)]
                public long? PointPrice { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public long? Points { get; set; }

                [NameInMap("PointsAmount")]
                [Validation(Required=false)]
                public long? PointsAmount { get; set; }

                [NameInMap("PointsInfo")]
                [Validation(Required=false)]
                public string PointsInfo { get; set; }

                [NameInMap("PointsKey")]
                [Validation(Required=false)]
                public string PointsKey { get; set; }

                [NameInMap("PremiumRate")]
                [Validation(Required=false)]
                public double? PremiumRate { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SkuDesc")]
                [Validation(Required=false)]
                public string SkuDesc { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuPicUrl")]
                [Validation(Required=false)]
                public string SkuPicUrl { get; set; }

                [NameInMap("SkuProperties")]
                [Validation(Required=false)]
                public Dictionary<string, string> SkuProperties { get; set; }

                [NameInMap("SkuPropertiesJson")]
                [Validation(Required=false)]
                public string SkuPropertiesJson { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StepPrices")]
                [Validation(Required=false)]
                public List<ListDistributionItemResponseBodyModelSkuListStepPrices> StepPrices { get; set; }
                public class ListDistributionItemResponseBodyModelSkuListStepPrices : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    [NameInMap("PriceCent")]
                    [Validation(Required=false)]
                    public long? PriceCent { get; set; }

                }

                [NameInMap("SupplierStatus")]
                [Validation(Required=false)]
                public int? SupplierStatus { get; set; }

                [NameInMap("SupplyPriceCent")]
                [Validation(Required=false)]
                public long? SupplyPriceCent { get; set; }

                [NameInMap("TaoBaoCurrentPrice")]
                [Validation(Required=false)]
                public long? TaoBaoCurrentPrice { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                [NameInMap("UserLabel")]
                [Validation(Required=false)]
                public List<string> UserLabel { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SupplyPriceCentScope")]
            [Validation(Required=false)]
            public string SupplyPriceCentScope { get; set; }

            [NameInMap("TaoBaoCurrentPriceScope")]
            [Validation(Required=false)]
            public string TaoBaoCurrentPriceScope { get; set; }

            [NameInMap("TbShopName")]
            [Validation(Required=false)]
            public string TbShopName { get; set; }

            [NameInMap("Tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

            [NameInMap("TotalSoldQuantity")]
            [Validation(Required=false)]
            public int? TotalSoldQuantity { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("UserCashPointsScope")]
            [Validation(Required=false)]
            public string UserCashPointsScope { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
