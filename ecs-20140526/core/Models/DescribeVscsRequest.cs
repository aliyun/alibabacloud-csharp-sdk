// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVscsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID to which the cloud disk or local disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 10 to 500. Default value: 10. If you do not specify this parameter or specify a value less than 10, the default value is 10. If you specify a value greater than 500, the default value is 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned for the current request.</para>
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
        /// <para>The ID of the resource group to which the instance belongs. When you use this parameter to filter resources, the resource count cannot exceed 1,000. Note: Filtering by the default resource group is not supported.</para>
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
        /// <para>The status of the VSCs to be queried. If you do not specify this parameter, VSCs in all states are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In_use: In use.</description></item>
        /// <item><description>Attaching: Attaching.</description></item>
        /// <item><description>Detaching: Detaching.</description></item>
        /// <item><description>AttachFailed: Attachment failed.</description></item>
        /// <item><description>DetachFailed: Detachment failed.</description></item>
        /// <item><description>All (default): All states.</description></item>
        /// </list>
        /// <para>Default value: All.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVscsRequestTag> Tag { get; set; }
        public class DescribeVscsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the command. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count returned cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources to which you attach multiple tags at the same time cannot exceed 1,000. If the resource count exceeds 1,000, you must call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Environment</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the VSCs to be queried.</para>
        /// <para>We recommend that you specify no more than 100 VSC IDs.</para>
        /// </summary>
        [NameInMap("VscIds")]
        [Validation(Required=false)]
        public List<string> VscIds { get; set; }

    }

}
