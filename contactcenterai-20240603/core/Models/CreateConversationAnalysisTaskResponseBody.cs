// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class CreateConversationAnalysisTaskResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateConversationAnalysisTaskResponseBodyData Data { get; set; }
        public class CreateConversationAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
