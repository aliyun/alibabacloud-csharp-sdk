// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The command execution records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The Base64-encoded command content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The type of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunPowerShellScript</para>
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// <para>The time when the execution task is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-19T09:15:46Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User1</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The overall execution status of the command. The value of this parameter depends on the execution status of the command on all the involved cloud computers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The command is being verified or sent. If the execution status is Pending on at least one cloud computer, the overall status is considered Pending.</para>
            /// </description></item>
            /// <item><description><para>Running: The command is being executed on cloud computers. If the execution status is Running on at least one cloud computer, the overall status is considered Running.</para>
            /// </description></item>
            /// <item><description><para>Success: If the execution status is Success on at least one cloud computer and either Success or Stopped on all other cloud computers, the overall status is considered Success.</para>
            /// </description></item>
            /// <item><description><para>Failed: If the execution status is Stopped or Failed on all cloud computers, the overall status is considered Failed. If any execution status on cloud computers matches one of the following values, Failed is returned.</para>
            /// <list type="bullet">
            /// <item><description>Invalid: The command is invalid.</description></item>
            /// <item><description>Aborted: The command failed to be sent.</description></item>
            /// <item><description>Failed: The command is executed, but the exit code is not 0.</description></item>
            /// <item><description>Timeout: The command execution timed out.</description></item>
            /// <item><description>Error: An error occurred when the command is being executed.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Stopping: The command execution is being stopped. If the execution status is Stopping on at least one cloud computer, the overall status is considered Stopping.</para>
            /// </description></item>
            /// <item><description><para>Stopped: The command execution stops. If the execution status is Stopped on at least one cloud computer, the overall status is considered Stopped. If any execution status on cloud computers matches one of the following values, Stopped is returned.</para>
            /// <list type="bullet">
            /// <item><description>Cancelled: The command execution is canceled.</description></item>
            /// <item><description>Terminated: The command execution is terminated.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>PartialFailed: The command execution succeeded on some cloud computers but failed on others. If the execution status on any cloud computer is Success, Failed, or Stopped, the overall status is considered PartialFailed.</para>
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
            /// <para>The total number of cloud computers on which the command is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvokeDesktopCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopCount { get; set; }

            /// <summary>
            /// <para>The total number of cloud computers on which the command execution succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvokeDesktopSucceedCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopSucceedCount { get; set; }

            /// <summary>
            /// <para>The cloud computers on which the command is executed.</para>
            /// </summary>
            [NameInMap("InvokeDesktops")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeDesktops : TeaModel {
                /// <summary>
                /// <para>The time when the command execution was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:54Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The cloud computer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-7w78ozhjcwa3u****</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The cloud computer name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo1234</para>
                /// </summary>
                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

                /// <summary>
                /// <para>The size of the text that is truncated and discarded when the Output value exceeds 24 KB in size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dropped")]
                [Validation(Required=false)]
                public int? Dropped { get; set; }

                /// <summary>
                /// <para>The code explaining why the command failed to be sent or executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Null: The command is executed successfully.</description></item>
                /// <item><description>InstanceNotExists: The specified cloud computer does not exist or is released.</description></item>
                /// <item><description>InstanceReleased: The cloud computer is released during the execution.</description></item>
                /// <item><description>InstanceNotRunning: The cloud computer is not running during the execution.</description></item>
                /// <item><description>CommandNotApplicable: The command cannot be executed on the specified cloud computer.</description></item>
                /// <item><description>ClientNotRunning: The Cloud Assistant agent is not running.</description></item>
                /// <item><description>ClientNotResponse: The Cloud Assistant agent does not respond.</description></item>
                /// <item><description>ClientIsUpgrading: The Cloud Assistant agent is being updated.</description></item>
                /// <item><description>ClientNeedUpgrade: The Cloud Assistant agent needs to be updated.</description></item>
                /// <item><description>DeliveryTimeout: The command sending times out.</description></item>
                /// <item><description>ExecutionTimeout: The command execution times out.</description></item>
                /// <item><description>ExecutionException: An exception occurs when the command is being executed.</description></item>
                /// <item><description>ExecutionInterrupted: The command execution is interrupted.</description></item>
                /// <item><description>ExitCodeNonzero: The command execution completes, but the exit code is not 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceNotExists</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The message explaining why the command failed to be sent or executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Null: The command is executed successfully.</description></item>
                /// <item><description>the specified instance does not exists: The specified cloud computer does not exist or is released.</description></item>
                /// <item><description>the instance has released when create task: The cloud computer is released during the execution.</description></item>
                /// <item><description>the instance is not running when create task: The cloud computer is not running during the execution.</description></item>
                /// <item><description>the command is not applicable: The command cannot be executed on the specified cloud computer.</description></item>
                /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant agent is not running.</description></item>
                /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant agent does not respond.</description></item>
                /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant agent is being updated.</description></item>
                /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant agent needs to be updated.</description></item>
                /// <item><description>the command delivery has been timeout: The command sending times out.</description></item>
                /// <item><description>the command execution has been timeout: The command execution times out.</description></item>
                /// <item><description>the command execution got an exception: An exception occurs when the command is being executed.</description></item>
                /// <item><description>the command execution has been interrupted: The command execution is interrupted.</description></item>
                /// <item><description>the command execution exit code is not zero: The command execution completes, but the exit code is not 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>The specified instance does not exist.</para>
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                /// <summary>
                /// <para>The exit code of the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                /// <summary>
                /// <para>The time when the command execution ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:56Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The execution progress of the command on a single cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The command output.</para>
                /// <list type="bullet">
                /// <item><description>When the <c>IncludeOutput</c> parameter is set to false, the output is not returned.</description></item>
                /// <item><description>When the <c>ContentEncoding</c> parameter is set to Base64, the output is returned as a Base64-encoded string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OutPutTestmsg</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// <para>The number of times the command has been executed on the cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                /// <summary>
                /// <para>The start time of the command execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:55Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The stop time of the command execution (StopInvocatio).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-25T09:15:47Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The time when the execution status was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-25T06:15:56Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-hz0jdfwd9f****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

        }

        /// <summary>
        /// <para>The query token that is returned from this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
