// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class ChangeMessageVisibilityRequest : TeaModel {
        [NameInMap("receiptHandle")]
        [Validation(Required=false)]
        public string ReceiptHandle { get; set; }

        [NameInMap("visibilityTimeout")]
        [Validation(Required=false)]
        public int? VisibilityTimeout { get; set; }

    }

}
