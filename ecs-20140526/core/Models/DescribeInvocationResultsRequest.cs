// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInvocationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz0jdfwcsr****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>The encoding mode of the <c>CommandContent</c> and <c>Output</c> values in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: returns the original command content and command output.</description></item>
        /// <item><description>Base64: returns the Base64-encoded command content and command output.</description></item>
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
        /// <para>Specifies whether to return the results of historical scheduled executions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the results of historical scheduled executions. If you set this parameter to true, you must set InvokeId to the ID of a task that is run on a schedule (RepeatMode set to Period) or on each system startup (RepeatMode set to EveryReboot).</description></item>
        /// <item><description>false: does not return the results of historical scheduled executions.</description></item>
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
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1i7gg30r52z2em****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the command task. You can call the <a href="https://help.aliyun.com/document_detail/64840.html">DescribeInvocations</a> operation to query the IDs of all command tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The execution status of the command task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: Before you stop the scheduled execution of the command, the execution state is always Running.</description></item>
        /// <item><description>One-time task: If the command is being run on instances, the execution state is Running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Finished:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be Finished.</description></item>
        /// <item><description>One-time task: The execution is complete on all instances, or the execution is stopped on some instances and is complete on the other instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Success:</para>
        /// <list type="bullet">
        /// <item><description>One-time task: The execution is complete, and the exit code is 0.</description></item>
        /// <item><description>Scheduled task: The last execution is complete, the exit code is 0, and the specified period ends.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Failed:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be Failed.</description></item>
        /// <item><description>One-time task: The execution fails on all instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PartialFailed:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled task: The execution state can never be PartialFailed.</description></item>
        /// <item><description>One-time task: The execution fails on some instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Stopped: The task is stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The task is being stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InvokeRecordStatus")]
        [Validation(Required=false)]
        public string InvokeRecordStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
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
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the command. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. After you set this parameter, command execution results in the specified resource group are queried.</para>
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
        /// <para>The tags of the command task.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInvocationResultsRequestTag> Tag { get; set; }
        public class DescribeInvocationResultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the command task. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags added, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the command task. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
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
