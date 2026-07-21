// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of script execution records.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The script content, transmitted in Base64 encoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The script type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunPowerShellScript</para>
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// <para>The creation time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-19T09:15:46Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DesktopScenario")]
            [Validation(Required=false)]
            public string DesktopScenario { get; set; }

            /// <summary>
            /// <para>The end user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User1</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The overall execution status of the script. The overall execution status depends on the combined execution status of all cloud desktops in this call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The system is validating or sending the command. If the script execution status on at least one cloud desktop is Pending, the overall execution status is Pending.</description></item>
            /// <item><description>Running: The command is running on the cloud desktop. If the script execution status on at least one cloud desktop is Running, the overall execution status is Running.</description></item>
            /// <item><description>Success: The script execution status on each cloud desktop is Stopped or Success, and the script execution status on at least one cloud desktop is Success. The overall execution status is Success.</description></item>
            /// <item><description>Failed: The script execution status on each cloud desktop is Stopped or Failed. The overall execution status is Failed. The return value is Failed when one or more of the following statuses occur on a cloud desktop:<list type="bullet">
            /// <item><description>Command validation failed (Invalid).</description></item>
            /// <item><description>Command delivery failed (Aborted).</description></item>
            /// <item><description>Command execution completed but the exit code is non-zero (Failed).</description></item>
            /// <item><description>Command execution timed out (Timeout).</description></item>
            /// <item><description>Command execution encountered an exception (Error).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Stopping: The task is being stopped. If the script execution status on at least one instance is Stopping, the overall execution status is Stopping.</description></item>
            /// <item><description>Stopped: The task has been stopped. If the script execution status on all instances is Stopped, the overall execution status is Stopped. The return value is Stopped when the script execution status on an instance is one of the following:<list type="bullet">
            /// <item><description>Task cancelled (Cancelled).</description></item>
            /// <item><description>Task terminated (Terminated).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>PartialFailed: Some instances succeeded and some instances failed. If the script execution status on each instance is Success, Failed, or Stopped, the overall execution status is PartialFailed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// <para>The total number of cloud desktops on which the script was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvokeDesktopCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopCount { get; set; }

            /// <summary>
            /// <para>The total number of cloud desktops on which the script was run successfully.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvokeDesktopSucceedCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopSucceedCount { get; set; }

            /// <summary>
            /// <para>The list of target cloud desktops for execution.</para>
            /// </summary>
            [NameInMap("InvokeDesktops")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvokeDesktops> InvokeDesktops { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvokeDesktops : TeaModel {
                /// <summary>
                /// <para>The creation time of the script process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:54Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The cloud desktop ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-7w78ozhjcwa3u****</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The cloud desktop name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo1234</para>
                /// </summary>
                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

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
                /// <para>The error code for the command delivery failure or execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Empty: The command ran normally.</description></item>
                /// <item><description>InstanceNotExists: The specified cloud desktop does not exist or has been released.</description></item>
                /// <item><description>InstanceReleased: The cloud desktop was released during task execution.</description></item>
                /// <item><description>InstanceNotRunning: The cloud desktop was not running when the task was created.</description></item>
                /// <item><description>CommandNotApplicable: The command is not applicable to the specified cloud desktop.</description></item>
                /// <item><description>ClientNotRunning: The Cloud Assistant client is not running.</description></item>
                /// <item><description>ClientNotResponse: The Cloud Assistant client is not responding.</description></item>
                /// <item><description>ClientIsUpgrading: The Cloud Assistant client is being upgraded.</description></item>
                /// <item><description>ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.</description></item>
                /// <item><description>DeliveryTimeout: Command delivery timed out.</description></item>
                /// <item><description>ExecutionTimeout: Command execution timed out.</description></item>
                /// <item><description>ExecutionException: An exception occurred during command execution.</description></item>
                /// <item><description>ExecutionInterrupted: Command execution was interrupted.</description></item>
                /// <item><description>ExitCodeNonzero: Command execution completed with a non-zero exit code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceNotExists</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The detailed information about the command delivery failure or execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Empty: The command ran normally.</description></item>
                /// <item><description>the specified instance does not exists: The specified cloud desktop does not exist or has been released.</description></item>
                /// <item><description>the instance has released when create task: The cloud desktop was released during task execution.</description></item>
                /// <item><description>the instance is not running when create task: The cloud desktop was not running when the task was created.</description></item>
                /// <item><description>the command is not applicable: The command is not applicable to the specified cloud desktop.</description></item>
                /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant client is not running.</description></item>
                /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant client is not responding.</description></item>
                /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.</description></item>
                /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.</description></item>
                /// <item><description>the command delivery has been timeout: Command delivery timed out.</description></item>
                /// <item><description>the command execution has been timeout: Command execution timed out.</description></item>
                /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
                /// <item><description>the command execution has been interrupted: Command execution was interrupted.</description></item>
                /// <item><description>the command execution exit code is not zero: Command execution completed with a non-zero exit code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>The specified instance does not exist.</para>
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public string ErrorInfo { get; set; }

                /// <summary>
                /// <para>The exit code of the script process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                /// <summary>
                /// <para>The end time of the script process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:56Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The script execution status on a single cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("JvsAgentId")]
                [Validation(Required=false)]
                public string JvsAgentId { get; set; }

                /// <summary>
                /// <para>The output of the script process.</para>
                /// <list type="bullet">
                /// <item><description>If the request parameter <c>IncludeOutput</c> is set to false, Output is not returned.</description></item>
                /// <item><description>If the request parameter <c>ContentEncoding</c> is set to Base64, Output is the Base64-encoded output.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OutPutTestmsg</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// <para>The number of times the command was run on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                /// <summary>
                /// <para>The time when the script process started running on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:55Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The time when execution was stopped, if StopInvocation was called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-25T09:15:47Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The update time of the task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-25T06:15:56Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-hz0jdfwd9f****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
