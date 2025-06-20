// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The command execution record.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The file sending records.</para>
            /// </summary>
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The executed command.</para>
                /// <list type="bullet">
                /// <item><description>If ContentEncoding is set to PlainText in the request, the original command content is returned.</description></item>
                /// <item><description>If ContentEncoding is set to Base64 in the request, the Base64-encoded command content is returned.</description></item>
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
                /// <para>The time when the command task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The schedule on which the command was run.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution state of the command task. The value of this parameter depends on the execution states of the command task on all the involved instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The command was being verified or sent. If the execution state on at least one instance is Pending, the overall execution state is Pending.</para>
                /// </description></item>
                /// <item><description><para>Scheduled: The command that is set to run on a schedule is sent and waiting to be run. If the execution state on at least one instance is Scheduled, the overall execution state is Scheduled.</para>
                /// </description></item>
                /// <item><description><para>Running: The command is being run on the instance. When the execution state on at least one instance is Running, the overall execution state is Running.</para>
                /// </description></item>
                /// <item><description><para>Success: When the execution state on at least one instance is Success and the execution state on the other instances is Stopped or Success, the overall execution state is Success.</para>
                /// <list type="bullet">
                /// <item><description>One-time task: The execution is complete, and the exit code is 0.</description></item>
                /// <item><description>Scheduled task: The last execution was complete, the exit code was 0, and the specified period ended.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Failed: When the execution state on all instances is Stopped or Failed, the overall execution state is Failed. When the execution state on an instance is one of the following values, Failed is returned as the overall execution state:</para>
                /// <list type="bullet">
                /// <item><description>Invalid: The command is invalid.</description></item>
                /// <item><description>Aborted: The command failed to be sent.</description></item>
                /// <item><description>Failed: The execution was complete, but the exit code was not 0.</description></item>
                /// <item><description>Timeout: The execution timed out.</description></item>
                /// <item><description>Error: An error occurred while the command was being run.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Stopping: The command task is being stopped. When the execution state on at least one instance is Stopping, the overall execution state is Stopping.</para>
                /// </description></item>
                /// <item><description><para>Stopped: The task was stopped. When the execution state on all instances is Stopped, the overall execution state is Stopped. When the execution state on an instance is one of the following values, Stopped is returned as the overall execution state:</para>
                /// <list type="bullet">
                /// <item><description>Cancelled: The task was canceled.</description></item>
                /// <item><description>Terminated: The task was terminated.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>PartialFailed: The execution was complete on some instances and failed on other instances. When the execution state is Success on some instances and is Failed or Stopped on the other instances, the overall execution state is PartialFailed.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para> The value of the <c>InvokeStatus</c> response parameter is similar to the value of InvocationStatus. We recommend that you ignore InvokeStatus and check the value of InvocationStatus.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The execution ID.</para>
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
                        /// <para>The start time of the execution.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <para>The size of the Output text that was truncated and discarded because the Output value exceeded 24 KB in size.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// <para>The error code returned when the file failed to be sent to the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Null: The file is sent to the instance.</description></item>
                        /// <item><description>NodeNotExists: The specified instance does not exist or has been released.</description></item>
                        /// <item><description>NodeReleased: The instance was released while the file was being sent.</description></item>
                        /// <item><description>NodeNotRunning: The instance was not running while the file sending task was being created.</description></item>
                        /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                        /// <item><description>ClientNotRunning: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>ClientNotResponse: Cloud Assistant Agent does not respond.</description></item>
                        /// <item><description>ClientIsUpgrading: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: The file sending task timed out.</description></item>
                        /// <item><description>FileCreateFail: The file failed to be created.</description></item>
                        /// <item><description>FileAlreadyExists: A file with the same name exists in the specified directory.</description></item>
                        /// <item><description>FileContentInvalid: The file content is invalid.</description></item>
                        /// <item><description>FileNameInvalid: The file name is invalid.</description></item>
                        /// <item><description>FilePathInvalid: The specified directory is invalid.</description></item>
                        /// <item><description>FileAuthorityInvalid: The specified permissions on the file are invalid.</description></item>
                        /// <item><description>UserGroupNotExists: The specified user group does not exist.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NodeNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message returned when the command cannot be sent or run.</para>
                        /// <list type="bullet">
                        /// <item><description>If this parameter is empty, the command was run as expected.</description></item>
                        /// <item><description>the specified node does not exists: The specified instance does not exist or is released.</description></item>
                        /// <item><description>the node has node when create task: The instance is released when the command is being run.</description></item>
                        /// <item><description>the node is not running when create task: The instance is not in the Running state while the command is being run.</description></item>
                        /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                        /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                        /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                        /// <item><description>the cron job expression is invalid: The cron expression that specifies the execution time is invalid.</description></item>
                        /// <item><description>the aliyun service is not running on the instance: Cloud Assistant Agent is not running.</description></item>
                        /// <item><description>the aliyun service in the instance does not response: Cloud Assistant Agent does not respond.</description></item>
                        /// <item><description>the aliyun service in the node is upgrading now: Cloud Assistant Agent is being upgraded.</description></item>
                        /// <item><description>the aliyun service in the node need upgrade: Cloud Assistant Agent needs to be upgraded.</description></item>
                        /// <item><description>the command delivery has been timeout: The request to send the command timed out.</description></item>
                        /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
                        /// <item><description>the command execution got an exception: An exception occurred when the command is being run.</description></item>
                        /// <item><description>the command execution has been interrupted: The command execution is interrupted.</description></item>
                        /// <item><description>the command execution exit code is not zero: The command execution completes, but the exit code is not 0.</description></item>
                        /// <item><description>the specified node has been released: The instance is released while the file is being sent.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified node does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <para>The exit code of the execution. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>For Linux instances, the value is the exit code of the shell process.</description></item>
                        /// <item><description>For Windows instances, the value is the exit code of the batch or PowerShell process.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <para>The end time of the execution.</para>
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
                        /// <item><description><para>Pending: The command was being verified or sent.</para>
                        /// </description></item>
                        /// <item><description><para>Invalid: The specified command type or parameter is invalid.</para>
                        /// </description></item>
                        /// <item><description><para>Aborted: The command failed to be sent to the instance. To send a command to an instance, make sure that the instance is in the Running state and the command can be sent to the instance within 1 minute.</para>
                        /// </description></item>
                        /// <item><description><para>Running: The command is being run on the instance.</para>
                        /// </description></item>
                        /// <item><description><para>Success:</para>
                        /// <list type="bullet">
                        /// <item><description>One-time task: The execution was complete, and the exit code was 0.</description></item>
                        /// <item><description>Recurring execution: The previous occurrence of the execution is complete, and the exit code is 0. The specified recurring period during which the command is run ends.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description><para>Failed:</para>
                        /// <list type="bullet">
                        /// <item><description>One-time task: The execution was complete, but the exit code was not 0.</description></item>
                        /// <item><description>Recurring execution: The previous occurrence of the execution is complete, but the exit code is not 0. The specified recurring period during which the command is run is about to end.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description><para>Error: The execution cannot proceed due to an exception.</para>
                        /// </description></item>
                        /// <item><description><para>Timeout: The execution timed out.</para>
                        /// </description></item>
                        /// <item><description><para>Cancelled: The execution was canceled before it started.</para>
                        /// </description></item>
                        /// <item><description><para>Stopping: The command task is being stopped.</para>
                        /// </description></item>
                        /// <item><description><para>Terminated: The execution was terminated before completion.</para>
                        /// </description></item>
                        /// <item><description><para>Scheduled:</para>
                        /// <list type="bullet">
                        /// <item><description>One-time task: The execution state can never be Scheduled.</description></item>
                        /// <item><description>Recurring execution: The command is waiting to be run.</description></item>
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
                        /// <para>The execution status of the command on a single instance.</para>
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
                        /// <item><description>If ContentEncoding is set to PlainText in the request, the original command output is returned.</description></item>
                        /// <item><description>If ContentEncoding is set to Base64 in the request, the Base64-encoded command output is returned.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OutPutTestmsg</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The number of times that the command was run on the instance.</para>
                        /// <list type="bullet">
                        /// <item><description>If the command is set to run only once, the value is 0 or 1.</description></item>
                        /// <item><description>If the command is set to run on a schedule, the value is the number of times that the command has been run on the instance.</description></item>
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
                        /// <para>The time when the command task was stopped. If you call the StopInvocation operation to stop the command task, the value of this parameter is the time when the operation is called.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the command is to be automatically run. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>true: The command is run by calling the <c>RunCommand</c> or <c>InvokeCommand</c> operation with <c>RepeatMode</c> set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c>.</para>
                        /// </description></item>
                        /// <item><description><para>false (default): The command meets the following requirements.</para>
                        /// <list type="bullet">
                        /// <item><description>The command is run by calling the <c>RunCommand</c> or <c>InvokeCommand</c> operation with <c>RepeatMode</c> set to <c>Once</c>.</description></item>
                        /// <item><description>The command task is canceled, stopped, or completed.</description></item>
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
                        /// <para>The update time of the execution.</para>
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
                /// <para>The overall execution status of the command task. The value of this parameter depends on the execution states of the command task on all involved instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Running:</para>
                /// <list type="bullet">
                /// <item><description>Scheduled task: Before you stop the scheduled execution of the command, the overall execution state is always Running.</description></item>
                /// <item><description>One-time task: If the command is being run on instances, the overall execution state is Running.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Finished:</para>
                /// <list type="bullet">
                /// <item><description>Scheduled task: The overall execution state can never be Finished.</description></item>
                /// <item><description>One-time task: The execution is complete on all instances, or the execution is stopped on some instances and is complete on the other instances.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Failed:</para>
                /// <list type="bullet">
                /// <item><description>Scheduled task: The overall execution state can never be Failed.</description></item>
                /// <item><description>One-time task: The execution failed on all instances.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Stopped: The task is stopped.</para>
                /// </description></item>
                /// <item><description><para>Stopping: The task is being stopped.</para>
                /// </description></item>
                /// <item><description><para>PartialFailed: The task fails on some instances. If you specify both this parameter and <c>InstanceId</c>, this parameter does not take effect.</para>
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
                /// <item><description>Once: The command is run immediately.</description></item>
                /// <item><description>Period: The command is run on a schedule.</description></item>
                /// <item><description>NextRebootOnly: The command is run the next time the instances start.</description></item>
                /// <item><description>EveryReboot: runs the command every time the instances start.</description></item>
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
                /// <para>The username that is used to run the command.</para>
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
