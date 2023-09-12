// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundReason : TeaModel {
        [NameInMap("proofRequired")]
        [Validation(Required=false)]
        public bool? ProofRequired { get; set; }

        [NameInMap("reasonTextId")]
        [Validation(Required=false)]
        public string ReasonTextId { get; set; }

        [NameInMap("reasonTips")]
        [Validation(Required=false)]
        public string ReasonTips { get; set; }

        [NameInMap("refundDescRequired")]
        [Validation(Required=false)]
        public bool? RefundDescRequired { get; set; }

    }

}
