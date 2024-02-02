// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// The information about the execution results.
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
                    /// The ID of the command.
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
                    /// The size of the text that is truncated and discarded when the `Output` value exceeds 24 KB in size.
                    /// </summary>
                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    /// <summary>
                    /// The error code returned when the command failed to be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is left empty, the command is run normally.
                    /// *   InstanceNotExists: The instance does not exist or is released.
                    /// *   InstanceReleased: The instance is released while the command is being run.
                    /// *   InstanceNotRunning: The instance is not running while the command is being run.
                    /// *   CommandNotApplicable: The command is not applicable to the specified instance.
                    /// *   AccountNotExists: The specified account does not exist.
                    /// *   DirectoryNotExists: The specified directory does not exist.
                    /// *   BadCronExpression: The specified cron expression for the execution schedule is invalid.
                    /// *   ClientNotRunning: Cloud Assistant Agent is not running.
                    /// *   ClientNotResponse: Cloud Assistant Agent does not respond.
                    /// *   ClientIsUpgrading: Cloud Assistant Agent was being upgraded.
                    /// *   ClientNeedUpgrade: Cloud Assistant Agent must be upgraded.
                    /// *   DeliveryTimeout: The request to send the command timed out.
                    /// *   ExecutionTimeout: The request to send the command timed out.
                    /// *   ExecutionException: An exception occurred while the command is being run.
                    /// *   ExecutionInterrupted: The execution is interrupted.
                    /// *   ExitCodeNonzero: The execution is complete, but the exit code is not 0.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The error message returned when the command failed to be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is left empty, the command is run normally.
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
                    /// The exit code of the command task.
                    /// 
                    /// *   For Linux instances, the exit code is the exit code of the shell command.
                    /// *   For Windows instances, the exit code is the exit code of the batch or PowerShell command.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    /// <summary>
                    /// The time when the command task was complete. If the command task times out, the end time is equal to the start time of the command task specified by StartTime plus the timeout period specified by Timeout in the [CreateCommand](~~64844~~) operation.
                    /// </summary>
                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

                    /// <summary>
                    /// The ID of the instance
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The execution state on a single instance. Valid values:
                    /// 
                    /// *   Pending: The command is being verified or sent.
                    /// 
                    /// *   Invalid: The specified command type or parameter is invalid.
                    /// 
                    /// *   Aborted: The command failed to be sent. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.
                    /// 
                    /// *   Running: The command is being run on the instance.
                    /// 
                    /// *   Success:
                    /// 
                    ///     *   Command that is set to run only once: The execution is complete, and the exit code is 0.
                    ///     *   Command that is set to run on a schedule: The previous execution is complete, and the exit code is 0. The specified execution period ends.
                    /// 
                    /// *   Failed:
                    /// 
                    ///     *   Command that is set to run only once: The execution is complete, but the exit code is not 0.
                    ///     *   Command that is set to run on a schedule: The previous execution is complete, but the exit code is not 0. The specified execution period is about to end.
                    /// 
                    /// *   Error: The execution cannot proceed due to an exception.
                    /// 
                    /// *   Timeout: The execution timed out.
                    /// 
                    /// *   Cancelled: The execution is canceled, and the command is not run.
                    /// 
                    /// *   Stopping: The command task is being stopped.
                    /// 
                    /// *   Terminated: The command task is terminated while it is being run.
                    /// 
                    /// *   Scheduled:
                    /// 
                    ///     *   Command that is set to run only once: The execution state cannot be Scheduled.
                    ///     *   Command that is set to run on a schedule: The command is waiting to be run.
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
                    /// The execution state of the command task.
                    /// </summary>
                    [NameInMap("InvokeRecordStatus")]
                    [Validation(Required=false)]
                    public string InvokeRecordStatus { get; set; }

                    /// <summary>
                    /// The command output.
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// The number of times that the command was run on the instance.
                    /// 
                    /// *   If the command is set to run only once, the value is 0 or 1.
                    /// *   If the command is set to run on a schedule, the value is the number of times that the command was run.
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
                    /// The username that was used to run the command on the instance.
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// The query token returned in this call.
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
