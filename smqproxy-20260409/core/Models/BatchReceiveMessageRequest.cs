// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class BatchReceiveMessageRequest : TeaModel {
        [NameInMap("numOfMessages")]
        [Validation(Required=false)]
        public int? NumOfMessages { get; set; }

        [NameInMap("waitseconds")]
        [Validation(Required=false)]
        public int? Waitseconds { get; set; }

    }

}
