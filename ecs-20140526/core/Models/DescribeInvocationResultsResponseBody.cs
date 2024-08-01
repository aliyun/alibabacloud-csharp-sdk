// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// Details about the execution results.
        /// </summary>
        [NameInMap("Invocation")]
        [Validation(Required=false)]
        public DescribeInvocationResultsResponseBodyInvocation Invocation { get; set; }
        public class DescribeInvocationResultsResponseBodyInvocation : TeaModel {
            /// <summary>
            /// The execution results.
            /// </summary>
            [NameInMap("InvocationResults")]
            [Validation(Required=false)]
            public DescribeInvocationResultsResponseBodyInvocationInvocationResults InvocationResults { get; set; }
            public class DescribeInvocationResultsResponseBodyInvocationInvocationResults : TeaModel {
                [NameInMap("InvocationResult")]
                [Validation(Required=false)]
                public List<DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResult> InvocationResult { get; set; }
                public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResult : TeaModel {
                    /// <summary>
                    /// The command ID.
                    /// </summary>
                    [NameInMap("CommandId")]
                    [Validation(Required=false)]
                    public string CommandId { get; set; }

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
                    /// The size of the Output text that was truncated and discarded because the `Output` value exceeded 24 KB in size.
                    /// </summary>
                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    /// <summary>
                    /// The error code returned when the command failed to be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is empty, the command was run as expected.
                    /// *   InstanceNotExists: The specified instance did not exist or was released.
                    /// *   InstanceReleased: The instance was released while the command was being run.
                    /// *   InstanceNotRunning: The instance was not running while the command was being run.
                    /// *   CommandNotApplicable: The command was inapplicable to the specified instance.
                    /// *   AccountNotExists: The username specified to run the command did not exist.
                    /// *   DirectoryNotExists: The specified directory did not exist.
                    /// *   BadCronExpression: The specified cron expression for the execution schedule was invalid.
                    /// *   ClientNotRunning: Cloud Assistant Agent was not running.
                    /// *   ClientNotResponse: Cloud Assistant Agent did not respond.
                    /// *   ClientIsUpgrading: Cloud Assistant Agent was being upgraded.
                    /// *   ClientNeedUpgrade: Cloud Assistant Agent needed to be upgraded.
                    /// *   DeliveryTimeout: The request to send the command timed out.
                    /// *   ExecutionTimeout: The execution timed out.
                    /// *   ExecutionException: An exception occurred while the command was being run.
                    /// *   ExecutionInterrupted: The execution was interrupted.
                    /// *   ExitCodeNonzero: The execution was complete, but the exit code was not 0.
                    /// *   SecurityGroupRuleDenied: Access to Cloud Assistant was denied by security group rules.
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
                    /// The exit code of the command task.
                    /// 
                    /// *   For Linux instances, the value is the exit code of the shell command.
                    /// *   For Windows instances, the value is the exit code of the batch or PowerShell command.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the command task was completed. If the command task times out, the end time is equal to the start time of the command task specified by `StartTime` plus the timeout period specified by `Timeout`.
                    /// </summary>
                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The execution status on a single instance. Valid values:
                    /// 
                    /// *   Pending: The command is being verified or sent.
                    /// 
                    /// *   Invalid: The specified command type or parameter is invalid.
                    /// 
                    /// *   Aborted: The command failed to be sent to the instance. To send a command to an instance, make sure that the instance is in the Running state and the command can be sent to the instance within 1 minute.
                    /// 
                    /// *   Running: The command is being run on the instance.
                    /// 
                    /// *   Success:
                    /// 
                    ///     *   One-time task: The execution was complete, and the exit code was 0.
                    ///     *   Scheduled task: The last execution was complete, the exit code was 0, and the specified period ended.
                    /// 
                    /// *   Failed:
                    /// 
                    ///     *   One-time task: The execution was complete, but the exit code was not 0.
                    ///     *   Scheduled task: The last execution was complete, but the exit code was not 0. The specified period was about to end.
                    /// 
                    /// *   Error: The execution cannot proceed due to an exception.
                    /// 
                    /// *   Timeout: The execution timed out.
                    /// 
                    /// *   Cancelled: The execution was canceled before it started.
                    /// 
                    /// *   Stopping: The command task is being stopped.
                    /// 
                    /// *   Terminated: The execution was terminated before completion.
                    /// 
                    /// *   Scheduled:
                    /// 
                    ///     *   One-time task: The execution state can never be Scheduled.
                    ///     *   Scheduled task: The command is waiting to be run.
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
                    /// The execution status of the command. Valid values:
                    /// 
                    /// *   Running:
                    /// 
                    ///     *   Scheduled task: Before you stop the scheduled execution of the command, the execution state is always Running.
                    ///     *   One-time task: If the command is being run on instances, the execution state is Running.
                    /// 
                    /// *   Finished:
                    /// 
                    ///     *   Scheduled task: The execution state can never be Finished.
                    ///     *   One-time task: The execution was complete on all instances, or the execution was stopped on some instances and was complete on the other instances.
                    /// 
                    /// *   Failed:
                    /// 
                    ///     *   Scheduled task: The execution state can never be Failed.
                    ///     *   One-time task: The execution failed on all instances.
                    /// 
                    /// *   PartialFailed:
                    /// 
                    ///     *   Scheduled task: The execution state can never be PartialFailed.
                    ///     *   One-time task: The execution failed on some instances.
                    /// 
                    /// *   Stopped: The task was stopped.
                    /// 
                    /// *   Stopping: The task is being stopped.
                    /// </summary>
                    [NameInMap("InvokeRecordStatus")]
                    [Validation(Required=false)]
                    public string InvokeRecordStatus { get; set; }

                    [NameInMap("Launcher")]
                    [Validation(Required=false)]
                    public string Launcher { get; set; }

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
                    /// The tags of the command task.
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags Tags { get; set; }
                    public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags : TeaModel {
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public List<DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag> Tag { get; set; }
                        public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag : TeaModel {
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
                    /// Indicates how the command task is stopped when a command execution is manually stopped or times out. Valid values:
                    /// 
                    /// *   Process: The process of the command is stopped.
                    /// *   ProcessTree: The process tree of the command is stopped. In this case, the process of the command and all subprocesses are stopped.
                    /// </summary>
                    [NameInMap("TerminationMode")]
                    [Validation(Required=false)]
                    public string TerminationMode { get; set; }

                    /// <summary>
                    /// The username used to run the command on the instance.
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of the commands.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
