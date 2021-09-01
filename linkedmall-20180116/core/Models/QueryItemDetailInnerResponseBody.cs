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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public QueryItemDetailInnerResponseBodyItem Item { get; set; }
        public class QueryItemDetailInnerResponseBodyItem : TeaModel {
            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }
            [NameInMap("MinPoints")]
            [Validation(Required=false)]
            public long? MinPoints { get; set; }
            [NameInMap("DescOption")]
            [Validation(Required=false)]
            public string DescOption { get; set; }
            [NameInMap("IsSellerPayPostfee")]
            [Validation(Required=false)]
            public bool? IsSellerPayPostfee { get; set; }
            [NameInMap("LmItemCategory")]
            [Validation(Required=false)]
            public string LmItemCategory { get; set; }
            [NameInMap("SellerPayPostfee")]
            [Validation(Required=false)]
            public bool? SellerPayPostfee { get; set; }
            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public long? SellerId { get; set; }
            [NameInMap("TbShopName")]
            [Validation(Required=false)]
            public string TbShopName { get; set; }
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }
            [NameInMap("CanSell")]
            [Validation(Required=false)]
            public bool? CanSell { get; set; }
            [NameInMap("CenterInventory")]
            [Validation(Required=false)]
            public bool? CenterInventory { get; set; }
            [NameInMap("TotalSoldQuantity")]
            [Validation(Required=false)]
            public int? TotalSoldQuantity { get; set; }
            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }
            [NameInMap("MinPrice")]
            [Validation(Required=false)]
            public long? MinPrice { get; set; }
            [NameInMap("IsCanSell")]
            [Validation(Required=false)]
            public bool? IsCanSell { get; set; }
            [NameInMap("LmShopId")]
            [Validation(Required=false)]
            public long? LmShopId { get; set; }
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }
            [NameInMap("SellerNick")]
            [Validation(Required=false)]
            public string SellerNick { get; set; }
            [NameInMap("DescPath")]
            [Validation(Required=false)]
            public string DescPath { get; set; }
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, string> Properties { get; set; }
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }
            [NameInMap("Skus")]
            [Validation(Required=false)]
            public List<QueryItemDetailInnerResponseBodyItemSkus> Skus { get; set; }
            public class QueryItemDetailInnerResponseBodyItemSkus : TeaModel {
                public int? Status { get; set; }
                public long? PriceCent { get; set; }
                public string SkuPvs { get; set; }
                public string LmItemId { get; set; }
                public long? PointPrice { get; set; }
                public long? ItemId { get; set; }
                public string SkuTitle { get; set; }
                public string ExtJson { get; set; }
                public long? SkuId { get; set; }
                public string SkuPicUrl { get; set; }
                public long? Points { get; set; }
                public long? PointsAmount { get; set; }
                public long? ReservePrice { get; set; }
                public string SkuDesc { get; set; }
                public int? Quantity { get; set; }
            }
            [NameInMap("SkuPropertys")]
            [Validation(Required=false)]
            public List<QueryItemDetailInnerResponseBodyItemSkuPropertys> SkuPropertys { get; set; }
            public class QueryItemDetailInnerResponseBodyItemSkuPropertys : TeaModel {
                public string Text { get; set; }
                public long? Id { get; set; }
                public List<QueryItemDetailInnerResponseBodyItemSkuPropertysValues> Values { get; set; }
                public class QueryItemDetailInnerResponseBodyItemSkuPropertysValues : TeaModel {
                    public string Text { get; set; }
                    public long? Id { get; set; }
                }
            }
            [NameInMap("CategoryIds")]
            [Validation(Required=false)]
            public List<string> CategoryIds { get; set; }
            [NameInMap("IforestProps")]
            [Validation(Required=false)]
            public List<string> IforestProps { get; set; }
            [NameInMap("ItemImages")]
            [Validation(Required=false)]
            public List<string> ItemImages { get; set; }
        };

    }

}
