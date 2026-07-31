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
        /// <para>The command name. This parameter does not take effect if the <c>InstanceId</c> parameter is also specified.</para>
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
        /// <item><description>RunShellScript: shell script that runs on Linux instances.</description></item>
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
        /// <item><description>PlainText: returns the original command content and output.</description></item>
        /// <item><description>Base64: returns Base64-encoded command content and output.</description></item>
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
        /// <para>Specifies whether to return the command output in the response.</para>
        /// <list type="bullet">
        /// <item><description>true: returns the output. You must specify at least the <c>InvokeId</c> or <c>InstanceId</c> parameter.</description></item>
        /// <item><description>false: does not return the output.</description></item>
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
        /// <para>The overall execution status of the command. The overall execution status is determined by the combined execution status across one or more instances. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Running:<list type="bullet">
        /// <item><description>Scheduled execution: the execution status remains Running until you manually stop the scheduled command.</description></item>
        /// <item><description>One-time execution: the overall status is Running if the command process is running on any instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Finished:<list type="bullet">
        /// <item><description>Scheduled execution: the status can never be Finished.</description></item>
        /// <item><description>One-time execution: all instances have completed execution, or the command process on some instances was manually stopped while the remaining instances completed execution.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Success: the execution status on each instance is Stopped or Success, and at least one instance has a status of Success.<list type="bullet">
        /// <item><description>Immediate task: the command execution is complete and the exit code is 0.</description></item>
        /// <item><description>Scheduled task: the most recent execution succeeded with an exit code of 0, and all specified execution times have elapsed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed:<list type="bullet">
        /// <item><description>Scheduled execution: the status can never be Failed.</description></item>
        /// <item><description>One-time execution: all instances failed to run the command.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopped: the command was stopped.</description></item>
        /// <item><description>Stopping: the command is being stopped.</description></item>
        /// <item><description>PartialFailed: the command succeeded on some instances but failed on others. This value does not take effect if the <c>InstanceId</c> parameter is also specified.</description></item>
        /// <item><description>Pending: the system is verifying or sending the command. The overall status is Pending if at least one instance has a status of Pending.</description></item>
        /// <item><description>Scheduled: the scheduled command has been sent and is waiting to run. The overall status is Scheduled if at least one instance has a status of Scheduled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.</para>
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
        /// <para>The execution mode of the command. This parameter does not take effect if the <c>InstanceId</c> parameter is also specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Once: runs the command immediately.</description></item>
        /// <item><description>Period: runs the command on a schedule.</description></item>
        /// <item><description>NextRebootOnly: automatically runs the command the next time the instance starts.</description></item>
        /// <item><description>EveryReboot: automatically runs the command every time the instance starts.</description></item>
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
        /// <para>The ID of the resource group to which the command execution belongs. After you specify this parameter, you must also specify ResourceGroupId when you run the command. This way, the corresponding command execution results can be filtered.</para>
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
            /// <para>If you use a single tag to filter resources, the number of resources with the specified tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources that are attached to all specified tags cannot exceed 1,000. If the resource count exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to execute the query.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>Specifies whether to query commands that will be automatically run in the future. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: queries commands for which the <c>RepeatMode</c> parameter is set to <c>Period</c>, <c>NextRebootOnly</c>, or <c>EveryReboot</c> when <c>RunCommand</c> or <c>InvokeCommand</c> is called.</description></item>
        /// <item><description>false: queries commands that meet one of the following conditions:<list type="bullet">
        /// <item><description>The <c>RepeatMode</c> parameter is set to <c>Once</c> when <c>RunCommand</c> or <c>InvokeCommand</c> is called.</description></item>
        /// <item><description>The commands have been canceled, stopped, or completed.</description></item>
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
