// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateMovieTicketOrderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CreateMovieTicketOrderResponseBodyModel Model { get; set; }
        public class CreateMovieTicketOrderResponseBodyModel : TeaModel {
            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }
            [NameInMap("PayTradeIds")]
            [Validation(Required=false)]
            public CreateMovieTicketOrderResponseBodyModelPayTradeIds PayTradeIds { get; set; }
            public class CreateMovieTicketOrderResponseBodyModelPayTradeIds : TeaModel {
                [NameInMap("PayTradeIds")]
                [Validation(Required=false)]
                public List<string> PayTradeIds { get; set; }

            }
            [NameInMap("OrderIds")]
            [Validation(Required=false)]
            public CreateMovieTicketOrderResponseBodyModelOrderIds OrderIds { get; set; }
            public class CreateMovieTicketOrderResponseBodyModelOrderIds : TeaModel {
                [NameInMap("OrderIds")]
                [Validation(Required=false)]
                public List<string> OrderIds { get; set; }

            }
        };

    }

}
