// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreatePayUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CreatePayUrlResponseBodyModel Model { get; set; }
        public class CreatePayUrlResponseBodyModel : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<string> LmOrderList { get; set; }

            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public List<string> OrderIds { get; set; }

            [NameInMap("PayTradeIds")]
            [Validation(Required=false)]
            public List<string> PayTradeIds { get; set; }

            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
