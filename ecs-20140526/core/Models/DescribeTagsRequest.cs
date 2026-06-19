// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTagsRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This parameter is about to be deprecated. To ensure compatibility, use other parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the tag list.</para>
        /// <para>Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The ID of the resource to which the tag is attached. For example, if the resource type (ResourceType) is instance, the resource ID is the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-946ntx4wr****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance.</description></item>
        /// <item><description>disk: cloud disk.</description></item>
        /// <item><description>snapshot: snapshot.</description></item>
        /// <item><description>image: image.</description></item>
        /// <item><description>securitygroup: security group.</description></item>
        /// <item><description>volume: storage volume.</description></item>
        /// <item><description>eni: network interface controller (NIC).</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>keypair: SSH key pair.</description></item>
        /// <item><description>launchtemplate: launch template.</description></item>
        /// <item><description>reservedinstance: reserved instance.</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy.</description></item>
        /// </list>
        /// <para>All valid values are in lowercase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTagsRequestTag> Tag { get; set; }
        public class DescribeTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. The tag value cannot contain http:// or https://.</para>
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
