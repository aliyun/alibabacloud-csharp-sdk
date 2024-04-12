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
                /// The command content.
                /// 
                /// *   If ContentEncoding is set to PlainText in the request, the original command content is returned.
                /// *   If ContentEncoding is set to Base64 in the request, the Base64-encoded command content is returned.
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
                /// The schedule on which the command was run.
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// The overall execution state of the command task. The value of this parameter depends on the execution states of the command task on all the involved instances. Valid values:
                /// 
                /// *   Pending: The command was being verified or sent. When the execution state on at least one instance is Pending, the overall execution state is Pending.
                /// 
                /// *   Scheduled: The command that is set to run on a schedule was sent and waiting to be run. When the execution state on at least one instance is Scheduled, the overall execution state is Scheduled.
                /// 
                /// *   Running: The command was being run on the instances. When the execution state on at least one instance is Running, the overall execution state is Running.
                /// 
                /// *   Success: When the execution state on at least one instance is Success and the execution state on the other instances is Stopped or Success, the overall execution state is Success.
                /// 
                ///     *   One-time task: The execution was complete, and the exit code was 0.
                ///     *   Scheduled task: The last execution was complete, the exit code was 0, and the specified period ended.
                /// 
                /// *   Failed: When the execution state on all instances is Stopped or Failed, the overall execution state is Failed. When the execution state on an instance is one of the following values, Failed is returned as the overall execution state:
                /// 
                ///     *   Invalid: The command was invalid.
                ///     *   Aborted: The command failed to be sent.
                ///     *   Failed: The execution was complete, but the exit code was not 0.
                ///     *   Timeout: The execution timed out.
                ///     *   Error: An error occurred while the command was being run.
                /// 
                /// *   Stopping: The command task was being stopped. When the execution state on at least one instance is Stopping, the overall execution state is Stopping.
                /// 
                /// *   Stopped: The task was stopped. When the execution state on all instances is Stopped, the overall execution state is Stopped. When the execution state on an instance is one of the following values, Stopped is returned as the overall execution state:
                /// 
                ///     *   Cancelled: The task was canceled.
                ///     *   Terminated: The task was terminated.
                /// 
                /// *   PartialFailed: The execution was complete on some instances and failed on other instances. When the execution state is Success on some instances and is Failed or Stopped on the other instances, the overall execution state is PartialFailed.
                /// 
                /// >  `InvokeStatus` in the response functions similarly to this parameter. We recommend that you check the value of this parameter.
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
                /// The instances on which the command was run.
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
                        /// The time when the command task was created.
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// The size of the Output text that was truncated and discarded because the Output value exceeded 24 KB in size.
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// The error code for the failure to send or run the command. Valid values:
                        /// 
                        /// *   If this parameter is empty, the command was run as expected.
                        /// *   InstanceNotExists: The specified instance did not exist or was released.
                        /// *   InstanceReleased: The instance was released while the command was being run.
                        /// *   InstanceNotRunning: The instance was not running when the command started to be run.
                        /// *   CommandNotApplicable: The command was not applicable to the specified instance.
                        /// *   AccountNotExists: The specified account did not exist.
                        /// *   DirectoryNotExists: The specified directory did not exist.
                        /// *   BadCronExpression: The specified cron expression for the execution schedule was invalid.
                        /// *   ClientNotRunning: Cloud Assistant Agent was not running.
                        /// *   ClientNotResponse: Cloud Assistant Agent did not respond.
                        /// *   ClientIsUpgrading: Cloud Assistant Agent was being upgraded.
                        /// *   ClientNeedUpgrade: Cloud Assistant Agent needed to be upgraded.
                        /// *   DeliveryTimeout: The request to send the command timed out.
                        /// *   ExecutionTimeout: The execution timed out.
                        /// *   ExecutionException: An exception occurred while the command was being run.
                        /// *   ExecutionInterrupted: The command task was interrupted.
                        /// *   ExitCodeNonzero: The execution was complete, but the exit code was not 0.
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// The error message returned when the command failed to be sent or run. Valid values:
                        /// 
                        /// *   If this parameter is empty, the command was run as expected.
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
                        /// *   the aliyun service in the instance need upgrade
                        /// *   the command delivery has been timeout
                        /// *   the command execution has been timeout
                        /// *   the command execution got an exception
                        /// *   the command execution has been interrupted
                        /// *   the command execution exit code is not zero
                        /// *   the specified instance has been released
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// The exit code of the execution. Valid values:
                        /// 
                        /// *   For Linux instances, the value is the exit code of the shell process.
                        /// *   For Windows instances, the value is the exit code of the batch or PowerShell process.
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public long? ExitCode { get; set; }

                        /// <summary>
                        /// The time when the execution ended.
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// The instance ID.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The execution state on a single instance.
                        /// 
                        /// >  We recommend that you ignore this parameter and check the value of `InvocationStatus` in the response to obtain the execution state.
                        /// </summary>
                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        /// <summary>
                        /// The execution state on a single instance. Valid values:
                        /// 
                        /// *   Pending: The command was being verified or sent.
                        /// 
                        /// *   Invalid: The specified command type or parameter was invalid.
                        /// 
                        /// *   Aborted: The command failed to be sent to the instance. To send a command to an instance, make sure that the instance is in the Running state and the command can be sent to the instance within 1 minute.
                        /// 
                        /// *   Running: The command was being run on the instance.
                        /// 
                        /// *   Success:
                        /// 
                        ///     *   One-time task: The execution was complete, and the exit code was 0.
                        ///     *   Scheduled task: The last execution was complete, the exit code was 0, and the specified period ended.
                        /// 
                        /// *   Failed:
                        /// 
                        ///     *   One-time task: The execution was complete, but the exit code was not 0.
                        ///     *   Scheduled task: The last execution was complete, but the exit code was not 0. The specified period is about to end.
                        /// 
                        /// *   Error: The execution cannot proceed due to an exception.
                        /// 
                        /// *   Timeout: The execution timed out.
                        /// 
                        /// *   Cancelled: The execution was canceled, and the command was not run.
                        /// 
                        /// *   Stopping: The command task was being stopped.
                        /// 
                        /// *   Terminated: The execution was terminated before completion.
                        /// 
                        /// *   Scheduled:
                        /// 
                        ///     *   One-time task: The execution state can never be Scheduled.
                        ///     *   Scheduled task: The command was waiting to be run.
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// The command output.
                        /// 
                        /// *   If ContentEncoding is set to PlainText in the request, the original command output is returned.
                        /// *   If ContentEncoding is set to Base64 in the request, the Base64-encoded command output is returned.
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// The number of times that the command was run on the instance.
                        /// 
                        /// *   If the command is set to run only once, the value is 0 or 1.
                        /// *   If the command is set to run on a schedule, the value is the number of times that the command has been run on the instance.
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
                        /// The time when the command task was stopped. If you call the `StopInvocation` operation to stop the command task, the value of this parameter is the time when the operation is called.
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
                        /// The time when the execution status was updated.
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// The overall execution state of the command task.
                /// 
                /// >  We recommend that you ignore this parameter and check the value of `InvocationStatus` in the response to obtain the overall execution state.
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
                /// The execution mode of the command. Valid values:
                /// 
                /// *   Once: The command is immediately run.
                /// *   Period: The command is run on a schedule.
                /// *   NextRebootOnly: The command is run the next time the instances start.
                /// *   EveryReboot: The command is run every time the instances start.
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
                /// The maximum timeout period for the command execution. Unit: seconds.
                /// 
                /// When a command cannot be run, the command execution times out. When a command execution times out, Cloud Assistant Agent forcefully terminates the command process by canceling the process ID (PID) of the command.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// The username used to run the command on the instances.
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
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
