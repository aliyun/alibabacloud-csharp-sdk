// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// Details of the execution result.
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
                    /// The ID of the container.
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    /// <summary>
                    /// The name of the container.
                    /// </summary>
                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    /// <summary>
                    /// The size of truncated and discarded text when the size of text in the `Output` response parameter is larger than 24 KB.
                    /// </summary>
                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    /// <summary>
                    /// The error code returned when the command cannot be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is empty, the command is run normally.
                    /// *   InstanceNotExists: The instance does not exist or has been released.
                    /// *   InstanceReleased: The instance is released while the command is being run.
                    /// *   InstanceNotRunning: The instance is not running while the command is being run.
                    /// *   CommandNotApplicable: The command is not applicable to the specified instance.
                    /// *   AccountNotExists: The specified account does not exist.
                    /// *   DirectoryNotExists: The specified directory does not exist.
                    /// *   BadCronExpression: The specified cron expression for the execution schedule is invalid.
                    /// *   ClientNotRunning: The Cloud Assistant client is not running.
                    /// *   ClientNotResponse: The Cloud Assistant client does not respond.
                    /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
                    /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
                    /// *   DeliveryTimeout: The request to send the command has timed out.
                    /// *   ExecutionTimeout: The execution has timed out.
                    /// *   ExecutionException: An exception has occurred while the command is being run.
                    /// *   ExecutionInterrupted: The execution is interrupted.
                    /// *   ExitCodeNonzero: The execution is complete, but the exit code is not 0.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The error message returned when the command cannot be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is empty, the command is run normally.
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
                    /// </summary>
                    [NameInMap("ErrorInfo")]
                    [Validation(Required=false)]
                    public string ErrorInfo { get; set; }

                    /// <summary>
                    /// The exit code of the command execution.
                    /// 
                    /// *   For Linux instances, the value is the exit code of the shell command.
                    /// *   For Windows instances, the value is the exit code of the batch or PowerShell command.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    /// <summary>
                    /// The completion time of the execution. If an execution times out, the completion time of the execution is subject to the value of the TimedOut parameter specified in the [CreateCommand](~~64844~~) operation.
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
                    ///     *   Command that is set to run on a schedule: The last execution succeeds, the exit code is 0, and the specified cycle ends.
                    /// 
                    /// *   Failed:
                    /// 
                    ///     *   Command that is set to run only once: The execution is complete, but the exit code is not 0.
                    ///     *   Command that is set to run on a schedule: The last execution is complete, the exit code is not 0, and the specified execution time is about to end.
                    /// 
                    /// *   Error: The execution cannot proceed due to an exception.
                    /// 
                    /// *   Timeout: The execution times out.
                    /// 
                    /// *   Cancelled: The execution is canceled, and the command is not run.
                    /// 
                    /// *   Stopping: The command that is running is being stopped.
                    /// 
                    /// *   Terminated: The command is terminated while it is being run.
                    /// 
                    /// *   Scheduled:
                    /// 
                    ///     *   Command that is set to run only once: The command is not applicable.
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
                    /// The state of the execution.
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
                    /// The number of times that the command is run on the instance.
                    /// 
                    /// *   If the command is set to run only once on the instance, the value is 0 or 1.
                    /// *   If the command is set to run on a schedule on the instance, the value is the number of times that the command is run.
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
                    /// The time when the command stopped being run on the instance. If you call the `StopInvocation` operation to manually stop the execution, the value is the time when you call the operation.
                    /// </summary>
                    [NameInMap("StopTime")]
                    [Validation(Required=false)]
                    public string StopTime { get; set; }

                    /// <summary>
                    /// The tags of the command.
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
                            /// The tag key of the command.
                            /// </summary>
                            [NameInMap("TagKey")]
                            [Validation(Required=false)]
                            public string TagKey { get; set; }

                            /// <summary>
                            /// The tag value of the command.
                            /// </summary>
                            [NameInMap("TagValue")]
                            [Validation(Required=false)]
                            public string TagValue { get; set; }

                        }

                    }

                    /// <summary>
                    /// The username that was used to run the command on the ECS instance.
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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
