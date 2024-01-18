// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateOrderV2ResponseBody : TeaModel {
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
        public CreateOrderV2ResponseBodyModel Model { get; set; }
        public class CreateOrderV2ResponseBodyModel : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public CreateOrderV2ResponseBodyModelLmOrderList LmOrderList { get; set; }
            public class CreateOrderV2ResponseBodyModelLmOrderList : TeaModel {
                [NameInMap("LmOrderList")]
                [Validation(Required=false)]
                public List<CreateOrderV2ResponseBodyModelLmOrderListLmOrderList> LmOrderList { get; set; }
                public class CreateOrderV2ResponseBodyModelLmOrderListLmOrderList : TeaModel {
                    [NameInMap("LmOrderId")]
                    [Validation(Required=false)]
                    public string LmOrderId { get; set; }

                }

            }

            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public CreateOrderV2ResponseBodyModelOrderIds OrderIds { get; set; }
            public class CreateOrderV2ResponseBodyModelOrderIds : TeaModel {
                [NameInMap("OrderIds")]
                [Validation(Required=false)]
                public List<string> OrderIds { get; set; }

            }

            [NameInMap("PayTradeIds")]
            [Validation(Required=false)]
            public CreateOrderV2ResponseBodyModelPayTradeIds PayTradeIds { get; set; }
            public class CreateOrderV2ResponseBodyModelPayTradeIds : TeaModel {
                [NameInMap("PayTradeIds")]
                [Validation(Required=false)]
                public List<string> PayTradeIds { get; set; }

            }

            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

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
