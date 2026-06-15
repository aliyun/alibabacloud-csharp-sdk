// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the resource. This parameter takes effect only if you do not specify TagKey.N. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource IDs. Valid values of N: 1 to 50.</para>
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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance: ECS instance</para>
        /// </description></item>
        /// <item><description><para>disk: disk</para>
        /// </description></item>
        /// <item><description><para>snapshot: snapshot</para>
        /// </description></item>
        /// <item><description><para>image: image</para>
        /// </description></item>
        /// <item><description><para>securitygroup: security group</para>
        /// </description></item>
        /// <item><description><para>volume: storage volume</para>
        /// </description></item>
        /// <item><description><para>eni: elastic network interface (ENI)</para>
        /// </description></item>
        /// <item><description><para>ddh: dedicated host</para>
        /// </description></item>
        /// <item><description><para>ddhcluster: dedicated host cluster</para>
        /// </description></item>
        /// <item><description><para>keypair: SSH key pair</para>
        /// </description></item>
        /// <item><description><para>launchtemplate: launch template</para>
        /// </description></item>
        /// <item><description><para>reservedinstance: reserved instance</para>
        /// </description></item>
        /// <item><description><para>snapshotpolicy: automatic snapshot policy</para>
        /// </description></item>
        /// <item><description><para>elasticityassurance: elasticity assurance</para>
        /// </description></item>
        /// <item><description><para>capacityreservation: capacity reservation</para>
        /// </description></item>
        /// <item><description><para>command: Cloud Assistant command</para>
        /// </description></item>
        /// <item><description><para>invocation: Cloud Assistant command execution result</para>
        /// </description></item>
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
        /// <para>The tag keys. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKey</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
