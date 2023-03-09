// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180701.Models
{
    public class GetCreditInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreditInfoResponseBodyData Data { get; set; }
        public class GetCreditInfoResponseBodyData : TeaModel {
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            [NameInMap("AlarmThreshold")]
            [Validation(Required=false)]
            public string AlarmThreshold { get; set; }

            [NameInMap("AvailableCredit")]
            [Validation(Required=false)]
            public string AvailableCredit { get; set; }

            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            [NameInMap("OutstandingBalance")]
            [Validation(Required=false)]
            public string OutstandingBalance { get; set; }

            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
