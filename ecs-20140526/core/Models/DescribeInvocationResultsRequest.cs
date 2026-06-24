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
        /// <para>The encoding type of the CommandContent and Output fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original command content and output.</description></item>
        /// <item><description>Base64: Returns Base64-encoded command content and output.</description></item>
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
        /// <para>Specifies whether to return the history records of scheduled command executions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns the results of scheduled command executions. When this parameter is set to true, InvokeId cannot be empty and must be the execution ID of a scheduled command (RepeatMode is Period) or a command that executes at each system startup (RepeatMode is EveryReboot).</description></item>
        /// <item><description>false: Does not return the history.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
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
        /// <para>The command execution ID. You can call <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> to query the InvokeId.</para>
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
        /// <item><description>Scheduled execution: The execution status remains running until you manually stop the scheduled command.</description></item>
        /// <item><description>One-time execution: The overall execution status is running as long as any command process is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Finished: The command execution is complete.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot have a status of finished.</description></item>
        /// <item><description>One-time execution: All instances have completed execution, or you manually stopped the command process on some instances and the remaining instances have completed execution.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Success:<list type="bullet">
        /// <item><description>One-time execution: The command execution is complete and the exit code is 0.</description></item>
        /// <item><description>Scheduled execution: The last execution succeeded with an exit code of 0, and the specified execution time has ended.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Failed: The command execution failed.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot have a status of failed.</description></item>
        /// <item><description>One-time execution: All instances failed to execute the command.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>PartialFailed: The command execution partially failed.<list type="bullet">
        /// <item><description>Scheduled execution: The command process cannot have a status of partially failed.</description></item>
        /// <item><description>One-time execution: Some instances have failed command processes, so the overall execution status is partially failed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Stopped: The command execution has been stopped.</description></item>
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
        /// <para>The maximum number of entries per page for a paging query.</para>
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
        /// <para>This parameter is about to be deprecated. Use NextToken and MaxResults to complete paging query operations.</para>
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
        /// <para>This parameter is about to be deprecated. Use NextToken and MaxResults to complete paging query operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The ID of the resource group to which the command execution belongs. After you specify this parameter, you must also specify ResourceGroupId when running the command. This parameter filters the corresponding command execution results.</para>
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
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command execution. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count with this tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count with all specified tags attached cannot exceed 1,000. If the resource count exceeds 1,000, call <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> to execute the query.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the command execution. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
