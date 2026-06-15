// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call the <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> API to query all available CommandId values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The command name. If the <c>InstanceId</c> parameter is also specified, this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CommandTestName</para>
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RunBatScript: The command is a Bat script that runs on a Windows instance.</para>
        /// </description></item>
        /// <item><description><para>RunPowerShellScript: The command is a PowerShell script that runs on a Windows instance.</para>
        /// </description></item>
        /// <item><description><para>RunShellScript: The command is a Shell script that runs on a Linux instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>The codec for the <c>CommandContent</c> and <c>Output</c> fields in the returned data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: Returns the original command content and output information.</para>
        /// </description></item>
        /// <item><description><para>Base64: Returns Base64-encoded command content and output information.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Indicates whether to return the command execution output in the results.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns the output. In this case, you must specify at least one of the <c>InvokeId</c> or <c>InstanceId</c> parameters.</para>
        /// </description></item>
        /// <item><description><para>false: Does not return the output.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        /// <summary>
        /// <para>The instance ID. If you specify this parameter, all command execution records for this instance will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i7gg30r52z2em****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The command execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The overall execution status of the command. The overall status depends on the combined execution statuses of one or more instances involved in the command execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running:</para>
        /// <list type="bullet">
        /// <item><description><para>Periodic execution: The status remains Running until the periodic execution is manually stopped.</para>
        /// </description></item>
        /// <item><description><para>One-time execution: The overall status is Running as long as any instance has a running command process.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Finished:</para>
        /// <list type="bullet">
        /// <item><description><para>Periodic execution: The command process cannot reach a Finished state.</para>
        /// </description></item>
        /// <item><description><para>One-time execution: All instances have completed execution, or some instances were manually stopped while the rest completed execution.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Success: All instances have a command execution status of either Stopped or Success, and at least one instance has a status of Success. Specifically:</para>
        /// <list type="bullet">
        /// <item><description><para>For immediate jobs: The command completed successfully with an exit code of 0.</para>
        /// </description></item>
        /// <item><description><para>For scheduled jobs: The most recent execution succeeded with an exit code of 0, and all scheduled times have been completed.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Failed:</para>
        /// <list type="bullet">
        /// <item><description><para>Periodic execution: The command process cannot reach a Failed state.</para>
        /// </description></item>
        /// <item><description><para>One-time execution: All instances failed execution.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Stopped: The command was stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The command is being stopped.</para>
        /// </description></item>
        /// <item><description><para>PartialFailed: Partial failure. This value does not take effect if the <c>InstanceId</c> parameter is also specified.</para>
        /// </description></item>
        /// <item><description><para>Pending: The system is validating or sending the command. If at least one instance has a Pending execution status, the overall status is Pending.</para>
        /// </description></item>
        /// <item><description><para>Scheduled: The scheduled command has been sent and is waiting to run. If at least one instance has a Scheduled execution status, the overall status is Scheduled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paged queries.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query credential (Token). Set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be unpublished soon. We recommend that you use NextToken and MaxResults to perform paged queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be unpublished soon. We recommend that you use NextToken and MaxResults to perform paged query operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The Region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest Alibaba Cloud region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The execution mode of the command. This parameter does not take effect if the <c>InstanceId</c> parameter is also specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Once: Executes the command immediately.</para>
        /// </description></item>
        /// <item><description><para>Period: Executes the command periodically.</para>
        /// </description></item>
        /// <item><description><para>NextRebootOnly: Automatically executes the command the next time the instance starts.</para>
        /// </description></item>
        /// <item><description><para>EveryReboot: Automatically executes the command every time the instance starts.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that all modes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The resource group ID of the command execution. After you specify this parameter, you must also specify ResourceGroupId when executing the command. This enables filtering to retrieve the corresponding command execution results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationsRequestTag> Tag { get; set; }
        public class DescribeInvocationsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key for command execution. Valid values for N are 1 to 20. If this value is specified, it cannot be an empty string.</para>
            /// <para>When you use one tag to filter resources, the number of resources under this tag cannot exceed 1,000. When you use multiple tags to filter resources, the number of resources bound to all specified tags simultaneously cannot exceed 1,000. If the number of resources exceeds 1,000, you must use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> API to query them.</para>
            /// <para>The key can contain up to 64 characters, must not start with <c>aliyun</c> or <c>acs:</c>, and must not contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value for command execution. Valid values for N are 1 to 20. This value can be an empty string.</para>
            /// <para>The value can contain up to 128 characters and must not contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the queried command will be automatically executed in the future. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The command is queried when the <c>RepeatMode</c> parameter is set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c> during a call to <c>RunCommand</c> or <c>InvokeCommand</c>.</para>
        /// </description></item>
        /// <item><description><para>false: The command is queried under either of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description><para>The <c>RepeatMode</c> parameter is set to <c>Once</c> during a call to <c>RunCommand</c> or <c>InvokeCommand</c>.</para>
        /// </description></item>
        /// <item><description><para>The command has been canceled, stopped, or has finished execution.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

    }

}
