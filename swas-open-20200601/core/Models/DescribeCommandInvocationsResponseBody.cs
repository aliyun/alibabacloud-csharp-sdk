// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The command executions.</para>
        /// </summary>
        [NameInMap("CommandInvocations")]
        [Validation(Required=false)]
        public List<DescribeCommandInvocationsResponseBodyCommandInvocations> CommandInvocations { get; set; }
        public class DescribeCommandInvocationsResponseBodyCommandInvocations : TeaModel {
            /// <summary>
            /// <para>The content of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo 123</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The description of the command.</para>
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
            /// <para>The time when the command was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-27T10:11:58</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The overall execution state of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The command is being verified or sent.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: The command failed to be sent to the instances. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.</description></item>
            /// <item><description>Running: The command is being run on the instances.</description></item>
            /// <item><description>Success: The command execution is complete, and the exit code is 0.</description></item>
            /// <item><description>Failed: The command execution is complete, and the exit code is not 0.</description></item>
            /// <item><description>Error: The command execution cannot proceed due to an exception.</description></item>
            /// <item><description>Timeout: The command execution timed out.</description></item>
            /// <item><description>Cancelled: The command execution is canceled, and the command is not started.</description></item>
            /// <item><description>Stopping: The command in the Running state is being stopped.</description></item>
            /// <item><description>Terminated: The command is terminated when it is being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// <para>The execution ID of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-hz0373jyzxt****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// <para>The instances on which the command is run.</para>
            /// </summary>
            [NameInMap("InvokeInstances")]
            [Validation(Required=false)]
            public List<DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances> InvokeInstances { get; set; }
            public class DescribeCommandInvocationsResponseBodyCommandInvocationsInvokeInstances : TeaModel {
                /// <summary>
                /// <para>The error code returned if the command failed to be sent or run.</para>
                /// <list type="bullet">
                /// <item><description>null: The command is run as expected.</description></item>
                /// <item><description>InstanceNotExists: The specified instance does not exist or is released.</description></item>
                /// <item><description>InstanceReleased: The instance is released when the command is being run.</description></item>
                /// <item><description>InstanceNotRunning: The instance is not in the Running state when the command is being run.</description></item>
                /// <item><description>CommandNotApplicable: The command is not applicable to the specified instance.</description></item>
                /// <item><description>AccountNotExists: The specified account does not exist.</description></item>
                /// <item><description>DirectoryNotExists: The specified directory does not exist.</description></item>
                /// <item><description>BadCronExpression: The specified CRON expression for the execution schedule is invalid.</description></item>
                /// <item><description>ClientNotRunning: Cloud Assistant Agent is not running.</description></item>
                /// <item><description>ClientNotResponse: Cloud Assistant Agent does not respond to your request.</description></item>
                /// <item><description>ClientIsUpgrading: Cloud Assistant Agent is being updated.</description></item>
                /// <item><description>ClientNeedUpgrade: Cloud Assistant Agent needs to be updated.</description></item>
                /// <item><description>DeliveryTimeout: The request to send the command timed out.</description></item>
                /// <item><description>ExecutionTimeout: The command execution timed out.</description></item>
                /// <item><description>ExecutionException: An exception occurred when the command was being run.</description></item>
                /// <item><description>ExecutionInterrupted: The command execution is interrupted.</description></item>
                /// <item><description>ExitCodeNonzero: The command execution is complete, and the exit code is not 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceNotExists</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned if the command failed to be sent or run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null: The command is run as expected.</description></item>
                /// <item><description>the specified instance does not exists: The specified instance does not exist or is released.</description></item>
                /// <item><description>the instance has released when create task: The instance is released when the command is being run.</description></item>
                /// <item><description>the instance is not running when create task: The instance is not in the Running state when the command is being run.</description></item>
                /// <item><description>the command is not applicable: The command is not applicable to the specified instance.</description></item>
                /// <item><description>the specified account does not exists: The specified account does not exist.</description></item>
                /// <item><description>the specified directory does not exists: The specified directory does not exist.</description></item>
                /// <item><description>the cron job expression is invalid: The specified CRON expression for the execution schedule is invalid.</description></item>
                /// <item><description>the aliyun service is not running on the instance: Cloud Assistant Agent is not running.</description></item>
                /// <item><description>the aliyun service in the instance does not response: Cloud Assistant Agent does not respond to your request.</description></item>
                /// <item><description>the aliyun service in the instance is upgrading now: Cloud Assistant Agent is being updated.</description></item>
                /// <item><description>the aliyun service in the instance need upgrade: Cloud Assistant Agent needs to be updated.</description></item>
                /// <item><description>the command delivery has been timeout: The request to send the command timed out.</description></item>
                /// <item><description>the command execution has been timeout: The command execution timed out.</description></item>
                /// <item><description>the command execution got an exception: An exception occurred when the command was being run.</description></item>
                /// <item><description>the command execution has been interrupted: The command execution is interrupted.</description></item>
                /// <item><description>the command execution exit code is not zero: The command execution is complete, and the exit code is not 0.</description></item>
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
                /// <para>The end of the time range during which the command is run on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-03T02:42:29Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2445f4aecdac4b71ba2c7e3a7ccf****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The execution state of the command on a single instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The command is being verified or sent.</para>
                /// </description></item>
                /// <item><description><para>Invalid: The specified command type or parameter is invalid.</para>
                /// </description></item>
                /// <item><description><para>Aborted: The command failed to be sent to the instance. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.</para>
                /// </description></item>
                /// <item><description><para>Running: The command is being run on the instance.</para>
                /// </description></item>
                /// <item><description><para>Success:</para>
                /// <list type="bullet">
                /// <item><description>Command that is set to run only once: The command execution is complete, and the exit code is 0.</description></item>
                /// <item><description>Command that is set to run on a schedule: The previous command execution is complete, the exit code is 0, and the specified cycle ends.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Failed:</para>
                /// <list type="bullet">
                /// <item><description>Command that is set to run only once: The command execution is complete, and the exit code is not 0.</description></item>
                /// <item><description>Command that is set to run on a schedule: The previous command execution is complete, the exit code is not 0, and the specified cycle is about to end.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Error: The command execution cannot proceed due to an exception.</para>
                /// </description></item>
                /// <item><description><para>Timeout: The command execution timed out.</para>
                /// </description></item>
                /// <item><description><para>Cancelled: The command execution is canceled, and the command is not started.</para>
                /// </description></item>
                /// <item><description><para>Stopping: The command task is being stopped.</para>
                /// </description></item>
                /// <item><description><para>Terminated: The command is terminated when it is being run.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <para>The command output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OutputMsg</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the command is run on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-09T03:32:24Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The custom parameters in the command. If no custom parameter exists in the command, the default value is {}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The timeout period. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

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
            /// <para>The working directory of the command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c:\wwwroot</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
