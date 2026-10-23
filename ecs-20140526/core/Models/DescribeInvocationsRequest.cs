// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call the <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> operation to query all available command IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The command name. This parameter does not take effect if the InstanceId parameter is also specified.</para>
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
        /// <item><description>RunBatScript: The command is a batch script that runs on a Windows instance.</description></item>
        /// <item><description>RunPowerShellScript: The command is a PowerShell script that runs on a Windows instance.</description></item>
        /// <item><description>RunShellScript: The command is a shell script that runs on a Linux instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>The encoding method of the CommandContent and Output fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: returns the original command content and output.</description></item>
        /// <item><description>Base64: returns the Base64-encoded command content and output.</description></item>
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
        /// <para>Specifies whether to return the output of the command execution in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The output is returned. In this case, you must specify at least the InvokeId or InstanceId parameter.</description></item>
        /// <item><description>false: The output is not returned.</description></item>
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
        /// <para>The instance ID. If you specify this parameter, the system queries all command execution records of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i7gg30r52z2em****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The execution ID of the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The overall execution status of the command. The overall execution status depends on the combined execution status of one or more instances involved in the execution. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Running:<list type="bullet">
        /// <item><description>Scheduled execution: The execution status remains Running until the scheduled command is manually stopped.</description></item>
        /// <item><description>One-time execution: The overall execution status is Running as long as a command process is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Finished:<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot be finished.</description></item>
        /// <item><description>One-time execution: All instances have completed the execution. Alternatively, the command processes on some instances are manually stopped, and the execution on the remaining instances is completed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Success: The command execution status on each instance is Stopped or Success, and the command execution status on at least one instance is Success.<list type="bullet">
        /// <item><description>Immediately run tasks: The command execution is completed, and the exit code is 0.</description></item>
        /// <item><description>Scheduled tasks: The most recent execution is successful, the exit code is 0, and the specified schedule has ended.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed:<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot fail.</description></item>
        /// <item><description>One-time execution: The execution fails on all instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopped: The command is stopped.</description></item>
        /// <item><description>Stopping: The command is being stopped.</description></item>
        /// <item><description>PartialFailed: The execution partially fails. This value does not take effect if the InstanceId parameter is also specified.</description></item>
        /// <item><description>Pending: The system is verifying or sending the command. The overall execution status is Pending if the command execution status on at least one instance is Pending.</description></item>
        /// <item><description>Scheduled: The scheduled command has been sent and is waiting to be run. The overall execution status is Scheduled if the command execution status on at least one instance is Scheduled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging.</para>
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
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call.</para>
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
        /// <para>This parameter will soon be taken offline. We recommend that you use NextToken and MaxResults for paging and paged query operations.</para>
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
        /// <para>This parameter will soon be taken offline. We recommend that you use NextToken and MaxResults for paging and paged query operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The execution mode of the command. This parameter does not take effect if the InstanceId parameter is also specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: runs the command immediately.</description></item>
        /// <item><description>Period: runs the command on a schedule.</description></item>
        /// <item><description>NextRebootOnly: automatically runs the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically runs the command every time the instance starts.</description></item>
        /// </list>
        /// <para>Default value: empty. An empty value indicates that all execution modes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the command execution belongs. If you specify this parameter, you must also specify ResourceGroupId when you run the command. This allows you to filter the corresponding command execution results.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationsRequestTag> Tag { get; set; }
        public class DescribeInvocationsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command to execute. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count returned cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that have all the specified tags attached cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the queried command will be automatically run in the future. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries commands for which the RepeatMode parameter is set to Period, NextRebootOnly, or EveryReboot when you call RunCommand or InvokeCommand to run the commands.</description></item>
        /// <item><description>false: Queries commands in the following states:<list type="bullet">
        /// <item><description>Commands for which the RepeatMode parameter is set to Once when you call RunCommand or InvokeCommand to run the commands.</description></item>
        /// <item><description>Commands that have been canceled, stopped, or completed.</description></item>
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
