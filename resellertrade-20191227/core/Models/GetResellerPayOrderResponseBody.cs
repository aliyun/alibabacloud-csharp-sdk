// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class GetResellerPayOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResellerPayOrderResponseBodyData Data { get; set; }
        public class GetResellerPayOrderResponseBodyData : TeaModel {
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            [NameInMap("PayAmount")]
            [Validation(Required=false)]
            public string PayAmount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
