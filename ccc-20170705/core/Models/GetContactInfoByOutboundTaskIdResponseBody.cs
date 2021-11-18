// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetContactInfoByOutboundTaskIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactIdentity")]
        [Validation(Required=false)]
        public GetContactInfoByOutboundTaskIdResponseBodyContactIdentity ContactIdentity { get; set; }
        public class GetContactInfoByOutboundTaskIdResponseBodyContactIdentity : TeaModel {
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }
            [NameInMap("ContactReferrnceId")]
            [Validation(Required=false)]
            public string ContactReferrnceId { get; set; }
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }
            [NameInMap("UserPhone")]
            [Validation(Required=false)]
            public string UserPhone { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
