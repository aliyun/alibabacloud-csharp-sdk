// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The command execution result.</para>
        /// </summary>
        [NameInMap("InvocationResult")]
        [Validation(Required=false)]
        public DescribeInvocationResultResponseBodyInvocationResult InvocationResult { get; set; }
        public class DescribeInvocationResultResponseBodyInvocationResult : TeaModel {
            /// <summary>
            /// <para>The error code for the reason why the command failed to be sent or run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Empty: The command was run normally.</description></item>
            /// <item><description>InstanceNotExists: The specified instance does not exist or has been released.</description></item>
            /// <item><description>InstanceReleased: The instance was released during command execution.</description></item>
            /// <item><description>InstanceNotRunning: The instance was not in the Running state when the command was run.</description></item>
            /// <item><description>CommandNotApplicable: The command is not applicable to the specified instance.</description></item>
            /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
            /// <item><description>DirectoryNotExists: The specified directory does not exist.</description></item>
            /// <item><description>BadCronExpression: The specified cron expression is invalid.</description></item>
            /// <item><description>ClientNotRunning: The Cloud Assistant Agent is not running.</description></item>
            /// <item><description>ClientNotResponse: The Cloud Assistant Agent is not responding.</description></item>
            /// <item><description>ClientIsUpgrading: The Cloud Assistant Agent is being upgraded.</description></item>
            /// <item><description>ClientNeedUpgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
            /// <item><description>DeliveryTimeout: The command sending timed out.</description></item>
            /// <item><description>ExecutionTimeout: The command execution timed out.</description></item>
            /// <item><description>ExecutionException: An exception occurred during command execution.</description></item>
            /// <item><description>ExecutionInterrupted: The command execution was interrupted.</description></item>
            /// <item><description>ExitCodeNonzero: The command finished running, and the exit code is not 0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceNotExists</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The details of the reason why the command failed to be sent or run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Empty: The command was run normally.</description></item>
            /// <item><description>the specified instance does not exists: The specified instance does not exist or has been released.</description></item>
            /// <item><description>the instance has released when create task: The instance was released during command execution.</description></item>
            /// <item><description>the instance is not running when create task: The instance was not in the Running state when the command was run.</description></item>
            /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
            /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
            /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
            /// <item><description>the cron job expression is invalid: The specified cron expression is invalid.</description></item>
            /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant Agent is not running.</description></item>
            /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant Agent is not responding.</description></item>
            /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant Agent is being upgraded.</description></item>
            /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
            /// <item><description>the command delivery has been timeout: The command sending timed out.</description></item>
            /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
            /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
            /// <item><description>the command execution has been interrupted: The command execution was interrupted.</description></item>
            /// <item><description>the command execution exit code is not zero: The command finished running, and the exit code is not 0.</description></item>
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
            /// <item><description>For Windows instances, the exit code is the exit code of the Bat or PowerShell command.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public long? ExitCode { get; set; }

            /// <summary>
            /// <para>The time when the command finished running on the instance. The time is displayed in UTC (Z) in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11T06:37:17Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ace0706b2ac4454d984295a94213****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The execution status of the command on the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The system is verifying or sending the command.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: Failed to send the command to the instance. The instance must be in the Running state, and the command must be sent within 1 minute.</description></item>
            /// <item><description>Running: The command is being run on the instance.</description></item>
            /// <item><description>Success: The command finished running, and the exit code is 0.</description></item>
            /// <item><description>Failed: The command finished running, and the exit code is not 0.</description></item>
            /// <item><description>Error: An exception occurred during command execution and the command cannot continue.</description></item>
            /// <item><description>Timeout: The command execution timed out.</description></item>
            /// <item><description>Cancelled: The command execution has been canceled, and the command was never started.</description></item>
            /// <item><description>Stopping: The running command is being stopped.</description></item>
            /// <item><description>Terminated: The command was terminated during execution.</description></item>
            /// </list>
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
            /// <para>t-bj02prjje65****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// <para>The command execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: Running.</description></item>
            /// <item><description>Finished: Finished.</description></item>
            /// <item><description>Failed: Failed.</description></item>
            /// <item><description>Stopped: Stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            /// <summary>
            /// <para>The username used to run the command on the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("InvokeUser")]
            [Validation(Required=false)]
            public string InvokeUser { get; set; }

            /// <summary>
            /// <para>The output of the command execution. The standard output (stdout) and standard error output (stderr) are merged into a single Output. The capacity is calculated separately for each execution and each instance. The maximum capacity of a single Output is 24 KB. Content that exceeds this limit is truncated and discarded. Even if the ExitCode is 0 or the execution status is Success, the output may still be truncated. The returned output is in UTF-8 plaintext and does not require Base64 decoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The time when the command started to be run on the instance. The time is displayed in UTC (Z) in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
