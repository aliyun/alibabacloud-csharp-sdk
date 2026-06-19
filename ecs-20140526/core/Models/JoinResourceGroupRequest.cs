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
        /// <para>The region ID of the resource. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent list of regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. For example, when ResourceType is set to instance, ResourceId can be interpreted as the InstanceId.</para>
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
        /// <item><description>instance: instance.</description></item>
        /// <item><description>disk: block storage.</description></item>
        /// <item><description>snapshot: snapshot.</description></item>
        /// <item><description>image: image.</description></item>
        /// <item><description>securitygroup: security group.</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>ddhcluster: dedicated host cluster.</description></item>
        /// <item><description>eni: elastic network interface.</description></item>
        /// <item><description>keypair: SSH key pair.</description></item>
        /// <item><description>launchtemplate: launch template.</description></item>
        /// <item><description>command: Cloud Assistant command.</description></item>
        /// <item><description>activation: Cloud Assistant managed instance activation code.</description></item>
        /// <item><description>managedinstance: Cloud Assistant managed instance.</description></item>
        /// </list>
        /// <para>The preceding values are case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>securitygroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
