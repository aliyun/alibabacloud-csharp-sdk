// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBalanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountBalanceResponseBodyData Data { get; set; }
        public class QueryAccountBalanceResponseBodyData : TeaModel {
            [NameInMap("AvailableAmount")]
            [Validation(Required=false)]
            public string AvailableAmount { get; set; }

            [NameInMap("AvailableCashAmount")]
            [Validation(Required=false)]
            public string AvailableCashAmount { get; set; }

            [NameInMap("CreditAmount")]
            [Validation(Required=false)]
            public string CreditAmount { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("MybankCreditAmount")]
            [Validation(Required=false)]
            public string MybankCreditAmount { get; set; }

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
