// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
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
            /// <para>The command content, which is transmitted in Base64 encoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bHM=</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The command name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

            /// <summary>
            /// <para>The type of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RunBatScript: a Bat command for Windows instances.</description></item>
            /// <item><description>RunPowerShellScript: a PowerShell command for Windows instances.</description></item>
            /// <item><description>RunShellScript: a shell command for Linux instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RunShellScript</para>
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// <para>The time when the command was created. The time is displayed in UTC (Z) in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11T06:37:16Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The execution status of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The system is verifying or sending the command.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: The command failed to be sent to the instance. The instance must be in the Running state, and the command must be delivered within one minute.</description></item>
            /// <item><description>Running: The command is being run on the instance.</description></item>
            /// <item><description>Success: The command execution is complete, and the exit code is 0.</description></item>
            /// <item><description>Failed: The command execution is complete, and the exit code is non-zero.</description></item>
            /// <item><description>Error: An exception occurred during command execution, and the command could not continue.</description></item>
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
            /// <para>t-hz02p9545t6****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            /// <summary>
            /// <para>The status of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The command is running.</description></item>
            /// <item><description>Finished: The command execution is complete.</description></item>
            /// <item><description>Failed: The command execution failed.</description></item>
            /// <item><description>Stopped: The command has been stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("InvokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            /// <summary>
            /// <para>The custom parameters included in the command. If no parameters exist, the default value is {}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

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
        /// <para>The number of entries per page. Settings for paging in a paged query.</para>
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
        /// <para>The total number of commands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
