// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The script execution records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The file delivery record.</para>
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
                /// <para>The time when the task was created. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The execution time of the scheduled command.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution status of the command. The overall execution status depends on the common execution status across all instances in this invocation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is validating or sending the command. When the command execution status on at least one instance is Pending, the overall execution status is Pending.</description></item>
                /// <item><description>Scheduled: The scheduled command has been sent and is waiting to run. When the command execution status on at least one instance is Scheduled, the overall execution status is Scheduled.</description></item>
                /// <item><description>Running: The command is running on the instance. When the command execution status on at least one instance is Running, the overall execution status is Running.</description></item>
                /// <item><description>Success: The command execution status on each instance is Stopped or Success, and the command execution status on at least one instance is Success. The overall execution status is Success.<list type="bullet">
                /// <item><description>One-time task: The command execution is complete and the exit code is 0.</description></item>
                /// <item><description>Scheduled task: The last execution was successful with an exit code of 0, and all specified schedules have been completed.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed: The command execution status on each instance is Stopped or Failed. The overall execution status is Failed. The return value is Failed when the command execution status on an instance is one or more of the following:<list type="bullet">
                /// <item><description>Command validation failed (Invalid).</description></item>
                /// <item><description>Command delivery failed (Aborted).</description></item>
                /// <item><description>Command execution completed with a non-zero exit code (Failed).</description></item>
                /// <item><description>Command execution timed out (Timeout).</description></item>
                /// <item><description>Command execution encountered an exception (Error).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopping: The task is being stopped. When the command execution status on at least one instance is Stopping, the overall execution status is Stopping.</description></item>
                /// <item><description>Stopped: The task has been stopped. When the command execution status on all instances is Stopped, the overall execution status is Stopped. The return value is Stopped when the command execution status on an instance is one of the following:<list type="bullet">
                /// <item><description>The task was canceled (Cancelled).</description></item>
                /// <item><description>The task was terminated (Terminated).</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>PartialFailed: Some instances executed successfully while others failed. When the command execution status on each instance is Success, Failed, or Stopped, the overall execution status is PartialFailed.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The InvokeStatus parameter in the response has a similar meaning, but we recommend that you check this parameter instead.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The command execution ID.</para>
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
                    /// <para>The command execution record on a node.</para>
                    /// </summary>
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <para>The start time of the command execution. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The length of the truncated and discarded text after the text length in the Output field exceeds 24 KB.</para>
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
                        /// <item><description>Empty: The file was delivered normally.</description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>NodeReleased: The instance was released during file delivery.</description></item>
                        /// <item><description>NodeNotRunning: The instance was not running when the file delivery task was created.</description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                        /// <item><description>ClientNotRunning: The Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>ClientNotResponse: The Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>ClientIsUpgrading: The Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: The file delivery timed out.</description></item>
                        /// <item><description>FileCreateFail: The file creation failed.</description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name already exists in the same path.</description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid.</description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid.</description></item>
                        /// <item><description>FilePathInvalid: The file path is invalid.</description></item>
                        /// <item><description>FileAuthorityInvalid: The file permissions are invalid.</description></item>
                        /// <item><description>UserGroupNotExists: The user group specified during file delivery does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The details of the command delivery failure or execution failure. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Empty: The command executed normally.</description></item>
                        /// <item><description>the specified node does not exists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>the node has node when create task: The instance was released during command execution.</description></item>
                        /// <item><description>the node is not running when create task: The instance was not running when the command was executed.</description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                        /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                        /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                        /// <item><description>the cron job expression is invalid: The specified execution schedule expression is invalid.</description></item>
                        /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant Agent is not responding.</description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: The Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>the aliyun service in the node need upgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>the command delivery has been timeout: The command delivery timed out.</description></item>
                        /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
                        /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
                        /// <item><description>the command execution has been interrupted: The command execution was interrupted.</description></item>
                        /// <item><description>the command execution exit code is not zero: The command execution completed with a non-zero exit code.</description></item>
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
                        /// <item><description>For Linux instances, the value is the exit code of the Shell process.</description></item>
                        /// <item><description>For Windows instances, the value is the exit code of the Bat or PowerShell process.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <para>The completion time. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
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
                        /// <item><description>Pending: The system is validating or sending the command.</description></item>
                        /// <item><description>Invalid: The specified command type or parameters are invalid.</description></item>
                        /// <item><description>Aborted: Failed to send the command to the instance. The instance must be running, and the command must be deliverable within one minute.</description></item>
                        /// <item><description>Running: The command is running on the instance.</description></item>
                        /// <item><description>Success:<list type="bullet">
                        /// <item><description>One-time command: The command execution is complete and the exit code is 0.</description></item>
                        /// <item><description>Scheduled command: The last execution was successful with an exit code of 0, and the specified schedule has ended.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Failed:<list type="bullet">
                        /// <item><description>One-time command: The command execution is complete and the exit code is non-zero.</description></item>
                        /// <item><description>Scheduled command: The last execution was successful with a non-zero exit code, and the specified schedule will be aborted.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description>Error: An exception occurred during command execution and the command cannot continue.</description></item>
                        /// <item><description>Timeout: The command execution timed out.</description></item>
                        /// <item><description>Cancelled: The command execution action was canceled and the command was never started.</description></item>
                        /// <item><description>Stopping: The task is being stopped.</description></item>
                        /// <item><description>Terminated: The command was terminated during execution.</description></item>
                        /// <item><description>Scheduled:<list type="bullet">
                        /// <item><description>One-time command: Not applicable. This status does not occur.</description></item>
                        /// <item><description>Scheduled command: Waiting to run.</description></item>
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
                        /// <para>The command output.</para>
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
                        /// <item><description>If the execution mode is scheduled execution, the value is the number of times the command has been executed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// <para>The start time. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when StopInvocation was called to stop the command execution. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the queried command will be automatically executed in the future. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The command was executed by calling RunCommand or InvokeCommand with the RepeatMode parameter set to Period, NextRebootOnly, or EveryReboot.</description></item>
                        /// <item><description>false (default): The queried command is in one of the following states:<list type="bullet">
                        /// <item><description>The command was executed by calling RunCommand or InvokeCommand with the RepeatMode parameter set to Once.</description></item>
                        /// <item><description>The command has been canceled, stopped, or has completed execution.</description></item>
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
                        /// <para>The update time. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
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
                /// <para>The overall execution status of the command. The overall execution status depends on the common execution status of one or more instances in the invocation. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>Running:<list type="bullet">
                /// <item><description>Scheduled execution: The execution status remains Running until you manually stop the scheduled command.</description></item>
                /// <item><description>One-time execution: The overall execution status is Running if the command process is running on any instance.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Finished:<list type="bullet">
                /// <item><description>Scheduled execution: The command process cannot have a status of Finished.</description></item>
                /// <item><description>One-time execution: All instances have completed execution, or the command process was manually stopped on some instances while the remaining instances completed execution.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed:<list type="bullet">
                /// <item><description>Scheduled execution: The command process cannot have a status of Failed.</description></item>
                /// <item><description>One-time execution: All instances failed to execute the command.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Stopped: The command was stopped.</description></item>
                /// <item><description>Stopping: The command is being stopped.</description></item>
                /// <item><description>PartialFailed: Partial failure. This value does not take effect if the InstanceId parameter is also specified.</description></item>
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
                /// <item><description>Once: Immediately executes the command.</description></item>
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
                /// <para>The timeout period for the command execution. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The username used to execute the command.</para>
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
