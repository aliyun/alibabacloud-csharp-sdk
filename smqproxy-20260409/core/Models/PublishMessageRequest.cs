// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class PublishMessageRequest : TeaModel {
        [NameInMap("MessageAttributes")]
        [Validation(Required=false)]
        public PublishMessageRequestMessageAttributes MessageAttributes { get; set; }
        public class PublishMessageRequestMessageAttributes : TeaModel {
            [NameInMap("DirectMail")]
            [Validation(Required=false)]
            public string DirectMail { get; set; }

            [NameInMap("DirectSMS")]
            [Validation(Required=false)]
            public string DirectSMS { get; set; }

            [NameInMap("Push")]
            [Validation(Required=false)]
            public string Push { get; set; }

        }

        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

    }

}
