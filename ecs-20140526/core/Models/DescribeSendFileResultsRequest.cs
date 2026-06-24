// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSendFileResultsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. If you specify this parameter, all file sending records of the specified instance are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The overall sending status of the file. The overall status depends on the shared execution status of all target instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The system is validating or sending the file. The overall status is Pending if the file sending status of at least one instance is Pending.</description></item>
        /// <item><description>Running: The file is being sent to instances. The overall status is Running if the file sending status of at least one instance is Running.</description></item>
        /// <item><description>Success: The file is sent. The overall status is Success if the file sending status of all instances is Success.</description></item>
        /// <item><description>Failed: The file failed to be sent. The overall status is Failed if the file sending status of all instances is Failed.</description></item>
        /// <item><description>PartialFailed: The file is sent to some instances but failed on others. The overall status is PartialFailed if the file sending status of all instances is Success or Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("InvocationStatus")]
        [Validation(Required=false)]
        public string InvocationStatus { get; set; }

        /// <summary>
        /// <para>The execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-hz0jdfwd9f****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

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
        /// <para>The name of the file. If you specify this parameter, all sending records of the file with the specified name are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>This parameter is about to go offline. Use NextToken and MaxResults to execute paging query operations.</para>
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
        /// <para>This parameter is about to go offline. Use NextToken and MaxResults to execute paging query operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the ECS instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the file sending task belongs. After you specify this parameter, you must also specify ResourceGroupId when sending a file. This way, you can filter the file sending results of the specified resource group.</para>
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
        public List<DescribeSendFileResultsRequestTag> Tag { get; set; }
        public class DescribeSendFileResultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the file sending task. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use one tag to filter resources, the resource count with the specified tag cannot exceed 1000. If you use multiple tags to filter resources, the resource count with all specified tags attached cannot exceed 1000. If the resource count exceeds 1000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the file sending task. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
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
