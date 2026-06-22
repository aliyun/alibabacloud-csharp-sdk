// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class PeekMessageResponseBody : TeaModel {
        [NameInMap("DequeueCount")]
        [Validation(Required=false)]
        public long? DequeueCount { get; set; }

        [NameInMap("EnqueueTime")]
        [Validation(Required=false)]
        public long? EnqueueTime { get; set; }

        [NameInMap("FirstDequeueTime")]
        [Validation(Required=false)]
        public long? FirstDequeueTime { get; set; }

        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        [NameInMap("MessageBodyMD5")]
        [Validation(Required=false)]
        public string MessageBodyMD5 { get; set; }

        [NameInMap("MessageGroupId")]
        [Validation(Required=false)]
        public string MessageGroupId { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("UserProperties")]
        [Validation(Required=false)]
        public string UserProperties { get; set; }

    }

}
