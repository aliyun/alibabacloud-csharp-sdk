// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The invocation records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The file delivery records.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The command content.</para>
                /// <list type="bullet">
                /// <item><description>If ContentEncoding is set to PlainText, the original script content is returned.</description></item>
                /// <item><description>If ContentEncoding is set to Base64, the Base64-encoded script content is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
                /// </summary>
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                /// <summary>
                /// <para>The command description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>The command name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CommandTestName</para>
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                /// <summary>
                /// <para>The time when the task was created. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The execution time of scheduled commands.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution status of the command. The overall execution status depends on the combined execution status of all instances involved in the invocation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is verifying or sending the command. If the execution status of at least one instance is Pending, the overall execution status is Pending.</description></item>
                /// <item><description>Scheduled: The scheduled command has been sent and is waiting to be executed. If the execution status of at least one instance is Scheduled, the overall execution status is Scheduled.</description></item>
                /// <item><description>Running: The command is running on the instances. If the execution status of at least one instance is Running, the overall execution status is Running.</description></item>
                /// <item><description>Success: The execution status of all instances is Stopped or Success, and the execution status of at least one instance is Success.<list type="bullet">
                /// <item><description>For tasks that run immediately: The command execution is complete, and the exit code is 0.</description></item>
                /// <item><description>For scheduled tasks: The most recent execution was successful with an exit code of 0, and all specified execution times have elapsed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed: The execution status of all instances is Stopped or Failed. The overall execution status is Failed if the execution status of one or more instances is any of the following:<list type="bullet">
                /// <item><description>Invalid: Command verification failed.</description></item>
                /// <item><description>Aborted: Command sending failed.</description></item>
                /// <item><description>Failed: Command execution is complete, but the exit code is not 0.</description></item>
                /// <item><description>Timeout: Command execution timed out.</description></item>
                /// <item><description>Error: An exception occurred during command execution.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopping: The task is being stopped. If the execution status of at least one instance is Stopping, the overall execution status is Stopping.</description></item>
                /// <item><description>Stopped: The task has been stopped. If the execution status of all instances is Stopped, the overall execution status is Stopped. The overall execution status is Stopped if the execution status of one or more instances is any of the following:<list type="bullet">
                /// <item><description>Cancelled: The task was canceled.</description></item>
                /// <item><description>Terminated: The task was terminated.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>PartialFailed: The command execution succeeded on some instances and failed on others. If the execution status of all instances is Success, Failed, or Stopped, the overall execution status is PartialFailed.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The InvokeStatus response parameter has a similar meaning to this parameter, but we recommend that you check this return value.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The invocation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-ind3k9ytvvduoe8</para>
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// <para>The command execution records.</para>
                /// </summary>
                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    /// <summary>
                    /// <para>The command execution records of the node.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The start time of the command execution. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The length of the truncated and discarded text when the text length in the Output field exceeds 24 KB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// <para>The error code for the file delivery failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The file is delivered normally.</description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>NodeReleased: The instance was released during file delivery.</description></item>
                        /// <item><description>NodeNotRunning: The instance was not in the Running state when the file delivery task was created.</description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                        /// <item><description>ClientNotRunning: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>ClientNotResponse: Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>ClientIsUpgrading: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: The file delivery timed out.</description></item>
                        /// <item><description>FileCreateFail: File creation failed.</description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name already exists in the same path.</description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid.</description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid.</description></item>
                        /// <item><description>FilePathInvalid: The file path is invalid.</description></item>
                        /// <item><description>FileAuthorityInvalid: The file permissions are invalid.</description></item>
                        /// <item><description>UserGroupNotExists: The specified user group does not exist when sending the file.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The details of the cause for the command delivery or execution failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The command is executed normally.</description></item>
                        /// <item><description>the specified node does not exists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>the node has node when create task: The instance was released during command execution.</description></item>
                        /// <item><description>the node is not running when create task: The instance was not in the Running state during command execution.</description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                        /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                        /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                        /// <item><description>the cron job expression is invalid: The specified cron expression is invalid.</description></item>
                        /// <item><description>the aliyun service is not running on the instance: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>the aliyun service in the instance does not response: Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>the aliyun service in the node need upgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>the command delivery has been timeout: The command delivery timed out.</description></item>
                        /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
                        /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
                        /// <item><description>the command execution has been interrupted: The command execution was interrupted.</description></item>
                        /// <item><description>the command execution exit code is not zero: The command execution is complete, but the exit code is not 0.</description></item>
                        /// <item><description>the specified node has been released: The instance was released during file delivery.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified node does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>The exit code of the command process. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>For Linux instances, the exit code of the shell process.</description></item>
                        /// <item><description>For Windows instances, the exit code of the batch or PowerShell process.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <para>The completion time. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The command execution status on a single instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The system is verifying or sending the command.</description></item>
                        /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
                        /// <item><description>Aborted: Failed to send the command to the instance. The instance must be in the Running state, and the command must be sent within 1 minute.</description></item>
                        /// <item><description>Running: The command is running on the instance.</description></item>
                        /// <item><description>Success:<list type="bullet">
                        /// <item><description>One-time execution: The command execution is complete, and the exit code is 0.</description></item>
                        /// <item><description>Scheduled execution: The previous execution was successful with an exit code of 0, and the specified schedule has ended.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Failed:<list type="bullet">
                        /// <item><description>One-time execution: The command execution is complete, but the exit code is not 0.</description></item>
                        /// <item><description>Scheduled execution: The previous execution completed with a non-zero exit code, and the specified schedule will be terminated.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Error: An exception occurred during command execution and the execution cannot continue.</description></item>
                        /// <item><description>Timeout: The command execution timed out.</description></item>
                        /// <item><description>Cancelled: The command execution was canceled before it started.</description></item>
                        /// <item><description>Stopping: The task is being stopped.</description></item>
                        /// <item><description>Terminated: The command was terminated while running.</description></item>
                        /// <item><description>Scheduled:<list type="bullet">
                        /// <item><description>One-time execution: Not applicable. This status does not appear.</description></item>
                        /// <item><description>Scheduled execution: Waiting to be executed.</description></item>
                        /// </list>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pending</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <para>The node ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e01-cn-lbj36wkp70b</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The command execution status on a single instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("NodeInvokeStatus")]
                        [Validation(Required=false)]
                        public string NodeInvokeStatus { get; set; }

                        /// <summary>
                        /// <para>The output of the command.</para>
                        /// <list type="bullet">
                        /// <item><description>If ContentEncoding is set to PlainText, the original output is returned.</description></item>
                        /// <item><description>If ContentEncoding is set to Base64, the Base64-encoded output is returned.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OutPutTestmsg</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The number of times the command was executed on the instance.</para>
                        /// <list type="bullet">
                        /// <item><description>If the execution mode is one-time execution, the value is 0 or 1.</description></item>
                        /// <item><description>If the execution mode is scheduled execution, the value is the total number of executions.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// <para>The start time. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when the StopInvocation operation was called to stop the command execution. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the queried command will be automatically executed in the future. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: Queries commands for which the RepeatMode parameter is set to Period, NextRebootOnly, or EveryReboot when calling RunCommand or InvokeCommand.</description></item>
                        /// <item><description>false: Queries commands in the following two states. This is the default value.<list type="bullet">
                        /// <item><description>Commands for which the RepeatMode parameter is set to Once when calling RunCommand or InvokeCommand.</description></item>
                        /// <item><description>Commands that have been canceled, stopped, or completed.</description></item>
                        /// </list>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public string Timed { get; set; }

                        /// <summary>
                        /// <para>The update time. The time follows the ISO 8601 standard, and Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The overall execution status of the command. The overall execution status depends on the combined execution status of one or more instances in the invocation. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>Running:<list type="bullet">
                /// <item><description>Scheduled execution: The execution status remains Running until the scheduled command is manually stopped.</description></item>
                /// <item><description>One-time execution: The overall execution status is Running as long as there is an ongoing command process.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Finished:<list type="bullet">
                /// <item><description>Scheduled execution: The command process cannot be Finished.</description></item>
                /// <item><description>One-time execution: All instances have completed the execution, or the command processes on some instances are manually stopped while the execution on the remaining instances is completed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed:<list type="bullet">
                /// <item><description>Scheduled execution: The command process cannot be Failed.</description></item>
                /// <item><description>One-time execution: The execution failed on all instances.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopped: The command is stopped.</description></item>
                /// <item><description>Stopping: The command is being stopped.</description></item>
                /// <item><description>PartialFailed: The execution partially failed. This value does not take effect if the InstanceId parameter is also specified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// <para>The custom parameters in the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The execution mode of the command. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Once: Executes the command immediately.</description></item>
                /// <item><description>Period: Executes the command on a schedule.</description></item>
                /// <item><description>NextRebootOnly: Automatically executes the command the next time the instance starts.</description></item>
                /// <item><description>EveryReboot: Automatically executes the command every time the instance starts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// <para>The timeout period for executing the command. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The username of the user who executes the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The working directory of the command on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/home</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
