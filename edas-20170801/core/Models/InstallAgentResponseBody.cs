// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InstallAgentResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The execution result.
        /// </summary>
        [NameInMap("ExecutionResultList")]
        [Validation(Required=false)]
        public InstallAgentResponseBodyExecutionResultList ExecutionResultList { get; set; }
        public class InstallAgentResponseBodyExecutionResultList : TeaModel {
            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public List<InstallAgentResponseBodyExecutionResultListExecutionResult> ExecutionResult { get; set; }
            public class InstallAgentResponseBodyExecutionResultListExecutionResult : TeaModel {
                /// <summary>
                /// The time when the installation was complete.
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The state of the installation.
                /// </summary>
                [NameInMap("InvokeRecordStatus")]
                [Validation(Required=false)]
                public string InvokeRecordStatus { get; set; }

                /// <summary>
                /// The state of the installation command.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether the installation was successful.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
