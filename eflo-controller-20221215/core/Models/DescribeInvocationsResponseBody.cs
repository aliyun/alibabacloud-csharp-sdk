// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that contains the script execution records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The command execution records.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The content of the command.</para>
                /// <list type="bullet">
                /// <item><description><para>If \<c>ContentEncoding\\</c> is set to \<c>PlainText\\</c>, the original script content is returned.</para>
                /// </description></item>
                /// <item><description><para>If \<c>ContentEncoding\\</c> is set to \<c>Base64\\</c>, the Base64-encoded script content is returned.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
                /// </summary>
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                /// <summary>
                /// <para>The description of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>The name of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CommandTestName</para>
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The cron expression for the scheduled command.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution status of the command. This status is determined by the execution status on all involved instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The system is verifying or sending the command. If the command is in the Pending state on at least one instance, the overall status is Pending.</para>
                /// </description></item>
                /// <item><description><para>Scheduled: The scheduled command is sent and is waiting to run. If the command is in the Scheduled state on at least one instance, the overall status is Scheduled.</para>
                /// </description></item>
                /// <item><description><para>Running: The command is running on the instances. If the command is in the Running state on at least one instance, the overall status is Running.</para>
                /// </description></item>
                /// <item><description><para>Success: The command was successfully executed. The command status on each instance is Stopped or Success, and the status on at least one instance is Success.</para>
                /// <list type="bullet">
                /// <item><description><para>For one-time tasks: The command execution is complete and the exit code is 0.</para>
                /// </description></item>
                /// <item><description><para>For scheduled tasks: The last execution was successful with an exit code of 0, and all scheduled executions are complete.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Failed: The command execution failed. The command status on each instance is Stopped or Failed. The overall status is Failed if the command status on one or more instances is one of the following:</para>
                /// <list type="bullet">
                /// <item><description><para>The command failed to be verified (Invalid).</para>
                /// </description></item>
                /// <item><description><para>The command failed to be sent (Aborted).</para>
                /// </description></item>
                /// <item><description><para>The command execution is complete, but the exit code is not 0 (Failed).</para>
                /// </description></item>
                /// <item><description><para>The command timed out (Timeout).</para>
                /// </description></item>
                /// <item><description><para>An error occurred during the command execution (Error).</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Stopping: The task is being stopped. If the command is in the Stopping state on at least one instance, the overall status is Stopping.</para>
                /// </description></item>
                /// <item><description><para>Stopped: The task was stopped. The overall status is Stopped if the command is in the Stopped state on all instances. The overall status is Stopped if the command status on the instances is one of the following:</para>
                /// <list type="bullet">
                /// <item><description><para>The task was canceled (Cancelled).</para>
                /// </description></item>
                /// <item><description><para>The task was terminated (Terminated).</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>PartialFailed: The command was successfully executed on some instances but failed on others. The overall status is PartialFailed if the command status on the instances is Success, Failed, or Stopped.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>The <c>InvokeStatus</c> parameter has a similar meaning. However, check the value of this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The ID of the command execution.</para>
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
                    /// <para>The command execution records on the nodes.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The start time of the command execution.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The number of characters that are truncated and discarded because the \<c>Output\\</c> value exceeds 24 KB in size.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// <para>The error code for a file sending failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Empty: The file was sent as expected.</para>
                        /// </description></item>
                        /// <item><description><para>NodeNotExists: The specified instance does not exist or has been released.</para>
                        /// </description></item>
                        /// <item><description><para>NodeReleased: The instance was released while the file was being sent.</para>
                        /// </description></item>
                        /// <item><description><para>NodeNotRunning: The instance was not in the Running state when the file sending task was created.</para>
                        /// </description></item>
                        /// <item><description><para>AccountNotExists: The specified account does not exist.</para>
                        /// </description></item>
                        /// <item><description><para>ClientNotRunning: Cloud Assistant Agent is not running.</para>
                        /// </description></item>
                        /// <item><description><para>ClientNotResponse: Cloud Assistant Agent is not responding.</para>
                        /// </description></item>
                        /// <item><description><para>ClientIsUpgrading: Cloud Assistant Agent is being upgraded.</para>
                        /// </description></item>
                        /// <item><description><para>ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.</para>
                        /// </description></item>
                        /// <item><description><para>DeliveryTimeout: The file failed to be sent due to a timeout.</para>
                        /// </description></item>
                        /// <item><description><para>FileCreateFail: The file failed to be created.</para>
                        /// </description></item>
                        /// <item><description><para>FileAlreadyExists: A file with the same name exists in the same path.</para>
                        /// </description></item>
                        /// <item><description><para>FileContentInvalid: The file content is invalid.</para>
                        /// </description></item>
                        /// <item><description><para>FileNameInvalid: The file name is invalid.</para>
                        /// </description></item>
                        /// <item><description><para>FilePathInvalid: The file path is invalid.</para>
                        /// </description></item>
                        /// <item><description><para>FileAuthorityInvalid: The file permissions are invalid.</para>
                        /// </description></item>
                        /// <item><description><para>UserGroupNotExists: The user group specified for sending the file does not exist.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The details about the cause of a command sending or execution failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Empty: The command was executed as expected.</para>
                        /// </description></item>
                        /// <item><description><para>the specified node does not exist: The specified instance does not exist or has been released.</para>
                        /// </description></item>
                        /// <item><description><para>the instance was released during the command execution: The instance was released during the command execution.</para>
                        /// </description></item>
                        /// <item><description><para>the instance is not running when create task: The instance was not in the Running state during the command execution.</para>
                        /// </description></item>
                        /// <item><description><para>the command is not applicable: The command is not applicable to the specified instance.</para>
                        /// </description></item>
                        /// <item><description><para>the specified account does not exist: The specified account does not exist.</para>
                        /// </description></item>
                        /// <item><description><para>the specified directory does not exist: The specified directory does not exist.</para>
                        /// </description></item>
                        /// <item><description><para>the cron job expression is invalid: The specified cron expression is invalid.</para>
                        /// </description></item>
                        /// <item><description><para>Cloud Assistant Agent is not running: Cloud Assistant Agent is not running.</para>
                        /// </description></item>
                        /// <item><description><para>Cloud Assistant Agent is not responding: Cloud Assistant Agent is not responding.</para>
                        /// </description></item>
                        /// <item><description><para>Cloud Assistant Agent is being upgraded: Cloud Assistant Agent is being upgraded.</para>
                        /// </description></item>
                        /// <item><description><para>Cloud Assistant Agent needs to be upgraded: Cloud Assistant Agent needs to be upgraded.</para>
                        /// </description></item>
                        /// <item><description><para>The command failed to be sent due to a timeout: The command failed to be sent due to a timeout.</para>
                        /// </description></item>
                        /// <item><description><para>The command execution timed out: The command execution timed out.</para>
                        /// </description></item>
                        /// <item><description><para>An exception occurred during the command execution: An exception occurred during the command execution.</para>
                        /// </description></item>
                        /// <item><description><para>The command execution was interrupted: The command execution was interrupted.</para>
                        /// </description></item>
                        /// <item><description><para>The command execution is complete, but the exit code is not 0: The command execution is complete, but the exit code is not 0.</para>
                        /// </description></item>
                        /// <item><description><para>The instance was released while the file was being sent: The instance was released while the file was being sent.</para>
                        /// </description></item>
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
                        /// <item><description><para>On a Linux instance, this is the exit code of the Shell process.</para>
                        /// </description></item>
                        /// <item><description><para>On a Windows instance, this is the exit code of the Batch or PowerShell process.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <para>The time when the execution was complete.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The execution status of the command on a single instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Pending: The system is verifying or sending the command.</para>
                        /// </description></item>
                        /// <item><description><para>Invalid: The specified command type or parameter is incorrect.</para>
                        /// </description></item>
                        /// <item><description><para>Aborted: Failed to send the command to the instance. The instance must be in the Running state and the command must be sent within 1 minute.</para>
                        /// </description></item>
                        /// <item><description><para>Running: The command is running on the instance.</para>
                        /// </description></item>
                        /// <item><description><para>Success:</para>
                        /// <list type="bullet">
                        /// <item><description><para>For a one-time command: The execution is complete and the exit code is 0.</para>
                        /// </description></item>
                        /// <item><description><para>For a scheduled command: The last execution was successful with an exit code of 0, and the specified period is over.</para>
                        /// </description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description><para>Failed:</para>
                        /// <list type="bullet">
                        /// <item><description><para>For a one-time command: The execution is complete, but the exit code is not 0.</para>
                        /// </description></item>
                        /// <item><description><para>For a scheduled command: The last execution was successful, but the exit code was not 0. The scheduled execution will be aborted.</para>
                        /// </description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description><para>Error: An exception occurred during the command execution and the execution cannot continue.</para>
                        /// </description></item>
                        /// <item><description><para>Timeout: The command execution timed out.</para>
                        /// </description></item>
                        /// <item><description><para>Cancelled: The command execution was canceled. The command was not started.</para>
                        /// </description></item>
                        /// <item><description><para>Stopping: The task is being stopped.</para>
                        /// </description></item>
                        /// <item><description><para>Terminated: The command was terminated during execution.</para>
                        /// </description></item>
                        /// <item><description><para>Scheduled:</para>
                        /// <list type="bullet">
                        /// <item><description><para>For a one-time command: This status is not applicable and will not occur.</para>
                        /// </description></item>
                        /// <item><description><para>For a scheduled command: The command is waiting to run.</para>
                        /// </description></item>
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
                        /// <para>The ID of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e01-cn-lbj36wkp70b</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The execution status of the command on a single instance.</para>
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
                        /// <item><description><para>If \<c>ContentEncoding\\</c> is set to \<c>PlainText\\</c>, the original output is returned.</para>
                        /// </description></item>
                        /// <item><description><para>If \<c>ContentEncoding\\</c> is set to \<c>Base64\\</c>, the Base64-encoded output is returned.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OutPutTestmsg</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The number of times the command has been executed on the instance.</para>
                        /// <list type="bullet">
                        /// <item><description><para>If the command is a one-time execution, the value is 0 or 1.</para>
                        /// </description></item>
                        /// <item><description><para>If the command is a scheduled execution, the value is the number of times the command has been executed.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// <para>The start time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when \<c>StopInvocation\\</c> was called to stop the command execution.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the command will be automatically run in the future. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>true: The command is a scheduled command. The <c>RepeatMode</c> parameter was set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c> when <c>RunCommand</c> or <c>InvokeCommand</c> was called.</para>
                        /// </description></item>
                        /// <item><description><para>false (default): The command is a one-time command or has finished.</para>
                        /// <list type="bullet">
                        /// <item><description><para>The <c>RepeatMode</c> parameter was set to <c>Once</c> when <c>RunCommand</c> or <c>InvokeCommand</c> was called.</para>
                        /// </description></item>
                        /// <item><description><para>The command was canceled, stopped, or has finished running.</para>
                        /// </description></item>
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
                        /// <para>The time when the record was updated.</para>
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
                /// <para>The overall execution status of the command. This status is determined by the execution status on one or more instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Running:</para>
                /// <list type="bullet">
                /// <item><description><para>Scheduled execution: The status is always Running before you manually stop the scheduled command.</para>
                /// </description></item>
                /// <item><description><para>One-time execution: The overall status is Running if a command process is in progress.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Finished:</para>
                /// <list type="bullet">
                /// <item><description><para>Scheduled execution: A command process cannot be in the Finished state.</para>
                /// </description></item>
                /// <item><description><para>One-time execution: The execution is complete on all instances. Alternatively, the command process is manually stopped on some instances and the execution is complete on the other instances.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Failed:</para>
                /// <list type="bullet">
                /// <item><description><para>Scheduled execution: A command process cannot be in the Failed state.</para>
                /// </description></item>
                /// <item><description><para>One-time execution: The execution failed on all instances.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Stopped: The command is stopped.</para>
                /// </description></item>
                /// <item><description><para>Stopping: The command is being stopped.</para>
                /// </description></item>
                /// <item><description><para>PartialFailed: The execution failed on some instances. This value is not returned if you specify the <c>NodeId</c> parameter.</para>
                /// </description></item>
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
                /// <item><description><para>Once: The command is immediately executed.</para>
                /// </description></item>
                /// <item><description><para>Period: The command is executed on a schedule.</para>
                /// </description></item>
                /// <item><description><para>NextRebootOnly: The command is automatically executed the next time the instance starts.</para>
                /// </description></item>
                /// <item><description><para>EveryReboot: The command is automatically executed every time the instance starts.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// <para>The timeout period for the command execution. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The name of the user who runs the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The directory where the command is run on the instance.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
