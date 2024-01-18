// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RenderOrderResponseBody : TeaModel {
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
        public RenderOrderResponseBodyModel Model { get; set; }
        public class RenderOrderResponseBodyModel : TeaModel {
            [NameInMap("RenderOrderInfos")]
            [Validation(Required=false)]
            public RenderOrderResponseBodyModelRenderOrderInfos RenderOrderInfos { get; set; }
            public class RenderOrderResponseBodyModelRenderOrderInfos : TeaModel {
                [NameInMap("RenderOrderInfos")]
                [Validation(Required=false)]
                public List<RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfos> RenderOrderInfos { get; set; }
                public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfos : TeaModel {
                    [NameInMap("DeliveryInfos")]
                    [Validation(Required=false)]
                    public RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfos DeliveryInfos { get; set; }
                    public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfos : TeaModel {
                        [NameInMap("DeliveryInfos")]
                        [Validation(Required=false)]
                        public List<RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfosDeliveryInfos> DeliveryInfos { get; set; }
                        public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfosDeliveryInfos : TeaModel {
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

                    }

                    [NameInMap("ExtInfo")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtInfo { get; set; }

                    [NameInMap("LmItemInfos")]
                    [Validation(Required=false)]
                    public RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfos LmItemInfos { get; set; }
                    public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfos : TeaModel {
                        [NameInMap("LmItemInfos")]
                        [Validation(Required=false)]
                        public List<RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfosLmItemInfos> LmItemInfos { get; set; }
                        public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfosLmItemInfos : TeaModel {
                            [NameInMap("ActualPrice")]
                            [Validation(Required=false)]
                            public long? ActualPrice { get; set; }

                            [NameInMap("CanSell")]
                            [Validation(Required=false)]
                            public bool? CanSell { get; set; }

                            [NameInMap("Cash")]
                            [Validation(Required=false)]
                            public long? Cash { get; set; }

                            [NameInMap("ItemId")]
                            [Validation(Required=false)]
                            public long? ItemId { get; set; }

                            [NameInMap("ItemName")]
                            [Validation(Required=false)]
                            public string ItemName { get; set; }

                            [NameInMap("ItemPicUrl")]
                            [Validation(Required=false)]
                            public string ItemPicUrl { get; set; }

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

                        }

                    }

                }

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
