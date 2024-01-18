// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RenderH5OrderResponseBody : TeaModel {
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
        public RenderH5OrderResponseBodyModel Model { get; set; }
        public class RenderH5OrderResponseBodyModel : TeaModel {
            [NameInMap("AddressInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelAddressInfoList> AddressInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelAddressInfoList : TeaModel {
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                [NameInMap("AddressId")]
                [Validation(Required=false)]
                public long? AddressId { get; set; }

                [NameInMap("Default")]
                [Validation(Required=false)]
                public bool? Default { get; set; }

                [NameInMap("DivisionCode")]
                [Validation(Required=false)]
                public string DivisionCode { get; set; }

                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("ReceiverPhone")]
                [Validation(Required=false)]
                public string ReceiverPhone { get; set; }

            }

            [NameInMap("BuyerCurrentPoints")]
            [Validation(Required=false)]
            public long? BuyerCurrentPoints { get; set; }

            [NameInMap("DeliveryInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelDeliveryInfoList> DeliveryInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelDeliveryInfoList : TeaModel {
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
            public Dictionary<string, object> ExtInfo { get; set; }

            [NameInMap("InvoiceInfo")]
            [Validation(Required=false)]
            public RenderH5OrderResponseBodyModelInvoiceInfo InvoiceInfo { get; set; }
            public class RenderH5OrderResponseBodyModelInvoiceInfo : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("LmItemInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelLmItemInfoList> LmItemInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelLmItemInfoList : TeaModel {
                [NameInMap("ActualPrice")]
                [Validation(Required=false)]
                public long? ActualPrice { get; set; }

                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("Cash")]
                [Validation(Required=false)]
                public long? Cash { get; set; }

                [NameInMap("Features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("ItemPicUrl")]
                [Validation(Required=false)]
                public string ItemPicUrl { get; set; }

                [NameInMap("ItemUrl")]
                [Validation(Required=false)]
                public string ItemUrl { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
                public long? Points { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("SellerNick")]
                [Validation(Required=false)]
                public string SellerNick { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public long? SkuId { get; set; }

                [NameInMap("SkuName")]
                [Validation(Required=false)]
                public string SkuName { get; set; }

                [NameInMap("TbShopName")]
                [Validation(Required=false)]
                public string TbShopName { get; set; }

                [NameInMap("VirtualItemType")]
                [Validation(Required=false)]
                public string VirtualItemType { get; set; }

            }

        }

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
