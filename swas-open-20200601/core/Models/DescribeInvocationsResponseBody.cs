// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The command name.</para>
        /// </summary>
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public List<DescribeInvocationsResponseBodyInvocations> Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            /// <summary>
            /// <para>The content of the command, which is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bHM=</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The name of the command.</para>
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
            /// <item><description>RunBatScript: batch command (applicable to Windows instances).</description></item>
            /// <item><description>RunPowerShellScript: PowerShell command (applicable to Windows instances).</description></item>
            /// <item><description>RunShellScript: shell command (applicable to Linux instances).</description></item>
            /// </list>
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
            /// <para>2022-07-11T06:37:16Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The status of the command. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The command is being verified or sent.</description></item>
            /// <item><description>Invalid: The specified command type or parameter is invalid.</description></item>
            /// <item><description>Aborted: The command failed to be sent. To send a command to an instance, make sure that the instance is in the Running state and the command is sent to the instance within 1 minute.</description></item>
            /// <item><description>Running: The command is being run on the instance.</description></item>
            /// <item><description>Success: The command finishes running, and the exit code is 0.</description></item>
            /// <item><description>Failed: The command finishes running, but the exit code is not 0.</description></item>
            /// <item><description>Error: The running of the command cannot proceed due to an exception.</description></item>
            /// <item><description>Timeout: The running of the command times out.</description></item>
            /// <item><description>Cancelled: The running is canceled, and the command is not run.</description></item>
            /// <item><description>Stopping: The command that is running is being stopped.</description></item>
            /// <item><description>Terminated: The command is terminated while it is being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            /// <summary>
            /// <para>The ID of the command task.</para>
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
            /// <item><description>Finished: The command finishes running.</description></item>
            /// <item><description>Failed: The running of the command failed.</description></item>
            /// <item><description>Stopped: The running is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("InvokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            /// <summary>
            /// <para>The custom parameters in the command. If no custom parameter exists in the command, the default value is {}.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
