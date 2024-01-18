// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryItemDetailInnerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public QueryItemDetailInnerResponseBodyItem Item { get; set; }
        public class QueryItemDetailInnerResponseBodyItem : TeaModel {
            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }

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

            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }

            [NameInMap("DescPath")]
            [Validation(Required=false)]
            public string DescPath { get; set; }

            [NameInMap("FirstPicUrl")]
            [Validation(Required=false)]
            public string FirstPicUrl { get; set; }

            [NameInMap("IforestProps")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> IforestProps { get; set; }

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
            public List<string> ItemImages { get; set; }

            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            [NameInMap("LmItemCategory")]
            [Validation(Required=false)]
            public string LmItemCategory { get; set; }

            [NameInMap("LmShopId")]
            [Validation(Required=false)]
            public long? LmShopId { get; set; }

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

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }

            [NameInMap("SellerNick")]
            [Validation(Required=false)]
            public string SellerNick { get; set; }

            [NameInMap("SellerPayPostfee")]
            [Validation(Required=false)]
            public bool? SellerPayPostfee { get; set; }

            [NameInMap("SkuPropertys")]
            [Validation(Required=false)]
            public List<QueryItemDetailInnerResponseBodyItemSkuPropertys> SkuPropertys { get; set; }
            public class QueryItemDetailInnerResponseBodyItemSkuPropertys : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<QueryItemDetailInnerResponseBodyItemSkuPropertysValues> Values { get; set; }
                public class QueryItemDetailInnerResponseBodyItemSkuPropertysValues : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

            }

            [NameInMap("Skus")]
            [Validation(Required=false)]
            public List<QueryItemDetailInnerResponseBodyItemSkus> Skus { get; set; }
            public class QueryItemDetailInnerResponseBodyItemSkus : TeaModel {
                [NameInMap("ExtJson")]
                [Validation(Required=false)]
                public string ExtJson { get; set; }

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

                [NameInMap("SkuDesc")]
                [Validation(Required=false)]
                public string SkuDesc { get; set; }

                /// <summary>
                /// skuid
                /// </summary>
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

            }

            [NameInMap("TbShopName")]
            [Validation(Required=false)]
            public string TbShopName { get; set; }

            [NameInMap("TotalSoldQuantity")]
            [Validation(Required=false)]
            public int? TotalSoldQuantity { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
