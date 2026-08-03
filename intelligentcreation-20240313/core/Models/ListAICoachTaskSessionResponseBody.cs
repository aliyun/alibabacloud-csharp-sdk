// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAICoachTaskSessionResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sessionList")]
        [Validation(Required=false)]
        public List<ListAICoachTaskSessionResponseBodySessionList> SessionList { get; set; }
        public class ListAICoachTaskSessionResponseBodySessionList : TeaModel {
            [NameInMap("sessionCreateTime")]
            [Validation(Required=false)]
            public string SessionCreateTime { get; set; }

            [NameInMap("sessionDuration")]
            [Validation(Required=false)]
            public long? SessionDuration { get; set; }

            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("sessionStatus")]
            [Validation(Required=false)]
            public int? SessionStatus { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
