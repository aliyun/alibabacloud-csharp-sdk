// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryCardStatusResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CardStatus")]
        [Validation(Required=false)]
        public QueryCardStatusResponseBodyCardStatus CardStatus { get; set; }
        public class QueryCardStatusResponseBodyCardStatus : TeaModel {
            [NameInMap("Msisdn")]
            [Validation(Required=false)]
            public string Msisdn { get; set; }
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }
            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
