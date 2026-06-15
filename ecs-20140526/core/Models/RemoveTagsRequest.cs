// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RemoveTagsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource is located. Call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to get the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource from which to remove tags. For example, if ResourceType is set to instance, this parameter is the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-946ntx4****</para>
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
        /// <item><description><para>instance: an ECS instance.</para>
        /// </description></item>
        /// <item><description><para>disk: a disk.</para>
        /// </description></item>
        /// <item><description><para>snapshot: a snapshot.</para>
        /// </description></item>
        /// <item><description><para>image: an image.</para>
        /// </description></item>
        /// <item><description><para>securitygroup: a security group.</para>
        /// </description></item>
        /// <item><description><para>volume: a volume.</para>
        /// </description></item>
        /// <item><description><para>eni: an elastic network interface.</para>
        /// </description></item>
        /// <item><description><para>ddh: a dedicated host.</para>
        /// </description></item>
        /// <item><description><para>keypair: an SSH key pair.</para>
        /// </description></item>
        /// <item><description><para>launchtemplate: a launch template.</para>
        /// </description></item>
        /// <item><description><para>reservedinstance: a reserved instance.</para>
        /// </description></item>
        /// <item><description><para>snapshotpolicy: an automatic snapshot policy.</para>
        /// </description></item>
        /// </list>
        /// <para>All values must be in lowercase.</para>
        /// <para>This parameter is required.</para>
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
        public List<RemoveTagsRequestTag> Tag { get; set; }
        public class RemoveTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para>For compatibility, we recommend that you use the Tag.N.Key parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The value can be an empty string and up to 128 characters long. It cannot start with aliyun or acs:, and cannot contain http\:// or https\://.</para>
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
