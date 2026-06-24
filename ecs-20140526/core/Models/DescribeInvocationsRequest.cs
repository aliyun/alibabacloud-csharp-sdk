// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID. You can call <a href="https://help.aliyun.com/document_detail/64843.html">DescribeCommands</a> to query all available command IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The command name. This parameter does not take effect if you also specify <c>InstanceId</c>.</para>
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
        /// <item><description>RunBatScript: Bat script that runs on Windows instances.</description></item>
        /// <item><description>RunPowerShellScript: PowerShell script that runs on Windows instances.</description></item>
        /// <item><description>RunShellScript: Shell script that runs on Linux instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original command content and output.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded command content and output.</description></item>
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
        /// <para>Specifies whether to return the command output in the results.</para>
        /// <list type="bullet">
        /// <item><description>true: The command output is returned. You must specify at least <c>InvokeId</c> or <c>InstanceId</c>.</description></item>
        /// <item><description>false: The command output is not returned.</description></item>
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
        /// <para>The instance ID. If you specify this parameter, all command execution records for the instance are queried.</para>
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
        /// <para>The overall execution status of the command. The overall execution status depends on the common execution status across one or more instances in the execution. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Running:<list type="bullet">
        /// <item><description>Scheduled execution: The execution status remains Running until you manually stop the scheduled command.</description></item>
        /// <item><description>One-time execution: The overall execution status is Running as long as the command process is running on any instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Finished:<list type="bullet">
        /// <item><description>Scheduled execution: The command process never reaches the Finished state.</description></item>
        /// <item><description>One-time execution: All instances have completed execution, or the command process on some instances was manually stopped while the remaining instances completed execution.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Success: The command execution status on each instance is Stopped or Success, and the command execution status on at least one instance is Success.<list type="bullet">
        /// <item><description>Immediate task: The command execution is complete and the exit code is 0.</description></item>
        /// <item><description>Scheduled task: The last execution was successful with an exit code of 0, and all specified execution times have elapsed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed:<list type="bullet">
        /// <item><description>Scheduled execution: The command process never reaches the Failed state.</description></item>
        /// <item><description>One-time execution: All instances failed to run the command.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopped: The command was stopped.</description></item>
        /// <item><description>Stopping: The command is being stopped.</description></item>
        /// <item><description>PartialFailed: The command partially failed. This value does not take effect if you also specify <c>InstanceId</c>.</description></item>
        /// <item><description>Pending: The system is verifying or sending the command. The overall execution status is Pending if the command execution status on at least one instance is Pending.</description></item>
        /// <item><description>Scheduled: The scheduled command has been sent and is waiting to run. The overall execution status is Scheduled if the command execution status on at least one instance is Scheduled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
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
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
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
        /// <para>This parameter is about to be deprecated. Use NextToken and MaxResults to perform paging queries.</para>
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
        /// <para>This parameter is about to be deprecated. Use NextToken and MaxResults to perform paging queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The execution mode of the command. This parameter does not take effect if you also specify <c>InstanceId</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: The command is immediately run.</description></item>
        /// <item><description>Period: The command is run on a schedule.</description></item>
        /// <item><description>NextRebootOnly: The command is automatically run the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: The command is automatically run every time the instance starts.</description></item>
        /// </list>
        /// <para>Default value: empty, which indicates that all execution modes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Once</para>
        /// </summary>
        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        /// <summary>
        /// <para>The resource group ID for command execution. After you specify this parameter, you must also specify ResourceGroupId when running the command. This parameter filters the corresponding command execution results.</para>
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
            /// <para>The tag key of the command execution. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the number of resources with the specified tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources with all specified tags attached cannot exceed 1,000. If the resource count exceeds 1,000, call <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> to execute the query.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the command will be automatically run in the future. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries commands for which the <c>RepeatMode</c> parameter is set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c> when <c>RunCommand</c> or <c>InvokeCommand</c> is called.</description></item>
        /// <item><description>false: Queries commands in the following two states:<list type="bullet">
        /// <item><description>Commands for which the <c>RepeatMode</c> parameter is set to <c>Once</c> when <c>RunCommand</c> or <c>InvokeCommand</c> is called.</description></item>
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
