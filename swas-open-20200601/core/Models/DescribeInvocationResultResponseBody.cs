// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationResultResponseBody : TeaModel {
        /// <summary>
        /// The execution results.
        /// </summary>
        [NameInMap("InvocationResult")]
        [Validation(Required=false)]
        public DescribeInvocationResultResponseBodyInvocationResult InvocationResult { get; set; }
        public class DescribeInvocationResultResponseBodyInvocationResult : TeaModel {
            /// <summary>
            /// The error code that is returned if the command failed to be sent or executed.
            /// 
            /// *   If this parameter is empty, the command is executed normally.
            /// *   InstanceNotExists: The specified server does not exist or is released.
            /// *   InstanceReleased: The server was released while the command was being executed on the server.
            /// *   InstanceNotRunning: The server is not in the Running state while the command is being executed.
            /// *   CommandNotApplicable: The command is not applicable to the specified server.
            /// *   AccountNotExists: The specified account does not exist.
            /// *   DirectoryNotExists: The specified directory does not exist.
            /// *   BadCronExpression: The specified cron expression for the execution schedule is invalid.
            /// *   ClientNotRunning: The Cloud Assistant client is not running.
            /// *   ClientNotResponse: The Cloud Assistant client does not respond.
            /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
            /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
            /// *   DeliveryTimeout: Command sending times out.
            /// *   ExecutionTimeout: The execution times out.
            /// *   ExecutionException: An exception occurs while the command is being executed.
            /// *   ExecutionInterrupted: The execution is interrupted.
            /// *   ExitCodeNonzero: The execution is complete, but the exit code is not 0.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message returned when the command is not successfully sent or executed. Valid values:
            /// 
            /// *   If this parameter is empty, the command is executed normally.
            /// *   the specified instance does not exists: The specified server does not exist or is released.
            /// *   the instance has released when create task: The server was released while the command was being executed on the server.
            /// *   the instance is not running when create task: The server is not in the Running state while the command is being executed.
            /// *   the command is not applicable: The command is not applicable to the specified server.
            /// *   the specified account does not exists: The specified account does not exist.
            /// *   the specified directory does not exists: The specified directory does not exist.
            /// *   the cron job expression is invalid: The specified cron expression is invalid.
            /// *   the aliyun service is not running on the instance: The Cloud Assistance client is not running.
            /// *   the aliyun service in the instance does not response: The Cloud Assistant client does not respond to your request.
            /// *   the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.
            /// *   the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.
            /// *   the command delivery has been timeout: Command sending times out.
            /// *   the command execution has been timeout: The execution times out.
            /// *   the command execution got an exception: An exception occurs while the command is being executed.
            /// *   the command execution has been interrupted: The execution is interrupted.
            /// *   the command execution exit code is not zero: The execution is complete, and the exit code is not 0.
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// The exit code of the command.
            /// 
            /// *   For Linux instances, the exit code is the exit code of the shell command.
            /// *   For Windows instances, the exit code is the exit code of the batch or PowerShell command.
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public long? ExitCode { get; set; }

            /// <summary>
            /// The time when the execution ended.
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the execution progress. Valid values:
            /// 
            /// *   Pending: The command is being verified or sent.
            /// *   Invalid: The specified command type or parameter is invalid.
            /// *   Aborted: The command fails to be sent to the server. To send a command to a server, make sure that the server is in the Running state and the command can be sent within 1 minute.
            /// *   Running: The command is being executed on the server.
            /// *   Success: The execution is completed, and the exit code is 0.
            /// *   Failed: The execution is completed, and the exit code is not 0.
            /// *   Error: The execution cannot proceed due to an exception.
            /// *   Timeout: The execution times out.
            /// *   Cancelled: The execution is canceled, and the command is not executed.
            /// *   Stopping: The command in the Running state is being stopped.
            /// *   Terminated: The command is terminated while it is being executed.
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// The execution ID.
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// The status of the execution. Valid values:
            /// 
            /// *   Running
            /// *   Finished
            /// *   Failed
            /// *   Stopped
            /// </summary>
            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            /// <summary>
            /// The username who executes the command on the simple application server.
            /// </summary>
            [NameInMap("InvokeUser")]
            [Validation(Required=false)]
            public string InvokeUser { get; set; }

            /// <summary>
            /// The command output.
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// The time when the execution started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
