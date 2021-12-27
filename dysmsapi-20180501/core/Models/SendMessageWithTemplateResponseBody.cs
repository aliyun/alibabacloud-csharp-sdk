// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateResponseBody : TeaModel {
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public SendMessageWithTemplateResponseBodyNumberDetail NumberDetail { get; set; }
        public class SendMessageWithTemplateResponseBodyNumberDetail : TeaModel {
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        [NameInMap("Segments")]
        [Validation(Required=false)]
        public string Segments { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
