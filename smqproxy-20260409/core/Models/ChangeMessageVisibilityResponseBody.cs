// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class ChangeMessageVisibilityResponseBody : TeaModel {
        [NameInMap("NextVisibleTime")]
        [Validation(Required=false)]
        public long? NextVisibleTime { get; set; }

        [NameInMap("ReceiptHandle")]
        [Validation(Required=false)]
        public string ReceiptHandle { get; set; }

    }

}
