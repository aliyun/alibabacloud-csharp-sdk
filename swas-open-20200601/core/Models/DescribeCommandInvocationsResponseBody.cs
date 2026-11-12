// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of command executions.</para>
        /// </summary>
        [NameInMap("CommandInvocations")]
        [Validation(Required=false)]
        public List<DescribeCommandInvocationsResponseBodyCommandInvocations> CommandInvocations { get; set; }
        public class DescribeCommandInvocationsResponseBodyCommandInvocations : TeaModel {
            /// <summary>
            /// <para>The command content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo 123</para>
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
            /// <para>c-hy0338xh28r****</para>
            /// </summary>
            [NameInMap("CommandId")]
            [Validation(Required=false)]
            public string CommandId { get; set; }

            /// <summary>
            /// <para>The command name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCommandName</para>
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
            /// <para>The time when the command was created, in the format of YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-27T10:11:58</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The execution status of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The system is validating or sending the command.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: Failed to send the command to the instance. The instance must be running and the command must be delivered within 1 minute.</description></item>
            /// <item><description>Running: The command is running on the instance.</description></item>
            /// <item><description>Success: The command execution is complete and the exit code is 0.</description></item>
            /// <item><description>Failed: The command execution is complete and the exit code is not 0.</description></item>
            /// <item><description>Error: An exception occurred during command execution and the command cannot continue.</description></item>
            /// <item><description>Timeout: The command execution timed out.</description></item>
            /// <item><description>Cancelled: The command execution action has been canceled and the command was never started.</description></item>
            /// <item><description>Stopping: The command execution is being stopped.</description></item>
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
            /// <para>t-hz0373jyzxt****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// <para>The list of target instances for execution.</para>
            /// </summary>
            [NameInMap("InvokeInstances")]
            [Validation(Required=false)]
            public List<DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances> InvokeInstances { get; set; }
            public class DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances : TeaModel {
                /// <summary>
                /// <para>The error code for the command delivery failure or execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Empty: The command executed normally.</description></item>
                /// <item><description>InstanceNotExists: The specified instance does not exist or has been released.</description></item>
                /// <item><description>InstanceReleased: The instance was released during command execution.</description></item>
                /// <item><description>InstanceNotRunning: The instance was not running when the command was executed.</description></item>
                /// <item><description>CommandNotApplicable: The command is not applicable to the specified instance.</description></item>
                /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                /// <item><description>DirectoryNotExists: The specified directory does not exist.</description></item>
                /// <item><description>BadCronExpression: The specified cron expression is invalid.</description></item>
                /// <item><description>ClientNotRunning: The Cloud Assistant Agent is not running.</description></item>
                /// <item><description>ClientNotResponse: The Cloud Assistant Agent is not responding.</description></item>
                /// <item><description>ClientIsUpgrading: The Cloud Assistant Agent is being upgraded.</description></item>
                /// <item><description>ClientNeedUpgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
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
                /// <para>The details of the command delivery failure or execution failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Empty: The command executed normally.</description></item>
                /// <item><description>the specified instance does not exists: The specified instance does not exist or has been released.</description></item>
                /// <item><description>the instance has released when create task: The instance was released during command execution.</description></item>
                /// <item><description>the instance is not running when create task: The instance was not running when the command was executed.</description></item>
                /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                /// <item><description>the cron job expression is invalid: The specified cron expression is invalid.</description></item>
                /// <item><description>the aliyun service is not running on the instance: The Cloud Assistant Agent is not running.</description></item>
                /// <item><description>the aliyun service in the instance does not response: The Cloud Assistant Agent is not responding.</description></item>
                /// <item><description>the aliyun service in the instance is upgrading now: The Cloud Assistant Agent is being upgraded.</description></item>
                /// <item><description>the aliyun service in the instance need upgrade: The Cloud Assistant Agent needs to be upgraded.</description></item>
                /// <item><description>the command delivery has been timeout: Command delivery timed out.</description></item>
                /// <item><description>the command execution has been timeout: Command execution timed out.</description></item>
                /// <item><description>the command execution got an exception: An exception occurred during command execution.</description></item>
                /// <item><description>the command execution has been interrupted: Command execution was interrupted.</description></item>
                /// <item><description>the command execution exit code is not zero: Command execution completed with a non-zero exit code.</description></item>
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
                /// <item><description>For Linux instances, this is the exit code of the Shell command.</description></item>
                /// <item><description>For Windows instances, this is the exit code of the Bat or PowerShell command.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public long? ExitCode { get; set; }

                /// <summary>
                /// <para>The time when the command process ended. The time is displayed in UTC (Z) in the format of YYYY-MM-DDThh:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-03T02:42:29Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The instance ID of the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2445f4aecdac4b71ba2c7e3a7ccf****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The command execution status on a single instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The system is validating or sending the command.</description></item>
                /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
                /// <item><description>Aborted: Failed to send the command to the instance. The instance must be running and the command must be delivered within 1 minute.</description></item>
                /// <item><description>Running: The command is running on the instance.</description></item>
                /// <item><description>Success:<list type="bullet">
                /// <item><description>One-time task: The command execution is complete and the exit code is 0.</description></item>
                /// <item><description>Scheduled task: The last execution succeeded with an exit code of 0, and the specified schedule has ended.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Failed:<list type="bullet">
                /// <item><description>One-time task: The command execution is complete and the exit code is not 0.</description></item>
                /// <item><description>Scheduled task: The last execution succeeded with an exit code that is not 0, and the specified schedule will be aborted.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>Error: An exception occurred during command execution and the command cannot continue.</description></item>
                /// <item><description>Timeout: The command execution timed out.</description></item>
                /// <item><description>Cancelled: The command execution action has been canceled and the command was never started.</description></item>
                /// <item><description>Stopping: The task is being stopped.</description></item>
                /// <item><description>Terminated: The command was terminated during execution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The output information of the command execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OutputMsg</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// <para>The time when the command started running on the instance. The time is displayed in UTC (Z) in the format of YYYY-MM-DDThh:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-09T03:32:24Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The custom parameters included in the command. If no parameters exist, the default value is {}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>The username used to run the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The path in which the command was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c:\wwwroot</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page settings for a paged query. This is the paging size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
