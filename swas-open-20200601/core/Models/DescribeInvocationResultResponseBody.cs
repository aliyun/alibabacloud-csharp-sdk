// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution results.</para>
        /// </summary>
        [NameInMap("InvocationResult")]
        [Validation(Required=false)]
        public DescribeInvocationResultResponseBodyInvocationResult InvocationResult { get; set; }
        public class DescribeInvocationResultResponseBodyInvocationResult : TeaModel {
            /// <summary>
            /// <para>The error code that is returned if the command failed to be sent or executed.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is empty, the command is executed normally.</description></item>
            /// <item><description>InstanceNotExists: The specified server does not exist or is released.</description></item>
            /// <item><description>InstanceReleased: The server was released while the command was being executed on the server.</description></item>
            /// <item><description>InstanceNotRunning: The server is not in the Running state while the command is being executed.</description></item>
            /// <item><description>CommandNotApplicable: The command is not applicable to the specified server.</description></item>
            /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
            /// <item><description>DirectoryNotExists: The specified directory does not exist.</description></item>
            /// <item><description>BadCronExpression: The specified cron expression for the execution schedule is invalid.</description></item>
            /// <item><description>ClientNotRunning: The Cloud Assistant client is not running.</description></item>
            /// <item><description>ClientNotResponse: The Cloud Assistant client does not respond.</description></item>
            /// <item><description>ClientIsUpgrading: The Cloud Assistant client is being upgraded.</description></item>
            /// <item><description>ClientNeedUpgrade: The Cloud Assistant client needs to be upgraded.</description></item>
            /// <item><description>DeliveryTimeout: Command sending times out.</description></item>
            /// <item><description>ExecutionTimeout: The execution times out.</description></item>
            /// <item><description>ExecutionException: An exception occurs while the command is being executed.</description></item>
            /// <item><description>ExecutionInterrupted: The execution is interrupted.</description></item>
            /// <item><description>ExitCodeNonzero: The execution is complete, but the exit code is not 0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceNotExists</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the command is not successfully sent or executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is empty, the command is executed normally.</description></item>
            /// <item><description>the specified instance does not exists: The specified server does not exist or is released.</description></item>
            /// <item><description>the instance has released when create task: The server was released while the command was being executed on the server.</description></item>
            /// <item><description>the instance is not running when create task: The server is not in the Running state while the command is being executed.</description></item>
            /// <item><description>the command is not applicable: The command is not applicable to the specified server.</description></item>
            /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
            /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
            /// <item><description>the cron job expression is invalid: The specified cron expression is invalid.</description></item>
            /// <item><description>the aliyun service is not running on the instance: The Cloud Assistance client is not running.</description></item>
            /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant client does not respond to your request.</description></item>
            /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant client is being upgraded.</description></item>
            /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant client needs to be upgraded.</description></item>
            /// <item><description>the command delivery has been timeout: Command sending times out.</description></item>
            /// <item><description>the command execution has been timeout: The execution times out.</description></item>
            /// <item><description>the command execution got an exception: An exception occurs while the command is being executed.</description></item>
            /// <item><description>the command execution has been interrupted: The execution is interrupted.</description></item>
            /// <item><description>the command execution exit code is not zero: The execution is complete, and the exit code is not 0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>the specified instance does not exists</para>
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// <para>The exit code of the command.</para>
            /// <list type="bullet">
            /// <item><description>For Linux instances, the exit code is the exit code of the shell command.</description></item>
            /// <item><description>For Windows instances, the exit code is the exit code of the batch or PowerShell command.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public long? ExitCode { get; set; }

            /// <summary>
            /// <para>The time when the execution ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11T06:37:17Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ace0706b2ac4454d984295a94213****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the execution progress. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The command is being verified or sent.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: The command fails to be sent to the server. To send a command to a server, make sure that the server is in the Running state and the command can be sent within 1 minute.</description></item>
            /// <item><description>Running: The command is being executed on the server.</description></item>
            /// <item><description>Success: The execution is completed, and the exit code is 0.</description></item>
            /// <item><description>Failed: The execution is completed, and the exit code is not 0.</description></item>
            /// <item><description>Error: The execution cannot proceed due to an exception.</description></item>
            /// <item><description>Timeout: The execution times out.</description></item>
            /// <item><description>Cancelled: The execution is canceled, and the command is not executed.</description></item>
            /// <item><description>Stopping: The command in the Running state is being stopped.</description></item>
            /// <item><description>Terminated: The command is terminated while it is being executed.</description></item>
            /// </list>
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
            /// <para>t-bj02prjje65****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// <para>The status of the execution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Finished</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Stopped</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            /// <summary>
            /// <para>The username who executes the command on the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("InvokeUser")]
            [Validation(Required=false)]
            public string InvokeUser { get; set; }

            /// <summary>
            /// <para>The command output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YWRtaW4K</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The time when the execution started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11T06:37:16Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
