// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryCredentialsInfoResponseBody : TeaModel {
        [NameInMap("CredentialsInfo")]
        [Validation(Required=false)]
        public QueryCredentialsInfoResponseBodyCredentialsInfo CredentialsInfo { get; set; }
        public class QueryCredentialsInfoResponseBodyCredentialsInfo : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("PersonName")]
            [Validation(Required=false)]
            public string PersonName { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
