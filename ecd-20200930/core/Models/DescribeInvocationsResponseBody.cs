// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// The command execution records.
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// The command content that is encoded in Base64.
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// The type of the command.
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the end user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The overall execution status of the command. The overall execution status is determined by the execution status of the command on all related cloud desktops. Valid values:
            /// 
            /// *   Pending: The system is verifying or sending the command. If the execution status on at least one cloud desktop is Pending, the overall execution status is Pending.
            /// 
            /// *   Running: The execution is in progress on cloud desktops. If the execution status on at least one cloud desktop is Running, the overall execution status is Running.
            /// 
            /// *   Success: If the execution status on at least one cloud desktop is Success, and the execution status on other cloud desktops is Success or Stopped, the overall execution status is Success.
            /// 
            /// *   Failed: If the execution status on all cloud desktops is Stopped or Failed, the overall execution status is Failed. If one or more execution status on a cloud desktop is one of the following values, Failed is returned:
            /// 
            ///     *   Invalid: The command is invalid.
            ///     *   Aborted: The command failed to be sent.
            ///     *   Failed: The execution is complete, but the exit code is not 0.
            ///     *   Timeout: The execution times out.
            ///     *   Error: An error occurs when the execution is in progress.
            /// 
            /// *   Stopping: The execution is being stopped. If the execution status on at least one cloud desktop is Stopping, the overall execution status is Stopping.
            /// 
            /// *   Stopped: The execution is stopped. If the execution status on all cloud desktops is Stopped, the overall execution status is Stopped. If the execution status on a cloud desktop is one of the following values, Stopped is returned:
            /// 
            ///     *   Cancelled: The execution is canceled.
            ///     *   Terminated: The execution is terminated.
            /// 
            /// *   PartialFailed: The execution is successful on specific cloud desktops and failed on other cloud desktops. If the execution status on different cloud desktops includes Success, Failed, and Stopped, the overall execution status is PartialFailed.
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// The cloud desktops on which the command is run.
            /// </summary>
            [NameInMap("InvokeDesktops")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeDesktops : TeaModel {
                /// <summary>
                /// The time when the command execution was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the cloud desktop.
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// The size of the text that is truncated and discarded when the value of the Output parameter exceeds 24 KB in size.
                /// </summary>
                [NameInMap("Dropped")]
                [Validation(Required=false)]
                public int? Dropped { get; set; }

                /// <summary>
                /// The error code that is returned if the command failed to be sent or run.
                /// 
                /// *   If null is returned, the command is run normally.
                /// *   If InstanceNotExists is returned, the specified cloud desktop does not exist or is released.
                /// *   If InstanceReleased is returned, the specified cloud desktop is released during the command execution.
                /// *   If InstanceNotRunning is returned, the specified cloud desktop is not in the Running state when the execution is created.
                /// *   If CommandNotApplicable is returned, the command cannot be run on the specified cloud desktop.
                /// *   If ClientNotRunning is returned, Cloud Assistant is not running.
                /// *   If ClientNotResponse is returned, Cloud Assistant does not respond to your request.
                /// *   If ClientIsUpgrading is returned, Cloud Assistant is being upgraded.
                /// *   If ClientNeedUpgrade is returned, you must upgrade Cloud Assistant.
                /// *   If DeliveryTimeout is returned, the operation to send the command times out.
                /// *   If ExecutionTimeout is returned, the command execution times out.
                /// *   If ExecutionException is returned, an execution occurs during the command execution.
                /// *   If ExecutionInterrupted is returned, the command execution is interrupted.
                /// *   If ExitCodeNonzero is returned, the command execution is complete, but the exit code is not 0.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message that is returned if the command failed to be sent or run.
                /// 
                /// *   If null is returned, the command is run normally.
                /// *   If "the specified instance does not exist" is returned, the specified cloud desktop does not exist or is released.
                /// *   If "the instance has released when create task" is returned, the specified cloud desktop is released during the command execution.
                /// *   If "the instance is not running when create task" is returned, the specified cloud desktop is not in the Running state when the execution is created.
                /// *   If "the command is not applicable" is returned, the command cannot be run on the specified cloud desktop.
                /// *   If "the aliyun service is not running on the instance" is returned, Cloud Assistant is not running.
                /// *   If "the aliyun service in the instance does not response" is returned, Cloud Assistant does not respond to your request.
                /// *   If "the aliyun service in the instance is upgrading now" is returned, Cloud Assistant is being upgraded.
                /// *   If "the aliyun service in the instance need upgrade" is returned, you must upgrade Cloud Assistant.
                /// *   If "the command delivery has been timeout" is returned, the operation to send the command times out.
                /// *   If "the command execution has been timeout" is returned, the command execution times out.
                /// *   If "the command execution got an exception" is returned, an exception occurs during the command execution.
                /// *   If "the command execution has been interrupted" is returned, the command execution is interrupted.
                /// *   If "the command execution exit code is not zero" is returned, the command execution is complete, but the exit code is not 0.
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                /// <summary>
                /// The exit code of the execution.
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                /// <summary>
                /// The end time of the command execution.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The execution status on a cloud desktop.
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// The command output.
                /// 
                /// *   If the IncludeOutput parameter is set to false, no value of the Output parameter is returned.
                /// *   If the ContentEncoding parameter is set to Base64, the value of the Output parameter is encoded in Base64.
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// The number of times that the command is run on the cloud desktop.
                /// </summary>
                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                /// <summary>
                /// The start time of the command execution on the cloud desktop.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// If you called the [stopInvocation](~~196957~~) operation, the value of this parameter indicates the time when you made the call.
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// The time when the execution status was last updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The ID of the execution.
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

        }

        /// <summary>
        /// The query token that is returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
