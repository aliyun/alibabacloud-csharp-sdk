// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class RunCompletionMessageResponseBody : TeaModel {
        [NameInMap("FinishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
