// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetCustomerAccountInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerAccountInfoResponseBodyData Data { get; set; }
        public class GetCustomerAccountInfoResponseBodyData : TeaModel {
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("CreditLimitStatus")]
            [Validation(Required=false)]
            public string CreditLimitStatus { get; set; }

            [NameInMap("HostingStatus")]
            [Validation(Required=false)]
            public string HostingStatus { get; set; }

            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public bool? IsCertified { get; set; }

            [NameInMap("LoginEmail")]
            [Validation(Required=false)]
            public string LoginEmail { get; set; }

            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public long? Mpk { get; set; }

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
