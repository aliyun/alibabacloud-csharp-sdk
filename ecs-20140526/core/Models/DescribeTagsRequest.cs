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
        /// <para>This parameter is deprecated. We recommend that you use other parameters to ensure compatibility.</para>
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
        /// <para>Starts from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to obtain the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. For example, if the <c>ResourceType</c> is <c>instance</c>, this parameter specifies the instance ID.</para>
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
        /// <item><description><para><c>instance</c>: an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><c>disk</c>: a disk.</para>
        /// </description></item>
        /// <item><description><para><c>snapshot</c>: a snapshot.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: an image.</para>
        /// </description></item>
        /// <item><description><para><c>securitygroup</c>: a security group.</para>
        /// </description></item>
        /// <item><description><para><c>volume</c>: a volume.</para>
        /// </description></item>
        /// <item><description><para><c>eni</c>: an elastic network interface.</para>
        /// </description></item>
        /// <item><description><para><c>ddh</c>: a dedicated host.</para>
        /// </description></item>
        /// <item><description><para><c>keypair</c>: an SSH key pair.</para>
        /// </description></item>
        /// <item><description><para><c>launchtemplate</c>: a launch template.</para>
        /// </description></item>
        /// <item><description><para><c>reservedinstance</c>: a reserved instance.</para>
        /// </description></item>
        /// <item><description><para><c>snapshotpolicy</c>: a snapshot policy.</para>
        /// </description></item>
        /// </list>
        /// <para>All values must be in lowercase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTagsRequestTag> Tag { get; set; }
        public class DescribeTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <remarks>
            /// <para>We recommend that you use the <c>Tag.N.Key</c> parameter to ensure compatibility.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length and can be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
