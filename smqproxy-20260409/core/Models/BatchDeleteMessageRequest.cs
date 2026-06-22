// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class BatchDeleteMessageRequest : TeaModel {
        [NameInMap("ReceiptHandles")]
        [Validation(Required=false)]
        public List<string> ReceiptHandles { get; set; }

    }

}
