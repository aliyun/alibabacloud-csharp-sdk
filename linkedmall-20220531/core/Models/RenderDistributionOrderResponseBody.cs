// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class RenderDistributionOrderResponseBody : TeaModel {
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
        public RenderDistributionOrderResponseBodyModel Model { get; set; }
        public class RenderDistributionOrderResponseBodyModel : TeaModel {
            [NameInMap("AddressInfos")]
            [Validation(Required=false)]
            public List<RenderDistributionOrderResponseBodyModelAddressInfos> AddressInfos { get; set; }
            public class RenderDistributionOrderResponseBodyModelAddressInfos : TeaModel {
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                [NameInMap("AddressId")]
                [Validation(Required=false)]
                public long? AddressId { get; set; }

                [NameInMap("DivisionCode")]
                [Validation(Required=false)]
                public string DivisionCode { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("ReceiverPhone")]
                [Validation(Required=false)]
                public string ReceiverPhone { get; set; }

                [NameInMap("TownDivisionCode")]
                [Validation(Required=false)]
                public string TownDivisionCode { get; set; }

            }

            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("RenderOrderInfos")]
            [Validation(Required=false)]
            public List<RenderDistributionOrderResponseBodyModelRenderOrderInfos> RenderOrderInfos { get; set; }
            public class RenderDistributionOrderResponseBodyModelRenderOrderInfos : TeaModel {
                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("DeliveryInfos")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosDeliveryInfos> DeliveryInfos { get; set; }
                public class RenderDistributionOrderResponseBodyModelRenderOrderInfosDeliveryInfos : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("PostFee")]
                    [Validation(Required=false)]
                    public long? PostFee { get; set; }

                    [NameInMap("ServiceType")]
                    [Validation(Required=false)]
                    public long? ServiceType { get; set; }

                }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtInfo { get; set; }

                [NameInMap("InvoiceInfo")]
                [Validation(Required=false)]
                public RenderDistributionOrderResponseBodyModelRenderOrderInfosInvoiceInfo InvoiceInfo { get; set; }
                public class RenderDistributionOrderResponseBodyModelRenderOrderInfosInvoiceInfo : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ItemInfos")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfos> ItemInfos { get; set; }
                public class RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfos : TeaModel {
                    [NameInMap("CanSell")]
                    [Validation(Required=false)]
                    public bool? CanSell { get; set; }

                    [NameInMap("DistributionMallId")]
                    [Validation(Required=false)]
                    public string DistributionMallId { get; set; }

                    [NameInMap("DistributionSupplierId")]
                    [Validation(Required=false)]
                    public string DistributionSupplierId { get; set; }

                    [NameInMap("DistributorId")]
                    [Validation(Required=false)]
                    public string DistributorId { get; set; }

                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Features { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("ItemPicUrl")]
                    [Validation(Required=false)]
                    public string ItemPicUrl { get; set; }

                    [NameInMap("ItemPromInstVOS")]
                    [Validation(Required=false)]
                    public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfosItemPromInstVOS> ItemPromInstVOS { get; set; }
                    public class RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfosItemPromInstVOS : TeaModel {
                        [NameInMap("AvailableItems")]
                        [Validation(Required=false)]
                        public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfosItemPromInstVOSAvailableItems> AvailableItems { get; set; }
                        public class RenderDistributionOrderResponseBodyModelRenderOrderInfosItemInfosItemPromInstVOSAvailableItems : TeaModel {
                            [NameInMap("ItemId")]
                            [Validation(Required=false)]
                            public long? ItemId { get; set; }

                            [NameInMap("LmItemId")]
                            [Validation(Required=false)]
                            public string LmItemId { get; set; }

                            [NameInMap("LmShopId")]
                            [Validation(Required=false)]
                            public long? LmShopId { get; set; }

                            [NameInMap("Number")]
                            [Validation(Required=false)]
                            public int? Number { get; set; }

                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public long? Points { get; set; }

                            [NameInMap("PointsAmount")]
                            [Validation(Required=false)]
                            public long? PointsAmount { get; set; }

                            [NameInMap("PriceCent")]
                            [Validation(Required=false)]
                            public long? PriceCent { get; set; }

                            [NameInMap("Removed")]
                            [Validation(Required=false)]
                            public bool? Removed { get; set; }

                            [NameInMap("SkuId")]
                            [Validation(Required=false)]
                            public long? SkuId { get; set; }

                            [NameInMap("TbSellerId")]
                            [Validation(Required=false)]
                            public long? TbSellerId { get; set; }

                            [NameInMap("UserPayFee")]
                            [Validation(Required=false)]
                            public long? UserPayFee { get; set; }

                        }

                        [NameInMap("CanUse")]
                        [Validation(Required=false)]
                        public bool? CanUse { get; set; }

                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public long? DiscountPrice { get; set; }

                        [NameInMap("ExpireTime")]
                        [Validation(Required=false)]
                        public long? ExpireTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        [NameInMap("PromotionType")]
                        [Validation(Required=false)]
                        public string PromotionType { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        [NameInMap("SkuIds")]
                        [Validation(Required=false)]
                        public List<long?> SkuIds { get; set; }

                        [NameInMap("SpecialPrice")]
                        [Validation(Required=false)]
                        public long? SpecialPrice { get; set; }

                        [NameInMap("SubBizCode")]
                        [Validation(Required=false)]
                        public string SubBizCode { get; set; }

                        [NameInMap("TbSellerId")]
                        [Validation(Required=false)]
                        public long? TbSellerId { get; set; }

                        [NameInMap("ThresholdPrice")]
                        [Validation(Required=false)]
                        public long? ThresholdPrice { get; set; }

                        [NameInMap("UseStartTime")]
                        [Validation(Required=false)]
                        public long? UseStartTime { get; set; }

                    }

                    [NameInMap("ItemUrl")]
                    [Validation(Required=false)]
                    public string ItemUrl { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    [NameInMap("PromotionFee")]
                    [Validation(Required=false)]
                    public long? PromotionFee { get; set; }

                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public int? Quantity { get; set; }

                    [NameInMap("ReservePrice")]
                    [Validation(Required=false)]
                    public long? ReservePrice { get; set; }

                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public long? SkuId { get; set; }

                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                    [NameInMap("VirtualItemType")]
                    [Validation(Required=false)]
                    public string VirtualItemType { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ShopPromInstVOS")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosShopPromInstVOS> ShopPromInstVOS { get; set; }
                public class RenderDistributionOrderResponseBodyModelRenderOrderInfosShopPromInstVOS : TeaModel {
                    [NameInMap("AvailableItems")]
                    [Validation(Required=false)]
                    public List<RenderDistributionOrderResponseBodyModelRenderOrderInfosShopPromInstVOSAvailableItems> AvailableItems { get; set; }
                    public class RenderDistributionOrderResponseBodyModelRenderOrderInfosShopPromInstVOSAvailableItems : TeaModel {
                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("LmShopId")]
                        [Validation(Required=false)]
                        public long? LmShopId { get; set; }

                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public int? Number { get; set; }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("Removed")]
                        [Validation(Required=false)]
                        public bool? Removed { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("TbSellerId")]
                        [Validation(Required=false)]
                        public long? TbSellerId { get; set; }

                        [NameInMap("UserPayFee")]
                        [Validation(Required=false)]
                        public long? UserPayFee { get; set; }

                    }

                    [NameInMap("CanUse")]
                    [Validation(Required=false)]
                    public bool? CanUse { get; set; }

                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public long? DiscountPrice { get; set; }

                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public long? ExpireTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("LmItemId")]
                    [Validation(Required=false)]
                    public string LmItemId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    [NameInMap("PromotionType")]
                    [Validation(Required=false)]
                    public string PromotionType { get; set; }

                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                    [NameInMap("SkuIds")]
                    [Validation(Required=false)]
                    public List<long?> SkuIds { get; set; }

                    [NameInMap("SpecialPrice")]
                    [Validation(Required=false)]
                    public long? SpecialPrice { get; set; }

                    [NameInMap("SubBizCode")]
                    [Validation(Required=false)]
                    public string SubBizCode { get; set; }

                    [NameInMap("TbSellerId")]
                    [Validation(Required=false)]
                    public long? TbSellerId { get; set; }

                    [NameInMap("ThresholdPrice")]
                    [Validation(Required=false)]
                    public long? ThresholdPrice { get; set; }

                    [NameInMap("UseStartTime")]
                    [Validation(Required=false)]
                    public long? UseStartTime { get; set; }

                }

            }

            [NameInMap("UnsellableRenderOrderInfos")]
            [Validation(Required=false)]
            public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfos> UnsellableRenderOrderInfos { get; set; }
            public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfos : TeaModel {
                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("DeliveryInfos")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosDeliveryInfos> DeliveryInfos { get; set; }
                public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosDeliveryInfos : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("PostFee")]
                    [Validation(Required=false)]
                    public long? PostFee { get; set; }

                    [NameInMap("ServiceType")]
                    [Validation(Required=false)]
                    public long? ServiceType { get; set; }

                }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtInfo { get; set; }

                [NameInMap("InvoiceInfo")]
                [Validation(Required=false)]
                public RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosInvoiceInfo InvoiceInfo { get; set; }
                public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosInvoiceInfo : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ItemInfos")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfos> ItemInfos { get; set; }
                public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfos : TeaModel {
                    [NameInMap("CanSell")]
                    [Validation(Required=false)]
                    public bool? CanSell { get; set; }

                    [NameInMap("DistributionMallId")]
                    [Validation(Required=false)]
                    public string DistributionMallId { get; set; }

                    [NameInMap("DistributionSupplierId")]
                    [Validation(Required=false)]
                    public string DistributionSupplierId { get; set; }

                    [NameInMap("DistributorId")]
                    [Validation(Required=false)]
                    public string DistributorId { get; set; }

                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Features { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("ItemPicUrl")]
                    [Validation(Required=false)]
                    public string ItemPicUrl { get; set; }

                    [NameInMap("ItemPromInstVOS")]
                    [Validation(Required=false)]
                    public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfosItemPromInstVOS> ItemPromInstVOS { get; set; }
                    public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfosItemPromInstVOS : TeaModel {
                        [NameInMap("AvailableItems")]
                        [Validation(Required=false)]
                        public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfosItemPromInstVOSAvailableItems> AvailableItems { get; set; }
                        public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosItemInfosItemPromInstVOSAvailableItems : TeaModel {
                            [NameInMap("ItemId")]
                            [Validation(Required=false)]
                            public long? ItemId { get; set; }

                            [NameInMap("LmItemId")]
                            [Validation(Required=false)]
                            public string LmItemId { get; set; }

                            [NameInMap("LmShopId")]
                            [Validation(Required=false)]
                            public long? LmShopId { get; set; }

                            [NameInMap("Number")]
                            [Validation(Required=false)]
                            public int? Number { get; set; }

                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public long? Points { get; set; }

                            [NameInMap("PointsAmount")]
                            [Validation(Required=false)]
                            public long? PointsAmount { get; set; }

                            [NameInMap("PriceCent")]
                            [Validation(Required=false)]
                            public long? PriceCent { get; set; }

                            [NameInMap("Removed")]
                            [Validation(Required=false)]
                            public bool? Removed { get; set; }

                            [NameInMap("SkuId")]
                            [Validation(Required=false)]
                            public long? SkuId { get; set; }

                            [NameInMap("TbSellerId")]
                            [Validation(Required=false)]
                            public long? TbSellerId { get; set; }

                            [NameInMap("UserPayFee")]
                            [Validation(Required=false)]
                            public long? UserPayFee { get; set; }

                        }

                        [NameInMap("CanUse")]
                        [Validation(Required=false)]
                        public bool? CanUse { get; set; }

                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public long? DiscountPrice { get; set; }

                        [NameInMap("ExpireTime")]
                        [Validation(Required=false)]
                        public long? ExpireTime { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        [NameInMap("PromotionType")]
                        [Validation(Required=false)]
                        public string PromotionType { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        [NameInMap("SkuIds")]
                        [Validation(Required=false)]
                        public List<long?> SkuIds { get; set; }

                        [NameInMap("SpecialPrice")]
                        [Validation(Required=false)]
                        public long? SpecialPrice { get; set; }

                        [NameInMap("SubBizCode")]
                        [Validation(Required=false)]
                        public string SubBizCode { get; set; }

                        [NameInMap("TbSellerId")]
                        [Validation(Required=false)]
                        public long? TbSellerId { get; set; }

                        [NameInMap("ThresholdPrice")]
                        [Validation(Required=false)]
                        public long? ThresholdPrice { get; set; }

                        [NameInMap("UseStartTime")]
                        [Validation(Required=false)]
                        public long? UseStartTime { get; set; }

                    }

                    [NameInMap("ItemUrl")]
                    [Validation(Required=false)]
                    public string ItemUrl { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    [NameInMap("PromotionFee")]
                    [Validation(Required=false)]
                    public long? PromotionFee { get; set; }

                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public int? Quantity { get; set; }

                    [NameInMap("ReservePrice")]
                    [Validation(Required=false)]
                    public long? ReservePrice { get; set; }

                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public long? SkuId { get; set; }

                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                    [NameInMap("VirtualItemType")]
                    [Validation(Required=false)]
                    public string VirtualItemType { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ShopPromInstVOS")]
                [Validation(Required=false)]
                public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosShopPromInstVOS> ShopPromInstVOS { get; set; }
                public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosShopPromInstVOS : TeaModel {
                    [NameInMap("AvailableItems")]
                    [Validation(Required=false)]
                    public List<RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosShopPromInstVOSAvailableItems> AvailableItems { get; set; }
                    public class RenderDistributionOrderResponseBodyModelUnsellableRenderOrderInfosShopPromInstVOSAvailableItems : TeaModel {
                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("LmShopId")]
                        [Validation(Required=false)]
                        public long? LmShopId { get; set; }

                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public int? Number { get; set; }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("Removed")]
                        [Validation(Required=false)]
                        public bool? Removed { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("TbSellerId")]
                        [Validation(Required=false)]
                        public long? TbSellerId { get; set; }

                        [NameInMap("UserPayFee")]
                        [Validation(Required=false)]
                        public long? UserPayFee { get; set; }

                    }

                    [NameInMap("CanUse")]
                    [Validation(Required=false)]
                    public bool? CanUse { get; set; }

                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public long? DiscountPrice { get; set; }

                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public long? ExpireTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("LmItemId")]
                    [Validation(Required=false)]
                    public string LmItemId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    [NameInMap("PromotionType")]
                    [Validation(Required=false)]
                    public string PromotionType { get; set; }

                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                    [NameInMap("SkuIds")]
                    [Validation(Required=false)]
                    public List<long?> SkuIds { get; set; }

                    [NameInMap("SpecialPrice")]
                    [Validation(Required=false)]
                    public long? SpecialPrice { get; set; }

                    [NameInMap("SubBizCode")]
                    [Validation(Required=false)]
                    public string SubBizCode { get; set; }

                    [NameInMap("TbSellerId")]
                    [Validation(Required=false)]
                    public long? TbSellerId { get; set; }

                    [NameInMap("ThresholdPrice")]
                    [Validation(Required=false)]
                    public long? ThresholdPrice { get; set; }

                    [NameInMap("UseStartTime")]
                    [Validation(Required=false)]
                    public long? UseStartTime { get; set; }

                }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
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
