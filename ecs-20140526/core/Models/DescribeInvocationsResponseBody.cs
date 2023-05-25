// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// Details about the command executions.
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// The Base64-encoded command content.
                /// </summary>
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                /// <summary>
                /// The command description.
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// The command ID.
                /// </summary>
                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                /// <summary>
                /// The command name.
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                /// <summary>
                /// The command type.
                /// </summary>
                [NameInMap("CommandType")]
                [Validation(Required=false)]
                public string CommandType { get; set; }

                /// <summary>
                /// The container ID.
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                /// <summary>
                /// The container name.
                /// </summary>
                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                /// <summary>
                /// The time when the command task was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The schedule on which to run the command. For information about the value specifications, see [Cron expression](~~64769~~).
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// The overall execution state of the command. The value of this parameter depends on the execution states on all the involved instances. Valid values:
                /// 
                /// *   Pending: The command is being verified or sent. When the execution state on at least one instance is Pending, the overall execution state is Pending.
                /// 
                /// *   Scheduled: The command scheduled to run is sent and pending execution. When the execution state on at least one instance is Scheduled, the overall execution state is Scheduled.
                /// 
                /// *   Running: The command is being run on the instances. When the execution state on at least one instance is Running, the overall execution state is Running.
                /// 
                /// *   Success: When the execution state on at least one instance is Success and the execution state on other instances is Stopped or Success, the overall execution state is Success.
                /// 
                ///     *   Command that is set to run only once: The execution is complete, and the exit code is 0.
                ///     *   Command that is set to run on a schedule: The last execution is complete, the exit code is 0, and the specified cycle ends.
                /// 
                /// *   Failed: When the execution state on all instances is Stopped or Failed, the overall execution state is Failed. When the execution state on an instance is one of the following values, Failed is returned as the overall execution state:
                /// 
                ///     *   Invalid: The command is invalid.
                ///     *   Aborted: The command failed to be sent.
                ///     *   Failed: The command execution is complete, but the exit code is not 0.
                ///     *   Timeout: The execution timed out.
                ///     *   Error: An error occurred while the command was being run on the instance.
                /// 
                /// *   Stopping: The command task is being stopped. When the execution state on at least one instance is Stopping, the overall execution state is Stopping.
                /// 
                /// *   Stopped: The command task is stopped. When the execution state on all instances is Stopped, the overall execution state is Stopped. When the execution state on an instance is one of the following values, Stopped is returned as the overall execution state:
                /// 
                ///     *   Cancelled: The command task is canceled.
                ///     *   Terminated: The command task is terminated.
                /// 
                /// *   PartialFailed: The execution is complete on some instances and fails on other instances. When the execution state is Success on some instances and is Failed or Stopped on other instances, the overall execution state is PartialFailed.
                /// 
                /// > The `InvokeStatus` response parameter functions similarly to this parameter. We recommend that you ignore InvokeStatus and check the value of InvocationStatus.
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// The command task ID.
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// Details about the instances on which the command is run.
                /// </summary>
                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        /// <summary>
                        /// The start time of the execution.
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// The size of the text that is truncated and discarded when the Output value exceeds 24 KB in size.
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// The code that indicates why the command failed to be sent or run. Valid values:
                        /// 
                        /// *   If this parameter is empty, the command is run normally.
                        /// *   InstanceNotExists: The instance does not exist or was released.
                        /// *   InstanceReleased: The instance was released while the command was being run.
                        /// *   InstanceNotRunning: The instance was not in the Running state while the command started to be run.
                        /// *   CommandNotApplicable: The command is not applicable to the specified instance.
                        /// *   AccountNotExists: The specified account does not exist.
                        /// *   DirectoryNotExists: The specified directory does not exist.
                        /// *   BadCronExpression: The cron expression used to specify a schedule is invalid.
                        /// *   ClientNotRunning: The Cloud Assistant client is not running.
                        /// *   ClientNotResponse: The Cloud Assistant client does not respond.
                        /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
                        /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
                        /// *   DeliveryTimeout: The request to send the command timed out.
                        /// *   ExecutionTimeout: The execution timed out.
                        /// *   ExecutionException: An exception occurs while the command is being run.
                        /// *   ExecutionInterrupted: The execution was interrupted.
                        /// *   ExitCodeNonzero: The execution is complete, but the exit code is not 0.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// Details about the reason why the command failed to be sent or run. Valid values:
                        /// 
                        /// *   If this parameter is empty, the execution is normal.
                        /// *   the specified instance does not exists
                        /// *   the instance has released when create task
                        /// *   the instance is not running when create task
                        /// *   the command is not applicable
                        /// *   the specified account does not exists
                        /// *   the specified directory does not exists
                        /// *   the cron job expression is invalid
                        /// *   the aliyun service is not running on the instance
                        /// *   the aliyun service in the instance does not response
                        /// *   the aliyun service in the instance is upgrading now
                        /// *   the aliyun service in the instance is upgrading now
                        /// *   the command delivery has been timeout
                        /// *   the command execution has been timeout
                        /// *   the command execution got an exception
                        /// *   the command execution has been interrupted
                        /// *   the command execution exit code is not zero
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// The exit code of the execution. Valid values:
                        /// 
                        /// *   For Linux instances, the exit code is the exit code of the shell process.
                        /// *   For Windows instances, the exit code is the exit code of the batch or PowerShell process.
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public long? ExitCode { get; set; }

                        /// <summary>
                        /// The end time of the execution.
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// The instance ID
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The execution state on a single instance.
                        /// 
                        /// > We recommend that you ignore this parameter and check the value of the `InvocationStatus` response parameter for the overall execution state.
                        /// </summary>
                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        /// <summary>
                        /// The execution state on a single instance. Valid values:
                        /// 
                        /// *   Pending: The command is being verified or sent.
                        /// 
                        /// *   Invalid: The specified command type or parameter is invalid.
                        /// 
                        /// *   Aborted: The command failed to be sent. To send a command to an instance, make sure that the instance is in the Running state and that the command is sent within 1 minute.
                        /// 
                        /// *   Running: The command is being run on the instance.
                        /// 
                        /// *   Success:
                        /// 
                        ///     *   Command that is set to run only once: The execution is complete, and the exit code is 0.
                        ///     *   Command that is set to run on a schedule: The previous execution is complete, the exit code is 0, and the specified cycle ends.
                        /// 
                        /// *   Failed:
                        /// 
                        ///     *   Command that is set to run only once: The execution is complete, but the exit code is not 0.
                        ///     *   Command that is set to run on a schedule: The previous execution is complete, the exit code is not 0, and the specified cycle is about to end.
                        /// 
                        /// *   Error: The execution cannot proceed due to an exception.
                        /// 
                        /// *   Timeout: The execution times out.
                        /// 
                        /// *   Cancelled: The execution is canceled, and the command is not started.
                        /// 
                        /// *   Stopping: The command task is being stopped.
                        /// 
                        /// *   Terminated: The command task is terminated while it is being run.
                        /// 
                        /// *   Scheduled:
                        /// 
                        ///     *   Command that is set to run only once: The overall execution state can never be Scheduled.
                        ///     *   Command that is set to run on a schedule: The command is pending execution.
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// The command output.
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// The number of times that the command is run on the instance.
                        /// 
                        /// *   If the execution is a one-time execution, the value is 0 or 1.
                        /// *   If the execution is a scheduled execution, the value is the number of times that the command is run.
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// The time when the command started to be run on the instance.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The time when the command stopped being run on the instance. If you call the `StopInvocation` operation to manually stop the execution, the value is the time when you called the operation.
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// Indicates whether the command is to be automatically run.
                        /// </summary>
                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public bool? Timed { get; set; }

                        /// <summary>
                        /// The time when the execution state was updated.
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// The overall execution state of the command.
                /// 
                /// > We recommend that you ignore this parameter and check the value of the `InvocationStatus` response parameter for the overall execution state.
                /// </summary>
                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// The custom parameters in the command.
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// Indicates the execution mode of the command. Valid values:
                /// 
                /// *   Once: immediately runs the command.
                /// *   Period: The command is run on a schedule.
                /// *   NextRebootOnly: The command is automatically run the next time the instance starts.
                /// *   EveryReboot: automatically runs the command every time the instance starts.
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// The tags of the command task.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the command task.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the command task.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the command is to be automatically run.
                /// </summary>
                [NameInMap("Timed")]
                [Validation(Required=false)]
                public bool? Timed { get; set; }

                /// <summary>
                /// The maximum timeout period for the command execution on the instance. Unit: seconds.
                /// 
                /// When a command cannot be run, the command execution times out. When a command execution times out, the Cloud Assistant client forcefully terminates the command process by canceling the PID of the command.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// The username that was used to run the command on the instance.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// The execution path of the command.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the commands.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
