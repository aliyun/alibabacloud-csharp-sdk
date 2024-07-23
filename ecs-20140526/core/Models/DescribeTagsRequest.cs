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
        /// <para>This parameter will be deprecated in the future. We recommend that you use other parameters to ensure future compatibility.</para>
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
        /// <para>The page number.</para>
        /// <para>Page starts from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to which the tags are added. If the resource is an instance, the value of this parameter is the ID of the instance.</para>
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
        /// <para>The type of the resource to which the tags are added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description>disk: disk.</description></item>
        /// <item><description>snapshot: snapshot.</description></item>
        /// <item><description>image: image.</description></item>
        /// <item><description>securitygroup: security group.</description></item>
        /// <item><description>volume: storage volume.</description></item>
        /// <item><description>eni: elastic network interface (ENI).</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>keypair: SSH key pair.</description></item>
        /// <item><description>launchtemplate: launch template.</description></item>
        /// <item><description>reservedinstance: reserved instance.</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy.</description></item>
        /// </list>
        /// <para>All values must be in lowercase letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTagsRequestTag> Tag { get; set; }
        public class DescribeTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the resource. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with acs: or aliyun. It cannot contain <a href="http://https://%E3%80%82">http:// or https://.</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the resource. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain <a href="http://https://%E3%80%82">http:// or https://.</a></para>
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
