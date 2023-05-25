// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// The execution results.
        /// </summary>
        [NameInMap("Invocation")]
        [Validation(Required=false)]
        public DescribeInvocationResultsResponseBodyInvocation Invocation { get; set; }
        public class DescribeInvocationResultsResponseBodyInvocation : TeaModel {
            /// <summary>
            /// The ID of the instance
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
                    /// The time when the command stopped being run on the instance. If you called the `StopInvocation` operation to manually stop the execution, the value is the time when you called the operation.
                    /// </summary>
                    [NameInMap("CommandId")]
                    [Validation(Required=false)]
                    public string CommandId { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    /// <summary>
                    /// The error message returned when the command is not successfully sent or run. Valid values:
                    /// 
                    /// *   If this parameter is empty, the command is run normally.
                    /// *   the specified instance does not exists: The specified instance does not exist is released.
                    /// *   the instance has released when create task: The instance was released while the command was being run on the instance.
                    /// *   the instance is not running when create task: The instance is not in the Running state while the command is being run.
                    /// *   the command is not applicable: The command is not applicable to the specified instance.
                    /// *   the specified account does not exists: The specified account does not exist.
                    /// *   the specified directory does not exists: The specified directory does not exist.
                    /// *   the cron job expression is invalid: The cron expression that specifies the execution time is invalid.
                    /// *   the aliyun service is not running on the instance: The Cloud Assistance client is not running.
                    /// *   the aliyun service in the instance does not response: The Cloud Assistant client is not responding.
                    /// *   the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.
                    /// *   the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.
                    /// *   the command delivery has been timeout: The request to send the command timed out.
                    /// *   the command execution has been timeout: The command execution timed out.
                    /// *   the command execution got an exception: An exception occurred while the command is being run.
                    /// *   the command execution has been interrupted: The command execution was interrupted.
                    /// *   the command execution exit code is not zero: The command execution is complete, but the exit code is not 0.
                    /// </summary>
                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    /// <summary>
                    /// The name of the user who ran the command on the instance.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The execution state of the command.
                    /// </summary>
                    [NameInMap("ErrorInfo")]
                    [Validation(Required=false)]
                    public string ErrorInfo { get; set; }

                    /// <summary>
                    /// The end time of the execution. If an execution times out, the end time of the execution is subject to the value of the TimedOut parameter specified in the [CreateCommand](~~64844~~) operation.
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    /// <summary>
                    /// The ID of the container.
                    /// </summary>
                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

                    /// <summary>
                    /// The exit code of the command execution.
                    /// 
                    /// *   For Linux instances, the value is the exit code of the shell command.
                    /// *   For Windows instances, the value is the exit code of the batch or PowerShell command.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The command output.
                    /// </summary>
                    [NameInMap("InvocationStatus")]
                    [Validation(Required=false)]
                    public string InvocationStatus { get; set; }

                    /// <summary>
                    /// The name of the container.
                    /// </summary>
                    [NameInMap("InvokeId")]
                    [Validation(Required=false)]
                    public string InvokeId { get; set; }

                    /// <summary>
                    /// The tags of the command execution.
                    /// </summary>
                    [NameInMap("InvokeRecordStatus")]
                    [Validation(Required=false)]
                    public string InvokeRecordStatus { get; set; }

                    /// <summary>
                    /// The time when the command started to be run on the instance.
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// The size of the text that is truncated and discarded when the `Output` value exceeds 24 KB in size.
                    /// </summary>
                    [NameInMap("Repeats")]
                    [Validation(Required=false)]
                    public int? Repeats { get; set; }

                    /// <summary>
                    /// The ID of the command execution.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The error code returned when the command cannot be sent or run. Valid values:
                    /// 
                    /// *   If this parameter is empty, the command is run normally.
                    /// *   InstanceNotExists: The specified instance does not exist is released.
                    /// *   InstanceReleased: The instance was released while the command was being run on the instance.
                    /// *   InstanceNotRunning: The instance is not in the Running state while the command is being run.
                    /// *   CommandNotApplicable: The command is not applicable to the specified instance.
                    /// *   AccountNotExists: The specified account does not exist.
                    /// *   DirectoryNotExists: The specified directory does not exist.
                    /// *   BadCronExpression: The cron expression used to specify the execution time is invalid.
                    /// *   ClientNotRunning: The Cloud Assistant client is not running.
                    /// *   ClientNotResponse: The Cloud Assistant client is not responding.
                    /// *   ClientIsUpgrading: The Cloud Assistant client is being upgraded.
                    /// *   ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.
                    /// *   DeliveryTimeout: The request to send the command timed out.
                    /// *   ExecutionTimeout: The command execution timed out.
                    /// *   ExecutionException: An exception occurred while the command was being run.
                    /// *   ExecutionInterrupted: The execution was interrupted.
                    /// *   ExitCodeNonzero: The command execution is complete, but the exit code is not 0.
                    /// </summary>
                    [NameInMap("StopTime")]
                    [Validation(Required=false)]
                    public string StopTime { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags Tags { get; set; }
                    public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTags : TeaModel {
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public List<DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag> Tag { get; set; }
                        public class DescribeInvocationResultsResponseBodyInvocationInvocationResultsInvocationResultTagsTag : TeaModel {
                            [NameInMap("TagKey")]
                            [Validation(Required=false)]
                            public string TagKey { get; set; }

                            [NameInMap("TagValue")]
                            [Validation(Required=false)]
                            public string TagValue { get; set; }

                        }

                    }

                    /// <summary>
                    /// The information about the tag.
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// The number of times that the command is run on the instance.
            /// 
            /// *   If the command is set to run only once on the instance, the value is 0 or 1.
            /// *   If the command is set to run on a schedule on the instance, the value is the number of times that the command is run.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

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
            ///     *   Command that is set to run on a schedule: The last execution is complete, the exit code is not 0, and the specified cycle is about to end.
            /// 
            /// *   Error: The execution cannot proceed due to an exception.
            /// 
            /// *   Timeout: The execution times out.
            /// 
            /// *   Cancelled: The execution is canceled, and the command is not run.
            /// 
            /// *   Stopping: The running command is being stopped.
            /// 
            /// *   Terminated: The command is terminated while it is being run.
            /// 
            /// *   Scheduled:
            /// 
            ///     *   Command that is set to run only once: The command is not applicable.
            ///     *   Command that is set to run on a schedule: The command is waiting to be run.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The ID of the command.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The total number of the commands.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
