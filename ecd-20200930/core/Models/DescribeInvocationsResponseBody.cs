// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// Details about execution records of the command.
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// The Base64-encoded command content.
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
            /// The time when the execution task is created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The overall execution status of the command. The overall execution status is determined by the execution status on all involved cloud desktops. The valid values include:
            /// 
            /// *   Pending: The system is verifying or sending the command. If the execution status on at least one cloud desktop is Pending, the overall execution status is Pending.
            /// 
            /// *   Running: The execution is in progress on cloud desktops. If the execution status on at least one cloud desktop is Running, the overall execution status is Running.
            /// 
            /// *   Success: If the execution status on all cloud desktops is Success or Stopped, or the execution status on at least one cloud desktop is Success, the overall execution status is Success.
            /// 
            /// *   Failed: If the execution status on all cloud desktops is Stopped or Failed, the overall execution status is Failed. If one or more execution status of a cloud desktop is one of the following values, Failed is returned:
            /// 
            ///     *   Invalid: The command is invalid.
            ///     *   Aborted: The command fails to be sent.
            ///     *   Failed: The command is executed, but the exit code is not 0.
            ///     *   Timeout: The command times out.
            ///     *   Error: An error occurs in the command.
            /// 
            /// *   Stopping: The execution is being stopped. If the execution status on at least one cloud desktop is Stopping, the overall execution state is Stopping.
            /// 
            /// *   Stopped: The execution is stopped. If the execution status on all cloud desktops is Stopped, the overall execution state is Stopped. If the execution status on a cloud desktop is one of the following values, Stopped is returned:
            /// 
            ///     *   Cancelled: The execution is canceled.
            ///     *   Terminated: The execution is terminated.
            /// 
            /// *   PartialFailed: The execution succeeded on some cloud desktops and failed on others. If the execution status on different cloud desktops is Success, Failed, or Stopped, the overall execution state is PartialFailed.
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// The cloud desktops on which the command is executed.
            /// </summary>
            [NameInMap("InvokeDesktops")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeDesktops : TeaModel {
                /// <summary>
                /// The time when the command execution was performed.
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
                /// The name of the cloud desktop.
                /// </summary>
                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

                /// <summary>
                /// The size of the text that is truncated and discarded when the Output value exceeds 24 KB in size.
                /// </summary>
                [NameInMap("Dropped")]
                [Validation(Required=false)]
                public int? Dropped { get; set; }

                /// <summary>
                /// The code that indicates the reason why a command failed to be sent or executed. The valid values include:
                /// 
                /// *   If this parameter is empty, the execution is normal.
                /// *   InstanceNotExists: The specified cloud desktop does not exist or is released.
                /// *   InstanceReleased: The cloud desktop is released during the execution.
                /// *   InstanceNotRunning: The cloud desktop is not running during the execution.
                /// *   CommandNotApplicable: The command cannot be used on the cloud desktop.
                /// *   ClientNotRunning: The Cloud Assistant client is not running.
                /// *   ClientNotResponse: The Cloud Assistant client does not respond.
                /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
                /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
                /// *   DeliveryTimeout: The time to send the command in the request times out.
                /// *   ExecutionTimeout: The execution times out.
                /// *   ExecutionException: An exception occurs during the execution.
                /// *   ExecutionInterrupted: The execution is interrupted.
                /// *   ExitCodeNonzero: The execution finishes, but the exit code is not 0.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Details about the reason why the command failed to be sent or executed. The valid values include:
                /// 
                /// *   If this parameter is empty, the execution is normal.
                /// *   the specified instance does not exists: The cloud desktop does not exist or is released.
                /// *   the instance has released when create task: The cloud desktop is released during execution.
                /// *   the instance is not running when create task: The cloud desktop is not running when the execution is being performed.
                /// *   the command is not applicable: The command cannot be used on the specified cloud desktop.
                /// *   the aliyun service is not running on the instance: The Cloud Assistance client is not running.
                /// *   the aliyun service in the instance does not response: The Cloud Assistant client is not responding.
                /// *   the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.
                /// *   the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.
                /// *   the command delivery has been timeout: The command that is sent in the request times out.
                /// *   the command execution has been timeout: The execution times out.
                /// *   the command execution got an exception: An exception occurs when the command is running.
                /// *   the command execution has been interrupted: The execution is interrupted.
                /// *   the command execution exit code is not zero: The execution finishes, but the exit code is not 0.
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
                /// The time when the command execution ended.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The execution status on the cloud desktop.
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// The command output.
                /// 
                /// *   If the IncludeOutput parameter is set to false, Output is not returned.
                /// *   If the ContentEncoding parameter is set to Base64, the value of Output is the output information that is encoded in Base64.
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// The number of times that the command is executed on the cloud desktop.
                /// </summary>
                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                /// <summary>
                /// The start time of the execution on the cloud desktop.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The time when you called the [StopInvocation](~~196957#doc-api-ecd-StopInvocation~~ "You can call this operation to stop a Cloud Assistant command that is running on one or cloud desktops.") operation to manually stop the command.
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// The time when the execution status was updated.
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
        /// The query token that is returned from this call.
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
