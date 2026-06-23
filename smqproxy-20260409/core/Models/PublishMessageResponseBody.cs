// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class PublishMessageResponseBody : TeaModel {
        [NameInMap("MessageBodyMD5")]
        [Validation(Required=false)]
        public string MessageBodyMD5 { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
