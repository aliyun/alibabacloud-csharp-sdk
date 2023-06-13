// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationResultResponseBody : TeaModel {
        /// <summary>
        /// The information about the command running result.
        /// </summary>
        [NameInMap("InvocationResult")]
        [Validation(Required=false)]
        public DescribeInvocationResultResponseBodyInvocationResult InvocationResult { get; set; }
        public class DescribeInvocationResultResponseBodyInvocationResult : TeaModel {
            /// <summary>
            /// The error code returned when the command cannot be sent or run. Valid values:
            /// 
            /// *   If this parameter is empty, the command is run normally.
            /// *   InstanceNotExists: The instance does not exist or is released.
            /// *   InstanceReleased: The instance was released while the command was being run on the instance.
            /// *   InstanceNotRunning: The instance is not in the Running state while the command is being run.
            /// *   CommandNotApplicable: The command is not applicable to the specified instance.
            /// *   AccountNotExists: The specified account does not exist.
            /// *   DirectoryNotExists: The specified directory does not exist.
            /// *   BadCronExpression: The specified cron expression for the running schedule is invalid.
            /// *   ClientNotRunning: The Cloud Assistant client is not running.
            /// *   ClientNotResponse: The Cloud Assistant client does not respond.
            /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
            /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
            /// *   DeliveryTimeout: The request for sending the command times out.
            /// *   ExecutionTimeout: The running of the command times out.
            /// *   ExecutionException: An exception has occurred while the command is being run.
            /// *   ExecutionInterrupted: The running of the command is interrupted.
            /// *   ExitCodeNonzero: The command finishes running, but the exit code is not 0.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message returned when the command cannot be sent or run. Valid values:
            /// 
            /// *   If this parameter is empty, the command is run normally.
            /// *   the specified instance does not exists: The specified instance does not exist or is released.
            /// *   the instance has released when create task: The instance was released while the command was being run on the instance.
            /// *   the instance is not running when create task: The instance is not in the Running state while the command is being run.
            /// *   the command is not applicable: The command is not applicable to the specified instance.
            /// *   the specified account does not exists: The specified account does not exist.
            /// *   the specified directory does not exists: The specified directory does not exist.
            /// *   the cron job expression is invalid: The specified cron expression for the runing schedule is invalid.
            /// *   the aliyun service is not running on the instance: The Cloud Assistance client is not running.
            /// *   the aliyun service in the instance does not response: The Cloud Assistant client does not respond.
            /// *   the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.
            /// *   the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.
            /// *   the command delivery has been timeout: The request for sending the command times out.
            /// *   the command execution has been timeout: The running of the command times out.
            /// *   the command execution got an exception: An exception has occurred while the command is being run.
            /// *   the command execution has been interrupted: The running of the command is interrupted.
            /// *   the command execution exit code is not zero: The command finishes running, but the exit code is not 0.
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// The exit code of the command task.
            /// 
            /// *   For Linux instances, the value is the exit code of the shell command.
            /// *   For Windows instances, the value is the exit code of the batch or PowerShell command.
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public long? ExitCode { get; set; }

            /// <summary>
            /// The time when the command finished running on the instance.
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
            /// The status of the command task. Valid values:
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
            /// The username who runs the command on the simple application server.
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
            /// The time when the command started to be run on the instance.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
