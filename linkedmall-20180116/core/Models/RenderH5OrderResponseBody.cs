// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RenderH5OrderResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public RenderH5OrderResponseBodyModel Model { get; set; }
        public class RenderH5OrderResponseBodyModel : TeaModel {
            [NameInMap("BuyerCurrentPoints")]
            [Validation(Required=false)]
            public long? BuyerCurrentPoints { get; set; }
            [NameInMap("InvoiceInfo")]
            [Validation(Required=false)]
            public RenderH5OrderResponseBodyModelInvoiceInfo InvoiceInfo { get; set; }
            public class RenderH5OrderResponseBodyModelInvoiceInfo : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

            }
            [NameInMap("DeliveryInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelDeliveryInfoList> DeliveryInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelDeliveryInfoList : TeaModel {
                public string DisplayName { get; set; }
                public long? PostFee { get; set; }
                public long? ServiceType { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("LmItemInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelLmItemInfoList> LmItemInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelLmItemInfoList : TeaModel {
                public string LmItemId { get; set; }
                public long? SellerId { get; set; }
                public string TbShopName { get; set; }
                public string Message { get; set; }
                public long? ItemId { get; set; }
                public long? Cash { get; set; }
                public bool? CanSell { get; set; }
                public string VirtualItemType { get; set; }
                public string ItemName { get; set; }
                public string SkuName { get; set; }
                public long? ActualPrice { get; set; }
                public long? SkuId { get; set; }
                public long? Points { get; set; }
                public string ItemUrl { get; set; }
                public string SellerNick { get; set; }
                public int? Quantity { get; set; }
                public Dictionary<string, string> Features { get; set; }
                public string ItemPicUrl { get; set; }
            }
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }
            [NameInMap("AddressInfoList")]
            [Validation(Required=false)]
            public List<RenderH5OrderResponseBodyModelAddressInfoList> AddressInfoList { get; set; }
            public class RenderH5OrderResponseBodyModelAddressInfoList : TeaModel {
                public string DivisionCode { get; set; }
                public string Receiver { get; set; }
                public string AddressDetail { get; set; }
                public bool? Default { get; set; }
                public long? AddressId { get; set; }
                public string ReceiverPhone { get; set; }
            }
        };

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
