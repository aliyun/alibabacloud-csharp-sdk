// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAgreementResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("QueryAgreementResponse")]
        [Validation(Required=false)]
        public QueryAgreementResponseBodyQueryAgreementResponse QueryAgreementResponse { get; set; }
        public class QueryAgreementResponseBodyQueryAgreementResponse : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ExternalAgreementNo")]
            [Validation(Required=false)]
            public string ExternalAgreementNo { get; set; }
            [NameInMap("ValidTime")]
            [Validation(Required=false)]
            public string ValidTime { get; set; }
            [NameInMap("InvalidTime")]
            [Validation(Required=false)]
            public string InvalidTime { get; set; }
            [NameInMap("AgreementNo")]
            [Validation(Required=false)]
            public string AgreementNo { get; set; }
            [NameInMap("SignTime")]
            [Validation(Required=false)]
            public string SignTime { get; set; }
        };

    }

}
