// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetOrderDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderDetailResponseBodyData Data { get; set; }
        public class GetOrderDetailResponseBodyData : TeaModel {
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public long? ChargeType { get; set; }

            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public string Cycle { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public long? OrderStatus { get; set; }

            [NameInMap("OrderTypeName")]
            [Validation(Required=false)]
            public string OrderTypeName { get; set; }

            [NameInMap("PayAmount")]
            [Validation(Required=false)]
            public string PayAmount { get; set; }

            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("ResourceFee")]
            [Validation(Required=false)]
            public string ResourceFee { get; set; }

            [NameInMap("TotalPayFee")]
            [Validation(Required=false)]
            public string TotalPayFee { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
