// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsResponseBody : TeaModel {
        /// <summary>
        /// The command executions.
        /// </summary>
        [NameInMap("CommandInvocations")]
        [Validation(Required=false)]
        public List<DescribeCommandInvocationsResponseBodyCommandInvocations> CommandInvocations { get; set; }
        public class DescribeCommandInvocationsResponseBodyCommandInvocations : TeaModel {
            /// <summary>
            /// The content of the command.
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// The description of the command.
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
            /// The time when the command was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The overall execution state of the command. Valid values:
            /// 
            /// *   Pending: The command is being verified or sent.
            /// *   Invalid: The specified command type or parameter is invalid.
            /// *   Aborted: The command failed to be sent to the instances. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.
            /// *   Running: The command is being run on the instances.
            /// *   Success: The command execution is complete, and the exit code is 0.
            /// *   Failed: The command execution is complete, and the exit code is not 0.
            /// *   Error: The command execution cannot proceed due to an exception.
            /// *   Timeout: The command execution timed out.
            /// *   Cancelled: The command execution is canceled, and the command is not started.
            /// *   Stopping: The command in the Running state is being stopped.
            /// *   Terminated: The command is terminated when it is being run.
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// The execution ID of the command.
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// The instances on which the command is run.
            /// </summary>
            [NameInMap("InvokeInstances")]
            [Validation(Required=false)]
            public List<DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances> InvokeInstances { get; set; }
            public class DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances : TeaModel {
                /// <summary>
                /// The error code returned if the command failed to be sent or run.
                /// 
                /// *   null: The command is run as expected.
                /// *   InstanceNotExists: The specified instance does not exist or is released.
                /// *   InstanceReleased: The instance is released when the command is being run.
                /// *   InstanceNotRunning: The instance is not in the Running state when the command is being run.
                /// *   CommandNotApplicable: The command is not applicable to the specified instance.
                /// *   AccountNotExists: The specified account does not exist.
                /// *   DirectoryNotExists: The specified directory does not exist.
                /// *   BadCronExpression: The specified CRON expression for the execution schedule is invalid.
                /// *   ClientNotRunning: Cloud Assistant Agent is not running.
                /// *   ClientNotResponse: Cloud Assistant Agent does not respond to your request.
                /// *   ClientIsUpgrading: Cloud Assistant Agent is being updated.
                /// *   ClientNeedUpgrade: Cloud Assistant Agent needs to be updated.
                /// *   DeliveryTimeout: The request to send the command timed out.
                /// *   ExecutionTimeout: The command execution timed out.
                /// *   ExecutionException: An exception occurred when the command was being run.
                /// *   ExecutionInterrupted: The command execution is interrupted.
                /// *   ExitCodeNonzero: The command execution is complete, and the exit code is not 0.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned if the command failed to be sent or run. Valid values:
                /// 
                /// *   null: The command is run as expected.
                /// *   the specified instance does not exists: The specified instance does not exist or is released.
                /// *   the instance has released when create task: The instance is released when the command is being run.
                /// *   the instance is not running when create task: The instance is not in the Running state when the command is being run.
                /// *   the command is not applicable: The command is not applicable to the specified instance.
                /// *   the specified account does not exists: The specified account does not exist.
                /// *   the specified directory does not exists: The specified directory does not exist.
                /// *   the cron job expression is invalid: The specified CRON expression for the execution schedule is invalid.
                /// *   the aliyun service is not running on the instance: Cloud Assistant Agent is not running.
                /// *   the aliyun service in the instance does not response: Cloud Assistant Agent does not respond to your request.
                /// *   the aliyun service in the instance is upgrading now: Cloud Assistant Agent is being updated.
                /// *   the aliyun service in the instance need upgrade: Cloud Assistant Agent needs to be updated.
                /// *   the command delivery has been timeout: The request to send the command timed out.
                /// *   the command execution has been timeout: The command execution timed out.
                /// *   the command execution got an exception: An exception occurred when the command was being run.
                /// *   the command execution has been interrupted: The command execution is interrupted.
                /// *   the command execution exit code is not zero: The command execution is complete, and the exit code is not 0.
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
                /// The end of the time range during which the command is run on the instance.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The ID of the simple application server.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The execution state of the command on a single instance. Valid values:
                /// 
                /// *   Pending: The command is being verified or sent.
                /// 
                /// *   Invalid: The specified command type or parameter is invalid.
                /// 
                /// *   Aborted: The command failed to be sent to the instance. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.
                /// 
                /// *   Running: The command is being run on the instance.
                /// 
                /// *   Success:
                /// 
                ///     *   Command that is set to run only once: The command execution is complete, and the exit code is 0.
                ///     *   Command that is set to run on a schedule: The previous command execution is complete, the exit code is 0, and the specified cycle ends.
                /// 
                /// *   Failed:
                /// 
                ///     *   Command that is set to run only once: The command execution is complete, and the exit code is not 0.
                ///     *   Command that is set to run on a schedule: The previous command execution is complete, the exit code is not 0, and the specified cycle is about to end.
                /// 
                /// *   Error: The command execution cannot proceed due to an exception.
                /// 
                /// *   Timeout: The command execution timed out.
                /// 
                /// *   Cancelled: The command execution is canceled, and the command is not started.
                /// 
                /// *   Stopping: The command task is being stopped.
                /// 
                /// *   Terminated: The command is terminated when it is being run.
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
                /// The beginning of the time range during which the command is run on the instance.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The custom parameters in the command. If no custom parameter exists in the command, the default value is {}.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// The timeout period. Unit: seconds.
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// The username that is used to run the command.
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// The working directory of the command.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
