// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryItemDetailResponseBody : TeaModel {
        [NameInMap("BizViewData")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizViewData { get; set; }

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
        public QueryItemDetailResponseBodyModel Model { get; set; }
        public class QueryItemDetailResponseBodyModel : TeaModel {
            [NameInMap("AuctionStatus")]
            [Validation(Required=false)]
            public int? AuctionStatus { get; set; }

            [NameInMap("CanNotBeSoldCode")]
            [Validation(Required=false)]
            public string CanNotBeSoldCode { get; set; }

            [NameInMap("CanNotBeSoldMassage")]
            [Validation(Required=false)]
            public string CanNotBeSoldMassage { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryIds")]
            [Validation(Required=false)]
            public List<long?> CategoryIds { get; set; }

            [NameInMap("CenterInventory")]
            [Validation(Required=false)]
            public bool? CenterInventory { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            [NameInMap("CustomizedAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomizedAttributeMap { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DescPath")]
            [Validation(Required=false)]
            public string DescPath { get; set; }

            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("Features")]
            [Validation(Required=false)]
            public Dictionary<string, string> Features { get; set; }

            [NameInMap("FirstPicUrl")]
            [Validation(Required=false)]
            public string FirstPicUrl { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("HasQuantity")]
            [Validation(Required=false)]
            public bool? HasQuantity { get; set; }

            [NameInMap("IforestProps")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> IforestProps { get; set; }

            [NameInMap("InvoiceType")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

            [NameInMap("IsCanSell")]
            [Validation(Required=false)]
            public bool? IsCanSell { get; set; }

            [NameInMap("IsSellerPayPostfee")]
            [Validation(Required=false)]
            public bool? IsSellerPayPostfee { get; set; }

            [NameInMap("ItemDesc")]
            [Validation(Required=false)]
            public string ItemDesc { get; set; }

            [NameInMap("ItemExtendedPropModelMap")]
            [Validation(Required=false)]
            public Dictionary<string, ModelItemExtendedPropModelMapValue> ItemExtendedPropModelMap { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("ItemTotalSimpleValue")]
            [Validation(Required=false)]
            public string ItemTotalSimpleValue { get; set; }

            [NameInMap("ItemTotalValue")]
            [Validation(Required=false)]
            public int? ItemTotalValue { get; set; }

            [NameInMap("LmItemAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> LmItemAttributeMap { get; set; }

            [NameInMap("LmItemCategory")]
            [Validation(Required=false)]
            public string LmItemCategory { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("LmShopId")]
            [Validation(Required=false)]
            public long? LmShopId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MinPoints")]
            [Validation(Required=false)]
            public long? MinPoints { get; set; }

            [NameInMap("MinPrice")]
            [Validation(Required=false)]
            public long? MinPrice { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Properties { get; set; }

            [NameInMap("Prov")]
            [Validation(Required=false)]
            public string Prov { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("SecuredTransactions")]
            [Validation(Required=false)]
            public int? SecuredTransactions { get; set; }

            [NameInMap("SimpleQuantity")]
            [Validation(Required=false)]
            public string SimpleQuantity { get; set; }

            [NameInMap("SkuModels")]
            [Validation(Required=false)]
            public List<QueryItemDetailResponseBodyModelSkuModels> SkuModels { get; set; }
            public class QueryItemDetailResponseBodyModelSkuModels : TeaModel {
                [NameInMap("CanNotBeSoldCode")]
                [Validation(Required=false)]
                public string CanNotBeSoldCode { get; set; }

                [NameInMap("CanNotBeSoldMassage")]
                [Validation(Required=false)]
                public string CanNotBeSoldMassage { get; set; }

                [NameInMap("CustomizedAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomizedAttributeMap { get; set; }

                [NameInMap("DistributionMallId")]
                [Validation(Required=false)]
                public string DistributionMallId { get; set; }

                [NameInMap("ExtJson")]
                [Validation(Required=false)]
                public string ExtJson { get; set; }

                [NameInMap("GradePriceModels")]
                [Validation(Required=false)]
                public List<QueryItemDetailResponseBodyModelSkuModelsGradePriceModels> GradePriceModels { get; set; }
                public class QueryItemDetailResponseBodyModelSkuModelsGradePriceModels : TeaModel {
                    [NameInMap("AccessUrl")]
                    [Validation(Required=false)]
                    public string AccessUrl { get; set; }

                    [NameInMap("CanBuy")]
                    [Validation(Required=false)]
                    public bool? CanBuy { get; set; }

                    [NameInMap("CharacteristicCode")]
                    [Validation(Required=false)]
                    public string CharacteristicCode { get; set; }

                    [NameInMap("CharacteristicName")]
                    [Validation(Required=false)]
                    public string CharacteristicName { get; set; }

                    [NameInMap("Exclusive")]
                    [Validation(Required=false)]
                    public bool? Exclusive { get; set; }

                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("PointPrice")]
                    [Validation(Required=false)]
                    public long? PointPrice { get; set; }

                    [NameInMap("Points")]
                    [Validation(Required=false)]
                    public long? Points { get; set; }

                    [NameInMap("PointsAmount")]
                    [Validation(Required=false)]
                    public long? PointsAmount { get; set; }

                    [NameInMap("PriceCent")]
                    [Validation(Required=false)]
                    public long? PriceCent { get; set; }

                    [NameInMap("Recommend")]
                    [Validation(Required=false)]
                    public bool? Recommend { get; set; }

                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    [NameInMap("SubBizCode")]
                    [Validation(Required=false)]
                    public string SubBizCode { get; set; }

                    [NameInMap("UserLabelList")]
                    [Validation(Required=false)]
                    public List<string> UserLabelList { get; set; }

                }

                [NameInMap("HasQuantity")]
                [Validation(Required=false)]
                public bool? HasQuantity { get; set; }

                [NameInMap("InvoiceType")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LmItemSkuStepPriceModels")]
                [Validation(Required=false)]
                public List<QueryItemDetailResponseBodyModelSkuModelsLmItemSkuStepPriceModels> LmItemSkuStepPriceModels { get; set; }
                public class QueryItemDetailResponseBodyModelSkuModelsLmItemSkuStepPriceModels : TeaModel {
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

                [NameInMap("LmSkuAttributeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> LmSkuAttributeMap { get; set; }

                [NameInMap("PriceCent")]
                [Validation(Required=false)]
                public long? PriceCent { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SimpleQuantity")]
                [Validation(Required=false)]
                public string SimpleQuantity { get; set; }

                [NameInMap("SkuDesc")]
                [Validation(Required=false)]
                public string SkuDesc { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuPicUrl")]
                [Validation(Required=false)]
                public string SkuPicUrl { get; set; }

                [NameInMap("SkuPvs")]
                [Validation(Required=false)]
                public string SkuPvs { get; set; }

                [NameInMap("SkuTitle")]
                [Validation(Required=false)]
                public string SkuTitle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SupplierPrice")]
                [Validation(Required=false)]
                public long? SupplierPrice { get; set; }

            }

            [NameInMap("SkuPropertys")]
            [Validation(Required=false)]
            public List<QueryItemDetailResponseBodyModelSkuPropertys> SkuPropertys { get; set; }
            public class QueryItemDetailResponseBodyModelSkuPropertys : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<QueryItemDetailResponseBodyModelSkuPropertysValues> Values { get; set; }
                public class QueryItemDetailResponseBodyModelSkuPropertysValues : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

            [NameInMap("ThirdPartyItemId")]
            [Validation(Required=false)]
            public string ThirdPartyItemId { get; set; }

            [NameInMap("ThirdPartyName")]
            [Validation(Required=false)]
            public string ThirdPartyName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            [NameInMap("VideoPicUrl")]
            [Validation(Required=false)]
            public string VideoPicUrl { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            [NameInMap("VirtualItemType")]
            [Validation(Required=false)]
            public string VirtualItemType { get; set; }

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
