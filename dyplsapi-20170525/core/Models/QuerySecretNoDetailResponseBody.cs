// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretNoInfoDTO")]
        [Validation(Required=false)]
        public QuerySecretNoDetailResponseBodySecretNoInfoDTO SecretNoInfoDTO { get; set; }
        public class QuerySecretNoDetailResponseBodySecretNoInfoDTO : TeaModel {
            [NameInMap("CertifyStatus")]
            [Validation(Required=false)]
            public int? CertifyStatus { get; set; }
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }
            [NameInMap("PurchaseTime")]
            [Validation(Required=false)]
            public string PurchaseTime { get; set; }
            [NameInMap("SecretStatus")]
            [Validation(Required=false)]
            public long? SecretStatus { get; set; }
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public long? Vendor { get; set; }
        };

    }

}
