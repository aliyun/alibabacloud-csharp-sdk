// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class JoinResourceGroupRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which you want to add the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. For example, if you set ResourceType to instance, set this parameter to the ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
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
        /// <para>The type of the ECS resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance: instance</para>
        /// </description></item>
        /// <item><description><para>disk: Elastic Block Storage (EBS) device</para>
        /// </description></item>
        /// <item><description><para>snapshot: snapshot</para>
        /// </description></item>
        /// <item><description><para>image: image</para>
        /// </description></item>
        /// <item><description><para>securitygroup: security group</para>
        /// </description></item>
        /// <item><description><para>ddh: dedicated host</para>
        /// </description></item>
        /// <item><description><para>ddhcluster: dedicated host cluster</para>
        /// </description></item>
        /// <item><description><para>eni: ENI</para>
        /// </description></item>
        /// <item><description><para>keypair: SSH key pair</para>
        /// </description></item>
        /// <item><description><para>launchtemplate: launch template</para>
        /// </description></item>
        /// <item><description><para>command: Cloud Assistant command</para>
        /// </description></item>
        /// <item><description><para>activation: activation code for a Cloud Assistant managed instance</para>
        /// </description></item>
        /// <item><description><para>managedinstance: Cloud Assistant managed instance</para>
        /// </description></item>
        /// </list>
        /// <para>The values are case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>securitygroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
