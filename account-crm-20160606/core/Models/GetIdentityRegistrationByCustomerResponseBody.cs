// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetIdentityRegistrationByCustomerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIdentityRegistrationByCustomerResponseBodyData Data { get; set; }
        public class GetIdentityRegistrationByCustomerResponseBodyData : TeaModel {
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            [NameInMap("ApplyStatus")]
            [Validation(Required=false)]
            public string ApplyStatus { get; set; }

            [NameInMap("AuditCode")]
            [Validation(Required=false)]
            public string AuditCode { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

            [NameInMap("DocBackPic")]
            [Validation(Required=false)]
            public string DocBackPic { get; set; }

            [NameInMap("DocFrontPic")]
            [Validation(Required=false)]
            public string DocFrontPic { get; set; }

            [NameInMap("DocNum")]
            [Validation(Required=false)]
            public string DocNum { get; set; }

            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("RegisteredAddress")]
            [Validation(Required=false)]
            public string RegisteredAddress { get; set; }

            [NameInMap("RegisteredCountry")]
            [Validation(Required=false)]
            public string RegisteredCountry { get; set; }

            [NameInMap("RegisteredNum")]
            [Validation(Required=false)]
            public string RegisteredNum { get; set; }

            [NameInMap("Tel")]
            [Validation(Required=false)]
            public string Tel { get; set; }

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
