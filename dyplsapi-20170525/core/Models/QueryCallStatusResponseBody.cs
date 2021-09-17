// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryCallStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretCallStatusDTO")]
        [Validation(Required=false)]
        public QueryCallStatusResponseBodySecretCallStatusDTO SecretCallStatusDTO { get; set; }
        public class QueryCallStatusResponseBodySecretCallStatusDTO : TeaModel {
            [NameInMap("CalledNo")]
            [Validation(Required=false)]
            public string CalledNo { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
        };

    }

}
