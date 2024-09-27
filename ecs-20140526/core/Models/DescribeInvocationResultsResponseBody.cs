// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the execution results.</para>
        /// </summary>
        [NameInMap("Invocation")]
        [Validation(Required=false)]
        public DescribeInvocationResultsResponseBodyInvocation Invocation { get; set; }
        public class DescribeInvocationResultsResponseBodyInvocation : TeaModel {
            /// <summary>
            /// <para>The execution results.</para>
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
                    /// <para>The command ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c-hz0jdfwcsr****</para>
                    /// </summary>
                    [NameInMap("CommandId")]
                    [Validation(Required=false)]
                    public string CommandId { get; set; }

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
                    /// <para>The size of the Output text that was truncated and discarded because the <c>Output</c> value exceeded 24 KB in size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Dropped")]
                    [Validation(Required=false)]
                    public int? Dropped { get; set; }

                    /// <summary>
                    /// <para>The error code returned when the command failed to be sent or run. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>If this parameter is empty, the command was run as expected.</description></item>
                    /// <item><description>InstanceNotExists: The specified instance did not exist or was released.</description></item>
                    /// <item><description>InstanceReleased: The instance was released while the command was being run.</description></item>
                    /// <item><description>InstanceNotRunning: The instance was not running while the command was being run.</description></item>
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
                    /// <item><description>ExecutionException: An exception occurred while the command was being run.</description></item>
                    /// <item><description>ExecutionInterrupted: The execution was interrupted.</description></item>
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
                    /// <para>The exit code of the command task.</para>
                    /// <list type="bullet">
                    /// <item><description>For Linux instances, the value is the exit code of the shell command.</description></item>
                    /// <item><description>For Windows instances, the value is the exit code of the batch or PowerShell command.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExitCode")]
                    [Validation(Required=false)]
                    public long? ExitCode { get; set; }

                    /// <summary>
                    /// <para>The time when the command task was completed. If the command task times out, the end time is equal to the start time of the command task specified by <c>StartTime</c> plus the timeout period specified by <c>Timeout</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-12-20T06:15:56Z</para>
                    /// </summary>
                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

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
                    /// <item><description>Scheduled task: The last execution was complete, but the exit code was not 0. The specified period was about to end.</description></item>
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
                    /// <para>The command task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t-hz0jdfwd9f****</para>
                    /// </summary>
                    [NameInMap("InvokeId")]
                    [Validation(Required=false)]
                    public string InvokeId { get; set; }

                    /// <summary>
                    /// <para>The execution status of the command. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Running:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduled task: Before you stop the scheduled execution of the command, the execution state is always Running.</description></item>
                    /// <item><description>One-time task: If the command is being run on instances, the execution state is Running.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>Finished:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduled task: The execution state can never be Finished.</description></item>
                    /// <item><description>One-time task: The execution was complete on all instances, or the execution was stopped on some instances and was complete on the other instances.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>Failed:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduled task: The execution state can never be Failed.</description></item>
                    /// <item><description>One-time task: The execution failed on all instances.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>PartialFailed:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduled task: The execution state can never be PartialFailed.</description></item>
                    /// <item><description>One-time task: The execution failed on some instances.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>Stopped: The task was stopped.</para>
                    /// </description></item>
                    /// <item><description><para>Stopping: The task is being stopped.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("InvokeRecordStatus")]
                    [Validation(Required=false)]
                    public string InvokeRecordStatus { get; set; }

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
                    /// <para>The command output.</para>
                    /// <list type="bullet">
                    /// <item><description>If ContentEncoding is set to PlainText in the request, the original command output is returned.</description></item>
                    /// <item><description>If ContentEncoding is set to Base64 in the request, the Base64-encoded command output is returned.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MTU6MzA6MDEK</para>
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
                    /// <para>The tags of the command task.</para>
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
                    /// <para>The username used to run the command on the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root</para>
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
