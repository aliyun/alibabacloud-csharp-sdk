// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about execution records of the command.</para>
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
            /// <para>The overall execution status of the command. The overall execution status is determined by the execution status on all involved cloud desktops. The valid values include:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The system is verifying or sending the command. If the execution status on at least one cloud desktop is Pending, the overall execution status is Pending.</para>
            /// </description></item>
            /// <item><description><para>Running: The execution is in progress on cloud desktops. If the execution status on at least one cloud desktop is Running, the overall execution status is Running.</para>
            /// </description></item>
            /// <item><description><para>Success: If the execution status on all cloud desktops is Success or Stopped, or the execution status on at least one cloud desktop is Success, the overall execution status is Success.</para>
            /// </description></item>
            /// <item><description><para>Failed: If the execution status on all cloud desktops is Stopped or Failed, the overall execution status is Failed. If one or more execution status of a cloud desktop is one of the following values, Failed is returned:</para>
            /// <list type="bullet">
            /// <item><description>Invalid: The command is invalid.</description></item>
            /// <item><description>Aborted: The command fails to be sent.</description></item>
            /// <item><description>Failed: The command is executed, but the exit code is not 0.</description></item>
            /// <item><description>Timeout: The command times out.</description></item>
            /// <item><description>Error: An error occurs in the command.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Stopping: The execution is being stopped. If the execution status on at least one cloud desktop is Stopping, the overall execution state is Stopping.</para>
            /// </description></item>
            /// <item><description><para>Stopped: The execution is stopped. If the execution status on all cloud desktops is Stopped, the overall execution state is Stopped. If the execution status on a cloud desktop is one of the following values, Stopped is returned:</para>
            /// <list type="bullet">
            /// <item><description>Cancelled: The execution is canceled.</description></item>
            /// <item><description>Terminated: The execution is terminated.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>PartialFailed: The execution succeeded on some cloud desktops and failed on others. If the execution status on different cloud desktops is Success, Failed, or Stopped, the overall execution state is PartialFailed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeDesktopCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopCount { get; set; }

            [NameInMap("InvokeDesktopSucceedCount")]
            [Validation(Required=false)]
            public int? InvokeDesktopSucceedCount { get; set; }

            /// <summary>
            /// <para>The cloud desktops on which the command is executed.</para>
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
                /// <para>The ID of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecd-7w78ozhjcwa3u****</para>
                /// </summary>
                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>The name of the cloud desktop.</para>
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
                /// <para>The code that indicates the reason why a command failed to be sent or executed. The valid values include:</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is empty, the execution is normal.</description></item>
                /// <item><description>InstanceNotExists: The specified cloud desktop does not exist or is released.</description></item>
                /// <item><description>InstanceReleased: The cloud desktop is released during the execution.</description></item>
                /// <item><description>InstanceNotRunning: The cloud desktop is not running during the execution.</description></item>
                /// <item><description>CommandNotApplicable: The command cannot be used on the cloud desktop.</description></item>
                /// <item><description>ClientNotRunning: The Cloud Assistant client is not running.</description></item>
                /// <item><description>ClientNotResponse: The Cloud Assistant client does not respond.</description></item>
                /// <item><description>ClientIsUpgrading: The Cloud Assistant client is being upgraded.</description></item>
                /// <item><description>ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.</description></item>
                /// <item><description>DeliveryTimeout: The time to send the command in the request times out.</description></item>
                /// <item><description>ExecutionTimeout: The execution times out.</description></item>
                /// <item><description>ExecutionException: An exception occurs during the execution.</description></item>
                /// <item><description>ExecutionInterrupted: The execution is interrupted.</description></item>
                /// <item><description>ExitCodeNonzero: The execution finishes, but the exit code is not 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceNotExists</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Details about the reason why the command failed to be sent or executed. The valid values include:</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is empty, the execution is normal.</description></item>
                /// <item><description>the specified instance does not exists: The cloud desktop does not exist or is released.</description></item>
                /// <item><description>the instance has released when create task: The cloud desktop is released during execution.</description></item>
                /// <item><description>the instance is not running when create task: The cloud desktop is not running when the execution is being performed.</description></item>
                /// <item><description>the command is not applicable: The command cannot be used on the specified cloud desktop.</description></item>
                /// <item><description>the aliyun service is not running on the instance: The Cloud Assistance client is not running.</description></item>
                /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant client is not responding.</description></item>
                /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.</description></item>
                /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.</description></item>
                /// <item><description>the command delivery has been timeout: The command that is sent in the request times out.</description></item>
                /// <item><description>the command execution has been timeout: The execution times out.</description></item>
                /// <item><description>the command execution got an exception: An exception occurs when the command is running.</description></item>
                /// <item><description>the command execution has been interrupted: The execution is interrupted.</description></item>
                /// <item><description>the command execution exit code is not zero: The execution finishes, but the exit code is not 0.</description></item>
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
                /// <para>The execution status on the cloud desktop.</para>
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
                /// <item><description>If the IncludeOutput parameter is set to false, Output is not returned.</description></item>
                /// <item><description>If the ContentEncoding parameter is set to Base64, the value of Output is the output information that is encoded in Base64.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OutPutTestmsg</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// <para>The number of times that the command is executed on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Repeats")]
                [Validation(Required=false)]
                public int? Repeats { get; set; }

                /// <summary>
                /// <para>The start time of the execution on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T06:15:55Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The time when you called the <a href="~~196957#doc-api-ecd-StopInvocation~~" title="You can call this operation to stop a Cloud Assistant command that is running on one or cloud desktops.">StopInvocation</a> operation to manually stop the command.</para>
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
