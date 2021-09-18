// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class QueryMessageResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ErrorDescription")]
        [Validation(Required=false)]
        public string ErrorDescription { get; set; }

        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        [NameInMap("ReceiveDate")]
        [Validation(Required=false)]
        public string ReceiveDate { get; set; }

        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public QueryMessageResponseBodyNumberDetail NumberDetail { get; set; }
        public class QueryMessageResponseBodyNumberDetail : TeaModel {
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
