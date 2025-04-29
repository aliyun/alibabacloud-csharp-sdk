// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource IDs. You can specify up to 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The type of the resource to which the tags are added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance</description></item>
        /// <item><description>disk: disk</description></item>
        /// <item><description>snapshot: snapshot</description></item>
        /// <item><description>image: image</description></item>
        /// <item><description>securitygroup: security group</description></item>
        /// <item><description>volume: storage volume</description></item>
        /// <item><description>eni: ENI</description></item>
        /// <item><description>ddh: dedicated host</description></item>
        /// <item><description>ddhcluster: dedicated host cluster</description></item>
        /// <item><description>keypair: SSH key pair</description></item>
        /// <item><description>launchtemplate: launch template</description></item>
        /// <item><description>reservedinstance</description></item>
        /// <item><description>snapshotpolicy: automatic snapshot policy</description></item>
        /// <item><description>elasticityassurance: elasticity assurance</description></item>
        /// <item><description>capacityreservation: capacity reservation</description></item>
        /// <item><description>command: Cloud Assistant command</description></item>
        /// <item><description>invocation: Cloud Assistant command execution result or file delivery result</description></item>
        /// <item><description>activation: activation code for a Cloud Assistant managed instance</description></item>
        /// <item><description>managedinstance: Cloud Assistant managed instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the reserved instance. You can specify up to 20 tags. If you specify multiple tags, the tag keys cannot be duplicated.``</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key cannot be null or an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. The tag value cannot be null and can be an empty string. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
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
