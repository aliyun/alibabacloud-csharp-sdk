// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InstallAgentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ExecutionResultList")]
        [Validation(Required=false)]
        public InstallAgentResponseBodyExecutionResultList ExecutionResultList { get; set; }
        public class InstallAgentResponseBodyExecutionResultList : TeaModel {
            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public List<InstallAgentResponseBodyExecutionResultListExecutionResult> ExecutionResult { get; set; }
            public class InstallAgentResponseBodyExecutionResultListExecutionResult : TeaModel {
                public string FinishedTime { get; set; }
                public string InstanceId { get; set; }
                public string InvokeRecordStatus { get; set; }
                public string Status { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
