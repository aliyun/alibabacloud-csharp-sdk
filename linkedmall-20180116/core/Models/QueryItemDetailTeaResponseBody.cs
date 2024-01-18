// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemDetailTeaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public QueryItemDetailTeaResponseBodyItem Item { get; set; }
        public class QueryItemDetailTeaResponseBodyItem : TeaModel {
            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CenterInventory")]
            [Validation(Required=false)]
            public bool? CenterInventory { get; set; }

            [NameInMap("CustomizedAttributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomizedAttributeMap { get; set; }

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DescPath")]
            [Validation(Required=false)]
            public string DescPath { get; set; }

            [NameInMap("ExtJson")]
            [Validation(Required=false)]
            public string ExtJson { get; set; }

            [NameInMap("FirstPicUrl")]
            [Validation(Required=false)]
            public string FirstPicUrl { get; set; }

            [NameInMap("HasQuantity")]
            [Validation(Required=false)]
            public bool? HasQuantity { get; set; }

            [NameInMap("IforestProps")]
            [Validation(Required=false)]
            public QueryItemDetailTeaResponseBodyItemIforestProps IforestProps { get; set; }
            public class QueryItemDetailTeaResponseBodyItemIforestProps : TeaModel {
                [NameInMap("IforestProp")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> IforestProp { get; set; }

            }

            [NameInMap("IsCanSell")]
            [Validation(Required=false)]
            public bool? IsCanSell { get; set; }

            [NameInMap("IsSellerPayPostfee")]
            [Validation(Required=false)]
            public bool? IsSellerPayPostfee { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public QueryItemDetailTeaResponseBodyItemItemImages ItemImages { get; set; }
            public class QueryItemDetailTeaResponseBodyItemItemImages : TeaModel {
                [NameInMap("ItemImage")]
                [Validation(Required=false)]
                public List<string> ItemImage { get; set; }

            }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("ItemTotalSimpleValue")]
            [Validation(Required=false)]
            public string ItemTotalSimpleValue { get; set; }

            [NameInMap("LmItemCategory")]
            [Validation(Required=false)]
            public string LmItemCategory { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("MinPoints")]
            [Validation(Required=false)]
            public long? MinPoints { get; set; }

            [NameInMap("MinPrice")]
            [Validation(Required=false)]
            public long? MinPrice { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }

            [NameInMap("SellerPayPostfee")]
            [Validation(Required=false)]
            public bool? SellerPayPostfee { get; set; }

            [NameInMap("SellerType")]
            [Validation(Required=false)]
            public int? SellerType { get; set; }

            [NameInMap("SimpleQuantity")]
            [Validation(Required=false)]
            public string SimpleQuantity { get; set; }

            [NameInMap("Skus")]
            [Validation(Required=false)]
            public QueryItemDetailTeaResponseBodyItemSkus Skus { get; set; }
            public class QueryItemDetailTeaResponseBodyItemSkus : TeaModel {
                [NameInMap("Sku")]
                [Validation(Required=false)]
                public List<QueryItemDetailTeaResponseBodyItemSkusSku> Sku { get; set; }
                public class QueryItemDetailTeaResponseBodyItemSkusSku : TeaModel {
                    [NameInMap("CanSell")]
                    [Validation(Required=false)]
                    public bool? CanSell { get; set; }

                    [NameInMap("CustomizedAttributeMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> CustomizedAttributeMap { get; set; }

                    [NameInMap("ExtJson")]
                    [Validation(Required=false)]
                    public string ExtJson { get; set; }

                    [NameInMap("HasQuantity")]
                    [Validation(Required=false)]
                    public bool? HasQuantity { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("LmItemId")]
                    [Validation(Required=false)]
                    public string LmItemId { get; set; }

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

                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public int? Quantity { get; set; }

                    [NameInMap("ReservePrice")]
                    [Validation(Required=false)]
                    public long? ReservePrice { get; set; }

                    [NameInMap("SimpleQuantity")]
                    [Validation(Required=false)]
                    public string SimpleQuantity { get; set; }

                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public long? SkuId { get; set; }

                    [NameInMap("SkuPicUrl")]
                    [Validation(Required=false)]
                    public string SkuPicUrl { get; set; }

                    [NameInMap("SkuProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> SkuProperties { get; set; }

                    [NameInMap("SkuTitle")]
                    [Validation(Required=false)]
                    public string SkuTitle { get; set; }

                }

            }

            [NameInMap("TbShopName")]
            [Validation(Required=false)]
            public string TbShopName { get; set; }

            [NameInMap("TotalSoldQuantity")]
            [Validation(Required=false)]
            public int? TotalSoldQuantity { get; set; }

            [NameInMap("TotalSoldSimpleQuantity")]
            [Validation(Required=false)]
            public string TotalSoldSimpleQuantity { get; set; }

            [NameInMap("VideoPicUrl")]
            [Validation(Required=false)]
            public string VideoPicUrl { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
