// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The command ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding method for the <c>CommandContent</c> and <c>Output</c> fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original command content and output information.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded command content and output information.
        /// Default value: Base64.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the history records of commands that execute on a schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns the results of commands that execute on a schedule. If this parameter is set to true, the InvokeId parameter cannot be empty and must be the execution ID of a scheduled command (RepeatMode is Period) or a command that runs after each system startup (RepeatMode is EveryReboot).</description></item>
        /// <item><description>false: Does not return the history records.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeHistory")]
        [Validation(Required=false)]
        public bool? IncludeHistory { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i7gg30r52z2em****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The execution ID of the command. You can call the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> operation to query the InvokeId value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The execution status of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The command is running.<list type="bullet">
        /// <item><description>Scheduled execution: The execution status remains Running until the scheduled command is manually stopped.</description></item>
        /// <item><description>One-time execution: The overall execution status is Running as long as a command process is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Finished: The command is completed.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot be in the Finished state.</description></item>
        /// <item><description>One-time execution: The command is completed on all instances, or the command process is manually stopped on some instances and completed on the remaining instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Success:<list type="bullet">
        /// <item><description>One-time execution: The command is completed and the exit code is 0.</description></item>
        /// <item><description>Scheduled execution: The last execution was successful with an exit code of 0, and the specified execution time has ended.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed: The execution failed.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot be in the Failed state.</description></item>
        /// <item><description>One-time execution: The command failed on all instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>PartialFailed: The execution partially failed.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot be in the PartialFailed state.</description></item>
        /// <item><description>One-time execution: The command process failed on some instances, so the overall execution status is PartialFailed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopped: The command execution is stopped.</description></item>
        /// <item><description>Stopping: The command execution is being stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

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
        /// <para>This parameter will soon be deprecated. We recommend that you use NextToken and MaxResults for paging.</para>
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
        /// <para>This parameter will soon be deprecated. We recommend that you use NextToken and MaxResults for paging.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The ID of the resource group to which the command execution belongs. If you specify this parameter, you must specify ResourceGroupId when you run the command. This allows you to filter the corresponding command execution results.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command that you execute. Valid values of N: 1 to 20. This parameter cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count under the tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that are attached to all specified tags cannot exceed 1,000. If the resource count exceeds 1,000, you must call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. This parameter can be an empty string.
            /// The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
