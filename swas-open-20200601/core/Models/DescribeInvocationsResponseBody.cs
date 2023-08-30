// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// The command name.
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// The content of the command, which is Base64-encoded.
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// The name of the command.
            /// </summary>
            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

            /// <summary>
            /// The type of the command. Valid values:
            /// 
            /// *   RunBatScript: batch command (applicable to Windows instances).
            /// *   RunPowerShellScript: PowerShell command (applicable to Windows instances).
            /// *   RunShellScript: shell command (applicable to Linux instances).
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// The time when the command was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The status of the command. Valid values:
            /// 
            /// *   Pending: The command is being verified or sent.
            /// *   Invalid: The specified command type or parameter is invalid.
            /// *   Aborted: The command failed to be sent. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.
            /// *   Running: The command is being run on the instance.
            /// *   Success: The command finishes running, and the exit code is 0.
            /// *   Failed: The command finishes running, but the exit code is not 0.
            /// *   Error: The running of the command cannot proceed due to an exception.
            /// *   Timeout: The running of the command times out.
            /// *   Cancelled: The running is canceled, and the command is not run.
            /// *   Stopping: The command that is running is being stopped.
            /// *   Terminated: The command is terminated while it is being run.
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// The ID of the command task.
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// The status of the command. Valid values:
            /// 
            /// *   Running: The command is running.
            /// *   Finished: The command finishes running.
            /// *   Failed: The running of the command failed.
            /// *   Stopped: The running is stopped.
            /// </summary>
            [NameInMap("InvokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            /// <summary>
            /// The custom parameters in the command. If no custom parameter exists in the command, the default value is {}.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
