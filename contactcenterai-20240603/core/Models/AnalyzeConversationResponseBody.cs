// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class AnalyzeConversationResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorInfo")]
        [Validation(Required=false)]
        public string ErrorInfo { get; set; }

        [NameInMap("finishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
