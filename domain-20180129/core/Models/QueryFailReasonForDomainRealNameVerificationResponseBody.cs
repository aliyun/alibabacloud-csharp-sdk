// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForDomainRealNameVerificationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailReasonForDomainRealNameVerificationResponseBodyData> Data { get; set; }
        public class QueryFailReasonForDomainRealNameVerificationResponseBodyData : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("DomainNameVerificationStatus")]
            [Validation(Required=false)]
            public string DomainNameVerificationStatus { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
