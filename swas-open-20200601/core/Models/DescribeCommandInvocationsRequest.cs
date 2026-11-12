// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> to query all available command IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-sh02yh0932w****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The command name. If the InstanceId parameter is also specified, this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: Bat command for Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command for Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell command for Linux instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunPowerShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

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
        /// <para>The overall execution status of the command. The overall execution status depends on the common execution status across all instances in this invocation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The system is validating or sending the command. If the command execution status on at least one instance is Pending, the overall execution status is Pending.</description></item>
        /// <item><description>Running: The command is running on instances. If the command execution status on at least one instance is Running, the overall execution status is Running.</description></item>
        /// <item><description>Success: The command execution status on each instance is Stopped or Success, and the command execution status on at least one instance is Success. In this case, the overall execution status is Success.<list type="bullet">
        /// <item><description>One-time task: The command execution is complete and the exit code is 0.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed: The command execution status on each instance is Stopped or Failed. In this case, the overall execution status is Failed. The overall execution status is Failed when the command execution status on an instance is one or more of the following values:<list type="bullet">
        /// <item><description>Command validation failed (Invalid).</description></item>
        /// <item><description>Command sending failed (Aborted).</description></item>
        /// <item><description>Command execution is complete but the exit code is not 0 (Failed).</description></item>
        /// <item><description>Command execution timed out (Timeout).</description></item>
        /// <item><description>Command execution encountered an exception (Error).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopping: The task is being stopped. If the command execution status on at least one instance is Stopping, the overall execution status is Stopping.</description></item>
        /// <item><description>Stopped: The task is stopped. If the command execution status on all instances is Stopped, the overall execution status is Stopped. The overall execution status is Stopped when the command execution status on an instance is one of the following values:<list type="bullet">
        /// <item><description>Task canceled (Cancelled).</description></item>
        /// <item><description>Task terminated (Terminated).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>PartialFailed: The command execution succeeded on some instances and failed on others. If the command execution status on each instance is Success, Failed, or Stopped, the overall execution status is PartialFailed.<remarks>
        /// <para>The <c>InvokeStatus</c> response parameter has a similar meaning, but we recommend that you check the value of this parameter.</para>
        /// </remarks>
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
        /// <para>The command execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz02p9545t6****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
