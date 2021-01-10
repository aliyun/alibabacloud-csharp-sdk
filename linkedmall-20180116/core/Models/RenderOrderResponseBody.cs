// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RenderOrderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
                    [NameInMap("ExtInfo")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ExtInfo { get; set; }

                    [NameInMap("LmItemInfos")]
                    [Validation(Required=false)]
                    public RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfos LmItemInfos { get; set; }
                    public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfos : TeaModel {
                        [NameInMap("LmItemInfos")]
                        [Validation(Required=false)]
                        public List<RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfosLmItemInfos> LmItemInfos { get; set; }
                        public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosLmItemInfosLmItemInfos : TeaModel {
                            public long? ItemId { get; set; }
                            public long? SkuId { get; set; }
                            public int? Quantity { get; set; }
                            public bool? CanSell { get; set; }
                            public string Message { get; set; }
                            public string ItemName { get; set; }
                            public string SkuName { get; set; }
                            public string LmItemId { get; set; }
                            public long? SellerId { get; set; }
                            public string SellerNick { get; set; }
                            public long? Cash { get; set; }
                            public long? Points { get; set; }
                            public long? ActualPrice { get; set; }
                            public string ItemPicUrl { get; set; }
                        }
                    };

                    [NameInMap("DeliveryInfos")]
                    [Validation(Required=false)]
                    public RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfos DeliveryInfos { get; set; }
                    public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfos : TeaModel {
                        [NameInMap("DeliveryInfos")]
                        [Validation(Required=false)]
                        public List<RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfosDeliveryInfos> DeliveryInfos { get; set; }
                        public class RenderOrderResponseBodyModelRenderOrderInfosRenderOrderInfosDeliveryInfosDeliveryInfos : TeaModel {
                            public string Id { get; set; }
                            public string DisplayName { get; set; }
                            public long? PostFee { get; set; }
                            public long? ServiceType { get; set; }
                        }
                    };

                }

            }
        };

    }

}
