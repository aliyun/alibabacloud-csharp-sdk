// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateOrderResponseBody : TeaModel {
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
        public CreateOrderResponseBodyModel Model { get; set; }
        public class CreateOrderResponseBodyModel : TeaModel {
            [NameInMap("PayTradeIds")]
            [Validation(Required=false)]
            public CreateOrderResponseBodyModelPayTradeIds PayTradeIds { get; set; }
            public class CreateOrderResponseBodyModelPayTradeIds : TeaModel {
                [NameInMap("PayTradeIds")]
                [Validation(Required=false)]
                public List<string> PayTradeIds { get; set; }

            }
            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public CreateOrderResponseBodyModelLmOrderList LmOrderList { get; set; }
            public class CreateOrderResponseBodyModelLmOrderList : TeaModel {
                [NameInMap("LmOrderList")]
                [Validation(Required=false)]
                public List<CreateOrderResponseBodyModelLmOrderListLmOrderList> LmOrderList { get; set; }
                public class CreateOrderResponseBodyModelLmOrderListLmOrderList : TeaModel {
                    [NameInMap("LmOrderId")]
                    [Validation(Required=false)]
                    public string LmOrderId { get; set; }

                }

            }
            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public CreateOrderResponseBodyModelOrderIds OrderIds { get; set; }
            public class CreateOrderResponseBodyModelOrderIds : TeaModel {
                [NameInMap("OrderIds")]
                [Validation(Required=false)]
                public List<string> OrderIds { get; set; }

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
