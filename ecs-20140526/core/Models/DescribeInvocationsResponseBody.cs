// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the command executions.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <para>The command content.</para>
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
                /// <para>The command ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-hz0jdfwcsr****</para>
                /// </summary>
                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

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
                /// <para>The command type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RunShellScript</para>
                /// </summary>
                [NameInMap("CommandType")]
                [Validation(Required=false)]
                public string CommandType { get; set; }

                /// <summary>
                /// <para>The container ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ab141ddfbacfe02d9dbc25966ed971536124527097398d419a6746873fea****</para>
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                /// <summary>
                /// <para>The container name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-container</para>
                /// </summary>
                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

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
                /// <para>The schedule on which the command is run.</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The overall execution status of the command task. The value of this parameter depends on the execution status of the command task on all the involved instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The command is being verified or sent. When the execution state on at least one instance is Pending, the overall execution state is Pending.</para>
                /// </description></item>
                /// <item><description><para>Scheduled: The command that is set to run on a schedule was sent and waiting to be run. When the execution state on at least one instance is Scheduled, the overall execution state is Scheduled.</para>
                /// </description></item>
                /// <item><description><para>Running: The command is being run on the instances. When the execution state on at least one instance is Running, the overall execution state is Running.</para>
                /// </description></item>
                /// <item><description><para>Success: When the execution state on at least one instance is Success and the execution state on the other instances is Stopped or Success, the overall execution state is Success.</para>
                /// <list type="bullet">
                /// <item><description>One-time task: The execution was complete, and the exit code was 0.</description></item>
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
                /// <para> <c>InvokeStatus</c> in the response functions similarly to this parameter. We recommend that you check the value of this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The command task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-hz0jdfwd9f****</para>
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                /// <summary>
                /// <para>The instances on which the command was run.</para>
                /// </summary>
                [NameInMap("InvokeInstances")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances InvokeInstances { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstances : TeaModel {
                    [NameInMap("InvokeInstance")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeInstancesInvokeInstance : TeaModel {
                        /// <summary>
                        /// <para>The time when the command task was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:54Z</para>
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
                        /// <para>The error code for the failure to send or run the command. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>If this parameter is empty, the command was run as expected.</description></item>
                        /// <item><description>InstanceNotExists: The specified instance did not exist or was released.</description></item>
                        /// <item><description>InstanceReleased: The instance was released while the command was being run.</description></item>
                        /// <item><description>InstanceNotRunning: The instance was not running when the command started to be run.</description></item>
                        /// <item><description>CommandNotApplicable: The command was inapplicable to the specified instance.</description></item>
                        /// <item><description>AccountNotExists: The username specified to run the command did not exist.</description></item>
                        /// <item><description>DirectoryNotExists: The specified directory did not exist.</description></item>
                        /// <item><description>BadCronExpression: The specified cron expression for the execution schedule was invalid.</description></item>
                        /// <item><description>ClientNotRunning: Cloud Assistant Agent was not running.</description></item>
                        /// <item><description>ClientNotResponse: Cloud Assistant Agent did not respond.</description></item>
                        /// <item><description>ClientIsUpgrading: Cloud Assistant Agent was being upgraded.</description></item>
                        /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needed to be upgraded.</description></item>
                        /// <item><description>DeliveryTimeout: The request to send the command timed out.</description></item>
                        /// <item><description>ExecutionTimeout: The execution timed out.</description></item>
                        /// <item><description>ExecutionException: An exception occurred while the command was being executed.</description></item>
                        /// <item><description>ExecutionInterrupted: The command task was interrupted.</description></item>
                        /// <item><description>ExitCodeNonzero: The execution was complete, but the exit code was not 0.</description></item>
                        /// <item><description>SecurityGroupRuleDenied: Access to Cloud Assistant was denied by security group rules.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InstanceNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <para>The error message returned when the command failed to be sent or run. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>If this parameter is empty, the command was run as expected.</description></item>
                        /// <item><description>The security group rules denied access to the aliyun service.</description></item>
                        /// <item><description>The specified instance does not exist.</description></item>
                        /// <item><description>The specified instance was released during task execution.</description></item>
                        /// <item><description>The specified instance was not running during task execution.</description></item>
                        /// <item><description>The OS type of the instance does not support the specified command type.</description></item>
                        /// <item><description>The specified account does not exist.</description></item>
                        /// <item><description>The specified directory does not exist.</description></item>
                        /// <item><description>The cron expression is invalid.</description></item>
                        /// <item><description>The aliyun service is not running on the instance.</description></item>
                        /// <item><description>The aliyun service in the instance does not response.</description></item>
                        /// <item><description>The aliyun service in the instance is upgrading during task execution.</description></item>
                        /// <item><description>The aliyun service in the instance need to be upgraded to at least version to support the feature. indicates the earliest version that supports the feature. indicates the name of the feature.</description></item>
                        /// <item><description>The command delivery has been timeout.</description></item>
                        /// <item><description>The command execution has been timeout.</description></item>
                        /// <item><description>The command execution got an exception.</description></item>
                        /// <item><description>The command execution exit code is not zero.</description></item>
                        /// <item><description>The specified instance was released during task execution.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>the specified instance does not exists</para>
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
                        public long? ExitCode { get; set; }

                        /// <summary>
                        /// <para>The time when the command process ended.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:56Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp1i7gg30r52z2em****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The execution status of the command on a single instance.</para>
                        /// <remarks>
                        /// <para> We recommend that you ignore this parameter and check the value of <c>InvocationStatus</c> in the response to obtain the execution status.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("InstanceInvokeStatus")]
                        [Validation(Required=false)]
                        public string InstanceInvokeStatus { get; set; }

                        /// <summary>
                        /// <para>The execution status on a single instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Pending: The command is being verified or sent.</para>
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
                        /// <item><description>Scheduled task: The last execution was complete, the exit code was 0, and the specified period ended.</description></item>
                        /// </list>
                        /// </description></item>
                        /// <item><description><para>Failed:</para>
                        /// <list type="bullet">
                        /// <item><description>One-time task: The execution was complete, but the exit code was not 0.</description></item>
                        /// <item><description>Scheduled task: The last execution was complete, but the exit code was not 0. The specified period is about to end.</description></item>
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
                        /// <item><description>Scheduled task: The command is waiting to be run.</description></item>
                        /// </list>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Success</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <para>The output delivery status of the command execution. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>InProgress: The delivery is in progress.</description></item>
                        /// <item><description>Finished: The delivery is complete.</description></item>
                        /// <item><description>Failed: The delivery failed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("OssOutputStatus")]
                        [Validation(Required=false)]
                        public string OssOutputStatus { get; set; }

                        /// <summary>
                        /// <para>The command execution Output delivers the object URI to OSS. This field is an empty string when the delivery fails or is in progress.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss://testBucket/testPrefix/output.txt</para>
                        /// </summary>
                        [NameInMap("OssOutputUri")]
                        [Validation(Required=false)]
                        public string OssOutputUri { get; set; }

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
                        /// <para>The time when the command started to be run on the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time when the command task was stopped. If you call the <c>StopInvocation</c> operation to stop the command task, the value of this parameter is the time when the operation is called.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-19T09:15:47Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the command is to be automatically run.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public bool? Timed { get; set; }

                        /// <summary>
                        /// <para>The time when the execution status was updated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-19T09:15:47Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The overall execution status of the command task.</para>
                /// <remarks>
                /// <para> We recommend that you ignore this parameter and check the value of <c>InvocationStatus</c> in the response to obtain the execution status.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// <para>The launcher for script execution. The value cannot exceed 1 KB in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>python3 -u {{ACS::ScriptFileName|Ext(&quot;.py&quot;)}}</para>
                /// </summary>
                [NameInMap("Launcher")]
                [Validation(Required=false)]
                public string Launcher { get; set; }

                /// <summary>
                /// <para>Command to execute the Output OSS delivery configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://testBucket/testPrefix</para>
                /// </summary>
                [NameInMap("OssOutputDelivery")]
                [Validation(Required=false)]
                public string OssOutputDelivery { get; set; }

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
                /// <item><description>Once: The command is immediately run.</description></item>
                /// <item><description>Period: The command is run on a schedule.</description></item>
                /// <item><description>NextRebootOnly: The command is run the next time the instances start.</description></item>
                /// <item><description>EveryReboot: The command is run every time the instances start.</description></item>
                /// <item><description>DryRun: The system performs only a dry run, without running the actual command. The system checks the request parameters, the execution environments on the instances, and the status of Cloud Assistant Agent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// <para>The tags of the command task.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationTags Tags { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationTagsTag> Tag { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the command task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>owner</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the command task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>zhangsan</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates how the command task is stopped when a command execution is manually stopped or times out. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Process: The process of the command is stopped.</description></item>
                /// <item><description>ProcessTree: The process tree of the command is stopped. In this case, the process of the command and all subprocesses are stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessTree</para>
                /// </summary>
                [NameInMap("TerminationMode")]
                [Validation(Required=false)]
                public string TerminationMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the command is to be automatically run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Timed")]
                [Validation(Required=false)]
                public bool? Timed { get; set; }

                /// <summary>
                /// <para>The maximum timeout period for the command execution. Unit: seconds.</para>
                /// <para>When a command cannot be run, the command execution times out. When a command execution times out, Cloud Assistant Agent forcefully terminates the command process by canceling the process ID (PID) of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// <para>The username used to run the command on the instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The execution path of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/home/</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
