// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Script execution record object.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>File delivery record.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>Command content.</para>
                /// <list type="bullet">
                /// <item><description>If <c>ContentEncoding</c> is set to <c>PlainText</c>, the original script content is returned.</description></item>
                /// <item><description>If <c>ContentEncoding</c> is set to <c>Base64</c>, the Base64-encoded script content is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
                /// </summary>
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                /// <summary>
                /// <para>Command description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>Command name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CommandTestName</para>
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                /// <summary>
                /// <para>The creation time of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The execution time for scheduled commands.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution status of the command, which depends on the common execution status of all instances involved in the call. Possible values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is validating or sending the command. If at least one instance has a command execution status of Pending, the overall status is Pending.</description></item>
                /// <item><description>Scheduled: The scheduled command has been sent and is waiting to run. If at least one instance has a command execution status of Scheduled, the overall status is Scheduled.</description></item>
                /// <item><description>Running: The command is running on the instance. If at least one instance has a command execution status of Running, the overall status is Running.</description></item>
                /// <item><description>Success: The command execution status of all instances is Stopped or Success, and at least one instance\&quot;s command execution status is Success. The overall status is Success.<list type="bullet">
                /// <item><description>For immediately executed tasks: The command has completed with an exit code of 0.</description></item>
                /// <item><description>For periodically executed tasks: The most recent execution was successful with an exit code of 0, and the specified times have all been completed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed: The command execution status of all instances is Stopped or Failed. The overall status is Failed if any of the following conditions apply to the instance\&quot;s command execution status:<list type="bullet">
                /// <item><description>Command validation failed (Invalid).</description></item>
                /// <item><description>Command sending failed (Aborted).</description></item>
                /// <item><description>Command completed but the exit code is not 0 (Failed).</description></item>
                /// <item><description>Command execution timed out (Timeout).</description></item>
                /// <item><description>Command execution encountered an error (Error).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopping: The task is being stopped. If at least one instance has a command execution status of Stopping, the overall status is Stopping.</description></item>
                /// <item><description>Stopped: The task has been stopped. If all instances\&quot; command execution statuses are Stopped, the overall status is Stopped. The overall status is Stopped if the instance\&quot;s command execution status is any of the following:<list type="bullet">
                /// <item><description>The task was canceled (Cancelled).</description></item>
                /// <item><description>The task was terminated (Terminated).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>PartialFailed: Some instances succeeded and some failed. If the command execution statuses of all instances are Success, Failed, or Stopped, the overall status is PartialFailed.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The <c>InvokeStatus</c> in the response parameters is similar in meaning to this parameter, but it is recommended that you check this return value.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>Command execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-ind3k9ytvvduoe8</para>
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// <para>Command execution records.</para>
                /// </summary>
                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    /// <summary>
                    /// <para>Command execution records for nodes.</para>
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
                        /// <para>The length of the text that is truncated and discarded when the length of the <c>Output</c> field exceeds 24 KB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// <para>Reason code for file delivery failure. Possible values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: File delivery is normal. </description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released. </description></item>
                        /// <item><description>NodeReleased: The instance was released during the file delivery process. </description></item>
                        /// <item><description>NodeNotRunning: The instance was not running when the file delivery task was created. </description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist. </description></item>
                        /// <item><description>ClientNotRunning: The Cloud Assistant Agent is not running. </description></item>
                        /// <item><description>ClientNotResponse: The Cloud Assistant Agent is not responding. </description></item>
                        /// <item><description>ClientIsUpgrading: The Cloud Assistant Agent is currently upgrading. </description></item>
                        /// <item><description>ClientNeedUpgrade: The Cloud Assistant Agent needs to be upgraded. </description></item>
                        /// <item><description>DeliveryTimeout: File sending timed out. </description></item>
                        /// <item><description>FileCreateFail: File creation failed. </description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name already exists at the specified path. </description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid. - FileNameInvalid: The file name is invalid. </description></item>
                        /// <item><description>FilePathInvalid: The file path is invalid. </description></item>
                        /// <item><description>FileAuthorityInvalid: The file permissions are invalid. </description></item>
                        /// <item><description>UserGroupNotExists: The user group specified for file sending does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>Details of the reason for command delivery failure or execution failure, possible values: </para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The command executed normally. </description></item>
                        /// <item><description>the specified node does not exist: The specified instance does not exist or has been released. </description></item>
                        /// <item><description>the node was released when creating the task: The instance was released during command execution. </description></item>
                        /// <item><description>the node is not running when creating the task: The instance was not in a running state when the command was executed. </description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance. </description></item>
                        /// <item><description>the specified account does not exist: The specified account does not exist. </description></item>
                        /// <item><description>the specified directory does not exist: The specified directory does not exist. </description></item>
                        /// <item><description>the cron job expression is invalid: The specified execution time expression is invalid. </description></item>
                        /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant Agent is not running. </description></item>
                        /// <item><description>the aliyun service in the instance does not respond: The Cloud Assistant Agent is not responding. </description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: The Cloud Assistant Agent is currently being upgraded. </description></item>
                        /// <item><description>the aliyun service in the node needs upgrade: The Cloud Assistant Agent needs an upgrade. </description></item>
                        /// <item><description>the command delivery has timed out: Command delivery has timed out. </description></item>
                        /// <item><description>the command execution has timed out: Command execution has timed out. </description></item>
                        /// <item><description>the command execution got an exception: An exception occurred during command execution. </description></item>
                        /// <item><description>the command execution was interrupted: Command execution was interrupted. </description></item>
                        /// <item><description>the command execution exit code is not zero: Command execution completed with a non-zero exit code. </description></item>
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
                        /// <para>The exit code of the command process. Possible values:</para>
                        /// <list type="bullet">
                        /// <item><description>For Linux instances, it is the exit code of the Shell process. - For Windows instances, it is the exit code of the Bat or PowerShell process.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <para>Completion time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The command progress status for a single instance. Possible values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The system is validating or sending the command.</description></item>
                        /// <item><description>Invalid: The specified command type or parameters are incorrect.</description></item>
                        /// <item><description>Aborted: Failed to send the command to the instance. The instance must be running, and the command should be sent within 1 minute.</description></item>
                        /// <item><description>Running: The command is running on the instance.</description></item>
                        /// <item><description>Success:<list type="bullet">
                        /// <item><description>For a one-time execution command: The command has completed with an exit code of 0.</description></item>
                        /// <item><description>For a periodic execution command: The last run was successful with an exit code of 0, and the specified period has ended.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Failed:<list type="bullet">
                        /// <item><description>For a one-time execution command: The command has completed with a non-zero exit code.</description></item>
                        /// <item><description>For a periodic execution command: The last run was successful with a non-zero exit code, and the specified period will be terminated.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Error: An exception occurred during command execution, and it cannot continue.</description></item>
                        /// <item><description>Timeout: The command execution timed out.</description></item>
                        /// <item><description>Cancelled: The command execution action has been canceled, and the command was never started.</description></item>
                        /// <item><description>Stopping: The task is being stopped.</description></item>
                        /// <item><description>Terminated: The command was terminated while running.</description></item>
                        /// <item><description>Scheduled:<list type="bullet">
                        /// <item><description>For a one-time execution command: Not applicable, will not appear.</description></item>
                        /// <item><description>For a periodic execution command: Waiting to run.</description></item>
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
                        /// <para>Node ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e01-cn-lbj36wkp70b</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The command progress status of a single instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("NodeInvokeStatus")]
                        [Validation(Required=false)]
                        public string NodeInvokeStatus { get; set; }

                        /// <summary>
                        /// <para>The output information of the command.</para>
                        /// <list type="bullet">
                        /// <item><description>If <c>ContentEncoding</c> is set to <c>PlainText</c>, the original output information is returned.</description></item>
                        /// <item><description>If <c>ContentEncoding</c> is set to <c>Base64</c>, the Base64-encoded output information is returned.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OutPutTestmsg</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The number of times the command has been executed on this instance.</para>
                        /// <list type="bullet">
                        /// <item><description>If the execution mode is one-time, the value is 0 or 1.</description></item>
                        /// <item><description>If the execution mode is periodic, the value is the number of times it has been executed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// <para>Start Time</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when <c>StopInvocation</c> was called to stop the command execution.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Whether the queried command will be automatically executed in the future. The value range is as follows:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The command, when executed by calling <c>RunCommand</c> or <c>InvokeCommand</c>, has the <c>RepeatMode</c> parameter set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c>. </description></item>
                        /// <item><description>false: Queries commands in the following two states. </description></item>
                        /// <item><description>When executing a command via <c>RunCommand</c> or <c>InvokeCommand</c>, the <c>RepeatMode</c> parameter is set to <c>Once</c>. </description></item>
                        /// <item><description>Commands that have been canceled, stopped, or completed.</description></item>
                        /// </list>
                        /// <para>Default value: false.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public string Timed { get; set; }

                        /// <summary>
                        /// <para>Update Time</para>
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
                /// <para>The overall execution status of the command. The overall execution status depends on the common execution status of one or more instances in the execution. Possible values: </para>
                /// <list type="bullet">
                /// <item><description>Running:<list type="bullet">
                /// <item><description>For scheduled execution: The execution status remains ongoing until the scheduled command is manually stopped.</description></item>
                /// <item><description>For single execution: If there is any command process running, the overall execution status is ongoing.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Finished:<list type="bullet">
                /// <item><description>For scheduled execution: The command process cannot be completed.</description></item>
                /// <item><description>For single execution: All instances have completed execution, or some instances\&quot; command processes are manually stopped and the rest have completed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed:<list type="bullet">
                /// <item><description>For scheduled execution: The command process cannot fail.</description></item>
                /// <item><description>For single execution: All instances have failed to execute.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopped: The command has been stopped.</description></item>
                /// <item><description>Stopping: The command is being stopped.</description></item>
                /// <item><description>PartialFailed: Partial failure; if the <c>InstanceId</c> parameter is set, this does not apply.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// <para>Custom parameters in the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>命令执行的方式。可能值：</para>
                /// <para>Once：立即执行命令。
                /// Period：定时执行命令。
                /// NextRebootOnly：当实例下一次启动时，自动执行命令。
                /// EveryReboot：实例每一次启动都将自动执行命令。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// <para>Timeout for executing the command, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>Username for executing the command.</para>
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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
