// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCommandInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call the <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> operation to query all available command IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-sh02yh0932w****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The command name. If both CommandName and InstanceId are specified, CommandName does not take effect.</para>
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
        /// <item><description>RunBatScript: batch command, applicable to Windows instances</description></item>
        /// <item><description>RunPowerShellScript: PowerShell command, applicable to Windows instances</description></item>
        /// <item><description>RunShellScript: shell command, applicable to Linux instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunPowerShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

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
        /// <para>The overall execution state of the command. The value of this parameter depends on the execution status of the command on all the involved instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The command is being verified or sent. When the execution state on at least one instance is Pending, the overall execution state is Pending.</para>
        /// </description></item>
        /// <item><description><para>Running: The command is being run on the instances. When the execution state on at least one instance is Running, the overall execution state is Running.</para>
        /// </description></item>
        /// <item><description><para>Success: When the execution state on at least one instance is Success and the execution state on other instances is Stopped or Success, the overall execution state is Success.</para>
        /// <list type="bullet">
        /// <item><description>Command that is set to run immediately: The command execution is complete, and the exit code is 0.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Failed: When the execution state on all instances is Stopped or Failed, the overall execution state is Failed. When the execution state on an instance is one of the following values, Failed is returned as the overall execution state:</para>
        /// <list type="bullet">
        /// <item><description>Invalid: The command is invalid.</description></item>
        /// <item><description>Aborted: The command fails to be sent.</description></item>
        /// <item><description>Failed: The command execution is complete, and the exit code is not 0.</description></item>
        /// <item><description>Timeout: The command execution times out.</description></item>
        /// <item><description>Error: An error occurs when the command is being run.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Stopping: The command task is being stopped. When the execution state on at least one instance is Stopping, the overall execution state is Stopping.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The command task is stopped. When the execution state on all instances is Stopped, the overall execution state is Stopped. When the execution state on an instance is one of the following values, Stopped is returned as the overall execution state:</para>
        /// <list type="bullet">
        /// <item><description>Cancelled: The command task is canceled.</description></item>
        /// <item><description>Terminated: The command task is terminated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PartialFailed: The command execution succeeds on some instances and fails on other instances. When the execution state on some instances is Success and the execution state on other instances is Failed or Stopped, the overall execution state is PartialFailed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of the <c>InvokeStatus</c> response parameter is similar to the value of InvocationStatus. We recommend that you ignore InvokeStatus and check the value of InvocationStatus.</para>
        /// </remarks>
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
        /// <para>t-hz02p9545t6****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
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
